Public Class Index

    Public TaiKhoanDangNhap As DataRow
    Public DsQuyenCn As DataTable
    Public DsQuyen As DataTable
    Public CnMaArr As String

    Private Sub onClickThoatMenuItem(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        FrmDangNhap.Close()
        Me.Close()
    End Sub

    Private Sub onIndexFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If showExitDialog() = False Then
            e.Cancel = True
        End If
    End Sub

    Function showExitDialog() As Boolean
        Dim dialogResult As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Return dialogResult = DialogResult.Yes
    End Function

    Private Sub onClickChiNhanhMenuItem(sender As Object, e As EventArgs) Handles ChiNhánhToolStripMenuItem.Click
        Dim frmQuanLiChiNhanh As FrmQuanLyChiNhanh = New FrmQuanLyChiNhanh()
        frmQuanLiChiNhanh.MdiParent = Me
        frmQuanLiChiNhanh.WindowState = FormWindowState.Maximized
        frmQuanLiChiNhanh.Show()
    End Sub

    Private Sub onClickNguoiDungMenuItem(sender As Object, e As EventArgs) Handles NgườiDùngToolStripMenuItem.Click
        Dim frmQuanLiNguoiDung As FrmQuanLyNguoiDung = New FrmQuanLyNguoiDung()
        frmQuanLiNguoiDung.MdiParent = Me
        frmQuanLiNguoiDung.WindowState = FormWindowState.Maximized
        frmQuanLiNguoiDung.Show()
    End Sub

    Private Sub onClickSanPhamMenuItem(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        Dim frmQuanLiSanPham As FrmQuanLySanPham = New FrmQuanLySanPham()
        frmQuanLiSanPham.MdiParent = Me
        frmQuanLiSanPham.WindowState = FormWindowState.Maximized
        frmQuanLiSanPham.Show()
    End Sub

    Private Sub onClickDanhMucMenuItem(sender As Object, e As EventArgs) Handles DanhMụcToolStripMenuItem.Click
        Dim frmQuanLiDanhMuc As FrmQuanLyDanhMuc = New FrmQuanLyDanhMuc()
        frmQuanLiDanhMuc.MdiParent = Me
        frmQuanLiDanhMuc.WindowState = FormWindowState.Maximized
        frmQuanLiDanhMuc.Show()
    End Sub

    Private Sub ĐonHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐơnHàngToolStripMenuItem.Click
        Dim frmQuanLiDonHang As FrmQuanLyDonHang = New FrmQuanLyDonHang()
        frmQuanLiDonHang.MdiParent = Me
        frmQuanLiDonHang.WindowState = FormWindowState.Maximized
        frmQuanLiDonHang.Show()
    End Sub

    Private Sub onClickNhapKhoMenuItem(sender As Object, e As EventArgs) Handles NhậpKhoToolStripMenuItem.Click
        Dim frmQuanLiNhapKho As FrmQuanLyNhapKho = New FrmQuanLyNhapKho()
        frmQuanLiNhapKho.MdiParent = Me
        frmQuanLiNhapKho.WindowState = FormWindowState.Maximized
        frmQuanLiNhapKho.Show()
    End Sub

    Private Sub XuatKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtKhoToolStripMenuItem.Click
        Dim frmQuanLiXuatKho As FrmQuanLyXuatKho = New FrmQuanLyXuatKho()
        frmQuanLiXuatKho.MdiParent = Me
        frmQuanLiXuatKho.WindowState = FormWindowState.Maximized
        frmQuanLiXuatKho.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim frmQuanLiMenu As FrmQuanLyMenu = New FrmQuanLyMenu()
        frmQuanLiMenu.MdiParent = Me
        frmQuanLiMenu.WindowState = FormWindowState.Maximized
        frmQuanLiMenu.Show()
    End Sub

    Private Sub DoanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoanhThuToolStripMenuItem.Click
        Dim frmThongKeDoanhThu As FrmThongKeDoanhThu = New FrmThongKeDoanhThu()
        frmThongKeDoanhThu.MdiParent = Me
        frmThongKeDoanhThu.WindowState = FormWindowState.Maximized
        frmThongKeDoanhThu.Show()
    End Sub

    Private Sub SoLuongDonHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoLuongDHToolStripMenuItem.Click
        Dim frmThongKeDonHang As FrmThongKeDonHang = New FrmThongKeDonHang()
        frmThongKeDonHang.MdiParent = Me
        frmThongKeDonHang.WindowState = FormWindowState.Maximized
        frmThongKeDonHang.Show()
    End Sub

    Private Sub SanPhamToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SoLuongSanPhamToolStripMenuItem1.Click
        Dim frmThongKeSanPham As FrmThongKeSanPham = New FrmThongKeSanPham()
        frmThongKeSanPham.MdiParent = Me
        frmThongKeSanPham.WindowState = FormWindowState.Maximized
        frmThongKeSanPham.Show()
    End Sub

    Private Sub TienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiềnTrongNgàyToolStripMenuItem.Click
        Dim frmDonHangSan As FrmThongKeTien = New FrmThongKeTien()
        FrmThongKeTien.MdiParent = Me
        FrmThongKeTien.WindowState = FormWindowState.Maximized
        FrmThongKeTien.Show()
    End Sub

    Private Sub SoluongSanPhamNhapXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SốLượngSảnPhẩmNhậpxuấtToolStripMenuItem.Click
        Dim frmThongKeXuatNhapKho As FrmThongKeXuatNhapKho = New FrmThongKeXuatNhapKho()
        frmThongKeXuatNhapKho.MdiParent = Me
        frmThongKeXuatNhapKho.WindowState = FormWindowState.Maximized
        frmThongKeXuatNhapKho.Show()
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = False
        Dim frm As FrmDangNhap = New FrmDangNhap()
        Dim result As DialogResult = frm.ShowDialog()
        If result = DialogResult.Yes Then
            Dim cnArr As List(Of Integer) = New List(Of Integer)
            For Each item1 As DataRow In DsQuyenCn.Rows
                cnArr.Add(item1("tkcn_ma_chi_nhanh"))
            Next

            CnMaArr = String.Join(",", cnArr)


            For Each item As DataRow In DsQuyen.Rows
                If item("qcn_ma_chuc_nang") = 1 Then
                    ChiNhánhToolStripMenuItem.Enabled = True
                End If

                If item("qcn_ma_chuc_nang") = 2 Then
                    SảnPhẩmToolStripMenuItem.Enabled = True
                End If

                If item("qcn_ma_chuc_nang") = 3 Then
                    DanhMụcToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 4 Then
                    NhậpKhoToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 5 Then
                    XuấtKhoToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 6 Then
                    NgườiDùngToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 7 Then
                    ĐơnHàngToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 10 Then
                    TiềnTrongNgàyToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 11 Then
                    DoanhThuToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 12 Then
                    SoLuongSanPhamToolStripMenuItem1.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 13 Then
                    SốLượngSảnPhẩmNhậpxuấtToolStripMenuItem.Enabled = True
                End If
                If item("qcn_ma_chuc_nang") = 14 Then
                    SoLuongDHToolStripMenuItem.Enabled = True
                End If

                If item("qcn_ma_chuc_nang") = 15 Then
                    MenuToolStripMenuItem.Enabled = True
                End If
            Next

            Me.Visible = True
        Else
            Me.Close()
        End If




    End Sub
End Class