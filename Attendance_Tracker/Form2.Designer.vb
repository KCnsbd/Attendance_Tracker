<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ViewAttendance = New Button()
        MarkAttendance = New Button()
        EditData = New Button()
        LOGOUT = New Button()
        SuspendLayout()
        ' 
        ' ViewAttendance
        ' 
        ViewAttendance.Location = New Point(298, 81)
        ViewAttendance.Name = "ViewAttendance"
        ViewAttendance.Size = New Size(217, 34)
        ViewAttendance.TabIndex = 0
        ViewAttendance.Text = "View Attendance"
        ViewAttendance.UseVisualStyleBackColor = True
        ' 
        ' MarkAttendance
        ' 
        MarkAttendance.Location = New Point(298, 141)
        MarkAttendance.Name = "MarkAttendance"
        MarkAttendance.Size = New Size(217, 34)
        MarkAttendance.TabIndex = 1
        MarkAttendance.Text = "Mark Attendance"
        MarkAttendance.UseVisualStyleBackColor = True
        ' 
        ' EditData
        ' 
        EditData.Location = New Point(298, 208)
        EditData.Name = "EditData"
        EditData.Size = New Size(217, 34)
        EditData.TabIndex = 2
        EditData.Text = "Edit Data"
        EditData.UseVisualStyleBackColor = True
        ' 
        ' LOGOUT
        ' 
        LOGOUT.Location = New Point(298, 270)
        LOGOUT.Name = "LOGOUT"
        LOGOUT.Size = New Size(217, 34)
        LOGOUT.TabIndex = 3
        LOGOUT.Text = "Log Out"
        LOGOUT.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LOGOUT)
        Controls.Add(EditData)
        Controls.Add(MarkAttendance)
        Controls.Add(ViewAttendance)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ViewAttendance As Button
    Friend WithEvents MarkAttendance As Button
    Friend WithEvents EditData As Button
    Friend WithEvents LOGOUT As Button
End Class
