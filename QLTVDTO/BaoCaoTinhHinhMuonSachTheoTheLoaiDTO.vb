Public Class BaoCaoTinhHinhMuonSachTheoTheLoaiDTO
	Private _tenTheLoai As String
	Private _soLuotMuon As Integer
	Private _tiLe As Double
	Public Sub New(tenTheLoai As String, soLuotMuon As Integer, tiLe As Integer)
		_tenTheLoai = tenTheLoai
		_soLuotMuon = soLuotMuon
		_tiLe = tiLe
	End Sub

	Public Property TenTheLoai As String
		Get
			Return _tenTheLoai
		End Get
		Set(value As String)
			_tenTheLoai = value
		End Set
	End Property

	Public Property SoLuotMuon As Integer
		Get
			Return _soLuotMuon
		End Get
		Set(value As Integer)
			_soLuotMuon = value
		End Set
	End Property

	Public Property TiLe As Double
		Get
			Return _tiLe
		End Get
		Set(value As Double)
			_tiLe = value
		End Set
	End Property
End Class
