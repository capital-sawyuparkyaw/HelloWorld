Imports System.Windows.Forms
Imports System.Drawing
Public Class Common_RadioButton
    Inherits RadioButton

    Dim x As New Font("Segoe UI", 10)
    Dim y As New SolidBrush(Color.Black)
    Dim z As New Point(0, 0)
    Public Property Icons As String
    Public Common_RadioButton()
    Dim a As New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.DrawString(Icons, x, y, z)
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
        SetStyle(ControlStyles.UserPaint, True)
    End Sub
End Class
