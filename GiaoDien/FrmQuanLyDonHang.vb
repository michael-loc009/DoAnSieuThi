Imports ThuVien

Public Class FrmQuanLyDonHang

    Dim dsDonHang As DataTable
    Dim dsDonHangView As DataView

    Dim dsChiNhanh As DataTable

    Dim selectedMaDonHang As Integer
    Dim selectedDh As DataRow

    Private Sub FrmQuanLyDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsDonHang = DuLieu.DocDuLieu("SELECT a.*, (a.dh_tong_tien - a.dh_tien_khuyen_mai) as thanh_tien, d.dhtt_ten, c.kh_ho_ten, b.cn_ten from ((DonHang a inner join ChiNhanh b on a.dh_ma_chi_nhanh = b.cn_ma) inner join KhachHang c on c.kh_ma = a.dh_ma_khach_hang) inner join DonHangTrangThai d on d.dhtt_ma = a.dh_trang_thai where b.cn_xoa = false")

        dsDonHangView = New DataView(dsDonHang)
        dtGridDonHang.DataSource = dsDonHangView
        dtGridDonHang.Columns("dh_trang_thai").Visible = False

        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        Dim row As DataRow = dsChiNhanh.NewRow()
        row(0) = 0
        row(1) = "Tất cả"
        dsChiNhanh.Rows.InsertAt(row, 0)

        cb_dh_cn.DataSource = dsChiNhanh
        cb_dh_cn.DisplayMember = "cn_ten"
        cb_dh_cn.ValueMember = "cn_ma"
        cb_dh_cn.SelectedIndex = 0

        date_from_don_hang.Format = DateTimePickerFormat.Custom
        date_from_don_hang.CustomFormat = "dd-MM-yyyy"
        date_to_don_hang.Format = DateTimePickerFormat.Custom
        date_to_don_hang.CustomFormat = "dd-MM-yyyy"

        dtGridDonHang.FirstDisplayedCell.Selected = False

    End Sub

    Private Sub btn_loc_don_hang_Click(sender As Object, e As EventArgs) Handles btn_loc_don_hang.Click
        Dim queryByChiNhanh As String = ""
        If cb_dh_cn.SelectedIndex > 0 Then
            queryByChiNhanh = $"dh_ma_chi_nhanh = {cb_dh_cn.SelectedValue} and "
        End If

        If date_from_don_hang.Text IsNot Nothing And date_to_don_hang.Text IsNot Nothing Then
            dsDonHangView.RowFilter = queryByChiNhanh + "dh_ngay >= #" + date_from_don_hang.Value.ToString("MM/d/yyyy") +
         "# And dh_ngay <= #" + date_to_don_hang.Value.ToString("MM/d/yyyy HH:mm") + "#"
        ElseIf date_from_don_hang.Text IsNot Nothing And date_to_don_hang.Text Is Nothing Then
            dsDonHangView.RowFilter = queryByChiNhanh + "dh_ngay >= #" + date_from_don_hang.Value.ToString("MM/d/yyyy HH:mm") + "#"
        ElseIf date_from_don_hang.Text Is Nothing And date_to_don_hang.Text IsNot Nothing Then
            dsDonHangView.RowFilter = queryByChiNhanh + "dh_ngay <= #" + date_to_don_hang.Value.ToString("MM/d/yyyy HH:mm") + "#"
        ElseIf cb_dh_cn.SelectedIndex > 0 Then
            dsDonHangView.RowFilter = $"dh_ma_chi_nhanh = {cb_dh_cn.SelectedValue}"
        Else
            dsDonHangView.RowFilter = ""
        End If
    End Sub

    Private Sub btn_dh_them_Click(sender As Object, e As EventArgs) Handles btn_dh_them.Click
        Dim frmBanHang As FrmBanHang = New FrmBanHang()
        frmBanHang.MdiParent = Index
        frmBanHang.WindowState = FormWindowState.Maximized

        frmBanHang.Show()
    End Sub

    Private Sub btn_dh_sua_Click(sender As Object, e As EventArgs) Handles btn_dh_sua.Click
        If selectedMaDonHang > 0 And selectedDh IsNot Nothing Then
            Dim frmBanHang As FrmBanHang = New FrmBanHang()
            frmBanHang.MdiParent = Index
            frmBanHang.WindowState = FormWindowState.Maximized
            frmBanHang.maDonHangChinhSua = selectedMaDonHang
            frmBanHang.selectedDh = selectedDh
            frmBanHang.Show()
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn đơn hàng cần được cập nhật", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dtGridDonHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridDonHang.CellClick
        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridDonHang.Rows(e.RowIndex).DataBoundItem
            Dim dh As DataRow = dmv.Row


            If Not IsDBNull(dh("dh_ma")) Then
                selectedDh = dh
                selectedMaDonHang = dh("dh_ma")
                DocDonHangChiTiet(dh("dh_ma"))
            End If
        End If
    End Sub

    Sub DocDonHangChiTiet(ByVal ma_danh_muc As Int32)
        Dim dsDonHangChiTiet As DataTable
        dsDonHangChiTiet = DuLieu.DocDuLieu("SELECT a.*, b.sp_ten from DonHangChiTiet a, SanPham b where a.dhct_ma_san_pham = b.sp_ma and a.dhct_ma_don_hang = " + ma_danh_muc.ToString())
        dtGridDonHangChiTiet.DataSource = dsDonHangChiTiet
    End Sub
End Class