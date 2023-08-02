Imports MySql.Data.MySqlClient
Public Class editStaff


    Dim conn As MySqlConnection
        Dim sqlQuerry, category As String
        Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub editStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffIds()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedId As Integer = CInt(ComboBox1.SelectedItem)

            Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
            Dim query As String = "SELECT firstname, lastname, dateofbirth, gender, phone, password, role FROM staff WHERE id = @Id;"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Id", selectedId)

                    Try
                        conn.Open()
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            ' Populate the form controls with the retrieved staff data
                            txtfirstname.Text = reader.GetString("firstname")
                            txtlastname.Text = reader.GetString("lastname")
                            txtgender.Text = reader.GetString("gender")
                            txtphone.Text = reader.GetString("phone")
                            txtpassword.Text = reader.GetString("password")
                            txtrole.Text = reader.GetString("role")
                        End If

                        reader.Close()
                    Catch ex As Exception
                        MessageBox.Show("Error loading staff data: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedId As Integer = CInt(ComboBox1.SelectedItem)

            ' Get the updated data from the form controls
            Dim firstName As String = txtfirstname.Text
            Dim lastName As String = txtlastname.Text
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

            ' Update the staff data in the database
            Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
            Dim updateQuery As String = "UPDATE staff SET firstname = @FirstName, lastname = @LastName, " &
                                        "gender = @Gender, phone = @Phone, " &
                                        "password = @Password, role = @Role WHERE id = @Id;"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@Id", selectedId)
                    cmd.Parameters.AddWithValue("@FirstName", firstName)
                    cmd.Parameters.AddWithValue("@LastName", lastName)
                    cmd.Parameters.AddWithValue("@Gender", gender)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@Role", role)

                    Try
                        conn.Open()
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Staff data updated successfully!")
                        Else
                            MessageBox.Show("No matching staff record found for the selected ID.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error updating staff data: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Please select a staff ID before updating.")
        End If
    End Sub

    Private Sub LoadStaffIds()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT id FROM staff;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim staffId As Integer = reader.GetInt32("id")
                        ComboBox1.Items.Add(staffId)
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error loading staff IDs: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class