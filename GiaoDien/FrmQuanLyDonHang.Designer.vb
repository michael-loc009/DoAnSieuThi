<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyDonHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtGridDonHang = New System.Windows.Forms.DataGridView()
        Me.dh_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_khach_hang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_nguon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_chi_nhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_ghi_chi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_trang_thai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.dtGridChiTietDonHang = New System.Windows.Forms.DataGridView()
        Me.ctdh_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctdh_don_hang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctdh_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctdh_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctdh_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctdh_khuyen_mai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.numSoluong = New System.Windows.Forms.NumericUpDown()
        Me.cbKhuyenMai = New System.Windows.Forms.ComboBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.cbSanPham = New System.Windows.Forms.ComboBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.cbNguon = New System.Windows.Forms.ComboBox()
        Me.cbChiNhanh = New System.Windows.Forms.ComboBox()
        Me.cbKhachHang = New System.Windows.Forms.ComboBox()
        Me.dateNgayTao = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThemSanPham = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGridChiTietDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.numSoluong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridDonHang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTimKiem)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridChiTietDonHang)
        Me.SplitContainer1.Size = New System.Drawing.Size(369, 450)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridDonHang
        '
        Me.dtGridDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridDonHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dh_ma, Me.dh_ngay, Me.dh_khach_hang, Me.dh_nguon, Me.dh_chi_nhanh, Me.dh_ghi_chi, Me.dh_trang_thai})
        Me.dtGridDonHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridDonHang.Location = New System.Drawing.Point(0, 23)
        Me.dtGridDonHang.Name = "dtGridDonHang"
        Me.dtGridDonHang.RowTemplate.Height = 25
        Me.dtGridDonHang.Size = New System.Drawing.Size(369, 205)
        Me.dtGridDonHang.TabIndex = 1
        '
        'dh_ma
        '
        Me.dh_ma.HeaderText = "Mã"
        Me.dh_ma.Name = "dh_ma"
        '
        'dh_ngay
        '
        Me.dh_ngay.HeaderText = "Ngày"
        Me.dh_ngay.Name = "dh_ngay"
        '
        'dh_khach_hang
        '
        Me.dh_khach_hang.HeaderText = "Khách hàng"
        Me.dh_khach_hang.Name = "dh_khach_hang"
        '
        'dh_nguon
        '
        Me.dh_nguon.HeaderText = "Nguồn"
        Me.dh_nguon.Name = "dh_nguon"
        '
        'dh_chi_nhanh
        '
        Me.dh_chi_nhanh.HeaderText = "Chi nhánh"
        Me.dh_chi_nhanh.Name = "dh_chi_nhanh"
        '
        'dh_ghi_chi
        '
        Me.dh_ghi_chi.HeaderText = "Ghi chú"
        Me.dh_ghi_chi.Name = "dh_ghi_chi"
        '
        'dh_trang_thai
        '
        Me.dh_trang_thai.HeaderText = "Trạng thái"
        Me.dh_trang_thai.Name = "dh_trang_thai"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTimKiem.Location = New System.Drawing.Point(0, 0)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(369, 23)
        Me.txtTimKiem.TabIndex = 0
        '
        'dtGridChiTietDonHang
        '
        Me.dtGridChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridChiTietDonHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ctdh_ma, Me.ctdh_don_hang, Me.ctdh_san_pham, Me.ctdh_gia, Me.ctdh_so_luong, Me.ctdh_khuyen_mai})
        Me.dtGridChiTietDonHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridChiTietDonHang.Location = New System.Drawing.Point(0, 0)
        Me.dtGridChiTietDonHang.Name = "dtGridChiTietDonHang"
        Me.dtGridChiTietDonHang.RowTemplate.Height = 25
        Me.dtGridChiTietDonHang.Size = New System.Drawing.Size(369, 218)
        Me.dtGridChiTietDonHang.TabIndex = 0
        '
        'ctdh_ma
        '
        Me.ctdh_ma.HeaderText = "Mã"
        Me.ctdh_ma.Name = "ctdh_ma"
        '
        'ctdh_don_hang
        '
        Me.ctdh_don_hang.HeaderText = "Đơn hàng"
        Me.ctdh_don_hang.Name = "ctdh_don_hang"
        '
        'ctdh_san_pham
        '
        Me.ctdh_san_pham.HeaderText = "Sản phẩm"
        Me.ctdh_san_pham.Name = "ctdh_san_pham"
        '
        'ctdh_gia
        '
        Me.ctdh_gia.HeaderText = "Giá"
        Me.ctdh_gia.Name = "ctdh_gia"
        '
        'ctdh_so_luong
        '
        Me.ctdh_so_luong.HeaderText = "Số lượng"
        Me.ctdh_so_luong.Name = "ctdh_so_luong"
        '
        'ctdh_khuyen_mai
        '
        Me.ctdh_khuyen_mai.HeaderText = "Khuyến mãi"
        Me.ctdh_khuyen_mai.Name = "ctdh_khuyen_mai"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.numSoluong)
        Me.Panel2.Controls.Add(Me.cbKhuyenMai)
        Me.Panel2.Controls.Add(Me.txtGia)
        Me.Panel2.Controls.Add(Me.cbSanPham)
        Me.Panel2.Controls.Add(Me.txtGhiChu)
        Me.Panel2.Controls.Add(Me.cbNguon)
        Me.Panel2.Controls.Add(Me.cbChiNhanh)
        Me.Panel2.Controls.Add(Me.cbKhachHang)
        Me.Panel2.Controls.Add(Me.dateNgayTao)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(369, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 447)
        Me.Panel2.TabIndex = 7
        '
        'numSoluong
        '
        Me.numSoluong.Location = New System.Drawing.Point(217, 313)
        Me.numSoluong.Name = "numSoluong"
        Me.numSoluong.Size = New System.Drawing.Size(152, 23)
        Me.numSoluong.TabIndex = 22
        '
        'cbKhuyenMai
        '
        Me.cbKhuyenMai.FormattingEnabled = True
        Me.cbKhuyenMai.Location = New System.Drawing.Point(217, 280)
        Me.cbKhuyenMai.Name = "cbKhuyenMai"
        Me.cbKhuyenMai.Size = New System.Drawing.Size(200, 23)
        Me.cbKhuyenMai.TabIndex = 21
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(217, 247)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(200, 23)
        Me.txtGia.TabIndex = 20
        '
        'cbSanPham
        '
        Me.cbSanPham.FormattingEnabled = True
        Me.cbSanPham.Location = New System.Drawing.Point(217, 214)
        Me.cbSanPham.Name = "cbSanPham"
        Me.cbSanPham.Size = New System.Drawing.Size(200, 23)
        Me.cbSanPham.TabIndex = 19
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(217, 169)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(200, 23)
        Me.txtGhiChu.TabIndex = 18
        '
        'cbNguon
        '
        Me.cbNguon.FormattingEnabled = True
        Me.cbNguon.Location = New System.Drawing.Point(217, 129)
        Me.cbNguon.Name = "cbNguon"
        Me.cbNguon.Size = New System.Drawing.Size(200, 23)
        Me.cbNguon.TabIndex = 17
        '
        'cbChiNhanh
        '
        Me.cbChiNhanh.FormattingEnabled = True
        Me.cbChiNhanh.Location = New System.Drawing.Point(217, 89)
        Me.cbChiNhanh.Name = "cbChiNhanh"
        Me.cbChiNhanh.Size = New System.Drawing.Size(200, 23)
        Me.cbChiNhanh.TabIndex = 16
        '
        'cbKhachHang
        '
        Me.cbKhachHang.FormattingEnabled = True
        Me.cbKhachHang.Location = New System.Drawing.Point(217, 49)
        Me.cbKhachHang.Name = "cbKhachHang"
        Me.cbKhachHang.Size = New System.Drawing.Size(200, 23)
        Me.cbKhachHang.TabIndex = 15
        '
        'dateNgayTao
        '
        Me.dateNgayTao.Location = New System.Drawing.Point(217, 9)
        Me.dateNgayTao.Name = "dateNgayTao"
        Me.dateNgayTao.Size = New System.Drawing.Size(200, 23)
        Me.dateNgayTao.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(165, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nguồn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ghi chú"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Số lượng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Khuyễn mãi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ngày tạo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sản phẩm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Chi nhánh"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnThemSanPham)
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Location = New System.Drawing.Point(61, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 51)
        Me.Panel1.TabIndex = 5
        '
        'btnThemSanPham
        '
        Me.btnThemSanPham.Location = New System.Drawing.Point(3, 15)
        Me.btnThemSanPham.Name = "btnThemSanPham"
        Me.btnThemSanPham.Size = New System.Drawing.Size(118, 23)
        Me.btnThemSanPham.TabIndex = 19
        Me.btnThemSanPham.Text = "Thêm Sản phẩm"
        Me.btnThemSanPham.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(159, 15)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(385, 15)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(272, 15)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'FrmQuanLyDonHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyDonHang"
        Me.Text = "Quản lý đơn hàng"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGridChiTietDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.numSoluong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dtGridDonHang As DataGridView
    Friend WithEvents dh_ma As DataGridViewTextBoxColumn
    Friend WithEvents dh_ngay As DataGridViewTextBoxColumn
    Friend WithEvents dh_khach_hang As DataGridViewTextBoxColumn
    Friend WithEvents dh_nguon As DataGridViewTextBoxColumn
    Friend WithEvents dh_chi_nhanh As DataGridViewTextBoxColumn
    Friend WithEvents dh_ghi_chi As DataGridViewTextBoxColumn
    Friend WithEvents dh_trang_thai As DataGridViewTextBoxColumn
    Friend WithEvents dtGridChiTietDonHang As DataGridView
    Friend WithEvents ctdh_ma As DataGridViewTextBoxColumn
    Friend WithEvents ctdh_don_hang As DataGridViewTextBoxColumn
    Friend WithEvents ctdh_san_pham As DataGridViewTextBoxColumn
    Friend WithEvents ctdh_gia As DataGridViewTextBoxColumn
    Friend WithEvents ctdh_so_luong As DataGridViewTextBoxColumn
    Friend WithEvents ctdh_khuyen_mai As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateNgayTao As DateTimePicker
    Friend WithEvents cbKhachHang As ComboBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents cbNguon As ComboBox
    Friend WithEvents txtGhiChu As TextBox
    Friend WithEvents btnThemSanPham As Button
    Friend WithEvents cbSanPham As ComboBox
    Friend WithEvents txtGia As TextBox
    Friend WithEvents cbKhuyenMai As ComboBox
    Friend WithEvents numSoluong As NumericUpDown
End Class
