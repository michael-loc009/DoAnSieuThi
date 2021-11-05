Imports ThuVien

Public Class FrmQuanLySanPham

    Dim dsSanPham As DataTable
    Dim dsSanPhamView As DataView

    Dim dsDanhMucSanPham As DataTable

    Private Sub onFrmQuanLySanPhamLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        dsSanPham = DuLieu.DocDuLieu("Select * From SanPham, DanhMucSanPham where sp_ma_danh_muc = dmsp_ma and sp_xoa = false and dmsp_xoa = false")

        dsSanPhamView = New DataView(dsSanPham)
        dtGridSanPham.DataSource = dsSanPhamView
        dtGridSanPham.Columns("dmsp_ma").Visible = False
        dtGridSanPham.Columns("dmsp_mo_ta").Visible = False
        dtGridSanPham.Columns("dmsp_xoa").Visible = False

        dsDanhMucSanPham = DuLieu.DocDuLieu("Select * from DanhMucSanPham where dmsp_xoa = false")
        Dim row As DataRow = dsDanhMucSanPham.NewRow()
        row(0) = 0
        row(1) = "Please select"
        dsDanhMucSanPham.Rows.InsertAt(row, 0)

        cb_sp_danh_muc_san_pham.DataSource = dsDanhMucSanPham
        cb_sp_danh_muc_san_pham.DisplayMember = "dmsp_ten"
        cb_sp_danh_muc_san_pham.ValueMember = "dmsp_ma"
        cb_sp_danh_muc_san_pham.SelectedIndex = 0

    End Sub

    Private Sub onFrmQuanLySanPhamClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub onClickBtnThem(sender As Object, e As EventArgs) Handles btnThem.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then

            Dim sp As DataRow = dsSanPham.NewRow()

            sp("sp_ten") = txt_sp_ten.Text
            sp("sp_mo_ta") = txt_sp_mo_ta.Text
            sp("sp_xoa") = False
            sp("sp_so_luong_toi_thieu") = num_sp_so_luong_toi_thieu.Value
            sp("sp_gia") = Convert.ToDecimal(num_sp_gia.Text)
            sp("sp_ma_danh_muc") = Convert.ToInt32(cb_sp_danh_muc_san_pham.SelectedValue)
            sp("dmsp_ten") = cb_sp_danh_muc_san_pham.GetItemText(cb_sp_danh_muc_san_pham.SelectedItem)

            dsSanPham.Rows.Add(sp)

            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        End If
    End Sub

    Private Sub onClickBtnSua(sender As Object, e As EventArgs) Handles btnSua.Click
        If dtGridSanPham.SelectedCells.Count() > 0 And ValidateChildren(ValidationConstraints.Enabled) Then
            Dim dmv As DataRowView = dtGridSanPham.Rows(dtGridSanPham.SelectedCells(0).RowIndex).DataBoundItem
            Dim sp As DataRow = dmv.Row
            sp("sp_ten") = txt_sp_ten.Text
            sp("sp_mo_ta") = txt_sp_mo_ta.Text
            sp("sp_so_luong_toi_thieu") = num_sp_so_luong_toi_thieu.Value
            sp("sp_gia") = Convert.ToDecimal(num_sp_gia.Text)
            sp("sp_ma_danh_muc") = Convert.ToInt32(cb_sp_danh_muc_san_pham.SelectedValue)
            sp("dmsp_ten") = cb_sp_danh_muc_san_pham.GetItemText(cb_sp_danh_muc_san_pham.SelectedItem)

            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        End If
    End Sub

    Private Sub onClickBtnXoa(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtGridSanPham.SelectedCells.Count() > 0 And ThuVien.ShowDialog("Bạn có chắc muốn xóa sản phẩm này không?", "Thông báo", MessageBoxIcon.Warning) = True Then
            Dim dmv As DataRowView = dtGridSanPham.Rows(dtGridSanPham.SelectedCells(0).RowIndex).DataBoundItem
            Dim sp As DataRow = dmv.Row
            sp("sp_xoa") = True

            dsSanPham.Rows.Remove(sp)
            DuLieu.GhiDuLieu("SanPham", dsSanPham)
        End If
    End Sub

    Private Sub dtGridSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridSanPham.CellClick
        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridSanPham.Rows(e.RowIndex).DataBoundItem
            Dim sp As DataRow = dmv.Row
            txt_sp_ten.Text = sp("sp_ten")
            num_sp_gia.Text = sp("sp_gia")
            num_sp_so_luong_toi_thieu.Value = sp("sp_so_luong_toi_thieu")
            cb_sp_danh_muc_san_pham.SelectedValue = sp("sp_ma_danh_muc")
            If Not IsDBNull(sp("sp_mo_ta")) Then
                txt_sp_mo_ta.Text = sp("sp_mo_ta")
            Else
                txt_sp_mo_ta.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_tim_kiem_sp_TextChanged(sender As Object, e As EventArgs) Handles txt_tim_kiem_sp.TextChanged
        If txt_tim_kiem_sp.Text <> "" Then
            dsSanPhamView.RowFilter = $"sp_ten like '%{txt_tim_kiem_sp.Text}%'"
        Else
            dsSanPhamView.RowFilter = ""
        End If
    End Sub

    Private Sub txt_sp_ten_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_sp_ten.Validating
        ThuVien.ValidateInput(txt_sp_ten, e, err_provider_sp_ten, "", "Vui lòng nhập tên sản phẩm")
    End Sub

    Private Sub num_sp_gia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles num_sp_gia.Validating
        ThuVien.ValidateInput(num_sp_gia, e, err_provider_sp_gia, "int", "Giá sản phẩm phải lớn hơn 0")
    End Sub

    Private Sub num_sp_so_luong_toi_thieu_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles num_sp_so_luong_toi_thieu.Validating
        ThuVien.ValidateInput(num_sp_so_luong_toi_thieu, e, err_provider_sp_so_luong_toi_thieu, "", "Số lượng tối thiểu phải lớn hơn 0")
    End Sub

    Private Sub cb_sp_danh_muc_san_pham_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_sp_danh_muc_san_pham.Validating
        ThuVien.ValidateInput(cb_sp_danh_muc_san_pham, e, err_provider_sp_danh_muc, "", "Vui lòng chọn danh mục sản phẩm")
    End Sub
End Class