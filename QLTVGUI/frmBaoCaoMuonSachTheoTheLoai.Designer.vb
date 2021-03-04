<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoMuonSachTheoTheLoai
	Inherits MetroFramework.Forms.MetroForm

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
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
		Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
		Me.btnBaoCao = New MetroFramework.Controls.MetroButton()
		Me.btnThoat = New MetroFramework.Controls.MetroButton()
		Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
		CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(50, 88)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(79, 19)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Tháng/Năm"
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(50, 135)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(84, 19)
		Me.MetroLabel2.TabIndex = 0
		Me.MetroLabel2.Text = "Thể loại sách"
		'
		'MetroDateTime1
		'
		Me.MetroDateTime1.Location = New System.Drawing.Point(147, 78)
		Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
		Me.MetroDateTime1.Name = "MetroDateTime1"
		Me.MetroDateTime1.Size = New System.Drawing.Size(200, 29)
		Me.MetroDateTime1.TabIndex = 1
		'
		'MetroComboBox1
		'
		Me.MetroComboBox1.FormattingEnabled = True
		Me.MetroComboBox1.ItemHeight = 23
		Me.MetroComboBox1.Location = New System.Drawing.Point(147, 125)
		Me.MetroComboBox1.Name = "MetroComboBox1"
		Me.MetroComboBox1.Size = New System.Drawing.Size(200, 29)
		Me.MetroComboBox1.TabIndex = 2
		Me.MetroComboBox1.UseSelectable = True
		'
		'btnBaoCao
		'
		Me.btnBaoCao.Location = New System.Drawing.Point(147, 202)
		Me.btnBaoCao.Name = "btnBaoCao"
		Me.btnBaoCao.Size = New System.Drawing.Size(86, 23)
		Me.btnBaoCao.TabIndex = 3
		Me.btnBaoCao.Text = "Xem Báo Cáo"
		Me.btnBaoCao.UseSelectable = True
		'
		'btnThoat
		'
		Me.btnThoat.Location = New System.Drawing.Point(272, 202)
		Me.btnThoat.Name = "btnThoat"
		Me.btnThoat.Size = New System.Drawing.Size(75, 23)
		Me.btnThoat.TabIndex = 3
		Me.btnThoat.Text = "Thoát"
		Me.btnThoat.UseSelectable = True
		'
		'MetroGrid1
		'
		Me.MetroGrid1.AllowUserToResizeRows = False
		Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
		Me.MetroGrid1.EnableHeadersVisualStyles = False
		Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MetroGrid1.Location = New System.Drawing.Point(426, 54)
		Me.MetroGrid1.Name = "MetroGrid1"
		Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.MetroGrid1.Size = New System.Drawing.Size(602, 171)
		Me.MetroGrid1.TabIndex = 4
		'
		'frmBaoCaoMuonSachTheoTheLoai
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1051, 342)
		Me.Controls.Add(Me.MetroGrid1)
		Me.Controls.Add(Me.btnThoat)
		Me.Controls.Add(Me.btnBaoCao)
		Me.Controls.Add(Me.MetroComboBox1)
		Me.Controls.Add(Me.MetroDateTime1)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Name = "frmBaoCaoMuonSachTheoTheLoai"
		Me.Text = "frmBaoCaoMuonSachTheoTheLoai"
		CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
	Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
	Friend WithEvents btnBaoCao As MetroFramework.Controls.MetroButton
	Friend WithEvents btnThoat As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
End Class
