

Imports System.ComponentModel
Imports FLPExcel
Imports Georg
Public Class frmBrowser

    Private init As Boolean = False
    Private log As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSoftware.Click
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        'Dim strSQL As String = "SELECT * FROM test"
        'Dim rdr As Georg.IGEOrgReader = cmd.GetGeorgReader(DB.clsConnection.SYS, strSQL)
        'While rdr.Read
        '    Debug.Print(rdr.GetInt64(0) & rdr.GetString(1))
        'End While
        'rdr.Close()
        Dim dt = cmd.GetTable(DB.clsConnection.SYS, "software")
        dgvInhalt.DataSource = dt


    End Sub


    Private Sub cmdConnectoren_Click(sender As Object, e As EventArgs) Handles cmdConnectoren.Click
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim dt = cmd.GetTable(DB.clsConnection.SYS, "connectoren")
        dgvInhalt.DataSource = dt
    End Sub

    Private Sub cmdImpFile_Click(sender As Object, e As EventArgs) Handles cmdImpFile.Click
        txtImportfile.Text = Tools.GetFilenameFromDialog("Nutzungsbericht",, "Excel-Dateien (*.xlsx)|*.xlsx")
    End Sub

    Private Sub txtImportfile_TextChanged(sender As Object, e As EventArgs) Handles txtImportfile.TextChanged
        If txtImportfile.Text.Length > 0 Then
            init = False
            Dim sheets As List(Of String) = FLPExcel.clsExcelImport.openExcelExportFile(txtImportfile.Text)
            cbSheets.DataSource = sheets
        End If
    End Sub

    Private Sub cbSheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSheets.SelectedIndexChanged
        If init Then
            Dim selectedsheet As String = cbSheets.Items(cbSheets.SelectedIndex)
            Dim dt As Data.DataTable = FLPExcel.clsExcelImport.Excelfile2Datatable(selectedsheet, True)
            dgExcelcontent.DataSource = dt
            If cbUeberführen.Checked Then
                If MsgBox("Es werden die Daten für " & selectedsheet & " importiert. Ist das ok?", MsgBoxStyle.YesNo, "Import") = MsgBoxResult.Yes Then
                    Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
                    Dim anz As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select count(*) from usage where month='" & selectedsheet & "'")
                    If anz > 0 Then
                        If MsgBox("Es liegen im Zeitraum " & selectedsheet & " bereits " & anz & " Datensätze vor." & vbCrLf &
                               "Diese Datensätze werden vor dem Import gelöscht", MsgBoxStyle.YesNo, "Daten werden gelöscht!") = MsgBoxResult.Yes Then
                            cmd.ExecuteNonQueryOld("SYS", "delete from usage where month='" & selectedsheet & "'")
                        Else
                            MsgBox("Vorgang abgebrochen. Es wird nichts importiert. Bitte kontrollieren Sie die Daten", MsgBoxStyle.OkOnly, "Abbruch")
                            Return
                        End If
                    End If
                    ' BenutzerImport(dt)
                    'SubscriptionImport(dt)
                    UsageImport(dt, selectedsheet)
                End If
            Else
                Return
            End If
            If log Then
                Tools.clsLogfile.CloseLogFile()
                MsgBox("Logdatei erstellt. Diese finden Sie unter " & "c:\tmp\ImportFehler\" & System.Environment.UserName, MsgBoxStyle.Information, "Fehler gefunden!")
            End If
        Else
            init = True
        End If
    End Sub

    Private Sub BenutzerImport(dt As DataTable)
        Dim zaehler As Integer = 0
        For Each excelrow As DataRow In dt.Rows
            Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
            If Not Userexist(excelrow("email")) Then
                cmd.ExecuteNonQueryOld("SYS", "insert into benutzer(first_name,last_name,email,autodesk_id,team_name,group_name)
                                                    values('" & excelrow("first_name") & "','" &
                                            excelrow("last_name") & "','" &
                                            excelrow("email") & "','" &
                                            excelrow("autodesk_id") & "','" &
                                            excelrow("team_alias") & "','" &
                                            excelrow("group") & "')")
                zaehler += 1
            End If
            cmd = Nothing
        Next
        MsgBox("Es wurden " & zaehler & " neue Benutzer in die Datenbank überführt", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub

    Private Sub SubscriptionImport(dt As DataTable)
        Dim updatezaehler As Integer = 0
        Dim insertzaehler As Integer = 0
        For Each excelrow As DataRow In dt.Rows
            If excelrow("access_option") = "Subscription" Then
                If Userexist(excelrow("email")) Then
                    Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
                    Dim UID As Integer = UserID(excelrow("email"))
                    Dim anz1 As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select count(*) from subscription where userid=" & UID & " and product='" &
                                                                      excelrow("offering_name") & "'")
                    If anz1 > 0 Then
                        Dim id1 As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select id from subscription where userid=" & UID & " and product='" &
                                                                      excelrow("offering_name") & "'")
                        cmd.ExecuteNonQueryOld("SYS", "update subscription set " &
                                               "assigndate=" & getDatestring(excelrow("assigned_date")) & "," &
                                               "unassigndate=" & getDatestring(excelrow("unassigned_date")) & "," &
                                               "seat_assignment='" & excelrow("seat_assignment") & "' " &
                                               "where id=" & id1)
                        updatezaehler += 1
                    Else
                        cmd.ExecuteNonQueryOld("SYS", "insert into subscription (userid,product,assigndate,unassigndate,seat_assignment) values(" &
                                                      UID & ",'" &
                                                      excelrow("offering_name") & "'," &
                                                      getDatestring(excelrow("assigned_date")) & "," &
                                                      getDatestring(excelrow("unassigned_date")) & ",'" &
                                                      excelrow("seat_assignment") & "')")
                        insertzaehler += 1
                    End If
                    cmd = Nothing
                End If
            End If
        Next
        MsgBox("Es wurden " & updatezaehler & " Subscriptions aktualisiert" & vbCrLf &
               "Insgesamt wurden " & insertzaehler & " neue Subscriptions angelegt", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub

    Private Sub UsageImport(dt As DataTable, monat As String)
        Dim insertzaehler As Integer = 0
        For Each excelrow As DataRow In dt.Rows
            If Userexist(excelrow("email")) Then
                Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
                Dim UID As Integer = UserID(excelrow("email"))
                cmd.ExecuteNonQueryOld("SYS", "insert into usage (userid,month,product,access_option,day_used,monthly_average,token_used,last_accessed) values(" &
                                                           UID & ",'" &
                                                           monat & "','" &
                                                           excelrow("offering_name") & "','" &
                                                           excelrow("access_option") & "'," &
                                                           getIntegervalue(excelrow("days_used")) & "," &
                                                           getDoublevalue(Replace(excelrow("monthly_average"), ",", ".")) & "," &
                                                           getIntegervalue(excelrow("tokens_used")) & "," &
                                                          getDatestring(excelrow("last_accessed")) & ")")
                insertzaehler += 1
                cmd = Nothing
            Else
                log = True
                Tools.clsLogfile.LogInfo("Benutzer:" & excelrow("first_name") & excelrow("last_name") & " fehlt in der Benutzertabelle")
            End If
        Next
        MsgBox("Es wurden " & "Insgesamt wurden " & insertzaehler & " neue Datensätze importiert", MsgBoxStyle.OkOnly, "Abgeschlossen!")

    End Sub

    Private Function getDatestring(datum As Object) As String
        If Len(datum.ToString) = 0 Then
            Return "null"
        Else
            Return "'" & datum.ToString & "'"
        End If
    End Function

    Private Function getIntegervalue(value As Object) As Integer
        If Len(value.ToString) = 0 Then
            Return 0
        Else
            Return CInt(value)
        End If
    End Function

    Private Function getDoublevalue(value As Object) As String
        If Len(value.ToString) = 0 Then
            Return "0.0"
        Else
            Return value.ToString
        End If
    End Function

    Private Function Userexist(email As String) As Boolean
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim retVal As Boolean = False
        Dim anz As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select count(*) from benutzer where email='" & email & "'")
        If anz > 0 Then retVal = True
        Return retVal
    End Function

    Private Function UserID(email As String) As Integer
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Return cmd.ExecuteScalarSlowAndOld("SYS", "select id from benutzer where email='" & email & "'")
    End Function


    Private Sub frmBrowser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FLPExcel.clsExcelImport.CloseExcel()
    End Sub

    'Private Sub cbUeberführen_CheckedChanged(sender As Object, e As EventArgs) Handles cbUeberführen.CheckedChanged
    '    If cbUeberführen.Checked AndAlso init Then

    '    Else

    '    End If
    'End Sub
End Class