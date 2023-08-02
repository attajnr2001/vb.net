Imports MySql.Data.MySqlClient
Public Class addcompany

    Dim conn As MySqlConnection
        Dim sqlQuerry, category As String
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader

    Private Sub txtPhone_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtPhone, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtPhone, "")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim companyName As String = txtName.Text
        Dim companyAddress As String = txtAddress.Text
        Dim companyPhone As String = txtPhone.Text

        ' Validate the input data (you can add more validation logic if needed)
        If String.IsNullOrWhiteSpace(companyName) OrElse String.IsNullOrWhiteSpace(companyAddress) OrElse String.IsNullOrWhiteSpace(companyPhone) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Add the data to the company table
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim insertQuery As String = "INSERT INTO company (name, address, phone) VALUES (@Name, @Address, @Phone);"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@Name", companyName)
                cmd.Parameters.AddWithValue("@Address", companyAddress)
                cmd.Parameters.AddWithValue("@Phone", companyPhone)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Company added successfully!")
                    ' Clear the textboxes after adding the data
                    txtName.Clear()
                    txtAddress.Clear()
                    txtPhone.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error adding company: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class