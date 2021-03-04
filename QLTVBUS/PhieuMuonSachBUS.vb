Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuMuonSachBUS
	Private phieuMuonSachDAL As PhieuMuonSachDAL

	Public Sub New()
		phieuMuonSachDAL = New PhieuMuonSachDAL()
	End Sub
	Public Sub New(connectionString As String)
		phieuMuonSachDAL = New PhieuMuonSachDAL(connectionString)
	End Sub
	Public Function InsertPhieuMuonSach(phieuMuonSach As PhieuMuonSachDTO) As Result
		'1. verify data here!!
			
		'2. insert to DB
		Return phieuMuonSachDAL.InsertPhieuMuonSach(phieuMuonSach)
	End Function

	Public Function BuildMaPhieuMuonSach(ByRef nextMaPhieuMuonSach As String) As Result

		Return phieuMuonSachDAL.BuildMaPhieuMuonSach(nextMaPhieuMuonSach)

	End Function

	Public Function IsVailNumberOfBooks(numberOfRows As Integer, quyDinh As QuyDinhDTO) As Boolean
		If numberOfRows >= quyDinh.SoSachMuonToiDa
			Return False
		End If

		Return True

	End Function

	Public Function IsVailAvailable(tinhTrangSach As String) As Boolean
		If	String.Compare(tinhTrangSach, "Đã cho mượn") = 0
			Return False
		End If

		Return True

	End Function

	Public Function IsVailDexpirationDate(ngayHetHan As Date) As Boolean
		If DateTime.Today > ngayHetHan Then
			Return False
		End If

		Return True

	End Function
	Public Function SelectByType(maPhieuMuonSach As Integer, ByRef listSach As List(Of SachReceive))
		Return phieuMuonSachDAL.SelectByType(maPhieuMuonSach, listSach)
	End Function
	Public Function SelectAll(ByRef listPhieuMuonSach As List(Of PhieuMuonSachDTO))
		Return phieuMuonSachDAL.SelectALL(listPhieuMuonSach)
	End Function

	Public Function Update(phieuMuonSach As PhieuMuonSachDTO, maPhieuMuonSach As String) As Result
		Return phieuMuonSachDAL.Update(phieuMuonSach, maPhieuMuonSach)
	End Function

	Public Function Delete(maPhieuMuonSach As String) As Result
		Return phieuMuonSachDAL.Delete(maPhieuMuonSach)
	End Function
End Class
