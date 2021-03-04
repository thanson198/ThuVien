Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmTraCuuSach
	Private sachBUS As SachBUS
	Private theLoaiSachBUS As TheLoaiSachBUS
	Private tacGiaBUS As TacGiaBUS

	Private Sub LoadMaxinumAndMininum()
		nudMinTriGia.Minimum = 0
		nudMinTriGia.Maximum = Decimal.MaxValue

		nudMaxTriGia.Minimum = 0
		nudMaxTriGia.Maximum = Decimal.MaxValue

		nudMinNamXuatBan.Minimum = 0
		nudMinNamXuatBan.Maximum = Decimal.MaxValue

		nudMaxNamXuatBan.Minimum = 0
		nudMaxNamXuatBan.Maximum = Decimal.MaxValue
	End Sub

	Private Sub LoadListSach(maSach As String,
	                         maLoai As Integer,
							 tenSach As String,
							 maTacGia As Integer,
							 nhaXuatBan As String,
	                         tinhTrangSach As String,
							 minTriGia As Integer,
							 maxTriGia As Integer,
	                         minNamXuatBan As Integer,
	                         maxNamXuatBan As Integer, 
	                         minNgayNhap As String,
	                         maxNgayNhap As String)
		Dim listSach = New List(Of SachReceive)
		Dim result As Result
		result = sachBUS.SelectAllCondition(maSach ,maLoai, tenSach, maTacGia, nhaXuatBan, tinhTrangSach, minTriGia, maxTriGia, minNamXuatBan, maxNamXuatBan, minNgayNhap, maxNgayNhap, listSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

		Dim clTheLoai = New DataGridViewTextBoxColumn()
		clTheLoai.Name = "TenTheLoai"
		clTheLoai.HeaderText = "Thể Loại"
		clTheLoai.DataPropertyName = "TenTheLoai"
		dgvListSach.Columns.Add(clTheLoai)

		Dim clTacGia = New DataGridViewTextBoxColumn()
		clTacGia.Name = "TenTacGia"
		clTacGia.HeaderText = "Tác Giả"
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

	Private Sub frmTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		sachBUS = New SachBUS()
		theLoaiSachBUS = New TheLoaiSachBUS()
		tacGiaBUS = New TacGiaBUS()

		'Load LoaiDocGia list
		Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
		Dim result As Result
		result = theLoaiSachBUS.selectAll(listTheLoaiSach)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy danh sách thể loại sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Return
		End If


		cbTheLoaiSach.DataSource = New BindingSource(listTheLoaiSach, String.Empty)
		cbTheLoaiSach.DisplayMember = "TenTheLoaiSach"
		cbTheLoaiSach.ValueMember = "MaTheLoaiSach"

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

		dtpMinNgayNhap.Value = DateTimePicker.MinimumDateTime
		dtpMaxNgayNhap.Value = Date.Today

		LoadMaxinumAndMininum()

	End Sub

	Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
		Try
			Dim maSach = txtMaSach.Text
			Dim maLoai = Convert.ToInt32(cbTheLoaiSach.SelectedValue)
			Dim tenSach = txtTenSach.Text
			Dim maTacGia = Convert.ToInt32(cbTacGia.SelectedValue)
			Dim nhaXuatBan = txtNhaXuatBan.Text
			Dim tinhTrangSach = txtTinhTrangSach.Text
			Dim minNgayNhap = dtpMinNgayNhap.Value
			Dim maxNgayNhap = dtpMaxNgayNhap.Value.AddDays(10)
			Dim minTriGia
			Dim maxTriGia
			Dim minNamXuatBan
			Dim maxNamXuatBan

			minTriGia = SachBUS.GetMinAndMaxValue(nudMinTriGia.Text)
			maxTriGia = SachBUS.GetMinAndMaxValue(nudMaxTriGia.Text)
			minNamXuatBan = SachBUS.GetMinAndMaxValue(nudMinNamXuatBan.Text)
			maxNamXuatBan = SachBUS.GetMinAndMaxValue(nudMaxNamXuatBan.Text)

			LoadListSach(maSach, maLoai, tenSach, maTacGia, nhaXuatBan, tinhTrangSach, minTriGia, maxTriGia, minNamXuatBan, maxNamXuatBan, minNgayNhap, maxNgayNhap)
		Catch ex As Exception
		End Try
	End Sub
End Class