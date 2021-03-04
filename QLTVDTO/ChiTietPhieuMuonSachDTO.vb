Public Class ChiTietPhieuMuonSachDTO
	Private _maChiTietPhieuMuonSach As String
	Private _maSach As String
	Private _maPhieuMuonSach As String

	Public Property MaChiTietPhieuMuonSach As String
		Get
			Return _maChiTietPhieuMuonSach
		End Get
		Set(value As String)
			_maChiTietPhieuMuonSach = value
		End Set
	End Property

	Public Property MaSach As String
		Get
			Return _maSach
		End Get
		Set(value As String)
			_maSach = value
		End Set
	End Property

	Public Property MaPhieuMuonSach As String
		Get
			Return _maPhieuMuonSach
		End Get
		Set(value As String)
			_maPhieuMuonSach = value
		End Set
	End Property
End Class
