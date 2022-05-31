Imports System
Imports System.Data.SqlClient
Imports System.IO
Public Class SearchForm
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
End Class