Imports ThuVien

Public Class FrmBanHang

    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Dim dsDonHangChiTiet As DataTable

    Public selectedDh As DataRow

    Dim selected_sp_index As Integer = -1
    Dim selected_dhct_index As Integer = -1
    Dim maDonHangTaoMoi As Integer = 0
    Public maDonHangChinhSua As Integer

    Dim dsChiNhanh As DataTable
    Dim dsKhuyenMai As DataTable
    Dim dsKhachHang As DataTable
    Dim dsTrangThaiDonHang As DataTable

    Private Sub FrmBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_dh_tong_sp.Text = "0"
        txt_dh_tong_tien.Text = "0"
        txt_dh_chiet_khau.Text = "0"
        txt_dh_thanh_tien.Text = "0"


        dsSanPham = DuLieu.DocDuLieu("SELECT c.ma_san_pham, c.sp_ten, switch(d.ma_san_pham is not null, c.sl_nhap_kho - d.sl_xuat_kho, d.ma_san_pham is null, c.sl_nhap_kho) AS sl_ton_kho, c.sp_gia, c.nk_ma_chi_nhanh
FROM (SELECT a.nkct_ma_san_pham AS ma_san_pham, nk.nk_ma_chi_nhanh, b.sp_ten, b.sp_gia , sum(nkct_so_luong) AS sl_nhap_kho FROM (NhapKhoChiTiet AS a INNER JOIN SanPham AS b ON a.nkct_ma_san_pham = b.sp_ma) INNER JOIN NhapKho AS nk ON nk.nk_ma = a.nkct_ma_nhap_kho WHERE nk.nk_xoa = false GROUP BY nkct_ma_san_pham, b.sp_ten,b.sp_gia,nk.nk_ma_chi_nhanh)  AS c LEFT JOIN (SELECT a.xkct_ma_san_pham AS ma_san_pham, b.sp_ten, sum(xkct_so_luong) AS sl_xuat_kho FROM (XuatKhoChiTiet AS a INNER JOIN SanPham AS b ON a.xkct_ma_san_pham = b.sp_ma) INNER JOIN XuatKho AS xk ON xk.xk_ma = a.xkct_ma_xuat_kho WHERE xk.xk_xoa = false GROUP BY xkct_ma_san_pham, b.sp_ten)  AS d ON c.ma_san_pham = d.ma_san_pham where c.sl_nhap_kho - d.sl_xuat_kho >0")

        dsSanPhamView = New DataView(dsSanPham)
        dtGridSanPham.DataSource = dsSanPhamView
        dsSanPhamView.RowFilter = $"nk_ma_chi_nhanh = 0"


        If maDonHangChinhSua <= 0 Then
            Dim dsDonHang As DataTable = DuLieu.DocDuLieu("SELECT top 1 dh_ma from DonHang order by dh_ma desc")
            If dsDonHang.Rows.Count > 0 Then
                Dim found_dh = dsDonHang.Rows(0)
                maDonHangTaoMoi = found_dh("dh_ma") + 1
            End If
        Else
            dsDonHangChiTiet = ThuVien.DocDuLieu($"select a.dhct_ma, a.dhct_ma_don_hang, a.dhct_ma_san_pham, a.dhct_so_luong, a.dhct_gia_ban, a.dhct_gia_ban*a.dhct_so_luong as dhct_thanh_tien, b.sp_ten, b.sp_ma from DonHangChiTiet a, SanPham b where a.dhct_ma_san_pham = b.sp_ma and a.dhct_ma_don_hang = {maDonHangChinhSua}")
            set_pk_dsDonHangChiTiet()
            dtGridDonHangChiTiet.DataSource = dsDonHangChiTiet
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

        dsTrangThaiDonHang = DuLieu.DocDuLieu("Select * from DonHangTrangThai")
        cb_dh_trang_thai.DataSource = dsTrangThaiDonHang
        cb_dh_trang_thai.DisplayMember = "dhtt_ten"
        cb_dh_trang_thai.ValueMember = "dhtt_ma"


        doc_ds_khach_hang()

        Dim currentDateTime As Date = DateTime.Now()
        Dim currentHour As Integer = DateTime.Now().TimeOfDay.Hours
        dsKhuyenMai = DuLieu.DocDuLieu($"SELECT * from KhuyenMaiDonHang where kmdh_ngay_bat_dau <=  #{currentDateTime.ToString("yyyy/MM/dd")}# and kmdh_ngay_ket_thuc >= #{currentDateTime.ToString("yyyy/MM/dd")}# and kmdh_gio_bat_dau <= {currentHour} and kmdh_gio_ket_thuc >= {currentHour}")
        Dim row1 As DataRow = dsKhuyenMai.NewRow()
        row1(0) = 0
        row1(9) = "Please select"
        dsKhuyenMai.Rows.InsertAt(row1, 0)
        cb_dh_khuyen_mai.DataSource = dsKhuyenMai
        cb_dh_khuyen_mai.DisplayMember = "kmdh_ten"
        cb_dh_khuyen_mai.ValueMember = "kmdh_ma"
        cb_dh_khuyen_mai.SelectedIndex = 0

        date_dh_ngay_tao.Format = DateTimePickerFormat.Custom
        date_dh_ngay_tao.CustomFormat = "dd-MM-yyyy HH:mm"

        tooltip_dh_them_sp.SetToolTip(btn_dh_them_san_pham, "Thêm sản phẩm")
        tooltip_dh_xoa_sp.SetToolTip(btn_dh_xoa_san_pham, "Bớt sản phẩm")

        If selectedDh IsNot Nothing Then
            btn_dh_them.Text = "Cập nhật"
            cb_dh_cn.SelectedValue = selectedDh("dh_ma_chi_nhanh")
            cb_dh_cn.Enabled = False
            cb_dh_khach_hang.SelectedValue = selectedDh("dh_ma_khach_hang")
            cb_dh_khach_hang.Enabled = False
            link_tao_khach_hang.Enabled = False
            txt_dh_tong_tien.Text = selectedDh("dh_tong_tien")
            txt_dh_chiet_khau.Text = selectedDh("dh_tien_khuyen_mai")
            txt_dh_thanh_tien.Text = selectedDh("dh_tong_tien") - selectedDh("dh_tien_khuyen_mai")
            txt_dh_tong_sp.Text = dtGridDonHangChiTiet.Rows.Count
            cb_dh_khuyen_mai.Enabled = False
            cb_dh_trang_thai.Enabled = True
            cb_dh_trang_thai.SelectedValue = selectedDh("dh_trang_thai")

            If selectedDh("dh_tien_khuyen_mai") > 0 Then
                Dim dsDonHangKhuyenMai As DataTable = ThuVien.DocDuLieu($"select top 1 * from DonHangKhuyenMaiDonHang where dhkmdh_ma_don_hang = {maDonHangChinhSua}")
                cb_dh_khuyen_mai.SelectedValue = Integer.Parse(dsDonHangKhuyenMai.Rows.Item(0)("dhkmdh_ma_khuyen_mai"))
                If cb_dh_khuyen_mai.SelectedText = "" Then
                    cb_dh_khuyen_mai.SelectedIndex = 0
                End If
            End If
        End If
    End Sub

    Private Sub doc_ds_khach_hang()
        dsKhachHang = DuLieu.DocDuLieu("Select * from KhachHang where kh_xoa = false")
        Dim row2 As DataRow = dsKhachHang.NewRow()
        row2(0) = 0
        row2(1) = "Please select"
        dsKhachHang.Rows.InsertAt(row2, 0)
        cb_dh_khach_hang.DataSource = dsKhachHang
        cb_dh_khach_hang.DisplayMember = "kh_ho_ten"
        cb_dh_khach_hang.ValueMember = "kh_ma"
        cb_dh_khach_hang.SelectedIndex = 0
    End Sub

    Private Sub cb_dh_cn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dh_cn.SelectedIndexChanged
        If cb_dh_cn.SelectedIndex > 0 Then
            dsSanPhamView.RowFilter = $"nk_ma_chi_nhanh = {cb_dh_cn.SelectedValue}"
            If maDonHangChinhSua <= 0 Then
                dtGridDonHangChiTiet.DataSource = Nothing
            End If

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
        If selected_dhct_index >= 0 And num_dh_sl_san_pham.Value > 0 And dsDonHangChiTiet IsNot Nothing Then
            Dim dmv As DataRowView = dtGridDonHangChiTiet.Rows(selected_dhct_index).DataBoundItem
            Dim dhct_found As DataRow = dmv.Row
            If dhct_found IsNot Nothing Then
                dhct_found("dhct_so_luong") -= num_dh_sl_san_pham.Value

                cap_nhap_gt_dh("bot", num_dh_sl_san_pham.Value, num_dh_sl_san_pham.Value * dhct_found("dhct_gia_ban"))

                If dhct_found("dhct_so_luong") <= 0 Then
                    Dim removed_dhct As DataRow = dsDonHangChiTiet.Rows.Find(dhct_found("dhct_ma_san_pham"))

                    If removed_dhct IsNot Nothing Then
                        BindingContext(dsDonHangChiTiet).RemoveAt(dsDonHangChiTiet.Rows.IndexOf(removed_dhct))
                        BindingContext(dsDonHangChiTiet).EndCurrentEdit()
                        txt_dh_chiet_khau.Text = "0"
                        selected_dhct_index = -1
                    End If
                Else
                    Dim giaMoi As Integer = Convert.ToInt32(dhct_found("dhct_gia_ban"))
                    Dim soluongMoi As Integer = Convert.ToInt32(dhct_found("dhct_so_luong"))
                    dhct_found("dhct_thanh_tien") = giaMoi * soluongMoi
                End If

                dtGridDonHangChiTiet.DataSource = dsDonHangChiTiet
            End If
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm trong giỏ hàng và số lượng bớt", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dtGridSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridSanPham.CellClick
        If e.RowIndex >= 0 Then
            selected_sp_index = e.RowIndex
        End If
    End Sub

    Private Sub dtGridDonHangChiTiet_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridDonHangChiTiet.CellClick
        If e.RowIndex >= 0 Then
            selected_dhct_index = e.RowIndex
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

        If hanh_dong = "them" Then
            tong_sp += sl_sp
            tong_tien += sp_thanh_tien
        Else
            tong_sp -= sl_sp
            tong_tien -= sp_thanh_tien
        End If

        txt_dh_tong_tien.Text = tong_tien

        tinh_dh_chiet_khau()
        Dim chietkhau As Integer = Integer.Parse(txt_dh_chiet_khau.Text)

        cap_nhat_dh_thanh_tien(tong_tien, chietkhau, tong_sp)

    End Sub


    Private Sub cap_nhat_dh_thanh_tien(tong_tien As Integer, chiet_khau As Integer, tong_sp As Integer)
        Dim thanh_tien As Integer = Integer.Parse(txt_dh_thanh_tien.Text)
        thanh_tien = tong_tien - chiet_khau
        txt_dh_tong_sp.Text = tong_sp

        If thanh_tien <= 0 Then
            txt_dh_thanh_tien.Text = "0"
        Else
            txt_dh_thanh_tien.Text = thanh_tien
        End If


    End Sub

    Private Sub cb_dh_khuyen_mai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dh_khuyen_mai.SelectedIndexChanged
        Dim isKMInValid As Boolean = dsDonHangChiTiet Is Nothing

        If dsDonHangChiTiet IsNot Nothing Then
            isKMInValid = dsDonHangChiTiet.Rows.Count <= 0
        End If


        If isKMInValid And cb_dh_khuyen_mai.SelectedIndex > 0 Then
            ThuVien.ShowErrorDialog("Vui lòng chọn mua sản phẩm trước khi chọn khuyến mãi", "Thông báo", MessageBoxIcon.Information)
            cb_dh_khuyen_mai.SelectedIndex = 0
        Else
            tinh_dh_chiet_khau()
            Dim tong_sp As Integer = Integer.Parse(txt_dh_tong_sp.Text)
            Dim tong_tien As Integer = Integer.Parse(txt_dh_tong_tien.Text)
            Dim chietkhau As Integer = Integer.Parse(txt_dh_chiet_khau.Text)
            cap_nhat_dh_thanh_tien(tong_tien, chietkhau, tong_sp)
        End If

    End Sub

    Private Sub tinh_dh_chiet_khau()
        If cb_dh_khuyen_mai.SelectedIndex > 0 Then
            Dim primaryKey(1) As DataColumn
            primaryKey(0) = dsKhuyenMai.Columns("kmdh_ma")
            dsKhuyenMai.PrimaryKey = primaryKey
            Dim selected_km As DataRow = dsKhuyenMai.Rows.Find(cb_dh_khuyen_mai.SelectedValue)

            Dim tong_tien As Integer = Integer.Parse(txt_dh_tong_tien.Text)

            If tong_tien < selected_km("kmdh_so_tien_toi_thieu") Then
                ThuVien.ShowErrorDialog($"Khuyến mãi chỉ áp dụng cho đơn hàng có tổng tiền tối thiểu {selected_km("kmdh_so_tien_toi_thieu")}", "Thông báo", MessageBoxIcon.Information)
                txt_dh_chiet_khau.Text = "0"
                cb_dh_khuyen_mai.SelectedIndex = 0
            Else
                If selected_km("kmdh_phan_tram") > 0 Then

                    Dim chiet_khau As Integer = (selected_km("kmdh_phan_tram") / 100) * tong_tien

                    If chiet_khau > selected_km("kmdh_khuyen_mai_toi_da") Then
                        chiet_khau = selected_km("kmdh_khuyen_mai_toi_da")
                    End If
                    txt_dh_chiet_khau.Text = chiet_khau

                Else
                    txt_dh_chiet_khau.Text = selected_km("kmdh_so_tien")
                End If
            End If
        End If
    End Sub

    Private Sub cb_dh_khach_hang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dh_khach_hang.SelectedIndexChanged

    End Sub

    Private Sub btn_dh_them_Click(sender As Object, e As EventArgs) Handles btn_dh_them.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            Dim dsDonHang As DataTable = ThuVien.DocDuLieu("select * from DonHang")
            If maDonHangChinhSua <= 0 Then
                Dim dh As DataRow = dsDonHang.NewRow()
                dh("dh_ngay") = date_dh_ngay_tao.Value
                dh("dh_ma_khach_hang") = cb_dh_khach_hang.SelectedValue
                dh("dh_trang_thai") = 1
                dh("dh_tong_tien") = Integer.Parse(txt_dh_tong_tien.Text)
                dh("dh_tien_khuyen_mai") = Integer.Parse(txt_dh_chiet_khau.Text)
                dh("dh_ma_chi_nhanh") = cb_dh_cn.SelectedValue
                dsDonHang.Rows.Add(dh)
            Else
                Dim primaryKey(1) As DataColumn
                primaryKey(0) = dsDonHang.Columns("dh_ma")
                dsDonHang.PrimaryKey = primaryKey

                Dim updated_dh As DataRow = dsDonHang.Rows.Find(maDonHangChinhSua)
                updated_dh("dh_tong_tien") = Integer.Parse(txt_dh_tong_tien.Text)
                updated_dh("dh_tien_khuyen_mai") = Integer.Parse(txt_dh_chiet_khau.Text)
                updated_dh("dh_trang_thai") = cb_dh_trang_thai.SelectedValue

            End If




            ThuVien.GhiDuLieu("DonHang", dsDonHang)
            ThuVien.GhiDuLieu("DonHangChiTiet", dsDonHangChiTiet)

            If cb_dh_khuyen_mai.SelectedIndex > 0 And maDonHangChinhSua <= 0 Then
                Dim dsDonHangKhuyenMaiChiTiet As DataTable = ThuVien.DocDuLieu("select * from DonHangKhuyenMaiDonHang")
                Dim dhkm As DataRow = dsDonHangKhuyenMaiChiTiet.NewRow()
                dhkm("dhkmdh_ma_don_hang") = maDonHangTaoMoi
                dhkm("dhkmdh_ma_khuyen_mai") = cb_dh_khuyen_mai.SelectedValue

                dsDonHangKhuyenMaiChiTiet.Rows.Add(dhkm)
                ThuVien.GhiDuLieu("DonHangKhuyenMaiDonHang", dsDonHangKhuyenMaiChiTiet)
            End If

            Dim frmQuanLyDonHang As FrmQuanLyDonHang = New FrmQuanLyDonHang()
            frmQuanLyDonHang.MdiParent = Index
            frmQuanLyDonHang.WindowState = FormWindowState.Maximized
            frmQuanLyDonHang.Show()

        End If
    End Sub

    Private Sub dtGridDonHangChiTiet_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtGridDonHangChiTiet.Validating
        ThuVien.ValidateInput(dtGridDonHangChiTiet, e, err_provider_dhct, "", "Giỏ hàng bị trống. Vui lòng thêm sản phẩm")
    End Sub

    Private Sub cb_dh_khach_hang_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_dh_khach_hang.Validating
        ThuVien.ValidateInput(cb_dh_khach_hang, e, err_provider_dh_khach_hang, "", "Vui lòng chọn khách hàng mua sản phẩm")
    End Sub

    Private Sub link_tao_khach_hang_Click(sender As Object, e As EventArgs) Handles link_tao_khach_hang.Click
        Dim frmTaoKhachHang As FrmTaoKhachHang = New FrmTaoKhachHang()
        If frmTaoKhachHang.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            doc_ds_khach_hang()

        End If
    End Sub

    Private Sub txt_dh_tong_sp_TextChanged(sender As Object, e As EventArgs) Handles txt_dh_tong_sp.TextChanged
        Dim tong_sp As Integer = Integer.Parse(txt_dh_tong_sp.Text)
        If tong_sp < 0 Then
            txt_dh_tong_sp.Text = "0"
        End If
    End Sub


End Class