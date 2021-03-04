<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaoCaoTinhHinhMuonSachTheoTheLoai
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
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dtThangBaoCao = New MetroFramework.Controls.MetroDateTime()
		Me.dgvChiTietBaoCao = New MetroFramework.Controls.MetroGrid()
		Me.lblTongSoLuotMuon = New MetroFramework.Controls.MetroLabel()
		CType(Me.dgvChiTietBaoCao,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dtThangBaoCao
		'
		Me.dtThangBaoCao.Location = New System.Drawing.Point(109, 112)
		Me.dtThangBaoCao.Margin = New System.Windows.Forms.Padding(4)
		Me.dtThangBaoCao.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtThangBaoCao.Name = "dtThangBaoCao"
		Me.dtThangBaoCao.Size = New System.Drawing.Size(265, 30)
		Me.dtThangBaoCao.TabIndex = 0
		'
		'dgvChiTietBaoCao
		'
		Me.dgvChiTietBaoCao.AllowUserToResizeRows = false
		Me.dgvChiTietBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvChiTietBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvChiTietBaoCao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
		Me.dgvChiTietBaoCao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(52,Byte),Integer), CType(CType(52,Byte),Integer))
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvChiTietBaoCao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvChiTietBaoCao.ColumnHeadersHeight = 30
		Me.dgvChiTietBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvChiTietBaoCao.DefaultCellStyle = DataGridViewCellStyle8
		Me.dgvChiTietBaoCao.EnableHeadersVisualStyles = false
		Me.dgvChiTietBaoCao.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvChiTietBaoCao.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvChiTietBaoCao.Location = New System.Drawing.Point(109, 192)
		Me.dgvChiTietBaoCao.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvChiTietBaoCao.Name = "dgvChiTietBaoCao"
		Me.dgvChiTietBaoCao.ReadOnly = true
		Me.dgvChiTietBaoCao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvChiTietBaoCao.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvChiTietBaoCao.RowHeadersVisible = false
		Me.dgvChiTietBaoCao.RowHeadersWidth = 600
		Me.dgvChiTietBaoCao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvChiTietBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvChiTietBaoCao.Size = New System.Drawing.Size(511, 185)
		Me.dgvChiTietBaoCao.TabIndex = 1
		'
		'lblTongSoLuotMuon
		'
		Me.lblTongSoLuotMuon.AutoSize = true
		Me.lblTongSoLuotMuon.BackColor = System.Drawing.Color.White
		Me.lblTongSoLuotMuon.FontWeight = MetroFramework.MetroLabelWeight.Bold
		Me.lblTongSoLuotMuon.ForeColor = System.Drawing.Color.White
		Me.lblTongSoLuotMuon.Location = New System.Drawing.Point(348, 380)
		Me.lblTongSoLuotMuon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTongSoLuotMuon.Name = "lblTongSoLuotMuon"
		Me.lblTongSoLuotMuon.Size = New System.Drawing.Size(141, 20)
		Me.lblTongSoLuotMuon.TabIndex = 2
		Me.lblTongSoLuotMuon.Text = "Tổng lượt mượn: 0"
		'
		'frmBaoCaoTinhHinhMuonSachTheoTheLoai
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
		Me.ClientSize = New System.Drawing.Size(762, 415)
		Me.Controls.Add(Me.lblTongSoLuotMuon)
		Me.Controls.Add(Me.dgvChiTietBaoCao)
		Me.Controls.Add(Me.dtThangBaoCao)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "frmBaoCaoTinhHinhMuonSachTheoTheLoai"
		Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
		Me.Text = "Báo Cáo Tình Hình Mượn Sách Theo Thể Loại"
		CType(Me.dgvChiTietBaoCao,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents dtThangBaoCao As MetroFramework.Controls.MetroDateTime
	Friend WithEvents dgvChiTietBaoCao As MetroFramework.Controls.MetroGrid
	Friend WithEvents lblTongSoLuotMuon As MetroFramework.Controls.MetroLabel
End Class
