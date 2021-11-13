Imports ThuVien

Public Class FrmQuanLyNguoiDung

    Dim dsTaiKhoan As DataTable
    Dim dsTaiKhoanView As DataView

    Dim dsLoaiTk As DataTable

    Dim dsChiNhanh As DataTable

    Dim tkMaMoiNhat As Integer

    Private Sub onFrmNguoiDungLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        docTK()

        If dsTaiKhoan.Rows.Count > 0 Then
            tkMaMoiNhat = dsTaiKhoan.Rows(0)("nd_ma_tai_khoan") + 1
        End If

        dtGridNguoiDung.ClearSelection()


        dsChiNhanh = DuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        cb_list_nd_phan_quyen_cn.DataSource = dsChiNhanh
        cb_list_nd_phan_quyen_cn.DisplayMember = "cn_ten"
        cb_list_nd_phan_quyen_cn.ValueMember = "cn_ma"

        dsLoaiTk = DuLieu.DocDuLieu("Select * from LoaiTaiKhoan where ltk_xoa = false")
        Dim row As DataRow = dsLoaiTk.NewRow()
        row(0) = 0
        row(1) = "Please select"
        dsLoaiTk.Rows.InsertAt(row, 0)
        cb_nd_loai_tk.DataSource = dsLoaiTk
        cb_nd_loai_tk.DisplayMember = "ltk_ten"
        cb_nd_loai_tk.ValueMember = "ltk_ma"
        cb_nd_loai_tk.SelectedIndex = 0


        date_nd_nam_sinh.Format = DateTimePickerFormat.Custom
        date_nd_nam_sinh.CustomFormat = "yyyy"
        date_nd_nam_sinh.ShowUpDown = True


    End Sub

    Private Sub onFrmNguoiDungClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub onClickBtnThem(sender As Object, e As EventArgs) Handles btnThem.Click

        If String.IsNullOrEmpty(txt_nd_pass.Text) Then
            ThuVien.ShowErrorDialog("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxIcon.Warning)
            Return
        End If

        If ValidateChildren(ValidationConstraints.Enabled) Then
            Dim tk As DataTable = DuLieu.DocDuLieu($"select * from TaiKhoan where tk_ten_dang_nhap = '{txt_nd_username.Text}'")

            If tk.Rows.Count > 0 Then
                ThuVien.ShowErrorDialog("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxIcon.Warning)
                Return
            End If


            Dim newTK As DataRow = tk.NewRow()
            newTK("tk_ten_dang_nhap") = txt_nd_username.Text
            newTK("tk_mat_khau") = ThuVien.GetHash(txt_nd_pass.Text)
            newTK("tk_ma_loai") = cb_nd_loai_tk.SelectedValue
            tk.Rows.Add(newTK)
            DuLieu.GhiDuLieu("TaiKhoan", tk)

            Dim nd As DataTable = DuLieu.DocDuLieu("select * from NguoiDung where nd_ma = -1")
            Dim newND As DataRow = nd.NewRow()
            newND("nd_ho_ten") = txt_nd_ho_ten.Text
            newND("nd_dia_chi") = txt_nd_dia_chi.Text
            newND("nd_nam_sinh") = date_nd_nam_sinh.Value.ToString("yyyy")
            newND("nd_ma_tai_khoan") = newTK("tk_ma")
            newND("nd_xoa") = False
            nd.Rows.Add(newND)
            DuLieu.GhiDuLieu("NguoiDung", nd)


            Dim tkq As DataTable = DuLieu.DocDuLieu("select * from TaiKhoanQuyen where tkq_ma = -1")
            Dim newTKQ As DataRow = tkq.NewRow()
            newTKQ("tkq_ma_tai_khoan") = newTK("tk_ma")
            newTKQ("tkq_ma_quyen") = cb_nd_loai_tk.SelectedValue
            tkq.Rows.Add(newTKQ)
            DuLieu.GhiDuLieu("TaiKhoanQuyen", tkq)


            Dim tkcn As DataTable = DuLieu.DocDuLieu("select * from TaiKhoanChiNhanh where tkcn_ma = -1")
            For Each item As DataRowView In cb_list_nd_phan_quyen_cn.CheckedItems
                Dim newTKCN As DataRow = tkcn.NewRow()
                newTKCN("tkcn_ma_chi_nhanh") = item.Row(0)
                newTKCN("tkcn_ma_tai_khoan") = newTK("tk_ma")
                tkcn.Rows.Add(newTKCN)
            Next

            DuLieu.GhiDuLieu("TaiKhoanChiNhanh", tkcn)
            txt_nd_confirm_pass.Text = ""
            txt_nd_pass.Text = ""

            docTK()

        End If
    End Sub

    Private Sub onClickBtnSua(sender As Object, e As EventArgs) Handles btnSua.Click

        Try

            If dtGridNguoiDung.SelectedCells.Count() > 0 And ValidateChildren(ValidationConstraints.Enabled) Then
                Dim dmv As DataRowView = dtGridNguoiDung.Rows(dtGridNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
                Dim selectedND As DataRow = dmv.Row

                If selectedND("nd_ma_tai_khoan") = 0 Or txt_nd_username.Text = "" Then
                    ThuVien.ShowErrorDialog("Vui lòng chọn người dùng tài khoản cập nhật", "Thông báo", MessageBoxIcon.Warning)
                    Return
                End If


                Dim tk As DataTable = DuLieu.DocDuLieu($"select * from TaiKhoan where tk_ten_dang_nhap = '{txt_nd_username.Text}'")

                If tk.Rows.Count > 1 Then
                    ThuVien.ShowErrorDialog("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxIcon.Warning)
                    Return
                Else
                    tk = DuLieu.DocDuLieu($"select * from TaiKhoan where tk_ma = {selectedND("nd_ma_tai_khoan")} ")
                End If


                Dim newTK As DataRow = tk.Rows(0)
                newTK("tk_ten_dang_nhap") = txt_nd_username.Text

                If txt_nd_pass.Text <> "" Then
                    newTK("tk_mat_khau") = ThuVien.GetHash(txt_nd_pass.Text)
                End If

                newTK("tk_ma_loai") = cb_nd_loai_tk.SelectedValue
                DuLieu.GhiDuLieu("TaiKhoan", tk)

                Dim nd As DataTable = DuLieu.DocDuLieu($"select * from NguoiDung where nd_ma = {selectedND("nd_ma")}")
                Dim newND As DataRow = nd.Rows(0)
                newND("nd_ho_ten") = txt_nd_ho_ten.Text
                newND("nd_dia_chi") = txt_nd_dia_chi.Text
                newND("nd_nam_sinh") = date_nd_nam_sinh.Value.ToString("yyyy")
                DuLieu.GhiDuLieu("NguoiDung", nd)


                Dim tkq As DataTable = DuLieu.DocDuLieu($"select * from TaiKhoanQuyen where tkq_ma_tai_khoan = {selectedND("nd_ma_tai_khoan")}")
                Dim newTKQ As DataRow = tkq.Rows(0)
                newTKQ("tkq_ma_quyen") = cb_nd_loai_tk.SelectedValue
                DuLieu.GhiDuLieu("TaiKhoanQuyen", tkq)


                Dim tkcn As DataTable = DuLieu.DocDuLieu($"select * from TaiKhoanChiNhanh where tkcn_ma_tai_khoan = {selectedND("nd_ma_tai_khoan")}")

                Dim found_tkcn_i As Integer = -1
                For j As Integer = 0 To cb_list_nd_phan_quyen_cn.Items.Count - 1
                    Dim item1 As DataRowView = cb_list_nd_phan_quyen_cn.Items.Item(j)
                    Dim found As Boolean = False
                    For i As Integer = 0 To tkcn.Rows.Count - 1
                        If i > tkcn.Rows.Count - 1 Then
                            Continue For
                        End If

                        If tkcn.Rows(i).RowState = DataRowState.Deleted Then
                            Continue For
                        End If

                        If item1.Row(0) = tkcn.Rows(i)("tkcn_ma_chi_nhanh") Then
                            If cb_list_nd_phan_quyen_cn.GetItemCheckState(j) = CheckState.Unchecked Then
                                found_tkcn_i = tkcn.Rows(i)("tkcn_ma_chi_nhanh")

                                BindingContext(tkcn).RemoveAt(tkcn.Rows.IndexOf(tkcn.Rows(i)))
                                BindingContext(tkcn).EndCurrentEdit()
                                found = True
                            End If
                        End If
                    Next

                    If found = False And cb_list_nd_phan_quyen_cn.GetSelected(j) = True Then
                        Dim newTKCN As DataRow = tkcn.NewRow()
                        newTKCN("tkcn_ma_chi_nhanh") = item1.Row(0)
                        newTKCN("tkcn_ma_tai_khoan") = selectedND("nd_ma_tai_khoan")
                        tkcn.Rows.Add(newTKCN)
                    End If

                Next

                DuLieu.GhiDuLieu("TaiKhoanChiNhanh", tkcn)


                docTK()

            End If

        Catch ex As Exception

            ThuVien.ShowErrorDialog(ex.ToString, "Thông báo", MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub onClickBtnXoa(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtGridNguoiDung.SelectedCells.Count() > 0 And ThuVien.ShowDialog("Bạn có chắc muốn xóa người dùng này không?", "Thông báo", MessageBoxIcon.Warning) = True Then
            Dim dmv As DataRowView = dtGridNguoiDung.Rows(dtGridNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
            Dim selected_nd As DataRow = dmv.Row

            Dim nd As DataTable = DuLieu.DocDuLieu($"select * from NguoiDung where nd_ma = {selected_nd("nd_ma")}")
            Dim updated_nd As DataRow = nd.Rows(0)
            updated_nd("nd_xoa") = True
            DuLieu.GhiDuLieu("NguoiDung", nd)
            docTK()
        End If
    End Sub

    Private Sub docTK()
        dsTaiKhoan = DuLieu.DocDuLieu("SELECT a.*, b.tk_ma_loai, b.tk_ten_dang_nhap, c.ltk_ten FROM (NguoiDung AS a INNER JOIN TaiKhoan AS b ON a.nd_ma_tai_khoan = b.tk_ma) INNER JOIN LoaiTaiKhoan AS c ON c.ltk_ma = b.tk_ma_loai where a.nd_xoa = false order by a.nd_ma_tai_khoan desc")
        dsTaiKhoanView = New DataView(dsTaiKhoan)
        dtGridNguoiDung.DataSource = dsTaiKhoanView
        dtGridNguoiDung.Columns("nd_ma_tai_khoan").Visible = False
        dtGridNguoiDung.Columns("nd_xoa").Visible = False
        dtGridNguoiDung.Columns("tk_ma_loai").Visible = False
        dtGridNguoiDung.Columns("tk_ten_dang_nhap").Visible = False
    End Sub

    Private Sub dtGridNguoiDung_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridNguoiDung.CellClick

        For j As Integer = 0 To cb_list_nd_phan_quyen_cn.Items.Count - 1
            cb_list_nd_phan_quyen_cn.SetSelected(j, False)
            cb_list_nd_phan_quyen_cn.SetItemCheckState(j, CheckState.Unchecked)
        Next

        If e.RowIndex >= 0 Then
            Dim dmv As DataRowView = dtGridNguoiDung.Rows(e.RowIndex).DataBoundItem
            Dim selectedND As DataRow = dmv.Row

            txt_nd_ho_ten.Text = selectedND("nd_ho_ten")
            txt_nd_dia_chi.Text = selectedND("nd_dia_chi")
            txt_nd_username.Text = selectedND("tk_ten_dang_nhap")
            cb_nd_loai_tk.SelectedValue = selectedND("tk_ma_loai")
            date_nd_nam_sinh.Value = New DateTime(selectedND("nd_nam_sinh"), 5, 31, 12, 14, 0)

            Dim tkcn As DataTable = DuLieu.DocDuLieu($"select * from TaiKhoanChiNhanh where tkcn_ma_tai_khoan = {selectedND("nd_ma_tai_khoan")} ")
            If tkcn IsNot Nothing Then
                For Each item As DataRow In tkcn.Rows
                    For j As Integer = 0 To cb_list_nd_phan_quyen_cn.Items.Count - 1
                        Dim item1 As DataRowView = cb_list_nd_phan_quyen_cn.Items.Item(j)
                        If item1.Row(0) = item("tkcn_ma_chi_nhanh") Then

                            cb_list_nd_phan_quyen_cn.SetSelected(j, True)
                            cb_list_nd_phan_quyen_cn.SetItemCheckState(j, CheckState.Checked)
                        End If
                    Next

                Next
            End If


        End If
    End Sub

    Private Sub txt_nd_username_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nd_username.Validating
        ThuVien.ValidateInput(txt_nd_username, e, err_provider_username, "", "Vui lòng nhập tên đăng nhập")
    End Sub


    Private Sub txt_nd_ho_ten_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nd_ho_ten.Validating
        ThuVien.ValidateInput(txt_nd_ho_ten, e, err_provider_hoten, "", "Vui lòng nhập họ vả tên")
    End Sub

    Private Sub txt_nd_confirm_pass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nd_confirm_pass.Validating
        If txt_nd_pass.Text <> "" Then
            ThuVien.ValidateInput(txt_nd_confirm_pass, e, err_provider_confirm_pass, txt_nd_pass.Text, "Vui lòng nhập xác nhận lại mật khẩu")
        End If

    End Sub

    Private Sub date_nd_nam_sinh_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles date_nd_nam_sinh.Validating
        If txt_nd_pass.Text <> "" Then
            ThuVien.ValidateInput(date_nd_nam_sinh, e, err_provider_namsinh, "", "Vui lòng nhập năm sinh")
        End If
    End Sub

    Private Sub txt_nd_dia_chi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nd_dia_chi.Validating
        ThuVien.ValidateInput(txt_nd_dia_chi, e, err_provider_diachi, "", "Vui lòng nhập địa chỉ")
    End Sub

    Private Sub cb_nd_loai_tk_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_nd_loai_tk.Validating
        ThuVien.ValidateInput(cb_nd_loai_tk, e, err_provider_loai_tk, "", "Vui lòng chọn loại tài khoản")
    End Sub

    Private Sub cb_list_nd_phan_quyen_cn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_list_nd_phan_quyen_cn.Validating
        ThuVien.ValidateInput(cb_list_nd_phan_quyen_cn, e, err_provider_quyen_cn, "", "Vui lòng phần quyền chi nhánh cho tài khoản")
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        If txtTimKiem.Text <> "" Then
            dsTaiKhoanView.RowFilter = $"nd_ho_ten like '%{txtTimKiem.Text}%'"
        Else
            dsTaiKhoanView.RowFilter = ""
        End If
    End Sub
End Class