<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuSach
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
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnTimKiem = New MetroFramework.Controls.MetroButton()
		Me.dgvListSach = New MetroFramework.Controls.MetroGrid()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtTenSach = New MetroFramework.Controls.MetroTextBox()
		Me.txtNhaXuatBan = New MetroFramework.Controls.MetroTextBox()
		Me.cbTheLoaiSach = New MetroFramework.Controls.MetroComboBox()
		Me.nudMinTriGia = New System.Windows.Forms.NumericUpDown()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.nudMaxTriGia = New System.Windows.Forms.NumericUpDown()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.nudMinNamXuatBan = New System.Windows.Forms.NumericUpDown()
		Me.nudMaxNamXuatBan = New System.Windows.Forms.NumericUpDown()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtMaSach = New MetroFramework.Controls.MetroTextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.dtpMinNgayNhap = New MetroFramework.Controls.MetroDateTime()
		Me.dtpMaxNgayNhap = New MetroFramework.Controls.MetroDateTime()
		Me.cbTacGia = New MetroFramework.Controls.MetroComboBox()
		Me.txtTinhTrangSach = New MetroFramework.Controls.MetroTextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMinTriGia,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMaxTriGia,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMinNamXuatBan,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nudMaxNamXuatBan,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.Location = New System.Drawing.Point(497, 66)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(92, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Nhà xuất bản"
		'
		'Label4
		'
		Me.Label4.AutoSize = true
		Me.Label4.Location = New System.Drawing.Point(497, 122)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 17)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "Tác giả"
		'
		'Label5
		'
		Me.Label5.AutoSize = true
		Me.Label5.Location = New System.Drawing.Point(845, 66)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(95, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Năm xuất bản"
		'
		'Label7
		'
		Me.Label7.AutoSize = true
		Me.Label7.Location = New System.Drawing.Point(845, 135)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(77, 17)
		Me.Label7.TabIndex = 0
		Me.Label7.Text = "Ngày nhập"
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.Location = New System.Drawing.Point(845, 98)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 17)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Trị giá"
		'
		'btnTimKiem
		'
		Me.btnTimKiem.Location = New System.Drawing.Point(729, 248)
		Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.btnTimKiem.Name = "btnTimKiem"
		Me.btnTimKiem.Size = New System.Drawing.Size(75, 23)
		Me.btnTimKiem.TabIndex = 11
		Me.btnTimKiem.Text = "Tìm kiếm"
		Me.btnTimKiem.UseSelectable = true
		'
		'dgvListSach
		'
		Me.dgvListSach.AllowUserToResizeRows = false
		Me.dgvListSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvListSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvListSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
		Me.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvListSach.DefaultCellStyle = DataGridViewCellStyle11
		Me.dgvListSach.EnableHeadersVisualStyles = false
		Me.dgvListSach.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvListSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvListSach.Location = New System.Drawing.Point(23, 297)
		Me.dgvListSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.dgvListSach.Name = "dgvListSach"
		Me.dgvListSach.ReadOnly = true
		Me.dgvListSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvListSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
		Me.dgvListSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvListSach.RowTemplate.Height = 24
		Me.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvListSach.Size = New System.Drawing.Size(1486, 399)
		Me.dgvListSach.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.Location = New System.Drawing.Point(188, 118)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(59, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Thể loại"
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.Location = New System.Drawing.Point(188, 64)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Tên sách"
		'
		'txtTenSach
		'
		'
		'
		'
		Me.txtTenSach.CustomButton.Image = Nothing
		Me.txtTenSach.CustomButton.Location = New System.Drawing.Point(201, 2)
		Me.txtTenSach.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtTenSach.CustomButton.Name = ""
		Me.txtTenSach.CustomButton.Size = New System.Drawing.Size(31, 28)
		Me.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenSach.CustomButton.TabIndex = 1
		Me.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenSach.CustomButton.UseSelectable = true
		Me.txtTenSach.CustomButton.Visible = false
		Me.txtTenSach.Lines = New String(-1) {}
		Me.txtTenSach.Location = New System.Drawing.Point(287, 64)
		Me.txtTenSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtTenSach.MaxLength = 32767
		Me.txtTenSach.Name = "txtTenSach"
		Me.txtTenSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenSach.SelectedText = ""
		Me.txtTenSach.SelectionLength = 0
		Me.txtTenSach.SelectionStart = 0
		Me.txtTenSach.ShortcutsEnabled = true
		Me.txtTenSach.Size = New System.Drawing.Size(177, 28)
		Me.txtTenSach.TabIndex = 0
		Me.txtTenSach.UseSelectable = true
		Me.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTenSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtNhaXuatBan
		'
		'
		'
		'
		Me.txtNhaXuatBan.CustomButton.Image = Nothing
		Me.txtNhaXuatBan.CustomButton.Location = New System.Drawing.Point(201, 2)
		Me.txtNhaXuatBan.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNhaXuatBan.CustomButton.Name = ""
		Me.txtNhaXuatBan.CustomButton.Size = New System.Drawing.Size(31, 28)
		Me.txtNhaXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtNhaXuatBan.CustomButton.TabIndex = 1
		Me.txtNhaXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtNhaXuatBan.CustomButton.UseSelectable = true
		Me.txtNhaXuatBan.CustomButton.Visible = false
		Me.txtNhaXuatBan.Lines = New String(-1) {}
		Me.txtNhaXuatBan.Location = New System.Drawing.Point(611, 64)
		Me.txtNhaXuatBan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtNhaXuatBan.MaxLength = 32767
		Me.txtNhaXuatBan.Name = "txtNhaXuatBan"
		Me.txtNhaXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNhaXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNhaXuatBan.SelectedText = ""
		Me.txtNhaXuatBan.SelectionLength = 0
		Me.txtNhaXuatBan.SelectionStart = 0
		Me.txtNhaXuatBan.ShortcutsEnabled = true
		Me.txtNhaXuatBan.Size = New System.Drawing.Size(177, 28)
		Me.txtNhaXuatBan.TabIndex = 3
		Me.txtNhaXuatBan.UseSelectable = true
		Me.txtNhaXuatBan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtNhaXuatBan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'cbTheLoaiSach
		'
		Me.cbTheLoaiSach.FormattingEnabled = true
		Me.cbTheLoaiSach.ItemHeight = 24
		Me.cbTheLoaiSach.Location = New System.Drawing.Point(287, 118)
		Me.cbTheLoaiSach.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cbTheLoaiSach.Name = "cbTheLoaiSach"
		Me.cbTheLoaiSach.Size = New System.Drawing.Size(177, 30)
		Me.cbTheLoaiSach.TabIndex = 1
		Me.cbTheLoaiSach.UseSelectable = true
		'
		'nudMinTriGia
		'
		Me.nudMinTriGia.Location = New System.Drawing.Point(1027, 92)
		Me.nudMinTriGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.nudMinTriGia.Name = "nudMinTriGia"
		Me.nudMinTriGia.Size = New System.Drawing.Size(88, 22)
		Me.nudMinTriGia.TabIndex = 7
		'
		'Label8
		'
		Me.Label8.AutoSize = true
		Me.Label8.Location = New System.Drawing.Point(987, 95)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(20, 17)
		Me.Label8.TabIndex = 0
		Me.Label8.Text = "từ"
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.Location = New System.Drawing.Point(1120, 97)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(32, 17)
		Me.Label9.TabIndex = 0
		Me.Label9.Text = "đến"
		'
		'nudMaxTriGia
		'
		Me.nudMaxTriGia.Location = New System.Drawing.Point(1157, 92)
		Me.nudMaxTriGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.nudMaxTriGia.Name = "nudMaxTriGia"
		Me.nudMaxTriGia.Size = New System.Drawing.Size(88, 22)
		Me.nudMaxTriGia.TabIndex = 8
		'
		'Label10
		'
		Me.Label10.AutoSize = true
		Me.Label10.Location = New System.Drawing.Point(987, 66)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(20, 17)
		Me.Label10.TabIndex = 0
		Me.Label10.Text = "từ"
		'
		'Label11
		'
		Me.Label11.AutoSize = true
		Me.Label11.Location = New System.Drawing.Point(1120, 69)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(32, 17)
		Me.Label11.TabIndex = 0
		Me.Label11.Text = "đến"
		'
		'nudMinNamXuatBan
		'
		Me.nudMinNamXuatBan.Location = New System.Drawing.Point(1027, 64)
		Me.nudMinNamXuatBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.nudMinNamXuatBan.Name = "nudMinNamXuatBan"
		Me.nudMinNamXuatBan.Size = New System.Drawing.Size(88, 22)
		Me.nudMinNamXuatBan.TabIndex = 5
		'
		'nudMaxNamXuatBan
		'
		Me.nudMaxNamXuatBan.Location = New System.Drawing.Point(1157, 64)
		Me.nudMaxNamXuatBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.nudMaxNamXuatBan.Name = "nudMaxNamXuatBan"
		Me.nudMaxNamXuatBan.Size = New System.Drawing.Size(88, 22)
		Me.nudMaxNamXuatBan.TabIndex = 6
		'
		'Label12
		'
		Me.Label12.AutoSize = true
		Me.Label12.Location = New System.Drawing.Point(987, 135)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(20, 17)
		Me.Label12.TabIndex = 0
		Me.Label12.Text = "từ"
		'
		'Label13
		'
		Me.Label13.AutoSize = true
		Me.Label13.Location = New System.Drawing.Point(987, 171)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(32, 17)
		Me.Label13.TabIndex = 0
		Me.Label13.Text = "đến"
		'
		'txtMaSach
		'
		'
		'
		'
		Me.txtMaSach.CustomButton.Image = Nothing
		Me.txtMaSach.CustomButton.Location = New System.Drawing.Point(201, 2)
		Me.txtMaSach.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtMaSach.CustomButton.Name = ""
		Me.txtMaSach.CustomButton.Size = New System.Drawing.Size(31, 28)
		Me.txtMaSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaSach.CustomButton.TabIndex = 1
		Me.txtMaSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaSach.CustomButton.UseSelectable = true
		Me.txtMaSach.CustomButton.Visible = false
		Me.txtMaSach.Lines = New String(-1) {}
		Me.txtMaSach.Location = New System.Drawing.Point(287, 174)
		Me.txtMaSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtMaSach.MaxLength = 32767
		Me.txtMaSach.Name = "txtMaSach"
		Me.txtMaSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaSach.SelectedText = ""
		Me.txtMaSach.SelectionLength = 0
		Me.txtMaSach.SelectionStart = 0
		Me.txtMaSach.ShortcutsEnabled = true
		Me.txtMaSach.Size = New System.Drawing.Size(177, 28)
		Me.txtMaSach.TabIndex = 2
		Me.txtMaSach.UseSelectable = true
		Me.txtMaSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtMaSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'Label14
		'
		Me.Label14.AutoSize = true
		Me.Label14.Location = New System.Drawing.Point(188, 174)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(61, 17)
		Me.Label14.TabIndex = 8
		Me.Label14.Text = "Mã sách"
		'
		'dtpMinNgayNhap
		'
		Me.dtpMinNgayNhap.Location = New System.Drawing.Point(1027, 124)
		Me.dtpMinNgayNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtpMinNgayNhap.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtpMinNgayNhap.Name = "dtpMinNgayNhap"
		Me.dtpMinNgayNhap.Size = New System.Drawing.Size(265, 30)
		Me.dtpMinNgayNhap.TabIndex = 12
		'
		'dtpMaxNgayNhap
		'
		Me.dtpMaxNgayNhap.Location = New System.Drawing.Point(1027, 164)
		Me.dtpMaxNgayNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtpMaxNgayNhap.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtpMaxNgayNhap.Name = "dtpMaxNgayNhap"
		Me.dtpMaxNgayNhap.Size = New System.Drawing.Size(265, 30)
		Me.dtpMaxNgayNhap.TabIndex = 13
		'
		'cbTacGia
		'
		Me.cbTacGia.FormattingEnabled = true
		Me.cbTacGia.ItemHeight = 24
		Me.cbTacGia.Location = New System.Drawing.Point(611, 118)
		Me.cbTacGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cbTacGia.Name = "cbTacGia"
		Me.cbTacGia.Size = New System.Drawing.Size(177, 30)
		Me.cbTacGia.TabIndex = 1
		Me.cbTacGia.UseSelectable = true
		'
		'txtTinhTrangSach
		'
		'
		'
		'
		Me.txtTinhTrangSach.CustomButton.Image = Nothing
		Me.txtTinhTrangSach.CustomButton.Location = New System.Drawing.Point(151, 2)
		Me.txtTinhTrangSach.CustomButton.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTinhTrangSach.CustomButton.Name = ""
		Me.txtTinhTrangSach.CustomButton.Size = New System.Drawing.Size(23, 23)
		Me.txtTinhTrangSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTinhTrangSach.CustomButton.TabIndex = 1
		Me.txtTinhTrangSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTinhTrangSach.CustomButton.UseSelectable = true
		Me.txtTinhTrangSach.CustomButton.Visible = false
		Me.txtTinhTrangSach.Lines = New String(-1) {}
		Me.txtTinhTrangSach.Location = New System.Drawing.Point(611, 174)
		Me.txtTinhTrangSach.Margin = New System.Windows.Forms.Padding(4)
		Me.txtTinhTrangSach.MaxLength = 32767
		Me.txtTinhTrangSach.Name = "txtTinhTrangSach"
		Me.txtTinhTrangSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTinhTrangSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTinhTrangSach.SelectedText = ""
		Me.txtTinhTrangSach.SelectionLength = 0
		Me.txtTinhTrangSach.SelectionStart = 0
		Me.txtTinhTrangSach.ShortcutsEnabled = true
		Me.txtTinhTrangSach.Size = New System.Drawing.Size(177, 28)
		Me.txtTinhTrangSach.TabIndex = 2
		Me.txtTinhTrangSach.UseSelectable = true
		Me.txtTinhTrangSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtTinhTrangSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'Label15
		'
		Me.Label15.AutoSize = true
		Me.Label15.Location = New System.Drawing.Point(497, 171)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(107, 17)
		Me.Label15.TabIndex = 8
		Me.Label15.Text = "Tình trạng sách"
		'
		'frmTraCuuSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1532, 764)
		Me.Controls.Add(Me.dtpMaxNgayNhap)
		Me.Controls.Add(Me.dtpMinNgayNhap)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.nudMaxNamXuatBan)
		Me.Controls.Add(Me.nudMaxTriGia)
		Me.Controls.Add(Me.nudMinNamXuatBan)
		Me.Controls.Add(Me.nudMinTriGia)
		Me.Controls.Add(Me.cbTacGia)
		Me.Controls.Add(Me.cbTheLoaiSach)
		Me.Controls.Add(Me.txtNhaXuatBan)
		Me.Controls.Add(Me.txtTinhTrangSach)
		Me.Controls.Add(Me.txtMaSach)
		Me.Controls.Add(Me.txtTenSach)
		Me.Controls.Add(Me.dgvListSach)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.btnTimKiem)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmTraCuuSach"
		Me.Padding = New System.Windows.Forms.Padding(20, 74, 20, 20)
		Me.Text = "Tra Cứu Sách"
		CType(Me.dgvListSach,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMinTriGia,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMaxTriGia,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMinNamXuatBan,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nudMaxNamXuatBan,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents btnTimKiem As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvListSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtTenSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtNhaXuatBan As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cbTheLoaiSach As MetroFramework.Controls.MetroComboBox
	Friend WithEvents nudMinTriGia As NumericUpDown
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents nudMaxTriGia As NumericUpDown
	Friend WithEvents Label10 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents nudMinNamXuatBan As NumericUpDown
	Friend WithEvents nudMaxNamXuatBan As NumericUpDown
	Friend WithEvents Label12 As Label
	Friend WithEvents Label13 As Label
	Friend WithEvents txtMaSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents Label14 As Label
	Friend WithEvents dtpMinNgayNhap As MetroFramework.Controls.MetroDateTime
	Friend WithEvents dtpMaxNgayNhap As MetroFramework.Controls.MetroDateTime
	Friend WithEvents cbTacGia As MetroFramework.Controls.MetroComboBox
	Friend WithEvents txtTinhTrangSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents Label15 As Label
End Class
