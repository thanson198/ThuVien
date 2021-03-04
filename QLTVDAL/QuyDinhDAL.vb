Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class QuyDinhDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function update(quyDinh As QuyDinhDTO) As Result

		Dim query As String = String.Empty
		query &= " UPDATE [tblQuyDinh] SET"
		query &= " [tuoitoithieu] = @tuoitoithieu "
		query &= " ,[tuoitoida] = @tuoitoida "
		query &= " ,[thoihansudung] = @thoihansudung "
		query &= " ,[khoangcachxuatban] = @khoangcachxuatban "
		query &= " ,[songaymuontoida] = @songaymuontoida "
		query &= " ,[sosachmuontoida] = @sosachmuontoida "
		query &= "WHERE "
		query &= " [id] = @id "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@tuoitoithieu", quyDinh.TuoiToiThieu)
					.Parameters.AddWithValue("@tuoitoida", quyDinh.TuoiToiDa)
					.Parameters.AddWithValue("@thoihansudung", quyDinh.ThoiHanSuDung)
					.Parameters.AddWithValue("@khoangcachxuatban", quyDinh.KhoangCachXuatBan)
					.Parameters.AddWithValue("@songaymuontoida", quyDinh.SoNgayMuonToiDa)
					.Parameters.AddWithValue("@sosachmuontoida", quyDinh.SoSachMuonToiDa)
					.Parameters.AddWithValue("@id", quyDinh.ID)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Cập nhật Quy Định không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function
	Public Function selectALL(ByRef quyDinh As QuyDinhDTO) As Result
		Dim query As String = String.Empty
		query &= "SELECT [id], [tuoitoithieu], [tuoitoida], [thoihansudung], [khoangcachxuatban], [songaymuontoida], [sosachmuontoida] "
		query &= "FROM [tblQuyDinh]"

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
							quyDinh = New QuyDinhDTO(reader("id"), reader("tuoitoithieu"), reader("tuoitoida"), reader("thoihansudung"), reader("khoangcachxuatban"), reader("songaymuontoida"), reader("sosachmuontoida"))
						End While
					End If
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Lấy Quy Định không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function
End Class
