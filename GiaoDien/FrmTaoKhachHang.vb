Public Class FrmTaoKhachHang

    Dim dsKhachHang As DataTable

    Private Sub FrmTaoKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsKhachHang = ThuVien.DocDuLieu("select * from KhachHang where kh_ma = 0")

        date_kh_ngay_tao.Format = DateTimePickerFormat.Custom
        date_kh_ngay_tao.CustomFormat = "dd-MM-yyyy HH:mm"
    End Sub

    Private Sub btn_kh_them_Click(sender As Object, e As EventArgs) Handles btn_kh_them.Click
        If ValidateChildren(ValidationConstraints.Enabled) Then
            Dim kh As DataRow = dsKhachHang.NewRow()
            kh("kh_ho_ten") = txt_kh_ho_ten.Text
            kh("kh_ngay_tao") = date_kh_ngay_tao.Value
            kh("kh_xoa") = False

            dsKhachHang.Rows.Add(kh)

            ThuVien.GhiDuLieu("KhachHang", dsKhachHang)

            Me.Close()

        End If
    End Sub

    Private Sub txt_kh_ho_ten_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_kh_ho_ten.Validating
        ThuVien.ValidateInput(txt_kh_ho_ten, e, err_provider_kh_ho_ten, "", "Vui lòng nhập họ và tên khách hàng")
    End Sub
End Class