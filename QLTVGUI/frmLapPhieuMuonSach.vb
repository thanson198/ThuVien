Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmLapPhieuMuonSach

	Private docGiaBUS As DocGiaBUS
	Private sachBUS As SachBUS
	Private phieuMuonSachBUS As PhieuMuonSachBUS
	Private chiTietPhieuMuonSachBUS AS ChiTietPhieuMuonSachBUS
	Private quyDinh As QuyDinhDTO
	Private quyDinhBUS As QuyDinhBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click  
		Dim phieuMuonSach = New PhieuMuonSachDTO()
		Dim chiTietPhieuMuonSach = new ChiTietPhieuMuonSachDTO()

		'1. Mapping data from GUI control
		phieuMuonSach.MaPhieuMuonSach = txtMaPhieuMuonSach.Text
		phieuMuonSach.NgayMuonSach = dtpNgayMuonSach.Value
		phieuMuonSach.MaDocGia = txtMaDocGia.Text
		phieuMuonSach.NgayTraSach = dtpNgayTraSach.Value

		chiTietPhieuMuonSach.MaPhieuMuonSach = txtMaPhieuMuonSach.Text

		' Kiểm tra ngày hét hạn
		If (phieuMuonSachBUS.IsVailDexpirationDate(dtpNgayHetHan.Value) = False) Then
			MessageBox.Show("Thẻ đã hết hạn", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		'Kiểm tra mã độc giả đã được nhập chưa
		If txtMaDocGia.Text = Nothing
			MessageBox.Show("Chưa nhập mã thẻ đọc giả", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		'Kiểm tra sach đã được thêm chưa
		If (dgvDanhSachMuon.Rows.Count - 1) < 0
			MessageBox.Show("Chưa thêm sách", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If
		
		'3. Insert to DB
		Dim result As Result
		result = phieuMuonSachBUS.InsertPhieuMuonSach(phieuMuonSach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Lập phiếu mượn sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			'set MSSH auto
			Dim nextMaPhieuMuonSach = "1"
			result = phieuMuonSachBUS.BuildMaPhieuMuonSach(nextMaPhieuMuonSach)
			If (result.FlagResult = False) Then
				MessageBox.Show("Lấy danh tự động mã phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
				Me.Close()
				Return
			End If
			txtMaPhieuMuonSach.Text = nextMaPhieuMuonSach

		Else
			MessageBox.Show("Lập phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If


		'Insert chi tiết phiếu mượn sách
		Dim sach = new SachDTO
		Dim nextMaChiTietPhieuMuonSach = "1"
		Dim numberOfRows = dgvDanhSachMuon.Rows.Count - 1
		For i As Integer = 0 To numberOfRows
			chiTietPhieuMuonSach.MaSach = dgvDanhSachMuon.Rows(i).Cells("MaSach").Value.ToString()

			sach.MaSach = chiTietPhieuMuonSach.MaSach
			sach.TinhTrangSach = "Đã cho mượn"
			sachBUS.UpdateStatusBook(sach)

			chiTietPhieuMuonSachBUS.BuildMaChiTietPhieuMuonSach(nextMaChiTietPhieuMuonSach)
			chiTietPhieuMuonSach.MaChiTietPhieuMuonSach = nextMaChiTietPhieuMuonSach

			chiTietPhieuMuonSachBUS.InsertChiTietPhieuMuonSach(chiTietPhieuMuonSach)
		Next

		dgvDanhSachMuon.Rows.Clear()
		dgvDanhSachMuon.Refresh()

	End Sub

	Private Sub frmLapPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		docGiaBUS = New DocGiaBUS()
		sachBUS = New SachBUS()
		phieuMuonSachBUS = New PhieuMuonSachBUS()
		chiTietPhieuMuonSachBUS = New ChiTietPhieuMuonSachBUS()
		quyDinhBUS = New QuyDinhBUS()

		Dim result As Result
		Dim nextMaPhieuMuonSach = "1"
		result = phieuMuonSachBUS.BuildMaPhieuMuonSach(nextMaPhieuMuonSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If

		quyDinh = New QuyDinhDTO
		result = quyDinhBUS.selectALL(quyDinh)

		txtMaPhieuMuonSach.Text = nextMaPhieuMuonSach

		dtpNgayHetHan.Enabled = False

		dtpNgayMuonSach.Enabled = False
		dtpNgayMuonSach.Value = DateTime.Today

		dtpNgayTraSach.Enabled = False
		dtpNgayTraSach.Value = dtpNgayMuonSach.Value.AddDays(quyDinh.SoNgayMuonToiDa)

		dgvDanhSachMuon.Columns.Clear()
		dgvDanhSachMuon.DataSource = Nothing

		dgvDanhSachMuon.AutoGenerateColumns = False
		dgvDanhSachMuon.AllowUserToAddRows = False

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		dgvDanhSachMuon.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		dgvDanhSachMuon.Columns.Add(clTenSach)

		Dim clTheLoai = New DataGridViewTextBoxColumn()
		clTheLoai.Name = "TheLoai"
		clTheLoai.HeaderText = "Thể Loại"
		dgvDanhSachMuon.Columns.Add(clTheLoai)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TacGia"
		clTacGia.HeaderText = "Tác Giả"
		dgvDanhSachMuon.Columns.Add(clTacGia)

		dgvDanhSachMuon.Columns(3).Width = 170
		
	End Sub

	Private Sub LoadInfoReader(maDocGia As String)
		Dim hoTen = New String(Nothing)
		Dim ngayHetHan = new Date()
		Dim result As Result

		result = docGiaBUS.SelectByType(maDocGia, hoTen, ngayHetHan)

		txtHoTenDocGia.Text = hoTen
		dtpNgayHetHan.Value = ngayHetHan
	End Sub

	Private Sub LoadInfoBook(maSach As String)
		Dim tenSach = New String(Nothing) 
		Dim tacGia = New String(Nothing)
		Dim theLoai = new String(Nothing)
		Dim tinhTrangSach = new String(Nothing)
		Dim result As Result

		result = sachBUS.SelectByType(maSach, tenSach, theLoai, tacGia, tinhTrangSach)

		txtTenSach.Text = tenSach
		txtTacGia.Text = tacGia
		txtTheLoai.Text = theLoai
		txtTinhTrangSach.Text = tinhTrangSach

	End Sub

	Private Sub txtMaDocGia_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaDocGia.KeyUp, txtTenSach.KeyUp, txtTacGia.KeyUp, txtTheLoai.KeyUp, txtTinhTrangSach.KeyUp 
		Try

			Dim maDocGia = txtMaDocGia.Text
			LoadInfoReader(maDocGia)

		Catch ex As Exception
		End Try
	End Sub

	Private Sub txtMaSach_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMaSach.KeyUp
		Try

			Dim maSach = txtMaSach.Text
			LoadInfoBook(maSach)

		Catch ex As Exception
		End Try
	End Sub

	Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
		Dim rnum As Integer = dgvDanhSachMuon.Rows.Add()

		dgvDanhSachMuon.Rows.Item(rnum).Cells("MaSach").Value = txtMaSach.Text
		dgvDanhSachMuon.Rows.Item(rnum).Cells("TenSach").Value = txtTenSach.Text
		dgvDanhSachMuon.Rows.Item(rnum).Cells("TheLoai").Value = txtTheLoai.Text
		dgvDanhSachMuon.Rows.Item(rnum).Cells("TacGia").Value = txtTacGia.Text

		Dim numberOfRows = dgvDanhSachMuon.Rows.Count - 1 'subtract the last row which is an editing row
		Dim i As Integer = 0

		While i < numberOfRows 

			For j As Integer = (numberOfRows) To (i + 1) Step - 1
				If dgvDanhSachMuon.Rows(i).Cells("MaSach").Value.ToString() = dgvDanhSachMuon.Rows(j).Cells("MaSach").Value.ToString() Then
					dgvDanhSachMuon.Rows.Remove(dgvDanhSachMuon.Rows(j))
					MessageBox.Show("Sách đã được thêm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					numberOfRows -= 1
				End If
			Next
			i += 1
		End While

		If dgvDanhSachMuon.Rows(numberOfRows).Cells("MaSach").Value.ToString() = nothing
			dgvDanhSachMuon.Rows.Remove(dgvDanhSachMuon.Rows(numberOfRows))
		End If

		If (phieuMuonSachBUS.IsVailNumberOfBooks(numberOfRows, quyDinh) = False)
			dgvDanhSachMuon.Rows.Remove(dgvDanhSachMuon.Rows(numberOfRows))
			MessageBox.Show("Quá số lượng sách cho mượn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

		If (phieuMuonSachBUS.IsVailAvailable(txtTinhTrangSach.Text) = False)
			dgvDanhSachMuon.Rows.Remove(dgvDanhSachMuon.Rows(numberOfRows))
			MessageBox.Show("Sách đã cho mượn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If

	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		For Each row As DataGridViewRow In dgvDanhSachMuon.SelectedRows
			dgvDanhSachMuon.Rows.RemoveAt(row.Index)
		Next
	End Sub
End Class