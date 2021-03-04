Public Class PhieuTraSachDTO
	Private _maPhieuMuonSach As String
	Private _ngayTraSach As Date

	Public Property MaPhieuMuonSach As String
		Get
			Return _maPhieuMuonSach
		End Get
		Set(value As String)
			_maPhieuMuonSach = value
		End Set
	End Property

	Public Property NgayTraSach As Date
		Get
			Return _ngayTraSach
		End Get
		Set(value As Date)
			_ngayTraSach = value
		End Set
	End Property
End Class
