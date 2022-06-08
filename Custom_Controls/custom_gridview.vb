Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Public Class custom_gridview
    Inherits DataGridView
    Dim hiraganaColumn As ArrayList
    Dim Setting As Boolean = False
    'Public Property Checkcol As ArrayList
    '    Get
    '        Return Checkcol
    '    End Get
    '    Set(value As ArrayList)
    '        checkCol = value
    '    End Set
    'End Property
    <Browsable(True)>
    <Description("Use Custom Properties")>
    <Category("Custom Properties")>
    Public Property UseSetting As Boolean
        Get
            Return Setting
        End Get
        Set(value As Boolean)
            Setting = value
            GridDesign()
        End Set
    End Property

    Dim UseRow As Boolean = True
    <Browsable(True)>
    <Description("Use RowNo")>
    <Category("Custom Properties")>
    <DisplayName("Use RowNo")>
    Public Property UseRowNo As Boolean
        Get
            Return UseRow
        End Get
        Set(value As Boolean)
            UseRow = RowHeadersVisible = value
        End Set
    End Property

    Dim RowHeight As Integer = 20
    <Browsable(True)>
    <Description("Row height")>
    <Category("Custom Properties")>
    <DisplayName("Row height")>
    Public Property RowHeight_ As Integer
        Get
            Return RowHeight
        End Get
        Set(value As Integer)
            RowHeight = value
            RowTemplate.Height = RowHeight
            Invalidate()
        End Set
    End Property
    Public Sub GridDesign()
        Me.DefaultCellStyle.Font = New Font("MS Gothic", 9, FontStyle.Regular)
        Me.EnableHeadersVisualStyles = False
        Me.ColumnHeadersDefaultCellStyle.Font = New Font(Me.Font, FontStyle.Bold)
        Me.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(191, 191, 191)
        Me.BackgroundColor = Color.FromArgb(198, 224, 180)
        Me.GridColor = Color.FromArgb(198, 224, 180)
        Me.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 247)
        Me.AutoGenerateColumns = False
        Me.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AllowUserToDeleteRows = False
        Me.AllowUserToResizeColumns = False
        Me.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ColumnHeadersHeight = 25
    End Sub
End Class
