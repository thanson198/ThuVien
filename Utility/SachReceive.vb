Public Class SachReceive
	Private _maSach As String
	Private _tenSach As String
	Private _tenTheLoai As String
	Private _tenTacGia As String
	Private _namXuatBan As Integer
	Private _nhaXuatBan As String
	Private _ngayNhap As Date
	Private _triGia As Integer
	Private _tinhTrangSach As String

	Public Sub New(maSach As String, tenSach As String, tenTheLoai As String, tenTacGia As String, namXuatBan As Integer, nhaXuatBan As String, ngayNhap As Date, triGia As Integer, tinhTrangSach As String)
		_maSach = maSach
		_tenSach = tenSach
		Me.TenTheLoai = tenTheLoai
		_tenTacGia = tenTacGia
		_namXuatBan = namXuatBan
		_nhaXuatBan = nhaXuatBan
		_ngayNhap = ngayNhap
		_triGia = triGia
		_tinhTrangSach = tinhTrangSach
	End Sub

	Public Sub New(maSach As String, tenSach As String, tenTheLoai As String, tenTacGia As String)
		_maSach = maSach
		_tenSach = tenSach
		_tenTheLoai = tenTheLoai
		_tenTacGia = tenTacGia
	End Sub

	Public Sub New ()
	End Sub
	Public Property MaSach As String
		Get
			Return _maSach
		End Get
		Set(value As String)
			_maSach = value
		End Set
	End Property

	Public Property TenSach As String
		Get
			Return _tenSach
		End Get
		Set(value As String)
			_tenSach = value
		End Set
	End Property

	Public Property NamXuatBan As Integer
		Get
			Return _namXuatBan
		End Get
		Set(value As Integer)
			_namXuatBan = value
		End Set
	End Property

	Public Property NhaXuatBan As String
		Get
			Return _nhaXuatBan
		End Get
		Set(value As String)
			_nhaXuatBan = value
		End Set
	End Property

	Public Property NgayNhap As Date
		Get
			Return _ngayNhap
		End Get
		Set(value As Date)
			_ngayNhap = value
		End Set
	End Property

	Public Property TriGia As Integer
		Get
			Return _triGia
		End Get
		Set(value As Integer)
			_triGia = value
		End Set
	End Property

	Public Property TinhTrangSach As String
		Get
			Return _tinhTrangSach
		End Get
		Set(value As String)
			_tinhTrangSach = value
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

	Public Property TenTheLoai As String
		Get
			Return _tenTheLoai
		End Get
		Set(value As String)
			_tenTheLoai = value
		End Set
	End Property
End Class
