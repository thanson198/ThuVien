Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmBaoCaoTinhHinhMuonSachTheoTheLoai
	Private baoCaoTinhHinhMuonSachBUS As BaoCaoTinhHinhMuonSachTheoTheLoaiBUS

	Sub StyleRowDataGridView()
		For i As Integer = 0 To dgvChiTietBaoCao.RowCount - 1
			If i Mod 2 = 0 Then
				dgvChiTietBaoCao.Rows(i).DefaultCellStyle.BackColor = Color.White
			Else
				dgvChiTietBaoCao.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
			End If

		Next
	End Sub

	Private Sub frmBaoCaoTinhHinhMuonSachTheoTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		baoCaoTinhHinhMuonSachBUS = New BaoCaoTinhHinhMuonSachTheoTheLoaiBUS()
		If dtThangBaoCao.Value <> Nothing Then
			LoadListChiTietBaoCao()
		End If
	End Sub

	Private Sub dtThangBaoCao_ValueChanged(sender As Object, e As EventArgs) Handles dtThangBaoCao.ValueChanged
		LoadListChiTietBaoCao()
		dtThangBaoCao.CustomFormat = "MM:yyyy"
		dtThangBaoCao.Format = DateTimePickerFormat.Custom
		dtThangBaoCao.ShowUpDown = True
	End Sub

	Private Sub LoadListChiTietBaoCao()
		Dim tongSoLuotMuon As Integer = 0
		If dtThangBaoCao.Value <> Nothing Then
			Dim listTinhHinhMuonSach = New List(Of BaoCaoTinhHinhMuonSachTheoTheLoaiDTO)
			listTinhHinhMuonSach = baoCaoTinhHinhMuonSachBUS.SelectALL(dtThangBaoCao.Value.Month, dtThangBaoCao.Value.Year)
			dgvChiTietBaoCao.DataSource = New BindingSource(listTinhHinhMuonSach, String.Empty)

			dgvChiTietBaoCao.Columns.Clear()
			dgvChiTietBaoCao.DataSource = Nothing

			dgvChiTietBaoCao.AutoGenerateColumns = False
			dgvChiTietBaoCao.AllowUserToAddRows = False
			dgvChiTietBaoCao.AutoResizeColumns()
			dgvChiTietBaoCao.DataSource = listTinhHinhMuonSach

			Dim clTenTheLoaiSach = New DataGridViewTextBoxColumn()
			clTenTheLoaiSach.Name = "TenTheLoai"
			clTenTheLoaiSach.HeaderText = "Tên Thể Loại Sách"
			clTenTheLoaiSach.DataPropertyName = "TenTheLoai"
			dgvChiTietBaoCao.Columns.Add(clTenTheLoaiSach)

			Dim clSoLuotMuon = New DataGridViewTextBoxColumn()
			clSoLuotMuon.Name = "SoLuotMuon"
			clSoLuotMuon.HeaderText = "Số Lượt Mượn"
			clSoLuotMuon.DataPropertyName = "SoLuotMuon"
			dgvChiTietBaoCao.Columns.Add(clSoLuotMuon)

			Dim clTiLe = New DataGridViewTextBoxColumn()
			clTiLe.Name = "TiLe"
			clTiLe.HeaderText = "Tỉ Lệ"
			clTiLe.DataPropertyName = "TiLe"
			dgvChiTietBaoCao.Columns.Add(clTiLe)



			For Each dt As BaoCaoTinhHinhMuonSachTheoTheLoaiDTO In listTinhHinhMuonSach
				tongSoLuotMuon += dt.SoLuotMuon
			Next
			lblTongSoLuotMuon.Text = "Tổng số lượt mượn: " & tongSoLuotMuon
		End If
		dgvChiTietBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells

	End Sub

	Private Sub dgvChiTietBaoCao_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvChiTietBaoCao.DataSourceChanged
		StyleRowDataGridView()
	End Sub
End Class