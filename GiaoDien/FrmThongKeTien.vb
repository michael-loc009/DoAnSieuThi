Imports ThuVien

Public Class FrmThongKeTien

    Dim TKDoanhThuTrongNgay As DataTable
    Dim TkDoanhThuTrongNgayView As DataView

    Private Sub FrmThongKeTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDate As Date = Date.Now()

        TKDoanhThuTrongNgay = DuLieu.DocDuLieu($"SELECT Sum(dh_tong_tien)-Sum(dh_tien_khuyen_mai) AS doanh_thu, ngay FROM (select dh_tong_tien, dh_tien_khuyen_mai,  format(dh_ngay, 'MM/dd/yyyy') AS ngay from DonHang order by dh_ngay desc) where ngay = '{currentDate.ToString("MM/dd/yyyy")}' GROUP BY ngay")
        TkDoanhThuTrongNgayView = New DataView(TKDoanhThuTrongNgay)
        dtGrid_tk_tien.DataSource = TkDoanhThuTrongNgayView


        date_tk_tien.Format = DateTimePickerFormat.Custom
        date_tk_tien.CustomFormat = "MM/dd/yyyy"
    End Sub
End Class