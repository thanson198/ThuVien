Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThemTheLoaiSach
	Private theLoaiSachBUS As TheLoaiSachBUS

	Private Sub frmThemTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		theLoaiSachBUS = New TheLoaiSachBUS()

		' Get Next ID
		Dim nextID As Integer
		Dim result As Result
		result = theLoaiSachBUS.getNextID(nextID)
		If (result.FlagResult = True) Then
			txtMaTheLoaiSach.Text = nextID.ToString()
		Else
			MessageBox.Show("Lấy ID kế tiếp của Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim theLoaiSach As TheLoaiSachDTO
		theLoaiSach = New TheLoaiSachDTO()

		'1. Mapping data from GUI control
		theLoaiSach.MaTheLoaiSach = Convert.ToInt32(txtMaTheLoaiSach.Text)
		theLoaiSach.TenTheLoaiSach = txtTenTheLoaiSach.Text


		'2. Business .....
		If (theLoaiSachBUS.isValidName(theLoaiSach) = False) Then
			MessageBox.Show("Tên Loại điểm không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenTheLoaiSach.Focus()
			Return
		End If
		'3. Insert to DB
		Dim result As Result
		result = theLoaiSachBUS.insert(theLoaiSach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm Loại điểm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenTheLoaiSach.Text = String.Empty

			' Get Next ID
			Dim nextID As Integer
			result = theLoaiSachBUS.getNextID(nextID)
			If (result.FlagResult = True) Then
				txtMaTheLoaiSach.Text = nextID.ToString()
			Else
				MessageBox.Show("Lấy ID kế tiếp của Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
			End If

		Else
			MessageBox.Show("Thêm Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If

	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
		Dim theLoaiSach As TheLoaiSachDTO
		theLoaiSach = New TheLoaiSachDTO()

		'1. Mapping data from GUI control
		theLoaiSach.MaTheLoaiSach = Convert.ToInt32(txtMaTheLoaiSach.Text)
		theLoaiSach.TenTheLoaiSach = txtTenTheLoaiSach.Text

		'2. Business .....
		If (theLoaiSachBUS.isValidName(theLoaiSach) = False) Then
			MessageBox.Show("Tên Loại điểm không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenTheLoaiSach.Focus()
			Return
		End If

		'3. Insert to DB
		Dim result As Result
		result = theLoaiSachBUS.insert(theLoaiSach)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm Loại điểm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Thêm Thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub
End Class