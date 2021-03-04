<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaoCaoThongKeSachTraTre
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
		Me.dtNgayBaoCao = New MetroFramework.Controls.MetroDateTime()
		Me.dgvBaoCaoThongKeSachTraTre = New MetroFramework.Controls.MetroGrid()
		CType(Me.dgvBaoCaoThongKeSachTraTre,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dtNgayBaoCao
		'
		Me.dtNgayBaoCao.Location = New System.Drawing.Point(80, 110)
		Me.dtNgayBaoCao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dtNgayBaoCao.MinimumSize = New System.Drawing.Size(0, 30)
		Me.dtNgayBaoCao.Name = "dtNgayBaoCao"
		Me.dtNgayBaoCao.Size = New System.Drawing.Size(265, 30)
		Me.dtNgayBaoCao.TabIndex = 0
		'
		'dgvBaoCaoThongKeSachTraTre
		'
		Me.dgvBaoCaoThongKeSachTraTre.AllowUserToResizeRows = false
		Me.dgvBaoCaoThongKeSachTraTre.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvBaoCaoThongKeSachTraTre.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvBaoCaoThongKeSachTraTre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvBaoCaoThongKeSachTraTre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvBaoCaoThongKeSachTraTre.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvBaoCaoThongKeSachTraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvBaoCaoThongKeSachTraTre.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvBaoCaoThongKeSachTraTre.EnableHeadersVisualStyles = false
		Me.dgvBaoCaoThongKeSachTraTre.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvBaoCaoThongKeSachTraTre.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.dgvBaoCaoThongKeSachTraTre.Location = New System.Drawing.Point(80, 188)
		Me.dgvBaoCaoThongKeSachTraTre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.dgvBaoCaoThongKeSachTraTre.Name = "dgvBaoCaoThongKeSachTraTre"
		Me.dgvBaoCaoThongKeSachTraTre.ReadOnly = true
		Me.dgvBaoCaoThongKeSachTraTre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvBaoCaoThongKeSachTraTre.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvBaoCaoThongKeSachTraTre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvBaoCaoThongKeSachTraTre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvBaoCaoThongKeSachTraTre.Size = New System.Drawing.Size(539, 185)
		Me.dgvBaoCaoThongKeSachTraTre.TabIndex = 1
		'
		'frmBaoCaoThongKeSachTraTre
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(740, 514)
		Me.Controls.Add(Me.dgvBaoCaoThongKeSachTraTre)
		Me.Controls.Add(Me.dtNgayBaoCao)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "frmBaoCaoThongKeSachTraTre"
		Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
		Me.Text = "Báo Cáo Thống Kê Sách Trả Trễ"
		CType(Me.dgvBaoCaoThongKeSachTraTre,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents dtNgayBaoCao As MetroFramework.Controls.MetroDateTime
	Friend WithEvents dgvBaoCaoThongKeSachTraTre As MetroFramework.Controls.MetroGrid
End Class
