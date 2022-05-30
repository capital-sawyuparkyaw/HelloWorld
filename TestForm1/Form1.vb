Public Class Form1
    Private Sub Load_Click(sender As Object, e As EventArgs) Handles Load.Click
        Dim n As Integer = TextBox1.Text
        If n Mod 2 = 0 Then
            TextBox2.Text = "Even " & n
        Else
            TextBox2.Text = "Odd " & n
        End If
    End Sub
End Class
