Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM attendance_tracker.admin WHERE username = '" & InUsername.Text & "' and password = '" & InPassword.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                Dashboard.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicate")

            Else
                MessageBox.Show("Username and Password are incorrect")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
