Imports System
Imports System.Reflection
Imports Custom_Controls.Common_Label
Imports Custom_Controls.custom_button
Imports Custom_Controls.custom_gridview
Imports Custom_Controls.custom_textbox
Public Class Form1
    Dim index As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_textbox1.Select()
    End Sub

    Private Sub Custom_textbox1_KeyUp(sender As Object, e As KeyEventArgs) Handles Custom_textbox4.KeyUp, Custom_textbox3.KeyUp, Custom_textbox2.KeyUp, Custom_textbox1.KeyUp
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Custom_gridview1.Rows.Add(Custom_textbox1.Text, Custom_textbox2.Text, Custom_textbox3.Text, Custom_textbox4.Text)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Custom_textbox1.Text = String.Empty
        Custom_textbox2.Text = String.Empty
        Custom_textbox3.Text = String.Empty
        Custom_textbox4.Text = String.Empty
    End Sub

    Private Sub Custom_gridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Custom_gridview1.CellClick
        Dim selectedGV As DataGridViewRow
        selectedGV = Custom_gridview1.Rows(e.RowIndex)
        Custom_textbox1.Text = selectedGV.Cells(0).Value
        Custom_textbox2.Text = selectedGV.Cells(1).Value
        Custom_textbox3.Text = selectedGV.Cells(2).Value
        Custom_textbox4.Text = selectedGV.Cells(3).Value
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedGV As DataGridViewRow
        selectedGV = Custom_gridview1.Rows(index)
        selectedGV.Cells(0).Value = Custom_textbox1.Text
        selectedGV.Cells(1).Value = Custom_textbox2.Text
        selectedGV.Cells(2).Value = Custom_textbox3.Text
        selectedGV.Cells(3).Value = Custom_textbox4.Text
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        index = Custom_gridview1.CurrentCell.RowIndex
        Custom_gridview1.Rows.RemoveAt(index)
    End Sub
End Class
