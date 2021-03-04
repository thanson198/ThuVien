Imports System.Configuration

Public Class frmMain
	Private ConnectionString As String

	Private Sub btnHoSoDocGia_Click(sender As Object, e As EventArgs) Handles btnHoSoDocGia.Click
		cmHoSoDocGia.Show(btnHoSoDocGia, 0, btnHoSoDocGia.Height)

	End Sub

	Private Sub ThêmLoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmLoạiĐộcGiảToolStripMenuItem.Click
		Dim frmLapTheDocGia As frmLapTheDocGia = New frmLapTheDocGia()
		frmLapTheDocGia.MdiParent = Me
		frmLapTheDocGia.Show()

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Read ConnectionString value from App.config file
		ConnectionString = ConfigurationManager.AppSettings("ConnectionString")

	End Sub

	Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
		Dim frmThemLoaiDoGia As frmThemLoaiDocGia = New frmThemLoaiDocGia()
		frmThemLoaiDoGia.MdiParent = Me
		frmThemLoaiDoGia.Show()

	End Sub

	Private Sub QuảnLíĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíĐộcGiảToolStripMenuItem.Click
		Dim frmQuanLyDocGia As frmQuanLyDocGia = New frmQuanLyDocGia()
		frmQuanLyDocGia.MdiParent = Me
		frmQuanLyDocGia.Show()

	End Sub

	Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíToolStripMenuItem.Click
		Dim frmQuanLyLoaiDocGia As frmQuanLyLoaiDocGia = New frmQuanLyLoaiDocGia()
		frmQuanLyLoaiDocGia.MdiParent = Me
		frmQuanLyLoaiDocGia.Show()
	End Sub

	Private Sub btnQuanLi_Click(sender As Object, e As EventArgs) Handles btnQuanLi.Click
		cmQuanLi.Show(btnQuanLi, 0, btnQuanLi.Height)
	End Sub

	Private Sub ThemSachToolTrip_Click(sender As Object, e As EventArgs) Handles ThemSachToolTrip.Click
		Dim frmThemSach As frmThemSach = New frmThemSach()
		frmThemSach.MdiParent = Me
		frmThemSach.Show()
	End Sub

	Private Sub ThêmThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmThểLoạiSáchToolStripMenuItem.Click
		Dim frmThemTheLoaiSach As frmThemTheLoaiSach = New frmThemTheLoaiSach()
		frmThemTheLoaiSach.MdiParent = Me
		frmThemTheLoaiSach.Show()
	End Sub

	Private Sub QuảnLýThểLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýThểLoạiSáchToolStripMenuItem.Click
		Dim frmQuanLyTheLoaiSach As frmQuanLyTheLoaiSach = New frmQuanLyTheLoaiSach()
		frmQuanLyTheLoaiSach.MdiParent = Me
		frmQuanLyTheLoaiSach.Show()
	End Sub

	Private Sub QuảnLýSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSáchToolStripMenuItem.Click
		Dim frmQuanLySach As frmQuanLySach = New frmQuanLySach()
		frmQuanLySach.MdiParent = Me
		frmQuanLySach.Show()
	End Sub

	Private Sub QuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuyĐịnhToolStripMenuItem.Click
		Dim frmQuyDinh As frmQuyDinh = New frmQuyDinh()
		frmQuyDinh.MdiParent = Me
		frmQuyDinh.Show()
	End Sub

	Private Sub btnQuyDinh_Click(sender As Object, e As EventArgs) Handles btnQuyDinh.Click
		cmQuyDinh.Show(btnQuyDinh, 0, btnQuyDinh.Height)
	End Sub

	Private Sub TraCứuSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuSáchToolStripMenuItem.Click
		Dim frmTraCuuSach As frmTraCuuSach = New frmTraCuuSach()
		frmTraCuuSach.MdiParent = Me
		frmTraCuuSach.Show()
	End Sub

	Private Sub LậpThẻMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim frmLapTheMuonSach As frmLapPhieuMuonSach = New frmLapPhieuMuonSach()
		frmLapTheMuonSach.MdiParent = Me
		frmLapTheMuonSach.Show()
	End Sub

	Private Sub ThêmTácGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTácGiảToolStripMenuItem.Click
		Dim frmTacGia As frmThemTacGia = New frmThemTacGia()
		frmThemTacGia.MdiParent = Me
		frmTacGia.Show()
	End Sub

	Private Sub QuảnLíThẻMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim frmQuanLiPhieuMuonSach As frmQuanLyPhieuMuonSach = New frmQuanLyPhieuMuonSach()
		frmQuanLyPhieuMuonSach.MdiParent = Me
		frmQuanLyPhieuMuonSach.Show()
	End Sub

	Private Sub BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem.Click
		Dim frmBaoCaoTinhHinhMuonSachTheoTheLoai As frmBaoCaoTinhHinhMuonSachTheoTheLoai = New frmBaoCaoTinhHinhMuonSachTheoTheLoai()
		frmBaoCaoTinhHinhMuonSachTheoTheLoai.MdiParent = Me
		frmBaoCaoTinhHinhMuonSachTheoTheLoai.Show()
	End Sub

	Private Sub btnBaoCao_Click(sender As Object, e As EventArgs) Handles btnBaoCao.Click
		cmBaoCao.Show(btnBaoCao, 0, btnBaoCao.Height)
	End Sub

	Private Sub BáoCáoThốngKêSáchTrảTrểToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoThốngKêSáchTrảTrểToolStripMenuItem.Click
		Dim frmBaoCaoThongKeSachTraTre As frmBaoCaoThongKeSachTraTre = New frmBaoCaoThongKeSachTraTre()
		frmBaoCaoThongKeSachTraTre.MdiParent = Me
		frmBaoCaoThongKeSachTraTre.Show()
	End Sub

	Private Sub NhậnTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim frmNhanTraSach As frmLapPhieuTraSach = New frmLapPhieuTraSach()
		frmNhanTraSach.MdiParent = Me
		frmNhanTraSach.Show()
	End Sub

	Private Sub btnPhieuMuonSach_Click(sender As Object, e As EventArgs) Handles btnPhieuMuonSach.Click
		cmPhieuMuonSach.Show(btnPhieuMuonSach, 0, btnPhieuMuonSach.Height)
	End Sub

	Private Sub LậpPhiếuMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuMượnSáchToolStripMenuItem.Click
		Dim frmLapTheMuonSach As frmLapPhieuMuonSach = New frmLapPhieuMuonSach()
		frmLapTheMuonSach.MdiParent = Me
		frmLapTheMuonSach.Show()
	End Sub

	Private Sub QuảnLíPhiếuMượnSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíPhiếuMượnSáchToolStripMenuItem.Click
		Dim frmQuanLiPhieuMuonSach As frmQuanLyPhieuMuonSach = New frmQuanLyPhieuMuonSach()
		frmQuanLyPhieuMuonSach.MdiParent = Me
		frmQuanLyPhieuMuonSach.Show()
	End Sub

	Private Sub btnPhieuTraSach_Click(sender As Object, e As EventArgs) Handles btnPhieuTraSach.Click
		cmPhieuTraSach.Show(btnPhieuTraSach, 0, btnPhieuTraSach.Height)
	End Sub

	Private Sub LậpPhiếuTrảSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuTrảSáchToolStripMenuItem.Click
		Dim frmLapPhieuTraSach As frmLapPhieuTraSach = New frmLapPhieuTraSach()
		frmLapPhieuTraSach.MdiParent = Me
		frmLapPhieuTraSach.Show()
	End Sub
End Class
