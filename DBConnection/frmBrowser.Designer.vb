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
        cmdSoftware = New Button()
        dgvInhalt = New DataGridView()
        SplitContainer1 = New SplitContainer()
        cmdConnectoren = New Button()
        TabControl1 = New TabControl()
        TabTabellen = New TabPage()
        TabImport = New TabPage()
        SplitContainer2 = New SplitContainer()
        cbUeberführen = New CheckBox()
        txtImportfile = New TextBox()
        lblSheets = New Label()
        cmdImpFile = New Button()
        cbSheets = New ComboBox()
        dgExcelcontent = New DataGridView()
        CType(dgvInhalt, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabTabellen.SuspendLayout()
        TabImport.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(dgExcelcontent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdSoftware
        ' 
        cmdSoftware.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdSoftware.Location = New Point(736, 17)
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
        dgvInhalt.Size = New Size(856, 474)
        dgvInhalt.TabIndex = 1
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(dgvInhalt)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(cmdConnectoren)
        SplitContainer1.Panel2.Controls.Add(cmdSoftware)
        SplitContainer1.Size = New Size(856, 541)
        SplitContainer1.SplitterDistance = 474
        SplitContainer1.TabIndex = 2
        ' 
        ' cmdConnectoren
        ' 
        cmdConnectoren.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmdConnectoren.Location = New Point(615, 17)
        cmdConnectoren.Name = "cmdConnectoren"
        cmdConnectoren.Size = New Size(115, 41)
        cmdConnectoren.TabIndex = 1
        cmdConnectoren.Text = "Connectoren"
        cmdConnectoren.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabTabellen)
        TabControl1.Controls.Add(TabImport)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(870, 575)
        TabControl1.TabIndex = 3
        ' 
        ' TabTabellen
        ' 
        TabTabellen.Controls.Add(SplitContainer1)
        TabTabellen.Location = New Point(4, 24)
        TabTabellen.Name = "TabTabellen"
        TabTabellen.Padding = New Padding(3)
        TabTabellen.Size = New Size(862, 547)
        TabTabellen.TabIndex = 0
        TabTabellen.Text = "Tabellen"
        TabTabellen.UseVisualStyleBackColor = True
        ' 
        ' TabImport
        ' 
        TabImport.Controls.Add(SplitContainer2)
        TabImport.Location = New Point(4, 24)
        TabImport.Name = "TabImport"
        TabImport.Padding = New Padding(3)
        TabImport.Size = New Size(862, 547)
        TabImport.TabIndex = 1
        TabImport.Text = "Import"
        TabImport.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(3, 3)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(cbUeberführen)
        SplitContainer2.Panel1.Controls.Add(txtImportfile)
        SplitContainer2.Panel1.Controls.Add(lblSheets)
        SplitContainer2.Panel1.Controls.Add(cmdImpFile)
        SplitContainer2.Panel1.Controls.Add(cbSheets)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(dgExcelcontent)
        SplitContainer2.Size = New Size(856, 541)
        SplitContainer2.SplitterDistance = 76
        SplitContainer2.TabIndex = 4
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
        dgExcelcontent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgExcelcontent.Dock = DockStyle.Fill
        dgExcelcontent.Location = New Point(0, 0)
        dgExcelcontent.Name = "dgExcelcontent"
        dgExcelcontent.Size = New Size(856, 461)
        dgExcelcontent.TabIndex = 0
        ' 
        ' frmBrowser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 575)
        Controls.Add(TabControl1)
        Name = "frmBrowser"
        Text = "frmBrowser"
        CType(dgvInhalt, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabTabellen.ResumeLayout(False)
        TabImport.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(dgExcelcontent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmdSoftware As Button
    Friend WithEvents dgvInhalt As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdConnectoren As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabTabellen As TabPage
    Friend WithEvents TabImport As TabPage
    Friend WithEvents txtImportfile As TextBox
    Friend WithEvents cmdImpFile As Button
    Friend WithEvents lblSheets As Label
    Friend WithEvents cbSheets As ComboBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents dgExcelcontent As DataGridView
    Friend WithEvents cbUeberführen As CheckBox
End Class
