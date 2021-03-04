<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemTacGia
	Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtMaTacGia = New MetroFramework.Controls.MetroTextBox()
        Me.txtTenTacGia = New MetroFramework.Controls.MetroTextBox()
        Me.btnNhap = New MetroFramework.Controls.MetroButton()
        Me.btnNhapVaDong = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(39, 73)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Mã tác giả"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(39, 105)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Tên tác giả"
        '
        'txtMaTacGia
        '
        '
        '
        '
        Me.txtMaTacGia.CustomButton.Image = Nothing
        Me.txtMaTacGia.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.txtMaTacGia.CustomButton.Name = ""
        Me.txtMaTacGia.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMaTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMaTacGia.CustomButton.TabIndex = 1
        Me.txtMaTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMaTacGia.CustomButton.UseSelectable = True
        Me.txtMaTacGia.CustomButton.Visible = False
        Me.txtMaTacGia.Lines = New String(-1) {}
        Me.txtMaTacGia.Location = New System.Drawing.Point(128, 73)
        Me.txtMaTacGia.MaxLength = 32767
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMaTacGia.SelectedText = ""
        Me.txtMaTacGia.SelectionLength = 0
        Me.txtMaTacGia.SelectionStart = 0
        Me.txtMaTacGia.ShortcutsEnabled = True
        Me.txtMaTacGia.Size = New System.Drawing.Size(191, 23)
        Me.txtMaTacGia.TabIndex = 1
        Me.txtMaTacGia.UseSelectable = True
        Me.txtMaTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMaTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTenTacGia
        '
        '
        '
        '
        Me.txtTenTacGia.CustomButton.Image = Nothing
        Me.txtTenTacGia.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.txtTenTacGia.CustomButton.Name = ""
        Me.txtTenTacGia.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTenTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTenTacGia.CustomButton.TabIndex = 1
        Me.txtTenTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTenTacGia.CustomButton.UseSelectable = True
        Me.txtTenTacGia.CustomButton.Visible = False
        Me.txtTenTacGia.Lines = New String(-1) {}
        Me.txtTenTacGia.Location = New System.Drawing.Point(128, 105)
        Me.txtTenTacGia.MaxLength = 32767
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTenTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTenTacGia.SelectedText = ""
        Me.txtTenTacGia.SelectionLength = 0
        Me.txtTenTacGia.SelectionStart = 0
        Me.txtTenTacGia.ShortcutsEnabled = True
        Me.txtTenTacGia.Size = New System.Drawing.Size(191, 23)
        Me.txtTenTacGia.TabIndex = 1
        Me.txtTenTacGia.UseSelectable = True
        Me.txtTenTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTenTacGia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(128, 153)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnNhap.TabIndex = 2
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseSelectable = True
        '
        'btnNhapVaDong
        '
        Me.btnNhapVaDong.Location = New System.Drawing.Point(232, 153)
        Me.btnNhapVaDong.Name = "btnNhapVaDong"
        Me.btnNhapVaDong.Size = New System.Drawing.Size(87, 23)
        Me.btnNhapVaDong.TabIndex = 3
        Me.btnNhapVaDong.Text = "Nhập và đóng"
        Me.btnNhapVaDong.UseSelectable = True
        '
        'frmThemTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 201)
        Me.Controls.Add(Me.btnNhapVaDong)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.txtTenTacGia)
        Me.Controls.Add(Me.txtMaTacGia)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "frmThemTacGia"
        Me.Text = "Thêm Tác Giả"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaTacGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtTenTacGia As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnNhap As MetroFramework.Controls.MetroButton
	Friend WithEvents btnNhapVaDong As MetroFramework.Controls.MetroButton
End Class
