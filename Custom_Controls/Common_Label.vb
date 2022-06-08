Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class Common_Label
    Inherits Label

    Public txt_color As Text_Color
    Public f_size As FontSize
    Public Sub New()
        Me.BackColor = Color.Transparent
        'Me.ForeColor = Color.Black
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
        Me.AutoSize = True
    End Sub

    Public Enum Text_Color
        Normal
        White
        Green
        DarkGreen
        Blue

    End Enum

    <Browsable(True)>
    <Description("Select Text Color")>
    <Category("Custom Properties")>
    Public Property TextColor As Text_Color
        Get
            Return txt_color
        End Get
        Set(ByVal value As Text_Color)
            Select Case value
                Case Text_Color.Normal
                    Me.ForeColor = Color.Black
                    txt_color = value
                Case Text_Color.White
                    Me.ForeColor = Color.White
                    txt_color = value
                Case Text_Color.Green
                    Me.ForeColor = Color.FromArgb(84, 130, 53)
                    txt_color = value
                Case Text_Color.DarkGreen
                    Me.ForeColor = Color.FromArgb(84, 130, 53)
                    txt_color = value
                Case Text_Color.Blue
                    Me.ForeColor = Color.Blue
                    txt_color = value
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
                    txt_color = value
                Case Text_Color.White
                    Me.BackColor = Color.White
                    txt_color = value
                Case Text_Color.Green
                    Me.BackColor = Color.FromArgb(169, 208, 142)
                    txt_color = value
                Case Text_Color.DarkGreen
                    Me.BackColor = Color.FromArgb(84, 130, 53)
                    txt_color = value
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
            Return f_size
        End Get
        Set(value As FontSize)
            Select Case value
                Case FontSize.Normal
                    Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.Small
                    Me.Font = New System.Drawing.Font("MS Gothic", 14.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.Medium
                    Me.Font = New System.Drawing.Font("MS Gothic", 16.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.Large
                    Me.Font = New System.Drawing.Font("MS Gothic", 20.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.XLarge
                    Me.Font = New System.Drawing.Font("MS Gothic", 24.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
            End Select
        End Set
    End Property
End Class