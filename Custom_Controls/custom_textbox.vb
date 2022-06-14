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
    Public IsCorrectDate As Boolean = True
    Public IsTimemmss As Boolean = False
    Public deciaml_place As Integer
    Public charbyte As bytes
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

    Public Enum bytes
        半角 = 0
        半全角 = 1
    End Enum
    <Browsable(True)>
    <Description("Select Full/Half width")>
    <Category("Custom Properties")>
    <DisplayName("Full/Half width")>
    Public Property Char_Byte As bytes
        Get
            Return charbyte
        End Get
        Set(ByVal value As bytes)
            charbyte = value
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

    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Max length After decimal Point")>
    <DisplayName("Deciaml Place")>
    Public Property DecimalPlace As Integer = 0

    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Max length Before decimal Point")>
    <DisplayName("Integer Place")>
    Public Property IntegerPlace As Integer = 0

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
                ElseIf textbox_type = type.YearMonth And YearMonthCheck() Then
                    Return
                ElseIf textbox_type = type.Time And TimeCheck() Then
                    Return
                ElseIf textbox_type = type.Price And PriceCheck() Then
                    Return
                ElseIf textbox_type = type.Origin Or textbox_type = type.Number Then
                    Control_Check()
                End If
            Else
                If textbox_type = type.Number And NumberCheck() Then
                    Return
                ElseIf textbox_type = type.DDate And DateCheck() Then
                    Return
                ElseIf textbox_type = type.YearMonth And YearMonthCheck() Then
                    Return
                ElseIf textbox_type = type.Time And TimeCheck() Then
                    Return
                ElseIf textbox_type = type.Price And PriceCheck() Then
                    Return
                ElseIf textbox_type = type.Origin Or textbox_type = type.Number Then
                    Control_Check()
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
                    Dim arrdate() As String
                    arrdate = Text.Split("/")
                    day = arrdate(0)
                    month = arrdate(1)
                    year = arrdate(2)

                    If (arrdate.Length > 2) Then
                        year = arrdate(arrdate.Length - 3)
                        Me.Text = year + month + day
                    End If
                ElseIf Text.Contains("-") Then
                    Dim arrdate() As String
                    arrdate = Text.Split("-")
                    day = arrdate(0)
                    month = arrdate(1)
                    year = arrdate(2)

                    If (arrdate.Length > 2) Then
                        year = arrdate(arrdate.Length - 3)
                        Me.Text = year + month + day
                    End If
                End If

                Dim str = Me.Text
                str = str.PadLeft(8, "0")
                day = str.Substring(str.Length - 2)
                month = str.Substring(str.Length - 4).Substring(0, 2)
                year = Convert.ToInt32(str.Substring(0, str.Length - 4)).ToString()

                If month = "00" Then
                    month = String.Empty
                End If
                If year = "0" Then
                    year = String.Empty
                End If


                If String.IsNullOrWhiteSpace(month) Then
                    month = DateTime.Now.Month.ToString().PadLeft(2, "0")

                    If (String.IsNullOrWhiteSpace(year)) Then

                        year = DateTime.Now.Year.ToString()

                    Else
                        If (year.Length = 1) Then
                            year = "200" + year
                        ElseIf (year.Length = 2) Then
                            year = "20" + year
                        End If
                    End If

                    Dim str_date = year + "/" + month + "/" + day
                    If IsDate(str_date) Then
                        IsCorrectDate = True
                        Me.Text = str_date

                    Else
                        MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End If
            Else
                MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return True
    End Function
    Private Function YearMonthCheck()
        Dim str = Text.Replace("/", "")

        If str.Length = 0 Then
            MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If str.Length = 1 Then
            Me.Text = DateTime.Now.Year.ToString() + "/" + Text.PadLeft(2, "0")
        End If
        If str.Length = 2 Then
            If Convert.ToInt32(str) > 12 Or Convert.ToInt32(str) = 0 Then
                MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False

            Else
                Me.Text = DateTime.Now.Year.ToString() + "/" + Text.PadLeft(2, "0")
            End If
        End If
        If str.Length = 3 Or str.Length = 4 Then
            MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If str.Length = 6 Then
            Dim year = Text.Substring(0, 4).ToString()
            Dim mn = Text.Substring(Text.Length - 2, 2).ToString().PadLeft(2, "0").ToString();
            If (mn.Length = 2) Then
                If ((Convert.ToInt32(mn)) > 12 Or (Convert.ToInt32(mn)) = 0) Then
                    MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
            If ((Convert.ToInt32(year)) <= 999) Then
                MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False

                Me.Text = year + "/" + mn
            End If
        End If
        If str.Length = 5 Then
            Dim year = Text.Substring(0, 4)
            Dim mn = Text.Substring(Text.Length - 1, 1).PadLeft(2, "0")
            If (mn.Length = 2) Then

                If ((Convert.ToInt32(mn)) > 12 Or (Convert.ToInt32(mn)) = 0) Then
                    MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False

                End If
                If ((Convert.ToInt32(year)) <= 999) Then
                    MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False

                    Me.Text = year + "/" + mn
                End If
            End If
        End If
        Return True
    End Function
    Private Function TimeCheck()
        If Not String.IsNullOrWhiteSpace(Text) Then
            Dim hr, min, sec, str As String
            str = Text
            If str.Contains(":") Then
                str = str
            Else System.Text.RegularExpressions.Regex.Replace(str, ".{2}", "$0:")
            End If
            str = str.TrimEnd(":")

            Dim strtime() As String = str.Split(":")
            If strtime.Length > 3 Then
                MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                hr = strtime(0).Trim().PadLeft(2, "0")
                min = If(strtime.Length > 1, strtime(1).Trim().PadLeft(2, "0"), "00")
                sec = If(strtime.Length > 2, strtime(2).Trim().PadLeft(2, "0"), "00")

                If (Not IsTime(hr, min, sec)) Then
                    MessageBox.Show("Date is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                Text = hr + ":" + min + ":" + sec
            End If

            If (IsTimemmss) Then
                If (Text.Contains(":")) Then
                    Text = Text.Split(":")(0) + ":" + Text.Split(":")(1)
                End If
            End If
        End If
        Return True
    End Function
    Private Function PriceCheck()
        Dim first, last As String
        Dim str = Text.Replace(",", "")
        If Not String.IsNullOrEmpty(Text) Then
            If DecimalPlace <= 0 Then
                If Not IsInteger(Text) Then
                    MessageBox.Show("Please enter Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If (Text.Contains("-")) Then
                    If Text.Substring(0, 1).ToString() <> "-" Or Text.Substring(1, Text.Length - 1).Contains("-") Then
                        MessageBox.Show("Please enter Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End If

                If Text.Replace("-", "").Length > IntegerPlace Then
                    MessageBox.Show("Exceed Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                first = Text
                first = If(String.IsNullOrWhiteSpace(first), "0", String.Format("{0:#,#}", Convert.ToInt32(first)))
                Text = If(String.IsNullOrWhiteSpace(first), "0", first)

                Return True
            Else
                If Not Text.Contains(".") Then
                    If Not IsInteger(Text) And Not String.IsNullOrWhiteSpace(Text) Then
                        MessageBox.Show("Please enter Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    Else
                        first = Text
                        last = Nothing

                        If first.Length > IntegerPlace Then
                            MessageBox.Show("Exceed Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If

                        If last.Length < DecimalPlace Then
                            last = last.PadRight(DecimalPlace, "0")
                        End If

                        first = If(String.IsNullOrWhiteSpace(first), "0", String.Format("{0:#,#}", Convert.ToInt32(first)))
                        Text = If(String.IsNullOrWhiteSpace(first), "0", first) + "." + last.ToString()

                    End If
                Else
                    'decimal occurs more than one to show error message

                    If IsInteger(Text.Replace(".", String.Empty)) Then
                        first = Text.Split(".")(0)
                        last = Text.Split(".")(1)

                        If last.Length > DecimalPlace Then
                            MessageBox.Show("Exceed Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If

                        If last.Length < DecimalPlace Then
                            last = last.PadRight(DecimalPlace, "0")
                        End If

                        If first.Replace("-", "").Length > IntegerPlace Or last.Length > DecimalPlace Then
                            MessageBox.Show("Exceed Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If

                        first = If(String.IsNullOrWhiteSpace(first), "0", String.Format("{0:#,#}", Convert.ToInt32(first)))
                        Text = If(String.IsNullOrWhiteSpace(first), "0", first) + "." + last.ToString()
                    Else
                        MessageBox.Show("Please enter Integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                End If
            End If
        End If
        Return True
    End Function
    Protected Sub Control_Check()
        If charbyte = bytes.半全角 Then
            Dim str = Encoding.GetEncoding(932).GetByteCount(Text).ToString()

            If Convert.ToInt32(str) > MaxLength Then
                MessageBox.Show("入力された文字が長すぎます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
        If charbyte = bytes.半角 Then
            Dim bytecount As Integer = Encoding.GetEncoding("Shift_JIS").GetByteCount(Text)
            Dim onebyteCount As Integer = System.Text.ASCIIEncoding.ASCII.GetByteCount(Text)
            If onebyteCount <> bytecount Then
                MessageBox.Show("入力された文字が長すぎます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
    End Sub
    Public Function IsInteger(ByVal value) As Boolean
        Dim val = Replace(value, "-", "")
        If Integer.TryParse(value, Nothing) Then
            Return True
        Else Return False
        End If
    End Function
    Public Function IsDate(ByVal value) As Boolean
        Return DateTime.TryParseExact(value,
                       "yyyy/MM/dd",
                       System.Globalization.CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       ByVal DateTime d)
    End Function
    Public Function IsTime(ByVal hr, ByVal min, ByVal sec) As Boolean
        If Convert.ToInt32(hr) > 23 Or Convert.ToInt32(min) > 59 Or Convert.ToInt32(sec) > 59 Then
            Return False
        End If
        Return True
    End Function
End Class
