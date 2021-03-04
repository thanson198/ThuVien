Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TacGiaBUS
	Private tacGiaDAL As TacGiaDAL
	Public Sub New()
		tacGiaDAL = New TacGiaDAL()
	End Sub
	Public Sub New(connectionString As String)
		tacGiaDAL = New TacGiaDAL(connectionString)
	End Sub
	Public Function IsValidName(tacGia As TacGiaDTO) As Boolean

		If (tacGia.TenTacGia.Length < 1) Then
			Return False
		End If

		Return True

	End Function
	Public Function Insert(tacGia As TacGiaDTO) As Result
		'1. verify data here!!

		'2. insert to DB
		Return tacGiaDAL.Insert(tacGia)
	End Function
	Public Function SelectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result
		'1. verify data here!!

		'2. insert to DB
		Return tacGiaDAL.SelectAll(listTacGia)
	End Function
	Public Function GetNextID(ByRef nextID As Integer) As Result
		Return tacGiaDAL.GetNextID(nextID)
	End Function
	Public Function Delete(maTacGia As Integer) As Result
		'1. verify data here!!

		'2. delete to DB
		Return tacGiaDAL.Delete(maTacGia)
	End Function
	Public Function Update(tacGia As TacGiaDTO) As Result
		'1. verify data here!!

		'2. update to DB
		Return tacGiaDAL.Update(tacGia)
	End Function
End Class
