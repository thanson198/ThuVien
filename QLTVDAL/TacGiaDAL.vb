Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class TacGiaDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub
	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub
	Public Function GetNextID(ByRef nextID As Integer) As Result
		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [matacgia] "
		query &= "FROM [tblTacGia] "
		query &= "ORDER BY [matacgia] DESC "

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
							idOnDB = reader("matacgia")
						End While
					End If
					' new ID = current ID + 1
					nextID = idOnDB + 1
				Catch ex As Exception
					conn.Close()
					' them that bai!!!
					nextID = 1
					Return New Result(False, "Lấy ID kế tiếp của tác giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function
	Public Function Insert(tacGia As TacGiaDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [tblTacGia] ([matacgia], [tentacgia])"
		query &= "VALUES (@matacgia, @tentacgia)"

		Dim nextID = 0
		Dim result As Result
		result = GetNextID(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		tacGia.MaTacGia = nextID

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matacgia", tacGia.MaTacGia)
					.Parameters.AddWithValue("@tentacgia", tacGia.TenTacGia)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Thêm tác giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function
	Public Function Update(tacGia As TacGiaDTO) As Result

		Dim query As String = String.Empty
		query &= " UPDATE [tblTacGia] SET"
		query &= " [tentacgia] = @tentacgia "
		query &= "WHERE "
		query &= " [matacgia] = @matacgia "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matacgia", tacGia.MaTacGia)
					.Parameters.AddWithValue("@tentacgia", tacGia.TenTacGia)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Cập nhật tác giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using

		Return New Result(True) ' thanh cong

	End Function
	Public Function Delete(maTacGia As Integer) As Result

		Dim query As String = String.Empty
		query &= " DELETE FROM [tblTacGia] "
		query &= " WHERE "
		query &= " [matacgia] = @matacgia "

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@matacgia", maTacGia)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Xóa tác giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using

		Return New Result(True) ' thanh cong

	End Function
	Public Function SelectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result
		Dim query As String = String.Empty
		query &= " SELECT [matacgia], [tentacgia]"
		query &= " FROM [tblTacGia]"

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
						listTacGia.Clear()
						While reader.Read()
							listTacGia.Add(New TacGiaDTO(reader("matacgia"), reader("tentacgia")))
						End While
					End If
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					' them that bai!!!
					Return New Result(False, "Lấy tất cả tác giả không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function
End Class
