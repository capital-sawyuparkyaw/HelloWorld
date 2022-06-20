Imports System.IO
Imports System.Data
Imports System.Collections.Generic
Imports ClosedXML.Excel


Public Class frmExcelImport
    Public fs As IO.FileStream

    Private Sub frmExcelImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvProjectData = New Custom_Controls.custom_gridview()
        gvProjectData.AllowUserToAddRows = False
        gvProjectData.AutoGenerateColumns = True
    End Sub
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFileDialog.ShowDialog()
    End Sub
    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        Dim filepath As String = OpenFileDialog.FileName
        Dim open As Boolean = False
        open = Test(filepath)
        If Not open Then
            Using workBook As New XLWorkbook(filepath)
                Dim worksheet As IXLWorksheet = workBook.Worksheet(1)

                Dim dt As New DataTable()

                Dim firstRow As Boolean = True
                For Each row As IXLRow In worksheet.Rows()
                    If firstRow Then
                        'For Each cell As IXLCell In row.Cells()
                        '    dt.Columns.Add(cell.Value.ToString())
                        'Next
                        firstRow = False
                    Else
                        dt.Rows.Add()
                        Dim i As Integer = 0
                        For Each cell As IXLCell In row.Cells
                            dt.Rows(dt.Rows.Count - 1)(i) = cell.Value.ToString()
                            i += 1
                        Next
                    End If

                    Dim colname() As Integer = {"プロジェクトコード", "プロジェクト名", "年度", "ブランドコード", "ブランドコード1", "シーズン", "予定期間　開始", "予定期間　終了", "総生産数", "総金額", "", "責任者コード", "責任者名"}

                    For Each i In colname
                        If Not dt.Columns(i).ColumnName.ToString().Equals(colname(i)) Then
                            MessageBox.Show("Excel column is not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        Else
                            Dim dtresult = CreateDatatable()
                            dtresult = dt
                            gvProjectData.DataSource = dtresult
                        End If
                    Next
                Next

            End Using
        End If
    End Sub

    Public Function Test(ByRef sName As String) As Boolean
        Try
            fs = File.Open(sName, FileMode.Open, FileAccess.Read, FileShare.None)
            Return False

        Catch ex As Exception
            Dim yn = MessageBox.Show("Imported Excel file is Opened.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End Try

    End Function


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