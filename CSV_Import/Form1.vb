Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports Custom_Controls
Imports System.Text
Imports System.Threading

Public Class CSV_Import
    Private Sub CSV_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpathfile.Select()
    End Sub

    Private Sub btnImport_Click_1(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim fName As String = ""
        Dim ext As String = ""
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.InitialDirectory = "C:\Csv"
        'OpenFileDialog1.Filter = "CSV files (*.csv)|*.CSV"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            fName = OpenFileDialog1.FileName
            txtpathfile.Text = fName
            ext = Path.GetExtension(fName)
            If Not (ext.Equals(".csv")) Then
                MsgBox("Please choose csv file")
                Return
            End If
            Dim TextLine As String = ""
            If System.IO.File.Exists(fName) = True Then
                Dim objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
                TextLine = objReader.ReadLine()
                Dim strArray As String() = TextLine.Split(","c)
                Dim dt As DataTable = New DataTable()
                Dim row As DataRow

                For Each s As String In strArray
                    dt.Columns.Add(New DataColumn())
                Next
                dt.Columns("Column1").ColumnName = "StartDate"
                dt.Columns("Column2").ColumnName = "End Date"
                dt.Columns("Column3").ColumnName = "UserCD"
                dt.Columns("Column4").ColumnName = "User Name"
                dt.Columns("Column5").ColumnName = "Full Name"
                dt.Columns("Column6").ColumnName = "Address"
                dt.Columns("Column7").ColumnName = "Remarks"
                Do
                    TextLine = objReader.ReadLine()
                    If Not TextLine = String.Empty Then
                        row = dt.NewRow()
                        row.ItemArray = TextLine.Split(","c)
                        dt.Rows.Add(row)
                        dataGridview1.DataSource = dt
                        Custom_gridview1.DataSource = dt
                    Else
                        Exit Do
                    End If
                Loop
            End If
        End If
    End Sub
End Class
