Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class BaoCaoThongKeSachTraTreDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function SelectSoSachTraTre(ByRef listBaoCaoSachTraTre As List(Of BaoCaoThongKeSachTraTreDTO)) As Result
		Dim query As String = String.Empty
		query &= "SELECT DATEDIFF(DAY, pms.ngaytrasach, pts.ngaytrasach) AS SoNgayTraTre, [tensach], [ngaymuonsach] "
		query &= "FROM [tblSach] AS sach, [tblPhieuMuonSach] AS pms, [tblChiTietPhieuMuonSach] AS chitiet, [tblPhieuTraSach] AS pts "
		query &= "WHERE sach.[masach] = chitiet.[masach] AND pms.[maphieumuonsach] = chitiet.[maphieumuonsach] AND pts.[maphieumuonsach] = pms.[maphieumuonsach] AND pms.[ngaytrasach] < pts.[ngaytrasach] "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With
				Try
					conn.Open()
					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()
					If reader.HasRows = True Then
						While reader.Read()
							listBaoCaoSachTraTre.Add(New BaoCaoThongKeSachTraTreDTO(reader("TenSach"), reader("ngaymuonsach"), reader("SoNgayTraTre")))
						End While
					End If

				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy thông tin Báo cáo sách trả trể không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function
End Class
