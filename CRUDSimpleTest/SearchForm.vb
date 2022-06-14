Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Public Class SearchForm
    Public Property CostCD As String
    Dim savedialog As SaveFileDialog
    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim constring As String = "Data Source=163.43.105.244;Initial Catalog=Accele_Test;User ID=sa;Password=admin123456!;Connect Timeout=30"
        Using con As New SqlConnection(constring)
            con.Open()
            Using cmd As New SqlCommand("Select *  from  D_Cost", con)
                cmd.CommandType = CommandType.Text
                Using sda As New SqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                        con.Close()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedGV As DataGridViewRow
        selectedGV = DataGridView1.Rows(e.RowIndex)
        txtCostCD.Text = selectedGV.Cells(1).Value
        cboYear.Text = selectedGV.Cells(2).Value
        cboSeason.Text = selectedGV.Cells(3).Value
        txtBrandCD.Text = selectedGV.Cells(5).Value
        txtProjectCD.Text = selectedGV.Cells(6).Value
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        GetData()
        CRUDSimpleTest.UserControl11.Code = CostCD
        CRUDSimpleTest.UserControl11.Select()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xlapp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlapp = New Excel.Application
        xlWorkBook = xlapp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("Sheet1"), Excel.Worksheet)

        For k = 0 To DataGridView1.ColumnCount - 1
            xlWorkSheet.Cells(1, k + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Cells(1, k + 1) = DataGridView1.Columns(k).Name
        Next
        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Cells(i + 2, j + 1) =
                    DataGridView1(j, i).Value.ToString()
            Next
        Next

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Title = "Save"
        SaveFileDialog1.FileName = "TestExcelFormat"
        SaveFileDialog1.RestoreDirectory = True
        Dim folderpath As String = "C:\\Excel\\"
        If Directory.Exists(folderpath) Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                MsgBox("Save file success")
            Else
                Return
            End If
        Else
            Directory.CreateDirectory(folderpath)
        End If
        xlWorkBook.Close()
        xlapp.Quit()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        GetData()
    End Sub
    Public Sub GetData()
        If DataGridView1.CurrentRow IsNot "" AndAlso DataGridView1.CurrentRow.Index >= 0 Then
            CostCD = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            CRUDSimpleTest.UserControl11.Code = CostCD
            CRUDSimpleTest.UserControl11.Select()
            Me.Close()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim csv As String = String.Empty
        For Each column As DataGridViewColumn In DataGridView1.Columns
            csv += column.HeaderText & ","c
        Next
        csv += vbCr & vbLf
        For Each row As DataGridViewRow In DataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                csv += cell.Value.ToString().Replace(",", ";") & ","c
            Next
            csv += vbCr & vbLf
        Next
        Dim folderPath As String = "C:\CSV\"
        File.WriteAllText(folderPath & "DataGridViewExport.csv", csv)
    End Sub
End Class