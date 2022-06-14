<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtChangeDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(133, 4)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(281, 19)
        Me.lblName.TabIndex = 8
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(102, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "･･･"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(2, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 6
        '
        'txtChangeDate
        '
        Me.txtChangeDate.Location = New System.Drawing.Point(3, 29)
        Me.txtChangeDate.Name = "txtChangeDate"
        Me.txtChangeDate.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeDate.TabIndex = 9
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtChangeDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCode)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(417, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtChangeDate As TextBox
End Class
