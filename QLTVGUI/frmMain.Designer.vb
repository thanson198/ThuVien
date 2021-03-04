<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmHoSoDocGia = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmLoạiĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmTácGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHoSoDocGia = New MetroFramework.Controls.MetroButton()
        Me.cmQuanLi = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ThemSachToolTrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmThểLoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýThểLoạiSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuanLi = New MetroFramework.Controls.MetroButton()
        Me.cmQuyDinh = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.QuyĐịnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuyDinh = New MetroFramework.Controls.MetroButton()
        Me.cmBaoCao = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoThốngKêSáchTrảTrểToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBaoCao = New MetroFramework.Controls.MetroButton()
        Me.cmPhieuMuonSach = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.LậpPhiếuMượnSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíPhiếuMượnSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPhieuMuonSach = New MetroFramework.Controls.MetroButton()
        Me.cmPhieuTraSach = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.LậpPhiếuTrảSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPhieuTraSach = New MetroFramework.Controls.MetroButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmHoSoDocGia.SuspendLayout()
        Me.cmQuanLi.SuspendLayout()
        Me.cmQuyDinh.SuspendLayout()
        Me.cmBaoCao.SuspendLayout()
        Me.cmPhieuMuonSach.SuspendLayout()
        Me.cmPhieuTraSach.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmHoSoDocGia
        '
        Me.cmHoSoDocGia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmHoSoDocGia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.ThêmLoạiĐộcGiảToolStripMenuItem, Me.QuảnLíĐộcGiảToolStripMenuItem, Me.ThêmTácGiảToolStripMenuItem})
        Me.cmHoSoDocGia.Name = "MetroContextMenu1"
        Me.cmHoSoDocGia.Size = New System.Drawing.Size(180, 114)
        Me.cmHoSoDocGia.Text = "Hồ sơ độc giả"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.QuảnLýToolStripMenuItem.Text = "Thêm loại độc giả "
        '
        'QuảnLíToolStripMenuItem
        '
        Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
        Me.QuảnLíToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.QuảnLíToolStripMenuItem.Text = "Quản lí loại độc giả "
        '
        'ThêmLoạiĐộcGiảToolStripMenuItem
        '
        Me.ThêmLoạiĐộcGiảToolStripMenuItem.Name = "ThêmLoạiĐộcGiảToolStripMenuItem"
        Me.ThêmLoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ThêmLoạiĐộcGiảToolStripMenuItem.Text = "Thêm độc giả "
        '
        'QuảnLíĐộcGiảToolStripMenuItem
        '
        Me.QuảnLíĐộcGiảToolStripMenuItem.Name = "QuảnLíĐộcGiảToolStripMenuItem"
        Me.QuảnLíĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.QuảnLíĐộcGiảToolStripMenuItem.Text = "Quản lí độc giả"
        '
        'ThêmTácGiảToolStripMenuItem
        '
        Me.ThêmTácGiảToolStripMenuItem.Name = "ThêmTácGiảToolStripMenuItem"
        Me.ThêmTácGiảToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ThêmTácGiảToolStripMenuItem.Text = "Thêm Tác Giả"
        '
        'btnHoSoDocGia
        '
        Me.btnHoSoDocGia.Location = New System.Drawing.Point(181, 76)
        Me.btnHoSoDocGia.Name = "btnHoSoDocGia"
        Me.btnHoSoDocGia.Size = New System.Drawing.Size(139, 34)
        Me.btnHoSoDocGia.TabIndex = 1
        Me.btnHoSoDocGia.Text = "Hồ sơ độc giả"
        Me.btnHoSoDocGia.UseSelectable = True
        '
        'cmQuanLi
        '
        Me.cmQuanLi.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmQuanLi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemSachToolTrip, Me.ThêmThểLoạiSáchToolStripMenuItem, Me.QuảnLýThểLoạiSáchToolStripMenuItem, Me.QuảnLýSáchToolStripMenuItem, Me.TraCứuSáchToolStripMenuItem})
        Me.cmQuanLi.Name = "cmQuanLi"
        Me.cmQuanLi.Size = New System.Drawing.Size(193, 114)
        '
        'ThemSachToolTrip
        '
        Me.ThemSachToolTrip.Name = "ThemSachToolTrip"
        Me.ThemSachToolTrip.Size = New System.Drawing.Size(192, 22)
        Me.ThemSachToolTrip.Text = "Thêm Sách"
        '
        'ThêmThểLoạiSáchToolStripMenuItem
        '
        Me.ThêmThểLoạiSáchToolStripMenuItem.Name = "ThêmThểLoạiSáchToolStripMenuItem"
        Me.ThêmThểLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ThêmThểLoạiSáchToolStripMenuItem.Text = "Thêm Thể Loại Sách"
        '
        'QuảnLýThểLoạiSáchToolStripMenuItem
        '
        Me.QuảnLýThểLoạiSáchToolStripMenuItem.Name = "QuảnLýThểLoạiSáchToolStripMenuItem"
        Me.QuảnLýThểLoạiSáchToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuảnLýThểLoạiSáchToolStripMenuItem.Text = "Quản Lý Thể Loại Sách"
        '
        'QuảnLýSáchToolStripMenuItem
        '
        Me.QuảnLýSáchToolStripMenuItem.Name = "QuảnLýSáchToolStripMenuItem"
        Me.QuảnLýSáchToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách"
        '
        'TraCứuSáchToolStripMenuItem
        '
        Me.TraCứuSáchToolStripMenuItem.Name = "TraCứuSáchToolStripMenuItem"
        Me.TraCứuSáchToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TraCứuSáchToolStripMenuItem.Text = "Tra cứu Sách"
        '
        'btnQuanLi
        '
        Me.btnQuanLi.Location = New System.Drawing.Point(295, 76)
        Me.btnQuanLi.Name = "btnQuanLi"
        Me.btnQuanLi.Size = New System.Drawing.Size(159, 34)
        Me.btnQuanLi.TabIndex = 0
        Me.btnQuanLi.Text = "Quản Lí Sách"
        Me.btnQuanLi.UseSelectable = True
        '
        'cmQuyDinh
        '
        Me.cmQuyDinh.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmQuyDinh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuyĐịnhToolStripMenuItem})
        Me.cmQuyDinh.Name = "cmQuyDinh"
        Me.cmQuyDinh.Size = New System.Drawing.Size(125, 26)
        '
        'QuyĐịnhToolStripMenuItem
        '
        Me.QuyĐịnhToolStripMenuItem.Name = "QuyĐịnhToolStripMenuItem"
        Me.QuyĐịnhToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.QuyĐịnhToolStripMenuItem.Text = "Quy Định"
        '
        'btnQuyDinh
        '
        Me.btnQuyDinh.Location = New System.Drawing.Point(30, 76)
        Me.btnQuyDinh.Name = "btnQuyDinh"
        Me.btnQuyDinh.Size = New System.Drawing.Size(154, 34)
        Me.btnQuyDinh.TabIndex = 4
        Me.btnQuyDinh.Text = "Quy Định"
        Me.btnQuyDinh.UseSelectable = True
        '
        'cmBaoCao
        '
        Me.cmBaoCao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem, Me.BáoCáoThốngKêSáchTrảTrểToolStripMenuItem})
        Me.cmBaoCao.Name = "cmBaoCao"
        Me.cmBaoCao.Size = New System.Drawing.Size(299, 48)
        '
        'BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem
        '
        Me.BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem.Name = "BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem"
        Me.BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem.Text = "Báo cáo tình hình mượn sách theo thể loại"
        '
        'BáoCáoThốngKêSáchTrảTrểToolStripMenuItem
        '
        Me.BáoCáoThốngKêSáchTrảTrểToolStripMenuItem.Name = "BáoCáoThốngKêSáchTrảTrểToolStripMenuItem"
        Me.BáoCáoThốngKêSáchTrảTrểToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.BáoCáoThốngKêSáchTrảTrểToolStripMenuItem.Text = "Báo cáo thống kê sách trả trể"
        '
        'btnBaoCao
        '
        Me.btnBaoCao.Location = New System.Drawing.Point(450, 76)
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.Size = New System.Drawing.Size(161, 34)
        Me.btnBaoCao.TabIndex = 7
        Me.btnBaoCao.Text = "Báo Cáo"
        Me.btnBaoCao.UseSelectable = True
        '
        'cmPhieuMuonSach
        '
        Me.cmPhieuMuonSach.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpPhiếuMượnSáchToolStripMenuItem, Me.QuảnLíPhiếuMượnSáchToolStripMenuItem})
        Me.cmPhieuMuonSach.Name = "cmPhieuMuonSach"
        Me.cmPhieuMuonSach.Size = New System.Drawing.Size(212, 48)
        '
        'LậpPhiếuMượnSáchToolStripMenuItem
        '
        Me.LậpPhiếuMượnSáchToolStripMenuItem.Name = "LậpPhiếuMượnSáchToolStripMenuItem"
        Me.LậpPhiếuMượnSáchToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.LậpPhiếuMượnSáchToolStripMenuItem.Text = "Lập Phiếu Mượn Sách"
        '
        'QuảnLíPhiếuMượnSáchToolStripMenuItem
        '
        Me.QuảnLíPhiếuMượnSáchToolStripMenuItem.Name = "QuảnLíPhiếuMượnSáchToolStripMenuItem"
        Me.QuảnLíPhiếuMượnSáchToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.QuảnLíPhiếuMượnSáchToolStripMenuItem.Text = "Quản Lí Phiếu Mượn Sách"
        '
        'btnPhieuMuonSach
        '
        Me.btnPhieuMuonSach.Location = New System.Drawing.Point(608, 76)
        Me.btnPhieuMuonSach.Name = "btnPhieuMuonSach"
        Me.btnPhieuMuonSach.Size = New System.Drawing.Size(154, 34)
        Me.btnPhieuMuonSach.TabIndex = 10
        Me.btnPhieuMuonSach.Text = "Phiếu Mượn Sách"
        Me.btnPhieuMuonSach.UseSelectable = True
        '
        'cmPhieuTraSach
        '
        Me.cmPhieuTraSach.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpPhiếuTrảSáchToolStripMenuItem})
        Me.cmPhieuTraSach.Name = "cmPhieuTraSach"
        Me.cmPhieuTraSach.Size = New System.Drawing.Size(173, 26)
        '
        'LậpPhiếuTrảSáchToolStripMenuItem
        '
        Me.LậpPhiếuTrảSáchToolStripMenuItem.Name = "LậpPhiếuTrảSáchToolStripMenuItem"
        Me.LậpPhiếuTrảSáchToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LậpPhiếuTrảSáchToolStripMenuItem.Text = "Lập Phiếu Trả Sách"
        '
        'btnPhieuTraSach
        '
        Me.btnPhieuTraSach.Location = New System.Drawing.Point(758, 75)
        Me.btnPhieuTraSach.Name = "btnPhieuTraSach"
        Me.btnPhieuTraSach.Size = New System.Drawing.Size(151, 35)
        Me.btnPhieuTraSach.TabIndex = 12
        Me.btnPhieuTraSach.Text = "Phiếu Trả Sách"
        Me.btnPhieuTraSach.UseSelectable = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QLTVGUI.My.Resources.Resources._11
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.btnPhieuTraSach)
        Me.Controls.Add(Me.btnPhieuMuonSach)
        Me.Controls.Add(Me.btnBaoCao)
        Me.Controls.Add(Me.btnQuyDinh)
        Me.Controls.Add(Me.btnQuanLi)
        Me.Controls.Add(Me.btnHoSoDocGia)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "QUẢN LÍ THƯ VIỆN"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmHoSoDocGia.ResumeLayout(False)
        Me.cmQuanLi.ResumeLayout(False)
        Me.cmQuyDinh.ResumeLayout(False)
        Me.cmBaoCao.ResumeLayout(False)
        Me.cmPhieuMuonSach.ResumeLayout(False)
        Me.cmPhieuTraSach.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmHoSoDocGia As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmLoạiĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnHoSoDocGia As MetroFramework.Controls.MetroButton
    Friend WithEvents cmQuanLi As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ThemSachToolTrip As ToolStripMenuItem
    Friend WithEvents btnQuanLi As MetroFramework.Controls.MetroButton
    Friend WithEvents ThêmThểLoạiSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýThểLoạiSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmQuyDinh As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents btnQuyDinh As MetroFramework.Controls.MetroButton
    Friend WithEvents QuyĐịnhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraCứuSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmTácGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmBaoCao As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents btnBaoCao As MetroFramework.Controls.MetroButton
    Friend WithEvents BáoCáoTìnhHìnhMượnSáchTheoThểLoạiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoThốngKêSáchTrảTrểToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmPhieuMuonSach As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents LậpPhiếuMượnSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíPhiếuMượnSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPhieuMuonSach As MetroFramework.Controls.MetroButton
    Friend WithEvents cmPhieuTraSach As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents btnPhieuTraSach As MetroFramework.Controls.MetroButton
    Friend WithEvents LậpPhiếuTrảSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
