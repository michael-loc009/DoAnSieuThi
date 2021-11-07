Imports ThuVien

Public Class FrmBanHang

    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Dim dsDonHangChiTiet As DataTable

    Dim selected_sp_index As Integer
    Dim maDonHangTaoMoi As Integer = 0
    Dim maDonHangChinhSua As Integer

    Dim dsChiNhanh As DataTable

    Private Sub FrmBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsSanPham = DuLieu.DocDuLieu("SELECT c.ma_san_pham, c.sp_ten, switch(d.ma_san_pham is not null, c.sl_nhap_kho - d.sl_xuat_kho, d.ma_san_pham is null, c.sl_nhap_kho) AS sl_ton_kho, c.sp_gia, c.nk_ma_chi_nhanh
FROM (SELECT a.nkct_ma_san_pham AS ma_san_pham, nk.nk_ma_chi_nhanh, b.sp_ten, b.sp_gia , sum(nkct_so_luong) AS sl_nhap_kho FROM (NhapKhoChiTiet AS a INNER JOIN SanPham AS b ON a.nkct_ma_san_pham = b.sp_ma) INNER JOIN NhapKho AS nk ON nk.nk_ma = a.nkct_ma_nhap_kho WHERE nk.nk_xoa = false GROUP BY nkct_ma_san_pham, b.sp_ten,b.sp_gia,nk.nk_ma_chi_nhanh)  AS c LEFT JOIN (SELECT a.xkct_ma_san_pham AS ma_san_pham, b.sp_ten, sum(xkct_so_luong) AS sl_xuat_kho FROM (XuatKhoChiTiet AS a INNER JOIN SanPham AS b ON a.xkct_ma_san_pham = b.sp_ma) INNER JOIN XuatKho AS xk ON xk.xk_ma = a.xkct_ma_xuat_kho WHERE xk.xk_xoa = false GROUP BY xkct_ma_san_pham, b.sp_ten)  AS d ON c.ma_san_pham = d.ma_san_pham where c.sl_nhap_kho - d.sl_xuat_kho >0")

        dsSanPhamView = New DataView(dsSanPham)
        dtGridSanPham.DataSource = dsSanPhamView

        Dim dsDonHang As DataTable = DuLieu.DocDuLieu("SELECT top 1 dh_ma from DonHang order by dh_ma desc")
        If dsDonHang.Rows.Count > 0 Then
            Dim found_dh = dsDonHang.Rows(0)
            maDonHangTaoMoi = found_dh("dh_ma") + 1
        End If



        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        Dim row As DataRow = dsChiNhanh.NewRow()
        row(0) = 0
        row(1) = "Please select"
        dsChiNhanh.Rows.InsertAt(row, 0)

        cb_dh_cn.DataSource = dsChiNhanh
        cb_dh_cn.DisplayMember = "cn_ten"
        cb_dh_cn.ValueMember = "cn_ma"
        cb_dh_cn.SelectedIndex = 0

        txt_dh_tong_sp.Text = "0"
        txt_dh_tong_tien.Text = "0"
        txt_dh_chiet_khau.Text = "0"
        txt_dh_thanh_tien.Text = "0"

        dsSanPhamView.RowFilter = $"nk_ma_chi_nhanh = 0"
    End Sub

    Private Sub cb_dh_cn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dh_cn.SelectedIndexChanged
        If cb_dh_cn.SelectedIndex > 0 Then
            dsSanPhamView.RowFilter = $"nk_ma_chi_nhanh = {cb_dh_cn.SelectedValue}"
        End If
    End Sub

    Private Sub txt_dh_tim_sp_TextChanged(sender As Object, e As EventArgs) Handles txt_dh_tim_sp.TextChanged
        If cb_dh_cn.SelectedIndex > 0 And txt_dh_tim_sp.Text <> "" Then
            dsSanPhamView.RowFilter = $"sp_ten like '%{txt_dh_tim_sp.Text}%' and nk_ma_chi_nhanh = {cb_dh_cn.SelectedValue}"
        ElseIf txt_dh_tim_sp.Text <> "" Then
            dsSanPhamView.RowFilter = $"sp_ten like '%{txt_dh_tim_sp.Text}%'"
        Else
            dsSanPhamView.RowFilter = $"nk_ma_chi_nhanh = {cb_dh_cn.SelectedValue}"
        End If
    End Sub

    Private Sub btn_dh_them_san_pham_Click(sender As Object, e As EventArgs) Handles btn_dh_them_san_pham.Click
        If selected_sp_index >= 0 And num_dh_sl_san_pham.Value > 0 Then
            Dim xkExists As Boolean = True
            If dsDonHangChiTiet Is Nothing Then
                khoi_tao_dsDonHangChiTiet()
                set_pk_dsDonHangChiTiet()
                xkExists = False
            End If

            Dim dmv As DataRowView = dtGridSanPham.Rows(selected_sp_index).DataBoundItem
            Dim selected_sp As DataRow = dmv.Row

            Dim dhct_found As DataRow = tim_dhct_by_sp(selected_sp("ma_san_pham"))
            If dhct_found IsNot Nothing Then
                If dhct_found("dhct_so_luong") + num_dh_sl_san_pham.Value > selected_sp("sl_ton_kho") Then
                    ThuVien.ShowErrorDialog("Số lượng mua sản phẩm vượt quá số lượng tồn kho của sản phẩm", "Thông báo", MessageBoxIcon.Error)
                Else
                    dhct_found("dhct_so_luong") += num_dh_sl_san_pham.Value
                    Dim giaMoi As Integer = selected_sp("sp_gia")
                    Dim soluongMoi As Integer = Convert.ToInt32(dhct_found("dhct_so_luong"))
                    dhct_found("dhct_thanh_tien") = giaMoi * soluongMoi

                    cap_nhap_gt_dh("them", num_dh_sl_san_pham.Value, num_dh_sl_san_pham.Value * giaMoi)
                End If
            Else
                Dim dhct As DataRow = dsDonHangChiTiet.NewRow()
                dhct("dhct_ma_san_pham") = Convert.ToInt32(selected_sp("ma_san_pham"))
                dhct("dhct_so_luong") = num_dh_sl_san_pham.Value
                dhct("sp_ten") = selected_sp("sp_ten")
                dhct("dhct_gia_ban") = selected_sp("sp_gia")
                Dim gia As Integer = selected_sp("sp_gia")
                Dim soluong As Integer = num_dh_sl_san_pham.Value
                dhct("dhct_thanh_tien") = gia * soluong

                If xkExists And maDonHangChinhSua > 0 Then
                    dhct("dhct_ma_don_hang") = maDonHangChinhSua
                Else
                    dhct("dhct_ma_don_hang") = maDonHangTaoMoi
                End If

                If dhct("dhct_so_luong") > selected_sp("sl_ton_kho") Then
                    ThuVien.ShowErrorDialog("Số lượng mua sản phẩm vượt quá số lượng tồn kho của sản phẩm", "Thông báo", MessageBoxIcon.Error)
                Else
                    cap_nhap_gt_dh("them", num_dh_sl_san_pham.Value, num_dh_sl_san_pham.Value * gia)
                    dsDonHangChiTiet.Rows.Add(dhct)
                End If
            End If

            dtGridDonHangChiTiet.DataSource = dsDonHangChiTiet
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và nhập số lượng thêm", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_dh_xoa_san_pham_Click(sender As Object, e As EventArgs) Handles btn_dh_xoa_san_pham.Click
        If selected_sp_index >= 0 And num_dh_sl_san_pham.Value > 0 And dsDonHangChiTiet IsNot Nothing Then
            Dim dmv As DataRowView = dtGridSanPham.Rows(selected_sp_index).DataBoundItem
            Dim selected_sp As DataRow = dmv.Row

            Dim dhct_found As DataRow = tim_dhct_by_sp(selected_sp("ma_san_pham"))
            If dhct_found IsNot Nothing Then
                dhct_found("dhct_so_luong") -= num_dh_sl_san_pham.Value

                cap_nhap_gt_dh("bot", num_dh_sl_san_pham.Value, num_dh_sl_san_pham.Value * selected_sp("sp_gia"))

                If dhct_found("dhct_so_luong") <= 0 Then
                    Dim removed_dhct As DataRow = dsDonHangChiTiet.Rows.Find(selected_sp("ma_san_pham"))

                    If removed_dhct IsNot Nothing Then
                        BindingContext(dsDonHangChiTiet).RemoveAt(dsDonHangChiTiet.Rows.IndexOf(removed_dhct))
                        BindingContext(dsDonHangChiTiet).EndCurrentEdit()
                    End If
                Else
                    Dim giaMoi As Integer = Convert.ToInt32(selected_sp("sp_gia"))
                    Dim soluongMoi As Integer = Convert.ToInt32(dhct_found("dhct_so_luong"))
                    dhct_found("dhct_thanh_tien") = giaMoi * soluongMoi
                End If

                dtGridDonHangChiTiet.DataSource = dsDonHangChiTiet
            End If
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và số lượng bớt", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dtGridSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridSanPham.CellClick
        If e.RowIndex >= 0 Then
            selected_sp_index = e.RowIndex
        End If
    End Sub

    Private Sub khoi_tao_dsDonHangChiTiet()
        dsDonHangChiTiet = New DataTable
        dsDonHangChiTiet.Columns.Add("dhct_ma")
        dsDonHangChiTiet.Columns.Add("dhct_ma_don_hang")
        dsDonHangChiTiet.Columns.Add("dhct_ma_san_pham")
        dsDonHangChiTiet.Columns.Add("dhct_so_luong")
        dsDonHangChiTiet.Columns.Add("sp_ten")
        dsDonHangChiTiet.Columns.Add("dhct_gia_ban")
        dsDonHangChiTiet.Columns.Add("dhct_thanh_tien")
    End Sub

    Private Sub set_pk_dsDonHangChiTiet()
        Dim primaryKey(1) As DataColumn
        primaryKey(0) = dsDonHangChiTiet.Columns("dhct_ma_san_pham")
        dsDonHangChiTiet.PrimaryKey = primaryKey
    End Sub

    Private Function tim_dhct_by_sp(ma_sp As Integer) As DataRow
        Dim dhct As DataRow = dsDonHangChiTiet.Rows.Find(ma_sp)
        Return dhct
    End Function

    Private Sub cap_nhap_gt_dh(hanh_dong As String, sl_sp As Integer, sp_thanh_tien As Integer)
        Dim tong_sp As Integer = Integer.Parse(txt_dh_tong_sp.Text)
        Dim tong_tien As Integer = Integer.Parse(txt_dh_tong_tien.Text)
        Dim chietkhau As Integer = Integer.Parse(txt_dh_chiet_khau.Text)
        Dim thanh_tien As Integer = Integer.Parse(txt_dh_thanh_tien.Text)

        If hanh_dong = "them" Then
            tong_sp += sl_sp
            tong_tien += sp_thanh_tien
        Else
            tong_sp -= sl_sp
            tong_tien -= sp_thanh_tien
        End If

        thanh_tien = tong_tien - chietkhau
        txt_dh_tong_sp.Text = tong_sp
        txt_dh_tong_tien.Text = tong_tien
        txt_dh_thanh_tien.Text = thanh_tien
    End Sub


End Class