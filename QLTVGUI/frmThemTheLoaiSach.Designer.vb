<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemTheLoaiSach
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
        Me.txtMaTheLoaiSach = New MetroFramework.Controls.MetroTextBox()
        Me.txtTenTheLoaiSach = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnNhap = New MetroFramework.Controls.MetroButton()
        Me.btnNhapVaDong = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtMaTheLoaiSach
        '
        '
        '
        '
        Me.txtMaTheLoaiSach.CustomButton.Image = Nothing
        Me.txtMaTheLoaiSach.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txtMaTheLoaiSach.CustomButton.Name = ""
        Me.txtMaTheLoaiSach.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMaTheLoaiSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMaTheLoaiSach.CustomButton.TabIndex = 1
        Me.txtMaTheLoaiSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMaTheLoaiSach.CustomButton.UseSelectable = True
        Me.txtMaTheLoaiSach.CustomButton.Visible = False
        Me.txtMaTheLoaiSach.Lines = New String(-1) {}
        Me.txtMaTheLoaiSach.Location = New System.Drawing.Point(151, 80)
        Me.txtMaTheLoaiSach.MaxLength = 32767
        Me.txtMaTheLoaiSach.Name = "txtMaTheLoaiSach"
        Me.txtMaTheLoaiSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaTheLoaiSach.ReadOnly = True
        Me.txtMaTheLoaiSach.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMaTheLoaiSach.SelectedText = ""
        Me.txtMaTheLoaiSach.SelectionLength = 0
        Me.txtMaTheLoaiSach.SelectionStart = 0
        Me.txtMaTheLoaiSach.ShortcutsEnabled = True
        Me.txtMaTheLoaiSach.Size = New System.Drawing.Size(179, 23)
        Me.txtMaTheLoaiSach.TabIndex = 0
        Me.txtMaTheLoaiSach.UseSelectable = True
        Me.txtMaTheLoaiSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMaTheLoaiSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTenTheLoaiSach
        '
        '
        '
        '
        Me.txtTenTheLoaiSach.CustomButton.Image = Nothing
        Me.txtTenTheLoaiSach.CustomButton.Location = New System.Drawing.Point(157, 1)
        Me.txtTenTheLoaiSach.CustomButton.Name = ""
        Me.txtTenTheLoaiSach.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTenTheLoaiSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTenTheLoaiSach.CustomButton.TabIndex = 1
        Me.txtTenTheLoaiSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTenTheLoaiSach.CustomButton.UseSelectable = True
        Me.txtTenTheLoaiSach.CustomButton.Visible = False
        Me.txtTenTheLoaiSach.Lines = New String(-1) {}
        Me.txtTenTheLoaiSach.Location = New System.Drawing.Point(151, 133)
        Me.txtTenTheLoaiSach.MaxLength = 32767
        Me.txtTenTheLoaiSach.Name = "txtTenTheLoaiSach"
        Me.txtTenTheLoaiSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTenTheLoaiSach.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTenTheLoaiSach.SelectedText = ""
        Me.txtTenTheLoaiSach.SelectionLength = 0
        Me.txtTenTheLoaiSach.SelectionStart = 0
        Me.txtTenTheLoaiSach.ShortcutsEnabled = True
        Me.txtTenTheLoaiSach.Size = New System.Drawing.Size(179, 23)
        Me.txtTenTheLoaiSach.TabIndex = 1
        Me.txtTenTheLoaiSach.UseSelectable = True
        Me.txtTenTheLoaiSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTenTheLoaiSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 80)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Mã Thể Loại Sách"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 133)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Tên Thể Loại Sách"
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(151, 189)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnNhap.TabIndex = 2
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseSelectable = True
        '
        'btnNhapVaDong
        '
        Me.btnNhapVaDong.Location = New System.Drawing.Point(243, 189)
        Me.btnNhapVaDong.Name = "btnNhapVaDong"
        Me.btnNhapVaDong.Size = New System.Drawing.Size(87, 23)
        Me.btnNhapVaDong.TabIndex = 3
        Me.btnNhapVaDong.Text = "Nhập và đóng"
        Me.btnNhapVaDong.UseSelectable = True
        '
        'frmThemTheLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 250)
        Me.Controls.Add(Me.btnNhapVaDong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtTenTheLoaiSach)
        Me.Controls.Add(Me.txtMaTheLoaiSach)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThemTheLoaiSach"
        Me.Text = "Thêm thể loại sách"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMaTheLoaiSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenTheLoaiSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnNhapVaDong As MetroFramework.Controls.MetroButton
End Class
