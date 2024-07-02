<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFES
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
        tabFES = New TabControl()
        tpApps = New TabPage()
        dgvApps = New DataGridView()
        tpTabs = New TabPage()
        dgvTabs = New DataGridView()
        tpForms = New TabPage()
        dgvForms = New DataGridView()
        tpControls = New TabPage()
        dgvControls = New DataGridView()
        tpValues = New TabPage()
        dgvValues = New DataGridView()
        tpButtons = New TabPage()
        dgvButtons = New DataGridView()
        tpFunctions = New TabPage()
        dgvFunctions = New DataGridView()
        tabFES.SuspendLayout()
        tpApps.SuspendLayout()
        CType(dgvApps, ComponentModel.ISupportInitialize).BeginInit()
        tpTabs.SuspendLayout()
        CType(dgvTabs, ComponentModel.ISupportInitialize).BeginInit()
        tpForms.SuspendLayout()
        CType(dgvForms, ComponentModel.ISupportInitialize).BeginInit()
        tpControls.SuspendLayout()
        CType(dgvControls, ComponentModel.ISupportInitialize).BeginInit()
        tpValues.SuspendLayout()
        CType(dgvValues, ComponentModel.ISupportInitialize).BeginInit()
        tpButtons.SuspendLayout()
        CType(dgvButtons, ComponentModel.ISupportInitialize).BeginInit()
        tpFunctions.SuspendLayout()
        CType(dgvFunctions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabFES
        ' 
        tabFES.Controls.Add(tpApps)
        tabFES.Controls.Add(tpTabs)
        tabFES.Controls.Add(tpForms)
        tabFES.Controls.Add(tpControls)
        tabFES.Controls.Add(tpValues)
        tabFES.Controls.Add(tpButtons)
        tabFES.Controls.Add(tpFunctions)
        tabFES.Dock = DockStyle.Fill
        tabFES.Location = New Point(0, 0)
        tabFES.Name = "tabFES"
        tabFES.SelectedIndex = 0
        tabFES.Size = New Size(800, 450)
        tabFES.TabIndex = 0
        ' 
        ' tpApps
        ' 
        tpApps.Controls.Add(dgvApps)
        tpApps.Location = New Point(4, 24)
        tpApps.Name = "tpApps"
        tpApps.Padding = New Padding(3)
        tpApps.Size = New Size(792, 422)
        tpApps.TabIndex = 0
        tpApps.Text = "Aplikationen"
        tpApps.UseVisualStyleBackColor = True
        ' 
        ' dgvApps
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvApps.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvApps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApps.Dock = DockStyle.Fill
        dgvApps.Location = New Point(3, 3)
        dgvApps.Name = "dgvApps"
        dgvApps.Size = New Size(786, 416)
        dgvApps.TabIndex = 0
        ' 
        ' tpTabs
        ' 
        tpTabs.Controls.Add(dgvTabs)
        tpTabs.Location = New Point(4, 24)
        tpTabs.Name = "tpTabs"
        tpTabs.Padding = New Padding(3)
        tpTabs.Size = New Size(792, 422)
        tpTabs.TabIndex = 1
        tpTabs.Text = "Tabs"
        ' 
        ' dgvTabs
        ' 
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvTabs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        dgvTabs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvTabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTabs.Dock = DockStyle.Fill
        dgvTabs.Location = New Point(3, 3)
        dgvTabs.Name = "dgvTabs"
        dgvTabs.Size = New Size(786, 416)
        dgvTabs.TabIndex = 0
        ' 
        ' tpForms
        ' 
        tpForms.Controls.Add(dgvForms)
        tpForms.Location = New Point(4, 24)
        tpForms.Name = "tpForms"
        tpForms.Padding = New Padding(3)
        tpForms.Size = New Size(792, 422)
        tpForms.TabIndex = 2
        tpForms.Text = "Forms"
        tpForms.UseVisualStyleBackColor = True
        ' 
        ' dgvForms
        ' 
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvForms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dgvForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvForms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvForms.Dock = DockStyle.Fill
        dgvForms.Location = New Point(3, 3)
        dgvForms.Name = "dgvForms"
        dgvForms.Size = New Size(786, 416)
        dgvForms.TabIndex = 0
        ' 
        ' tpControls
        ' 
        tpControls.Controls.Add(dgvControls)
        tpControls.Location = New Point(4, 24)
        tpControls.Name = "tpControls"
        tpControls.Padding = New Padding(3)
        tpControls.Size = New Size(792, 422)
        tpControls.TabIndex = 3
        tpControls.Text = "Controls"
        tpControls.UseVisualStyleBackColor = True
        ' 
        ' dgvControls
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvControls.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvControls.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvControls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvControls.Dock = DockStyle.Fill
        dgvControls.Location = New Point(3, 3)
        dgvControls.Name = "dgvControls"
        dgvControls.Size = New Size(786, 416)
        dgvControls.TabIndex = 1
        ' 
        ' tpValues
        ' 
        tpValues.Controls.Add(dgvValues)
        tpValues.Location = New Point(4, 24)
        tpValues.Name = "tpValues"
        tpValues.Padding = New Padding(3)
        tpValues.Size = New Size(792, 422)
        tpValues.TabIndex = 4
        tpValues.Text = "Values"
        tpValues.UseVisualStyleBackColor = True
        ' 
        ' dgvValues
        ' 
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvValues.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvValues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvValues.Dock = DockStyle.Fill
        dgvValues.Location = New Point(3, 3)
        dgvValues.Name = "dgvValues"
        dgvValues.Size = New Size(786, 416)
        dgvValues.TabIndex = 1
        ' 
        ' tpButtons
        ' 
        tpButtons.Controls.Add(dgvButtons)
        tpButtons.Location = New Point(4, 24)
        tpButtons.Name = "tpButtons"
        tpButtons.Padding = New Padding(3)
        tpButtons.Size = New Size(792, 422)
        tpButtons.TabIndex = 5
        tpButtons.Text = "Buttons"
        tpButtons.UseVisualStyleBackColor = True
        ' 
        ' dgvButtons
        ' 
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvButtons.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        dgvButtons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvButtons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvButtons.Dock = DockStyle.Fill
        dgvButtons.Location = New Point(3, 3)
        dgvButtons.Name = "dgvButtons"
        dgvButtons.Size = New Size(786, 416)
        dgvButtons.TabIndex = 1
        ' 
        ' tpFunctions
        ' 
        tpFunctions.Controls.Add(dgvFunctions)
        tpFunctions.Location = New Point(4, 24)
        tpFunctions.Name = "tpFunctions"
        tpFunctions.Padding = New Padding(3)
        tpFunctions.Size = New Size(792, 422)
        tpFunctions.TabIndex = 6
        tpFunctions.Text = "Functions"
        tpFunctions.UseVisualStyleBackColor = True
        ' 
        ' dgvFunctions
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvFunctions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvFunctions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvFunctions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFunctions.Dock = DockStyle.Fill
        dgvFunctions.Location = New Point(3, 3)
        dgvFunctions.Name = "dgvFunctions"
        dgvFunctions.Size = New Size(786, 416)
        dgvFunctions.TabIndex = 1
        ' 
        ' frmFES
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tabFES)
        Name = "frmFES"
        Text = "Fichtner Engineering Suite Konfigurator"
        tabFES.ResumeLayout(False)
        tpApps.ResumeLayout(False)
        CType(dgvApps, ComponentModel.ISupportInitialize).EndInit()
        tpTabs.ResumeLayout(False)
        CType(dgvTabs, ComponentModel.ISupportInitialize).EndInit()
        tpForms.ResumeLayout(False)
        CType(dgvForms, ComponentModel.ISupportInitialize).EndInit()
        tpControls.ResumeLayout(False)
        CType(dgvControls, ComponentModel.ISupportInitialize).EndInit()
        tpValues.ResumeLayout(False)
        CType(dgvValues, ComponentModel.ISupportInitialize).EndInit()
        tpButtons.ResumeLayout(False)
        CType(dgvButtons, ComponentModel.ISupportInitialize).EndInit()
        tpFunctions.ResumeLayout(False)
        CType(dgvFunctions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabFES As TabControl
    Friend WithEvents tpApps As TabPage
    Friend WithEvents tpTabs As TabPage
    Friend WithEvents dgvApps As DataGridView
    Friend WithEvents dgvTabs As DataGridView
    Friend WithEvents tpForms As TabPage
    Friend WithEvents dgvForms As DataGridView
    Friend WithEvents tpControls As TabPage
    Friend WithEvents dgvControls As DataGridView
    Friend WithEvents tpValues As TabPage
    Friend WithEvents dgvValues As DataGridView
    Friend WithEvents tpButtons As TabPage
    Friend WithEvents dgvButtons As DataGridView
    Friend WithEvents tpFunctions As TabPage
    Friend WithEvents dgvFunctions As DataGridView
End Class
