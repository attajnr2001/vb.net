Imports MySql.Data.MySqlClient
Public Class login
    Dim conn As MySqlConnection
    Dim sqlQuerry, category As String
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Sub login()

        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            ' Use parameters to avoid SQL injection
            sqlQuerry = "SELECT * FROM staff WHERE id = @UserID AND password = @Password"
            cmd = New MySqlCommand(sqlQuerry, conn)
            cmd.Parameters.AddWithValue("@UserID", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@Password", RichTextBox2.Text)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Dim staffRole As String = dr("role").ToString()
                If staffRole = "Admin" Then
                    formParent.SetAdminPermissions(True)
                Else
                    formParent.SetAdminPermissions(False)
                End If

                formParent.Show()
                RichTextBox1.Clear()
                RichTextBox2.Clear()
                Hide()
            Else
                MessageBox.Show("Invalid user ID or password.")
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        End Try

    End Sub


    Private Sub RichTextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If (Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(RichTextBox1, "Invalid input.")
        Else
            ErrorProvider1.SetError(RichTextBox1, "")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login()
    End Sub
End Class