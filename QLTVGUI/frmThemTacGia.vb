Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmThemTacGia
	Private tacGiaBUS As TacGiaBUS
	Private Sub frmTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		tacGiaBUS = New TacGiaBUS()

		' Get Next ID
		Dim nextID As Integer
		Dim result As Result
		result = tacGiaBUS.GetNextID(nextID)
		If (result.FlagResult = True) Then
			txtMaTacGia.Text = nextID.ToString()
		Else
			MessageBox.Show("Lấy ID kế tiếp của Tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
		Dim tacGia As TacGiaDTO
		tacGia = New TacGiaDTO()

		'1. Mapping data from GUI control
		tacGia.MaTacGia = Convert.ToInt32(txtMaTacGia.Text)
		tacGia.TenTacGia = txtTenTacGia.Text

		'2. Business .....
		If (tacGiaBUS.IsValidName(tacGia) = False) Then
			MessageBox.Show("Tên Tác giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenTacGia.Focus()
			Return
		End If

		'3. Insert to DB
		Dim result As Result
		result = tacGiaBUS.Insert(tacGia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm Tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			txtTenTacGia.Text = String.Empty

			' Get Next ID
			Dim nextID As Integer
			result = tacGiaBUS.GetNextID(nextID)
			If (result.FlagResult = True) Then
				txtMaTacGia.Text = nextID.ToString()
			Else
				MessageBox.Show("Lấy ID kế tiếp của Tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
			End If

		Else
			MessageBox.Show("Thêm Tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapVaDong.Click
		Dim tacGia As TacGiaDTO
		tacGia = New TacGiaDTO()

		'1. Mapping data from GUI control
		tacGia.MaTacGia = Convert.ToInt32(txtMaTacGia.Text)
		tacGia.TenTacGia = txtTenTacGia.Text

		'2. Business .....
		If (tacGiaBUS.IsValidName(tacGia) = False) Then
			MessageBox.Show("Tên Tác giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtTenTacGia.Focus()
			Return
		End If


		'3. Insert to DB
		Dim result As Result
		result = tacGiaBUS.Insert(tacGia)
		If (result.FlagResult = True) Then
			MessageBox.Show("Thêm Tác giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MessageBox.Show("Thêm Tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
		End If
	End Sub
End Class