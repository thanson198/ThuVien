Public Class TheLoaiSachDTO
	Private _maTheLoaiSach As Integer
	Private _tenTheLoaiSach As String

	Public Sub New()
	End Sub

	Public Sub New(maTheLoaiSach As Integer, tenTheLoaiSach As String)
		_maTheLoaiSach = maTheLoaiSach
		_tenTheLoaiSach = tenTheLoaiSach
	End Sub
	Public Property MaTheLoaiSach As Integer
		Get
			Return _maTheLoaiSach
		End Get
		Set(value As Integer)
			_maTheLoaiSach = value
		End Set
	End Property

	Public Property TenTheLoaiSach As String
		Get
			Return _tenTheLoaiSach
		End Get
		Set(value As String)
			_tenTheLoaiSach = value
		End Set
	End Property
End Class
