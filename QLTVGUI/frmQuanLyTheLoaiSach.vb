﻿Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmQuanLyTheLoaiSach
	Private theloaiSachBUS As TheLoaiSachBUS
	Private Sub frmQuanLyTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		theloaiSachBUS = New TheLoaiSachBUS()
		'Load the loai sach list
		LoadListTheLoaiSach()
	End Sub

	Private Sub LoadListTheLoaiSach()
		'Load the loai sach list
		Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
		Dim result as Result
		result = theloaiSachBUS.selectAll(listTheLoaiSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách thể loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If

		dgvDanhSachTheLoaiSach.Columns.Clear()
		dgvDanhSachTheLoaiSach.DataSource = Nothing

		dgvDanhSachTheLoaiSach.AutoGenerateColumns = False
		dgvDanhSachTheLoaiSach.AllowUserToAddRows = False
		dgvDanhSachTheLoaiSach.DataSource = listTheLoaiSach

		Dim clMaLoai = New DataGridViewTextBoxColumn()
		clMaLoai.Name = "MaTheLoaiSach"
		clMaLoai.HeaderText = "Mã Loại"
		clMaLoai.DataPropertyName = "MaTheLoaiSach"
		dgvDanhSachTheLoaiSach.Columns.Add(clMaLoai)

		Dim clTenTheLoaiSach = New DataGridViewTextBoxColumn()
		clTenTheLoaiSach.Name = "TenTheLoaiSach"
		clTenTheLoaiSach.HeaderText = "Tên Loại"
		clTenTheLoaiSach.DataPropertyName = "TenTheLoaiSach"
		dgvDanhSachTheLoaiSach.Columns.Add(clTenTheLoaiSach)

	End Sub

	Private Sub dgvDanhSachTheLoaiSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachTheLoaiSach.SelectionChanged
		' Get the current cell location.
		Dim currentRowIndex As Integer = dgvDanhSachTheLoaiSach.CurrentCellAddress.Y 'current row selected
		'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

		' Write coordinates to console for debugging
		'Console.WriteLine(y.ToString + " " + x.ToString)

		'Verify that indexing OK
		If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTheLoaiSach.RowCount) Then
			Try
				Dim theLoaiSach = CType(dgvDanhSachTheLoaiSach.Rows(currentRowIndex).DataBoundItem, TheLoaiSachDTO)
				txtMaLoai.Text = theLoaiSach.MaTheLoaiSach
				txtTenLoai.Text = theLoaiSach.TenTheLoaiSach
			Catch ex As Exception
				Console.WriteLine(ex.StackTrace)
			End Try

		End If
	End Sub

	Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
		' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTheLoaiSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTheLoaiSach.RowCount) Then
            SELECT Case MsgBox("Bạn có thực sự muốn xóa thể loại sách có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = theloaiSachBUS.Delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            LoadListTheLoaiSach()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachTheLoaiSach.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachTheLoaiSach.Rows(currentRowIndex).SELECTed = True
                                Try
                                    Dim theLoaiSach = CType(dgvDanhSachTheLoaiSach.Rows(currentRowIndex).DataBoundItem, TheLoaiSachDTO)
                                    txtMaLoai.Text = theLoaiSach.MaTheLoaiSach
                                    txtTenLoai.Text = theLoaiSach.TenTheLoaiSach
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa thể loại sách thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

	Private Sub btnCapNhap_Click(sender As Object, e As EventArgs) Handles btnCapNhap.Click
		  ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachTheLoaiSach.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachTheLoaiSach.RowCount) Then
            Try
                Dim theLoaiSach As TheLoaiSachDTO
                theLoaiSach = New TheLoaiSachDTO()

                '1. Mapping data from GUI control
                theLoaiSach.MaTheLoaiSach = Convert.ToInt32(txtMaLoai.Text)
                theLoaiSach.TenTheLoaiSach = txtTenLoai.Text

                '2. Business .....
                If (theloaiSachBUS.isValidName(theLoaiSach) = False) Then
                    MessageBox.Show("Tên thể loại sách không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB
                Dim result As Result
                result = theLoaiSachBUS.Update(theLoaiSach)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
					LoadListTheLoaiSach()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachTheLoaiSach.Rows(currentRowIndex).SELECTed = True
                    Try
                        theLoaiSach = CType(dgvDanhSachTheLoaiSach.Rows(currentRowIndex).DataBoundItem, TheLoaiSachDTO)
                        txtMaLoai.Text = theLoaiSach.MaTheLoaiSach
                        txtTenLoai.Text = theLoaiSach.MaTheLoaiSach
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
End Class