Imports ThuVien

Public Class FrmThongKeDonHang

    Dim TkDonHang As DataTable
    Dim TkDonHangView As DataView


    Private Sub FrmThongKeDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TkDonHang = DuLieu.DocDuLieu("SELECT count(dh_ma) AS dh_sl, format(dh_ngay, 'MM/dd/yyyy') AS ngay FROM DonHang WHERE dh_trang_thai <> 200 GROUP BY format(dh_ngay, 'MM/dd/yyyy')")
        TkDonHangView = New DataView(TkDonHang)
        dtGrid_tk_dh.DataSource = TkDonHangView

        date_tk_dh_from.Format = DateTimePickerFormat.Custom
        date_tk_dh_from.CustomFormat = "MM/dd/yyyy"
        date_tk_dh_to.Format = DateTimePickerFormat.Custom
        date_tk_dh_to.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub btn_tk_dh_loc_Click(sender As Object, e As EventArgs) Handles btn_tk_dh_loc.Click
        If date_tk_dh_from.Text IsNot Nothing And date_tk_dh_to.Text IsNot Nothing Then
            TkDonHangView.RowFilter = "ngay >= #" + date_tk_dh_from.Value.ToString("MM/dd/yyyy") +
         "# And ngay <= #" + date_tk_dh_to.Value.ToString("MM/dd/yyyy") + "#"
        ElseIf date_tk_dh_from.Text IsNot Nothing And date_tk_dh_to.Text Is Nothing Then
            TkDonHangView.RowFilter = "ngay >= #" + date_tk_dh_from.Value.ToString("MM/dd/yyyy") + "#"
        ElseIf date_tk_dh_from.Text Is Nothing And date_tk_dh_to.Text IsNot Nothing Then
            TkDonHangView.RowFilter = "ngay <= #" + date_tk_dh_to.Value.ToString("MM/dd/yyyy") + "#"
        Else
            TkDonHangView.RowFilter = ""
        End If
    End Sub
End Class