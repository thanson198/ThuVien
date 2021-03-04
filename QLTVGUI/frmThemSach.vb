Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThemSach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS
	Private quyDinhBUS As QuyDinhBUS
	Private quyDinh As QuyDinhDTO
	Private tacGiaBUS As TacGiaBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim sach As SachDTO
		sach = New SachDTO()

		' 1.Mapping data from GUI control
		sach.MaSach = txtMaSach.Text
		sach.TenSach = txtTenSach.Text
		sach.MaTheLoaiSach = Convert.ToInt32(cbMaTheLoaiSach.SelectedValue)
		sach.MaTacGia = Convert.ToInt32(cbTacGia.SelectedValue)
		sach.NamXuatBan = cbNamXuatBan.SelectedItem
		sach.NhaXuatBan = txtNhaXuatBan.Text
		sach.NgayNhap = dtNgayNhap.Value
		sach.TriGia = txtTriGia.Text
		sach.TinhTrangSach = txtTinhTrangSach.Text

		'2. Business .....
		If (sachBUS.IsVaildName(sach) = False) Then
			MessageBox.Show("tên sách không đúng", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenSach.Focus()
			Return
		End If

		If (sachBUS.IsIntervaleYear(sach, quyDinh) = False) Then
			MessageBox.Show($"Chỉ nhận các sách xuất bản trong vòng {quyDinh.KhoangCachXuatBan} năm", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			cbNamXuatBan.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = sachBUS.Insert(sach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm sách thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)

			'Set MSdocgia auto
			Dim nextMaSoSach = "1"
			result = sachBUS.BuildMaSoSach(nextMaSoSach)

			If (result.FlagResult = False) Then
				MessageBox.Show("Lấy danh sách tự động mã sách không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Me.Close()
				Return
			End If

			txtMaSach.Text = nextMaSoSach
			txtTenSach.Text = String.Empty
			txtNhaXuatBan.Text = String.Empty
			txtTriGia.Text = String.Empty
		Else
			MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If


	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click

		Dim sach As SachDTO
		sach = New SachDTO()

		' 1.Mapping data from GUI control
		sach.MaSach = txtMaSach.Text
		sach.TenSach = txtTenSach.Text
		' sach.MaLoaisach = Convert.ToInt32(cbLoaisach.SelectedValue)
		sach.NhaXuatBan = txtNhaXuatBan.Text
		sach.TriGia = txtTriGia.Text
		sach.NgayNhap = dtNgayNhap.Value

		'2. Business .....
		If (sachBUS.IsVaildName(sach) = False) Then
			MessageBox.Show("Tên Sách không đúng", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenSach.Focus()
			Return
		End If

		If (sachBUS.IsIntervaleYear(sach, quyDinh) = False) Then
			MessageBox.Show($"Chỉ nhận các sách xuất bản trong vòng {quyDinh.KhoangCachXuatBan} năm", "Important Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			cbNamXuatBan.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = sachBUS.Insert(sach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm sách thành công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Thêm sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub frmThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sachBUS = New SachBUS()
		theLoaiSachBUS = New TheLoaiSachBUS()
		tacGiaBUS = New TacGiaBUS()
		quyDinhBUS = New QuyDinhBUS()

		' Load QuyDinhDTO 
		quyDinh = New QuyDinhDTO
		Dim results As Result
		results = quyDinhBUS.selectALL(quyDinh)

		If (results.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách quy định không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(results.SystemMessage)
			Me.Close()
			Return
		End If

		Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
		Dim result As Result

		result = theLoaiSachBUS.selectAll(listTheLoaiSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If
		cbMaTheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
		cbMaTheLoaiSach.DisplayMember = "TenTheLoaiSach"
		cbMaTheLoaiSach.ValueMember = "MaTheLoaiSach"

		Dim listTacGia = New List(Of TacGiaDTO)
		Dim resultTacGia As Result

		resultTacGia = tacGiaBUS.SelectAll(listTacGia)
		If (resultTacGia.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách Tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If
		cbTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
		cbTacGia.DisplayMember = "TenTacGia"
		cbTacGia.ValueMember = "MaTacGia"

		'set MSSH auto
		Dim nextMaSoSach = "1"
		result = sachBUS.BuildMaSoSach(nextMaSoSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh tự động mã sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
			Return
		End If
		txtMaSach.Text = nextMaSoSach

		For year As Integer = 1990 To DateTime.Today.Year
			cbNamXuatBan.Items.Add(year)
		Next

	End Sub
End Class