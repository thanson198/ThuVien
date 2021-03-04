Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class PhieuTraSachDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub

	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function Insert(phieuTraSach As PhieuTraSachDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [tblPhieuTraSach] ([maphieumuonsach], [ngaytrasach])"
		query &= "VALUES (@maphieumuonsach, @ngaytrasach)"


		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@maphieumuonsach", phieuTraSach.MaPhieuMuonSach)
					.Parameters.AddWithValue("@ngaytrasach", phieuTraSach.NgayTraSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Thêm Phiếu Trả sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function
End Class
