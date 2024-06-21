Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports DB
Imports Npgsql

Public Class login

    Private Const pw As String = "Fwt$CAD!2o24"

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
            If MsgBox(cn.GetErrorDescription(err.Fehlerklasse, ""), MsgBoxStyle.Critical Or MsgBoxStyle.RetryCancel) = MsgBoxResult.Cancel Then
                Close()
                Return
            End If
        Else
            err = cn.OpenPostgreSQLDB(clsConnectionNames.ErrCn, txtServer.Text, txtUser.Text, txtPasswort.Text, txtDatenbank.Text)
            If err.Fehlerklasse <> Georg.IGEOrgConnection.eConnectionError.NO_ERROR Then
                cn.RemoveAll() ' eigentlich remove(clsVersion.C_SYS)
                If MsgBox(cn.GetErrorDescription(err.Fehlerklasse, ""), MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly) = vbOK Then
                    Close()
                    Return
                End If
            End If
        End If
        Dim f As New frmBrowser
        f.Show()
        Me.Close()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPasswort.Text = pw
    End Sub
End Class
