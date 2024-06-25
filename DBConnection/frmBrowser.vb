

Imports System.ComponentModel
Imports FLPExcel
Imports Georg
Public Class frmBrowser

    Private init As Boolean = False
    Private log As Boolean = False
    Private Const C_None As String = "<none>"

    Private Sub frmBrowser_Load(sender As Object, e As EventArgs) Handles Me.Load
        tabMain.SelectedTab = tpBenutzer
        TabTabellen.Visible = False
        Me.Text = "Lizenzanalyse Autodesk 1.0"
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)

        Dim BenutzerTeams As DataTable = cmd.GetTableFromSelect("SYS", "select distinct team_name from benutzer")
        cbUserTeam.Items.Add(C_None)
        For Each dr As DataRow In BenutzerTeams.Rows
            cbUserTeam.Items.Add(dr(0))
        Next
        cbUserTeam.SelectedIndex = 0

        Dim BenutzerGruppen As DataTable = cmd.GetTableFromSelect("SYS", "select distinct group_name from benutzer order by group_name")
        cbUserGruppe.Items.Add(C_None)
        For Each dr As DataRow In BenutzerGruppen.Rows
            cbUserGruppe.Items.Add(dr(0))
        Next
        cbUserGruppe.SelectedIndex = 0

        Dim SubBenutzer As DataTable = cmd.GetTableFromSelect("SYS", "select first_name,last_name from benutzer order by last_name")
        cbSubBenutzer.Items.Add(C_None)
        For Each dr As DataRow In SubBenutzer.Rows
            cbSubBenutzer.Items.Add(dr("last_name") & ", " & dr("first_name"))
        Next
        cbSubBenutzer.SelectedIndex = 0

        Dim Subtimes As DataTable = cmd.GetTableFromSelect("SYS", "select distinct month from vusage order by month")
        cbSubMonat.Items.Add(C_None)
        For Each dr As DataRow In Subtimes.Rows
            cbSubMonat.Items.Add(dr(0))
        Next
        cbSubMonat.SelectedIndex = 0

        Dim LicBenutzer As DataTable = cmd.GetTableFromSelect("SYS", "select first_name,last_name from benutzer order by last_name")
        cbLizenzBenutzer.Items.Add(C_None)
        For Each dr As DataRow In LicBenutzer.Rows
            cbLizenzBenutzer.Items.Add(dr("last_name") & ", " & dr("first_name"))
        Next
        cbLizenzBenutzer.SelectedIndex = 0

        Dim Lictimes As DataTable = cmd.GetTableFromSelect("SYS", "select distinct month from vsubscription order by month")
        cbLizenzMonat.Items.Add(C_None)
        For Each dr As DataRow In Lictimes.Rows
            cbLizenzMonat.Items.Add(dr(0))
        Next
        cbLizenzMonat.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSoftware.Click
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
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
                    BenutzerImport(dt)
                    SubscriptionImport(dt, selectedsheet)
                    UsageImport(dt, selectedsheet)
                End If
            Else
                MsgBox("Import abgebrochen. Programm wird beendet", MsgBoxStyle.OkOnly, "Programmabbruch")
                Application.Exit()
            End If
            If log Then
                Tools.clsLogfile.CloseLogFile()
                MsgBox("Logdatei erstellt. Diese finden Sie unter " & "c:\tmp\ImportFehler\" & System.Environment.UserName, MsgBoxStyle.Information, "Fehler gefunden!")
            End If
            MsgBox("Import erfolgreich abgeschlossen. Programm wird beendet", MsgBoxStyle.OkOnly, "Programmende")
            Application.Exit()
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

    Private Sub SubscriptionImport(dt As DataTable, monat As String)
        Dim updatezaehler As Integer = 0
        Dim insertzaehler As Integer = 0
        For Each excelrow As DataRow In dt.Rows
            If excelrow("access_option") = "Subscription" Then
                If Userexist(excelrow("email")) Then
                    Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
                    Dim UID As Integer = UserID(excelrow("email"))
                    cmd.ExecuteNonQueryOld("SYS", "insert into subscription (userid,offering_name,assigned_date,unassigned_date," &
                                           "seat_assignment,user_activity,days_inactive,month) values(" &
                                           UID & ",'" &
                                           excelrow("offering_name") & "'," &
                                           getDatestring(excelrow("assigned_date")) & "," &
                                           getDatestring(excelrow("unassigned_date")) & ",'" &
                                           excelrow("seat_assignment") & "','" &
                                           excelrow("user_activity") & "'," &
                                           getIntegervalue(excelrow("days_inactive")) & ",'" &
                                           monat & "')")
                    insertzaehler += 1
                    'End If
                    cmd = Nothing
                End If
            End If
        Next
        MsgBox("Insgesamt wurden " & insertzaehler & " neue Subscriptions angelegt", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub

    Private Sub UsageImport(dt As DataTable, monat As String)
        Dim insertzaehler As Integer = 0
        For Each excelrow As DataRow In dt.Rows
            If Userexist(excelrow("email")) Then
                Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
                Dim UID As Integer = UserID(excelrow("email"))
                cmd.ExecuteNonQueryOld("SYS", "insert into usage (userid,month,offering_name,access_option,days_used,monthly_average,tokens_used,last_accessed) values(" &
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

    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Dim fn As String = Tools.GetFilenameFromDialog("Bilddatei",, "Bild-Dateien (*.jpg)|*.jpg")
        Dim img As Byte() = Tools.File2Bytes(fn)
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)

        Dim params As New DB.postgreSQLParams

        params.AddString("name", "Profilbild")
        params.AddString("beschreibung", "Stefan Rohr")
        params.AddBlob("image", img)
        Try
            cmd.ExecuteScalar("SYS", "insert into software(name, beschreibung, image) values(@name,@beschreibung,@image)", params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        Dim filename As String = "D:\Downloads\test.jpg"
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim params As New DB.postgreSQLParams
        Dim img As Byte() = Nothing
        params.AddBlob("image", img)
        Try
            img = cmd.ExecuteScalarSlowAndOld("SYS", "select image from software where id=4")
            Tools.Bytes2File(img, filename)

            Dim b As New Bitmap(Tools.Bytes2Stream(img))
            Dim i As Image = Image.FromStream(Tools.Bytes2Stream(img))

            Process.Start(filename)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cbSubBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubBenutzer.SelectedIndexChanged, cbSubMonat.SelectedIndexChanged
        If cbSubBenutzer.Items.Count = 0 Or cbSubMonat.Items.Count = 0 Then Return
        Dim selectedUser As String = cbSubBenutzer.SelectedItem.ToString
        Dim selectedMonth As String = cbSubMonat.SelectedItem.ToString
        Dim VorNachname As String() = Split(selectedUser, ", ")
        Dim Vorname As String = ""
        Dim Nachname As String = ""
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        If selectedUser <> C_None Then
            If VorNachname.Count = 2 Then
                If selectedMonth <> C_None Then
                    Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vsubscription where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "'" &
                                                                 " and month='" & selectedMonth & "' order by produkt")
                    dgvSubsriptions.DataSource = dt
                Else
                    Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vsubscription where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "' order by produkt")
                    dgvSubsriptions.DataSource = dt
                End If
            End If
        Else
            If selectedMonth <> C_None Then
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vsubscription where monat='" & selectedMonth & "' order by email")
                dgvSubsriptions.DataSource = dt
            Else
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vsubscription order by email,month")
                dgvSubsriptions.DataSource = dt
            End If
        End If
    End Sub

    Private Sub cbUserTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUserTeam.SelectedIndexChanged, cbUserGruppe.SelectedIndexChanged
        If cbUserGruppe.Items.Count = 0 Then Return
        If cbUserTeam.Items.Count = 0 Then Return
        Dim selectedTeam As String = cbUserTeam.SelectedItem.ToString
        Dim selectedGroup As String = cbUserGruppe.SelectedItem.ToString
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        If selectedTeam <> C_None Then
            If selectedGroup <> C_None Then
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from benutzer where team_name='" & selectedTeam &
                                                             "' and group_name='" & selectedGroup & "' order by group_name")
                dgvBenutzer.DataSource = dt
            Else
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from benutzer where team_name='" & selectedTeam & "' order by team_name")
                dgvBenutzer.DataSource = dt
            End If
        Else
            If selectedGroup <> C_None Then
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from benutzer where group_name='" & selectedGroup & "' order by group_name")
                dgvBenutzer.DataSource = dt
            Else
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from benutzer order by email")
                dgvBenutzer.DataSource = dt
            End If
        End If
    End Sub

    Private Sub cbLizenzBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLizenzBenutzer.SelectedIndexChanged, cbLizenzMonat.SelectedIndexChanged
        If cbLizenzBenutzer.Items.Count = 0 Or cbLizenzMonat.Items.Count = 0 Then Return
        Dim selectedUser As String = cbLizenzBenutzer.SelectedItem.ToString
        Dim selectedMonth As String = cbLizenzMonat.SelectedItem.ToString
        Dim VorNachname As String() = Split(selectedUser, ", ")
        Dim Vorname As String = ""
        Dim Nachname As String = ""
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)

        If selectedUser <> C_None Then
            If VorNachname.Count = 2 Then
                If selectedMonth <> C_None Then
                    Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vusage where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "'" &
                                                                 " and month='" & selectedMonth & "' order by produkt")
                    dgvLizenznutzung.DataSource = dt
                Else
                    Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vusage where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "' order by produkt")
                    dgvLizenznutzung.DataSource = dt
                End If
            End If
        Else
            If selectedMonth <> C_None Then
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vusage where monat='" & selectedMonth & "' order by email")
                dgvLizenznutzung.DataSource = dt
            Else
                Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from vusage order by email,month")
                dgvLizenznutzung.DataSource = dt
            End If
        End If

    End Sub
End Class