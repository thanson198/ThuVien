Public Class PhieuMuonSachDTO
	Private _maPhieuMuonSach As String
	Private _ngayMuonSach As Date
	Private _maDocGia As String
	Private _ngayTraSach As Date

	Public Sub New()

	End Sub
	Public Sub New(maPhieuMuonSach As String, ngayMuonSach As Date, maDocGia As String, ngayTraSach As Date)
		_maPhieuMuonSach = maPhieuMuonSach
		_ngayMuonSach = ngayMuonSach
		_maDocGia = maDocGia
		_ngayTraSach = ngayTraSach
	End Sub

	Public Property MaPhieuMuonSach As String
		Get
			Return _maPhieuMuonSach
		End Get
		Set(value As String)
			_maPhieuMuonSach = value
		End Set
	End Property

	Public Property NgayMuonSach As Date
		Get
			Return _ngayMuonSach
		End Get
		Set(value As Date)
			_ngayMuonSach = value
		End Set
	End Property

	Public Property MaDocGia As String
		Get
			Return _maDocGia
		End Get
		Set(value As String)
			_maDocGia = value
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
