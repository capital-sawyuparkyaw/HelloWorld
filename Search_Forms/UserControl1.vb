Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Public Class UserControl1
    Public f_size As FontSize
    Dim obj As New CRUDSimpleTest.SearchForm
    Public Search_Type As SearchType
    Public Enum FontSize
        Normal
        Small
        SmallLarge
        Medium
        Large
        XLarge
    End Enum
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Select FontSize")>
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
                Case FontSize.Small
                    Me.Font = New System.Drawing.Font("MS Gothic", 10.0F, System.Drawing.FontStyle.Bold)
                    f_size = value
                Case FontSize.SmallLarge
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
    Public Enum SearchType
        Test1
    End Enum
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Select Control Type")>
    <DisplayName("Control Type")>
    Public Property Stype As SearchType
        Get
            Return Search_Type
        End Get
        Set(value As SearchType)
            Search_Type = value
        End Set
    End Property
    Public Property Code As String
        Get
            Return txtCode.Text
        End Get
        Set(value As String)
            txtCode.Text = value
        End Set
    End Property
    Public Property LabelText As String
        Get
            Return lblName.Text
        End Get
        Set(value As String)
            lblName.Text = value
        End Set
    End Property
    Public Property ChangeDate As String
        Get
            Return txtChangeDate.Text
        End Get
        Set(value As String)
            txtChangeDate.Text = value
        End Set
    End Property
    Public Property SearchEnable As Boolean
        Get
            Return btnSearch.Enabled
        End Get
        Set(value As Boolean)
            btnSearch.Enabled = value
        End Set
    End Property
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Use ChangeDate")>
    <DisplayName("Use ChangeDate")>
    Public Property UseChangeDate As Boolean
        Get
            Return txtChangeDate.Visible
        End Get
        Set(value As Boolean)
            txtChangeDate.Visible = value
            CalculateWidth()
        End Set
    End Property
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Set Label Visible")>
    <DisplayName("Label Visible")>
    Public Property LabelVisible As Boolean
        Get
            Return lblName.Visible
        End Get
        Set(value As Boolean)
            lblName.Visible = value
            CalculateWidth()
        End Set
    End Property
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Code Width1")>
    <DisplayName("Code Width1")>
    Public Property CodeWidth1 As Integer
        Get
            Return txtCode.Width
        End Get
        Set(value As Integer)
            txtCode.Width = value
            CalculateWidth()
        End Set
    End Property
    <Browsable(True)>
    <Category("Custom Properties")>
    <Description("Name Width")>
    <DisplayName("Name Width")>
    Public Property NameWidth As Integer
        Get
            Return lblName.Width
        End Get
        Set(value As Integer)
            lblName.Width = value
        End Set
    End Property
    Private Sub CalculateWidth()
        txtCode.Width = CodeWidth
        btnSearch.Location = New Point(txtCode.Width - 1, btnSearch.Location.Y)
        lblName.Location = New Point(txtCode.Width + btnSearch.Width - 2, lblName.Location.Y)
        If (lblName.Visible) Then
            Me.Width = txtCode.Width + btnSearch.Width + lblName.Width
        Else
            Me.Width = txtCode.Width + btnSearch.Width
        End If
    End Sub
    Public Property CodeWidth As Integer
        Get
            Return txtCode.Width
        End Get
        Set(value As Integer)
            txtCode.Width = value
        End Set
    End Property
    Private Sub SetWidth()
        Select Case Search_Type
            Case SearchType.Test1
                txtCode.MaxLength = 6
                txtCode.Width = 60
                lblName.Width = 280
        End Select
    End Sub
    Private Sub Search()
        Select Case Stype
            Case SearchType.Test1
                obj.Show()
                If obj.CostCD IsNot "" Then
                    txtCode.Text = obj.CostCD
                End If
                'Dim newfrm = New CRUDSimpleTest.SearchForm
                'newfrm.Show()
                'txtCode.Text = newfrm.CostCD
        End Select
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        If (String.IsNullOrWhiteSpace(txtCode.Text)) Then
            lblName.Text = String.Empty
        End If
        If e.KeyCode = Keys.F9 Then
            Search()
        End If
    End Sub

    Private Sub Search_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCode.Text = obj.CostCD
    End Sub
End Class
