Public Class DocGiaDTO
	Private _maDocGia As String
	Private _hoTen As String
	Private _maLoaiDocGia As Integer
	Private _ngaySinh As Date
	Private _diaChi As String
	Private _email As String
	Private _ngayLapThe As Date
	Private _ngayHetHan As Date

	Public Sub New()
	End Sub

	Public Sub New(maDocgia As String, 
	               hoTen As String, 
	               maLoaiDocGia As Integer, 
	               ngaySinh As Date, 
	               diaChi As String,
	               email As String, 
	               ngayLapThe As Date, 
	               ngayHetHan As Date)

		_maDocGia = maDocgia
		_hoTen = hoTen
		_maLoaiDocGia = maLoaiDocGia
		_ngaySinh = ngaySinh
		_diaChi = diaChi
		_email = email
		_ngayLapThe = ngayLapThe
		_ngayHetHan = ngayHetHan
	End Sub

	Public Property HoTen As String
		Get
			Return _hoTen
		End Get
		Set(value As String)
			_hoTen = value
		End Set
	End Property

	Public Property MaLoaiDocGia As Integer
		Get
			Return _maLoaiDocGia
		End Get
		Set(ByVal Value As Integer)
			_maLoaiDocGia = Value
		End Set
	End Property

	Public Property NgaySinh As Date
		Get
			Return _ngaySinh
		End Get
		Set(value As Date)
			_ngaySinh = value
		End Set
	End Property

	Public Property DiaChi As String
		Get
			Return _diaChi
		End Get
		Set(value As String)
			_diaChi = value
		End Set
	End Property

	Public Property Email As String
		Get
			Return _email
		End Get
		Set(value As String)
			_email = value
		End Set
	End Property

	Public Property NgayLapThe As Date
		Get
			Return _ngayLapThe
		End Get
		Set(value As Date)
			_ngayLapThe = value
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

	Public Property NgayHetHan As Date
		Get
			Return _ngayHetHan
		End Get
		Set(value As Date)
			_ngayHetHan = value
		End Set
	End Property
End Class
