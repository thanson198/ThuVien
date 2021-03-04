Public Class BaoCaoThongKeSachTraTreDTO
	Private _tenSach As String
	Private _ngayMuon As Date
	Private _soNgayTraTre As Integer

	Public Sub New(tenSach As String, ngayMuon As Date, soNgayTraTre As Integer)
		_tenSach = tenSach
		_ngayMuon = ngayMuon
		_soNgayTraTre = soNgayTraTre
	End Sub
	Public Property TenSach As String
		Get
			Return _tenSach
		End Get
		Set(value As String)
			_tenSach = value
		End Set
	End Property

	Public Property NgayMuon As Date
		Get
			Return _ngayMuon
		End Get
		Set(value As Date)
			_ngayMuon = value
		End Set
	End Property

	Public Property SoNgayTraTre As Integer
		Get
			Return _soNgayTraTre
		End Get
		Set(value As Integer)
			_soNgayTraTre = value
		End Set
	End Property
End Class
