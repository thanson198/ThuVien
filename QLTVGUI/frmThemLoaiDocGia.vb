Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThemLoaiDocGia
	Private docGiaBUS As LoaidocGiaBUS

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim loaiDocGia As LoaiDocGiaDTO
		loaiDocGia = New LoaiDocGiaDTO()

		'1. Mapping data from GUI control
		loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoaiDocGia.Text)
		loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGiaDocGia.Text

		'2. Business .....
		If (docGiaBUS.IsVaildName(loaiDocGia) = False) Then
			MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenLoaiDocGiaDocGia.Focus()

			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = docGiaBUS.Insert(loaiDocGia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenLoaiDocGiaDocGia.Text = String.Empty

			' Get Next ID
			Dim nextID As Integer
			result = docGiaBUS.GetNextID(nextID)
			If (result.FlagResult = True) Then
				txtMaLoaiDocGia.Text = nextID.ToString()
			Else
				MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
			End If

		Else
			MessageBox.Show("Thêm loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub frmThemLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		docGiaBUS = New LoaidocGiaBUS()

		' Get Next ID
		Dim nextID As Integer
		Dim result As Result
		result = docGiaBUS.GetNextID(nextID)
		If (result.FlagResult = True) Then
			txtMaLoaiDocGia.Text = nextID.ToString()
		Else
			MessageBox.Show("Lấy ID kế tiếp của Loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
		Dim loaiDocGia As LoaiDocGiaDTO
		loaiDocGia = New LoaiDocGiaDTO()

		'1. Mapping data from GUI control
		loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoaiDocGia.Text)
		loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGiaDocGia.Text

		'2. Business .....
		If (docGiaBUS.IsVaildName(loaiDocGia) = False) Then
			MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenLoaiDocGiaDocGia.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = docGiaBUS.Insert(loaiDocGia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenLoaiDocGiaDocGia.Text = String.Empty
			Me.Close()
		Else
			MessageBox.Show("Thêm loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

End Class