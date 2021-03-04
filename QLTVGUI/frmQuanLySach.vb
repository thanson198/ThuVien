Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmQuanLySach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS
	Private tacGiaBUS As TacGiaBUS

	Private Sub cbTheLoaiSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTheLoaiSach.SelectedIndexChanged
		Try
			Dim maLoai = Convert.ToInt32(cbTheLoaiSach.SelectedValue)
			LoadListSach(maLoai)
		Catch ex As Exception
		End Try
	End Sub

	Private Sub LoadListSach(maLoai As Integer)
		Dim listSach = New List(Of SachReceive)
		Dim result As Result
		result = sachBUS.SelectAllByType(maLoai, listSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách sách theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		'dgvListDocGia.SuspendLayout()
		dgvListSach.Columns.Clear()
		dgvListSach.DataSource = Nothing

		dgvListSach.AutoGenerateColumns = False
		dgvListSach.AllowUserToAddRows = False
		dgvListSach.DataSource = listSach

		Dim clMa = New DataGridViewTextBoxColumn()
		clMa.Name = "MaSach"
		clMa.HeaderText = "Mã Sách"
		clMa.DataPropertyName = "MaSach"
		dgvListSach.Columns.Add(clMa)

		Dim clTenSach = New DataGridViewTextBoxColumn()
		clTenSach.Name = "TenSach"
		clTenSach.HeaderText = "Tên Sách"
		clTenSach.DataPropertyName = "TenSach"
		dgvListSach.Columns.Add(clTenSach)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TenTacGia"
		clTacGia.HeaderText = "Tên Tác Giả"
		clTacGia.DataPropertyName = "TenTacGia"
		dgvListSach.Columns.Add(clTacGia)

		Dim clNamXuatBan = New DataGridViewTextBoxColumn()
		clNamXuatBan.Name = "NamXuatBan"
		clNamXuatBan.HeaderText = "Năm Xuất Bản"
		clNamXuatBan.DataPropertyName = "NamXuatBan"
		dgvListSach.Columns.Add(clNamXuatBan)

		Dim clNhaXuatBan = New DataGridViewTextBoxColumn()
		clNhaXuatBan.Name = "NhaXuatBan"
		clNhaXuatBan.HeaderText = "Nhà Xuất Bản"
		clNhaXuatBan.DataPropertyName = "NhaXuatBan"
		dgvListSach.Columns.Add(clNhaXuatBan)

		Dim clNgayNhap = New DataGridViewTextBoxColumn()
		clNgayNhap.Name = "NgayNhap"
		clNgayNhap.HeaderText = "Ngày Nhập"
		clNgayNhap.DataPropertyName = "NgayNhap"
		dgvListSach.Columns.Add(clNgayNhap)

		Dim clTriGia = New DataGridViewTextBoxColumn()
		clTriGia.Name = "TriGia"
		clTriGia.HeaderText = "Trị Giá"
		clTriGia.DataPropertyName = "TriGia"
		dgvListSach.Columns.Add(clTriGia)

		Dim clTinhTrangSach = New DataGridViewTextBoxColumn()
		clTinhTrangSach.Name = "TinhTrangSach"
		clTinhTrangSach.HeaderText = "Tình Trạng Sách"
		clTinhTrangSach.DataPropertyName = "TinhTrangSach"
		dgvListSach.Columns.Add(clTinhTrangSach)

	End Sub

	Private Sub frmQuanLySach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sachBUS = New SachBUS()
		theLoaiSachBUS = New TheLoaiSachBUS()
		tacGiaBUS = New TacGiaBUS()

		'Load LoaiDocGia list
		Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
		Dim result As Result
		result = theLoaiSachBUS.SelectAll(listTheLoaiSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		cbTheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
		cbTheLoaiSach.DisplayMember = "TenTheLoaiSach"
		cbTheLoaiSach.ValueMember = "MaTheLoaiSach"

		cbTheLoaiSachCapNhap.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
		cbTheLoaiSachCapNhap.DisplayMember = "TenTheLoaiSach"
		cbTheLoaiSachCapNhap.ValueMember = "MaTheLoaiSach"

		tacGiaBUS = New TacGiaBUS()

		'Load TacGia list
		Dim listTacGia = New List(Of TacGiaDTO)
		result = tacGiaBUS.SelectAll(listTacGia)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách tác giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		cbTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
		cbTacGia.DisplayMember = "TenTacGia"
		cbTacGia.ValueMember = "MaTacGia"

		For year As Integer = 1990 To DateTime.Today.Year
			cbNamXuatBan.Items.Add(year)
		Next

	End Sub

	Private Sub dgvListSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListSach.SelectionChanged
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected
		'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

		' Write coordinates to console for debugging
		'Console.WriteLine(y.ToString + " " + x.ToString)

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
			Try
				Dim sach = CType(dgvListSach.Rows(currentRowIndex).DataBoundItem, SachReceive)
				txtMaSach.Text = sach.MaSach
				txtTenSach.Text = sach.TenSach
				cbTheLoaiSachCapNhap.SelectedIndex = cbTheLoaiSach.SelectedIndex
				cbTacGia.Text = sach.TenTacGia
				cbNamXuatBan.SelectedItem = sach.NamXuatBan
				txtTinhTrangSach.Text = sach.TinhTrangSach
				txtNhaXuatBan.Text = sach.NhaXuatBan
				dtNgayNhap.Value = sach.NgayNhap
				txtTriGia.Text = sach.TriGia
				
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try
		End If

	End Sub

	Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y ' current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
			Try
				Dim sach As SachDTO
				sach = New SachDTO()

				'1. Mapping data from GUI control
				sach.MaSach = txtMaSach.Text
				sach.TenSach = txtTenSach.Text
				sach.MaTheLoaiSach = Convert.ToInt32(cbTheLoaiSachCapNhap.SelectedValue)
				sach.MaTacGia = cbTacGia.SelectedIndex
				sach.NamXuatBan = cbNamXuatBan.SelectedItem
				sach.NhaXuatBan = txtNhaXuatBan.Text
				sach.TinhTrangSach = txtTinhTrangSach.Text
				sach.NgayNhap = dtNgayNhap.Value
				sach.TriGia = txtTriGia.Text

				'2. Business .....
				If (sachBUS.IsVaildName(sach) = False) Then
					MessageBox.Show("tên sách không đúng")
					txtTenSach.Focus()
					Return
				End If
				'3. Insert to DB
				Dim result As Result
				result = sachBUS.Update(sach)
				If (result.FlagResult = True) Then
					' Re-Load docGia list
					LoadListSach(cbTheLoaiSach.SelectedValue)
					' Hightlight the row has been updated on table
					dgvListSach.Rows(currentRowIndex).Selected = True

					MessageBox.Show("Cập nhật Sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Else
					MessageBox.Show("Cập nhật Sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					System.Console.WriteLine(result.SystemMessage)
				End If
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvListSach.CurrentCellAddress.Y 'current row selected

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvListSach.RowCount) Then
			Select Case MsgBox("Bạn có thực sự muốn xóa sách có mã số: " + txtMaSach.Text, MsgBoxStyle.YesNo, "Information")

				Case MsgBoxResult.Yes
					Try
						'1. Delete from DB
						Dim result As Result
						result = sachBUS.Delete(txtMaSach.Text)
						If (result.FlagResult = True) Then

							' Re-Load LoaiHocSinh list
							LoadListSach(cbTheLoaiSach.SelectedValue)

							' Hightlight the next row on table
							If (currentRowIndex >= dgvListSach.Rows.Count) Then
								currentRowIndex = currentRowIndex - 1
							End If
							If (currentRowIndex >= 0) Then
								dgvListSach.Rows(currentRowIndex).Selected = True
							End If

							MessageBox.Show("Xóa sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
						Else
							MessageBox.Show("Xóa sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class