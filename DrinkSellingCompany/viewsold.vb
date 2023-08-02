Imports MySql.Data.MySqlClient
Public Class viewsold
    Dim conn As MySqlConnection
    Dim sqlQuerry, category As String
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chartForm.Show()
    End Sub

    Private Sub viewsold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT * FROM sold;"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim dataTable As New DataTable()
                    dataTable.Load(cmd.ExecuteReader())
                    DataGridView1.DataSource = dataTable

                    ' Now, calculate the sum of the "total" field for each day and display it in DataGridView2
                    Dim sumQuery As String = "SELECT DATE(time) AS SoldDate, SUM(total) AS TotalSum FROM sold GROUP BY SoldDate;"
                    Dim sumDataTable As New DataTable()

                    Using sumCmd As New MySqlCommand(sumQuery, conn)
                        sumDataTable.Load(sumCmd.ExecuteReader())
                        DataGridView2.DataSource = sumDataTable
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


End Class