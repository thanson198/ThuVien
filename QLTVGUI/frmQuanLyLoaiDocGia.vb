Imports QLTVBUS
Imports Utility
Imports QLTVDTO

Public Class frmQuanLyLoaiDocGia
	Private loaiDocGiaBUS As LoaiDocGiaBUS

	Private Sub frmQuanLyLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		loaiDocGiaBUS = New LoaiDocGiaBUS()
		'Load LoaiDocGiaDTO list
		LoadListLoaiDocGia()
	End Sub

	Private Sub LoadListLoaiDocGia()
		' Load LoaiHocSinh list
		Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
		Dim result As Result
		result = loaiDocGiaBUS.selectAll(listLoaiDocGia)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		dgvDanhSachLoaiDocGia.Columns.Clear()
		dgvDanhSachLoaiDocGia.DataSource = Nothing

		dgvDanhSachLoaiDocGia.AutoGenerateColumns = False
		dgvDanhSachLoaiDocGia.AllowUserToAddRows = False
		dgvDanhSachLoaiDocGia.DataSource = listLoaiDocGia

		Dim clMaLoai = New DataGridViewTextBoxColumn()
		clMaLoai.Name = "MaLoaiDocGia"
		clMaLoai.HeaderText = "Mã Loại"
		clMaLoai.DataPropertyName = "MaLoaiDocGia"
		dgvDanhSachLoaiDocGia.Columns.Add(clMaLoai)

		Dim clTenLoaiDocGia = New DataGridViewTextBoxColumn()
		clTenLoaiDocGia.Name = "TenLoaiDocGia"
		clTenLoaiDocGia.HeaderText = "Tên Loại"
		clTenLoaiDocGia.DataPropertyName = "TenLoaiDocGia"
		dgvDanhSachLoaiDocGia.Columns.Add(clTenLoaiDocGia)
	End Sub

	Private Sub btnCapNhap_Click(sender As Object, e As EventArgs) Handles btnCapNhap.Click
		  ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDocGia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDocGia.RowCount) Then
            Try
                Dim loaiDocGia As LoaiDocGiaDTO
                loaiDocGia = New LoaiDocGiaDTO()

                '1. Mapping data from GUI control
                loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoai.Text)
                loaiDocGia.TenLoaiDocGia = txtTenLoai.Text

                '2. Business .....
                If (loaiDocGiaBUS.IsVaildName(loaiDocGia) = False) Then
                    MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = loaiDocGiaBUS.Update(loaiDocGia)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
					LoadListLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachLoaiDocGia.Rows(currentRowIndex).SELECTed = True
                    Try
                        loaiDocGia = CType(dgvDanhSachLoaiDocGia.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                        txtMaLoai.Text = loaiDocGia.MaLoaiDocGia
                        txtTenLoai.Text = loaiDocGia.TenLoaiDocGia
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
	End Sub

	Private Sub dgvDanhSachLoaiDocGia_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachLoaiDocGia.SelectionChanged
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvDanhSachLoaiDocGia.CurrentCellAddress.Y 'current row selected
		'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

		' Write coordinates to console for debugging
		'Console.WriteLine(y.ToString + " " + x.ToString)

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDocGia.RowCount) Then
			Try
				Dim loaiDocGia = CType(dgvDanhSachLoaiDocGia.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
				txtMaLoai.Text = loaiDocGia.MaLoaiDocGia
				txtTenLoai.Text = loaiDocGia.TenLoaiDocGia
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try

		End If
	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDocGia.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDocGia.RowCount) Then
            SELECT Case MsgBox("Bạn có thực sự muốn xóa loại độc giả có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = loaiDocGiaBUS.Delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListLoaiDocGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachLoaiDocGia.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachLoaiDocGia.Rows(currentRowIndex).SELECTed = True
                                Try
                                    Dim loaiDocGia = CType(dgvDanhSachLoaiDocGia.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                                    txtMaLoai.Text = loaiDocGia.MaLoaiDocGia
                                    txtTenLoai.Text = loaiDocGia.TenLoaiDocGia
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End SELECT

        End If

    End Sub
End Class
