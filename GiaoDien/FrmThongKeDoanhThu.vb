Imports ThuVien

Public Class FrmThongKeDoanhThu

    Dim TkDoanhThu As DataTable
    Dim TkDoanhThuView As DataView

    Private Sub FrmThongKeDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TkDoanhThu = DuLieu.DocDuLieu("SELECT Sum(dh_tong_tien)-Sum(dh_tien_khuyen_mai) AS doanh_thu, ngay FROM (select dh_tong_tien, dh_tien_khuyen_mai,  format(dh_ngay, 'MM/dd/yyyy') AS ngay from DonHang order by dh_ngay desc) GROUP BY ngay")
        TkDoanhThuView = New DataView(TkDoanhThu)
        dtGridTkDoanhThu.DataSource = TkDoanhThuView

        date_tk_doanh_thu_from.Format = DateTimePickerFormat.Custom
        date_tk_doanh_thu_from.CustomFormat = "MM/dd/yyyy"
        date_tk_doanh_thu_to.Format = DateTimePickerFormat.Custom
        date_tk_doanh_thu_to.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub btn_tk_doanh_thu_loc_Click(sender As Object, e As EventArgs) Handles btn_tk_doanh_thu_loc.Click
        If date_tk_doanh_thu_from.Text IsNot Nothing And date_tk_doanh_thu_to.Text IsNot Nothing Then
            TkDoanhThuView.RowFilter = "ngay >= #" + date_tk_doanh_thu_from.Value.ToString("MM/dd/yyyy") +
         "# And ngay <= #" + date_tk_doanh_thu_to.Value.ToString("MM/dd/yyyy") + "#"
        ElseIf date_tk_doanh_thu_from.Text IsNot Nothing And date_tk_doanh_thu_to.Text Is Nothing Then
            TkDoanhThuView.RowFilter = "ngay >= #" + date_tk_doanh_thu_from.Value.ToString("MM/dd/yyyy") + "#"
        ElseIf date_tk_doanh_thu_from.Text Is Nothing And date_tk_doanh_thu_to.Text IsNot Nothing Then
            TkDoanhThuView.RowFilter = "ngay <= #" + date_tk_doanh_thu_to.Value.ToString("MM/dd/yyyy") + "#"
        Else
            TkDoanhThuView.RowFilter = ""
        End If
    End Sub


End Class