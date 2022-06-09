Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Public Class custom_button
    Inherits Button
    Private BtnSize As Boolean = False
    Public back_color As Button_Color
    Public f_size As FontSize
    Public Sub New()
        Me.Cursor = Cursors.Hand
        Me.BackColor = Color.FromArgb(191, 191, 191)
        Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.BorderColor = Color.Black
        Me.Margin = New Padding(1)
    End Sub
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Set Default Width")>
    <DisplayName("Set Default Width")>
    Public Property DefaultBtnSize As Boolean
        Get
            Return BtnSize
        End Get
        Set(value As Boolean)
            BtnSize = value
            If (value) Then
                Me.Width = 118
                Me.Height = 28
            End If
        End Set
    End Property
    Public Enum Button_Color
        Normal
        Yellow
        Orange
        Green
        DarkGreen
        White
        Pink
    End Enum
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Select Back Color")>
    <DisplayName("Back Color")>
    Public Property TextColor As Button_Color
        Get
            Return back_color
        End Get
        Set(value As Button_Color)
            Select Case value
                Case Button_Color.Normal
                    Me.BackColor = Color.FromArgb(191, 191, 191)
                    back_color = value
                Case Button_Color.Yellow
                    Me.BackColor = Color.FromArgb(255, 242, 204)
                    back_color = value
                Case Button_Color.Orange
                    Me.BackColor = Color.FromArgb(255, 224, 192)
                    back_color = value
                Case Button_Color.Green
                    Me.BackColor = Color.FromArgb(192, 255, 192)
                    back_color = value
                Case Button_Color.DarkGreen
                    Me.BackColor = Color.FromArgb(169, 208, 142)
                    back_color = value
                Case Button_Color.White
                    Me.BackColor = Color.FromArgb(255, 255, 255)
                    back_color = value
                Case Button_Color.Pink
                    Me.BackColor = Color.FromArgb(255, 192, 255)
                    back_color = value
            End Select
        End Set
    End Property
    Public Enum FontSize
        Normal
        XSmall
        Small
        Medium
        Large
        XLarge
    End Enum
    <Browsable(True)>
    <Description("Select FontSize")>
    <Category("Custom Properties")>
    <DisplayName("Font Size")>
    Public Property Font_Size As FontSize
        Get
            Return f_size
        End Get
        Set(value As FontSize)
            Select Case value
                Case FontSize.Normal
                    Me.Font = New System.Drawing.Font("MS Gothic", 9.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.XSmall
                    Me.Font = New System.Drawing.Font("MS Gothic", 14.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.Small
                    Me.Font = New System.Drawing.Font("MS Gothic", 22.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.Medium
                    Me.Font = New System.Drawing.Font("MS Gothic", 26.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.Large
                    Me.Font = New System.Drawing.Font("MS Gothic", 28.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.XLarge
                    Me.Font = New System.Drawing.Font("MS Gothic", 30.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
            End Select
        End Set
    End Property

End Class
