Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmQuanLyPhieuMuonSach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS
	Private chiTietPhieuMuonSachBUS As ChiTietPhieuMuonSachBUS
	Private phieuMuonSachBUS As PhieuMuonSachBUS
	Dim maSach


	Private Sub frmQuanLyPhieuMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		phieuMuonSachBUS = New PhieuMuonSachBUS()
		chiTietPhieuMuonSachBUS = New ChiTietPhieuMuonSachBUS()
		

	End Sub
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
		dgvPhieuMuonSach.Columns.Clear()
		dgvPhieuMuonSach.DataSource = Nothing
		dgvPhieuMuonSach.AutoGenerateColumns = False
		dgvPhieuMuonSach.AllowUserToAddRows = False
		dgvPhieuMuonSach.AutoResizeColumns()

		dgvPhieuMuonSach.DataSource = listSach

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		clMa.DataPropertyName = "MaSach"
		dgvPhieuMuonSach.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		clTenSach.DataPropertyName = "TenSach"
		dgvPhieuMuonSach.Columns.Add(clTenSach)

		Dim clTenTheLoaiSach = New DataGridViewTextBoxColumn()
		clTenTheLoaiSach.Name = "TenTheLoai"
		clTenTheLoaiSach.HeaderText = "Thể Loại"
		clTenTheLoaiSach.DataPropertyName = "TenTheLoai"
		dgvPhieuMuonSach.Columns.Add(clTenTheLoaiSach)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TenTacGia"
		clTacGia.HeaderText = "Tác Giả"
		clTacGia.DataPropertyName = "TenTacGia"
		dgvPhieuMuonSach.Columns.Add(clTacGia)

		dgvPhieuMuonSach.Columns(3).Width = 170


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

		dtpNgayMuonSach.Value = ngayMuonSach
		dtpNgayTraSach.Value = ngayTraSach

	End Sub

	Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvPhieuMuonSach.CurrentCellAddress.Y 'current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvPhieuMuonSach.RowCount) Then
			Try
				Dim chiTietPhieu As ChiTietPhieuMuonSachDTO
				chiTietPhieu = New ChiTietPhieuMuonSachDTO()
				'1. Mapping data from GUI control
				chiTietPhieu.MaSach = txtMaSach.Text
				Dim result As Result
				result = chiTietPhieuMuonSachBUS.Update(chiTietPhieu, txtMaPhieuMuonSach.Text, maSach)
				If (result.FlagResult = True) Then
					' Re-Load docGia list
					LoadPhieuMuonSach(txtMaPhieuMuonSach.Text)
					LoadChiTietPhieuMuonSach(txtMaPhieuMuonSach.Text)
					' Hightlight the row has been updated on table
					dgvPhieuMuonSach.Rows(currentRowIndex).Selected = True

					MessageBox.Show("Cập nhật chi tiết phiếu mượn sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Else
					MessageBox.Show("Cập nhật chi tiết phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					System.Console.WriteLine(result.SystemMessage)
				End If
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub dgvPhieuMuonSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPhieuMuonSach.SelectionChanged
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvPhieuMuonSach.CurrentCellAddress.Y 'current row selected
		'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

		' Write coordinates to console for debugging
		'Console.WriteLine(y.ToString + " " + x.ToString)

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvPhieuMuonSach.RowCount) Then
			Try
				Dim chiTietPhieu = CType(dgvPhieuMuonSach.Rows(currentRowIndex).DataBoundItem, SachReceive)
				txtMaSach.Text = chiTietPhieu.MaSach
				maSach = chiTietPhieu.MaSach
				txtTenSach.Text = chiTietPhieu.TenSach
				txtTacGia.Text = chiTietPhieu.TenTacGia
				txtTheLoaiSach.Text = chiTietPhieu.TenTheLoai
				
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try
		End If

	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvPhieuMuonSach.CurrentCellAddress.Y 'current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvPhieuMuonSach.RowCount) Then
			Select Case MsgBox("Bạn có thực sự muốn xóa sách có mã số: " + txtMaSach.Text, MsgBoxStyle.YesNo, "Information")

				Case MsgBoxResult.Yes
					Try
						'1. Delete from DB
						Dim result As Result
						result = chiTietPhieuMuonSachBUS.Delete(txtMaPhieuMuonSach.Text, maSach)
						If (result.FlagResult = True) Then

							' Re-Load LoaiHocSinh list
							LoadPhieuMuonSach(txtMaPhieuMuonSach.Text)
							LoadChiTietPhieuMuonSach(txtMaPhieuMuonSach.Text)

							' Hightlight the next row on table
							If (currentRowIndex >= dgvPhieuMuonSach.Rows.Count) Then
								currentRowIndex = currentRowIndex - 1
							End If
							If (currentRowIndex >= 0) Then
								dgvPhieuMuonSach.Rows(currentRowIndex).Selected = True
							End If

							MessageBox.Show("Xóa chi tiết phiếu mượn sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Else
							MessageBox.Show("Xóa chi tiết phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
							System.Console.WriteLine(result.SystemMessage)
						End If
					Catch ex As Exception
						Console.WriteLine(ex.StackTrace)
					End Try
				Case MsgBoxResult.No
					Return
			End Select

		End If

	End Sub

	Private Sub btnCapNhapPhieuMuonSach_Click(sender As Object, e As EventArgs) Handles btnCapNhapPhieuMuonSach.Click
		Try
			Dim phieuMuonSach As PhieuMuonSachDTO
			phieuMuonSach = New PhieuMuonSachDTO()
			'1. Mapping data from GUI control
			phieuMuonSach.NgayMuonSach = dtpNgayMuonSach.Value
			phieuMuonSach.NgayTraSach = dtpNgayTraSach.Value
			Dim result As Result
			result = phieuMuonSachBUS.Update(phieuMuonSach, txtMaPhieuMuonSach.Text)
			If (result.FlagResult = True) Then
				MessageBox.Show("Cập nhật phiếu mượn sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Cập nhật phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
			End If
		Catch ex As Exception
			Console.WriteLine(ex.StackTrace)
		End Try
	End Sub

	Private Sub btnXoaPhieuMuonSach_Click(sender As Object, e As EventArgs) Handles btnXoaPhieuMuonSach.Click
		Select Case MsgBox("Bạn có thực sự muốn xóa phiếu mượn sách có mã số: " + txtMaPhieuMuonSach.Text, MsgBoxStyle.YesNo, "Information")

			Case MsgBoxResult.Yes
				Try
					'1. Delete from DB
					Dim result As Result
					result = phieuMuonSachBUS.Delete(txtMaPhieuMuonSach.Text)
					If (result.FlagResult = True) Then
						MessageBox.Show("Xóa phiếu mượn thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Else
						MessageBox.Show("Xóa phiếu mượn sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
						System.Console.WriteLine(result.SystemMessage)
					End If
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
				End Try
			Case MsgBoxResult.No
				Return
		End Select
		dgvPhieuMuonSach.Rows.Clear()
		dgvPhieuMuonSach.Refresh()

	End Sub
End Class