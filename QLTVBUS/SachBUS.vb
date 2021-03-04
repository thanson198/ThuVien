Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class SachBUS
	Private sachDAL As SachDAL
	Public Sub New()
		sachDAL = New SachDAL()
	End Sub

	Public Sub New(connectionString As String)
		sachDAL = New SachDAL(connectionString)
	End Sub

	Public Function IsVaildName(sach As SachDTO) As Boolean
		If (sach.TenSach.Length < 1) Then
			Return False
		End If

		Return True

	End Function

	Public Shared Function GetMinAndMaxValue(obj As Object) As Object
		If obj <> Nothing
			Return obj
		End If

		Return nothing

	End Function


	Public Function Insert(sach As SachDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return sachDAL.Insert(sach)
	End Function

	Public Function SelectAllByType(maLoai As Integer, Byref listSach As List(Of SachReceive)) As Result
		Return sachDAL.SelectAllByType(maLoai, listSach)
	End Function

	Public Function SelectAllCondition(maSach As String,
												  maLoai As Integer,
										tenSach As String,
										maTacGia As Integer,
										nhaXuatBan As String,
												  tinhTrangSach As String,
										minTriGia As Integer,
										maxTriGia As Integer,
												  minNamXuatBan As Integer,
												  maxNamXuatBan As Integer,
												  minNgayNhap As String,
												  maxNgayNhap As String,
										ByRef listSach As List(Of SachReceive)) As Result
		Return sachDAL.SelectAllCondition(maSach, maLoai, tenSach, maTacGia, nhaXuatBan, tinhTrangSach, minTriGia, maxTriGia, minNamXuatBan, maxNamXuatBan, minNgayNhap, maxNgayNhap, listSach)
	End Function

	Public Function BuildMaSoSach(ByRef nextMaSoSach As String) As Result

		Return sachDAL.buildMaSoSach(nextMaSoSach)

	End Function

	Public Function Update(sach As SachDTO) As Result
		Return sachDAL.Update(sach)
	End Function

	Public Function UpdateStatusBook(sach As SachDTO) As Result
		Return sachDAL.UpdateStatusBook(sach)
	End Function

	Public Function Delete(maSach As String) As Result
		Return sachDAL.Delete(maSach)
	End Function

	Public Function SelectByType(maSach As String, ByRef tenSach As String, ByRef theLoai As String, ByRef tacGia As String, ByRef tinhTrangSach As String) As Result
		Return sachDAL.SelectByType(maSach, tenSach, theLoai, tacGia, tinhTrangSach)
	End Function
	Public Function IsIntervaleYear(sachDTO As SachDTO, quyDinh As QuyDinhDTO) As Boolean
		Dim x = DateTime.Today.Year - sachDTO.NamXuatBan

		If (x > quyDinh.KhoangCachXuatBan) Then
			Return False
		End If

		Return True
	End Function
	'Public Function IsBookMax(sachDTO As SachDTO, quyDinh As QuyDinhDTO) As Boolean
	'	Dim count As Integer
	'	For book As Integer = 0 To sachDTO.MaSach

	'	Next
	'	If (count > quyDinh.SoSachMuonToiDa) Then
	'		Return False
	'	End If

	'	Return True
	'End Function

End Class
