

Public Class frmBrowser
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
End Class