<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cmdSoftware = New Button()
        dgvInhalt = New DataGridView()
        spTabellen = New SplitContainer()
        cmdDownload = New Button()
        cmdUpload = New Button()
        cmdConnectoren = New Button()
        tabMain = New TabControl()
        TabTabellen = New TabPage()
        TpImport = New TabPage()
        spImport = New SplitContainer()
        cbUeberführen = New CheckBox()
        txtImportfile = New TextBox()
        lblSheets = New Label()
        cmdImpFile = New Button()
        cbSheets = New ComboBox()
        dgExcelcontent = New DataGridView()
        tpBenutzer = New TabPage()
        spBenutzer = New SplitContainer()
        Label2 = New Label()
        cbUserGruppe = New ComboBox()
        Label1 = New Label()
        cbUserTeam = New ComboBox()
        dgvBenutzer = New DataGridView()
        tpSubscritions = New TabPage()
        spSubsriptions = New SplitContainer()
        Label3 = New Label()
        cbSubMonat = New ComboBox()
        Label4 = New Label()
        cbSubBenutzer = New ComboBox()
        dgvSubsriptions = New DataGridView()
        tpLizenznutzung = New TabPage()
        spLizenznutzung = New SplitContainer()
        Label5 = New Label()
        cbLizenzMonat = New ComboBox()
        Label6 = New Label()
        cbLizenzBenutzer = New ComboBox()
        dgvLizenznutzung = New DataGridView()
        CType(dgvInhalt, ComponentModel.ISupportInitialize).BeginInit()
        CType(spTabellen, ComponentModel.ISupportInitialize).BeginInit()
        spTabellen.Panel1.SuspendLayout()
        spTabellen.Panel2.SuspendLayout()
        spTabellen.SuspendLayout()
        tabMain.SuspendLayout()
        TabTabellen.SuspendLayout()
        TpImport.SuspendLayout()
        CType(spImport, ComponentModel.ISupportInitialize).BeginInit()
        spImport.Panel1.SuspendLayout()
        spImport.Panel2.SuspendLayout()
        spImport.SuspendLayout()
        CType(dgExcelcontent, ComponentModel.ISupportInitialize).BeginInit()
        tpBenutzer.SuspendLayout()
        CType(spBenutzer, ComponentModel.ISupportInitialize).BeginInit()
        spBenutzer.Panel1.SuspendLayout()
        spBenutzer.Panel2.SuspendLayout()
        spBenutzer.SuspendLayout()
        CType(dgvBenutzer, ComponentModel.ISupportInitialize).BeginInit()
        tpSubscritions.SuspendLayout()
        CType(spSubsriptions, ComponentModel.ISupportInitialize).BeginInit()
        spSubsriptions.Panel1.SuspendLayout()
        spSubsriptions.Panel2.SuspendLayout()
        spSubsriptions.SuspendLayout()
        CType(dgvSubsriptions, ComponentModel.ISupportInitialize).BeginInit()
        tpLizenznutzung.SuspendLayout()
        CType(spLizenznutzung, ComponentModel.ISupportInitialize).BeginInit()
        spLizenznutzung.Panel1.SuspendLayout()
        spLizenznutzung.Panel2.SuspendLayout()
        spLizenznutzung.SuspendLayout()
        CType(dgvLizenznutzung, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdSoftware
        ' 
        cmdSoftware.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdSoftware.Location = New Point(1165, 25)
        cmdSoftware.Name = "cmdSoftware"
        cmdSoftware.Size = New Size(115, 41)
        cmdSoftware.TabIndex = 0
        cmdSoftware.Text = "Software"
        cmdSoftware.UseVisualStyleBackColor = True
        ' 
        ' dgvInhalt
        ' 
        dgvInhalt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInhalt.Dock = DockStyle.Fill
        dgvInhalt.Location = New Point(0, 0)
        dgvInhalt.Name = "dgvInhalt"
        dgvInhalt.Size = New Size(1285, 527)
        dgvInhalt.TabIndex = 1
        ' 
        ' spTabellen
        ' 
        spTabellen.Dock = DockStyle.Fill
        spTabellen.Location = New Point(3, 3)
        spTabellen.Name = "spTabellen"
        spTabellen.Orientation = Orientation.Horizontal
        ' 
        ' spTabellen.Panel1
        ' 
        spTabellen.Panel1.Controls.Add(dgvInhalt)
        ' 
        ' spTabellen.Panel2
        ' 
        spTabellen.Panel2.Controls.Add(cmdDownload)
        spTabellen.Panel2.Controls.Add(cmdUpload)
        spTabellen.Panel2.Controls.Add(cmdConnectoren)
        spTabellen.Panel2.Controls.Add(cmdSoftware)
        spTabellen.Size = New Size(1285, 602)
        spTabellen.SplitterDistance = 527
        spTabellen.TabIndex = 2
        ' 
        ' cmdDownload
        ' 
        cmdDownload.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdDownload.Location = New Point(555, 25)
        cmdDownload.Name = "cmdDownload"
        cmdDownload.Size = New Size(115, 41)
        cmdDownload.TabIndex = 3
        cmdDownload.Text = "Bild anzeigen"
        cmdDownload.UseVisualStyleBackColor = True
        ' 
        ' cmdUpload
        ' 
        cmdUpload.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdUpload.Location = New Point(434, 25)
        cmdUpload.Name = "cmdUpload"
        cmdUpload.Size = New Size(115, 41)
        cmdUpload.TabIndex = 2
        cmdUpload.Text = "Bild hochladen"
        cmdUpload.UseVisualStyleBackColor = True
        ' 
        ' cmdConnectoren
        ' 
        cmdConnectoren.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdConnectoren.Location = New Point(1044, 25)
        cmdConnectoren.Name = "cmdConnectoren"
        cmdConnectoren.Size = New Size(115, 41)
        cmdConnectoren.TabIndex = 1
        cmdConnectoren.Text = "Connectoren"
        cmdConnectoren.UseVisualStyleBackColor = True
        ' 
        ' tabMain
        ' 
        tabMain.Controls.Add(TabTabellen)
        tabMain.Controls.Add(TpImport)
        tabMain.Controls.Add(tpBenutzer)
        tabMain.Controls.Add(tpSubscritions)
        tabMain.Controls.Add(tpLizenznutzung)
        tabMain.Dock = DockStyle.Fill
        tabMain.Location = New Point(0, 0)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(1299, 636)
        tabMain.TabIndex = 3
        ' 
        ' TabTabellen
        ' 
        TabTabellen.Controls.Add(spTabellen)
        TabTabellen.Location = New Point(4, 24)
        TabTabellen.Name = "TabTabellen"
        TabTabellen.Padding = New Padding(3)
        TabTabellen.Size = New Size(1291, 608)
        TabTabellen.TabIndex = 0
        TabTabellen.Text = "Tabellen"
        TabTabellen.UseVisualStyleBackColor = True
        ' 
        ' TpImport
        ' 
        TpImport.Controls.Add(spImport)
        TpImport.Location = New Point(4, 24)
        TpImport.Name = "TpImport"
        TpImport.Padding = New Padding(3)
        TpImport.Size = New Size(1291, 608)
        TpImport.TabIndex = 1
        TpImport.Text = "Import"
        TpImport.UseVisualStyleBackColor = True
        ' 
        ' spImport
        ' 
        spImport.Dock = DockStyle.Fill
        spImport.Location = New Point(3, 3)
        spImport.Name = "spImport"
        spImport.Orientation = Orientation.Horizontal
        ' 
        ' spImport.Panel1
        ' 
        spImport.Panel1.Controls.Add(cbUeberführen)
        spImport.Panel1.Controls.Add(txtImportfile)
        spImport.Panel1.Controls.Add(lblSheets)
        spImport.Panel1.Controls.Add(cmdImpFile)
        spImport.Panel1.Controls.Add(cbSheets)
        ' 
        ' spImport.Panel2
        ' 
        spImport.Panel2.Controls.Add(dgExcelcontent)
        spImport.Size = New Size(1285, 602)
        spImport.SplitterDistance = 84
        spImport.TabIndex = 4
        ' 
        ' cbUeberführen
        ' 
        cbUeberführen.AutoSize = True
        cbUeberführen.Checked = True
        cbUeberführen.CheckState = CheckState.Checked
        cbUeberführen.Location = New Point(373, 46)
        cbUeberführen.Name = "cbUeberführen"
        cbUeberführen.Size = New Size(149, 19)
        cbUeberführen.TabIndex = 4
        cbUeberführen.Text = "direkt in DB überführen"
        cbUeberführen.UseVisualStyleBackColor = True
        ' 
        ' txtImportfile
        ' 
        txtImportfile.Location = New Point(5, 13)
        txtImportfile.Name = "txtImportfile"
        txtImportfile.Size = New Size(809, 23)
        txtImportfile.TabIndex = 1
        ' 
        ' lblSheets
        ' 
        lblSheets.AutoSize = True
        lblSheets.Location = New Point(5, 45)
        lblSheets.Name = "lblSheets"
        lblSheets.Size = New Size(153, 15)
        lblSheets.TabIndex = 3
        lblSheets.Text = "vorhandene Tabellenblätter:"
        ' 
        ' cmdImpFile
        ' 
        cmdImpFile.Location = New Point(820, 13)
        cmdImpFile.Name = "cmdImpFile"
        cmdImpFile.Size = New Size(31, 23)
        cmdImpFile.TabIndex = 0
        cmdImpFile.Text = "..."
        cmdImpFile.UseVisualStyleBackColor = True
        ' 
        ' cbSheets
        ' 
        cbSheets.FormattingEnabled = True
        cbSheets.Location = New Point(161, 42)
        cbSheets.Name = "cbSheets"
        cbSheets.Size = New Size(206, 23)
        cbSheets.TabIndex = 2
        ' 
        ' dgExcelcontent
        ' 
        dgExcelcontent.AllowUserToAddRows = False
        dgExcelcontent.AllowUserToDeleteRows = False
        dgExcelcontent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgExcelcontent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgExcelcontent.Dock = DockStyle.Fill
        dgExcelcontent.Location = New Point(0, 0)
        dgExcelcontent.Name = "dgExcelcontent"
        dgExcelcontent.Size = New Size(1285, 514)
        dgExcelcontent.TabIndex = 0
        ' 
        ' tpBenutzer
        ' 
        tpBenutzer.Controls.Add(spBenutzer)
        tpBenutzer.Location = New Point(4, 24)
        tpBenutzer.Name = "tpBenutzer"
        tpBenutzer.Padding = New Padding(3)
        tpBenutzer.Size = New Size(1291, 608)
        tpBenutzer.TabIndex = 2
        tpBenutzer.Text = "Benutzer"
        tpBenutzer.UseVisualStyleBackColor = True
        ' 
        ' spBenutzer
        ' 
        spBenutzer.Dock = DockStyle.Fill
        spBenutzer.IsSplitterFixed = True
        spBenutzer.Location = New Point(3, 3)
        spBenutzer.Name = "spBenutzer"
        ' 
        ' spBenutzer.Panel1
        ' 
        spBenutzer.Panel1.Controls.Add(Label2)
        spBenutzer.Panel1.Controls.Add(cbUserGruppe)
        spBenutzer.Panel1.Controls.Add(Label1)
        spBenutzer.Panel1.Controls.Add(cbUserTeam)
        ' 
        ' spBenutzer.Panel2
        ' 
        spBenutzer.Panel2.Controls.Add(dgvBenutzer)
        spBenutzer.Size = New Size(1285, 602)
        spBenutzer.SplitterDistance = 231
        spBenutzer.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 7
        Label2.Text = "Gruppe"
        ' 
        ' cbUserGruppe
        ' 
        cbUserGruppe.FormattingEnabled = True
        cbUserGruppe.Location = New Point(3, 67)
        cbUserGruppe.Name = "cbUserGruppe"
        cbUserGruppe.Size = New Size(223, 23)
        cbUserGruppe.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 5
        Label1.Text = "Lizenz-Team"
        ' 
        ' cbUserTeam
        ' 
        cbUserTeam.FormattingEnabled = True
        cbUserTeam.Location = New Point(3, 18)
        cbUserTeam.Name = "cbUserTeam"
        cbUserTeam.Size = New Size(223, 23)
        cbUserTeam.TabIndex = 4
        ' 
        ' dgvBenutzer
        ' 
        dgvBenutzer.AllowUserToAddRows = False
        dgvBenutzer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvBenutzer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvBenutzer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvBenutzer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBenutzer.Dock = DockStyle.Fill
        dgvBenutzer.Location = New Point(0, 0)
        dgvBenutzer.Name = "dgvBenutzer"
        dgvBenutzer.Size = New Size(1050, 602)
        dgvBenutzer.TabIndex = 0
        ' 
        ' tpSubscritions
        ' 
        tpSubscritions.Controls.Add(spSubsriptions)
        tpSubscritions.Location = New Point(4, 24)
        tpSubscritions.Name = "tpSubscritions"
        tpSubscritions.Padding = New Padding(3)
        tpSubscritions.Size = New Size(1291, 608)
        tpSubscritions.TabIndex = 3
        tpSubscritions.Text = "Subscriptions"
        tpSubscritions.UseVisualStyleBackColor = True
        ' 
        ' spSubsriptions
        ' 
        spSubsriptions.Dock = DockStyle.Fill
        spSubsriptions.IsSplitterFixed = True
        spSubsriptions.Location = New Point(3, 3)
        spSubsriptions.Name = "spSubsriptions"
        ' 
        ' spSubsriptions.Panel1
        ' 
        spSubsriptions.Panel1.Controls.Add(Label3)
        spSubsriptions.Panel1.Controls.Add(cbSubMonat)
        spSubsriptions.Panel1.Controls.Add(Label4)
        spSubsriptions.Panel1.Controls.Add(cbSubBenutzer)
        ' 
        ' spSubsriptions.Panel2
        ' 
        spSubsriptions.Panel2.Controls.Add(dgvSubsriptions)
        spSubsriptions.Size = New Size(1285, 602)
        spSubsriptions.SplitterDistance = 228
        spSubsriptions.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 7
        Label3.Text = "Monat"
        ' 
        ' cbSubMonat
        ' 
        cbSubMonat.FormattingEnabled = True
        cbSubMonat.Location = New Point(3, 67)
        cbSubMonat.Name = "cbSubMonat"
        cbSubMonat.Size = New Size(223, 23)
        cbSubMonat.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 5
        Label4.Text = "Benutzer"
        ' 
        ' cbSubBenutzer
        ' 
        cbSubBenutzer.FormattingEnabled = True
        cbSubBenutzer.Location = New Point(3, 18)
        cbSubBenutzer.Name = "cbSubBenutzer"
        cbSubBenutzer.Size = New Size(223, 23)
        cbSubBenutzer.TabIndex = 4
        ' 
        ' dgvSubsriptions
        ' 
        dgvSubsriptions.AllowUserToAddRows = False
        dgvSubsriptions.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvSubsriptions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        dgvSubsriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvSubsriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSubsriptions.Dock = DockStyle.Fill
        dgvSubsriptions.Location = New Point(0, 0)
        dgvSubsriptions.Name = "dgvSubsriptions"
        dgvSubsriptions.Size = New Size(1053, 602)
        dgvSubsriptions.TabIndex = 0
        ' 
        ' tpLizenznutzung
        ' 
        tpLizenznutzung.Controls.Add(spLizenznutzung)
        tpLizenznutzung.Location = New Point(4, 24)
        tpLizenznutzung.Name = "tpLizenznutzung"
        tpLizenznutzung.Padding = New Padding(3)
        tpLizenznutzung.Size = New Size(1291, 608)
        tpLizenznutzung.TabIndex = 4
        tpLizenznutzung.Text = "Lizenznutzung"
        tpLizenznutzung.UseVisualStyleBackColor = True
        ' 
        ' spLizenznutzung
        ' 
        spLizenznutzung.Dock = DockStyle.Fill
        spLizenznutzung.IsSplitterFixed = True
        spLizenznutzung.Location = New Point(3, 3)
        spLizenznutzung.Name = "spLizenznutzung"
        ' 
        ' spLizenznutzung.Panel1
        ' 
        spLizenznutzung.Panel1.Controls.Add(Label5)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzMonat)
        spLizenznutzung.Panel1.Controls.Add(Label6)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzBenutzer)
        ' 
        ' spLizenznutzung.Panel2
        ' 
        spLizenznutzung.Panel2.Controls.Add(dgvLizenznutzung)
        spLizenznutzung.Size = New Size(1285, 602)
        spLizenznutzung.SplitterDistance = 228
        spLizenznutzung.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 7
        Label5.Text = "Monat"
        ' 
        ' cbLizenzMonat
        ' 
        cbLizenzMonat.FormattingEnabled = True
        cbLizenzMonat.Location = New Point(3, 67)
        cbLizenzMonat.Name = "cbLizenzMonat"
        cbLizenzMonat.Size = New Size(223, 23)
        cbLizenzMonat.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 5
        Label6.Text = "Benutzer"
        ' 
        ' cbLizenzBenutzer
        ' 
        cbLizenzBenutzer.FormattingEnabled = True
        cbLizenzBenutzer.Location = New Point(3, 18)
        cbLizenzBenutzer.Name = "cbLizenzBenutzer"
        cbLizenzBenutzer.Size = New Size(223, 23)
        cbLizenzBenutzer.TabIndex = 4
        ' 
        ' dgvLizenznutzung
        ' 
        dgvLizenznutzung.AllowUserToAddRows = False
        dgvLizenznutzung.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvLizenznutzung.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dgvLizenznutzung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvLizenznutzung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLizenznutzung.Dock = DockStyle.Fill
        dgvLizenznutzung.Location = New Point(0, 0)
        dgvLizenznutzung.Name = "dgvLizenznutzung"
        dgvLizenznutzung.Size = New Size(1053, 602)
        dgvLizenznutzung.TabIndex = 0
        ' 
        ' frmBrowser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1299, 636)
        Controls.Add(tabMain)
        Name = "frmBrowser"
        Text = "frmBrowser"
        CType(dgvInhalt, ComponentModel.ISupportInitialize).EndInit()
        spTabellen.Panel1.ResumeLayout(False)
        spTabellen.Panel2.ResumeLayout(False)
        CType(spTabellen, ComponentModel.ISupportInitialize).EndInit()
        spTabellen.ResumeLayout(False)
        tabMain.ResumeLayout(False)
        TabTabellen.ResumeLayout(False)
        TpImport.ResumeLayout(False)
        spImport.Panel1.ResumeLayout(False)
        spImport.Panel1.PerformLayout()
        spImport.Panel2.ResumeLayout(False)
        CType(spImport, ComponentModel.ISupportInitialize).EndInit()
        spImport.ResumeLayout(False)
        CType(dgExcelcontent, ComponentModel.ISupportInitialize).EndInit()
        tpBenutzer.ResumeLayout(False)
        spBenutzer.Panel1.ResumeLayout(False)
        spBenutzer.Panel1.PerformLayout()
        spBenutzer.Panel2.ResumeLayout(False)
        CType(spBenutzer, ComponentModel.ISupportInitialize).EndInit()
        spBenutzer.ResumeLayout(False)
        CType(dgvBenutzer, ComponentModel.ISupportInitialize).EndInit()
        tpSubscritions.ResumeLayout(False)
        spSubsriptions.Panel1.ResumeLayout(False)
        spSubsriptions.Panel1.PerformLayout()
        spSubsriptions.Panel2.ResumeLayout(False)
        CType(spSubsriptions, ComponentModel.ISupportInitialize).EndInit()
        spSubsriptions.ResumeLayout(False)
        CType(dgvSubsriptions, ComponentModel.ISupportInitialize).EndInit()
        tpLizenznutzung.ResumeLayout(False)
        spLizenznutzung.Panel1.ResumeLayout(False)
        spLizenznutzung.Panel1.PerformLayout()
        spLizenznutzung.Panel2.ResumeLayout(False)
        CType(spLizenznutzung, ComponentModel.ISupportInitialize).EndInit()
        spLizenznutzung.ResumeLayout(False)
        CType(dgvLizenznutzung, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmdSoftware As Button
    Friend WithEvents dgvInhalt As DataGridView
    Friend WithEvents spTabellen As SplitContainer
    Friend WithEvents cmdConnectoren As Button
    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabTabellen As TabPage
    Friend WithEvents TpImport As TabPage
    Friend WithEvents txtImportfile As TextBox
    Friend WithEvents cmdImpFile As Button
    Friend WithEvents lblSheets As Label
    Friend WithEvents cbSheets As ComboBox
    Friend WithEvents spImport As SplitContainer
    Friend WithEvents dgExcelcontent As DataGridView
    Friend WithEvents cbUeberführen As CheckBox
    Friend WithEvents cmdUpload As Button
    Friend WithEvents cmdDownload As Button
    Friend WithEvents tpBenutzer As TabPage
    Friend WithEvents tpSubscritions As TabPage
    Friend WithEvents tpLizenznutzung As TabPage
    Friend WithEvents spBenutzer As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents cbUserTeam As ComboBox
    Friend WithEvents dgvBenutzer As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbUserGruppe As ComboBox
    Friend WithEvents spSubsriptions As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSubMonat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSubBenutzer As ComboBox
    Friend WithEvents dgvSubsriptions As DataGridView
    Friend WithEvents spLizenznutzung As SplitContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents cbLizenzMonat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbLizenzBenutzer As ComboBox
    Friend WithEvents dgvLizenznutzung As DataGridView
End Class
