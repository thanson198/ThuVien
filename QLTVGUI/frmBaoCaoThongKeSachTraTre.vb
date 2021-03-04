Imports QLTVBUS
Imports QLTVDTO
Imports Utility

Public Class frmBaoCaoThongKeSachTraTre
	Private baoCaoThongKeSachTraTreBUS As BaoCaoThongKeSachTraTreBUS
	Private Sub LoadChiTietBaoCao()
		If dtNgayBaoCao.Value <> Nothing Then
			Dim listThongKeTraSach = New List(Of BaoCaoThongKeSachTraTreDTO)
			Dim result As Result
			result = baoCaoThongKeSachTraTreBUS.SelectSoSachTraTre(listThongKeTraSach)
			If (result.FlagResult = False) Then
				MessageBox.Show("Lấy danh sách sách theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
				Return
			End If

			'dgvListDocGia.SuspendLayout()
			dgvBaoCaoThongKeSachTraTre.Columns.Clear()
			dgvBaoCaoThongKeSachTraTre.DataSource = Nothing

			dgvBaoCaoThongKeSachTraTre.AutoGenerateColumns = False
			dgvBaoCaoThongKeSachTraTre.AllowUserToAddRows = False
			dgvBaoCaoThongKeSachTraTre.DataSource = listThongKeTraSach

			Dim clTenSach = New DataGridViewTextBoxColumn()
			clTenSach.Name = "TenSach"
			clTenSach.HeaderText = "Tên Sách"
			clTenSach.DataPropertyName = "TenSach"
			dgvBaoCaoThongKeSachTraTre.Columns.Add(clTenSach)

			Dim clNgayMuon = New DataGridViewTextBoxColumn()
			clNgayMuon.Name = "NgayMuon"
			clNgayMuon.HeaderText = "Ngày Mượn"
			clNgayMuon.DataPropertyName = "NgayMuon"
			dgvBaoCaoThongKeSachTraTre.Columns.Add(clNgayMuon)

			Dim clSoNgayTraTre = New DataGridViewTextBoxColumn()
			clSoNgayTraTre.Name = "SoNgayTraTre"
			clSoNgayTraTre.HeaderText = "Số Ngày Trả Trể"
			clSoNgayTraTre.DataPropertyName = "SoNgayTraTre"
			dgvBaoCaoThongKeSachTraTre.Columns.Add(clSoNgayTraTre)

			dgvBaoCaoThongKeSachTraTre.Columns(0).Width = 150
		End If
	End Sub

	Private Sub frmBaoCaoThongKeSachTraTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		baoCaoThongKeSachTraTreBUS = New BaoCaoThongKeSachTraTreBUS()
		LoadChiTietBaoCao()
	End Sub
End Class