Public Class frmFES
    Private Sub frmFES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
        Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select pk,name,description from ui1.fec_applications order by pk asc")
        dgvApps.DataSource = dt
    End Sub

    Private Sub dgvApps_SelectionChanged(sender As Object, e As EventArgs) Handles dgvApps.SelectionChanged
        For Each dr As DataGridViewRow In dgvApps.SelectedRows
            Dim pk As Integer = dr.Cells.Item(0).Value
            Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
            Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select pk,name from ui1.fec_tabs where application_pk=" & pk & " order by pk asc")
            dgvTabs.DataSource = dt
            tabFES.SelectedTab = tpTabs
        Next
    End Sub

    Private Sub dgvTabs_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTabs.SelectionChanged
        For Each dr As DataGridViewRow In dgvTabs.SelectedRows
            Dim pk As Integer = dr.Cells.Item(0).Value
            Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
            Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select pk,name from ui1.fec_forms where tab_pk=" & pk & " order by pk asc")
            dgvForms.DataSource = dt
            tabFES.SelectedTab = tpForms
        Next
    End Sub

    Private Sub dgvForms_SelectionChanged(sender As Object, e As EventArgs) Handles dgvForms.SelectionChanged
        For Each dr As DataGridViewRow In dgvForms.SelectedRows
            Dim pk As Integer = dr.Cells.Item(0).Value
            Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
            Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select pk,label as Beschriftung, key as Aufruf, element as Parameter, " &
                                                         "default_value as Standardwert, required as Muss_Attribut from ui1.fec_controls where form_pk=" & pk & " order by pk asc")
            dgvControls.DataSource = dt
            tabFES.SelectedTab = tpControls
        Next
    End Sub


    Private Sub frmFES_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub dgvControls_SelectionChanged(sender As Object, e As EventArgs) Handles dgvControls.SelectionChanged
        For Each dr As DataGridViewRow In dgvControls.SelectedRows
            Dim pk As Integer = dr.Cells.Item(0).Value
            Dim cmd = DB.clsConnection.Manager.GetCommand(DB.clsConnection.SYS)
            Dim dt As DataTable = cmd.GetTableFromSelect("SYS", "select pk,value as Werte from ui1.fec_controloptions where control_pk=" & pk & " order by pk asc")
            dgvValues.DataSource = dt
            tabFES.SelectedTab = tpValues
        Next
    End Sub

End Class