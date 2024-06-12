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
        CType(dgvInhalt, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmdSoftware
        ' 
        cmdSoftware.Location = New Point(682, 3)
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
        dgvInhalt.Size = New Size(800, 395)
        dgvInhalt.TabIndex = 1
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
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
        SplitContainer1.Size = New Size(800, 450)
        SplitContainer1.SplitterDistance = 395
        SplitContainer1.TabIndex = 2
        ' 
        ' cmdConnectoren
        ' 
        cmdConnectoren.Location = New Point(561, 2)
        cmdConnectoren.Name = "cmdConnectoren"
        cmdConnectoren.Size = New Size(115, 41)
        cmdConnectoren.TabIndex = 1
        cmdConnectoren.Text = "Connectoren"
        cmdConnectoren.UseVisualStyleBackColor = True
        ' 
        ' frmBrowser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Name = "frmBrowser"
        Text = "frmBrowser"
        CType(dgvInhalt, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmdSoftware As Button
    Friend WithEvents dgvInhalt As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdConnectoren As Button
End Class
