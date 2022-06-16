Imports System.IO
Imports System.Data
Imports System.Collections.Generic
Imports ClosedXML.Excel


Public Class frmExcelImport
    Private Sub frmExcelImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvProjectData = New Custom_Controls.custom_gridview()
        gvProjectData.AllowUserToAddRows = False
    End Sub
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFileDialog.ShowDialog()
    End Sub
    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        Dim filepath As String = OpenFileDialog.FileName
        Using workBook As New XLWorkbook(filepath)
            Dim worksheet As IXLWorksheet = workBook.Worksheet(1)

            Dim dtP As New DataTable()

            Dim firstRow As Boolean = True
            For Each row As IXLRow In worksheet.Rows()
                If firstRow Then
                    'For Each cell As IXLCell In row.Cells()
                    '    dt.Columns.Add(cell.Value.ToString())
                    'Next
                    dtP = CreateDatatable1()
                    firstRow = False
                Else
                    dtP.Rows.Add()
                    Dim i As Integer = 0
                    For Each cell As IXLCell In row.Cells
                        dtP.Rows(dtP.Rows.Count - 1)(i) = cell.Value.ToString()
                        i += 1
                    Next
                End If
                dgv1.DataSource = dtP

            Next

        End Using
    End Sub

    Private Function CreateDatatable()
        Dim dt As New DataTable()

        dt.Columns.Add("ProjectCD")
        dt.Columns.Add("ProjectName")
        dt.Columns.Add("Year")
        dt.Columns.Add("BrandCD")
        dt.Columns.Add("BrandName")
        dt.Columns.Add("Season")
        dt.Columns.Add("PeriodStart")
        dt.Columns.Add("PeriodEnd")
        dt.Columns.Add("TotalProduction")
        dt.Columns.Add("TotalAmount")
        dt.Columns.Add("UserID")
        dt.Columns.Add("UserName")

        Return dt
    End Function

    Private Function CreateDatatable1()
        Dim dt As New DataTable()

        dt.Columns.Add("ProjectCD1")
        dt.Columns.Add("ProjectName1")
        dt.Columns.Add("Year1")
        dt.Columns.Add("BrandCD1")
        dt.Columns.Add("BrandName1")
        dt.Columns.Add("Season1")
        dt.Columns.Add("PeriodStart1")
        dt.Columns.Add("PeriodEnd1")
        dt.Columns.Add("TotalProduction1")
        dt.Columns.Add("TotalAmount1")
        dt.Columns.Add("ManagerID")
        dt.Columns.Add("ManagerName")

        Return dt
    End Function
End Class