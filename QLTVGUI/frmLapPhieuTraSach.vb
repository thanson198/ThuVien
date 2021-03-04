Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapPhieuTraSach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS
	Private chiTietPhieuMuonSachBUS As ChiTietPhieuMuonSachBUS
	Private phieuMuonSachBUS As PhieuMuonSachBUS
	Private phieuTraSachBUS As PhieuTraSachBUS
	Private Sub LoadChiTietPhieuMuonSach(maPhieuMuonSach As Integer)
		Dim listSach = New List(Of SachReceive)
		Dim result As Result

		result = phieuMuonSachBUS.SelectByType(maPhieuMuonSach, listSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		'dgvListDocGia.SuspendLayout()
		dgvNhanTraSach.Columns.Clear()
		dgvNhanTraSach.DataSource = Nothing
		dgvNhanTraSach.AutoGenerateColumns = False
		dgvNhanTraSach.AllowUserToAddRows = False
		dgvNhanTraSach.AutoResizeColumns()

		dgvNhanTraSach.DataSource = listSach

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		clMa.DataPropertyName = "MaSach"
		dgvNhanTraSach.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		clTenSach.DataPropertyName = "TenSach"
		dgvNhanTraSach.Columns.Add(clTenSach)

		Dim clTenTheLoaiSach = New DataGridViewTextBoxColumn()
		clTenTheLoaiSach.Name = "TenTheLoai"
		clTenTheLoaiSach.HeaderText = "Thể Loại"
		clTenTheLoaiSach.DataPropertyName = "TenTheLoai"
		dgvNhanTraSach.Columns.Add(clTenTheLoaiSach)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TenTacGia"
		clTacGia.HeaderText = "Tác Giả"
		clTacGia.DataPropertyName = "TenTacGia"
		dgvNhanTraSach.Columns.Add(clTacGia)

		dgvNhanTraSach.Columns(3).Width = 170


	End Sub

	Private Sub frmNhanTraSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		phieuMuonSachBUS = New PhieuMuonSachBUS()
		phieuTraSachBUS = New PhieuTraSachBUS()
		chiTietPhieuMuonSachBUS = New ChiTietPhieuMuonSachBUS()
		sachBUS = New SachBUS()

		dtNgayTraSach.Enabled = False
	End Sub

	Private Sub txtMaPhieuMuonSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaPhieuMuonSach.KeyUp
		Try
			Dim maPhieuMuonSach = txtMaPhieuMuonSach.Text
			LoadChiTietPhieuMuonSach(maPhieuMuonSach)
			LoadPhieuMuonSach(maPhieuMuonSach)
		Catch ex As Exception

		End Try
	End Sub

	Private Sub LoadPhieuMuonSach(maPhieuMuonSach As String)
		Dim ngayMuonSach As Date
		Dim ngayTraSach As Date
		Dim result As Result

		result = chiTietPhieuMuonSachBUS.SelectAll(maPhieuMuonSach, ngayMuonSach, ngayTraSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		dtNgayTraSach.Value = ngayMuonSach

	End Sub

	Private Sub btnTraSach_Click(sender As Object, e As EventArgs) Handles btnTraSach.Click
		Dim result As Result
		Dim phieuTraSach As PhieuTraSachDTO
		phieuTraSach = New PhieuTraSachDTO()

		phieuTraSach.MaPhieuMuonSach = txtMaPhieuMuonSach.Text
		phieuTraSach.NgayTraSach = dtpNgayTraSach.Value

		result = phieuTraSachBUS.Insert(phieuTraSach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm Phiếu trả sách thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)

		Else
			MessageBox.Show("Thêm Phiếu trả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

		Dim sach = new SachDTO
		Dim numberOfRows = dgvNhanTraSach.Rows.Count - 1
		For i As Integer = 0 To numberOfRows
			sach.MaSach = dgvNhanTraSach.Rows(i).Cells("MaSach").Value.ToString()
			sach.TinhTrangSach = "Chưa được mượn"
			sachBUS.UpdateStatusBook(sach)
		Next

	End Sub
End Class