Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonSachDAL
	Private connectionString As String

	Public Sub New()
		' Read ConnectionString value from App.config file
		connectionString = ConfigurationManager.AppSettings("ConnectionString")
	End Sub

	Public Sub New(ConnectionString As String)
		Me.connectionString = ConnectionString
	End Sub

	Public Function BuildMaChiTietPhieuMuonSach(ByRef nextMaChiTietPhieuMuonSach As String) As Result
		nextMaChiTietPhieuMuonSach = String.Empty
		Dim y = DateTime.Now.Year
		Dim x = y.ToString().Substring(2)
		nextMaChiTietPhieuMuonSach = x + "0000"

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [machitietphieumuonsach] "
		query &= "FROM [tblChiTietPhieuMuonSach] "
		query &= "ORDER BY [machitietphieumuonsach] DESC "

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
					Dim msOnDB As String
					msOnDB = Nothing
					If reader.HasRows = True Then
						While reader.Read()
							msOnDB = reader("machitietphieumuonsach")
						End While
					End If
					If (msOnDB <> Nothing And msOnDB.Length >= 6) Then
						Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
						Dim iCurrentYear = Integer.Parse(currentYear)
						Dim currentYearOnDB = msOnDB.Substring(0, 2)
						Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
						Dim year = iCurrentYear
						If (year < icurrentYearOnDB) Then
							year = icurrentYearOnDB
						End If
						nextMaChiTietPhieuMuonSach = year.ToString()
						Dim v = msOnDB.Substring(2)
						Dim convertDecimal = Convert.ToDecimal(v)
						convertDecimal = convertDecimal + 1
						Dim tmp = convertDecimal.ToString()
						tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
						nextMaChiTietPhieuMuonSach = nextMaChiTietPhieuMuonSach + tmp
						System.Console.WriteLine(nextMaChiTietPhieuMuonSach)
					End If
				Catch ex As Exception
					conn.Close() ' that bai!!!
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy tự động Mã chi tiết phiếu mượn sách kế tiếp không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function InsertChiTietPhieuMuonSach(chiTietPhieuMuonSach As ChiTietPhieuMuonSachDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [tblChiTietPhieuMuonSach] ([machitietphieumuonsach], [masach], [maphieumuonsach])"
		query &= "VALUES (@machitietphieumuonsach, @masach, @maphieumuonsach)"

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@machitietphieumuonsach", chiTietPhieuMuonSach.MaChiTietPhieuMuonSach)
					.Parameters.AddWithValue("@masach", chiTietPhieuMuonSach.MaSach)
					.Parameters.AddWithValue("@maphieumuonsach", chiTietPhieuMuonSach.MaPhieuMuonSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Thêm chi tiét phiếu mượn sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function

	Public Function Update(chiTietPhieuMuonSach As ChiTietPhieuMuonSachDTO, maPhieuMuonSach As String, maSach As String) As Result
		Dim query As String = String.Empty

		query &= " UPDATE [tblChiTietPhieuMuonSach] SET"
		query &= " [masach] = @masachcapnhap "
		query &= " WHERE "
		query &= " [masach] = @masach and [maphieumuonsach] = @maphieumuonsach"

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@masachcapnhap", chiTietPhieuMuonSach.MaSach)
					.Parameters.AddWithValue("@masach", maSach)
					.Parameters.AddWithValue("@maphieumuonsach", maPhieuMuonSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Cập nhập chi tiết phiếu mượn sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong

	End Function

	Public Function Delete(maPhieuMuonSach As String, maSach As String) As Result
		Dim query As String = String.Empty
		query &= " DELETE FROM [tblChiTietPhieuMuonSach] "
		query &= " WHERE "
		query &= " [masach] = @masach and [maphieumuonsach] = @maphieumuonsach"

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@masach", maSach)
					.Parameters.AddWithValue("@maphieumuonsach", maPhieuMuonSach)
				End With
				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch ex As Exception
					Console.WriteLine(ex.StackTrace)
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Xóa chi tiết phiếu mượn sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True)  ' thanh cong
	End Function

	Public Function SelectAll(maPhieuMuonSach As String, ByRef ngayMuonSach As Date, ByRef ngayTraSach As Date) As Result
		Dim query As String = String.Empty
		query &= "SELECT [ngaymuonsach], [ngaytrasach] "
		query &= "FROM [tblPhieuMuonSach] "
		query &= "WHERE [maphieumuonsach] = @maphieumuonsach"

		Using conn As New SqlConnection(connectionString)
			Using comm As New SqlCommand()
				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@maphieumuonsach", maPhieuMuonSach)
				End With
				Try
					conn.Open()
					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()
					If reader.HasRows = True Then
						While reader.Read()
							ngayMuonSach = reader("ngaymuonsach")
							ngayTraSach = reader("ngaytrasach")
						End While
					End If

				Catch ex As Exception
					conn.Close()
					System.Console.WriteLine(ex.StackTrace)
					Return New Result(False, "Lấy thông tin sách không thành công", ex.StackTrace)
				End Try
			End Using
		End Using
		Return New Result(True) ' thanh cong
	End Function
End Class
