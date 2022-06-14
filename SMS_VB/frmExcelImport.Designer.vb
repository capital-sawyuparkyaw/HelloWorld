<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcelImport
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
        Me.btnOpenFile = New Custom_Controls.custom_button()
        Me.lblFileName = New Custom_Controls.Common_Label()
        Me.Custom_gridview1 = New Custom_Controls.custom_gridview()
        Me.colProjectCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBrandCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBrandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSeason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeriodStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeriodEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalProduction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Custom_gridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenFile.DefaultBtnSize = False
        Me.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOpenFile.Font_Size = Custom_Controls.custom_button.FontSize.Normal
        Me.btnOpenFile.Location = New System.Drawing.Point(40, 72)
        Me.btnOpenFile.Margin = New System.Windows.Forms.Padding(1)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(148, 30)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Open File Dialog"
        Me.btnOpenFile.TextColor = Custom_Controls.custom_button.Button_Color.Normal
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.BackColor = System.Drawing.Color.Transparent
        Me.lblFileName.BackGroundColor = Custom_Controls.Common_Label.Text_Color.Normal
        Me.lblFileName.Font = New System.Drawing.Font("MS Gothic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblFileName.Font_Size = Custom_Controls.Common_Label.FontSize.Medium
        Me.lblFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblFileName.Location = New System.Drawing.Point(192, 73)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(118, 22)
        Me.lblFileName.TabIndex = 1
        Me.lblFileName.Text = "File Name"
        Me.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFileName.TextColor = Custom_Controls.Common_Label.Text_Color.Green
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
        Me.Custom_gridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProjectCD, Me.colProjectName, Me.colYear, Me.colBrandCD, Me.colBrandName, Me.colSeason, Me.colPeriodStart, Me.colPeriodEnd, Me.colTotalProduction, Me.colTotalAmount, Me.colUserID, Me.colUserName})
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
        Me.Custom_gridview1.Location = New System.Drawing.Point(38, 146)
        Me.Custom_gridview1.Name = "Custom_gridview1"
        Me.Custom_gridview1.RowHeight_ = 20
        Me.Custom_gridview1.RowTemplate.Height = 20
        Me.Custom_gridview1.Size = New System.Drawing.Size(1261, 627)
        Me.Custom_gridview1.TabIndex = 2
        Me.Custom_gridview1.UseRowNo = True
        Me.Custom_gridview1.UseSetting = False
        '
        'colProjectCD
        '
        Me.colProjectCD.HeaderText = "プロジェクトコード"
        Me.colProjectCD.Name = "colProjectCD"
        Me.colProjectCD.ReadOnly = True
        '
        'colProjectName
        '
        Me.colProjectName.HeaderText = "プロジェクト名"
        Me.colProjectName.Name = "colProjectName"
        Me.colProjectName.ReadOnly = True
        '
        'colYear
        '
        Me.colYear.HeaderText = "年度"
        Me.colYear.Name = "colYear"
        Me.colYear.ReadOnly = True
        '
        'colBrandCD
        '
        Me.colBrandCD.HeaderText = "ブランドコード"
        Me.colBrandCD.Name = "colBrandCD"
        Me.colBrandCD.ReadOnly = True
        '
        'colBrandName
        '
        Me.colBrandName.HeaderText = "ブランド名"
        Me.colBrandName.Name = "colBrandName"
        Me.colBrandName.ReadOnly = True
        '
        'colSeason
        '
        Me.colSeason.HeaderText = "シーズン"
        Me.colSeason.Name = "colSeason"
        Me.colSeason.ReadOnly = True
        '
        'colPeriodStart
        '
        Me.colPeriodStart.HeaderText = "予定期間　開始"
        Me.colPeriodStart.Name = "colPeriodStart"
        Me.colPeriodStart.ReadOnly = True
        '
        'colPeriodEnd
        '
        Me.colPeriodEnd.HeaderText = "予定期間　終了"
        Me.colPeriodEnd.Name = "colPeriodEnd"
        Me.colPeriodEnd.ReadOnly = True
        '
        'colTotalProduction
        '
        Me.colTotalProduction.HeaderText = "総生産数"
        Me.colTotalProduction.Name = "colTotalProduction"
        Me.colTotalProduction.ReadOnly = True
        '
        'colTotalAmount
        '
        Me.colTotalAmount.HeaderText = "総金額"
        Me.colTotalAmount.Name = "colTotalAmount"
        Me.colTotalAmount.ReadOnly = True
        '
        'colUserID
        '
        Me.colUserID.HeaderText = "責任者コード"
        Me.colUserID.Name = "colUserID"
        Me.colUserID.ReadOnly = True
        '
        'colUserName
        '
        Me.colUserName.HeaderText = "責任者名"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.ReadOnly = True
        '
        'frmExcelImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1415, 810)
        Me.Controls.Add(Me.Custom_gridview1)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Name = "frmExcelImport"
        Me.Text = "Excel Import to Grid View"
        CType(Me.Custom_gridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenFile As Custom_Controls.custom_button
    Friend WithEvents lblFileName As Custom_Controls.Common_Label
    Friend WithEvents Custom_gridview1 As Custom_Controls.custom_gridview
    Friend WithEvents colProjectCD As DataGridViewTextBoxColumn
    Friend WithEvents colProjectName As DataGridViewTextBoxColumn
    Friend WithEvents colYear As DataGridViewTextBoxColumn
    Friend WithEvents colBrandCD As DataGridViewTextBoxColumn
    Friend WithEvents colBrandName As DataGridViewTextBoxColumn
    Friend WithEvents colSeason As DataGridViewTextBoxColumn
    Friend WithEvents colPeriodStart As DataGridViewTextBoxColumn
    Friend WithEvents colPeriodEnd As DataGridViewTextBoxColumn
    Friend WithEvents colTotalProduction As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents colUserID As DataGridViewTextBoxColumn
    Friend WithEvents colUserName As DataGridViewTextBoxColumn
End Class
