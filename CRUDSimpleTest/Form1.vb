Imports System
Imports System.Data.SqlClient
Public Class CRUDSimpleTest
    Dim Connection As New SqlConnection("Data Source=163.43.105.244;Initial Catalog=Accele_Test;User ID=sa;Password=admin123456!;Connect Timeout=30")
    Private Sub CRUDSimpleTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim constring As String = "Data Source=163.43.105.244;Initial Catalog=Accele_Test;User ID=sa;Password=admin123456!;Connect Timeout=30"
        Using con As New SqlConnection(constring)
            con.Open()
            Using cmd As New SqlCommand("Select *  from  M_Rate", con)
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim insertQuery As String = "Insert Into M_Rate([BrandCD],[CategoryCD],[Rate]) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        Try
            ExecuteQuery(insertQuery)
            MsgBox("Data Inserted")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox1.Select()
            BindGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, Connection)
        Connection.Open()
        command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateQuery As String = "Update  M_Rate SET BrandCD='" & TextBox1.Text & "',CategoryCD='" & TextBox2.Text & "',Rate='" & TextBox3.Text & "' where BrandCD='" & TextBox1.Text & "'"
        Try
            ExecuteQuery(updateQuery)
            MsgBox("Data Updated")
            BindGrid()
            TextBox1.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure to delete?", "Delete document", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Dim deleteQuery As String = "Delete from  M_Rate where BrandCD='" & TextBox1.Text & "'"
            Try
                ExecuteQuery(deleteQuery)
                MsgBox("Data Deleted")
                BindGrid()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim constring As String = "Data Source=163.43.105.244;Initial Catalog=Accele_Test;User ID=sa;Password=admin123456!;Connect Timeout=30"
        Using con As New SqlConnection(constring)
            con.Open()
            Using cmd As New SqlCommand("Select *  from  M_Rate where ([BrandCD] Is Null OR ([BrandCD] ='" & TextBox1.Text & "')) And ([CategoryCD] Is Null OR ([CategoryCD] like'%" & TextBox2.Text & "%')) AND ([Rate] Is Null OR ([Rate] like '%" & TextBox3.Text & "%'))", con)
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

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyUp, TextBox2.KeyUp, TextBox1.KeyUp
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchForm.Show()
        Me.Hide()
    End Sub
End Class
