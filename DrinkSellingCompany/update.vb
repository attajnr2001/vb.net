Imports MySql.Data.MySqlClient
Public Class update

    Dim conn As MySqlConnection
        Dim sqlQuerry, category As String
        Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader


    Private Sub UpdateTotal()
        Dim price As Decimal
        Dim quantity As Integer

        If Decimal.TryParse(txtprice.Text, price) AndAlso Integer.TryParse(txtQuantity.Text, quantity) Then
            Dim total As Decimal = price * quantity
            txtTotal.Text = total.ToString()
        Else
            txtTotal.Text = ""
        End If
    End Sub
    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbname.DropDownStyle = ComboBoxStyle.DropDownList
        cmbcompany.DropDownStyle = ComboBoxStyle.DropDownList
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"

        ' Load product names into ComboBox1
        Dim productQuery As String = "SELECT name FROM product;"
        LoadComboBoxItems(cmbname, connectionString, productQuery)

        ' Load company names into cmbcompany
        Dim companyQuery As String = "SELECT name FROM company;"
        LoadComboBoxItems(cmbcompany, connectionString, companyQuery)
    End Sub



    Private Sub txtnewprice_TextChanged(sender As Object, e As EventArgs) 
        Dim selecteditem As String = cmbname.SelectedItem.ToString()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT price FROM product WHERE name = @productname order by name;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@productname", selecteditem)

                Try
                    conn.Open()
                    Dim price As Object = cmd.ExecuteScalar()

                    If price IsNot Nothing AndAlso Not DBNull.Value.Equals(price) Then
                        txtnewprice.Text = Convert.ToDecimal(price).ToString("0.00")
                    Else
                        txtnewprice.Text = ""
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving fish price: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim productName As String = cmbname.Text
        Dim companyName As String = cmbcompany.Text
        Dim newPrice As Decimal = txtnewprice.Text
        Dim price As Decimal = txtprice.Text
        Dim quantity As Integer
        Dim total As Decimal

        If Decimal.TryParse(txtprice.Text, price) AndAlso Integer.TryParse(txtQuantity.Text, quantity) Then
            total = price * quantity

            Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
            Dim selectTotalIncomeQuery As String = "SELECT totalincome FROM product WHERE name = @ProductName;"
            Dim updatePriceQuery As String = "UPDATE product SET price = @NewPrice, totalincome = totalincome - @Total WHERE name = @ProductName;"
            Dim insertQuery As String = "INSERT INTO bought (name, company, price, total, quantity) VALUES (@Name, @Company, @Price, @Total, @Quantity);"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Check if the update will result in a negative totalincome
                        Using selectTotalIncomeCmd As New MySqlCommand(selectTotalIncomeQuery, conn)
                            selectTotalIncomeCmd.Parameters.AddWithValue("@ProductName", productName)
                            Dim totalIncomeObj As Object = selectTotalIncomeCmd.ExecuteScalar()

                            If totalIncomeObj IsNot Nothing AndAlso Not DBNull.Value.Equals(totalIncomeObj) Then
                                Dim totalIncome As Decimal = Convert.ToDecimal(totalIncomeObj)
                                Dim newTotalIncome As Decimal = totalIncome - total

                                If newTotalIncome >= 0 Then
                                    ' Update the "price" field and "totalincome" field in the "product" table
                                    Using updatePriceCmd As New MySqlCommand(updatePriceQuery, conn)
                                        updatePriceCmd.Parameters.AddWithValue("@NewPrice", newPrice)
                                        updatePriceCmd.Parameters.AddWithValue("@Total", total)
                                        updatePriceCmd.Parameters.AddWithValue("@ProductName", productName)
                                        updatePriceCmd.ExecuteNonQuery()
                                    End Using

                                    ' Insert the data into the "bought" table
                                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                                        insertCmd.Parameters.AddWithValue("@Name", productName)
                                        insertCmd.Parameters.AddWithValue("@Company", companyName)
                                        insertCmd.Parameters.AddWithValue("@Price", price) ' Use the new price
                                        insertCmd.Parameters.AddWithValue("@Total", total)
                                        insertCmd.Parameters.AddWithValue("@Quantity", quantity)
                                        insertCmd.ExecuteNonQuery()
                                    End Using

                                    trans.Commit()
                                    MessageBox.Show("Data added to 'bought' table successfully!")
                                    txtQuantity.Clear()
                                    txtTotal.Clear()
                                Else
                                    ' Show a message box to warn the user about the negative totalincome and ask for confirmation
                                    Dim result As DialogResult = MessageBox.Show("Updating 'totalincome' would result in a negative value. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                                    If result = DialogResult.Yes Then
                                        ' User chooses to continue
                                        ' Update the "price" field and "totalincome" field in the "product" table
                                        Using updatePriceCmd As New MySqlCommand(updatePriceQuery, conn)
                                            updatePriceCmd.Parameters.AddWithValue("@NewPrice", newPrice)
                                            updatePriceCmd.Parameters.AddWithValue("@Total", total)
                                            updatePriceCmd.Parameters.AddWithValue("@ProductName", productName)
                                            updatePriceCmd.ExecuteNonQuery()
                                        End Using

                                        ' Insert the data into the "bought" table
                                        Using insertCmd As New MySqlCommand(insertQuery, conn)
                                            insertCmd.Parameters.AddWithValue("@Name", productName)
                                            insertCmd.Parameters.AddWithValue("@Company", companyName)
                                            insertCmd.Parameters.AddWithValue("@Price", price) ' Use the new price
                                            insertCmd.Parameters.AddWithValue("@Total", total)
                                            insertCmd.Parameters.AddWithValue("@Quantity", quantity)
                                            insertCmd.ExecuteNonQuery()
                                        End Using

                                        trans.Commit()
                                        MessageBox.Show("Data added to 'bought' table successfully!")
                                        txtQuantity.Clear()
                                        txtTotal.Clear()
                                    End If
                                End If
                            Else
                                MessageBox.Show("Selected product not found in the database.")
                            End If
                        End Using
                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Error adding data to 'bought' table: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Invalid new price or quantity.")
        End If
    End Sub


    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        UpdateTotal()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        UpdateTotal()
    End Sub

    Private Sub cmbname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbname.SelectedIndexChanged
        Dim selecteditem As String = cmbname.SelectedItem.ToString()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT price FROM product WHERE name = @productname order by name;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@productname", selecteditem)

                Try
                    conn.Open()
                    Dim price As Object = cmd.ExecuteScalar()

                    If price IsNot Nothing AndAlso Not DBNull.Value.Equals(price) Then
                        txtnewprice.Text = Convert.ToDecimal(price).ToString("0.00")
                    Else
                        txtnewprice.Text = ""
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving fish price: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtprice, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtprice, "")
        End If
    End Sub

    Private Sub txtnewprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnewprice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtnewprice, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtnewprice, "")
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtQuantity, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtQuantity, "")
        End If
    End Sub

    Private Sub LoadComboBoxItems(comboBox As ComboBox, connectionString As String, query As String)
        comboBox.Items.Clear()

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim itemName As String = reader("name").ToString()
                        comboBox.Items.Add(itemName)
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error loading items: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class