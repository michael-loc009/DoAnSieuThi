
Imports ThuVien

Public Class FrmQuanLyDanhMuc

    Dim dsDanhMucSanPham As DataTable
    Dim dsDanhMucSanPhamView As DataView

    Private Sub onFrmDanhMucLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        dsDanhMucSanPham = DuLieu.DocDuLieu("Select * from DanhMucSanPham where dmsp_xoa = false")

        dsDanhMucSanPhamView = New DataView(dsDanhMucSanPham)
        dtGridDanhMucSanPham.DataSource = dsDanhMucSanPhamView
    End Sub

    Private Sub onFrmDanhMucClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub onClickBtnThem(sender As Object, e As EventArgs) Handles btnThem.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            Dim dmsp As DataRow = dsDanhMucSanPham.NewRow()

            dmsp("dmsp_ten") = txt_dmsp_ten.Text
            dmsp("dmsp_mo_ta") = txt_dmsp_mo_ta.Text
            dmsp("dmsp_xoa") = False

            dsDanhMucSanPham.Rows.Add(dmsp)
            DuLieu.GhiDuLieu("DanhMucSanPham", dsDanhMucSanPham)
        End If
    End Sub

    Private Sub onClickBtnSua(sender As Object, e As EventArgs) Handles btnSua.Click
        If dtGridDanhMucSanPham.SelectedCells.Count() > 0 And ValidateChildren(ValidationConstraints.Enabled) Then
            Dim dmv As DataRowView = dtGridDanhMucSanPham.Rows(dtGridDanhMucSanPham.SelectedCells(0).RowIndex).DataBoundItem
            Dim dmsp As DataRow = dmv.Row
            dmsp("dmsp_ten") = txt_dmsp_ten.Text
            dmsp("dmsp_mo_ta") = txt_dmsp_mo_ta.Text

            DuLieu.GhiDuLieu("DanhMucSanPham", dsDanhMucSanPham)
        End If
    End Sub

    Private Sub onClickBtnXoa(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtGridDanhMucSanPham.SelectedCells.Count() > 0 And ThuVien.ShowDialog("Bạn có chắc muốn xóa danh mục sản phẩm này không?", "Thông báo", MessageBoxIcon.Warning) = True Then
            Dim dmv As DataRowView = dtGridDanhMucSanPham.Rows(dtGridDanhMucSanPham.SelectedCells(0).RowIndex).DataBoundItem
            Dim dmsp As DataRow = dmv.Row
            dmsp("dmsp_xoa") = True

            DuLieu.GhiDuLieu("DanhMucSanPham", dsDanhMucSanPham)
            dsDanhMucSanPham.Rows.Remove(dmsp)
        End If
    End Sub

    Private Sub dtGridDanhMucSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridDanhMucSanPham.CellClick
        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridDanhMucSanPham.Rows(e.RowIndex).DataBoundItem
            Dim dmsp As DataRow = dmv.Row
            txt_dmsp_ten.Text = dmsp("dmsp_ten")
            If Not IsDBNull(dmsp("dmsp_mo_ta")) Then
                txt_dmsp_mo_ta.Text = dmsp("dmsp_mo_ta")
            Else
                txt_dmsp_mo_ta.Text = ""
            End If

            If Not IsDBNull(dmsp("dmsp_ma")) Then
                DocSanPham(dmsp("dmsp_ma"))
            End If
        End If
    End Sub

    Private Sub txtTimKiemDanhMucSanPham_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemDanhMucSanPham.TextChanged
        If txtTimKiemDanhMucSanPham.Text <> "" Then
            dsDanhMucSanPhamView.RowFilter = $"dmsp_ten like '%{txtTimKiemDanhMucSanPham.Text}%'"
        Else
            dsDanhMucSanPhamView.RowFilter = ""
        End If
    End Sub

    Sub DocSanPham(ByVal ma_danh_muc As Int32)
        Dim dsSanPham As DataTable
        dsSanPham = DuLieu.DocDuLieu("Select * from SanPham where sp_ma_danh_muc = " + ma_danh_muc.ToString())
        dtGridSanPham.DataSource = dsSanPham
    End Sub

    Private Sub txt_dmsp_ten_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_dmsp_ten.Validating
        ThuVien.ValidateInput(txt_dmsp_ten, e, err_provider_dmsp_ten, "", "Vui lòng nhập tên danh mục sản phẩm")
    End Sub
End Class