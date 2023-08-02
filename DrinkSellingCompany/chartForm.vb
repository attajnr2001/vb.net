Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class chartForm

    Dim conn As MySqlConnection
    Dim sqlQuerry, category As String
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub chartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesData()
    End Sub

    Private Sub LoadSalesData()
        Dim connectionString As String = "server=localhost;user=user;password=12345678;database=db;SslMode=None;"
        Dim query As String = "SELECT DATE(time) AS salesDate, SUM(total) AS totalSales FROM sold GROUP BY DATE(time);"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim dataTable As New DataTable()
                    dataTable.Load(cmd.ExecuteReader())

                    ' Clear any existing data in the chart
                    Chart1.Series.Clear()

                    ' Create a Series for the Chart
                    Dim series As New Series()
                    series.Name = "Total Sales"
                    series.ChartType = SeriesChartType.Line
                    series.XValueType = ChartValueType.Date

                    ' Add data points to the Series based on the DataTable
                    For Each row As DataRow In dataTable.Rows
                        Dim salesDate As Date = CDate(row("salesDate"))
                        Dim totalSales As Decimal = CDec(row("totalSales"))
                        series.Points.AddXY(salesDate, totalSales)
                    Next

                    ' Add the Series to the Chart control
                    Chart1.Series.Add(series)
                Catch ex As Exception
                    MessageBox.Show("Error loading sales data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class