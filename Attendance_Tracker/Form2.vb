Imports MySql.Data.MySqlClient
Public Class Dashboard
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub EditData_Click(sender As Object, e As EventArgs) Handles EditData.Click
        frmEditData.Show()
        Me.Hide()
    End Sub
End Class