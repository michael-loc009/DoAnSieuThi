Imports ThuVien

Public Class FrmQuanLyXuatKho

    Dim dsXuatKho As DataTable
    Dim dsXuatKhoView As DataView

    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Dim dsChiNhanh As DataTable

    Dim dsXuatKhoChiTiet As DataTable

    Dim maXuatKhoTaoMoi As Integer
    Dim maXuatKhoChinhSua As Integer

    Private Sub FrmQuanLyXuatKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsXuatKho = DuLieu.DocDuLieu("Select xk_ma, xk_ngay_tao, xk_ma_chi_nhanh, xk_xoa, cn_ma, cn_ten From XuatKho, ChiNhanh where xk_ma_chi_nhanh = cn_ma and xk_xoa = false and cn_xoa = false")

        dsXuatKhoView = New DataView(dsXuatKho)
        dsXuatKhoView.Sort = "xk_ma desc"

        Dim found_xk = dsXuatKhoView.Item(0)
        maXuatKhoTaoMoi = found_xk("xk_ma") + 1


        dtGridXuatKho.DataSource = dsXuatKhoView
        dtGridXuatKho.Columns("cn_ma").Visible = False

        dsSanPham = DuLieu.DocDuLieu("Select * from SanPham where sp_xoa = false")
        dsSanPhamView = New DataView(dsSanPham)
        dsSanPhamView.Sort = "sp_ma"
        Dim row As DataRow = dsSanPham.NewRow()
        row(0) = 0
        row(1) = "Please select"
        dsSanPham.Rows.InsertAt(row, 0)
        cb_xk_ten_san_pham.DataSource = dsSanPham
        cb_xk_ten_san_pham.DisplayMember = "sp_ten"
        cb_xk_ten_san_pham.ValueMember = "sp_ma"
        cb_xk_ten_san_pham.SelectedIndex = 0

        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        Dim row1 As DataRow = dsChiNhanh.NewRow()
        row1(0) = 0
        row1(1) = "Please select"
        dsChiNhanh.Rows.InsertAt(row1, 0)
        cb_xk_chi_nhanh.DataSource = dsChiNhanh
        cb_xk_chi_nhanh.DisplayMember = "cn_ten"
        cb_xk_chi_nhanh.ValueMember = "cn_ma"
        cb_xk_chi_nhanh.SelectedIndex = 0

        date_xk_ngay_tao.Format = DateTimePickerFormat.Custom
        date_xk_ngay_tao.CustomFormat = "dd-MM-yyyy HH:mm"
        date_from_xuat_kho.Format = DateTimePickerFormat.Custom
        date_from_xuat_kho.CustomFormat = "dd-MM-yyyy"
        date_to_xuat_kho.Format = DateTimePickerFormat.Custom
        date_to_xuat_kho.CustomFormat = "dd-MM-yyyy"
        tooltip_xk_them_sp.SetToolTip(btn_xk_them_san_pham, "Thêm sản phẩm")
        tooltip_xk_xoa_sp.SetToolTip(btn_xk_xoa_san_pham, "Bớt sản phẩm")
    End Sub

    Private Sub btn_xk_them_san_pham_Click(sender As Object, e As EventArgs) Handles btn_xk_them_san_pham.Click
        If cb_xk_ten_san_pham.SelectedIndex > 0 And num_xk_sl_san_pham.Value > 0 Then
            Dim xkExists As Boolean = True
            If dsXuatKhoChiTiet Is Nothing Then
                khoi_tao_dsXuatKhoChiTiet()
                set_pk_dsXuatKhoChiTiet()
                xkExists = False
            End If

            Dim xkct_found As DataRow = tim_xkct_by_sp()
            If xkct_found IsNot Nothing Then
                xkct_found("xkct_so_luong") += num_xk_sl_san_pham.Value
                Dim giaMoi As Integer = Convert.ToInt32(num_xk_gia_san_pham.Text)
                Dim soluongMoi As Integer = Convert.ToInt32(xkct_found("xkct_so_luong"))
                xkct_found("xkct_thanh_tien") = giaMoi * soluongMoi
            Else
                Dim xkct As DataRow = dsXuatKhoChiTiet.NewRow()
                xkct("xkct_ma_san_pham") = Convert.ToInt32(cb_xk_ten_san_pham.SelectedValue)
                xkct("xkct_so_luong") = num_xk_sl_san_pham.Value
                xkct("sp_ten") = cb_xk_ten_san_pham.GetItemText(cb_xk_ten_san_pham.SelectedItem)
                xkct("sp_gia") = num_xk_gia_san_pham.Text
                Dim gia As Integer = Convert.ToInt32(num_xk_gia_san_pham.Text)
                Dim soluong As Integer = Convert.ToInt32(num_xk_sl_san_pham.Value)
                xkct("xkct_thanh_tien") = gia * soluong

                If xkExists And maXuatKhoChinhSua > 0 Then
                    xkct("xkct_ma_xuat_kho") = maXuatKhoChinhSua
                Else
                    xkct("xkct_ma_xuat_kho") = maXuatKhoTaoMoi
                End If

                dsXuatKhoChiTiet.Rows.Add(xkct)
            End If

            dtGridChiTietXuatKho.DataSource = dsXuatKhoChiTiet
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và nhập số lượng nhập kho", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_xk_xoa_san_pham_Click(sender As Object, e As EventArgs) Handles btn_xk_xoa_san_pham.Click
        If cb_xk_ten_san_pham.SelectedIndex > 0 And num_xk_sl_san_pham.Value > 0 And dsXuatKhoChiTiet IsNot Nothing Then
            Dim xkct_found As DataRow = tim_xkct_by_sp()
            If xkct_found IsNot Nothing Then
                xkct_found("xkct_so_luong") -= num_xk_sl_san_pham.Value

                If xkct_found("xkct_so_luong") <= 0 Then
                    Dim removed_xkct As DataRow = dsXuatKhoChiTiet.Rows.Find(cb_xk_ten_san_pham.SelectedValue)

                    If removed_xkct IsNot Nothing Then
                        BindingContext(dsXuatKhoChiTiet).RemoveAt(dsXuatKhoChiTiet.Rows.IndexOf(removed_xkct))
                        BindingContext(dsXuatKhoChiTiet).EndCurrentEdit()
                    End If
                Else
                    Dim giaMoi As Integer = Convert.ToInt32(num_xk_gia_san_pham.Text)
                    Dim soluongMoi As Integer = Convert.ToInt32(xkct_found("xkct_so_luong"))
                    xkct_found("xkct_thanh_tien") = giaMoi * soluongMoi
                End If

                dtGridChiTietXuatKho.DataSource = dsXuatKhoChiTiet
            End If
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và nhập số lượng nhập kho", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_xk_them_Click(sender As Object, e As EventArgs) Handles btn_xk_them.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then

            Dim xk As DataRow = dsXuatKho.NewRow()

            xk("xk_ngay_tao") = date_xk_ngay_tao.Value
            xk("xk_ma_chi_nhanh") = cb_xk_chi_nhanh.SelectedValue
            xk("xk_xoa") = False
            xk("cn_ten") = cb_xk_chi_nhanh.GetItemText(cb_xk_chi_nhanh.SelectedItem)

            dsXuatKho.Rows.Add(xk)
            DuLieu.GhiDuLieu("XuatKho", dsXuatKho)

            DuLieu.GhiDuLieu("XuatKhoChiTiet", dsXuatKhoChiTiet)

            maXuatKhoTaoMoi += 1

        End If
    End Sub

    Private Sub btn_xk_sua_Click(sender As Object, e As EventArgs) Handles btn_xk_sua.Click
        If dtGridXuatKho.SelectedCells.Count() > 0 And ValidateChildren(ValidationConstraints.Enabled) Then

            Dim dmv As DataRowView = dtGridXuatKho.Rows(dtGridXuatKho.SelectedCells(0).RowIndex).DataBoundItem
            Dim xk As DataRow = dmv.Row
            xk("xk_ma_chi_nhanh") = cb_xk_chi_nhanh.SelectedValue
            xk("cn_ten") = cb_xk_chi_nhanh.GetItemText(cb_xk_chi_nhanh.SelectedItem)

            DuLieu.GhiDuLieu("XuatKho", dsXuatKho)
            DuLieu.GhiDuLieu("XuatKhoChiTiet", dsXuatKhoChiTiet)
            dsXuatKhoChiTiet.AcceptChanges()
        End If
    End Sub

    Private Sub btn_xk_xoa_Click(sender As Object, e As EventArgs) Handles btn_xk_xoa.Click
        If dtGridXuatKho.SelectedCells.Count() > 0 And ThuVien.ShowDialog("Bạn có chắc muốn xóa phiếu xuất kho này không?", "Thông báo", MessageBoxIcon.Warning) = True Then
            Dim dmv As DataRowView = dtGridXuatKho.Rows(dtGridXuatKho.SelectedCells(0).RowIndex).DataBoundItem
            Dim xk As DataRow = dmv.Row
            xk("xk_xoa") = True

            DuLieu.GhiDuLieu("XuatKho", dsXuatKho)
            dsXuatKho.Rows.Remove(xk)
        End If
    End Sub

    Private Sub btn_loc_phieu_xuat_kho_Click(sender As Object, e As EventArgs) Handles btn_loc_phieu_xuat_kho.Click
        If date_from_xuat_kho.Text IsNot Nothing And date_to_xuat_kho.Text IsNot Nothing Then
            dsXuatKhoView.RowFilter = "xk_ngay_tao >= #" + date_from_xuat_kho.Value.ToString("MM/d/yyyy") +
         "# And xk_ngay_tao <= #" + date_to_xuat_kho.Value.ToString("MM/d/yyyy") + "#"
        ElseIf date_from_xuat_kho.Text IsNot Nothing And date_to_xuat_kho.Text Is Nothing Then
            dsXuatKhoView.RowFilter = "xk_ngay_tao >= #" + date_from_xuat_kho.Value.ToString("MM/d/yyyy") + "#"
        ElseIf date_from_xuat_kho.Text Is Nothing And date_to_xuat_kho.Text IsNot Nothing Then
            dsXuatKhoView.RowFilter = "xk_ngay_tao <= #" + date_to_xuat_kho.Value.ToString("MM/d/yyyy") + "#"
        Else
            dsXuatKhoView.RowFilter = ""
        End If
    End Sub

    Private Sub dtGridXuatKho_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridXuatKho.CellClick
        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridXuatKho.Rows(e.RowIndex).DataBoundItem
            Dim xk As DataRow = dmv.Row
            date_xk_ngay_tao.Value = xk("xk_ngay_tao")
            cb_xk_chi_nhanh.SelectedValue = xk("xk_ma_chi_nhanh")

            If Not IsDBNull(xk("xk_ma")) Then
                DocChiTietXuatKho(xk("xk_ma"))
            End If
        End If
    End Sub

    Private Sub cb_xk_ten_san_pham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_xk_ten_san_pham.SelectedIndexChanged
        If cb_xk_ten_san_pham.SelectedIndex > 0 Then
            Dim found_sp As DataRowView = tim_gia_sp()
            num_xk_gia_san_pham.Text = found_sp("sp_gia")
        End If
    End Sub

    Sub DocChiTietXuatKho(ByVal ma_xk As Int32)
        maXuatKhoChinhSua = ma_xk
        dsXuatKhoChiTiet = DuLieu.DocDuLieu($"Select a.xkct_ma, a.xkct_ma_xuat_kho, a.xkct_ma_san_pham, a.xkct_so_luong, b.sp_ten, b.sp_gia , b.sp_gia*a.xkct_so_luong as xkct_thanh_tien from XuatKhoChiTiet a, SanPham b where a.xkct_ma_xuat_kho = {ma_xk} and a.xkct_ma_san_pham = b.sp_ma and b.sp_xoa = false")
        set_pk_dsXuatKhoChiTiet()
        dtGridChiTietXuatKho.DataSource = dsXuatKhoChiTiet
    End Sub

    Private Sub set_pk_dsXuatKhoChiTiet()
        Dim primaryKey(1) As DataColumn
        primaryKey(0) = dsXuatKhoChiTiet.Columns("xkct_ma_san_pham")
        dsXuatKhoChiTiet.PrimaryKey = primaryKey
    End Sub

    Private Function tim_xkct_by_sp() As DataRow
        Dim xkct As DataRow = dsXuatKhoChiTiet.Rows.Find(cb_xk_ten_san_pham.SelectedValue)
        Return xkct
    End Function

    Private Sub khoi_tao_dsXuatKhoChiTiet()
        dsXuatKhoChiTiet = New DataTable
        dsXuatKhoChiTiet.Columns.Add("xkct_ma")
        dsXuatKhoChiTiet.Columns.Add("xkct_ma_xuat_kho")
        dsXuatKhoChiTiet.Columns.Add("xkct_ma_san_pham")
        dsXuatKhoChiTiet.Columns.Add("xkct_so_luong")
        dsXuatKhoChiTiet.Columns.Add("sp_ten")
        dsXuatKhoChiTiet.Columns.Add("sp_gia")
        dsXuatKhoChiTiet.Columns.Add("xkct_thanh_tien")
    End Sub

    Private Function tim_gia_sp() As DataRowView
        Dim sp_index = dsSanPhamView.Find(cb_xk_ten_san_pham.SelectedValue)
        Dim found_sp = dsSanPhamView.Item(sp_index)
        Return found_sp
    End Function

    Private Sub cb_xk_chi_nhanh_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_xk_chi_nhanh.Validating
        ThuVien.ValidateInput(cb_xk_chi_nhanh, e, err_provider_xk_cn, "", "Vui lòng chọn chi nhánh")
    End Sub

    Private Sub cb_xk_ten_san_pham_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_xk_ten_san_pham.Validating
        ThuVien.ValidateInput(cb_xk_ten_san_pham, e, err_provider_xk_ten_sp, "", "Vui lòng chọn sản phẩm")
    End Sub

    Private Sub num_xk_sl_san_pham_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles num_xk_sl_san_pham.Validating
        ThuVien.ValidateInput(num_xk_sl_san_pham, e, err_provider_xk_sl_sp, "0", $"Số lượng sản phẩm phải lớn hơn 0")
    End Sub

    Private Sub dtGridChiTietXuatKho_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtGridChiTietXuatKho.Validating
        ThuVien.ValidateInput(dtGridChiTietXuatKho, e, err_provider_xkct, "", "Vui lòng thêm tối thiểu sản phẩm trong đơn nhập kho")
    End Sub
End Class