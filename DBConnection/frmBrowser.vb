﻿

Imports System.ComponentModel
Imports ABI.Windows.ApplicationModel.Activation
Imports FLPExcel
Imports Georg
Public Class frmBrowser

    Private init As Boolean = False
    Private log As Boolean = False
    Private Const C_None As String = "<none>"
    Private titel As String = "Lizenzanalyse Autodesk 1.0"

#Region "Eventhandler"

    Private Sub frmBrowser_Load(sender As Object, e As EventArgs) Handles Me.Load
        tabMain.TabPages.Remove(TabTabellen)
        'tabMain.TabPages.Remove(tpSubscritions)
        'tabMain.TabPages.Remove(tpLizenznutzung)

        Me.Text = titel
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)

        Dim BenutzerTeams As DataTable = cmd.GetTableFromSelect("SYS", "select distinct team_name from benutzer")
        cbUserTeam.Items.Add(C_None)
        cbNutzTeam.Items.Add(C_None)
        For Each dr As DataRow In BenutzerTeams.Rows
            cbUserTeam.Items.Add(dr(0))
            cbNutzTeam.Items.Add(dr(0))
        Next
        cbUserTeam.SelectedIndex = 0
        cbNutzTeam.SelectedIndex = 0

        Dim BenutzerGruppen As DataTable = cmd.GetTableFromSelect("SYS", "select distinct group_name from benutzer order by group_name")
        cbUserGruppe.Items.Add(C_None)
        cbNutzGruppe.Items.Add(C_None)
        For Each dr As DataRow In BenutzerGruppen.Rows
            cbUserGruppe.Items.Add(dr(0))
            cbNutzGruppe.Items.Add(dr(0))
        Next
        cbUserGruppe.SelectedIndex = 0
        cbNutzGruppe.SelectedIndex = 0

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

        Dim NutzMonat As DataTable = cmd.GetTableFromSelect("SYS", "select distinct to_char(day_used, 'YYYY-MM') from vnutzung order by to_char(day_used, 'YYYY-MM')")
        cbNutzMonat.Items.Add(C_None)
        For Each dr As DataRow In NutzMonat.Rows
            cbNutzMonat.Items.Add(dr(0))
        Next
        cbNutzMonat.SelectedIndex = 0

        Dim NutzProdukt As DataTable = cmd.GetTableFromSelect("SYS", "select distinct offering_name from vnutzung order by offering_name")
        cbNutzProdukt.Items.Add(C_None)
        For Each dr As DataRow In NutzProdukt.Rows
            cbNutzProdukt.Items.Add(dr(0))
        Next
        cbNutzProdukt.SelectedIndex = 0

        Dim AbosProdukt As DataTable = cmd.GetTableFromSelect("SYS", "select distinct offering_name from abonnements order by offering_name")
        cbAbosProdukt.Items.Add(C_None)
        For Each dr As DataRow In AbosProdukt.Rows
            cbAbosProdukt.Items.Add(dr(0))
        Next
        cbAbosProdukt.SelectedIndex = 0

        Dim NutzZugriff As DataTable = cmd.GetTableFromSelect("SYS", "select distinct access_option from vnutzung")
        cbNutzAccess.Items.Add(C_None)
        For Each dr As DataRow In NutzZugriff.Rows
            cbNutzAccess.Items.Add(dr(0))
        Next
        cbNutzAccess.SelectedIndex = 0

        Dim Lictimes As DataTable = cmd.GetTableFromSelect("SYS", "select distinct month from vsubscription order by month")
        cbLizenzMonat.Items.Add(C_None)
        For Each dr As DataRow In Lictimes.Rows
            cbLizenzMonat.Items.Add(dr(0))
        Next
        cbLizenzMonat.SelectedIndex = 0

        Dim LizenzGruppe As DataTable = cmd.GetTableFromSelect("SYS", "select distinct gruppe from vusage order by gruppe")
        cbLizenzGruppe.Items.Add(C_None)
        For Each dr As DataRow In LizenzGruppe.Rows
            cbLizenzGruppe.Items.Add(dr(0))
        Next
        cbLizenzGruppe.SelectedIndex = 0

        Dim LizenzAbteilung As DataTable = cmd.GetTableFromSelect("SYS", "select distinct abteilung from vusage order by abteilung")
        cbLizenzAbteilung.Items.Add(C_None)
        For Each dr As DataRow In LizenzAbteilung.Rows
            cbLizenzAbteilung.Items.Add(dr(0))
        Next
        cbLizenzAbteilung.SelectedIndex = 0

        Dim LizenzProdukt As DataTable = cmd.GetTableFromSelect("SYS", "select distinct produkt from vusage order by produkt")
        cbLizenzProdukt.Items.Add(C_None)
        For Each dr As DataRow In LizenzProdukt.Rows
            cbLizenzProdukt.Items.Add(dr(0))
        Next
        cbLizenzProdukt.SelectedIndex = 0

        Dim LizenzZugriff As DataTable = cmd.GetTableFromSelect("SYS", "select distinct access_option from vusage")
        cbLizenzZugriff.Items.Add(C_None)
        For Each dr As DataRow In LizenzZugriff.Rows
            cbLizenzZugriff.Items.Add(dr(0))
        Next
        cbLizenzZugriff.SelectedIndex = 0




        tabMain.SelectedTab = tpBenutzer

    End Sub

    Private Sub cmdBerichtToken_Click(sender As Object, e As EventArgs) Handles cmdBerichtToken.Click
        CreateReport4Token()
    End Sub

    Private Sub cmdBerichtAEC_Click(sender As Object, e As EventArgs) Handles cmdBerichtAEC.Click
        CreateReport4AEC()
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
                Select Case selectedsheet.ToLower
                    Case "abteilung"
                        BenutzerAbteilungsImport(dt)
                    Case "benutzer"
                        BenutzerGrundImport(dt)
                    Case "benutzer_mit_gruppe"
                        BenutzerGruppenImport(dt)
                    Case "nutzung"
                        NutzungsImport(dt)
                    Case "abonnements"
                        AbonnementImport(dt)
                    Case "vdi user"
                        BenutzerVDIAbgleich(dt)
                    Case Else
                        If MsgBox("Es werden die Daten für " & selectedsheet & " importiert. Ist das ok?", MsgBoxStyle.YesNo, "Import") = MsgBoxResult.Yes Then
                            Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
                            Dim anz As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select count(*) from usage where month='" & selectedsheet & "'")
                            If anz > 0 Then
                                If MsgBox("Es liegen im Zeitraum " & selectedsheet & " bereits " & anz & " Datensätze vor." & vbCrLf &
                                       "Diese Datensätze werden vor dem Import gelöscht", MsgBoxStyle.YesNo, "Daten werden gelöscht!") = MsgBoxResult.Yes Then
                                    cmd.ExecuteNonQueryOld("SYS", "delete from usage where month='" & selectedsheet & "'")
                                    cmd.ExecuteNonQueryOld("SYS", "delete from subscription where month='" & selectedsheet & "'")
                                Else
                                    MsgBox("Vorgang abgebrochen. Es wird nichts importiert. Bitte kontrollieren Sie die Daten", MsgBoxStyle.OkOnly, "Abbruch")
                                    Return
                                End If
                            End If
                            BenutzerImport(dt)
                            SubscriptionImport(dt, selectedsheet)
                            UsageImport(dt, selectedsheet)
                        Else
                            MsgBox("Import abgebrochen. Programm wird beendet", MsgBoxStyle.OkOnly, "Programmabbruch")
                            Application.Exit()
                        End If
                End Select
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

    Private Sub frmBrowser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FLPExcel.clsExcelImport.CloseExcel()
    End Sub

#Region "Beispiel Prozess"

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from prozesse")
        cbProzesse.Items.Add(C_None)
        For Each row As DataRow In dt.Rows
            cbProzesse.Items.Add(row("prozessbeschreibung"))
        Next
        cbProzesse.SelectedIndex = 0
    End Sub

    Private Sub cbProzesse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProzesse.SelectedValueChanged
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim prozessID As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select prozessid from prozesse where prozessbeschreibung='" & cbProzesse.SelectedItem.ToString & "'")
        MsgBox("prozessID=" & prozessID)
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
        Dim filename = "D:\Downloads\test.jpg"
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim params As New DB.postgreSQLParams
        Dim img As Byte() = Nothing
        params.AddBlob("image", img)
        Try
            img = cmd.ExecuteScalarSlowAndOld("SYS", "select image from software where id=4")
            Tools.Bytes2File(img, filename)

            Dim b As New Bitmap(Tools.Bytes2Stream(img))
            Dim i = Image.FromStream(Tools.Bytes2Stream(img))

            Process.Start(filename)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#End Region

#Region "Monatsberichte"

    Private Sub CreateReport4Token()
        Dim access_option As String = "'Tokens'"
        Dim Monat As String = cbNutzMonat.SelectedItem
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim strsql As String = "select * from vnutzung where access_option=" & access_option &
                                " and to_char(day_used, 'YYYY-MM')='" & Monat & "'"
        Dim dt As DataTable = cmd.GetTableFromSelect("SYS", strsql)
        Dim lBenutzer As New Dictionary(Of String, String)
        Dim lTokens As New Dictionary(Of String, Integer)
        For Each row As DataRow In dt.Rows
            If Not lBenutzer.Keys.Contains(row("email").ToString) Then
                lBenutzer.Add(row("email").ToString, row("gruppe").ToString)
                If Not lTokens.ContainsKey(row("gruppe").ToString) Then
                    lTokens.Add(row("gruppe").ToString, 1)
                Else
                    Dim Anzahl As Integer = lTokens(row("gruppe").ToString)
                    lTokens(row("gruppe").ToString) = Anzahl + CInt(row("tokens_used"))
                End If
            End If
        Next
        Dim dtToken As DataTable = New DataTable
        Tools.CreateColumn(dtToken, "Gruppe", Tools.modTablesAndRows.eColumnFormat.Zeichen, False, False)
        Tools.CreateColumn(dtToken, "Lizenzen/Email", Tools.modTablesAndRows.eColumnFormat.Zeichen, False, False)
        Dim usedLicenes As Integer = 0
        For Each kvp As KeyValuePair(Of String, Integer) In lTokens
            dtToken.Rows.Add(kvp.Key, kvp.Value)
            usedLicenes += kvp.Value
        Next
        dtToken.Rows.Add("Genutzte Tokens in " & Monat & ":", usedLicenes.ToString)
        dtToken.Rows.Add("", "")
        dtToken.Rows.Add("", "")
        For Each kvp As KeyValuePair(Of String, String) In lBenutzer
            dtToken.Rows.Add(kvp.Value, kvp.Key)
        Next
        dgvToken.DataSource = dtToken
        tabMain.SelectedTab = tpToken
    End Sub


    Private Sub CreateReport4AEC()
        Dim offering_name As String = "'Architecture Engineering & Construction Collection'"
        Dim access_option As String = "'Seats'"
        Dim Monat As String = cbNutzMonat.SelectedItem
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim strsql As String = "select * from vnutzung where offering_name=" & offering_name & " and access_option=" & access_option &
                                " and to_char(day_used, 'YYYY-MM')='" & Monat & "'"
        Dim dt As DataTable = cmd.GetTableFromSelect("SYS", strsql)
        Dim lBenutzer As New Dictionary(Of String, String)
        Dim lLizenzen As New Dictionary(Of String, Integer)
        For Each row As DataRow In dt.Rows
            If Not lBenutzer.Keys.Contains(row("email").ToString) Then
                lBenutzer.Add(row("email").ToString, row("gruppe").ToString)
                If Not lLizenzen.ContainsKey(row("gruppe").ToString) Then
                    lLizenzen.Add(row("gruppe").ToString, 1)
                Else
                    Dim Anzahl As Integer = lLizenzen(row("gruppe").ToString)
                    lLizenzen(row("gruppe").ToString) = Anzahl + 1
                End If
            End If
        Next
        Dim dtAEC As DataTable = New DataTable
        Tools.CreateColumn(dtAEC, "Gruppe", Tools.modTablesAndRows.eColumnFormat.Zeichen, False, False)
        Tools.CreateColumn(dtAEC, "Lizenzen/Email", Tools.modTablesAndRows.eColumnFormat.Zeichen, False, False)
        Dim usedLicenes As Integer = 0
        For Each kvp As KeyValuePair(Of String, Integer) In lLizenzen
            dtAEC.Rows.Add(kvp.Key, kvp.Value)
            usedLicenes += kvp.Value
        Next
        dtAEC.Rows.Add("Genutzte Lizenzen in " & Monat & ":", usedLicenes.ToString)
        dtAEC.Rows.Add("", "")
        dtAEC.Rows.Add("", "")
        For Each kvp As KeyValuePair(Of String, String) In lBenutzer
            dtAEC.Rows.Add(kvp.Value, kvp.Key)
        Next
        dgvAEC.DataSource = dtAEC
        tabMain.SelectedTab = tpAEC
    End Sub


#End Region

#Region "Importmethoden"

    Private Sub BenutzerVDIAbgleich(dt As DataTable)
        Dim zaehler As Integer = 0
        Dim Nichtgefunden As String = ""
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        For Each excelrow As DataRow In dt.Rows
            If Userexist(excelrow("Assigned User").ToString) Then
                Dim ids As List(Of Integer) = UserIDs(excelrow("Assigned User"))
                For Each id In ids
                    Dim strsql As String = "update benutzer set " &
                                            "vdi_machine='" & excelrow("Machine") & "'," &
                                            "vdi_user='true'" &
                                            " where id=" & id
                    cmd.ExecuteNonQueryOld("SYS", strsql)
                    zaehler += 1
                Next
            Else
                If Len(excelrow("Assigned User").ToString) > 0 Then
                    log = True
                    Tools.clsLogfile.LogEmpty(excelrow("Assigned User").ToString & ";" & excelrow("Machine").ToString)
                End If
            End If
        Next
        MsgBox("Es wurden " & zaehler & " Benutzer in der Datenbank aktualisiert", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub

    Private Sub BenutzerGruppenImport(dt As DataTable)
        Dim zaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        For Each excelrow As DataRow In dt.Rows
            If Userexist(excelrow("email"), excelrow("team_name")) Then
                Dim id As Integer = UserID(excelrow("email"), excelrow("team_name"))
                If id > 0 Then
                    Dim strsql As String = "update benutzer set " &
                                            "group_name='" & excelrow("group_name") & "' where id=" & id
                    cmd.ExecuteNonQueryOld("SYS", strsql)
                    zaehler += 1
                End If
            End If
        Next
        MsgBox("Es wurden " & zaehler & " Benutzer in der Datenbank aktualisiert", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub

    Private Sub BenutzerAbteilungsImport(dt As DataTable)
        Dim zaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        For Each excelrow As DataRow In dt.Rows
            Dim strsql As String = "update benutzer set " &
                                        "abteilung='" & excelrow("abteilung") & "' where first_name='" & excelrow("Vorname") & "'" &
                                        " and last_name='" & excelrow("Nachname") & "'"
            zaehler += cmd.ExecuteNonQueryOld("SYS", strsql)
        Next
        MsgBox("Es wurden " & zaehler & " Benutzer in der Datenbank aktualisiert", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub


    Private Sub BenutzerImport(dt As DataTable)
        Dim zaehler As Integer = 0
        Dim updatezaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        For Each excelrow As DataRow In dt.Rows
            If Not Userexist(excelrow("email"), excelrow("team_alias")) Then
                cmd.ExecuteNonQueryOld("SYS", "insert into benutzer(first_name,last_name,email,autodesk_id,team_name,group_name)
                                                    values('" & excelrow("first_name") & "','" &
                                            excelrow("last_name") & "','" &
                                            excelrow("email") & "','" &
                                            excelrow("autodesk_id") & "','" &
                                            excelrow("team_alias") & "','" &
                                            excelrow("group") & "')")
                zaehler += 1
            Else
                Dim id As Integer = UserID(excelrow("email"), excelrow("team_alias"))
                If id > 0 Then
                    Dim strsql As String = "update benutzer set " &
                                            "first_name='" & excelrow("first_name") & "'," &
                                            "last_name='" & excelrow("last_name") & "'," &
                                            "email='" & excelrow("email") & "'," &
                                            "autodesk_id='" & excelrow("autodesk_id") & "'," &
                                            "team_name='" & excelrow("team_alias") & "'," &
                                            "group_name='" & excelrow("group") & "' where id=" & id
                    cmd.ExecuteNonQueryOld("SYS", strsql)
                    updatezaehler += 1
                End If
            End If
        Next
        MsgBox("Es wurden " & zaehler & " neue Benutzer in die Datenbank überführt, sowie " & updatezaehler &
               " Benutzer aktualisiert", MsgBoxStyle.OkOnly, "Benutzerimport abgeschlossen!")
    End Sub

    Private Sub BenutzerGrundImport(dt As DataTable)
        Dim zaehler As Integer = 0
        Dim updatezaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim userlist As New List(Of String)
        For Each excelrow As DataRow In dt.Rows
            If Not userlist.Contains(excelrow("email")) Then
                userlist.Add(excelrow("email"))
                If Not Userexist(excelrow("email"), excelrow("team_alias")) Then
                    Dim strsql As String = "insert into benutzer(first_name,last_name,email,autodesk_id,team_name,role,account_status)
                                                    values('" & excelrow("first_name") & "','" &
                                                    excelrow("last_name") & "','" &
                                                    excelrow("email") & "','" &
                                                    excelrow("autodesk_id") & "','" &
                                                    excelrow("team_alias") & "','" &
                                                    excelrow("role") & "','" &
                                                    excelrow("account_Status") & "')"
                    cmd.ExecuteNonQueryOld("SYS", strsql)
                    zaehler += 1
                Else
                    Dim id As Integer = UserID(excelrow("email"), excelrow("team_alias"))
                    If id > 0 Then
                        Dim strsql As String = "update benutzer set " &
                                            "first_name='" & excelrow("first_name") & "'," &
                                            "last_name='" & excelrow("last_name") & "'," &
                                            "email='" & excelrow("email") & "'," &
                                            "autodesk_id='" & excelrow("autodesk_id") & "'," &
                                            "team_name='" & excelrow("team_alias") & "'," &
                                            "role='" & excelrow("role") & "'," &
                                            "account_status='" & excelrow("account_status") & "' where id=" & id
                        cmd.ExecuteNonQueryOld("SYS", strsql)
                        updatezaehler += 1
                    End If
                End If
            End If
        Next
        MsgBox("Es wurden " & zaehler & " neue Benutzer in die Datenbank überführt sowie " &
               updatezaehler & " Benutzerdaten aktualisiert.", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub


    Private Sub SubscriptionImport(dt As DataTable, monat As String)
        Dim updatezaehler As Integer = 0
        Dim insertzaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        For Each excelrow As DataRow In dt.Rows
            If excelrow("access_option") = "Subscription" Then
                If Userexist(excelrow("email"), excelrow("team_alias")) Then
                    Dim UID As Integer = UserID(excelrow("email"), excelrow("team_alias"))
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
                End If
            End If
        Next
        cmd = Nothing
        MsgBox("Insgesamt wurden " & insertzaehler & " neue Subscriptions angelegt", MsgBoxStyle.OkOnly, "Subsciptionimport abgeschlossen!")
    End Sub

    Private Sub UsageImport(dt As DataTable, monat As String)
        Dim insertzaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        For Each excelrow As DataRow In dt.Rows
            If Userexist(excelrow("email"), excelrow("team_alias")) Then
                Dim UID As Integer = UserID(excelrow("email"), excelrow("team_alias"))
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
            Else
                log = True
                Tools.clsLogfile.LogInfo("Benutzer:" & excelrow("first_name") & excelrow("last_name") & " fehlt in der Benutzertabelle")
            End If
        Next
        cmd = Nothing
        MsgBox("Es wurden " & "Insgesamt wurden " & insertzaehler & " neue Datensätze importiert", MsgBoxStyle.OkOnly, "Nutzungszahlenimport abgeschlossen!")

    End Sub

    Private Sub NutzungsImport(dt As DataTable)
        Dim insertzaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        cmd.ExecuteNonQueryOld("SYS", "truncate nutzung")
        For Each excelrow As DataRow In dt.Rows
            If Userexist(excelrow("email"), excelrow("team_alias")) Then
                Dim UID As Integer = UserID(excelrow("email"), excelrow("team_alias"))
                Dim strSql As String = "insert into nutzung (userid,offering_name,product_name,version,day_used,tokens_used,access_option) values(" &
                                                           UID & ",'" &
                                                           excelrow("offering_name") & "','" &
                                                           excelrow("product_name") & "','" &
                                                           excelrow("version") & "'," &
                                                           getDatestring(excelrow("day_used")) & ",'" &
                                                           excelrow("tokens_used") & "','" &
                                                           excelrow("access_option") & "')"
                cmd.ExecuteNonQueryOld("SYS", strSql)
                insertzaehler += 1
            Else
                log = True
                Tools.clsLogfile.LogInfo("Benutzer:" & excelrow("first_name") & excelrow("last_name") & " fehlt in der Benutzertabelle")
            End If
        Next
        cmd = Nothing
        MsgBox("Es wurden " & "Insgesamt wurden " & insertzaehler & " neue Datensätze importiert", MsgBoxStyle.OkOnly, "Abgeschlossen!")
    End Sub

    Private Sub AbonnementImport(dt As DataTable)
        Dim insertzaehler As Integer = 0
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        cmd.ExecuteNonQueryOld("SYS", "truncate abonnements")
        For Each excelrow As DataRow In dt.Rows
            Dim strSql As String = "insert into abonnements (team_alias,offering_name,contract_number,subscription_id,term,start_date,end_date," &
                                   "autorenew_date,subscription_status,seat_quantity,reseller_email,reseller_name) values('" &
                                   excelrow("team_alias") & "','" &
                                   excelrow("offering_name") & "','" &
                                   excelrow("contract_number") & "','" &
                                   excelrow("subscription_id") & "','" &
                                   excelrow("term") & "'," &
                                   getDatestring(excelrow("start_date")) & "," &
                                   getDatestring(excelrow("end_date")) & "," &
                                   getDatestring(excelrow("autorenew_date")) & ",'" &
                                   excelrow("subscription_status") & "','" &
                                   excelrow("seat_quantity") & "','" &
                                   excelrow("reseller_email") & "','" &
                                   excelrow("reseller_name") & "')"
            cmd.ExecuteNonQueryOld("SYS", strSql)
            insertzaehler += 1
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

    Private Function Userexist(WindowsUSer As String) As Boolean
        If Len(WindowsUSer) = 0 Then Return False
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim retVal As Boolean = False
        Dim teile() As String = Split(WindowsUSer, "\")
        Dim Nachname As String = Mid(teile(1), 1, Len(teile(1)) - 1)
        Dim Initiale As String = Mid(teile(1), Len(teile(1)))
        Dim strSQL As String = "select count(*) from benutzer where lower(last_name)='" &
            Nachname.ToLower & "' and lower(first_name) like('" & Initiale.ToLower & "%')"
        Dim anz As Integer = cmd.ExecuteScalarSlowAndOld("SYS", strSQL)
        If anz > 0 Then retVal = True
        Return retVal
    End Function

    Private Function UserIDs(WindowsUSer As String) As List(Of Integer)
        Dim retVal As New List(Of Integer)
        If Len(WindowsUSer) = 0 Then Return retVal
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim teile() As String = Split(WindowsUSer, "\")
        Dim Nachname As String = Mid(teile(1), 1, Len(teile(1)) - 1)
        Dim Initiale As String = Mid(teile(1), Len(teile(1)))
        Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select * from benutzer where lower(last_name)='" &
                                                         Nachname.ToLower & "' and lower(first_name) like('" & Initiale.ToLower & "%')")
        For Each row As DataRow In dt.Rows
            retVal.Add(CInt(row("ID")))
        Next
        Return retVal
    End Function



    Private Function Userexist(email As String, team As String) As Boolean
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim retVal As Boolean = False
        Dim anz As Integer = cmd.ExecuteScalarSlowAndOld("SYS", "select count(*) from benutzer where email='" & email & "' and team_name='" & team & "'")
        If anz > 0 Then retVal = True
        Return retVal
    End Function

    Private Function UserID(email As String, team As String) As Integer
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Return cmd.ExecuteScalarSlowAndOld("SYS", "select id from benutzer where email='" & email & "' and team_name='" & team & "'")
    End Function

#End Region

#Region "Datagridviews füllen"
    Private Sub cbSubBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubBenutzer.SelectedIndexChanged, cbSubMonat.SelectedIndexChanged
        If cbSubBenutzer.Items.Count = 0 Or cbSubMonat.Items.Count = 0 Then Return
        Dim selectedUser = cbSubBenutzer.SelectedItem.ToString
        Dim selectedMonth = cbSubMonat.SelectedItem.ToString
        Dim VorNachname = Split(selectedUser, ", ")
        Dim Vorname = ""
        Dim Nachname = ""
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        If selectedUser <> C_None Then
            If VorNachname.Count = 2 Then
                If selectedMonth <> C_None Then
                    Dim dt = cmd.GetTableFromSelect("SYS", "select * from vsubscription where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "'" &
                                                                 " and month='" & selectedMonth & "' order by produkt")
                    dgvSubsriptions.DataSource = dt
                    Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
                Else
                    Dim dt = cmd.GetTableFromSelect("SYS", "select * from vsubscription where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "' order by produkt")
                    dgvSubsriptions.DataSource = dt
                    Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
                End If
            End If
        Else
            If selectedMonth <> C_None Then
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from vsubscription where month='" & selectedMonth & "' order by email")
                dgvSubsriptions.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            Else
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from vsubscription order by email,month")
                dgvSubsriptions.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            End If
        End If
    End Sub

    Private Sub cbLizenzBenutzer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLizenzBenutzer.SelectedIndexChanged, cbLizenzMonat.SelectedIndexChanged
        If cbLizenzBenutzer.Items.Count = 0 Or cbLizenzMonat.Items.Count = 0 Then Return
        Dim selectedUser = cbLizenzBenutzer.SelectedItem.ToString
        Dim selectedMonth = cbLizenzMonat.SelectedItem.ToString
        Dim VorNachname = Split(selectedUser, ", ")
        Dim Vorname = ""
        Dim Nachname = ""
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)

        If selectedUser <> C_None Then
            If VorNachname.Count = 2 Then
                If selectedMonth <> C_None Then
                    Dim dt = cmd.GetTableFromSelect("SYS", "select * from vusage where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "'" &
                                                                 " and month='" & selectedMonth & "' order by produkt")
                    dgvLizenznutzung.DataSource = dt
                    Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
                Else
                    Dim dt = cmd.GetTableFromSelect("SYS", "select * from vusage where vorname='" & VorNachname(1) &
                                                                 "' and nachname='" & VorNachname(0) & "' order by produkt")
                    dgvLizenznutzung.DataSource = dt
                    Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
                End If
            End If
        Else
            If selectedMonth <> C_None Then
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from vusage where month='" & selectedMonth & "' order by email")
                dgvLizenznutzung.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            Else
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from vusage order by email,month")
                dgvLizenznutzung.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            End If
        End If

    End Sub

    Private Sub cbUserTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUserTeam.SelectedIndexChanged, cbUserGruppe.SelectedIndexChanged
        If cbUserGruppe.Items.Count = 0 Then Return
        If cbUserTeam.Items.Count = 0 Then Return
        Dim selectedTeam = cbUserTeam.SelectedItem.ToString
        Dim selectedGroup = cbUserGruppe.SelectedItem.ToString
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        If selectedTeam <> C_None Then
            If selectedGroup <> C_None Then
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from benutzer where team_name='" & selectedTeam &
                                                             "' and group_name='" & selectedGroup & "' order by group_name")
                dgvBenutzer.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            Else
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from benutzer where team_name='" & selectedTeam & "' order by team_name")
                dgvBenutzer.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            End If
        Else
            If selectedGroup <> C_None Then
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from benutzer where group_name='" & selectedGroup & "' order by group_name")
                dgvBenutzer.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            Else
                Dim dt = cmd.GetTableFromSelect("SYS", "select * from benutzer order by email")
                dgvBenutzer.DataSource = dt
                Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
            End If
        End If
    End Sub

    Private Sub cbAbosProdukt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAbosProdukt.SelectedIndexChanged
        If cbAbosProdukt.Items.Count = 0 Then Return
        Dim selectedProdukt = cbAbosProdukt.SelectedItem.ToString
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        If selectedProdukt <> C_None Then
            Dim dt = cmd.GetTableFromSelect("SYS", "select * from abonnements where offering_name='" & selectedProdukt & "'")
            dgvAbos.DataSource = dt
            Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
        Else
            Dim dt = cmd.GetTableFromSelect("SYS", "select * from abonnements")
            dgvAbos.DataSource = dt
            Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
        End If

    End Sub


    Private Sub cbNutzungTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNutzTeam.SelectedIndexChanged, cbNutzGruppe.SelectedIndexChanged, cbNutzProdukt.SelectedIndexChanged, cbNutzMonat.SelectedIndexChanged, cbNutzAccess.SelectedIndexChanged
        If cbNutzGruppe.Items.Count = 0 Then Return
        If cbNutzTeam.Items.Count = 0 Then Return
        If cbNutzMonat.Items.Count = 0 Then Return
        If cbNutzMonat.SelectedItem <> C_None Then
            cmdBerichtAEC.Enabled = True
            cmdBerichtToken.Enabled = True
        Else
            cmdBerichtAEC.Enabled = False
            cmdBerichtToken.Enabled = False
        End If
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim strSpalten = "vorname,nachname,email,team,gruppe,rolle,account_status,offering_name,product_name,version," &
                                   "day_used,tokens_used,access_option"
        Dim bedingung = getNutzBedingung()

        If Len(bedingung) > 0 Then
            Dim dt = cmd.GetTableFromSelect("SYS", "select " & strSpalten & " from vnutzung where " & bedingung)
            dgvNutzung.DataSource = dt
            Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
        Else
            dgvNutzung.DataSource = Nothing
        End If
    End Sub

    Private Function getNutzBedingung() As String
        Dim retVal As String = ""
        Dim selectedTeam As String = C_None
        Dim selectedGroup As String = C_None
        Dim selectedMonat As String = C_None
        Dim selectedProdukt As String = C_None
        Dim selectedZugriff As String = C_None
        If cbNutzTeam.Items.Count > 0 Then
            selectedTeam = cbNutzTeam.SelectedItem.ToString
        End If
        If cbNutzGruppe.Items.Count > 0 Then
            selectedGroup = cbNutzGruppe.SelectedItem.ToString
        End If
        If cbNutzMonat.Items.Count > 0 Then
            selectedMonat = cbNutzMonat.SelectedItem.ToString
        End If
        If cbNutzProdukt.Items.Count > 0 Then
            selectedProdukt = cbNutzProdukt.SelectedItem.ToString
        End If
        If cbNutzAccess.Items.Count > 0 Then
            selectedZugriff = cbNutzAccess.SelectedItem.ToString
        End If
        If selectedTeam <> C_None Then
            retVal &= "and team='" & selectedTeam & "' "
        End If
        If selectedGroup <> C_None Then
            retVal &= "and gruppe='" & selectedGroup & "' "
        End If
        If selectedMonat <> C_None Then
            retVal &= "and to_char(day_used, 'YYYY-MM')='" & selectedMonat & "' "
        End If
        If selectedProdukt <> C_None Then
            retVal &= "and offering_name='" & selectedProdukt & "' "
        End If
        If selectedZugriff <> C_None Then
            retVal &= "and access_option='" & selectedZugriff & "' "
        End If
        If Len(retVal) > 0 Then
            retVal = Mid(retVal, 4)
        End If
        Return retVal
    End Function

    Private Sub cbLizenzSchalter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLizenzBenutzer.SelectedIndexChanged, cbLizenzMonat.SelectedIndexChanged, cbLizenzGruppe.SelectedIndexChanged, cbLizenzAbteilung.SelectedIndexChanged, cbLizenzProdukt.SelectedIndexChanged, cbLizenzZugriff.SelectedIndexChanged
        If cbLizenzBenutzer.Items.Count = 0 Then Return
        If cbLizenzMonat.Items.Count = 0 Then Return
        If cbLizenzAbteilung.Items.Count = 0 Then Return
        If cbLizenzProdukt.Items.Count = 0 Then Return
        If cbLizenzZugriff.Items.Count = 0 Then Return
        If cbLizenzGruppe.Items.Count = 0 Then Return
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim strSpalten = "vorname,nachname,email,team,gruppe,abteilung,rolle,account_status,produkt,access_option," &
                         "days_used,monthly_average,tokens_used,last_accessed,month"
        Dim bedingung = getLizenzBedingung()

        If Len(bedingung) > 0 Then
            Dim dt = cmd.GetTableFromSelect("SYS", "select " & strSpalten & " from vusage where " & bedingung)
            dgvLizenznutzung.DataSource = dt
            Text = titel & " | " & dt.Rows.Count & " angezeigte Datensätze"
        Else
            dgvLizenznutzung.DataSource = Nothing
        End If
    End Sub

    Private Function getLizenzBedingung() As String
        Dim retVal As String = ""
        Dim selectedBenutzer As String = C_None
        Dim selectedMonat As String = C_None
        Dim selectedGruppe As String = C_None
        Dim selectedAbteilung As String = C_None
        Dim selectedProdukt As String = C_None
        Dim selectedZugriff As String = C_None
        If cbNutzTeam.Items.Count > 0 Then
            selectedBenutzer = cbLizenzBenutzer.SelectedItem.ToString
        End If
        If cbNutzMonat.Items.Count > 0 Then
            selectedMonat = cbLizenzMonat.SelectedItem.ToString
        End If
        If cbLizenzAbteilung.Items.Count > 0 Then
            selectedAbteilung = cbLizenzAbteilung.SelectedItem.ToString
        End If
        If cbLizenzGruppe.Items.Count > 0 Then
            selectedGruppe = cbLizenzGruppe.SelectedItem.ToString
        End If
        If cbLizenzProdukt.Items.Count > 0 Then
            selectedProdukt = cbLizenzProdukt.SelectedItem.ToString
        End If
        If cbLizenzZugriff.Items.Count > 0 Then
            selectedZugriff = cbLizenzZugriff.SelectedItem.ToString
        End If
        If selectedBenutzer <> C_None Then
            retVal &= "and benutzer='" & selectedBenutzer & "' "
        End If
        If selectedAbteilung <> C_None Then
            retVal &= "and abteilung='" & selectedAbteilung & "' "
        End If
        If selectedGruppe <> C_None Then
            retVal &= "and gruppe='" & selectedGruppe & "' "
        End If
        If selectedMonat <> C_None Then
            retVal &= "and month='" & selectedMonat & "' "
        End If
        If selectedProdukt <> C_None Then
            retVal &= "and produkt='" & selectedProdukt & "' "
        End If
        If selectedZugriff <> C_None Then
            retVal &= "and access_option='" & selectedZugriff & "' "
        End If
        If Len(retVal) > 0 Then
            retVal = Mid(retVal, 4)
        End If
        Return retVal
    End Function

    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        Select Case tabMain.SelectedTab.Name
            Case "tpBenutzer"
                Me.Text = titel & " | " & dgvBenutzer.Rows.Count & " angezeigte Datensätze"
            Case "tpLizenznutzung"
                Me.Text = titel & " | " & dgvLizenznutzung.Rows.Count & " angezeigte Datensätze"
            Case "tpSubscritions"
                Me.Text = titel & " | " & dgvSubsriptions.Rows.Count & " angezeigte Datensätze"
            Case "TpImport"
                Me.Text = titel & " | " & dgExcelcontent.Rows.Count & " angezeigte Datensätze"
            Case "tpAbos"
                Me.Text = titel & " | " & dgvAbos.Rows.Count & " angezeigte Datensätze"
            Case "tpNutzung"
                Me.Text = titel & " | " & dgvNutzung.Rows.Count & " angezeigte Datensätze"
            Case Else
                Me.Text = titel
        End Select
    End Sub


#End Region

End Class