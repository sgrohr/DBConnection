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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cmdSoftware = New Button()
        dgvInhalt = New DataGridView()
        spTabellen = New SplitContainer()
        cbProzesse = New ComboBox()
        Button1 = New Button()
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
        cbxGastUser = New CheckBox()
        Label17 = New Label()
        cbUserRolle = New ComboBox()
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
        txtmaxNutzung = New TextBox()
        txtTokenpreis = New TextBox()
        txtLizenzpreis = New TextBox()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        cmdGesamtAEC = New Button()
        cmdGesamtToken = New Button()
        cmdNutzungAEC = New Button()
        cmdNutzungFlex = New Button()
        Label16 = New Label()
        cbLizenzGruppe = New ComboBox()
        Label15 = New Label()
        cbLizenzZugriff = New ComboBox()
        Label14 = New Label()
        cbLizenzAbteilung = New ComboBox()
        Label13 = New Label()
        cbLizenzProdukt = New ComboBox()
        Label5 = New Label()
        cbLizenzMonat = New ComboBox()
        Label6 = New Label()
        cbLizenzBenutzer = New ComboBox()
        dgvLizenznutzung = New DataGridView()
        tpAbos = New TabPage()
        spAbos = New SplitContainer()
        Label12 = New Label()
        cbAbosProdukt = New ComboBox()
        dgvAbos = New DataGridView()
        tpNutzung = New TabPage()
        spNutzung = New SplitContainer()
        cmdBerichtAEC = New Button()
        cmdBerichtToken = New Button()
        Label11 = New Label()
        cbNutzAccess = New ComboBox()
        Label8 = New Label()
        cbNutzMonat = New ComboBox()
        Label7 = New Label()
        cbNutzProdukt = New ComboBox()
        Label9 = New Label()
        cbNutzGruppe = New ComboBox()
        Label10 = New Label()
        cbNutzTeam = New ComboBox()
        dgvNutzung = New DataGridView()
        tpAEC = New TabPage()
        dgvAEC = New DataGridView()
        tpToken = New TabPage()
        dgvToken = New DataGridView()
        MainMenu = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        BeendenToolStripMenuItem = New ToolStripMenuItem()
        BearbeitenToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        TokennutzungToolStripMenuItem = New ToolStripMenuItem()
        LizenznutzungToolStripMenuItem = New ToolStripMenuItem()
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
        tpAbos.SuspendLayout()
        CType(spAbos, ComponentModel.ISupportInitialize).BeginInit()
        spAbos.Panel1.SuspendLayout()
        spAbos.Panel2.SuspendLayout()
        spAbos.SuspendLayout()
        CType(dgvAbos, ComponentModel.ISupportInitialize).BeginInit()
        tpNutzung.SuspendLayout()
        CType(spNutzung, ComponentModel.ISupportInitialize).BeginInit()
        spNutzung.Panel1.SuspendLayout()
        spNutzung.Panel2.SuspendLayout()
        spNutzung.SuspendLayout()
        CType(dgvNutzung, ComponentModel.ISupportInitialize).BeginInit()
        tpAEC.SuspendLayout()
        CType(dgvAEC, ComponentModel.ISupportInitialize).BeginInit()
        tpToken.SuspendLayout()
        CType(dgvToken, ComponentModel.ISupportInitialize).BeginInit()
        MainMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmdSoftware
        ' 
        cmdSoftware.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdSoftware.Location = New Point(1165, 23)
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
        dgvInhalt.Size = New Size(1285, 505)
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
        spTabellen.Panel2.Controls.Add(cbProzesse)
        spTabellen.Panel2.Controls.Add(Button1)
        spTabellen.Panel2.Controls.Add(cmdDownload)
        spTabellen.Panel2.Controls.Add(cmdUpload)
        spTabellen.Panel2.Controls.Add(cmdConnectoren)
        spTabellen.Panel2.Controls.Add(cmdSoftware)
        spTabellen.Size = New Size(1285, 578)
        spTabellen.SplitterDistance = 505
        spTabellen.TabIndex = 2
        ' 
        ' cbProzesse
        ' 
        cbProzesse.FormattingEnabled = True
        cbProzesse.Location = New Point(135, 35)
        cbProzesse.Name = "cbProzesse"
        cbProzesse.Size = New Size(206, 23)
        cbProzesse.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(5, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 41)
        Button1.TabIndex = 4
        Button1.Text = "Prozesse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cmdDownload
        ' 
        cmdDownload.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdDownload.Location = New Point(555, 23)
        cmdDownload.Name = "cmdDownload"
        cmdDownload.Size = New Size(115, 41)
        cmdDownload.TabIndex = 3
        cmdDownload.Text = "Bild anzeigen"
        cmdDownload.UseVisualStyleBackColor = True
        ' 
        ' cmdUpload
        ' 
        cmdUpload.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdUpload.Location = New Point(434, 23)
        cmdUpload.Name = "cmdUpload"
        cmdUpload.Size = New Size(115, 41)
        cmdUpload.TabIndex = 2
        cmdUpload.Text = "Bild hochladen"
        cmdUpload.UseVisualStyleBackColor = True
        ' 
        ' cmdConnectoren
        ' 
        cmdConnectoren.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdConnectoren.Location = New Point(1044, 23)
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
        tabMain.Controls.Add(tpAbos)
        tabMain.Controls.Add(tpNutzung)
        tabMain.Controls.Add(tpAEC)
        tabMain.Controls.Add(tpToken)
        tabMain.Dock = DockStyle.Fill
        tabMain.Location = New Point(0, 24)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(1299, 612)
        tabMain.TabIndex = 3
        ' 
        ' TabTabellen
        ' 
        TabTabellen.Controls.Add(spTabellen)
        TabTabellen.Location = New Point(4, 24)
        TabTabellen.Name = "TabTabellen"
        TabTabellen.Padding = New Padding(3)
        TabTabellen.Size = New Size(1291, 584)
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
        TpImport.Size = New Size(1291, 584)
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
        spImport.Size = New Size(1285, 578)
        spImport.SplitterDistance = 80
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
        dgExcelcontent.Size = New Size(1285, 494)
        dgExcelcontent.TabIndex = 0
        ' 
        ' tpBenutzer
        ' 
        tpBenutzer.Controls.Add(spBenutzer)
        tpBenutzer.Location = New Point(4, 24)
        tpBenutzer.Name = "tpBenutzer"
        tpBenutzer.Padding = New Padding(3)
        tpBenutzer.Size = New Size(1291, 584)
        tpBenutzer.TabIndex = 2
        tpBenutzer.Text = "Benutzer"
        tpBenutzer.UseVisualStyleBackColor = True
        ' 
        ' spBenutzer
        ' 
        spBenutzer.Dock = DockStyle.Fill
        spBenutzer.FixedPanel = FixedPanel.Panel1
        spBenutzer.IsSplitterFixed = True
        spBenutzer.Location = New Point(3, 3)
        spBenutzer.Name = "spBenutzer"
        ' 
        ' spBenutzer.Panel1
        ' 
        spBenutzer.Panel1.Controls.Add(cbxGastUser)
        spBenutzer.Panel1.Controls.Add(Label17)
        spBenutzer.Panel1.Controls.Add(cbUserRolle)
        spBenutzer.Panel1.Controls.Add(Label2)
        spBenutzer.Panel1.Controls.Add(cbUserGruppe)
        spBenutzer.Panel1.Controls.Add(Label1)
        spBenutzer.Panel1.Controls.Add(cbUserTeam)
        ' 
        ' spBenutzer.Panel2
        ' 
        spBenutzer.Panel2.Controls.Add(dgvBenutzer)
        spBenutzer.Size = New Size(1285, 578)
        spBenutzer.SplitterDistance = 231
        spBenutzer.TabIndex = 0
        ' 
        ' cbxGastUser
        ' 
        cbxGastUser.AutoSize = True
        cbxGastUser.Location = New Point(3, 159)
        cbxGastUser.Name = "cbxGastUser"
        cbxGastUser.Size = New Size(145, 19)
        cbxGastUser.TabIndex = 10
        cbxGastUser.Text = "Gastbenutzer anzeigen"
        cbxGastUser.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(5, 100)
        Label17.Name = "Label17"
        Label17.Size = New Size(33, 15)
        Label17.TabIndex = 9
        Label17.Text = "Rolle"
        ' 
        ' cbUserRolle
        ' 
        cbUserRolle.FormattingEnabled = True
        cbUserRolle.Location = New Point(3, 118)
        cbUserRolle.Name = "cbUserRolle"
        cbUserRolle.Size = New Size(223, 23)
        cbUserRolle.TabIndex = 8
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
        dgvBenutzer.Size = New Size(1050, 578)
        dgvBenutzer.TabIndex = 0
        ' 
        ' tpSubscritions
        ' 
        tpSubscritions.Controls.Add(spSubsriptions)
        tpSubscritions.Location = New Point(4, 24)
        tpSubscritions.Name = "tpSubscritions"
        tpSubscritions.Padding = New Padding(3)
        tpSubscritions.Size = New Size(1291, 584)
        tpSubscritions.TabIndex = 3
        tpSubscritions.Text = "Subscriptions"
        tpSubscritions.UseVisualStyleBackColor = True
        ' 
        ' spSubsriptions
        ' 
        spSubsriptions.Dock = DockStyle.Fill
        spSubsriptions.FixedPanel = FixedPanel.Panel1
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
        spSubsriptions.Size = New Size(1285, 578)
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
        dgvSubsriptions.Size = New Size(1053, 578)
        dgvSubsriptions.TabIndex = 0
        ' 
        ' tpLizenznutzung
        ' 
        tpLizenznutzung.Controls.Add(spLizenznutzung)
        tpLizenznutzung.Location = New Point(4, 24)
        tpLizenznutzung.Name = "tpLizenznutzung"
        tpLizenznutzung.Padding = New Padding(3)
        tpLizenznutzung.Size = New Size(1291, 584)
        tpLizenznutzung.TabIndex = 4
        tpLizenznutzung.Text = "Lizenznutzung"
        tpLizenznutzung.UseVisualStyleBackColor = True
        ' 
        ' spLizenznutzung
        ' 
        spLizenznutzung.Dock = DockStyle.Fill
        spLizenznutzung.FixedPanel = FixedPanel.Panel1
        spLizenznutzung.IsSplitterFixed = True
        spLizenznutzung.Location = New Point(3, 3)
        spLizenznutzung.Name = "spLizenznutzung"
        ' 
        ' spLizenznutzung.Panel1
        ' 
        spLizenznutzung.Panel1.Controls.Add(txtmaxNutzung)
        spLizenznutzung.Panel1.Controls.Add(txtTokenpreis)
        spLizenznutzung.Panel1.Controls.Add(txtLizenzpreis)
        spLizenznutzung.Panel1.Controls.Add(Label20)
        spLizenznutzung.Panel1.Controls.Add(Label19)
        spLizenznutzung.Panel1.Controls.Add(Label18)
        spLizenznutzung.Panel1.Controls.Add(cmdGesamtAEC)
        spLizenznutzung.Panel1.Controls.Add(cmdGesamtToken)
        spLizenznutzung.Panel1.Controls.Add(cmdNutzungAEC)
        spLizenznutzung.Panel1.Controls.Add(cmdNutzungFlex)
        spLizenznutzung.Panel1.Controls.Add(Label16)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzGruppe)
        spLizenznutzung.Panel1.Controls.Add(Label15)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzZugriff)
        spLizenznutzung.Panel1.Controls.Add(Label14)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzAbteilung)
        spLizenznutzung.Panel1.Controls.Add(Label13)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzProdukt)
        spLizenznutzung.Panel1.Controls.Add(Label5)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzMonat)
        spLizenznutzung.Panel1.Controls.Add(Label6)
        spLizenznutzung.Panel1.Controls.Add(cbLizenzBenutzer)
        ' 
        ' spLizenznutzung.Panel2
        ' 
        spLizenznutzung.Panel2.Controls.Add(dgvLizenznutzung)
        spLizenznutzung.Size = New Size(1285, 578)
        spLizenznutzung.SplitterDistance = 235
        spLizenznutzung.TabIndex = 1
        ' 
        ' txtmaxNutzung
        ' 
        txtmaxNutzung.Location = New Point(156, 485)
        txtmaxNutzung.Name = "txtmaxNutzung"
        txtmaxNutzung.Size = New Size(70, 23)
        txtmaxNutzung.TabIndex = 25
        ' 
        ' txtTokenpreis
        ' 
        txtTokenpreis.Location = New Point(156, 456)
        txtTokenpreis.Name = "txtTokenpreis"
        txtTokenpreis.Size = New Size(70, 23)
        txtTokenpreis.TabIndex = 24
        ' 
        ' txtLizenzpreis
        ' 
        txtLizenzpreis.Location = New Point(156, 428)
        txtLizenzpreis.Name = "txtLizenzpreis"
        txtLizenzpreis.Size = New Size(70, 23)
        txtLizenzpreis.TabIndex = 23
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(3, 488)
        Label20.Name = "Label20"
        Label20.Size = New Size(156, 15)
        Label20.TabIndex = 22
        Label20.Text = "max. monatl. Tagesnutzung:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(0, 459)
        Label19.Name = "Label19"
        Label19.Size = New Size(80, 15)
        Label19.TabIndex = 21
        Label19.Text = "Tokenpreis [€]"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(3, 431)
        Label18.Name = "Label18"
        Label18.Size = New Size(112, 15)
        Label18.TabIndex = 20
        Label18.Text = "mittl. Lizenzpreis [€]"
        ' 
        ' cmdGesamtAEC
        ' 
        cmdGesamtAEC.Location = New Point(3, 399)
        cmdGesamtAEC.Name = "cmdGesamtAEC"
        cmdGesamtAEC.Size = New Size(223, 23)
        cmdGesamtAEC.TabIndex = 19
        cmdGesamtAEC.Text = "Gesamtbericht AEC"
        cmdGesamtAEC.UseVisualStyleBackColor = True
        ' 
        ' cmdGesamtToken
        ' 
        cmdGesamtToken.Location = New Point(3, 370)
        cmdGesamtToken.Name = "cmdGesamtToken"
        cmdGesamtToken.Size = New Size(223, 23)
        cmdGesamtToken.TabIndex = 18
        cmdGesamtToken.Text = "Gesamtbericht Token"
        cmdGesamtToken.UseVisualStyleBackColor = True
        ' 
        ' cmdNutzungAEC
        ' 
        cmdNutzungAEC.Enabled = False
        cmdNutzungAEC.Location = New Point(3, 341)
        cmdNutzungAEC.Name = "cmdNutzungAEC"
        cmdNutzungAEC.Size = New Size(223, 23)
        cmdNutzungAEC.TabIndex = 17
        cmdNutzungAEC.Text = "Monatsbericht AEC"
        cmdNutzungAEC.UseVisualStyleBackColor = True
        ' 
        ' cmdNutzungFlex
        ' 
        cmdNutzungFlex.Enabled = False
        cmdNutzungFlex.Location = New Point(3, 312)
        cmdNutzungFlex.Name = "cmdNutzungFlex"
        cmdNutzungFlex.Size = New Size(223, 23)
        cmdNutzungFlex.TabIndex = 16
        cmdNutzungFlex.Text = "Monatsbericht Flex Token"
        cmdNutzungFlex.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(0, 100)
        Label16.Name = "Label16"
        Label16.Size = New Size(46, 15)
        Label16.TabIndex = 15
        Label16.Text = "Gruppe"
        ' 
        ' cbLizenzGruppe
        ' 
        cbLizenzGruppe.FormattingEnabled = True
        cbLizenzGruppe.Location = New Point(3, 118)
        cbLizenzGruppe.Name = "cbLizenzGruppe"
        cbLizenzGruppe.Size = New Size(223, 23)
        cbLizenzGruppe.TabIndex = 14
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(3, 241)
        Label15.Name = "Label15"
        Label15.Size = New Size(62, 15)
        Label15.TabIndex = 13
        Label15.Text = "Zugriffsart"
        ' 
        ' cbLizenzZugriff
        ' 
        cbLizenzZugriff.FormattingEnabled = True
        cbLizenzZugriff.Location = New Point(3, 259)
        cbLizenzZugriff.Name = "cbLizenzZugriff"
        cbLizenzZugriff.Size = New Size(223, 23)
        cbLizenzZugriff.TabIndex = 12
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(0, 144)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 15)
        Label14.TabIndex = 11
        Label14.Text = "Abteilung"
        ' 
        ' cbLizenzAbteilung
        ' 
        cbLizenzAbteilung.FormattingEnabled = True
        cbLizenzAbteilung.Location = New Point(3, 162)
        cbLizenzAbteilung.Name = "cbLizenzAbteilung"
        cbLizenzAbteilung.Size = New Size(223, 23)
        cbLizenzAbteilung.TabIndex = 10
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(0, 192)
        Label13.Name = "Label13"
        Label13.Size = New Size(49, 15)
        Label13.TabIndex = 9
        Label13.Text = "Produkt"
        ' 
        ' cbLizenzProdukt
        ' 
        cbLizenzProdukt.FormattingEnabled = True
        cbLizenzProdukt.Location = New Point(3, 210)
        cbLizenzProdukt.Name = "cbLizenzProdukt"
        cbLizenzProdukt.Size = New Size(223, 23)
        cbLizenzProdukt.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(0, 49)
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
        Label6.Location = New Point(3, 0)
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
        dgvLizenznutzung.Size = New Size(1046, 578)
        dgvLizenznutzung.TabIndex = 0
        ' 
        ' tpAbos
        ' 
        tpAbos.Controls.Add(spAbos)
        tpAbos.Location = New Point(4, 24)
        tpAbos.Name = "tpAbos"
        tpAbos.Padding = New Padding(3)
        tpAbos.Size = New Size(1291, 584)
        tpAbos.TabIndex = 5
        tpAbos.Text = "Abonnements"
        tpAbos.UseVisualStyleBackColor = True
        ' 
        ' spAbos
        ' 
        spAbos.Dock = DockStyle.Fill
        spAbos.FixedPanel = FixedPanel.Panel1
        spAbos.IsSplitterFixed = True
        spAbos.Location = New Point(3, 3)
        spAbos.Name = "spAbos"
        ' 
        ' spAbos.Panel1
        ' 
        spAbos.Panel1.Controls.Add(Label12)
        spAbos.Panel1.Controls.Add(cbAbosProdukt)
        ' 
        ' spAbos.Panel2
        ' 
        spAbos.Panel2.Controls.Add(dgvAbos)
        spAbos.Size = New Size(1285, 578)
        spAbos.SplitterDistance = 231
        spAbos.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(8, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(49, 15)
        Label12.TabIndex = 11
        Label12.Text = "Produkt"
        ' 
        ' cbAbosProdukt
        ' 
        cbAbosProdukt.FormattingEnabled = True
        cbAbosProdukt.Location = New Point(6, 21)
        cbAbosProdukt.Name = "cbAbosProdukt"
        cbAbosProdukt.Size = New Size(223, 23)
        cbAbosProdukt.TabIndex = 10
        ' 
        ' dgvAbos
        ' 
        dgvAbos.AllowUserToAddRows = False
        dgvAbos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvAbos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvAbos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAbos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAbos.Dock = DockStyle.Fill
        dgvAbos.Location = New Point(0, 0)
        dgvAbos.Name = "dgvAbos"
        dgvAbos.Size = New Size(1050, 578)
        dgvAbos.TabIndex = 0
        ' 
        ' tpNutzung
        ' 
        tpNutzung.Controls.Add(spNutzung)
        tpNutzung.Location = New Point(4, 24)
        tpNutzung.Name = "tpNutzung"
        tpNutzung.Padding = New Padding(3)
        tpNutzung.Size = New Size(1291, 584)
        tpNutzung.TabIndex = 6
        tpNutzung.Text = "Nutzung"
        tpNutzung.UseVisualStyleBackColor = True
        ' 
        ' spNutzung
        ' 
        spNutzung.Dock = DockStyle.Fill
        spNutzung.FixedPanel = FixedPanel.Panel1
        spNutzung.IsSplitterFixed = True
        spNutzung.Location = New Point(3, 3)
        spNutzung.Name = "spNutzung"
        ' 
        ' spNutzung.Panel1
        ' 
        spNutzung.Panel1.Controls.Add(cmdBerichtAEC)
        spNutzung.Panel1.Controls.Add(cmdBerichtToken)
        spNutzung.Panel1.Controls.Add(Label11)
        spNutzung.Panel1.Controls.Add(cbNutzAccess)
        spNutzung.Panel1.Controls.Add(Label8)
        spNutzung.Panel1.Controls.Add(cbNutzMonat)
        spNutzung.Panel1.Controls.Add(Label7)
        spNutzung.Panel1.Controls.Add(cbNutzProdukt)
        spNutzung.Panel1.Controls.Add(Label9)
        spNutzung.Panel1.Controls.Add(cbNutzGruppe)
        spNutzung.Panel1.Controls.Add(Label10)
        spNutzung.Panel1.Controls.Add(cbNutzTeam)
        ' 
        ' spNutzung.Panel2
        ' 
        spNutzung.Panel2.Controls.Add(dgvNutzung)
        spNutzung.Size = New Size(1285, 578)
        spNutzung.SplitterDistance = 231
        spNutzung.TabIndex = 1
        ' 
        ' cmdBerichtAEC
        ' 
        cmdBerichtAEC.Enabled = False
        cmdBerichtAEC.Location = New Point(5, 260)
        cmdBerichtAEC.Name = "cmdBerichtAEC"
        cmdBerichtAEC.Size = New Size(221, 23)
        cmdBerichtAEC.TabIndex = 15
        cmdBerichtAEC.Text = "Monatsbericht AEC"
        cmdBerichtAEC.UseVisualStyleBackColor = True
        ' 
        ' cmdBerichtToken
        ' 
        cmdBerichtToken.Enabled = False
        cmdBerichtToken.Location = New Point(5, 231)
        cmdBerichtToken.Name = "cmdBerichtToken"
        cmdBerichtToken.Size = New Size(221, 23)
        cmdBerichtToken.TabIndex = 14
        cmdBerichtToken.Text = "Monatsbericht Flex Token"
        cmdBerichtToken.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(5, 172)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 15)
        Label11.TabIndex = 13
        Label11.Text = "Zugriff"
        ' 
        ' cbNutzAccess
        ' 
        cbNutzAccess.FormattingEnabled = True
        cbNutzAccess.Location = New Point(3, 190)
        cbNutzAccess.Name = "cbNutzAccess"
        cbNutzAccess.Size = New Size(223, 23)
        cbNutzAccess.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(5, 129)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 11
        Label8.Text = "Monat"
        ' 
        ' cbNutzMonat
        ' 
        cbNutzMonat.FormattingEnabled = True
        cbNutzMonat.Location = New Point(3, 147)
        cbNutzMonat.Name = "cbNutzMonat"
        cbNutzMonat.Size = New Size(223, 23)
        cbNutzMonat.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(5, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 15)
        Label7.TabIndex = 9
        Label7.Text = "Produkt"
        ' 
        ' cbNutzProdukt
        ' 
        cbNutzProdukt.FormattingEnabled = True
        cbNutzProdukt.Location = New Point(3, 104)
        cbNutzProdukt.Name = "cbNutzProdukt"
        cbNutzProdukt.Size = New Size(223, 23)
        cbNutzProdukt.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(5, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 15)
        Label9.TabIndex = 7
        Label9.Text = "Gruppe"
        ' 
        ' cbNutzGruppe
        ' 
        cbNutzGruppe.FormattingEnabled = True
        cbNutzGruppe.Location = New Point(3, 61)
        cbNutzGruppe.Name = "cbNutzGruppe"
        cbNutzGruppe.Size = New Size(223, 23)
        cbNutzGruppe.TabIndex = 6
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(5, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 15)
        Label10.TabIndex = 5
        Label10.Text = "Lizenz-Team"
        ' 
        ' cbNutzTeam
        ' 
        cbNutzTeam.FormattingEnabled = True
        cbNutzTeam.Location = New Point(3, 18)
        cbNutzTeam.Name = "cbNutzTeam"
        cbNutzTeam.Size = New Size(223, 23)
        cbNutzTeam.TabIndex = 4
        ' 
        ' dgvNutzung
        ' 
        dgvNutzung.AllowUserToAddRows = False
        dgvNutzung.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvNutzung.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvNutzung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvNutzung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNutzung.Dock = DockStyle.Fill
        dgvNutzung.Location = New Point(0, 0)
        dgvNutzung.Name = "dgvNutzung"
        dgvNutzung.Size = New Size(1050, 578)
        dgvNutzung.TabIndex = 0
        ' 
        ' tpAEC
        ' 
        tpAEC.Controls.Add(dgvAEC)
        tpAEC.Location = New Point(4, 24)
        tpAEC.Name = "tpAEC"
        tpAEC.Padding = New Padding(3)
        tpAEC.Size = New Size(1291, 584)
        tpAEC.TabIndex = 7
        tpAEC.Text = "AEC Bericht"
        tpAEC.UseVisualStyleBackColor = True
        ' 
        ' dgvAEC
        ' 
        dgvAEC.AllowUserToAddRows = False
        dgvAEC.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvAEC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        dgvAEC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvAEC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAEC.Dock = DockStyle.Fill
        dgvAEC.Location = New Point(3, 3)
        dgvAEC.Name = "dgvAEC"
        dgvAEC.Size = New Size(1285, 578)
        dgvAEC.TabIndex = 1
        ' 
        ' tpToken
        ' 
        tpToken.Controls.Add(dgvToken)
        tpToken.Location = New Point(4, 24)
        tpToken.Name = "tpToken"
        tpToken.Padding = New Padding(3)
        tpToken.Size = New Size(1291, 584)
        tpToken.TabIndex = 8
        tpToken.Text = "Token Bericht"
        tpToken.UseVisualStyleBackColor = True
        ' 
        ' dgvToken
        ' 
        dgvToken.AllowUserToAddRows = False
        dgvToken.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvToken.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvToken.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvToken.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvToken.Dock = DockStyle.Fill
        dgvToken.Location = New Point(3, 3)
        dgvToken.Name = "dgvToken"
        dgvToken.Size = New Size(1285, 578)
        dgvToken.TabIndex = 1
        ' 
        ' MainMenu
        ' 
        MainMenu.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, BearbeitenToolStripMenuItem})
        MainMenu.Location = New Point(0, 0)
        MainMenu.Name = "MainMenu"
        MainMenu.Size = New Size(1299, 24)
        MainMenu.TabIndex = 4
        MainMenu.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {BeendenToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(46, 20)
        ToolStripMenuItem1.Text = "Datei"
        ' 
        ' BeendenToolStripMenuItem
        ' 
        BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        BeendenToolStripMenuItem.Size = New Size(180, 22)
        BeendenToolStripMenuItem.Text = "Beenden"
        ' 
        ' BearbeitenToolStripMenuItem
        ' 
        BearbeitenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportToolStripMenuItem})
        BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        BearbeitenToolStripMenuItem.Size = New Size(75, 20)
        BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TokennutzungToolStripMenuItem, LizenznutzungToolStripMenuItem})
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(108, 22)
        ExportToolStripMenuItem.Text = "Export"
        ' 
        ' TokennutzungToolStripMenuItem
        ' 
        TokennutzungToolStripMenuItem.Name = "TokennutzungToolStripMenuItem"
        TokennutzungToolStripMenuItem.Size = New Size(150, 22)
        TokennutzungToolStripMenuItem.Text = "Tokennutzung"
        ' 
        ' LizenznutzungToolStripMenuItem
        ' 
        LizenznutzungToolStripMenuItem.Name = "LizenznutzungToolStripMenuItem"
        LizenznutzungToolStripMenuItem.Size = New Size(150, 22)
        LizenznutzungToolStripMenuItem.Text = "Lizenznutzung"
        ' 
        ' frmBrowser
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1299, 636)
        Controls.Add(tabMain)
        Controls.Add(MainMenu)
        MainMenuStrip = MainMenu
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
        tpAbos.ResumeLayout(False)
        spAbos.Panel1.ResumeLayout(False)
        spAbos.Panel1.PerformLayout()
        spAbos.Panel2.ResumeLayout(False)
        CType(spAbos, ComponentModel.ISupportInitialize).EndInit()
        spAbos.ResumeLayout(False)
        CType(dgvAbos, ComponentModel.ISupportInitialize).EndInit()
        tpNutzung.ResumeLayout(False)
        spNutzung.Panel1.ResumeLayout(False)
        spNutzung.Panel1.PerformLayout()
        spNutzung.Panel2.ResumeLayout(False)
        CType(spNutzung, ComponentModel.ISupportInitialize).EndInit()
        spNutzung.ResumeLayout(False)
        CType(dgvNutzung, ComponentModel.ISupportInitialize).EndInit()
        tpAEC.ResumeLayout(False)
        CType(dgvAEC, ComponentModel.ISupportInitialize).EndInit()
        tpToken.ResumeLayout(False)
        CType(dgvToken, ComponentModel.ISupportInitialize).EndInit()
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents tpAbos As TabPage
    Friend WithEvents tpNutzung As TabPage
    Friend WithEvents spAbos As SplitContainer
    Friend WithEvents dgvAbos As DataGridView
    Friend WithEvents spNutzung As SplitContainer
    Friend WithEvents Label9 As Label
    Friend WithEvents cbNutzGruppe As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbNutzTeam As ComboBox
    Friend WithEvents dgvNutzung As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents cbNutzMonat As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbNutzProdukt As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbNutzAccess As ComboBox
    Friend WithEvents cbProzesse As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdBerichtAEC As Button
    Friend WithEvents cmdBerichtToken As Button
    Friend WithEvents tpAEC As TabPage
    Friend WithEvents tpToken As TabPage
    Friend WithEvents dgvAEC As DataGridView
    Friend WithEvents dgvToken As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents cbAbosProdukt As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbLizenzZugriff As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbLizenzAbteilung As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbLizenzProdukt As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbLizenzGruppe As ComboBox
    Friend WithEvents cmdNutzungAEC As Button
    Friend WithEvents cmdNutzungFlex As Button
    Friend WithEvents cmdGesamtAEC As Button
    Friend WithEvents cmdGesamtToken As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents cbUserRolle As ComboBox
    Friend WithEvents cbxGastUser As CheckBox
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TokennutzungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LizenznutzungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTokenpreis As TextBox
    Friend WithEvents txtLizenzpreis As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtmaxNutzung As TextBox
End Class
