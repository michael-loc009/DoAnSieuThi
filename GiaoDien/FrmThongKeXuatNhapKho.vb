Imports ThuVien

Public Class FrmThongKeXuatNhapKho

    Dim TKNhapKho As DataTable
    Dim TKNhapKhoView As DataView

    Dim TKXuatKho As DataTable
    Dim TKXuatKhoView As DataView

    Private Sub FrmThongKeXuatNhapKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TKNhapKho = DuLieu.DocDuLieu("SELECT sum(nkct_so_luong) AS sl_sp, format(b.nk_ngay_tao, 'MM/yyyy') AS ngay_tao FROM NhapKhoChiTiet AS a INNER JOIN NhapKho AS b ON a.nkct_ma_nhap_kho = b.nk_ma WHERE b.nk_xoa = false GROUP BY format(b.nk_ngay_tao, 'MM/yyyy')")
        TKNhapKhoView = New DataView(TKNhapKho)
        dtGrid_tk_sp_nhap_kho.DataSource = TKNhapKhoView

        date_tk_nk_from.Format = DateTimePickerFormat.Custom
        date_tk_nk_from.CustomFormat = "MM/yyyy"
        date_tk_nk_from.ShowUpDown = True
        date_tk_nk_to.Format = DateTimePickerFormat.Custom
        date_tk_nk_to.CustomFormat = "MM/yyyy"
        date_tk_nk_to.ShowUpDown = True

        TKXuatKho = DuLieu.DocDuLieu("SELECT sum(xkct_so_luong) AS sl_sp, format(b.xk_ngay_tao, 'MM/yyyy') AS ngay_tao FROM XuatKhoChiTiet AS a INNER JOIN XuatKho AS b ON a.xkct_ma_xuat_kho = b.xk_ma WHERE b.xk_xoa = false GROUP BY format(b.xk_ngay_tao, 'MM/yyyy')")
        TKXuatKhoView = New DataView(TKXuatKho)
        dtGrid_tk_xk.DataSource = TKXuatKhoView

        date_tk_xk_from.Format = DateTimePickerFormat.Custom
        date_tk_xk_from.CustomFormat = "MM/yyyy"
        date_tk_xk_from.ShowUpDown = True
        date_tk_xk_to.Format = DateTimePickerFormat.Custom
        date_tk_xk_to.CustomFormat = "MM/yyyy"
        date_tk_xk_to.ShowUpDown = True

    End Sub

    Private Sub btn_tk_nk_loc_Click(sender As Object, e As EventArgs) Handles btn_tk_nk_loc.Click
        If date_tk_nk_from.Text IsNot Nothing And date_tk_nk_to.Text IsNot Nothing Then
            TKNhapKhoView.RowFilter = "ngay_tao >= #" + date_tk_nk_from.Value.ToString("MM/yyyy") +
         "# And ngay_tao <= #" + date_tk_nk_to.Value.ToString("MM/yyyy") + "#"
        ElseIf date_tk_nk_from.Text IsNot Nothing And date_tk_nk_to.Text Is Nothing Then
            TKNhapKhoView.RowFilter = "ngay_tao >= #" + date_tk_nk_from.Value.ToString("MM/yyyy") + "#"
        ElseIf date_tk_nk_from.Text Is Nothing And date_tk_nk_to.Text IsNot Nothing Then
            TKNhapKhoView.RowFilter = "ngay_tao <= #" + date_tk_nk_to.Value.ToString("MM/yyyy") + "#"
        Else
            TKNhapKhoView.RowFilter = ""
        End If
    End Sub

    Private Sub btn_tk_xk_loc_Click(sender As Object, e As EventArgs) Handles btn_tk_xk_loc.Click
        If date_tk_xk_from.Text IsNot Nothing And date_tk_xk_to.Text IsNot Nothing Then
            TKXuatKhoView.RowFilter = "ngay_tao >= #" + date_tk_xk_from.Value.ToString("MM/yyyy") +
         "# And ngay_tao <= #" + date_tk_xk_to.Value.ToString("MM/yyyy") + "#"
        ElseIf date_tk_xk_from.Text IsNot Nothing And date_tk_xk_to.Text Is Nothing Then
            TKXuatKhoView.RowFilter = "ngay_tao >= #" + date_tk_xk_from.Value.ToString("MM/yyyy") + "#"
        ElseIf date_tk_xk_from.Text Is Nothing And date_tk_xk_to.Text IsNot Nothing Then
            TKXuatKhoView.RowFilter = "ngay_tao <= #" + date_tk_xk_to.Value.ToString("MM/yyyy") + "#"
        Else
            TKXuatKhoView.RowFilter = ""
        End If
    End Sub
End Class