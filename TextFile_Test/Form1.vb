Imports System
Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim folderPath As String
        Dim lines() As String
        Dim vals() As String
        folderPath = "C:\Users\Shwe Eain San\Downloads\textfile.txt"

        lines = File.ReadAllLines(folderPath)
        For i As Integer = 0 To lines.Length - 1 Step +1
            vals = lines(i).ToString().Split(" ")
            Dim row(vals.Length - 1) As String
            For j As Integer = 0 To vals.Length - 1 Step +1
                row(j) = vals(j).Trim
            Next j
            DataGridView1.Rows.Add(row)
        Next i
    End Sub
End Class
