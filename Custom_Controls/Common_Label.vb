Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class Common_Label
    Inherits Label

    Public Sub New()
        Me.BackColor = Color.Transparent
        Me.ForeColor = Color.Black
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
        Me.AutoSize = True
    End Sub
    <Browsable(True)>
    <Description("Select Text Color")>
    <Category("Custom Properties")>
    Public Enum Text_Color
        White
        Green
        DarkGreen
        Blue
        Normal
    End Enum
    Public Property TextColor As Text_Color
        Get
            Return TextColor
        End Get
        Set(value As Text_Color)
            Select Case value
                Case Text_Color.Normal
                    Me.ForeColor = Color.Black
                Case Text_Color.White
                    Me.ForeColor = Color.White
                Case Text_Color.Green
                    Me.ForeColor = Color.FromArgb(84, 130, 53)
                Case Text_Color.DarkGreen
                    Me.ForeColor = Color.FromArgb(84, 130, 53)
                Case Text_Color.Blue
                    Me.ForeColor = Color.Blue
            End Select
        End Set
    End Property
    <Browsable(True)>
    <Description("Select Background Color")>
    <Category("Custom Properties")>
    Public Property BackGroundColor As Text_Color
        Get
            Return BackGroundColor
        End Get
        Set(value As Text_Color)
            Select Case value
                Case Text_Color.Normal
                    Me.BackColor = Color.Transparent
                Case Text_Color.White
                    Me.BackColor = Color.White
                Case Text_Color.Green
                    Me.BackColor = Color.FromArgb(169, 208, 142)
                Case Text_Color.DarkGreen
                    Me.BackColor = Color.FromArgb(84, 130, 53)
            End Select
        End Set
    End Property
    <Browsable(True)>
    <Description("Select FontSize")>
    <Category("Custom Properties")>
    Public Enum FontSize
        Normal
        Small
        Medium
        Large
        XLarge
    End Enum
    Public Property Font_Size As FontSize
        Get
            Return Font_Size
        End Get
        Set(value As FontSize)
            Select Case value
                Case FontSize.Normal
                    Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
                Case FontSize.Small
                    Me.Font = New System.Drawing.Font("MS Gothic", 14.0F, System.Drawing.FontStyle.Bold)
                Case FontSize.Medium
                    Me.Font = New System.Drawing.Font("MS Gothic", 16.0F, System.Drawing.FontStyle.Bold)
                Case FontSize.Large
                    Me.Font = New System.Drawing.Font("MS Gothic", 20.0F, System.Drawing.FontStyle.Bold)
                Case FontSize.XLarge
                    Me.Font = New System.Drawing.Font("MS Gothic", 24.0F, System.Drawing.FontStyle.Bold)
            End Select
        End Set
    End Property
End Class
