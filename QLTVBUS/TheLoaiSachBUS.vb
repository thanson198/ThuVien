Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TheLoaiSachBUS
	Private theLoaiSachDAL As TheLoaiSachDAL
	Public Sub New()
		theLoaiSachDAL = New TheLoaiSachDAL()
	End Sub
	Public Sub New(connectionString As String)
		theLoaiSachDAL = New TheLoaiSachDAL(connectionString)
	End Sub
	Public Function isValidName(theLoaiSach As TheLoaiSachDTO) As Boolean

		If (theLoaiSach.TenTheLoaiSach.Length < 1) Then
			Return False
		End If

		Return True

	End Function
	Public Function insert(theLoaiSach As TheLoaiSachDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return theLoaiSachDAL.insert(theLoaiSach)
	End Function
	Public Function selectAll(ByRef listTheLoaiSach As List(Of TheLoaiSachDTO)) As Result
		'1. verify data here!!

		'2. insert to DB
		Return theLoaiSachDAL.selectALL(listTheLoaiSach)
	End Function

	Public Function getNextID(ByRef nextID As Integer) As Result
		Return theLoaiSachDAL.getNextID(nextID)
	End Function

	Public Function Delete(maLoai As  Integer) As Result
		'1. verify data here!!

		'2. delete to DB
		Return theLoaiSachDAL.Delete(maLoai)
	End Function

	Public Function Update(theLoaiSach As TheLoaiSachDTO) As Result
		'1. verify data here!!

		'2. update to DB
		Return theLoaiSachDAL.Update(theLoaiSach)
	End Function
End Class
