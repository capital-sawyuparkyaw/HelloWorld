Imports System.IO
Imports System.Data
Imports ClosedXML.Excel

Public Class frmExcelImport
    Private Sub frmExcelImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim od = New OpenFileDialog()
        od.ShowDialog()

    End Sub
End Class