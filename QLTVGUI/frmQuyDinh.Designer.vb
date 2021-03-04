<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuyDinh
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtTuoiToiThieu = New MetroFramework.Controls.MetroTextBox()
        Me.txtTuoiToiDa = New MetroFramework.Controls.MetroTextBox()
        Me.txtKhoangCachXuatBan = New MetroFramework.Controls.MetroTextBox()
        Me.txtSoNgayMuonToiDa = New MetroFramework.Controls.MetroTextBox()
        Me.txtSoSachMuonToiDa = New MetroFramework.Controls.MetroTextBox()
        Me.btnCapNhat = New MetroFramework.Controls.MetroButton()
        Me.txtHanSuDung = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(25, 79)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(155, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Tuổi tối thiểu của độc giả"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(25, 114)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Tuổi tối đa của độc giả"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(25, 155)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(176, 19)
        Me.MetroLabel3.TabIndex = 0
        Me.MetroLabel3.Text = "Thời hạn sử dụng thẻ(Tháng)"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(25, 193)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(174, 19)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Khoảng cách xuất bản(Năm)"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(25, 231)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(162, 19)
        Me.MetroLabel5.TabIndex = 0
        Me.MetroLabel5.Text = "Số ngày mượn sách tối đa"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(25, 271)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(130, 19)
        Me.MetroLabel6.TabIndex = 0
        Me.MetroLabel6.Text = "Số sách mượn tối đa"
        '
        'txtTuoiToiThieu
        '
        '
        '
        '
        Me.txtTuoiToiThieu.CustomButton.Image = Nothing
        Me.txtTuoiToiThieu.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtTuoiToiThieu.CustomButton.Name = ""
        Me.txtTuoiToiThieu.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTuoiToiThieu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTuoiToiThieu.CustomButton.TabIndex = 1
        Me.txtTuoiToiThieu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTuoiToiThieu.CustomButton.UseSelectable = True
        Me.txtTuoiToiThieu.CustomButton.Visible = False
        Me.txtTuoiToiThieu.Lines = New String(-1) {}
        Me.txtTuoiToiThieu.Location = New System.Drawing.Point(211, 75)
        Me.txtTuoiToiThieu.MaxLength = 32767
        Me.txtTuoiToiThieu.Name = "txtTuoiToiThieu"
        Me.txtTuoiToiThieu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTuoiToiThieu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTuoiToiThieu.SelectedText = ""
        Me.txtTuoiToiThieu.SelectionLength = 0
        Me.txtTuoiToiThieu.SelectionStart = 0
        Me.txtTuoiToiThieu.ShortcutsEnabled = True
        Me.txtTuoiToiThieu.Size = New System.Drawing.Size(133, 23)
        Me.txtTuoiToiThieu.TabIndex = 0
        Me.txtTuoiToiThieu.UseSelectable = True
        Me.txtTuoiToiThieu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTuoiToiThieu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTuoiToiDa
        '
        '
        '
        '
        Me.txtTuoiToiDa.CustomButton.Image = Nothing
        Me.txtTuoiToiDa.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtTuoiToiDa.CustomButton.Name = ""
        Me.txtTuoiToiDa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTuoiToiDa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTuoiToiDa.CustomButton.TabIndex = 1
        Me.txtTuoiToiDa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTuoiToiDa.CustomButton.UseSelectable = True
        Me.txtTuoiToiDa.CustomButton.Visible = False
        Me.txtTuoiToiDa.Lines = New String(-1) {}
        Me.txtTuoiToiDa.Location = New System.Drawing.Point(211, 110)
        Me.txtTuoiToiDa.MaxLength = 32767
        Me.txtTuoiToiDa.Name = "txtTuoiToiDa"
        Me.txtTuoiToiDa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTuoiToiDa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTuoiToiDa.SelectedText = ""
        Me.txtTuoiToiDa.SelectionLength = 0
        Me.txtTuoiToiDa.SelectionStart = 0
        Me.txtTuoiToiDa.ShortcutsEnabled = True
        Me.txtTuoiToiDa.Size = New System.Drawing.Size(133, 23)
        Me.txtTuoiToiDa.TabIndex = 1
        Me.txtTuoiToiDa.UseSelectable = True
        Me.txtTuoiToiDa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTuoiToiDa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtKhoangCachXuatBan
        '
        '
        '
        '
        Me.txtKhoangCachXuatBan.CustomButton.Image = Nothing
        Me.txtKhoangCachXuatBan.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtKhoangCachXuatBan.CustomButton.Name = ""
        Me.txtKhoangCachXuatBan.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtKhoangCachXuatBan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKhoangCachXuatBan.CustomButton.TabIndex = 1
        Me.txtKhoangCachXuatBan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKhoangCachXuatBan.CustomButton.UseSelectable = True
        Me.txtKhoangCachXuatBan.CustomButton.Visible = False
        Me.txtKhoangCachXuatBan.Lines = New String(-1) {}
        Me.txtKhoangCachXuatBan.Location = New System.Drawing.Point(211, 193)
        Me.txtKhoangCachXuatBan.MaxLength = 32767
        Me.txtKhoangCachXuatBan.Name = "txtKhoangCachXuatBan"
        Me.txtKhoangCachXuatBan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKhoangCachXuatBan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKhoangCachXuatBan.SelectedText = ""
        Me.txtKhoangCachXuatBan.SelectionLength = 0
        Me.txtKhoangCachXuatBan.SelectionStart = 0
        Me.txtKhoangCachXuatBan.ShortcutsEnabled = True
        Me.txtKhoangCachXuatBan.Size = New System.Drawing.Size(133, 23)
        Me.txtKhoangCachXuatBan.TabIndex = 3
        Me.txtKhoangCachXuatBan.UseSelectable = True
        Me.txtKhoangCachXuatBan.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKhoangCachXuatBan.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSoNgayMuonToiDa
        '
        '
        '
        '
        Me.txtSoNgayMuonToiDa.CustomButton.Image = Nothing
        Me.txtSoNgayMuonToiDa.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtSoNgayMuonToiDa.CustomButton.Name = ""
        Me.txtSoNgayMuonToiDa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSoNgayMuonToiDa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSoNgayMuonToiDa.CustomButton.TabIndex = 1
        Me.txtSoNgayMuonToiDa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSoNgayMuonToiDa.CustomButton.UseSelectable = True
        Me.txtSoNgayMuonToiDa.CustomButton.Visible = False
        Me.txtSoNgayMuonToiDa.Lines = New String(-1) {}
        Me.txtSoNgayMuonToiDa.Location = New System.Drawing.Point(211, 231)
        Me.txtSoNgayMuonToiDa.MaxLength = 32767
        Me.txtSoNgayMuonToiDa.Name = "txtSoNgayMuonToiDa"
        Me.txtSoNgayMuonToiDa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSoNgayMuonToiDa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSoNgayMuonToiDa.SelectedText = ""
        Me.txtSoNgayMuonToiDa.SelectionLength = 0
        Me.txtSoNgayMuonToiDa.SelectionStart = 0
        Me.txtSoNgayMuonToiDa.ShortcutsEnabled = True
        Me.txtSoNgayMuonToiDa.Size = New System.Drawing.Size(133, 23)
        Me.txtSoNgayMuonToiDa.TabIndex = 4
        Me.txtSoNgayMuonToiDa.UseSelectable = True
        Me.txtSoNgayMuonToiDa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSoNgayMuonToiDa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSoSachMuonToiDa
        '
        '
        '
        '
        Me.txtSoSachMuonToiDa.CustomButton.Image = Nothing
        Me.txtSoSachMuonToiDa.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtSoSachMuonToiDa.CustomButton.Name = ""
        Me.txtSoSachMuonToiDa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSoSachMuonToiDa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSoSachMuonToiDa.CustomButton.TabIndex = 1
        Me.txtSoSachMuonToiDa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSoSachMuonToiDa.CustomButton.UseSelectable = True
        Me.txtSoSachMuonToiDa.CustomButton.Visible = False
        Me.txtSoSachMuonToiDa.Lines = New String(-1) {}
        Me.txtSoSachMuonToiDa.Location = New System.Drawing.Point(211, 271)
        Me.txtSoSachMuonToiDa.MaxLength = 32767
        Me.txtSoSachMuonToiDa.Name = "txtSoSachMuonToiDa"
        Me.txtSoSachMuonToiDa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSoSachMuonToiDa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSoSachMuonToiDa.SelectedText = ""
        Me.txtSoSachMuonToiDa.SelectionLength = 0
        Me.txtSoSachMuonToiDa.SelectionStart = 0
        Me.txtSoSachMuonToiDa.ShortcutsEnabled = True
        Me.txtSoSachMuonToiDa.Size = New System.Drawing.Size(133, 23)
        Me.txtSoSachMuonToiDa.TabIndex = 5
        Me.txtSoSachMuonToiDa.UseSelectable = True
        Me.txtSoSachMuonToiDa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSoSachMuonToiDa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(237, 308)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseSelectable = True
        '
        'txtHanSuDung
        '
        '
        '
        '
        Me.txtHanSuDung.CustomButton.Image = Nothing
        Me.txtHanSuDung.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtHanSuDung.CustomButton.Name = ""
        Me.txtHanSuDung.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtHanSuDung.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtHanSuDung.CustomButton.TabIndex = 1
        Me.txtHanSuDung.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtHanSuDung.CustomButton.UseSelectable = True
        Me.txtHanSuDung.CustomButton.Visible = False
        Me.txtHanSuDung.Lines = New String(-1) {}
        Me.txtHanSuDung.Location = New System.Drawing.Point(211, 151)
        Me.txtHanSuDung.MaxLength = 32767
        Me.txtHanSuDung.Name = "txtHanSuDung"
        Me.txtHanSuDung.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHanSuDung.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHanSuDung.SelectedText = ""
        Me.txtHanSuDung.SelectionLength = 0
        Me.txtHanSuDung.SelectionStart = 0
        Me.txtHanSuDung.ShortcutsEnabled = True
        Me.txtHanSuDung.Size = New System.Drawing.Size(133, 23)
        Me.txtHanSuDung.TabIndex = 2
        Me.txtHanSuDung.UseSelectable = True
        Me.txtHanSuDung.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtHanSuDung.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmQuyDinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 358)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtSoSachMuonToiDa)
        Me.Controls.Add(Me.txtSoNgayMuonToiDa)
        Me.Controls.Add(Me.txtKhoangCachXuatBan)
        Me.Controls.Add(Me.txtHanSuDung)
        Me.Controls.Add(Me.txtTuoiToiDa)
        Me.Controls.Add(Me.txtTuoiToiThieu)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuyDinh"
        Me.Resizable = False
        Me.Text = "Quy Định"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtTuoiToiThieu As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTuoiToiDa As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtKhoangCachXuatBan As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtSoNgayMuonToiDa As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtSoSachMuonToiDa As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnCapNhat As MetroFramework.Controls.MetroButton
	Friend WithEvents txtHanSuDung As MetroFramework.Controls.MetroTextBox
End Class
