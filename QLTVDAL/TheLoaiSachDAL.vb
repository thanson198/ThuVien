Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class TheLoaiSachDAL
	Private connectionString As String
	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub

	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub
	Public Function getNextID(ByRef nextID As Integer) As Result

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [matheloaisach] "
		query &= "FROM [tblTheLoaiSach] "
		query &= "ORDER BY [matheloaisach] DESC "

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
					Dim idOnDB As Integer
					idOnDB = Nothing
					If reader.HasRows = True Then
						While reader.Read()
							idOnDB = reader("matheloaisach")
						End While
					End If
					' new ID = current ID + 1
					nextID = idOnDB + 1
				Catch ex As Exception
					conn.Close()
					' them that bai!!!
					nextID = 1
					Return New Result(False, "Lấy ID kế tiếp của Thể loại sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function insert(sach As TheLoaiSachDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [tblTheLoaiSach] ([matheloaisach], [tentheloaisach])"
		query &= "VALUES (@matheloaisach,@tentheloaisach)"

		Dim nextID = 0
		Dim result As Result
		result = getNextID(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		sach.MaTheLoaiSach = nextID

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matheloaisach", sach.MaTheLoaiSach)
					.Parameters.AddWithValue("@tentheloaisach", sach.TenTheLoaiSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Thêm Thể loại sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function selectALL(ByRef listTheLoaiSach As List(Of TheLoaiSachDTO)) As Result
		Dim query As String = String.Empty
		query &= " SELECT [matheloaisach], [tentheloaisach]"
		query &= " FROM [tblTheLoaiSach]"


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
						listTheLoaiSach.Clear()
						While reader.Read()
							listTheLoaiSach.Add(New TheLoaiSachDTO(reader("matheloaisach"), reader("tentheloaisach")))
						End While
					End If
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Lấy tất cả Thể loại sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function Delete(maLoai As Integer) As Result
		Dim query As String = String.Empty
		query &= " DELETE FROM [tblTheLoaiSach] "
		query &= " WHERE "
		query &= " [matheloaisach] = @matheloaisach "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matheloaisach", maLoai)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Xóa thể loại sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using

		Return New Result(True) ' thanh cong
	End Function

	Public Function Update(theLoaiSach As TheLoaiSachDTO) As Result
		Dim query As String = String.Empty
		query &= " UPDATE [tblTheLoaiSach] SET"
		query &= " [tentheloaisach] = @tentheloaisach "
		query &= "WHERE "
		query &= " [matheloaisach] = @matheloaisach "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matheloaisach", theLoaiSach.MaTheLoaiSach)
					.Parameters.AddWithValue("@tentheloaisach", theLoaiSach.TenTheLoaiSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Cập nhật the loai sach không thành công", ex.StackTrace)
				End Try
			End Using
		End Using

		Return New Result(True) ' thanh cong
	End Function

	Public Function DemSoLanMuon(maTheLoai As String, month As Integer, year As Integer) As Integer
		Dim query As String = String.Empty
		Dim soLanMuon As Integer
		query &= " SELECT COUNT (*) AS SoLanMuon "
		query &= " FROM [tblPhieuMuonSach] AS pms, [tblChiTietPhieuMuonSach] AS chitiet, [tblTheLoaiSach] AS theloai, [tblSach] AS sach "
		query &= " WHERE sach.[masach] = chitiet.[masach] AND chitiet.[masach] = sach.[masach] AND pms.[maphieumuonsach] = chitiet.[maphieumuonsach]
					  AND sach.[matheloaisach] = theloai.[matheloaisach]
					  AND theloai.[matheloaisach] = @matheloaisach
					  AND YEAR([ngaymuonsach]) = @year
					  AND MONTH([ngaymuonsach]) = @month "
		Using connection As New SqlConnection(connectionString)
			Using command As New SqlCommand()
				With command
					.Connection = connection
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matheloaisach", maTheLoai)
					.Parameters.AddWithValue("@month", month)
					.Parameters.AddWithValue("@year", year)
				End With
				Try
					connection.Open()
					Dim reader As SqlDataReader
					reader = command.ExecuteReader()
					If reader.HasRows = True Then
						While reader.Read()
							soLanMuon = reader("SoLanMuon")
						End While
					End If
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					connection.Close()
					Return -1
				End Try
			End Using
		End Using
		Return soLanMuon
	End Function


End Class
