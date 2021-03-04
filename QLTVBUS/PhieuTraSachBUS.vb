Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuTraSachBUS
	Private phieuTraSachDAL As PhieuTraSachDAL

	Public Sub New()
		phieuTraSachDAL = New PhieuTraSachDAL()
	End Sub

	Public Sub New(connectionString As String)
		phieuTraSachDAL = New PhieuTraSachDAL(connectionString)
	End Sub

	Public Function Insert(phieuTraSach As PhieuTraSachDTO) As Result
		'1. verify data here!!

		'2. Insert to DB
		Return phieuTraSachDAL.Insert(phieuTraSach)
	End Function
End Class
