<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLapPhieuTraSach
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.txtMaPhieuMuonSach = New MetroFramework.Controls.MetroTextBox()
		Me.dgvNhanTraSach = New MetroFramework.Controls.MetroGrid()
		Me.btnTraSach = New MetroFramework.Controls.MetroButton()
		Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.dtNgayTraSach = New MetroFramework.Controls.MetroDateTime()
		Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
		Me.dtpNgayTraSach = New MetroFramework.Controls.MetroDateTime()
		CType(Me.dgvNhanTraSach,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = true
		Me.MetroLabel1.Location = New System.Drawing.Point(151, 116)
		Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(140, 20)
		Me.MetroLabel1.TabIndex = 0
		Me.MetroLabel1.Text = "Mã Phiếu Mượn Sách"
		'
		'txtMaPhieuMuonSach
		'
		'
		'
		'
		Me.txtMaPhieuMuonSach.CustomButton.Image = Nothing
		Me.txtMaPhieuMuonSach.CustomButton.Location = New System.Drawing.Point(321, 2)
		Me.txtMaPhieuMuonSach.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtMaPhieuMuonSach.CustomButton.Name = ""
		Me.txtMaPhieuMuonSach.CustomButton.Size = New System.Drawing.Size(31, 28)
		Me.txtMaPhieuMuonSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaPhieuMuonSach.CustomButton.TabIndex = 1
		Me.txtMaPhieuMuonSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaPhieuMuonSach.CustomButton.UseSelectable = true
		Me.txtMaPhieuMuonSach.CustomButton.Visible = false
		Me.txtMaPhieuMuonSach.Lines = New String(-1) {}
		Me.txtMaPhieuMuonSach.Location = New System.Drawing.Point(364, 116)
		Me.txtMaPhieuMuonSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtMaPhieuMuonSach.MaxLength = 32767
		Me.txtMaPhieuMuonSach.Name = "txtMaPhieuMuonSach"
		Me.txtMaPhieuMuonSach.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaPhieuMuonSach.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaPhieuMuonSach.SelectedText = ""
		Me.txtMaPhieuMuonSach.SelectionLength = 0
		Me.txtMaPhieuMuonSach.SelectionStart = 0
		Me.txtMaPhieuMuonSach.ShortcutsEnabled = true
		Me.txtMaPhieuMuonSach.Size = New System.Drawing.Size(267, 28)
		Me.txtMaPhieuMuonSach.TabIndex = 1
		Me.txtMaPhieuMuonSach.UseSelectable = true
		Me.txtMaPhieuMuonSach.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
		Me.txtMaPhieuMuonSach.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'dgvNhanTraSach
		'
		Me.dgvNhanTraSach.AllowUserToResizeRows = false
		Me.dgvNhanTraSach.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvNhanTraSach.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvNhanTraSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvNhanTraSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvNhanTraSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvNhanTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvNhanTraSach.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvNhanTraSach.EnableHeadersVisualStyles = false
		Me.dgvNhanTraSach.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvNhanTraSach.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvNhanTraSach.Location = New System.Drawing.Point(124, 290)
		Me.dgvNhanTraSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dgvNhanTraSach.Name = "dgvNhanTraSach"
		Me.dgvNhanTraSach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvNhanTraSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvNhanTraSach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvNhanTraSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvNhanTraSach.Size = New System.Drawing.Size(709, 185)
		Me.dgvNhanTraSach.TabIndex = 2
		'
		'btnTraSach
		'
		Me.btnTraSach.Location = New System.Drawing.Point(433, 518)
		Me.btnTraSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnTraSach.Name = "btnTraSach"
		Me.btnTraSach.Size = New System.Drawing.Size(100, 28)
		Me.btnTraSach.TabIndex = 3
		Me.btnTraSach.Text = "Trả Sách"
		Me.btnTraSach.UseSelectable = true
		'
		'MetroGrid1
		'
		Me.MetroGrid1.AllowUserToResizeRows = false
		Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle5
		Me.MetroGrid1.EnableHeadersVisualStyles = false
		Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.MetroGrid1.Location = New System.Drawing.Point(328, 443)
		Me.MetroGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MetroGrid1.Name = "MetroGrid1"
		Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.MetroGrid1.Size = New System.Drawing.Size(11, 10)
		Me.MetroGrid1.TabIndex = 4
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = true
		Me.MetroLabel2.Location = New System.Drawing.Point(151, 169)
		Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(114, 20)
		Me.MetroLabel2.TabIndex = 6
		Me.MetroLabel2.Text = "Ngày mượn sách"
		'
		'dtNgayTraSach
		'
		Me.dtNgayTraSach.Location = New System.Drawing.Point(364, 169)
		Me.dtNgayTraSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtNgayTraSach.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtNgayTraSach.Name = "dtNgayTraSach"
		Me.dtNgayTraSach.Size = New System.Drawing.Size(265, 30)
		Me.dtNgayTraSach.TabIndex = 7
		'
		'MetroLabel3
		'
		Me.MetroLabel3.AutoSize = true
		Me.MetroLabel3.Location = New System.Drawing.Point(151, 220)
		Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.MetroLabel3.Name = "MetroLabel3"
		Me.MetroLabel3.Size = New System.Drawing.Size(94, 20)
		Me.MetroLabel3.TabIndex = 8
		Me.MetroLabel3.Text = "Ngày trả sách"
		'
		'dtpNgayTraSach
		'
		Me.dtpNgayTraSach.Location = New System.Drawing.Point(364, 220)
		Me.dtpNgayTraSach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtpNgayTraSach.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtpNgayTraSach.Name = "dtpNgayTraSach"
		Me.dtpNgayTraSach.Size = New System.Drawing.Size(265, 30)
		Me.dtpNgayTraSach.TabIndex = 9
		'
		'frmLapPhieuTraSach
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(931, 571)
		Me.Controls.Add(Me.dtpNgayTraSach)
		Me.Controls.Add(Me.MetroLabel3)
		Me.Controls.Add(Me.dtNgayTraSach)
		Me.Controls.Add(Me.MetroLabel2)
		Me.Controls.Add(Me.MetroGrid1)
		Me.Controls.Add(Me.btnTraSach)
		Me.Controls.Add(Me.dgvNhanTraSach)
		Me.Controls.Add(Me.txtMaPhieuMuonSach)
		Me.Controls.Add(Me.MetroLabel1)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "frmLapPhieuTraSach"
		Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
		Me.Text = "Lập Phiếu Trả Sách"
		CType(Me.dgvNhanTraSach,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaPhieuMuonSach As MetroFramework.Controls.MetroTextBox
	Friend WithEvents dgvNhanTraSach As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnTraSach As MetroFramework.Controls.MetroButton
	Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dtNgayTraSach As MetroFramework.Controls.MetroDateTime
	Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
	Friend WithEvents dtpNgayTraSach As MetroFramework.Controls.MetroDateTime
End Class
