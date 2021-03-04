<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySach
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
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.cbTheLoaiSachCapNhap = New MetroFramework.Controls.MetroComboBox()
		Me.dtNgayNhap = New MetroFramework.Controls.MetroDateTime()
		Me.txtTriGia = New MetroFramework.Controls.MetroTextBox()
		Me.txtNhaXuatBan = New MetroFramework.Controls.MetroTextBox()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.btnCapNhat = New MetroFramework.Controls.MetroButton()
		Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
		Me.cbTheLoaiSach = New MetroFramework.Controls.MetroComboBox()
		Me.dgvListSach = New MetroFramework.Controls.MetroGrid()
		Me.cbNamXuatBan = New MetroFramework.Controls.MetroComboBox()
		Me.cbTacGia = New MetroFramework.Controls.MetroComboBox()
		Me.txtTinhTrangSach = New MetroFramework.Controls.MetroTextBox()
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'cbTheLoaiSachCapNhap
		'
		Me.cbTheLoaiSachCapNhap.FormattingEnabled = true
		Me.cbTheLoaiSachCapNhap.ItemHeight = 24
		Me.cbTheLoaiSachCapNhap.Items.AddRange(New Object() {"1", "2"})
		Me.cbTheLoaiSachCapNhap.Location = New System.Drawing.Point(826, 110)
		Me.cbTheLoaiSachCapNhap.Margin = New System.Windows.Forms.Padding(4)
		Me.cbTheLoaiSachCapNhap.Name = "cbTheLoaiSachCapNhap"
		Me.cbTheLoaiSachCapNhap.Size = New System.Drawing.Size(265, 30)
		Me.cbTheLoaiSachCapNhap.TabIndex = 23
		Me.cbTheLoaiSachCapNhap.UseSelectable = true
		'
		'dtNgayNhap
		'
		Me.dtNgayNhap.Location = New System.Drawing.Point(826, 204)
		Me.dtNgayNhap.Margin = New System.Windows.Forms.Padding(4)
		Me.dtNgayNhap.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtNgayNhap.Name = "dtNgayNhap"
		Me.dtNgayNhap.Size = New System.Drawing.Size(265, 30)
		Me.dtNgayNhap.TabIndex = 22
		'
		'txtTriGia
		'
		'
		'
		'
		Me.txtTriGia.CustomButton.Image = Nothing
		Me.txtTriGia.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtTriGia.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTriGia.CustomButton.Name = ""
		Me.txtTriGia.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtTriGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTriGia.CustomButton.TabIndex = 1
		Me.txtTriGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTriGia.CustomButton.UseSelectable = true
		Me.txtTriGia.CustomButton.Visible = false
		Me.txtTriGia.Lines = New String(-1) {}
		Me.txtTriGia.Location = New System.Drawing.Point(826, 253)
		Me.txtTriGia.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTriGia.MaxLength = 32767
		Me.txtTriGia.Name = "txtTriGia"
		Me.txtTriGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTriGia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTriGia.SelectedText = ""
		Me.txtTriGia.SelectionLength = 0
		Me.txtTriGia.SelectionStart = 0
		Me.txtTriGia.ShortcutsEnabled = true
		Me.txtTriGia.Size = New System.Drawing.Size(267, 28)
		Me.txtTriGia.TabIndex = 20
		Me.txtTriGia.UseSelectable = true
		Me.txtTriGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTriGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNhaXuatBan
		'
		'
		'
		'
		Me.txtNhaXuatBan.CustomButton.Image = Nothing
		Me.txtNhaXuatBan.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtNhaXuatBan.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNhaXuatBan.CustomButton.Name = ""
		Me.txtNhaXuatBan.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtNhaXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNhaXuatBan.CustomButton.TabIndex = 1
		Me.txtNhaXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNhaXuatBan.CustomButton.UseSelectable = true
		Me.txtNhaXuatBan.CustomButton.Visible = false
		Me.txtNhaXuatBan.Lines = New String(-1) {}
		Me.txtNhaXuatBan.Location = New System.Drawing.Point(316, 253)
		Me.txtNhaXuatBan.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNhaXuatBan.MaxLength = 32767
		Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
		Me.txtNhaXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNhaXuatBan.SelectedText = ""
		Me.txtNhaXuatBan.SelectionLength = 0
		Me.txtNhaXuatBan.SelectionStart = 0
		Me.txtNhaXuatBan.ShortcutsEnabled = true
		Me.txtNhaXuatBan.Size = New System.Drawing.Size(267, 28)
		Me.txtNhaXuatBan.TabIndex = 19
		Me.txtNhaXuatBan.UseSelectable = true
		Me.txtNhaXuatBan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtNhaXuatBan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtTenSach.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = true
		Me.txtTenSach.CustomButton.Visible = false
		Me.txtTenSach.Lines = New String(-1) {}
		Me.txtTenSach.Location = New System.Drawing.Point(316, 157)
		Me.txtTenSach.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = true
		Me.txtTenSach.Size = New System.Drawing.Size(267, 28)
		Me.txtTenSach.TabIndex = 21
		Me.txtTenSach.UseSelectable = true
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtMaSach.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = true
		Me.txtMaSach.CustomButton.Visible = false
		Me.txtMaSach.ForeColor = System.Drawing.Color.Gray
		Me.txtMaSach.Lines = New String(-1) {}
		Me.txtMaSach.Location = New System.Drawing.Point(316, 110)
		Me.txtMaSach.Margin = New System.Windows.Forms.Padding(4)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ReadOnly = true
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = true
		Me.txtMaSach.Size = New System.Drawing.Size(267, 28)
		Me.txtMaSach.TabIndex = 17
		Me.txtMaSach.UseSelectable = true
		Me.txtMaSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtMaSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'MetroLabel9
		'
		Me.MetroLabel9.AutoSize = true
		Me.MetroLabel9.Location = New System.Drawing.Point(161, 298)
		Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel9.Name = "MetroLabel9"
		Me.MetroLabel9.Size = New System.Drawing.Size(107, 20)
		Me.MetroLabel9.TabIndex = 15
		Me.MetroLabel9.Text = "Tình Trạng Sách"
		'
		'MetroLabel8
		'
		Me.MetroLabel8.AutoSize = true
		Me.MetroLabel8.Location = New System.Drawing.Point(671, 253)
		Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel8.Name = "MetroLabel8"
		Me.MetroLabel8.Size = New System.Drawing.Size(47, 20)
		Me.MetroLabel8.TabIndex = 14
		Me.MetroLabel8.Text = "Trị Giá"
		'
		'MetroLabel7
		'
		Me.MetroLabel7.AutoSize = true
		Me.MetroLabel7.Location = New System.Drawing.Point(671, 204)
		Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel7.Name = "MetroLabel7"
		Me.MetroLabel7.Size = New System.Drawing.Size(80, 20)
		Me.MetroLabel7.TabIndex = 13
		Me.MetroLabel7.Text = "Ngày Nhập"
		'
		'MetroLabel6
		'
		Me.MetroLabel6.AutoSize = true
		Me.MetroLabel6.Location = New System.Drawing.Point(161, 251)
		Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel6.Name = "MetroLabel6"
		Me.MetroLabel6.Size = New System.Drawing.Size(93, 20)
		Me.MetroLabel6.TabIndex = 12
		Me.MetroLabel6.Text = "Nhà Xuất Bản"
		'
		'MetroLabel5
		'
		Me.MetroLabel5.AutoSize = true
		Me.MetroLabel5.Location = New System.Drawing.Point(161, 204)
		Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel5.Name = "MetroLabel5"
		Me.MetroLabel5.Size = New System.Drawing.Size(97, 20)
		Me.MetroLabel5.TabIndex = 11
		Me.MetroLabel5.Text = "Năm Xuất Bản"
		'
		'MetroLabel4
		'
		Me.MetroLabel4.AutoSize = true
		Me.MetroLabel4.Location = New System.Drawing.Point(671, 157)
		Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel4.Name = "MetroLabel4"
		Me.MetroLabel4.Size = New System.Drawing.Size(57, 20)
		Me.MetroLabel4.TabIndex = 10
		Me.MetroLabel4.Text = "Tác Giả "
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = true
		Me.MetroLabel3.Location = New System.Drawing.Point(671, 110)
		Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(99, 20)
		Me.MetroLabel3.TabIndex = 9
		Me.MetroLabel3.Text = "Thể Loại Sách "
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = true
		Me.MetroLabel2.Location = New System.Drawing.Point(161, 157)
		Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(68, 20)
		Me.MetroLabel2.TabIndex = 16
		Me.MetroLabel2.Text = "Tên Sách "
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = true
		Me.MetroLabel1.Location = New System.Drawing.Point(161, 110)
		Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(80, 20)
		Me.MetroLabel1.TabIndex = 8
		Me.MetroLabel1.Text = "Mã Số Sách"
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(736, 748)
		Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(117, 31)
		Me.btnXoa.TabIndex = 27
		Me.btnXoa.Text = "Xóa"
		Me.btnXoa.UseSelectable = true
		'
		'btnCapNhat
		'
		Me.btnCapNhat.Location = New System.Drawing.Point(499, 748)
		Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCapNhat.Name = "btnCapNhat"
		Me.btnCapNhat.Size = New System.Drawing.Size(117, 31)
		Me.btnCapNhat.TabIndex = 26
		Me.btnCapNhat.Text = "Cập nhật"
		Me.btnCapNhat.UseSelectable = true
		'
		'MetroLabel10
		'
		Me.MetroLabel10.AutoSize = true
		Me.MetroLabel10.Location = New System.Drawing.Point(442, 38)
		Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel10.Name = "MetroLabel10"
		Me.MetroLabel10.Size = New System.Drawing.Size(95, 20)
		Me.MetroLabel10.TabIndex = 29
		Me.MetroLabel10.Text = "Thể Loại Sách"
		'
		'cbTheLoaiSach
		'
		Me.cbTheLoaiSach.FormattingEnabled = true
		Me.cbTheLoaiSach.ItemHeight = 24
		Me.cbTheLoaiSach.Location = New System.Drawing.Point(571, 29)
		Me.cbTheLoaiSach.Margin = New System.Windows.Forms.Padding(4)
		Me.cbTheLoaiSach.Name = "cbTheLoaiSach"
		Me.cbTheLoaiSach.Size = New System.Drawing.Size(160, 30)
		Me.cbTheLoaiSach.TabIndex = 28
		Me.cbTheLoaiSach.UseSelectable = true
		'
		'dgvListSach
		'
		Me.dgvListSach.AllowUserToResizeColumns = false
		Me.dgvListSach.AllowUserToResizeRows = false
		Me.dgvListSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvListSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvListSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvListSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvListSach.DefaultCellStyle = DataGridViewCellStyle5
		Me.dgvListSach.EnableHeadersVisualStyles = false
		Me.dgvListSach.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvListSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListSach.Location = New System.Drawing.Point(24, 351)
		Me.dgvListSach.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvListSach.MultiSelect = false
		Me.dgvListSach.Name = "dgvListSach"
		Me.dgvListSach.ReadOnly = true
		Me.dgvListSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.dgvListSach.RowHeadersVisible = false
		Me.dgvListSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvListSach.Size = New System.Drawing.Size(1301, 389)
		Me.dgvListSach.TabIndex = 30
		'
		'cbNamXuatBan
		'
		Me.cbNamXuatBan.FormattingEnabled = true
		Me.cbNamXuatBan.ItemHeight = 24
		Me.cbNamXuatBan.Location = New System.Drawing.Point(316, 204)
		Me.cbNamXuatBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cbNamXuatBan.Name = "cbNamXuatBan"
		Me.cbNamXuatBan.Size = New System.Drawing.Size(267, 30)
		Me.cbNamXuatBan.TabIndex = 31
		Me.cbNamXuatBan.UseSelectable = true
		'
		'cbTacGia
		'
		Me.cbTacGia.FormattingEnabled = true
		Me.cbTacGia.ItemHeight = 24
		Me.cbTacGia.Location = New System.Drawing.Point(826, 157)
		Me.cbTacGia.Name = "cbTacGia"
		Me.cbTacGia.Size = New System.Drawing.Size(265, 30)
		Me.cbTacGia.TabIndex = 32
		Me.cbTacGia.UseSelectable = true
		'
		'txtTinhTrangSach
		'
		'
		'
		'
		Me.txtTinhTrangSach.CustomButton.Image = Nothing
		Me.txtTinhTrangSach.CustomButton.Location = New System.Drawing.Point(241, 2)
		Me.txtTinhTrangSach.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTinhTrangSach.CustomButton.Name = ""
		Me.txtTinhTrangSach.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtTinhTrangSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTinhTrangSach.CustomButton.TabIndex = 1
		Me.txtTinhTrangSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTinhTrangSach.CustomButton.UseSelectable = true
		Me.txtTinhTrangSach.CustomButton.Visible = false
		Me.txtTinhTrangSach.Lines = New String(-1) {}
		Me.txtTinhTrangSach.Location = New System.Drawing.Point(316, 298)
		Me.txtTinhTrangSach.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTinhTrangSach.MaxLength = 32767
		Me.txtTinhTrangSach.Name = "txtTinhTrangSach"
		Me.txtTinhTrangSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTinhTrangSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTinhTrangSach.SelectedText = ""
		Me.txtTinhTrangSach.SelectionLength = 0
		Me.txtTinhTrangSach.SelectionStart = 0
		Me.txtTinhTrangSach.ShortcutsEnabled = true
		Me.txtTinhTrangSach.Size = New System.Drawing.Size(267, 28)
		Me.txtTinhTrangSach.TabIndex = 19
		Me.txtTinhTrangSach.UseSelectable = true
		Me.txtTinhTrangSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTinhTrangSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'frmQuanLySach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1349, 814)
		Me.Controls.Add(Me.cbTacGia)
		Me.Controls.Add(Me.cbNamXuatBan)
		Me.Controls.Add(Me.dgvListSach)
		Me.Controls.Add(Me.MetroLabel10)
		Me.Controls.Add(Me.cbTheLoaiSach)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhat)
		Me.Controls.Add(Me.cbTheLoaiSachCapNhap)
		Me.Controls.Add(Me.dtNgayNhap)
		Me.Controls.Add(Me.txtTriGia)
		Me.Controls.Add(Me.txtTinhTrangSach)
		Me.Controls.Add(Me.txtNhaXuatBan)
		Me.Controls.Add(Me.txtTenSach)
		Me.Controls.Add(Me.txtMaSach)
		Me.Controls.Add(Me.MetroLabel9)
		Me.Controls.Add(Me.MetroLabel8)
		Me.Controls.Add(Me.MetroLabel7)
		Me.Controls.Add(Me.MetroLabel6)
		Me.Controls.Add(Me.MetroLabel5)
		Me.Controls.Add(Me.MetroLabel4)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmQuanLySach"
		Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
		Me.Text = "Quản Lý Sách"
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
	Friend WithEvents cbTheLoaiSachCapNhap As MetroFramework.Controls.MetroComboBox
	Friend WithEvents dtNgayNhap As MetroFramework.Controls.MetroDateTime
	Friend WithEvents txtTriGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtNhaXuatBan As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents btnCapNhat As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbTheLoaiSach As MetroFramework.Controls.MetroComboBox
	Friend WithEvents dgvListSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents cbNamXuatBan As MetroFramework.Controls.MetroComboBox
	Friend WithEvents cbTacGia As MetroFramework.Controls.MetroComboBox
	Friend WithEvents txtTinhTrangSach As MetroFramework.Controls.MetroTextBox
End Class
