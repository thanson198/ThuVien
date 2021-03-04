<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyLoaiDocGia
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
		Me.HtmlLabel1 = New MetroFramework.Drawing.Html.HtmlLabel()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.dgvDanhSachLoaiDocGia = New MetroFramework.Controls.MetroGrid()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaLoai = New MetroFramework.Controls.MetroTextBox()
		Me.btnCapNhap = New MetroFramework.Controls.MetroButton()
		Me.btnXoa = New MetroFramework.Controls.MetroButton()
		Me.txtTenLoai = New MetroFramework.Controls.MetroTextBox()
		CType(Me.dgvDanhSachLoaiDocGia,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'HtmlLabel1
		'
		Me.HtmlLabel1.AutoScroll = True
		Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(66, 23)
		Me.HtmlLabel1.AutoSize = False
		Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
		Me.HtmlLabel1.Location = New System.Drawing.Point(-14, -15)
		Me.HtmlLabel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.HtmlLabel1.Name = "HtmlLabel1"
		Me.HtmlLabel1.Size = New System.Drawing.Size(56, 19)
		Me.HtmlLabel1.TabIndex = 0
		Me.HtmlLabel1.Text = "HtmlLabel1"
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(178, 61)
		Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(148, 19)
		Me.MetroLabel1.TabIndex = 1
		Me.MetroLabel1.Text = "Danh Sách Loại Độc Giả"
		'
		'dgvDanhSachLoaiDocGia
		'
		Me.dgvDanhSachLoaiDocGia.AllowUserToResizeRows = False
		Me.dgvDanhSachLoaiDocGia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvDanhSachLoaiDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvDanhSachLoaiDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvDanhSachLoaiDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDanhSachLoaiDocGia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvDanhSachLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvDanhSachLoaiDocGia.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvDanhSachLoaiDocGia.EnableHeadersVisualStyles = False
		Me.dgvDanhSachLoaiDocGia.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvDanhSachLoaiDocGia.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvDanhSachLoaiDocGia.Location = New System.Drawing.Point(107, 79)
		Me.dgvDanhSachLoaiDocGia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.dgvDanhSachLoaiDocGia.Name = "dgvDanhSachLoaiDocGia"
		Me.dgvDanhSachLoaiDocGia.ReadOnly = True
		Me.dgvDanhSachLoaiDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvDanhSachLoaiDocGia.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvDanhSachLoaiDocGia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvDanhSachLoaiDocGia.RowTemplate.Height = 24
		Me.dgvDanhSachLoaiDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvDanhSachLoaiDocGia.Size = New System.Drawing.Size(300, 212)
		Me.dgvDanhSachLoaiDocGia.TabIndex = 4
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(184, 322)
		Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(59, 19)
		Me.MetroLabel2.TabIndex = 3
		Me.MetroLabel2.Text = "Mã Loại:"
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = True
		Me.MetroLabel3.Location = New System.Drawing.Point(182, 356)
		Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(59, 19)
		Me.MetroLabel3.TabIndex = 4
		Me.MetroLabel3.Text = "Tên Loại:"
		'
		'txtMaLoai
		'
		'
		'
		'
		Me.txtMaLoai.CustomButton.Image = Nothing
		Me.txtMaLoai.CustomButton.Location = New System.Drawing.Point(28, 1)
		Me.txtMaLoai.CustomButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtMaLoai.CustomButton.Name = ""
		Me.txtMaLoai.CustomButton.Size = New System.Drawing.Size(13, 14)
		Me.txtMaLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaLoai.CustomButton.TabIndex = 1
		Me.txtMaLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaLoai.CustomButton.UseSelectable = True
		Me.txtMaLoai.CustomButton.Visible = False
		Me.txtMaLoai.Lines = New String(-1) {}
		Me.txtMaLoai.Location = New System.Drawing.Point(280, 318)
		Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtMaLoai.MaxLength = 32767
		Me.txtMaLoai.Name = "txtMaLoai"
		Me.txtMaLoai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaLoai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaLoai.SelectedText = ""
		Me.txtMaLoai.SelectionLength = 0
		Me.txtMaLoai.SelectionStart = 0
		Me.txtMaLoai.ShortcutsEnabled = True
		Me.txtMaLoai.Size = New System.Drawing.Size(56, 19)
		Me.txtMaLoai.TabIndex = 5
		Me.txtMaLoai.UseSelectable = True
		Me.txtMaLoai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaLoai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnCapNhap
		'
		Me.btnCapNhap.Location = New System.Drawing.Point(148, 396)
		Me.btnCapNhap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnCapNhap.Name = "btnCapNhap"
		Me.btnCapNhap.Size = New System.Drawing.Size(81, 19)
		Me.btnCapNhap.TabIndex = 7
		Me.btnCapNhap.Text = "Cập Nhập"
		Me.btnCapNhap.UseSelectable = True
		'
		'btnXoa
		'
		Me.btnXoa.Location = New System.Drawing.Point(280, 396)
		Me.btnXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnXoa.Name = "btnXoa"
		Me.btnXoa.Size = New System.Drawing.Size(56, 19)
		Me.btnXoa.TabIndex = 7
		Me.btnXoa.Text = "Xoá"
		Me.btnXoa.UseSelectable = True
		'
		'txtTenLoai
		'
		'
		'
		'
		Me.txtTenLoai.CustomButton.Image = Nothing
		Me.txtTenLoai.CustomButton.Location = New System.Drawing.Point(28, 1)
		Me.txtTenLoai.CustomButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtTenLoai.CustomButton.Name = ""
		Me.txtTenLoai.CustomButton.Size = New System.Drawing.Size(13, 14)
		Me.txtTenLoai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTenLoai.CustomButton.TabIndex = 1
		Me.txtTenLoai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTenLoai.CustomButton.UseSelectable = True
		Me.txtTenLoai.CustomButton.Visible = False
		Me.txtTenLoai.Lines = New String(-1) {}
		Me.txtTenLoai.Location = New System.Drawing.Point(280, 353)
		Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtTenLoai.MaxLength = 32767
		Me.txtTenLoai.Name = "txtTenLoai"
		Me.txtTenLoai.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTenLoai.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTenLoai.SelectedText = ""
		Me.txtTenLoai.SelectionLength = 0
		Me.txtTenLoai.SelectionStart = 0
		Me.txtTenLoai.ShortcutsEnabled = True
		Me.txtTenLoai.Size = New System.Drawing.Size(56, 19)
		Me.txtTenLoai.TabIndex = 5
		Me.txtTenLoai.UseSelectable = True
		Me.txtTenLoai.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTenLoai.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'frmQuanLyLoaiDocGia
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(494, 466)
		Me.Controls.Add(Me.btnXoa)
		Me.Controls.Add(Me.btnCapNhap)
		Me.Controls.Add(Me.txtTenLoai)
		Me.Controls.Add(Me.txtMaLoai)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.dgvDanhSachLoaiDocGia)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Controls.Add(Me.HtmlLabel1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmQuanLyLoaiDocGia"
		Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
		Me.Text = "Quản Lý Loại Độc Giả"
		CType(Me.dgvDanhSachLoaiDocGia,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents HtmlLabel1 As MetroFramework.Drawing.Html.HtmlLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dgvDanhSachLoaiDocGia As MetroFramework.Controls.MetroGrid
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaLoai As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnCapNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
	Friend WithEvents txtTenLoai As MetroFramework.Controls.MetroTextBox
End Class
