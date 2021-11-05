Imports ThuVien

Public Class FrmQuanLyChiNhanh

    Dim dsChiNhanh As DataTable
    Dim dsChiNhanhView As DataView

    Private Sub onFrmQuanChiNhanhClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub onFrmQuanLiChiNhanhLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")

        dsChiNhanhView = New DataView(dsChiNhanh)
        dtGridChiNhanh.DataSource = dsChiNhanhView
    End Sub

    Private Sub onClickBtnThem(sender As Object, e As EventArgs) Handles btnThem.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            Dim cn As DataRow = dsChiNhanh.NewRow()

            cn("cn_ten") = txt_cn_ten.Text
            cn("cn_dia_chi") = txt_cn_dia_chi.Text
            cn("cn_xoa") = False
            dsChiNhanh.Rows.Add(cn)
            DuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)

        End If
    End Sub

    Private Sub onClickBtnSua(sender As Object, e As EventArgs) Handles btnSua.Click
        If dtGridChiNhanh.SelectedCells.Count() > 0 And ValidateChildren(ValidationConstraints.Enabled) Then
            Dim dmv As DataRowView = dtGridChiNhanh.Rows(dtGridChiNhanh.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = dmv.Row
            cn("cn_ten") = txt_cn_ten.Text
            cn("cn_dia_chi") = txt_cn_dia_chi.Text

            DuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
        End If
    End Sub

    Private Sub onClickBtnXoa(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtGridChiNhanh.SelectedCells.Count() > 0 And ThuVien.ShowDialog("Bạn có chắc muốn xóa chi nhánh này không?", "Thông báo", MessageBoxIcon.Warning) = True Then
            Dim dmv As DataRowView = dtGridChiNhanh.Rows(dtGridChiNhanh.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = dmv.Row
            cn("cn_xoa") = True

            DuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
            dsChiNhanh.Rows.Remove(cn)
        End If
    End Sub

    Private Sub txt_tim_kiem_chi_nhanh_TextChanged(sender As Object, e As EventArgs) Handles txt_tim_kiem_chi_nhanh.TextChanged
        If txt_tim_kiem_chi_nhanh.Text <> "" Then
            dsChiNhanhView.RowFilter = $"cn_ten like '%{txt_tim_kiem_chi_nhanh.Text}%'"
        Else
            dsChiNhanhView.RowFilter = ""
        End If
    End Sub

    Private Sub dtGridChiNhanh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridChiNhanh.CellClick
        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridChiNhanh.Rows(e.RowIndex).DataBoundItem
            Dim dmsp As DataRow = dmv.Row
            txt_cn_ten.Text = dmsp("cn_ten")
            If Not IsDBNull(dmsp("cn_dia_chi")) Then
                txt_cn_dia_chi.Text = dmsp("cn_dia_chi")
            Else
                txt_cn_dia_chi.Text = ""
            End If
        End If
    End Sub

    Private Sub txt_cn_ten_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_cn_ten.Validating
        ThuVien.ValidateInput(txt_cn_ten, e, err_provider_cn_ten, "", "Vui lòng nhập tên chi nhánh")
    End Sub
End Class