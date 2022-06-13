Imports System
Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Drawing
Imports System.Globalization
Public Class custom_textbox
    Inherits TextBox
    Private txt As TextBox = Nothing
    Public textboxtype As type
    Public allowminus As Boolean = False
    Public IsRequired As Boolean = False
    Public Enum type
        Origin = 0
        Number = 1
        Price = 2
        DDate = 3
        YearMonth = 4
        Time = 5
    End Enum

    <Browsable(True)>
    <Description("Select Textbox Type")>
    <Category("Custom Properties")>
    <DisplayName("Type")>
    Public Property textbox_type As type
        Get
            Return textboxtype
        End Get
        Set(ByVal value As type)
            textboxtype = value
        End Set
    End Property

    <Browsable(True)>
    <Description("Allow Minus")>
    <Category("Custom Properties")>
    <DisplayName("Allow Minus")>
    Public Property allow_minus As Boolean
        Get
            Return allowminus
        End Get
        Set(ByVal value As Boolean)
            allowminus = value
        End Set
    End Property

    <Browsable(True)>
    <Description("Is Required")>
    <Category("Custom Properties")>
    <DisplayName("Is Required")>
    Public Property is_required As Boolean
        Get
            Return IsRequired
        End Get
        Set(ByVal value As Boolean)
            IsRequired = value
        End Set
    End Property
    Private Sub SetTextAlign()
        Select Case (textbox_type)
            Case textbox_type = type.Origin
                Me.TextAlign = HorizontalAlignment.Left
            Case textbox_type = type.Price
                Me.TextAlign = HorizontalAlignment.Right
            Case textbox_type = type.Number
                Me.TextAlign = HorizontalAlignment.Left
            Case textbox_type = type.DDate
                Me.TextAlign = HorizontalAlignment.Center
                Me.MaxLength = 10
            Case textbox_type = type.YearMonth
                Me.TextAlign = HorizontalAlignment.Center
                Me.MaxLength = 7
            Case textbox_type = type.Time
                Me.TextAlign = HorizontalAlignment.Center
                Me.MaxLength = 8
        End Select
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)

        If textbox_type = type.Price Then
            If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Chr(Keys.Back)) Or (e.KeyChar = ",") Or (e.KeyChar = ".")) Or (e.KeyChar = "\u0016" Or e.KeyChar = "\u0001" Or e.KeyChar = "\u0003" Or e.KeyChar = "\u0018") Or (e.KeyChar = "-" And allowminus) Or (e.KeyChar = Chr(Keys.Enter)) Then
                e.Handled = False
            Else e.Handled = True
            End If
        ElseIf textbox_type = type.Number Then
            If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Chr(Keys.Back)) Or (e.KeyChar = "-" And allowminus)) Or (e.KeyChar = "\u0016" Or e.KeyChar = "\u0001" Or e.KeyChar = "\u0003" Or e.KeyChar = "\u0018") Or (e.KeyChar = Chr(Keys.Enter)) Then
                e.Handled = False
            Else e.Handled = True
            End If
        ElseIf textbox_type = type.YearMonth Then
            If Char.IsDigit(e.KeyChar) Or ((e.KeyChar = Chr(Keys.Back)) Or (e.KeyChar = "-" And allowminus)) Or (e.KeyChar = "\u0016" Or e.KeyChar = "\u0001" Or e.KeyChar = "\u0003" Or e.KeyChar = "\u0018") Or (e.KeyChar = Chr(Keys.Enter)) Then
                e.Handled = False
            Else e.Handled = True
            End If
        ElseIf textbox_type = type.Time Then
            If Char.IsDigit(e.KeyChar) Or (e.KeyChar.ToString() = ":") Or (e.KeyChar.ToString() = " ") Or (e.KeyChar.ToString() = "\b") Then
                e.Handled = False
            Else e.Handled = True
            End If
        Else e.Handled = False
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Enter Then
            If IsRequired Then
                If String.IsNullOrEmpty(txt.Text) Then
                    MessageBox.Show("This text box cannot be empty!", "Error Messge", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf textbox_type = type.Number And NumberCheck() Then
                    Return
                ElseIf textbox_type = type.DDate And DateCheck() Then
                    Return
                ElseIf textbox_type = type.Number Then

                End If
            Else
                If textbox_type = type.Number And NumberCheck() Then
                    Return
                ElseIf textbox_type = type.DDate And DateCheck() Then
                    Return
                ElseIf textbox_type = type.Number Then

                End If

            End If
        End If
    End Sub

    'TextBox Error Check
    Private Function NumberCheck()
        If Not String.IsNullOrEmpty(Text) And Not IsInteger(Text) Then
            Return False
        Else Return True
        End If
    End Function
    Private Function DateCheck()
        If Not String.IsNullOrEmpty(Text) Then
            If IsInteger(Text.Replace("/", "").Replace("-", "")) Then
                Dim day, month, year As String
                If Text.Contains("/") Then

                End If
            End If
        End If
    End Function
    Private Function YearMonthCheck()

    End Function
    Private Function TimeCheck()

    End Function
    Private Function PriceCheck()

    End Function

    Public Function IsInteger(ByVal value) As Boolean
        Dim val = Replace(value, "-", "")
        If Integer.TryParse(value, Nothing) Then
            Return True
        Else Return False
        End If
    End Function
End Class
