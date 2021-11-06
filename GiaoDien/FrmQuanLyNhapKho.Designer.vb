<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQuanLyNhapKho
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtGridNhapKho = New System.Windows.Forms.DataGridView()
        Me.nk_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nk_ngay_tao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cn_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nk_ma_chi_nhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nk_xoa = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_loc_phieu_nhap_kho = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_to_nhap_kho = New System.Windows.Forms.DateTimePicker()
        Me.date_from_nhap_kho = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_nk_chi_nhanh = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_nk_xoa = New System.Windows.Forms.Button()
        Me.btn_nk_sua = New System.Windows.Forms.Button()
        Me.btn_nk_them = New System.Windows.Forms.Button()
        Me.dtGridChiTietXuatKho = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_nk_ngay_tao = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nk_xoa_san_pham = New System.Windows.Forms.Button()
        Me.btn_nk_them_san_pham = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_nk_ten_san_pham = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.num_nk_gia_san_pham = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.num_nk_sl_san_pham = New System.Windows.Forms.NumericUpDown()
        Me.tooltip_nk_them_sp = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltip_nk_xoa_sp = New System.Windows.Forms.ToolTip(Me.components)
        Me.err_provider_nk_ten_sp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_nk_cn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_nk_sl_sp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_nkct = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.nkct_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nkct_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nkct_thanh_tien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nkct_ma_nhap_kho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nkct_ma_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridNhapKho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtGridChiTietXuatKho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.num_nk_sl_san_pham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_nk_ten_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_nk_cn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_nk_sl_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_nkct, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridNhapKho)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cb_nk_chi_nhanh)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridChiTietXuatKho)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.date_nk_ngay_tao)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 558)
        Me.SplitContainer1.SplitterDistance = 325
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridNhapKho
        '
        Me.dtGridNhapKho.AllowUserToAddRows = False
        Me.dtGridNhapKho.AllowUserToDeleteRows = False
        Me.dtGridNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridNhapKho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nk_ma, Me.nk_ngay_tao, Me.cn_ten, Me.nk_ma_chi_nhanh, Me.nk_xoa})
        Me.dtGridNhapKho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridNhapKho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridNhapKho.Location = New System.Drawing.Point(0, 128)
        Me.dtGridNhapKho.MultiSelect = False
        Me.dtGridNhapKho.Name = "dtGridNhapKho"
        Me.dtGridNhapKho.ReadOnly = True
        Me.dtGridNhapKho.RowTemplate.Height = 25
        Me.dtGridNhapKho.Size = New System.Drawing.Size(325, 430)
        Me.dtGridNhapKho.TabIndex = 1
        '
        'nk_ma
        '
        Me.nk_ma.DataPropertyName = "nk_ma"
        Me.nk_ma.HeaderText = "Mã"
        Me.nk_ma.Name = "nk_ma"
        Me.nk_ma.ReadOnly = True
        '
        'nk_ngay_tao
        '
        Me.nk_ngay_tao.DataPropertyName = "nk_ngay_tao"
        Me.nk_ngay_tao.HeaderText = "Ngày tạo"
        Me.nk_ngay_tao.Name = "nk_ngay_tao"
        Me.nk_ngay_tao.ReadOnly = True
        '
        'cn_ten
        '
        Me.cn_ten.DataPropertyName = "cn_ten"
        Me.cn_ten.HeaderText = "Chi nhánh"
        Me.cn_ten.Name = "cn_ten"
        Me.cn_ten.ReadOnly = True
        '
        'nk_ma_chi_nhanh
        '
        Me.nk_ma_chi_nhanh.DataPropertyName = "nk_ma_chi_nhanh"
        Me.nk_ma_chi_nhanh.HeaderText = "Mã chi nhánh"
        Me.nk_ma_chi_nhanh.Name = "nk_ma_chi_nhanh"
        Me.nk_ma_chi_nhanh.ReadOnly = True
        Me.nk_ma_chi_nhanh.Visible = False
        '
        'nk_xoa
        '
        Me.nk_xoa.DataPropertyName = "nk_xoa"
        Me.nk_xoa.HeaderText = "Xóa"
        Me.nk_xoa.Name = "nk_xoa"
        Me.nk_xoa.ReadOnly = True
        Me.nk_xoa.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_loc_phieu_nhap_kho)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.date_to_nhap_kho)
        Me.GroupBox1.Controls.Add(Me.date_from_nhap_kho)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lọc dữ liệu"
        '
        'btn_loc_phieu_nhap_kho
        '
        Me.btn_loc_phieu_nhap_kho.Location = New System.Drawing.Point(121, 90)
        Me.btn_loc_phieu_nhap_kho.Name = "btn_loc_phieu_nhap_kho"
        Me.btn_loc_phieu_nhap_kho.Size = New System.Drawing.Size(75, 23)
        Me.btn_loc_phieu_nhap_kho.TabIndex = 4
        Me.btn_loc_phieu_nhap_kho.Text = "Lọc"
        Me.btn_loc_phieu_nhap_kho.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(27, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Đến:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Từ:"
        '
        'date_to_nhap_kho
        '
        Me.date_to_nhap_kho.Location = New System.Drawing.Point(70, 51)
        Me.date_to_nhap_kho.Name = "date_to_nhap_kho"
        Me.date_to_nhap_kho.Size = New System.Drawing.Size(200, 23)
        Me.date_to_nhap_kho.TabIndex = 1
        '
        'date_from_nhap_kho
        '
        Me.date_from_nhap_kho.Location = New System.Drawing.Point(70, 22)
        Me.date_from_nhap_kho.Name = "date_from_nhap_kho"
        Me.date_from_nhap_kho.Size = New System.Drawing.Size(200, 23)
        Me.date_from_nhap_kho.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(86, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Chi nhánh:"
        '
        'cb_nk_chi_nhanh
        '
        Me.cb_nk_chi_nhanh.FormattingEnabled = True
        Me.cb_nk_chi_nhanh.Location = New System.Drawing.Point(182, 61)
        Me.cb_nk_chi_nhanh.Name = "cb_nk_chi_nhanh"
        Me.cb_nk_chi_nhanh.Size = New System.Drawing.Size(197, 23)
        Me.cb_nk_chi_nhanh.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_nk_xoa)
        Me.Panel1.Controls.Add(Me.btn_nk_sua)
        Me.Panel1.Controls.Add(Me.btn_nk_them)
        Me.Panel1.Location = New System.Drawing.Point(86, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 48)
        Me.Panel1.TabIndex = 16
        '
        'btn_nk_xoa
        '
        Me.btn_nk_xoa.Location = New System.Drawing.Point(218, 21)
        Me.btn_nk_xoa.Name = "btn_nk_xoa"
        Me.btn_nk_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_nk_xoa.TabIndex = 2
        Me.btn_nk_xoa.Text = "Xóa"
        Me.btn_nk_xoa.UseVisualStyleBackColor = True
        '
        'btn_nk_sua
        '
        Me.btn_nk_sua.Location = New System.Drawing.Point(123, 21)
        Me.btn_nk_sua.Name = "btn_nk_sua"
        Me.btn_nk_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_nk_sua.TabIndex = 1
        Me.btn_nk_sua.Text = "Sửa"
        Me.btn_nk_sua.UseVisualStyleBackColor = True
        '
        'btn_nk_them
        '
        Me.btn_nk_them.Location = New System.Drawing.Point(24, 21)
        Me.btn_nk_them.Name = "btn_nk_them"
        Me.btn_nk_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_nk_them.TabIndex = 0
        Me.btn_nk_them.Text = "Thêm"
        Me.btn_nk_them.UseVisualStyleBackColor = True
        '
        'dtGridChiTietXuatKho
        '
        Me.dtGridChiTietXuatKho.AllowUserToAddRows = False
        Me.dtGridChiTietXuatKho.AllowUserToDeleteRows = False
        Me.dtGridChiTietXuatKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridChiTietXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridChiTietXuatKho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nkct_ma, Me.sp_ten, Me.sp_gia, Me.nkct_so_luong, Me.nkct_thanh_tien, Me.nkct_ma_nhap_kho, Me.nkct_ma_san_pham})
        Me.dtGridChiTietXuatKho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridChiTietXuatKho.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtGridChiTietXuatKho.Location = New System.Drawing.Point(0, 373)
        Me.dtGridChiTietXuatKho.MultiSelect = False
        Me.dtGridChiTietXuatKho.Name = "dtGridChiTietXuatKho"
        Me.dtGridChiTietXuatKho.ReadOnly = True
        Me.dtGridChiTietXuatKho.RowTemplate.Height = 25
        Me.dtGridChiTietXuatKho.Size = New System.Drawing.Size(471, 185)
        Me.dtGridChiTietXuatKho.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(84, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ngày tạo:"
        '
        'date_nk_ngay_tao
        '
        Me.date_nk_ngay_tao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_nk_ngay_tao.Enabled = False
        Me.date_nk_ngay_tao.Location = New System.Drawing.Point(180, 22)
        Me.date_nk_ngay_tao.Name = "date_nk_ngay_tao"
        Me.date_nk_ngay_tao.Size = New System.Drawing.Size(200, 23)
        Me.date_nk_ngay_tao.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_nk_xoa_san_pham)
        Me.GroupBox2.Controls.Add(Me.btn_nk_them_san_pham)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cb_nk_ten_san_pham)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.num_nk_gia_san_pham)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.num_nk_sl_san_pham)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 206)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thêm sản phẩm"
        '
        'btn_nk_xoa_san_pham
        '
        Me.btn_nk_xoa_san_pham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_nk_xoa_san_pham.Location = New System.Drawing.Point(213, 156)
        Me.btn_nk_xoa_san_pham.Name = "btn_nk_xoa_san_pham"
        Me.btn_nk_xoa_san_pham.Size = New System.Drawing.Size(38, 34)
        Me.btn_nk_xoa_san_pham.TabIndex = 15
        Me.btn_nk_xoa_san_pham.Text = "-"
        Me.btn_nk_xoa_san_pham.UseVisualStyleBackColor = True
        '
        'btn_nk_them_san_pham
        '
        Me.btn_nk_them_san_pham.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nk_them_san_pham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_nk_them_san_pham.Location = New System.Drawing.Point(131, 156)
        Me.btn_nk_them_san_pham.Name = "btn_nk_them_san_pham"
        Me.btn_nk_them_san_pham.Size = New System.Drawing.Size(37, 34)
        Me.btn_nk_them_san_pham.TabIndex = 14
        Me.btn_nk_them_san_pham.Text = "+"
        Me.btn_nk_them_san_pham.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(34, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên sản phẩm:"
        '
        'cb_nk_ten_san_pham
        '
        Me.cb_nk_ten_san_pham.FormattingEnabled = True
        Me.cb_nk_ten_san_pham.Location = New System.Drawing.Point(131, 26)
        Me.cb_nk_ten_san_pham.Name = "cb_nk_ten_san_pham"
        Me.cb_nk_ten_san_pham.Size = New System.Drawing.Size(200, 23)
        Me.cb_nk_ten_san_pham.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(34, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Số lượng:"
        '
        'num_nk_gia_san_pham
        '
        Me.num_nk_gia_san_pham.Enabled = False
        Me.num_nk_gia_san_pham.Location = New System.Drawing.Point(131, 74)
        Me.num_nk_gia_san_pham.Name = "num_nk_gia_san_pham"
        Me.num_nk_gia_san_pham.Size = New System.Drawing.Size(200, 23)
        Me.num_nk_gia_san_pham.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(34, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Đơn giá:"
        '
        'num_nk_sl_san_pham
        '
        Me.num_nk_sl_san_pham.Location = New System.Drawing.Point(131, 124)
        Me.num_nk_sl_san_pham.Name = "num_nk_sl_san_pham"
        Me.num_nk_sl_san_pham.Size = New System.Drawing.Size(120, 23)
        Me.num_nk_sl_san_pham.TabIndex = 1
        '
        'err_provider_nk_ten_sp
        '
        Me.err_provider_nk_ten_sp.ContainerControl = Me
        '
        'err_provider_nk_cn
        '
        Me.err_provider_nk_cn.ContainerControl = Me
        '
        'err_provider_nk_sl_sp
        '
        Me.err_provider_nk_sl_sp.ContainerControl = Me
        '
        'err_provider_nkct
        '
        Me.err_provider_nkct.ContainerControl = Me
        '
        'nkct_ma
        '
        Me.nkct_ma.DataPropertyName = "nkct_ma"
        Me.nkct_ma.HeaderText = "Mã"
        Me.nkct_ma.Name = "nkct_ma"
        Me.nkct_ma.ReadOnly = True
        '
        'sp_ten
        '
        Me.sp_ten.DataPropertyName = "sp_ten"
        Me.sp_ten.HeaderText = "Sản phẩm"
        Me.sp_ten.Name = "sp_ten"
        Me.sp_ten.ReadOnly = True
        '
        'sp_gia
        '
        Me.sp_gia.DataPropertyName = "sp_gia"
        Me.sp_gia.HeaderText = "Giá"
        Me.sp_gia.Name = "sp_gia"
        Me.sp_gia.ReadOnly = True
        '
        'nkct_so_luong
        '
        Me.nkct_so_luong.DataPropertyName = "nkct_so_luong"
        Me.nkct_so_luong.HeaderText = "Số lượng"
        Me.nkct_so_luong.Name = "nkct_so_luong"
        Me.nkct_so_luong.ReadOnly = True
        '
        'nkct_thanh_tien
        '
        Me.nkct_thanh_tien.DataPropertyName = "nkct_thanh_tien"
        Me.nkct_thanh_tien.HeaderText = "Thành tiền"
        Me.nkct_thanh_tien.Name = "nkct_thanh_tien"
        Me.nkct_thanh_tien.ReadOnly = True
        '
        'nkct_ma_nhap_kho
        '
        Me.nkct_ma_nhap_kho.DataPropertyName = "nkct_ma_nhap_kho"
        Me.nkct_ma_nhap_kho.HeaderText = "Mã nhập kho"
        Me.nkct_ma_nhap_kho.Name = "nkct_ma_nhap_kho"
        Me.nkct_ma_nhap_kho.ReadOnly = True
        Me.nkct_ma_nhap_kho.Visible = False
        '
        'nkct_ma_san_pham
        '
        Me.nkct_ma_san_pham.DataPropertyName = "nkct_ma_san_pham"
        Me.nkct_ma_san_pham.HeaderText = "Mã sản phẩm"
        Me.nkct_ma_san_pham.Name = "nkct_ma_san_pham"
        Me.nkct_ma_san_pham.ReadOnly = True
        Me.nkct_ma_san_pham.Visible = False
        '
        'FrmQuanLyNhapKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyNhapKho"
        Me.Text = "Quản lý nhập kho"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridNhapKho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtGridChiTietXuatKho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.num_nk_sl_san_pham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_nk_ten_sp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_nk_cn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_nk_sl_sp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_nkct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date_to_nhap_kho As DateTimePicker
    Friend WithEvents date_from_nhap_kho As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_loc_phieu_nhap_kho As Button
    Friend WithEvents dtGridNhapKho As DataGridView
    Friend WithEvents date_nk_ngay_tao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_nk_ten_san_pham As ComboBox
    Friend WithEvents num_nk_gia_san_pham As TextBox
    Friend WithEvents num_nk_sl_san_pham As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_nk_them_san_pham As Button
    Friend WithEvents dtGridChiTietXuatKho As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_nk_xoa As Button
    Friend WithEvents btn_nk_sua As Button
    Friend WithEvents btn_nk_them As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_nk_chi_nhanh As ComboBox
    Friend WithEvents nk_ma As DataGridViewTextBoxColumn
    Friend WithEvents nk_ngay_tao As DataGridViewTextBoxColumn
    Friend WithEvents cn_ten As DataGridViewTextBoxColumn
    Friend WithEvents nk_ma_chi_nhanh As DataGridViewTextBoxColumn
    Friend WithEvents nk_xoa As DataGridViewCheckBoxColumn
    Friend WithEvents tooltip_nk_them_sp As ToolTip
    Friend WithEvents btn_nk_xoa_san_pham As Button
    Friend WithEvents tooltip_nk_xoa_sp As ToolTip
    Friend WithEvents err_provider_nk_ten_sp As ErrorProvider
    Friend WithEvents err_provider_nk_cn As ErrorProvider
    Friend WithEvents err_provider_nk_sl_sp As ErrorProvider
    Friend WithEvents err_provider_nkct As ErrorProvider
    Friend WithEvents nkct_ma As DataGridViewTextBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents sp_gia As DataGridViewTextBoxColumn
    Friend WithEvents nkct_so_luong As DataGridViewTextBoxColumn
    Friend WithEvents nkct_thanh_tien As DataGridViewTextBoxColumn
    Friend WithEvents nkct_ma_nhap_kho As DataGridViewTextBoxColumn
    Friend WithEvents nkct_ma_san_pham As DataGridViewTextBoxColumn
End Class
