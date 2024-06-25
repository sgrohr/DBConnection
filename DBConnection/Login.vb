Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports DB
Imports Npgsql

Public Class login

    Private Const SoftwareServer As String = "10.18.32.15"
    Private Const SoftwareDB As String = "Software"
    Private Const SoftwareUser As String = "CADLayer"
    Private Const SoftwarePW As String = "Fwt$CAD!2o24"
    Private Const FESTestServer As String = "engsuite-sql-test.postgres.database.azure.com"
    Private Const FESTestDB As String = "engsuitetest"
    Private Const FESTestUser As String = "engsuite_rohrs@engsuite-sql-test"
    Private Const FESTestPW As String = "Fas3_Zum5_Fyb3"
    Private Const FESProdServer As String = "engsuite-sql.postgres.database.azure.com"
    Private Const FESProdDB As String = "engsuite"
    Private Const FESProdPW As String = "1466aP8i03Mh2tu3So2iq5"
    Private Const FESProdUser As String = "engsuite_appservice_writer@engsuite-sql"
    Private frmfollow As String = ""

    Private Sub cmdLogin_click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        OpenDB()
    End Sub
    Private Sub OpenDB()
        Dim cn As DB.clsConnection = DB.clsConnection.Manager
        Dim err As New Georg.IGEOrgConnection.ConnectionErrorInfo
        err.Fehlerklasse = Georg.IGEOrgConnection.eConnectionError.NO_ERROR
        If Len(txtUser.Text) = 0 Or Len(txtPasswort.Text) = 0 Then
            MsgBox("Bitte Username und Passwort eingeben!", MsgBoxStyle.Exclamation, "Eingabe erforderlich!")
            Exit Sub
        End If
        err = cn.OpenPostgreSQLDB(clsConnectionNames.SysCn, txtServer.Text, txtUser.Text, txtPasswort.Text, txtDatenbank.Text)
        If err.Fehlerklasse <> Georg.IGEOrgConnection.eConnectionError.NO_ERROR Then
            cn.RemoveAll() ' eigentlich remove(clsVersion.C_SYS)
            Select Case MsgBox(cn.GetErrorDescription(err.Fehlerklasse, err.Ausnahme.Message), MsgBoxStyle.Critical Or MsgBoxStyle.RetryCancel)
                Case MsgBoxResult.Cancel
                    Close()
                    Return
                Case Else
                    Return
            End Select
        Else
            err = cn.OpenPostgreSQLDB(clsConnectionNames.ErrCn, txtServer.Text, txtUser.Text, txtPasswort.Text, txtDatenbank.Text)
            If err.Fehlerklasse <> Georg.IGEOrgConnection.eConnectionError.NO_ERROR Then
                cn.RemoveAll() ' eigentlich remove(clsVersion.C_SYS)
                If MsgBox(cn.GetErrorDescription(err.Fehlerklasse, err.Ausnahme.Message), MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly) = vbOK Then
                    Close()
                    Return
                End If
            End If
        End If
        Select Case frmfollow
            Case "frmBrowser"
                Dim f As New frmBrowser
                GetFrmPosition(f)
                f.Show()
            Case "FES"
                Dim f As New frmFES
                f.Show()
                GetFrmPosition(f)
        End Select
        Me.Close()

    End Sub


    Private Sub cbServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServer.SelectedIndexChanged
        Dim server As String = cbServer.SelectedItem
        Select Case server
            Case "Software"
                txtServer.Text = SoftwareServer
                txtDatenbank.Text = SoftwareDB
                txtUser.Text = SoftwareUser
                txtPasswort.Text = SoftwarePW
                frmfollow = "frmBrowser"
                cmdLogin.Enabled = True
            Case "FES-Test"
                txtServer.Text = FESTestServer
                txtDatenbank.Text = FESTestDB
                txtUser.Text = FESTestUser
                txtPasswort.Text = FESTestPW
                frmfollow = "FES"
                cmdLogin.Enabled = True
            Case "FES-Produktiv"
                txtServer.Text = FESProdServer
                txtDatenbank.Text = FESProdDB
                txtUser.Text = FESProdUser
                txtPasswort.Text = FESProdPW
                frmfollow = "FES"
                cmdLogin.Enabled = True
            Case Else
                cmdLogin.Enabled = False
        End Select
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetFrmPosition(Me)
        cbServer.SelectedIndex = 0
        cmdLogin.Enabled = False
    End Sub

    Private Sub GetFrmPosition(frm As Form)
        Dim retVal As Point = Nothing
        Dim anzBildschirme As Integer = Screen.AllScreens.Count
        Select Case anzBildschirme
            Case 1
                Dim scr As Screen = Screen.AllScreens(0)
                frm.StartPosition = FormStartPosition.Manual
                frm.Location = New Point(scr.Bounds.X + scr.Bounds.Width / 2 - frm.Width / 2, scr.Bounds.Y + scr.Bounds.Height / 2 - frm.Height / 2)
            Case Else
                Dim scr As Screen = Screen.AllScreens(1)
                frm.StartPosition = FormStartPosition.Manual
                frm.Location = New Point(scr.Bounds.X + scr.Bounds.Width / 2 - frm.Width / 2, scr.Bounds.Y + scr.Bounds.Height / 2 - frm.Height / 2)
        End Select

    End Sub

    Private Sub cmdEnde_Click(sender As Object, e As EventArgs) Handles cmdEnde.Click
        Application.Exit()
    End Sub
End Class
