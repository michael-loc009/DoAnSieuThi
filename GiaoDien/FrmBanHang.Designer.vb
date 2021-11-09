<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBanHang
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_dh_tim_sp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_dh_cn = New System.Windows.Forms.ComboBox()
        Me.dtGridSanPham = New System.Windows.Forms.DataGridView()
        Me.ma_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sl_ton_kho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nk_ma_chi_nhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_dh_them = New System.Windows.Forms.Button()
        Me.link_tao_khach_hang = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_dh_thanh_tien = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_dh_chiet_khau = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_dh_tong_tien = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_dh_tong_sp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_dh_khuyen_mai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_dh_khach_hang = New System.Windows.Forms.ComboBox()
        Me.date_dh_ngay_tao = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_dh_xoa_san_pham = New System.Windows.Forms.Button()
        Me.num_dh_sl_san_pham = New System.Windows.Forms.NumericUpDown()
        Me.btn_dh_them_san_pham = New System.Windows.Forms.Button()
        Me.dtGridDonHangChiTiet = New System.Windows.Forms.DataGridView()
        Me.dhct_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_ma_don_hang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_ma_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_gia_ban = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_thanh_tien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tooltip_dh_them_sp = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltip_dh_xoa_sp = New System.Windows.Forms.ToolTip(Me.components)
        Me.err_provider_dh_khach_hang = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_dhct = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cb_dh_trang_thai = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtGridSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.num_dh_sl_san_pham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGridDonHangChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_dh_khach_hang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_dhct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.link_tao_khach_hang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_dh_thanh_tien)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_dh_chiet_khau)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_dh_tong_tien)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_dh_tong_sp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cb_dh_khuyen_mai)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cb_dh_khach_hang)
        Me.SplitContainer1.Panel2.Controls.Add(Me.date_dh_ngay_tao)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SplitContainer1.Size = New System.Drawing.Size(1133, 541)
        Me.SplitContainer1.SplitterDistance = 376
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dtGridSanPham)
        Me.SplitContainer2.Size = New System.Drawing.Size(376, 541)
        Me.SplitContainer2.SplitterDistance = 97
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_dh_tim_sp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cb_dh_cn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 98)
        Me.Panel1.TabIndex = 7
        '
        'txt_dh_tim_sp
        '
        Me.txt_dh_tim_sp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_dh_tim_sp.Location = New System.Drawing.Point(0, 75)
        Me.txt_dh_tim_sp.Name = "txt_dh_tim_sp"
        Me.txt_dh_tim_sp.Size = New System.Drawing.Size(376, 23)
        Me.txt_dh_tim_sp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Chi nhánh:"
        '
        'cb_dh_cn
        '
        Me.cb_dh_cn.FormattingEnabled = True
        Me.cb_dh_cn.Location = New System.Drawing.Point(96, 25)
        Me.cb_dh_cn.Name = "cb_dh_cn"
        Me.cb_dh_cn.Size = New System.Drawing.Size(140, 23)
        Me.cb_dh_cn.TabIndex = 1
        '
        'dtGridSanPham
        '
        Me.dtGridSanPham.AllowUserToAddRows = False
        Me.dtGridSanPham.AllowUserToDeleteRows = False
        Me.dtGridSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ma_san_pham, Me.sp_ten, Me.sl_ton_kho, Me.sp_gia, Me.nk_ma_chi_nhanh})
        Me.dtGridSanPham.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridSanPham.Location = New System.Drawing.Point(0, 0)
        Me.dtGridSanPham.MultiSelect = False
        Me.dtGridSanPham.Name = "dtGridSanPham"
        Me.dtGridSanPham.ReadOnly = True
        Me.dtGridSanPham.RowTemplate.Height = 25
        Me.dtGridSanPham.Size = New System.Drawing.Size(376, 440)
        Me.dtGridSanPham.TabIndex = 1
        '
        'ma_san_pham
        '
        Me.ma_san_pham.DataPropertyName = "ma_san_pham"
        Me.ma_san_pham.HeaderText = "Mã"
        Me.ma_san_pham.Name = "ma_san_pham"
        Me.ma_san_pham.ReadOnly = True
        '
        'sp_ten
        '
        Me.sp_ten.DataPropertyName = "sp_ten"
        Me.sp_ten.HeaderText = "Tên"
        Me.sp_ten.Name = "sp_ten"
        Me.sp_ten.ReadOnly = True
        '
        'sl_ton_kho
        '
        Me.sl_ton_kho.DataPropertyName = "sl_ton_kho"
        Me.sl_ton_kho.HeaderText = "Số lượng tồn kho"
        Me.sl_ton_kho.Name = "sl_ton_kho"
        Me.sl_ton_kho.ReadOnly = True
        '
        'sp_gia
        '
        Me.sp_gia.DataPropertyName = "sp_gia"
        Me.sp_gia.HeaderText = "Giá"
        Me.sp_gia.Name = "sp_gia"
        Me.sp_gia.ReadOnly = True
        '
        'nk_ma_chi_nhanh
        '
        Me.nk_ma_chi_nhanh.DataPropertyName = "nk_ma_chi_nhanh"
        Me.nk_ma_chi_nhanh.HeaderText = "Mã chi nhánh"
        Me.nk_ma_chi_nhanh.Name = "nk_ma_chi_nhanh"
        Me.nk_ma_chi_nhanh.ReadOnly = True
        Me.nk_ma_chi_nhanh.Visible = False
        '
        'btn_dh_them
        '
        Me.btn_dh_them.Location = New System.Drawing.Point(257, 415)
        Me.btn_dh_them.Name = "btn_dh_them"
        Me.btn_dh_them.Size = New System.Drawing.Size(118, 23)
        Me.btn_dh_them.TabIndex = 22
        Me.btn_dh_them.Text = "Tạo đơn hàng"
        Me.btn_dh_them.UseVisualStyleBackColor = True
        '
        'link_tao_khach_hang
        '
        Me.link_tao_khach_hang.AutoSize = True
        Me.link_tao_khach_hang.Location = New System.Drawing.Point(416, 65)
        Me.link_tao_khach_hang.Name = "link_tao_khach_hang"
        Me.link_tao_khach_hang.Size = New System.Drawing.Size(105, 15)
        Me.link_tao_khach_hang.TabIndex = 21
        Me.link_tao_khach_hang.TabStop = True
        Me.link_tao_khach_hang.Text = "Tạo thẻ thành viên"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(106, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Thành tiền:"
        '
        'txt_dh_thanh_tien
        '
        Me.txt_dh_thanh_tien.Enabled = False
        Me.txt_dh_thanh_tien.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_dh_thanh_tien.Location = New System.Drawing.Point(210, 320)
        Me.txt_dh_thanh_tien.Name = "txt_dh_thanh_tien"
        Me.txt_dh_thanh_tien.ReadOnly = True
        Me.txt_dh_thanh_tien.Size = New System.Drawing.Size(200, 29)
        Me.txt_dh_thanh_tien.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(106, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Chiết khấu:"
        '
        'txt_dh_chiet_khau
        '
        Me.txt_dh_chiet_khau.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txt_dh_chiet_khau.ForeColor = System.Drawing.Color.Maroon
        Me.txt_dh_chiet_khau.Location = New System.Drawing.Point(210, 272)
        Me.txt_dh_chiet_khau.Name = "txt_dh_chiet_khau"
        Me.txt_dh_chiet_khau.ReadOnly = True
        Me.txt_dh_chiet_khau.Size = New System.Drawing.Size(200, 23)
        Me.txt_dh_chiet_khau.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(106, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tổng tiền:"
        '
        'txt_dh_tong_tien
        '
        Me.txt_dh_tong_tien.Enabled = False
        Me.txt_dh_tong_tien.Location = New System.Drawing.Point(210, 221)
        Me.txt_dh_tong_tien.Name = "txt_dh_tong_tien"
        Me.txt_dh_tong_tien.ReadOnly = True
        Me.txt_dh_tong_tien.Size = New System.Drawing.Size(200, 23)
        Me.txt_dh_tong_tien.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(106, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tổng sản phẩm:"
        '
        'txt_dh_tong_sp
        '
        Me.txt_dh_tong_sp.Enabled = False
        Me.txt_dh_tong_sp.Location = New System.Drawing.Point(210, 168)
        Me.txt_dh_tong_sp.Name = "txt_dh_tong_sp"
        Me.txt_dh_tong_sp.ReadOnly = True
        Me.txt_dh_tong_sp.Size = New System.Drawing.Size(200, 23)
        Me.txt_dh_tong_sp.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(105, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Khuyến mãi:"
        '
        'cb_dh_khuyen_mai
        '
        Me.cb_dh_khuyen_mai.FormattingEnabled = True
        Me.cb_dh_khuyen_mai.Location = New System.Drawing.Point(210, 115)
        Me.cb_dh_khuyen_mai.Name = "cb_dh_khuyen_mai"
        Me.cb_dh_khuyen_mai.Size = New System.Drawing.Size(200, 23)
        Me.cb_dh_khuyen_mai.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(106, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Khách hàng:"
        '
        'cb_dh_khach_hang
        '
        Me.cb_dh_khach_hang.FormattingEnabled = True
        Me.cb_dh_khach_hang.Location = New System.Drawing.Point(210, 62)
        Me.cb_dh_khach_hang.Name = "cb_dh_khach_hang"
        Me.cb_dh_khach_hang.Size = New System.Drawing.Size(200, 23)
        Me.cb_dh_khach_hang.TabIndex = 7
        '
        'date_dh_ngay_tao
        '
        Me.date_dh_ngay_tao.Enabled = False
        Me.date_dh_ngay_tao.Location = New System.Drawing.Point(210, 12)
        Me.date_dh_ngay_tao.Name = "date_dh_ngay_tao"
        Me.date_dh_ngay_tao.Size = New System.Drawing.Size(200, 23)
        Me.date_dh_ngay_tao.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(106, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ngày tạo:"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_dh_them)
        Me.SplitContainer3.Panel1.Controls.Add(Me.cb_dh_trang_thai)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer3.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.dtGridDonHangChiTiet)
        Me.SplitContainer3.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SplitContainer3.Size = New System.Drawing.Size(753, 541)
        Me.SplitContainer3.SplitterDistance = 465
        Me.SplitContainer3.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btn_dh_xoa_san_pham)
        Me.Panel2.Controls.Add(Me.num_dh_sl_san_pham)
        Me.Panel2.Controls.Add(Me.btn_dh_them_san_pham)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(99, 465)
        Me.Panel2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Số lượng:"
        '
        'btn_dh_xoa_san_pham
        '
        Me.btn_dh_xoa_san_pham.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dh_xoa_san_pham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dh_xoa_san_pham.Location = New System.Drawing.Point(28, 198)
        Me.btn_dh_xoa_san_pham.Name = "btn_dh_xoa_san_pham"
        Me.btn_dh_xoa_san_pham.Size = New System.Drawing.Size(34, 30)
        Me.btn_dh_xoa_san_pham.TabIndex = 12
        Me.btn_dh_xoa_san_pham.Text = "-"
        Me.btn_dh_xoa_san_pham.UseVisualStyleBackColor = True
        '
        'num_dh_sl_san_pham
        '
        Me.num_dh_sl_san_pham.Cursor = System.Windows.Forms.Cursors.Hand
        Me.num_dh_sl_san_pham.Location = New System.Drawing.Point(12, 118)
        Me.num_dh_sl_san_pham.Name = "num_dh_sl_san_pham"
        Me.num_dh_sl_san_pham.Size = New System.Drawing.Size(72, 23)
        Me.num_dh_sl_san_pham.TabIndex = 0
        '
        'btn_dh_them_san_pham
        '
        Me.btn_dh_them_san_pham.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dh_them_san_pham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_dh_them_san_pham.Location = New System.Drawing.Point(28, 147)
        Me.btn_dh_them_san_pham.Name = "btn_dh_them_san_pham"
        Me.btn_dh_them_san_pham.Size = New System.Drawing.Size(34, 30)
        Me.btn_dh_them_san_pham.TabIndex = 11
        Me.btn_dh_them_san_pham.Text = "+"
        Me.btn_dh_them_san_pham.UseVisualStyleBackColor = True
        '
        'dtGridDonHangChiTiet
        '
        Me.dtGridDonHangChiTiet.AllowUserToAddRows = False
        Me.dtGridDonHangChiTiet.AllowUserToDeleteRows = False
        Me.dtGridDonHangChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridDonHangChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridDonHangChiTiet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dhct_ma, Me.dhct_ma_don_hang, Me.dhct_ma_san_pham, Me.DataGridViewTextBoxColumn1, Me.dhct_so_luong, Me.dhct_gia_ban, Me.dhct_thanh_tien})
        Me.dtGridDonHangChiTiet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridDonHangChiTiet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridDonHangChiTiet.Location = New System.Drawing.Point(0, 0)
        Me.dtGridDonHangChiTiet.Name = "dtGridDonHangChiTiet"
        Me.dtGridDonHangChiTiet.ReadOnly = True
        Me.dtGridDonHangChiTiet.RowTemplate.Height = 25
        Me.dtGridDonHangChiTiet.Size = New System.Drawing.Size(753, 72)
        Me.dtGridDonHangChiTiet.TabIndex = 20
        '
        'dhct_ma
        '
        Me.dhct_ma.DataPropertyName = "dhct_ma"
        Me.dhct_ma.HeaderText = "Mã"
        Me.dhct_ma.Name = "dhct_ma"
        Me.dhct_ma.ReadOnly = True
        '
        'dhct_ma_don_hang
        '
        Me.dhct_ma_don_hang.DataPropertyName = "dhct_ma_don_hang"
        Me.dhct_ma_don_hang.HeaderText = "Mã đơn hàng"
        Me.dhct_ma_don_hang.Name = "dhct_ma_don_hang"
        Me.dhct_ma_don_hang.ReadOnly = True
        Me.dhct_ma_don_hang.Visible = False
        '
        'dhct_ma_san_pham
        '
        Me.dhct_ma_san_pham.DataPropertyName = "dhct_ma_san_pham"
        Me.dhct_ma_san_pham.HeaderText = "Mã sản phẩm"
        Me.dhct_ma_san_pham.Name = "dhct_ma_san_pham"
        Me.dhct_ma_san_pham.ReadOnly = True
        Me.dhct_ma_san_pham.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sp_ten"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sản phẩm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dhct_so_luong
        '
        Me.dhct_so_luong.DataPropertyName = "dhct_so_luong"
        Me.dhct_so_luong.HeaderText = "Số lượng"
        Me.dhct_so_luong.Name = "dhct_so_luong"
        Me.dhct_so_luong.ReadOnly = True
        '
        'dhct_gia_ban
        '
        Me.dhct_gia_ban.DataPropertyName = "dhct_gia_ban"
        Me.dhct_gia_ban.HeaderText = "Giá bán"
        Me.dhct_gia_ban.Name = "dhct_gia_ban"
        Me.dhct_gia_ban.ReadOnly = True
        '
        'dhct_thanh_tien
        '
        Me.dhct_thanh_tien.DataPropertyName = "dhct_thanh_tien"
        Me.dhct_thanh_tien.HeaderText = "Thành tiền"
        Me.dhct_thanh_tien.Name = "dhct_thanh_tien"
        Me.dhct_thanh_tien.ReadOnly = True
        '
        'err_provider_dh_khach_hang
        '
        Me.err_provider_dh_khach_hang.ContainerControl = Me
        '
        'err_provider_dhct
        '
        Me.err_provider_dhct.ContainerControl = Me
        '
        'cb_dh_trang_thai
        '
        Me.cb_dh_trang_thai.Enabled = False
        Me.cb_dh_trang_thai.FormattingEnabled = True
        Me.cb_dh_trang_thai.Location = New System.Drawing.Point(210, 375)
        Me.cb_dh_trang_thai.Name = "cb_dh_trang_thai"
        Me.cb_dh_trang_thai.Size = New System.Drawing.Size(200, 23)
        Me.cb_dh_trang_thai.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(111, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Thành tiền:"
        '
        'FrmBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1133, 541)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmBanHang"
        Me.Text = "Đơn hàng chi tiết"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtGridSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.num_dh_sl_san_pham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGridDonHangChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_dh_khach_hang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_dhct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_dh_tim_sp As TextBox
    Friend WithEvents dtGridSanPham As DataGridView
    Friend WithEvents cb_dh_cn As ComboBox
    Friend WithEvents date_dh_ngay_tao As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_dh_khach_hang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents num_dh_sl_san_pham As NumericUpDown
    Friend WithEvents btn_dh_them_san_pham As Button
    Friend WithEvents btn_dh_xoa_san_pham As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_dh_khuyen_mai As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_dh_tong_sp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_dh_tong_tien As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_dh_chiet_khau As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_dh_thanh_tien As TextBox
    Friend WithEvents dtGridDonHangChiTiet As DataGridView
    Friend WithEvents link_tao_khach_hang As LinkLabel
    Friend WithEvents btn_dh_them As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ma_san_pham As DataGridViewTextBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents sl_ton_kho As DataGridViewTextBoxColumn
    Friend WithEvents sp_gia As DataGridViewTextBoxColumn
    Friend WithEvents nk_ma_chi_nhanh As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents dhct_ma As DataGridViewTextBoxColumn
    Friend WithEvents dhct_ma_don_hang As DataGridViewTextBoxColumn
    Friend WithEvents dhct_ma_san_pham As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dhct_so_luong As DataGridViewTextBoxColumn
    Friend WithEvents dhct_gia_ban As DataGridViewTextBoxColumn
    Friend WithEvents dhct_thanh_tien As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tooltip_dh_them_sp As ToolTip
    Friend WithEvents tooltip_dh_xoa_sp As ToolTip
    Friend WithEvents err_provider_dh_khach_hang As ErrorProvider
    Friend WithEvents err_provider_dhct As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_dh_trang_thai As ComboBox
End Class
