Imports MySql.Data.MySqlClient
Public Class addstaffA

    Dim conn As MySqlConnection
        Dim sqlQuerry, category As String
        Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub addstaffA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtrole.DropDownStyle = ComboBoxStyle.DropDownList
        txtgender.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            ErrorProvider1.SetError(txtphone, "Invalid input. Only numbers allowed.")
        Else
            ErrorProvider1.SetError(txtphone, "")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim firstName As String = txtfirstname.Text
        Dim lastName As String = txtlastname.Text
        Dim dateOfBirth As Date = DateTime.Parse(txtdateofbirth.Text)
        Dim gender As String = txtgender.Text
        Dim phone As String = txtphone.Text
        Dim password As String = txtpassword.Text
        Dim role As String = txtrole.Text

        ' Validate the input data (you can add more validation logic if needed)
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) _
            OrElse String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(phone) _
            OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(role) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Add the data to the staff table
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim insertQuery As String = "INSERT INTO staff (firstname, lastname, dateofbirth, gender, phone, password, role) " &
                                    "VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Phone, @Password, @Role);"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@FirstName", firstName)
                cmd.Parameters.AddWithValue("@LastName", lastName)
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@Gender", gender)
                cmd.Parameters.AddWithValue("@Phone", phone)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@Role", role)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Staff data added successfully!")
                    ' Clear the textboxes after adding the data
                    txtfirstname.Clear()
                    txtlastname.Clear()
                    txtgender.SelectedIndex = -1
                    txtphone.Clear()
                    txtpassword.Clear()
                    txtrole.SelectedIndex = -1
                Catch ex As Exception
                    MessageBox.Show("Error adding staff data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class