Imports MySql.Data.MySqlClient
Public Class sell
    Dim conn As MySqlConnection
    Dim sqlQuerry, category As String
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selecteditem As String = ComboBox1.SelectedItem.ToString()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT price FROM product WHERE name = @productname order by name;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@productname", selecteditem)

                Try
                    conn.Open()
                    Dim price As Object = cmd.ExecuteScalar()

                    If price IsNot Nothing AndAlso Not DBNull.Value.Equals(price) Then
                        txtprice.Text = Convert.ToDecimal(price).ToString("0.00")
                    Else
                        txtprice.Text = ""
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving fish price: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub RichTextBox2_TextChanges(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtQuantity, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtQuantity, "")
        End If
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim quantity As Decimal
        Dim price As Decimal

        If Decimal.TryParse(txtQuantity.Text, quantity) AndAlso Decimal.TryParse(txtprice.Text, price) Then
            Dim total As Decimal = quantity * price
            txtTotal.Text = total.ToString("0.00")
        Else
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedItem As String = ComboBox1.SelectedItem.ToString()
        Dim quantity As Decimal
        Dim price As Decimal
        Dim total As Decimal

        If Decimal.TryParse(txtQuantity.Text, quantity) AndAlso Decimal.TryParse(txtprice.Text, price) Then

            Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
            Dim checkQuantityQuery As String = "SELECT quantity FROM product WHERE name = @Item;"
            Dim updateQuantityQuery As String = "UPDATE product SET quantity = quantity - @Quantity, sold = sold + @Quantity WHERE name = @Item;"
            Dim sellQuery As String = "INSERT INTO sold (product, price, quantity, total) VALUES (@Item, @Price, @Quantity, @Total);"
            Dim updateTotalIncomeQuery As String = "UPDATE product SET totalincome = totalincome + @Total WHERE name = @Item;"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Using checkQuantityCmd As New MySqlCommand(checkQuantityQuery, conn)
                            Using updateQuantityCmd As New MySqlCommand(updateQuantityQuery, conn)
                                Using sellCmd As New MySqlCommand(sellQuery, conn)
                                    Using updateTotalIncomeCmd As New MySqlCommand(updateTotalIncomeQuery, conn)
                                        checkQuantityCmd.Parameters.AddWithValue("@Item", selectedItem)

                                        Dim availableQuantity As Object = checkQuantityCmd.ExecuteScalar()

                                        If availableQuantity IsNot Nothing AndAlso Not DBNull.Value.Equals(availableQuantity) Then
                                            Dim availableQty As Decimal = Convert.ToDecimal(availableQuantity)
                                            If quantity > availableQty Then
                                                MessageBox.Show("Not enough quantity available to sell.")
                                                Return
                                            End If

                                            total = quantity * price

                                            sellCmd.Parameters.AddWithValue("@Item", selectedItem)
                                            sellCmd.Parameters.AddWithValue("@Price", price)
                                            sellCmd.Parameters.AddWithValue("@Quantity", quantity)
                                            sellCmd.Parameters.AddWithValue("@Total", total)

                                            sellCmd.ExecuteNonQuery()

                                            updateQuantityCmd.Parameters.AddWithValue("@Item", selectedItem)
                                            updateQuantityCmd.Parameters.AddWithValue("@Quantity", quantity)
                                            updateQuantityCmd.ExecuteNonQuery()

                                            updateTotalIncomeCmd.Parameters.AddWithValue("@Item", selectedItem)
                                            updateTotalIncomeCmd.Parameters.AddWithValue("@Total", total)
                                            updateTotalIncomeCmd.ExecuteNonQuery()

                                            trans.Commit()

                                            MessageBox.Show("Item sold successfully!")

                                            txtprice.Clear()
                                            txtQuantity.Clear()
                                            txtTotal.Clear()
                                        Else
                                            MessageBox.Show("Selected item not found in the database.")
                                        End If
                                    End Using
                                End Using
                            End Using
                        End Using
                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Error selling item: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Invalid quantity or price.")
        End If
    End Sub


    Private Sub sell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT name FROM product;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim fishName As String = reader("name").ToString()
                        ComboBox1.Items.Add(fishName)
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error loading fish names: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class