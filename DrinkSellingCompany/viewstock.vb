Imports MySql.Data.MySqlClient
Public Class viewstock
    Dim conn As MySqlConnection
    Dim sqlQuerry, category As String
        Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub viewstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductData()
        LoadBoughtData()
    End Sub

    Private Sub LoadBoughtData()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT * FROM bought;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim dataTable As New DataTable()
                    dataTable.Load(cmd.ExecuteReader())
                    DataGridView1.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading bought data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadProductData()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT * FROM product;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim dataTable As New DataTable()
                    dataTable.Load(cmd.ExecuteReader())
                    DataGridView2.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading product data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class