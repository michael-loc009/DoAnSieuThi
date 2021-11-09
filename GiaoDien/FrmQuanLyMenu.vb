Imports ThuVien

Public Class FrmQuanLyMenu

    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Dim dsChiNhanh As DataTable

    Dim dsMenuChiNhanhSanPham As DataTable

    Dim selected_sp_index As Integer = -1
    Dim selected_menu_sp_index As Integer = -1

    Private Sub FrmQuanLyMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsSanPham = DuLieu.DocDuLieu("select sp_ma, sp_ten, sp_xoa, sp_gia from SanPham where sp_xoa = false")
        dsSanPhamView = New DataView(dsSanPham)
        dtGrid_menu_san_pham.DataSource = dsSanPhamView
        dtGrid_menu_san_pham.ClearSelection()


        loc_menu_cn_sp(0)
        dtGrid_menu_cn_san_pham.DataSource = dsMenuChiNhanhSanPham
        dtGrid_menu_cn_san_pham.ClearSelection()
        set_pk_dsMenuChiNhanhSanPham()


        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        Dim row1 As DataRow = dsChiNhanh.NewRow()
        row1(0) = 0
        row1(1) = "Please select"
        dsChiNhanh.Rows.InsertAt(row1, 0)
        cb_menu_cn.DataSource = dsChiNhanh
        cb_menu_cn.DisplayMember = "cn_ten"
        cb_menu_cn.ValueMember = "cn_ma"
        cb_menu_cn.SelectedIndex = 0


    End Sub

    Private Sub txt_menu_tim_sp_TextChanged(sender As Object, e As EventArgs) Handles txt_menu_tim_sp.TextChanged
        If txt_menu_tim_sp.Text <> "" Then
            dsSanPhamView.RowFilter = $"sp_ten like '%{txt_menu_tim_sp.Text}%'"
        Else
            dsSanPhamView.RowFilter = ""
        End If
    End Sub



    Private Sub btn_menu_them_sp_Click(sender As Object, e As EventArgs) Handles btn_menu_them_sp.Click
        If cb_menu_cn.SelectedIndex <= 0 Then
            ThuVien.ShowErrorDialog("Vui lòng chọn chi nhánh cho menu", "Thông báo", MessageBoxIcon.Error)
        ElseIf selected_sp_index >= 0 And num_menu_sl_sp.Value > 0 Then
            Dim dmv As DataRowView = dtGrid_menu_san_pham.Rows(selected_sp_index).DataBoundItem
            Dim sp As DataRow = dmv.Row

            Dim found_cn_sp = tim_menu_cn_sp_by_sp(sp("sp_ma"))

            If found_cn_sp Is Nothing Then
                Dim cn_sp As DataRow = dsMenuChiNhanhSanPham.NewRow()
                cn_sp("m_ma_san_pham") = sp("sp_ma")
                cn_sp("m_ma_chi_nhanh") = cb_menu_cn.SelectedValue
                cn_sp("m_gia_ban") = sp("sp_gia")
                cn_sp("m_so_luong") = num_menu_sl_sp.Value
                dsMenuChiNhanhSanPham.Rows.Add(cn_sp)
            Else
                found_cn_sp("m_so_luong") += num_menu_sl_sp.Value
            End If

            DuLieu.GhiDuLieu("Menu", dsMenuChiNhanhSanPham)
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn sản phẩm và nhập số lượng", "Thông báo", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_menu_xoa_sp_Click(sender As Object, e As EventArgs) Handles btn_menu_xoa_sp.Click
        If cb_menu_cn.SelectedIndex <= 0 Then
            ThuVien.ShowErrorDialog("Vui lòng chọn chi nhánh cho menu", "Thông báo", MessageBoxIcon.Error)
        ElseIf selected_menu_sp_index >= 0 And num_menu_sl_sp.Value > 0 Then
            Dim dmv As DataRowView = dtGrid_menu_cn_san_pham.Rows(selected_menu_sp_index).DataBoundItem
            Dim cn_sp As DataRow = dmv.Row
            If cn_sp("m_so_luong") - num_menu_sl_sp.Value <= 0 Then
                Dim removed_cn_sp As DataRow = dsMenuChiNhanhSanPham.Rows.Find(cn_sp("m_ma_san_pham"))
                If removed_cn_sp IsNot Nothing Then
                    BindingContext(dsMenuChiNhanhSanPham).RemoveAt(dsMenuChiNhanhSanPham.Rows.IndexOf(removed_cn_sp))
                    BindingContext(dsMenuChiNhanhSanPham).EndCurrentEdit()
                    selected_menu_sp_index = -1
                End If
            Else
                cn_sp("m_so_luong") -= num_menu_sl_sp.Value
            End If

            DuLieu.GhiDuLieu("Menu", dsMenuChiNhanhSanPham)
        Else
            ThuVien.ShowErrorDialog("Vui lòng chọn menu chi nhánh sản phẩm và nhập số lượng", "Thông báo", MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub dtGrid_menu_cn_san_pham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid_menu_cn_san_pham.CellClick
        If e.RowIndex >= 0 Then
            selected_menu_sp_index = e.RowIndex
        End If
    End Sub

    Private Sub dtGrid_menu_san_pham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid_menu_san_pham.CellClick
        If e.RowIndex >= 0 Then
            selected_sp_index = e.RowIndex
        End If
    End Sub

    Private Sub cb_menu_cn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_menu_cn.SelectedIndexChanged
        If cb_menu_cn.SelectedIndex > 0 Then
            loc_menu_cn_sp(cb_menu_cn.SelectedValue)
        Else
            loc_menu_cn_sp(0)
        End If
    End Sub

    Private Sub loc_menu_cn_sp(ma_cn As Integer)
        dsMenuChiNhanhSanPham = DuLieu.DocDuLieu($"select a.*, b.sp_ten from Menu a, SanPham b where a.m_ma_san_pham = b.sp_ma and a.m_ma_chi_nhanh = {ma_cn}")
        set_pk_dsMenuChiNhanhSanPham()
        dtGrid_menu_cn_san_pham.DataSource = dsMenuChiNhanhSanPham
    End Sub

    Private Sub set_pk_dsMenuChiNhanhSanPham()
        Dim primaryKey(1) As DataColumn
        primaryKey(0) = dsMenuChiNhanhSanPham.Columns("m_ma_san_pham")
        dsMenuChiNhanhSanPham.PrimaryKey = primaryKey
    End Sub

    Private Function tim_menu_cn_sp_by_sp(ma_sp As Integer) As DataRow
        Dim menu_cn_sp As DataRow = dsMenuChiNhanhSanPham.Rows.Find(ma_sp)
        Return menu_cn_sp
    End Function

End Class