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
        'CRUDSimpleTest.TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        'CRUDSimpleTest.TextBox1.Select()
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
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            MsgBox("Save file success")
        Else
            Return
        End If
        xlWorkBook.Close()
        xlapp.Quit()
        'Try
        '    Dim folderPath As String
        '    Dim filename As String = "TestingExcel"
        '    folderPath = "C:\\Excel\\"
        '    If Directory.Exists(folderPath) Then
        '        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        '        Dim xlWorkbook As Microsoft.Office.Interop.Excel.Workbook
        '        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        '        Dim misValue As Object = System.Reflection.Missing.Value
        '        Dim i As Integer
        '        Dim j As Integer
        '        xlApp = New Microsoft.Office.Interop.Excel.Application
        '        xlWorkbook = xlApp.Workbooks.Add(misValue)
        '        xlWorkSheet = xlWorkbook.Sheets("sheet1")
        '        xlWorkSheet.Columns.AutoFit()
        '        For i = 0 To DataGridView1.Rows.Count - 2
        '            For j = 0 To DataGridView1.Columns.Count - 1
        '                For k As Integer = 1 To DataGridView1.Columns.Count
        '                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        '                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, 1).Value.ToString
        '                Next
        '            Next
        '        Next
        '    Else
        '        Directory.CreateDirectory(folderPath)
        '    End If
        'Catch ex As Exception

        'End Try
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
End Class