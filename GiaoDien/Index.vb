﻿Public Class Index
    Private Sub onClickThoatMenuItem(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
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

    Private Sub ĐơnHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐơnHàngToolStripMenuItem.Click
        Dim frmQuanLiDonHang As FrmQuanLyDonHang = New FrmQuanLyDonHang()
        frmQuanLiDonHang.MdiParent = Me
        frmQuanLiDonHang.WindowState = FormWindowState.Maximized
        frmQuanLiDonHang.Show()
    End Sub
End Class