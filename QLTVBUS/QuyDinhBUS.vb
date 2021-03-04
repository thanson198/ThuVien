Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class QuyDinhBUS
	Private quyDinhDAL As QuyDinhDAL
	Public Sub New()
		quyDinhDAL = New QuyDinhDAL()
	End Sub
	Public Sub New(connnectionString As String)
		quyDinhDAL = New QuyDinhDAL(connnectionString)
	End Sub
	Public Function update(quyDinh As QuyDinhDTO) As Result
		Return quyDinhDAL.update(quyDinh)
	End Function

	Public Function selectALL(ByRef quyDinh As QuyDinhDTO) As Result
		Return quyDinhDAL.selectALL(quyDinh)
	End Function

End Class
