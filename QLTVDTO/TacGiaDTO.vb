Public Class TacGiaDTO
	Private _maTacGia As Integer
	Private _tenTacGia As String

	Public Sub New()

	End Sub
	Public Sub New(maLoai As Integer, tenTacGia As String)
		_maTacGia = maLoai
		_tenTacGia = tenTacGia
	End Sub

	Public Property MaTacGia As Integer
		Get
			Return _maTacGia
		End Get
		Set(value As Integer)
			_maTacGia = value
		End Set
	End Property

	Public Property TenTacGia As String
		Get
			Return _tenTacGia
		End Get
		Set(value As String)
			_tenTacGia = value
		End Set
	End Property
End Class
