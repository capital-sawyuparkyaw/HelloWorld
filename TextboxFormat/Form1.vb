Imports System.Globalization

Public Class Form1
    Public ReadOnly Property out As Date
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        NumberOnly(e)
    End Sub
    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd")
        txtDate.TextAlign = HorizontalAlignment.Center
    End Sub
    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate.KeyDown
        Dim year As String
        Dim month As String
        Dim day As String
        If e.KeyCode = Keys.Enter Then
            Dim strdate As String
            Dim str2 As String = txtDate.Text
            If str2.Length = 8 Then
                day = str2.Substring(str2.Length - 2)
                month = str2.Substring(str2.Length - 4).Substring(0, 2)
                year = Convert.ToInt32(str2.Substring(0, str2.Length - 4)).ToString()
                If month = 0 Then
                    month = String.Empty
                End If
                If year = 0 Then
                    year = String.Empty
                End If
                If day = 0 Then
                    day = String.Empty
                End If
                If (String.IsNullOrWhiteSpace(month)) Then
                    month = DateTime.Now.Month.ToString().PadLeft(2)
                End If
                If (String.IsNullOrWhiteSpace(year)) Then
                    year = DateTime.Now.Year.ToString()
                End If
                If (String.IsNullOrWhiteSpace(day)) Then
                    day = DateTime.Now.Day.ToString()
                End If
                strdate = year + "/" + month + "/" + day
                txtDate.Text = strdate
            End If
        End If
    End Sub
End Class
