Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class BaoCaoTinhHinhMuonSachTheoTheLoaiBUS
	Private baoCaoTinhHinhMuonSachTheoTheLoaiDAL As BaoCaoTinhHinhMuonSachTheoTheLoaiDAL

	Public Sub New(connectionString As String)
		baoCaoTinhHinhMuonSachTheoTheLoaiDAL = New BaoCaoTinhHinhMuonSachTheoTheLoaiDAL(connectionString)
	End Sub

	Public Sub New()
		baoCaoTinhHinhMuonSachTheoTheLoaiDAL = New BaoCaoTinhHinhMuonSachTheoTheLoaiDAL()
	End Sub
	Public Function SelectALL(month As Integer, year As Integer) As List(Of BaoCaoTinhHinhMuonSachTheoTheLoaiDTO)
		Return baoCaoTinhHinhMuonSachTheoTheLoaiDAL.SelectAll(month, year)
	End Function

End Class
