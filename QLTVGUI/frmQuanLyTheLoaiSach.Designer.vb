<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTheLoaiSach
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
		Me.dgvDanhSachTheLoaiSach = New MetroFramework.Controls.MetroGrid()
		Me.M = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaLoai = New MetroFramework.Controls.MetroTextBox()
		Me.txtTenLoai = New MetroFramework.Controls.MetroTextBox()
		Me.btnCapNhap = New MetroFramework.Controls.MetroButton()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		CType(Me.dgvDanhSachTheLoaiSach, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvDanhSachTheLoaiSach
		'
		Me.dgvDanhSachTheLoaiSach.AllowUserToResizeRows = False
		Me.dgvDanhSachTheLoaiSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvDanhSachTheLoaiSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvDanhSachTheLoaiSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvDanhSachTheLoaiSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDanhSachTheLoaiSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvDanhSachTheLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDanhSachTheLoaiSach.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvDanhSachTheLoaiSach.EnableHeadersVisualStyles = False
		Me.dgvDanhSachTheLoaiSach.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvDanhSachTheLoaiSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvDanhSachTheLoaiSach.Location = New System.Drawing.Point(5, 18)
		Me.dgvDanhSachTheLoaiSach.Margin = New System.Windows.Forms.Padding(2)
		Me.dgvDanhSachTheLoaiSach.Name = "dgvDanhSachTheLoaiSach"
		Me.dgvDanhSachTheLoaiSach.ReadOnly = True
		Me.dgvDanhSachTheLoaiSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDanhSachTheLoaiSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvDanhSachTheLoaiSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvDanhSachTheLoaiSach.RowTemplate.Height = 24
		Me.dgvDanhSachTheLoaiSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDanhSachTheLoaiSach.Size = New System.Drawing.Size(344, 237)
		Me.dgvDanhSachTheLoaiSach.TabIndex = 1
		'
		'M
		'
		Me.M.AutoSize = True
		Me.M.Location = New System.Drawing.Point(128, 357)
		Me.M.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.M.Name = "M"
		Me.M.Size = New System.Drawing.Size(75, 19)
		Me.M.TabIndex = 2
		Me.M.Text = "Mã thể loại"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(128, 391)
		Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(75, 19)
		Me.MetroLabel3.TabIndex = 3
		Me.MetroLabel3.Text = "Tên thể loại"
		'
		'txtMaLoai
		'
		'
		'
		'
		Me.txtMaLoai.CustomButton.Image = Nothing
		Me.txtMaLoai.CustomButton.Location = New System.Drawing.Point(79, 1)
		Me.txtMaLoai.CustomButton.Margin = New System.Windows.Forms.Padding(2)
		Me.txtMaLoai.CustomButton.Name = ""
		Me.txtMaLoai.CustomButton.Size = New System.Drawing.Size(17, 17)
		Me.txtMaLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaLoai.CustomButton.TabIndex = 1
		Me.txtMaLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaLoai.CustomButton.UseSelectable = True
		Me.txtMaLoai.CustomButton.Visible = False
		Me.txtMaLoai.Lines = New String(-1) {}
		Me.txtMaLoai.Location = New System.Drawing.Point(214, 358)
		Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(2)
		Me.txtMaLoai.MaxLength = 32767
		Me.txtMaLoai.Name = "txtMaLoai"
		Me.txtMaLoai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaLoai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaLoai.SelectedText = ""
		Me.txtMaLoai.SelectionLength = 0
		Me.txtMaLoai.SelectionStart = 0
		Me.txtMaLoai.ShortcutsEnabled = True
		Me.txtMaLoai.Size = New System.Drawing.Size(97, 19)
		Me.txtMaLoai.TabIndex = 4
		Me.txtMaLoai.UseSelectable = True
		Me.txtMaLoai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaLoai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTenLoai
		'
		'
		'
		'
		Me.txtTenLoai.CustomButton.Image = Nothing
		Me.txtTenLoai.CustomButton.Location = New System.Drawing.Point(79, 1)
		Me.txtTenLoai.CustomButton.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTenLoai.CustomButton.Name = ""
		Me.txtTenLoai.CustomButton.Size = New System.Drawing.Size(17, 17)
		Me.txtTenLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenLoai.CustomButton.TabIndex = 1
		Me.txtTenLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenLoai.CustomButton.UseSelectable = True
		Me.txtTenLoai.CustomButton.Visible = False
		Me.txtTenLoai.Lines = New String(-1) {}
		Me.txtTenLoai.Location = New System.Drawing.Point(214, 394)
		Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(2)
		Me.txtTenLoai.MaxLength = 32767
		Me.txtTenLoai.Name = "txtTenLoai"
		Me.txtTenLoai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenLoai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenLoai.SelectedText = ""
		Me.txtTenLoai.SelectionLength = 0
		Me.txtTenLoai.SelectionStart = 0
		Me.txtTenLoai.ShortcutsEnabled = True
		Me.txtTenLoai.Size = New System.Drawing.Size(97, 19)
		Me.txtTenLoai.TabIndex = 4
		Me.txtTenLoai.UseSelectable = True
		Me.txtTenLoai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenLoai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnCapNhap
		'
		Me.btnCapNhap.Location = New System.Drawing.Point(119, 434)
		Me.btnCapNhap.Margin = New System.Windows.Forms.Padding(2)
		Me.btnCapNhap.Name = "btnCapNhap"
		Me.btnCapNhap.Size = New System.Drawing.Size(74, 19)
		Me.btnCapNhap.TabIndex = 5
		Me.btnCapNhap.Text = "Cập nhập"
		Me.btnCapNhap.UseSelectable = True
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(265, 434)
		Me.btnXoa.Margin = New System.Windows.Forms.Padding(2)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(65, 19)
		Me.btnXoa.TabIndex = 5
		Me.btnXoa.Text = "Xoá"
		Me.btnXoa.UseSelectable = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.dgvDanhSachTheLoaiSach)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(49, 82)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(354, 260)
		Me.GroupBox1.TabIndex = 6
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Danh sách các thể loại sách"
		'
		'frmQuanLyTheLoaiSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(457, 494)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhap)
		Me.Controls.Add(Me.txtTenLoai)
		Me.Controls.Add(Me.txtMaLoai)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.M)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmQuanLyTheLoaiSach"
		Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
		Me.Text = "Quản Lý Thể Loại Sách"
		CType(Me.dgvDanhSachTheLoaiSach, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout

End Sub
	Friend WithEvents dgvDanhSachTheLoaiSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents M As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaLoai As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenLoai As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnCapNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents GroupBox1 As GroupBox
End Class
