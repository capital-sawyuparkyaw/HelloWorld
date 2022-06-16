<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSV_Import
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataGridview1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.txtpathfile = New System.Windows.Forms.TextBox()
        Me.Custom_gridview1 = New Custom_Controls.custom_gridview()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custom_gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridview1
        '
        Me.dataGridview1.AllowUserToAddRows = False
        Me.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dataGridview1.Location = New System.Drawing.Point(21, 494)
        Me.dataGridview1.Name = "dataGridview1"
        Me.dataGridview1.Size = New System.Drawing.Size(759, 205)
        Me.dataGridview1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "StartDate"
        Me.Column1.HeaderText = "StartDate"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "End Date"
        Me.Column2.HeaderText = "End Date"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "UserCD"
        Me.Column3.HeaderText = "UserCD"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "User Name"
        Me.Column4.HeaderText = "User Name"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Full Name"
        Me.Column5.HeaderText = "Full Name"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Address"
        Me.Column6.HeaderText = "Address"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Remarks"
        Me.Column7.HeaderText = "Remarks"
        Me.Column7.Name = "Column7"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(21, 89)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(94, 31)
        Me.btnImport.TabIndex = 4
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'txtpathfile
        '
        Me.txtpathfile.Location = New System.Drawing.Point(21, 39)
        Me.txtpathfile.Name = "txtpathfile"
        Me.txtpathfile.Size = New System.Drawing.Size(323, 20)
        Me.txtpathfile.TabIndex = 5
        '
        'Custom_gridview1
        '
        Me.Custom_gridview1.AllowUserToAddRows = False
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
        Me.Custom_gridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
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
        Me.Custom_gridview1.Location = New System.Drawing.Point(21, 181)
        Me.Custom_gridview1.Name = "Custom_gridview1"
        Me.Custom_gridview1.RowHeight_ = 20
        Me.Custom_gridview1.RowTemplate.Height = 20
        Me.Custom_gridview1.Size = New System.Drawing.Size(759, 205)
        Me.Custom_gridview1.TabIndex = 6
        Me.Custom_gridview1.UseRowNo = True
        Me.Custom_gridview1.UseSetting = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "StartDate"
        Me.Column8.HeaderText = "StartDate"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "End Date"
        Me.Column9.HeaderText = "End Date"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "UserCD"
        Me.Column10.HeaderText = "UserCD"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "User Name"
        Me.Column11.HeaderText = "User Name"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "Full Name"
        Me.Column12.HeaderText = "Full  Name"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "Address"
        Me.Column13.HeaderText = "Address"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "Remarks"
        Me.Column14.HeaderText = "Remarks"
        Me.Column14.Name = "Column14"
        '
        'CSV_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 757)
        Me.Controls.Add(Me.Custom_gridview1)
        Me.Controls.Add(Me.txtpathfile)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.dataGridview1)
        Me.Name = "CSV_Import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSV_Import"
        CType(Me.dataGridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custom_gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGridview1 As DataGridView
    Friend WithEvents btnImport As Button
    Friend WithEvents txtpathfile As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Custom_gridview1 As Custom_Controls.custom_gridview
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
End Class
