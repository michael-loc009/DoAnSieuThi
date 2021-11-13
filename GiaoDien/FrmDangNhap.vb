Imports ThuVien


Public Class FrmDangNhap

    Private Sub btn_dang_nhap_Click(sender As Object, e As EventArgs) Handles btn_dang_nhap.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            Dim TaiKhoan As DataTable = DuLieu.DocDuLieu($"select * from TaiKhoan where tk_ten_dang_nhap = '{txt_dang_nhap_username.Text}'")

            If TaiKhoan.Rows.Count <= 0 Then
                ThuVien.ShowErrorDialog("Tên đăng nhập không hợp lệ", "Thông báo", MessageBoxIcon.Warning)
                Return
            End If

            Dim hashedPass As String = ThuVien.GetHash(txt_dang_nhap_pass.Text)

            If hashedPass <> TaiKhoan.Rows(0)("tk_mat_khau") Then
                ThuVien.ShowErrorDialog("Mật khẩu không hợp lệ", "Thông báo", MessageBoxIcon.Warning)
            Else
                Dim ThongTinTaiKhoan As DataTable = DuLieu.DocDuLieu($"SELECT a.*, b.tk_ma_loai, c.ltk_ten FROM (NguoiDung AS a INNER JOIN TaiKhoan AS b ON a.nd_ma_tai_khoan = b.tk_ma) INNER JOIN LoaiTaiKhoan AS c ON c.ltk_ma = b.tk_ma_loai where nd_ma_tai_khoan = {TaiKhoan.Rows(0)("tk_ma")}")

                If ThongTinTaiKhoan.Rows(0)("nd_xoa") = True Then
                    ThuVien.ShowErrorDialog("Tài khoản đã bị xóa", "Thông báo", MessageBoxIcon.Warning)
                    Return
                End If

                Index.DsQuyenCn = DuLieu.DocDuLieu($"select * from TaiKhoanChiNhanh where tkcn_ma_tai_khoan = {ThongTinTaiKhoan.Rows(0)("nd_ma_tai_khoan")} ")

                Index.DsQuyen = DuLieu.DocDuLieu($"select * from QuyenChucNang a inner join TaiKhoanQuyen b on a.qcn_ma_quyen = b.tkq_ma_quyen where b.tkq_ma_tai_khoan = {ThongTinTaiKhoan.Rows(0)("nd_ma_tai_khoan")}")


                Index.TaiKhoanDangNhap = ThongTinTaiKhoan.Rows(0)
                Me.DialogResult = DialogResult.Yes

            End If
        End If
    End Sub

    Private Sub FrmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_dang_nhap_pass.Text = "123123"
        txt_dang_nhap_username.Text = "quanly"
    End Sub

    Private Sub txt_dang_nhap_username_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_dang_nhap_username.Validating
        ThuVien.ValidateInput(txt_dang_nhap_username, e, err_provider_username, "", "Vui lòng nhập tên đăng nhập")
    End Sub

    Private Sub txt_dang_nhap_pass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_dang_nhap_pass.Validating
        ThuVien.ValidateInput(txt_dang_nhap_pass, e, err_provider_pass, "", "Vui lòng nhập mật khẩu")
    End Sub
End Class