Public Class ThamSoDTO
	Private Shared _tuoiToiThieu As Integer = 18
	Private Shared _tuoiToiDa As Integer = 55
	Private Shared _thoiHanSuDung As Integer = 6
	Private Shared _khoangCachXuatBan As Integer = 8

	Public Shared Property TuoiToiThieu As Integer
		Get
			Return _tuoiToiThieu
		End Get
		Set(value As Integer)
			_tuoiToiThieu = value
		End Set
	End Property

	Public Shared Property TuoiToiDa As Integer
		Get
			Return _tuoiToiDa
		End Get
		Set(value As Integer)
			_tuoiToiDa = value
		End Set
	End Property

	Public Shared Property ThoiHanSuDung As Integer
		Get
			Return _thoiHanSuDung
		End Get
		Set(value As Integer)
			_thoiHanSuDung = value
		End Set
	End Property
End Class
