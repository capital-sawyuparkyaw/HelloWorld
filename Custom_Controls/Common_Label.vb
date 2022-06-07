Imports System.Windows.Forms
Imports System.Drawing

Public Class Common_Label
    Inherits Label
    Dim tmr As FontSize
    Public Sub New()
        If FontSize.Normal Then
            Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
        ElseIf FontSize.Small Then
            Me.Font = New System.Drawing.Font("MS Gothic", 14.0F, System.Drawing.FontStyle.Bold)
        ElseIf FontSize.Medium Then
            Me.Font = New System.Drawing.Font("MS Gothic", 16.0F, System.Drawing.FontStyle.Bold)
        ElseIf FontSize.Large Then
            Me.Font = New System.Drawing.Font("MS Gothic", 20.0F, System.Drawing.FontStyle.Bold)
        ElseIf FontSize.XLarge Then
            Me.Font = New System.Drawing.Font("MS Gothic", 24.0F, System.Drawing.FontStyle.Bold)
        End If
    End Sub

    Public Enum Color
        White
        Green
        DarkGreen
        Blue
    End Enum

    Public Enum FontSize
        Normal
        Small
        Medium
        Large
        XLarge
    End Enum
    'Private Sub Font_Size(ByVal Obj As Object, ByVal e As EventArgs)
    '    If FontSize.Normal Then
    '        Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
    '    ElseIf FontSize.Small Then
    '        Me.Font = New System.Drawing.Font("MS Gothic", 14.0F, System.Drawing.FontStyle.Bold)
    '    ElseIf FontSize.Medium Then
    '        Me.Font = New System.Drawing.Font("MS Gothic", 16.0F, System.Drawing.FontStyle.Bold)
    '    ElseIf FontSize.Large Then
    '        Me.Font = New System.Drawing.Font("MS Gothic", 20.0F, System.Drawing.FontStyle.Bold)
    '    ElseIf FontSize.XLarge Then
    '        Me.Font = New System.Drawing.Font("MS Gothic", 24.0F, System.Drawing.FontStyle.Bold)
    '    End If
    'End Sub
End Class
