<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Custom_button4 = New Custom_Controls.custom_button()
        Me.Custom_button3 = New Custom_Controls.custom_button()
        Me.btnNew = New Custom_Controls.custom_button()
        Me.btnInsert = New Custom_Controls.custom_button()
        Me.Custom_gridview1 = New Custom_Controls.custom_gridview()
        Me.Custom_textbox4 = New Custom_Controls.custom_textbox()
        Me.Custom_textbox3 = New Custom_Controls.custom_textbox()
        Me.Custom_textbox2 = New Custom_Controls.custom_textbox()
        Me.txt4 = New Custom_Controls.Common_Label()
        Me.txt3 = New Custom_Controls.Common_Label()
        Me.txt2 = New Custom_Controls.Common_Label()
        Me.Custom_textbox1 = New Custom_Controls.custom_textbox()
        Me.txt1 = New Custom_Controls.Common_Label()
        CType(Me.Custom_gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Custom_button4
        '
        Me.Custom_button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Custom_button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Custom_button4.DefaultBtnSize = False
        Me.Custom_button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Custom_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Custom_button4.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Custom_button4.Font_Size = Custom_Controls.custom_button.FontSize.XSmall
        Me.Custom_button4.Location = New System.Drawing.Point(647, 302)
        Me.Custom_button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Custom_button4.Name = "Custom_button4"
        Me.Custom_button4.Size = New System.Drawing.Size(110, 34)
        Me.Custom_button4.TabIndex = 12
        Me.Custom_button4.Text = "Delete"
        Me.Custom_button4.TextColor = Custom_Controls.custom_button.Button_Color.Green
        Me.Custom_button4.UseVisualStyleBackColor = False
        '
        'Custom_button3
        '
        Me.Custom_button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Custom_button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Custom_button3.DefaultBtnSize = False
        Me.Custom_button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Custom_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Custom_button3.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Custom_button3.Font_Size = Custom_Controls.custom_button.FontSize.XSmall
        Me.Custom_button3.Location = New System.Drawing.Point(466, 302)
        Me.Custom_button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Custom_button3.Name = "Custom_button3"
        Me.Custom_button3.Size = New System.Drawing.Size(110, 34)
        Me.Custom_button3.TabIndex = 11
        Me.Custom_button3.Text = "Update"
        Me.Custom_button3.TextColor = Custom_Controls.custom_button.Button_Color.Yellow
        Me.Custom_button3.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.DefaultBtnSize = False
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.Font_Size = Custom_Controls.custom_button.FontSize.XSmall
        Me.btnNew.Location = New System.Drawing.Point(286, 302)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(110, 34)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New"
        Me.btnNew.TextColor = Custom_Controls.custom_button.Button_Color.Pink
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsert.DefaultBtnSize = False
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnInsert.Font_Size = Custom_Controls.custom_button.FontSize.XSmall
        Me.btnInsert.Location = New System.Drawing.Point(116, 302)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(1)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(110, 34)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextColor = Custom_Controls.custom_button.Button_Color.DarkGreen
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Custom_gridview1
        '
        Me.Custom_gridview1.AllowUserToDeleteRows = False
        Me.Custom_gridview1.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Custom_gridview1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Custom_gridview1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(180, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Custom_gridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Custom_gridview1.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Custom_gridview1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Custom_gridview1.EnableHeadersVisualStyles = False
        Me.Custom_gridview1.GridColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Custom_gridview1.Location = New System.Drawing.Point(354, 43)
        Me.Custom_gridview1.Name = "Custom_gridview1"
        Me.Custom_gridview1.RowHeight_ = 20
        Me.Custom_gridview1.RowTemplate.Height = 20
        Me.Custom_gridview1.Size = New System.Drawing.Size(512, 207)
        Me.Custom_gridview1.TabIndex = 8
        Me.Custom_gridview1.UseRowNo = True
        Me.Custom_gridview1.UseSetting = False
        '
        'Custom_textbox4
        '
        Me.Custom_textbox4.allow_minus = False
        Me.Custom_textbox4.Char_Byte = Custom_Controls.custom_textbox.bytes.半角
        Me.Custom_textbox4.DecimalPlace = 0
        Me.Custom_textbox4.IntegerPlace = 0
        Me.Custom_textbox4.is_required = False
        Me.Custom_textbox4.Location = New System.Drawing.Point(211, 230)
        Me.Custom_textbox4.Name = "Custom_textbox4"
        Me.Custom_textbox4.Size = New System.Drawing.Size(100, 20)
        Me.Custom_textbox4.TabIndex = 7
        Me.Custom_textbox4.textbox_type = Custom_Controls.custom_textbox.type.Price
        '
        'Custom_textbox3
        '
        Me.Custom_textbox3.allow_minus = False
        Me.Custom_textbox3.Char_Byte = Custom_Controls.custom_textbox.bytes.半角
        Me.Custom_textbox3.DecimalPlace = 0
        Me.Custom_textbox3.IntegerPlace = 0
        Me.Custom_textbox3.is_required = False
        Me.Custom_textbox3.Location = New System.Drawing.Point(211, 167)
        Me.Custom_textbox3.Name = "Custom_textbox3"
        Me.Custom_textbox3.Size = New System.Drawing.Size(100, 20)
        Me.Custom_textbox3.TabIndex = 6
        Me.Custom_textbox3.textbox_type = Custom_Controls.custom_textbox.type.Origin
        '
        'Custom_textbox2
        '
        Me.Custom_textbox2.allow_minus = False
        Me.Custom_textbox2.Char_Byte = Custom_Controls.custom_textbox.bytes.半角
        Me.Custom_textbox2.DecimalPlace = 0
        Me.Custom_textbox2.IntegerPlace = 0
        Me.Custom_textbox2.is_required = False
        Me.Custom_textbox2.Location = New System.Drawing.Point(211, 107)
        Me.Custom_textbox2.Name = "Custom_textbox2"
        Me.Custom_textbox2.Size = New System.Drawing.Size(100, 20)
        Me.Custom_textbox2.TabIndex = 5
        Me.Custom_textbox2.textbox_type = Custom_Controls.custom_textbox.type.Origin
        '
        'txt4
        '
        Me.txt4.AutoSize = True
        Me.txt4.BackColor = System.Drawing.Color.Transparent
        Me.txt4.BackGroundColor = Custom_Controls.Common_Label.Text_Color.Normal
        Me.txt4.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt4.Font_Size = Custom_Controls.Common_Label.FontSize.Small
        Me.txt4.ForeColor = System.Drawing.Color.Black
        Me.txt4.Location = New System.Drawing.Point(165, 230)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(42, 19)
        Me.txt4.TabIndex = 4
        Me.txt4.Text = "Sum"
        Me.txt4.TextColor = Custom_Controls.Common_Label.Text_Color.Normal
        '
        'txt3
        '
        Me.txt3.AutoSize = True
        Me.txt3.BackColor = System.Drawing.Color.Transparent
        Me.txt3.BackGroundColor = Custom_Controls.Common_Label.Text_Color.Normal
        Me.txt3.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt3.Font_Size = Custom_Controls.Common_Label.FontSize.Small
        Me.txt3.ForeColor = System.Drawing.Color.Black
        Me.txt3.Location = New System.Drawing.Point(99, 167)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(108, 19)
        Me.txt3.TabIndex = 3
        Me.txt3.Text = "Last Name"
        Me.txt3.TextColor = Custom_Controls.Common_Label.Text_Color.Normal
        '
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.BackColor = System.Drawing.Color.Transparent
        Me.txt2.BackGroundColor = Custom_Controls.Common_Label.Text_Color.Normal
        Me.txt2.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt2.Font_Size = Custom_Controls.Common_Label.FontSize.Small
        Me.txt2.ForeColor = System.Drawing.Color.Black
        Me.txt2.Location = New System.Drawing.Point(88, 107)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(119, 19)
        Me.txt2.TabIndex = 2
        Me.txt2.Text = "First Name"
        Me.txt2.TextColor = Custom_Controls.Common_Label.Text_Color.Normal
        '
        'Custom_textbox1
        '
        Me.Custom_textbox1.allow_minus = False
        Me.Custom_textbox1.Char_Byte = Custom_Controls.custom_textbox.bytes.半角
        Me.Custom_textbox1.DecimalPlace = 0
        Me.Custom_textbox1.IntegerPlace = 0
        Me.Custom_textbox1.is_required = False
        Me.Custom_textbox1.Location = New System.Drawing.Point(211, 44)
        Me.Custom_textbox1.Name = "Custom_textbox1"
        Me.Custom_textbox1.Size = New System.Drawing.Size(100, 20)
        Me.Custom_textbox1.TabIndex = 1
        Me.Custom_textbox1.textbox_type = Custom_Controls.custom_textbox.type.Number
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.BackColor = System.Drawing.Color.Transparent
        Me.txt1.BackGroundColor = Custom_Controls.Common_Label.Text_Color.Normal
        Me.txt1.Font = New System.Drawing.Font("MS Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt1.Font_Size = Custom_Controls.Common_Label.FontSize.Small
        Me.txt1.ForeColor = System.Drawing.Color.Black
        Me.txt1.Location = New System.Drawing.Point(176, 44)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(31, 19)
        Me.txt1.TabIndex = 0
        Me.txt1.Text = "ID"
        Me.txt1.TextColor = Custom_Controls.Common_Label.Text_Color.Normal
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 450)
        Me.Controls.Add(Me.Custom_button4)
        Me.Controls.Add(Me.Custom_button3)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Custom_gridview1)
        Me.Controls.Add(Me.Custom_textbox4)
        Me.Controls.Add(Me.Custom_textbox3)
        Me.Controls.Add(Me.Custom_textbox2)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Custom_textbox1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Custom_gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As Custom_Controls.Common_Label
    Friend WithEvents Custom_textbox1 As Custom_Controls.custom_textbox
    Friend WithEvents txt2 As Custom_Controls.Common_Label
    Friend WithEvents txt4 As Custom_Controls.Common_Label
    Friend WithEvents Custom_textbox2 As Custom_Controls.custom_textbox
    Friend WithEvents Custom_textbox3 As Custom_Controls.custom_textbox
    Friend WithEvents Custom_textbox4 As Custom_Controls.custom_textbox
    Friend WithEvents Custom_gridview1 As Custom_Controls.custom_gridview
    Friend WithEvents btnInsert As Custom_Controls.custom_button
    Friend WithEvents btnNew As Custom_Controls.custom_button
    Friend WithEvents Custom_button3 As Custom_Controls.custom_button
    Friend WithEvents Custom_button4 As Custom_Controls.custom_button
    Friend WithEvents txt3 As Custom_Controls.Common_Label
End Class
