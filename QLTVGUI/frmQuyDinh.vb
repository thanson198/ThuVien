Imports QLTVBUS
Imports QLTVDTO

Public Class frmQuyDinh
	Dim quyDinhBus As QuyDinhBUS
	Dim quyDinh As QuyDinhDTO
	Private Sub frmQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		quyDinhBus = New QuyDinhBUS()
		Dim result = quyDinhBus.selectALL(quyDinh)
		If (result.FlagResult = False) Then
			MessageBox.Show("Lấy thông tin Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			System.Console.WriteLine(result.SystemMessage)
			Me.Close()
		End If
		txtTuoiToiThieu.Text = quyDinh.TuoiToiThieu
		txtTuoiToiDa.Text = quyDinh.TuoiToiDa
		txtHanSuDung.Text = quyDinh.ThoiHanSuDung
		txtKhoangCachXuatBan.Text = quyDinh.KhoangCachXuatBan
		txtSoNgayMuonToiDa.Text = quyDinh.SoNgayMuonToiDa
		txtSoSachMuonToiDa.Text = quyDinh.SoSachMuonToiDa
	End Sub

	Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
		Try
			quyDinh.TuoiToiThieu = Integer.Parse(txtTuoiToiThieu.Text)
			quyDinh.TuoiToiDa = Integer.Parse(txtTuoiToiDa.Text)
			quyDinh.ThoiHanSuDung = Integer.Parse(txtHanSuDung.Text)
			quyDinh.KhoangCachXuatBan = Integer.Parse(txtKhoangCachXuatBan.Text)
			quyDinh.SoNgayMuonToiDa = Integer.Parse(txtSoNgayMuonToiDa.Text)
			quyDinh.SoSachMuonToiDa = Integer.Parse(txtSoSachMuonToiDa.Text)

			Dim result = quyDinhBus.update(quyDinh)
			If (result.FlagResult = False) Then
				MessageBox.Show("Cập nhật Quy Định không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				System.Console.WriteLine(result.SystemMessage)
				Return
			End If
			MessageBox.Show("Cập nhật Quy Định thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Catch ex As Exception
			System.Console.WriteLine(ex.StackTrace)
		End Try
	End Sub
End Class