Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class BaoCaoThongKeSachTraTreBUS
	Private baoCaoThongKeSachTraTreDAL As BaoCaoThongKeSachTraTreDAL

	Public Sub New(connectionString As String)
		baoCaoThongKeSachTraTreDAL = New BaoCaoThongKeSachTraTreDAL(connectionString)
	End Sub

	Public Sub New()
		baoCaoThongKeSachTraTreDAL = New BaoCaoThongKeSachTraTreDAL()
	End Sub

	Public Function SelectSoSachTraTre(ByRef listBaoCao As List(Of BaoCaoThongKeSachTraTreDTO)) As Result
		Return baoCaoThongKeSachTraTreDAL.SelectSoSachTraTre(listBaoCao)
	End Function
End Class
