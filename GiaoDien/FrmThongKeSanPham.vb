Imports ThuVien

Public Class FrmThongKeSanPham

    Dim TKSanPhamTheoNgay As DataTable
    Dim TKSanPhamTheoNgayView As DataView

    Dim TKSanPhamTheoThang As DataTable
    Dim TKSanPhamTheoThangView As DataView


    Private Sub FrmThongKeSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TKSanPhamTheoNgay = DuLieu.DocDuLieu("SELECT sum(b.dhct_so_luong) AS sl_sp_ban, format(c.dh_ngay, 'MM/dd/yyyy') AS dh_ngay_tao FROM DonHangChiTiet AS b INNER JOIN DonHang AS c ON c.dh_ma = b.dhct_ma_don_hang WHERE c.dh_trang_thai <> 200 GROUP BY format(c.dh_ngay, 'MM/dd/yyyy');")
        TKSanPhamTheoNgayView = New DataView(TKSanPhamTheoNgay)
        dtGrid_tk_sp_theo_ngay.DataSource = TKSanPhamTheoNgayView

        date_tk_sp_theo_ngay_from.Format = DateTimePickerFormat.Custom
        date_tk_sp_theo_ngay_from.CustomFormat = "MM/dd/yyyy"
        date_tk_sp_theo_ngay_to.Format = DateTimePickerFormat.Custom
        date_tk_sp_theo_ngay_to.CustomFormat = "MM/dd/yyyy"

        TKSanPhamTheoThang = DuLieu.DocDuLieu("SELECT sum(b.dhct_so_luong) AS sl_sp_ban, format(c.dh_ngay, 'MM/yyyy') AS dh_ngay_tao FROM DonHangChiTiet AS b INNER JOIN DonHang AS c ON c.dh_ma = b.dhct_ma_don_hang WHERE c.dh_trang_thai <> 200 GROUP BY format(c.dh_ngay, 'MM/yyyy');")
        TKSanPhamTheoThangView = New DataView(TKSanPhamTheoThang)
        dtGrid_tk_sp_theo_thang.DataSource = TKSanPhamTheoThangView

        date_tk_sp_theo_thang_from.Format = DateTimePickerFormat.Custom
        date_tk_sp_theo_thang_from.CustomFormat = "MM/yyyy"
        date_tk_sp_theo_thang_from.ShowUpDown = True
        date_tk_sp_theo_thang_to.Format = DateTimePickerFormat.Custom
        date_tk_sp_theo_thang_to.CustomFormat = "MM/yyyy"
        date_tk_sp_theo_thang_to.ShowUpDown = True
    End Sub

    Private Sub btn_tk_sp_loc_theo_ngay_Click(sender As Object, e As EventArgs) Handles btn_tk_sp_loc_theo_ngay.Click
        If date_tk_sp_theo_ngay_from.Text IsNot Nothing And date_tk_sp_theo_ngay_to.Text IsNot Nothing Then
            TKSanPhamTheoNgayView.RowFilter = "dh_ngay_tao >= #" + date_tk_sp_theo_ngay_from.Value.ToString("MM/dd/yyyy") +
         "# And dh_ngay_tao <= #" + date_tk_sp_theo_ngay_to.Value.ToString("MM/dd/yyyy") + "#"
        ElseIf date_tk_sp_theo_ngay_from.Text IsNot Nothing And date_tk_sp_theo_ngay_to.Text Is Nothing Then
            TKSanPhamTheoNgayView.RowFilter = "dh_ngay_tao >= #" + date_tk_sp_theo_ngay_from.Value.ToString("MM/dd/yyyy") + "#"
        ElseIf date_tk_sp_theo_ngay_from.Text Is Nothing And date_tk_sp_theo_ngay_to.Text IsNot Nothing Then
            TKSanPhamTheoNgayView.RowFilter = "dh_ngay_tao <= #" + date_tk_sp_theo_ngay_to.Value.ToString("MM/dd/yyyy") + "#"
        Else
            TKSanPhamTheoNgayView.RowFilter = ""
        End If
    End Sub

    Private Sub btn_tk_sp_loc_theo_thang_Click(sender As Object, e As EventArgs) Handles btn_tk_sp_loc_theo_thang.Click
        If date_tk_sp_theo_thang_from.Text IsNot Nothing And date_tk_sp_theo_thang_to.Text IsNot Nothing Then
            TKSanPhamTheoThangView.RowFilter = "dh_ngay_tao >= #" + date_tk_sp_theo_thang_from.Value.ToString("MM/yyyy") +
         "# And dh_ngay_tao <= #" + date_tk_sp_theo_thang_to.Value.ToString("MM/yyyy") + "#"
        ElseIf date_tk_sp_theo_thang_from.Text IsNot Nothing And date_tk_sp_theo_thang_to.Text Is Nothing Then
            TKSanPhamTheoThangView.RowFilter = "dh_ngay_tao >= #" + date_tk_sp_theo_thang_from.Value.ToString("MM/yyyy") + "#"
        ElseIf date_tk_sp_theo_thang_from.Text Is Nothing And date_tk_sp_theo_thang_to.Text IsNot Nothing Then
            TKSanPhamTheoThangView.RowFilter = "dh_ngay_tao <= #" + date_tk_sp_theo_thang_to.Value.ToString("MM/yyyy") + "#"
        Else
            TKSanPhamTheoThangView.RowFilter = ""
        End If
    End Sub
End Class