<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        InUsername = New TextBox()
        InPassword = New TextBox()
        LogIn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(363, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(367, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' InUsername
        ' 
        InUsername.Location = New Point(252, 145)
        InUsername.Name = "InUsername"
        InUsername.Size = New Size(319, 31)
        InUsername.TabIndex = 2
        ' 
        ' InPassword
        ' 
        InPassword.Location = New Point(252, 255)
        InPassword.Name = "InPassword"
        InPassword.Size = New Size(319, 31)
        InPassword.TabIndex = 3
        ' 
        ' LogIn
        ' 
        LogIn.Location = New Point(353, 330)
        LogIn.Name = "LogIn"
        LogIn.Size = New Size(112, 34)
        LogIn.TabIndex = 4
        LogIn.Text = "LOGIN"
        LogIn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LogIn)
        Controls.Add(InPassword)
        Controls.Add(InUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Admin Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InUsername As TextBox
    Friend WithEvents InPassword As TextBox
    Friend WithEvents LogIn As Button

End Class
