Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonSachBUS
	Private chiTietPhieuMuonSachDAL As ChiTietPhieuMuonSachDAL

	Public Sub New()
		chiTietPhieuMuonSachDAL = New ChiTietPhieuMuonSachDAL()
	End Sub
	Public Sub New(connectionString As String)
		chiTietPhieuMuonSachDAL = New ChiTietPhieuMuonSachDAL(connectionString)
	End Sub

	Public Function InsertChiTietPhieuMuonSach(chiTietPhieuMuonSach As ChiTietPhieuMuonSachDTO) As Result
	
		Return chiTietPhieuMuonSachDAL.InsertChiTietPhieuMuonSach(chiTietPhieuMuonSach)

	End Function

	Public Function BuildMaChiTietPhieuMuonSach(ByRef nextMaPhieuMuonSach As String) As Result

		Return chiTietPhieuMuonSachDAL.BuildMaChiTietPhieuMuonSach(nextMaPhieuMuonSach)

	End Function

	Public Function Update(chiTietPhieu As ChiTietPhieuMuonSachDTO, maPhieuMuonSach As String, maSach As  String) As Result
		Return chiTietPhieuMuonSachDAL.Update(chiTietPhieu, maPhieuMuonSach, maSach)
	End Function

	Public Function Delete(maPhieuMuonSach As String, maSach As String) As Result
		Return chiTietPhieuMuonSachDAL.Delete(maPhieuMuonSach, maSach)
	End Function

	Public Function SelectAll(maPhieuMuonSach As String, ByRef ngayMuonSach As Date, ByRef ngayTraSach As Date) As Result
		Return chiTietPhieuMuonSachDAL.SelectAll(maPhieuMuonSach, ngayMuonSach, ngayTraSach)
	End Function
End Class
