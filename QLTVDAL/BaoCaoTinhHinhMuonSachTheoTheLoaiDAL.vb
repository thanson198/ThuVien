Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class BaoCaoTinhHinhMuonSachTheoTheLoaiDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function SelectAll(month As Integer, year As Integer) As List(Of BaoCaoTinhHinhMuonSachTheoTheLoaiDTO)
		Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
		Dim theLoaiSach = New TheLoaiSachDAL
		'Dim theLoaiDAL = New TheLoaiSachDAL
		theLoaiSach.selectALL(listTheLoaiSach)

		Dim tongSoLanMuon As Integer = 0
		Dim listThongKe = New List(Of BaoCaoTinhHinhMuonSachTheoTheLoaiDTO)
		For Each theloai In listTheLoaiSach
			If theLoaiSach.DemSoLanMuon(theloai.MaTheLoaiSach, month, year) > 0 Then
				listThongKe.Add(New BaoCaoTinhHinhMuonSachTheoTheLoaiDTO(theloai.TenTheLoaiSach, theLoaiSach.DemSoLanMuon(theloai.MaTheLoaiSach, month, year), 0))
	
			End If
		Next

		For Each dt In listThongKe
			tongSoLanMuon += dt.SoLuotMuon
		Next

		Dim tile As Integer = 0
		For Each dt In listThongKe
			dt.TiLe = dt.SoLuotMuon * 100 / tongSoLanMuon
		Next

		Return listThongKe
	End Function
End Class
