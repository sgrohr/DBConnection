<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdLogin = New Button()
        txtServer = New TextBox()
        txtUser = New TextBox()
        txtPasswort = New TextBox()
        txtDatenbank = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cmdEnde = New Button()
        cbServer = New ComboBox()
        SuspendLayout()
        ' 
        ' cmdLogin
        ' 
        cmdLogin.Location = New Point(125, 138)
        cmdLogin.Name = "cmdLogin"
        cmdLogin.Size = New Size(77, 28)
        cmdLogin.TabIndex = 0
        cmdLogin.Text = "weiter"
        cmdLogin.UseVisualStyleBackColor = True
        ' 
        ' txtServer
        ' 
        txtServer.Location = New Point(52, 128)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(114, 23)
        txtServer.TabIndex = 1
        txtServer.Visible = False
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(88, 70)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(114, 23)
        txtUser.TabIndex = 2
        ' 
        ' txtPasswort
        ' 
        txtPasswort.Location = New Point(88, 99)
        txtPasswort.Name = "txtPasswort"
        txtPasswort.PasswordChar = "*"c
        txtPasswort.Size = New Size(114, 23)
        txtPasswort.TabIndex = 3
        ' 
        ' txtDatenbank
        ' 
        txtDatenbank.Location = New Point(88, 41)
        txtDatenbank.Name = "txtDatenbank"
        txtDatenbank.Size = New Size(114, 23)
        txtDatenbank.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 5
        Label1.Text = "Server:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 6
        Label2.Text = "Datenbank:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 7
        Label3.Text = "Benutzer:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 8
        Label4.Text = "Passwort:"
        ' 
        ' cmdEnde
        ' 
        cmdEnde.Location = New Point(19, 138)
        cmdEnde.Name = "cmdEnde"
        cmdEnde.Size = New Size(77, 28)
        cmdEnde.TabIndex = 9
        cmdEnde.Text = "Beenden"
        cmdEnde.UseVisualStyleBackColor = True
        ' 
        ' cbServer
        ' 
        cbServer.FormattingEnabled = True
        cbServer.Items.AddRange(New Object() {"<DB auswählen>", "Software", "FES-Test", "FES-Produktiv"})
        cbServer.Location = New Point(88, 12)
        cbServer.Name = "cbServer"
        cbServer.Size = New Size(114, 23)
        cbServer.TabIndex = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(215, 174)
        Controls.Add(cbServer)
        Controls.Add(cmdEnde)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtDatenbank)
        Controls.Add(txtPasswort)
        Controls.Add(txtUser)
        Controls.Add(txtServer)
        Controls.Add(cmdLogin)
        MaximumSize = New Size(231, 213)
        MinimumSize = New Size(231, 213)
        Name = "Login"
        Text = "PostgreSQL Browser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdLogin As Button
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents txtDatenbank As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdEnde As Button
    Friend WithEvents cbServer As ComboBox

End Class
