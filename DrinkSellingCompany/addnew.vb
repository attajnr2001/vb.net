Imports MySql.Data.MySqlClient
Public Class addnew
    Dim conn As MySqlConnection
    Dim sqlQuerry, category As String
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub RichTextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If (Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtprice, "Invalid input.")
        Else
            ErrorProvider1.SetError(txtprice, "")
        End If
    End Sub

    Private Sub txtquantity_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If (Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtquantity, "Invalid input.")
        Else
            ErrorProvider1.SetError(txtquantity, "")
        End If
    End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtprice, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtprice, "")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String = txtname.Text
        Dim price As Decimal
        Dim quantity As Integer

        If Decimal.TryParse(txtprice.Text, price) AndAlso Integer.TryParse(txtquantity.Text, quantity) Then
            Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
            Dim insertQuery As String = "INSERT INTO product (name, price, quantity) VALUES (@Name, @Price, @Quantity);"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)

                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Product added successfully!")
                        txtname.Clear()
                        txtprice.Clear()
                        txtquantity.Clear()
                    Catch ex As Exception
                        MessageBox.Show("Error adding product: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Invalid price or quantity.")
        End If
    End Sub
End Class