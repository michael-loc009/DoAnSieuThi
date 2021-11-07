Imports ThuVien

Public Class FrmQuanLyNhapKho

    Dim dsNhapKho As DataTable
    Dim dsNhapKhoView As DataView

    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Dim dsChiNhanh As DataTable

    Dim dsNhapKhoChiTiet As DataTable

    Dim maNhapKhoTaoMoi As Integer
    Dim maNhapKhoChinhSua As Integer

    Private Sub FrmQuanLyNhapKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsNhapKho = DuLieu.DocDuLieu("Select nk_ma, nk_ngay_tao, nk_ma_chi_nhanh, nk_xoa, cn_ma, cn_ten From NhapKho, ChiNhanh where nk_ma_chi_nhanh = cn_ma and nk_xoa = false and cn_xoa = false")

        dsNhapKhoView = New DataView(dsNhapKho)
        dsNhapKhoView.Sort = "nk_ma desc"

        Dim found_nk = dsNhapKhoView.Item(0)
        maNhapKhoTaoMoi = found_nk("nk_ma") + 1


        dtGridNhapKho.DataSource = dsNhapKhoView
        dtGridNhapKho.Columns("cn_ma").Visible = False

        dsSanPham = DuLieu.DocDuLieu("Select * from SanPham where sp_xoa = false")
        dsSanPhamView = New DataView(dsSanPham)
        dsSanPhamView.Sort = "sp_ma"
        Dim row As DataRow = dsSanPham.NewRow()
        row(0) = 0
        row(1) = "Please select"
        dsSanPham.Rows.InsertAt(row, 0)
        cb_nk_ten_san_pham.DataSource = dsSanPham
        cb_nk_ten_san_pham.DisplayMember = "sp_ten"
        cb_nk_ten_san_pham.ValueMember = "sp_ma"
        cb_nk_ten_san_pham.SelectedIndex = 0

        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        Dim row1 As DataRow = dsChiNhanh.NewRow()
        row1(0) = 0
        row1(1) = "Please select"
        dsChiNhanh.Rows.InsertAt(row1, 0)
        cb_nk_chi_nhanh.DataSource = dsChiNhanh
        cb_nk_chi_nhanh.DisplayMember = "cn_ten"
        cb_nk_chi_nhanh.ValueMember = "cn_ma"
        cb_nk_chi_nhanh.SelectedIndex = 0

        date_nk_ngay_tao.Format = DateTimePickerFormat.Custom
        date_nk_ngay_tao.CustomFormat = "dd-MM-yyyy HH:mm"
        date_from_nhap_kho.Format = DateTimePickerFormat.Custom
        date_from_nhap_kho.CustomFormat = "dd-MM-yyyy"
        date_to_nhap_kho.Format = DateTimePickerFormat.Custom
        date_to_nhap_kho.CustomFormat = "dd-MM-yyyy"
        tooltip_nk_them_sp.SetToolTip(btn_nk_them_san_pham, "Thêm sản phẩm")
        tooltip_nk_xoa_sp.SetToolTip(btn_nk_xoa_san_pham, "Bớt sản phẩm")
    End Sub

    Private Sub btn_loc_phieu_nhap_kho_Click(sender As Object, e As EventArgs) Handles btn_loc_phieu_nhap_kho.Click
        If date_from_nhap_kho.Text IsNot Nothing And date_to_nhap_kho.Text IsNot Nothing Then
            dsNhapKhoView.RowFilter = "nk_ngay_tao >= #" + date_from_nhap_kho.Value.ToString("MM/d/yyyy") +
         "# And nk_ngay_tao <= #" + date_to_nhap_kho.Value.ToString("MM/d/yyyy HH:mm") + "#"
        ElseIf date_from_nhap_kho.Text IsNot Nothing And date_to_nhap_kho.Text Is Nothing Then
            dsNhapKhoView.RowFilter = "nk_ngay_tao >= #" + date_from_nhap_kho.Value.ToString("MM/d/yyyy HH:mm") + "#"
        ElseIf date_from_nhap_kho.Text Is Nothing And date_to_nhap_kho.Text IsNot Nothing Then
            dsNhapKhoView.RowFilter = "nk_ngay_tao <= #" + date_to_nhap_kho.Value.ToString("MM/d/yyyy HH:mm") + "#"
        Else
            dsNhapKhoView.RowFilter = ""
        End If
    End Sub

    Private Sub dtGridNhapKho_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridNhapKho.CellClick
        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridNhapKho.Rows(e.RowIndex).DataBoundItem
            Dim nk As DataRow = dmv.Row
            date_nk_ngay_tao.Value = nk("nk_ngay_tao")
            cb_nk_chi_nhanh.SelectedValue = nk("nk_ma_chi_nhanh")

            If Not IsDBNull(nk("nk_ma")) Then
                DocChiTietNhapKho(nk("nk_ma"))
            End If
        End If
    End Sub

    Sub DocChiTietNhapKho(ByVal ma_nk As Int32)
        maNhapKhoChinhSua = ma_nk
        dsNhapKhoChiTiet = DuLieu.DocDuLieu($"Select a.nkct_ma, a.nkct_ma_nhap_kho, a.nkct_ma_san_pham, a.nkct_so_luong, b.sp_ten, b.sp_gia , b.sp_gia*a.nkct_so_luong as nkct_thanh_tien from NhapKhoChiTiet a, SanPham b where a.nkct_ma_nhap_kho = {ma_nk} and a.nkct_ma_san_pham = b.sp_ma and b.sp_xoa = false ")
        set_pk_dsNhapKhoChiTiet()
        dtGridChiTietXuatKho.DataSource = dsNhapKhoChiTiet
    End Sub

    Private Sub btn_nk_them_san_pham_Click(sender As Object, e As EventArgs) Handles btn_nk_them_san_pham.Click
        Dim min As Integer = 0

        Dim found_sp As DataRowView = tim_gia_sp()
        If found_sp IsNot Nothing And cb_nk_ten_san_pham.SelectedIndex > 0 Then
            min = found_sp("sp_so_luong_toi_thieu")
        End If

        If cb_nk_ten_san_pham.SelectedIndex > 0 And num_nk_sl_san_pham.Value > 0 And num_nk_sl_san_pham.Value >= min Then
            Dim nkExists As Boolean = True
            If dsNhapKhoChiTiet Is Nothing Then
                khoi_tao_dsNhapKhoChiTiet()
                set_pk_dsNhapKhoChiTiet()
                nkExists = False
            End If

            Dim nkct_found As DataRow = tim_nkct_by_sp()
            If nkct_found IsNot Nothing Then
                nkct_found("nkct_so_luong") += num_nk_sl_san_pham.Value
                Dim giaMoi As Integer = Convert.ToInt32(num_nk_gia_san_pham.Text)
                Dim soluongMoi As Integer = Convert.ToInt32(nkct_found("nkct_so_luong"))
                nkct_found("nkct_thanh_tien") = giaMoi * soluongMoi
            Else
                Dim nkct As DataRow = dsNhapKhoChiTiet.NewRow()
                nkct("nkct_ma_san_pham") = Convert.ToInt32(cb_nk_ten_san_pham.SelectedValue)
                nkct("nkct_so_luong") = num_nk_sl_san_pham.Value
                nkct("sp_ten") = cb_nk_ten_san_pham.GetItemText(cb_nk_ten_san_pham.SelectedItem)
                nkct("sp_gia") = num_nk_gia_san_pham.Text
                Dim gia As Integer = Convert.ToInt32(num_nk_gia_san_pham.Text)
                Dim soluong As Integer = Convert.ToInt32(num_nk_sl_san_pham.Value)
                nkct("nkct_thanh_tien") = gia * soluong

                If nkExists And maNhapKhoChinhSua > 0 Then
                    nkct("nkct_ma_nhap_kho") = maNhapKhoChinhSua
                Else
                    nkct("nkct_ma_nhap_kho") = maNhapKhoTaoMoi
                End If

                dsNhapKhoChiTiet.Rows.Add(nkct)
            End If

            dtGridChiTietXuatKho.DataSource = dsNhapKhoChiTiet
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và nhập số lượng nhập kho", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_nk_xoa_san_pham_Click(sender As Object, e As EventArgs) Handles btn_nk_xoa_san_pham.Click
        If cb_nk_ten_san_pham.SelectedIndex > 0 And num_nk_sl_san_pham.Value > 0 And dsNhapKhoChiTiet IsNot Nothing Then
            Dim nkct_found As DataRow = tim_nkct_by_sp()
            If nkct_found IsNot Nothing Then
                nkct_found("nkct_so_luong") -= num_nk_sl_san_pham.Value

                If nkct_found("nkct_so_luong") <= 0 Then
                    Dim removed_nkct As DataRow = dsNhapKhoChiTiet.Rows.Find(cb_nk_ten_san_pham.SelectedValue)

                    If removed_nkct IsNot Nothing Then
                        BindingContext(dsNhapKhoChiTiet).RemoveAt(dsNhapKhoChiTiet.Rows.IndexOf(removed_nkct))
                        BindingContext(dsNhapKhoChiTiet).EndCurrentEdit()
                    End If
                Else
                    Dim giaMoi As Integer = Convert.ToInt32(num_nk_gia_san_pham.Text)
                    Dim soluongMoi As Integer = Convert.ToInt32(nkct_found("nkct_so_luong"))
                    nkct_found("nkct_thanh_tien") = giaMoi * soluongMoi
                End If

                dtGridChiTietXuatKho.DataSource = dsNhapKhoChiTiet
            End If
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và nhập số lượng bớt", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_nk_them_Click(sender As Object, e As EventArgs) Handles btn_nk_them.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then

            Dim nk As DataRow = dsNhapKho.NewRow()

            nk("nk_ngay_tao") = date_nk_ngay_tao.Value
            nk("nk_ma_chi_nhanh") = cb_nk_chi_nhanh.SelectedValue
            nk("nk_xoa") = False
            nk("cn_ten") = cb_nk_chi_nhanh.GetItemText(cb_nk_chi_nhanh.SelectedItem)

            dsNhapKho.Rows.Add(nk)
            DuLieu.GhiDuLieu("NhapKho", dsNhapKho)

            DuLieu.GhiDuLieu("NhapKhoChiTiet", dsNhapKhoChiTiet)

            maNhapKhoTaoMoi += 1

        End If
    End Sub

    Private Sub btn_nk_sua_Click(sender As Object, e As EventArgs) Handles btn_nk_sua.Click
        If dtGridNhapKho.SelectedCells.Count() > 0 And ValidateChildren(ValidationConstraints.Enabled) Then

            Dim dmv As DataRowView = dtGridNhapKho.Rows(dtGridNhapKho.SelectedCells(0).RowIndex).DataBoundItem
            Dim nk As DataRow = dmv.Row
            nk("nk_ma_chi_nhanh") = cb_nk_chi_nhanh.SelectedValue
            nk("cn_ten") = cb_nk_chi_nhanh.GetItemText(cb_nk_chi_nhanh.SelectedItem)

            DuLieu.GhiDuLieu("NhapKho", dsNhapKho)
            DuLieu.GhiDuLieu("NhapKhoChiTiet", dsNhapKhoChiTiet)
            dsNhapKhoChiTiet.AcceptChanges()
        End If
    End Sub

    Private Sub btn_nk_xoa_Click(sender As Object, e As EventArgs) Handles btn_nk_xoa.Click
        If dtGridNhapKho.SelectedCells.Count() > 0 And ThuVien.ShowDialog("Bạn có chắc muốn xóa phiếu nhập kho này không?", "Thông báo", MessageBoxIcon.Warning) = True Then
            Dim dmv As DataRowView = dtGridNhapKho.Rows(dtGridNhapKho.SelectedCells(0).RowIndex).DataBoundItem
            Dim nk As DataRow = dmv.Row
            nk("nk_xoa") = True

            DuLieu.GhiDuLieu("NhapKho", dsNhapKho)
            dsNhapKho.Rows.Remove(nk)
        End If
    End Sub

    Private Sub cb_nk_ten_san_pham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_nk_ten_san_pham.SelectedIndexChanged
        If cb_nk_ten_san_pham.SelectedIndex > 0 Then
            Dim found_sp As DataRowView = tim_gia_sp()
            num_nk_gia_san_pham.Text = found_sp("sp_gia")
        End If
    End Sub

    Private Function tim_gia_sp() As DataRowView
        Dim sp_index = dsSanPhamView.Find(cb_nk_ten_san_pham.SelectedValue)
        Dim found_sp = dsSanPhamView.Item(sp_index)
        Return found_sp
    End Function

    Private Function tim_nkct_by_sp() As DataRow
        Dim nkct As DataRow = dsNhapKhoChiTiet.Rows.Find(cb_nk_ten_san_pham.SelectedValue)
        Return nkct
    End Function

    Private Sub set_pk_dsNhapKhoChiTiet()
        Dim primaryKey(1) As DataColumn
        primaryKey(0) = dsNhapKhoChiTiet.Columns("nkct_ma_san_pham")
        dsNhapKhoChiTiet.PrimaryKey = primaryKey
    End Sub

    Private Sub khoi_tao_dsNhapKhoChiTiet()
        dsNhapKhoChiTiet = New DataTable
        dsNhapKhoChiTiet.Columns.Add("nkct_ma")
        dsNhapKhoChiTiet.Columns.Add("nkct_ma_nhap_kho")
        dsNhapKhoChiTiet.Columns.Add("nkct_ma_san_pham")
        dsNhapKhoChiTiet.Columns.Add("nkct_so_luong")
        dsNhapKhoChiTiet.Columns.Add("sp_ten")
        dsNhapKhoChiTiet.Columns.Add("sp_gia")
        dsNhapKhoChiTiet.Columns.Add("nkct_thanh_tien")
    End Sub

    Private Sub cb_nk_chi_nhanh_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_nk_chi_nhanh.Validating
        ThuVien.ValidateInput(cb_nk_chi_nhanh, e, err_provider_nk_cn, "", "Vui lòng chọn chi nhánh")
    End Sub

    Private Sub cb_nk_ten_san_pham_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_nk_ten_san_pham.Validating
        ThuVien.ValidateInput(cb_nk_ten_san_pham, e, err_provider_nk_ten_sp, "", "Vui lòng chọn sản phẩm")
    End Sub

    Private Sub num_nk_sl_san_pham_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles num_nk_sl_san_pham.Validating
        Dim found_sp As DataRowView = tim_gia_sp()
        Dim min As String = "0"
        If found_sp IsNot Nothing And cb_nk_ten_san_pham.SelectedIndex > 0 Then
            min = found_sp("sp_so_luong_toi_thieu")
        End If

        ThuVien.ValidateInput(num_nk_sl_san_pham, e, err_provider_nk_sl_sp, min, $"Số lượng sản phẩm phải lớn hơn {min}")
    End Sub

    Private Sub dtGridChiTietXuatKho_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtGridChiTietXuatKho.Validating
        ThuVien.ValidateInput(dtGridChiTietXuatKho, e, err_provider_nkct, "", "Vui lòng thêm tối thiểu sản phẩm trong đơn nhập kho")
    End Sub
End Class