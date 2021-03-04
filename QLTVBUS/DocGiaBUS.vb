Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DocGiaBUS
	Private docGiaDAL As DocGiaDAL

	Public Sub New()
		docGiaDAL = New DocGiaDAL()
	End Sub

	Public Sub New(connectionString As String)
		docGiaDAL = New DocGiaDAL(connectionString)
	End Sub

	Public Function IsVaildName(docgia As DocGiaDTO) As Boolean
		If (docgia.HoTen.Length < 1) Then
			Return False
		End If

		Return True

	End Function

	Public Function Insert(docgia As DocGiaDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.Insert(docgia)
	End Function
	Public Function Update(docGia As DocGiaDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.Update(docGia)

	End Function
	Public Function Delete(maLoai As Integer) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.Delete(maLoai)

	End Function

	Public Function SelectAll(ByRef LoaiDocGiaDTO As List(Of DocGiaDTO)) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.SelectAll(LoaiDocGiaDTO)

	End Function

	Public Function SelectAllByType(maLoai As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return docGiaDAL.SelectAllByType(maLoai, listDocGia)

	End Function

	Public Function BuildMaSoDocGia(ByRef nextMaSoDocGia As Integer) As Result

		Return docGiaDAL.BuildMaSoDocGia(nextMaSoDocGia)

	End Function

	Public Function LayNgayHetHan(ngayLapThe As Date) As Date
		Return ngayLapThe.AddMonths(ThamSoDTO.ThoiHanSuDung)
	End Function

	Public Function IsVaildAge(docGiaDTO As DocGiaDTO, quyDinh As QuyDinhDTO) As Boolean
		Dim age As Integer
		age = DateTime.Today.Year - docGiaDTO.NgaySinh.Year
		If DateTime.Today < docGiaDTO.NgaySinh.AddYears(age) Then
			age = age - 1
		End If
		If age < quyDinh.TuoiToiThieu Or age > quyDinh.TuoiToiDa Then
			Return False
		End If
		Return True
	End Function

	Public Function SelectByType(maDocGia As String, ByRef hoTen As String, ByRef ngayHetHan As Date) As Result
		
		Return docGiaDAL.SelectByType(maDocGia, hoTen, ngayHetHan)
	End Function
End Class
