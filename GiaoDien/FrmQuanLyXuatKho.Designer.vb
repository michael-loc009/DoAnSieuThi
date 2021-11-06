<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyXuatKho
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
        Me.dtGridXuatKho = New System.Windows.Forms.DataGridView()
        Me.xk_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xk_ma_chi_nhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xk_ngay_tao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cn_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xk_xoa = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_loc_phieu_xuat_kho = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_to_xuat_kho = New System.Windows.Forms.DateTimePicker()
        Me.date_from_xuat_kho = New System.Windows.Forms.DateTimePicker()
        Me.dtGridChiTietXuatKho = New System.Windows.Forms.DataGridView()
        Me.xkct_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xkct_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xkct_thanh_tien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xkct_ma_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xkct_ma_xuat_kho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_xk_chi_nhanh = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_xk_xoa = New System.Windows.Forms.Button()
        Me.btn_xk_sua = New System.Windows.Forms.Button()
        Me.btn_xk_them = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_xk_ngay_tao = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_xk_xoa_san_pham = New System.Windows.Forms.Button()
        Me.btn_xk_them_san_pham = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_xk_ten_san_pham = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.num_xk_gia_san_pham = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.num_xk_sl_san_pham = New System.Windows.Forms.NumericUpDown()
        Me.tooltip_xk_them_sp = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltip_xk_xoa_sp = New System.Windows.Forms.ToolTip(Me.components)
        Me.err_provider_xk_cn = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_xk_ten_sp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_xk_sl_sp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_xkct = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridXuatKho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtGridChiTietXuatKho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.num_xk_sl_san_pham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_xk_cn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_xk_ten_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_xk_sl_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_xkct, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridXuatKho)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridChiTietXuatKho)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 564)
        Me.SplitContainer1.SplitterDistance = 298
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridXuatKho
        '
        Me.dtGridXuatKho.AllowUserToAddRows = False
        Me.dtGridXuatKho.AllowUserToDeleteRows = False
        Me.dtGridXuatKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridXuatKho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.xk_ma, Me.xk_ma_chi_nhanh, Me.xk_ngay_tao, Me.cn_ten, Me.xk_xoa})
        Me.dtGridXuatKho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridXuatKho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridXuatKho.Location = New System.Drawing.Point(0, 128)
        Me.dtGridXuatKho.MultiSelect = False
        Me.dtGridXuatKho.Name = "dtGridXuatKho"
        Me.dtGridXuatKho.ReadOnly = True
        Me.dtGridXuatKho.RowTemplate.Height = 25
        Me.dtGridXuatKho.Size = New System.Drawing.Size(298, 436)
        Me.dtGridXuatKho.TabIndex = 2
        '
        'xk_ma
        '
        Me.xk_ma.DataPropertyName = "xk_ma"
        Me.xk_ma.HeaderText = "Mã"
        Me.xk_ma.Name = "xk_ma"
        Me.xk_ma.ReadOnly = True
        '
        'xk_ma_chi_nhanh
        '
        Me.xk_ma_chi_nhanh.DataPropertyName = "xk_ma_chi_nhanh"
        Me.xk_ma_chi_nhanh.HeaderText = "Mã Chi nhánh"
        Me.xk_ma_chi_nhanh.Name = "xk_ma_chi_nhanh"
        Me.xk_ma_chi_nhanh.ReadOnly = True
        Me.xk_ma_chi_nhanh.Visible = False
        '
        'xk_ngay_tao
        '
        Me.xk_ngay_tao.DataPropertyName = "xk_ngay_tao"
        Me.xk_ngay_tao.HeaderText = "Ngày tạo"
        Me.xk_ngay_tao.Name = "xk_ngay_tao"
        Me.xk_ngay_tao.ReadOnly = True
        '
        'cn_ten
        '
        Me.cn_ten.DataPropertyName = "cn_ten"
        Me.cn_ten.HeaderText = "Chi nhánh"
        Me.cn_ten.Name = "cn_ten"
        Me.cn_ten.ReadOnly = True
        '
        'xk_xoa
        '
        Me.xk_xoa.DataPropertyName = "xk_xoa"
        Me.xk_xoa.HeaderText = "Xóa"
        Me.xk_xoa.Name = "xk_xoa"
        Me.xk_xoa.ReadOnly = True
        Me.xk_xoa.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_loc_phieu_xuat_kho)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.date_to_xuat_kho)
        Me.GroupBox1.Controls.Add(Me.date_from_xuat_kho)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lọc dữ liệu"
        '
        'btn_loc_phieu_xuat_kho
        '
        Me.btn_loc_phieu_xuat_kho.Location = New System.Drawing.Point(121, 90)
        Me.btn_loc_phieu_xuat_kho.Name = "btn_loc_phieu_xuat_kho"
        Me.btn_loc_phieu_xuat_kho.Size = New System.Drawing.Size(75, 23)
        Me.btn_loc_phieu_xuat_kho.TabIndex = 4
        Me.btn_loc_phieu_xuat_kho.Text = "Lọc"
        Me.btn_loc_phieu_xuat_kho.UseVisualStyleBackColor = True
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
        'date_to_xuat_kho
        '
        Me.date_to_xuat_kho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_to_xuat_kho.Location = New System.Drawing.Point(70, 51)
        Me.date_to_xuat_kho.Name = "date_to_xuat_kho"
        Me.date_to_xuat_kho.Size = New System.Drawing.Size(200, 23)
        Me.date_to_xuat_kho.TabIndex = 1
        '
        'date_from_xuat_kho
        '
        Me.date_from_xuat_kho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_from_xuat_kho.Location = New System.Drawing.Point(70, 22)
        Me.date_from_xuat_kho.Name = "date_from_xuat_kho"
        Me.date_from_xuat_kho.Size = New System.Drawing.Size(200, 23)
        Me.date_from_xuat_kho.TabIndex = 0
        '
        'dtGridChiTietXuatKho
        '
        Me.dtGridChiTietXuatKho.AllowUserToAddRows = False
        Me.dtGridChiTietXuatKho.AllowUserToDeleteRows = False
        Me.dtGridChiTietXuatKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridChiTietXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridChiTietXuatKho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.xkct_ma, Me.sp_ten, Me.sp_gia, Me.xkct_so_luong, Me.xkct_thanh_tien, Me.xkct_ma_san_pham, Me.xkct_ma_xuat_kho})
        Me.dtGridChiTietXuatKho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridChiTietXuatKho.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtGridChiTietXuatKho.Location = New System.Drawing.Point(0, 392)
        Me.dtGridChiTietXuatKho.MultiSelect = False
        Me.dtGridChiTietXuatKho.Name = "dtGridChiTietXuatKho"
        Me.dtGridChiTietXuatKho.ReadOnly = True
        Me.dtGridChiTietXuatKho.RowTemplate.Height = 25
        Me.dtGridChiTietXuatKho.Size = New System.Drawing.Size(498, 172)
        Me.dtGridChiTietXuatKho.TabIndex = 1
        '
        'xkct_ma
        '
        Me.xkct_ma.DataPropertyName = "xkct_ma"
        Me.xkct_ma.HeaderText = "Mã"
        Me.xkct_ma.Name = "xkct_ma"
        Me.xkct_ma.ReadOnly = True
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
        'xkct_so_luong
        '
        Me.xkct_so_luong.DataPropertyName = "xkct_so_luong"
        Me.xkct_so_luong.HeaderText = "Số lượng"
        Me.xkct_so_luong.Name = "xkct_so_luong"
        Me.xkct_so_luong.ReadOnly = True
        '
        'xkct_thanh_tien
        '
        Me.xkct_thanh_tien.DataPropertyName = "xkct_thanh_tien"
        Me.xkct_thanh_tien.HeaderText = "Thành tiền"
        Me.xkct_thanh_tien.Name = "xkct_thanh_tien"
        Me.xkct_thanh_tien.ReadOnly = True
        '
        'xkct_ma_san_pham
        '
        Me.xkct_ma_san_pham.DataPropertyName = "xkct_ma_san_pham"
        Me.xkct_ma_san_pham.HeaderText = "Mã sản phẩm"
        Me.xkct_ma_san_pham.Name = "xkct_ma_san_pham"
        Me.xkct_ma_san_pham.ReadOnly = True
        Me.xkct_ma_san_pham.Visible = False
        '
        'xkct_ma_xuat_kho
        '
        Me.xkct_ma_xuat_kho.DataPropertyName = "xkct_ma_xuat_kho"
        Me.xkct_ma_xuat_kho.HeaderText = "Mã xuất kho"
        Me.xkct_ma_xuat_kho.Name = "xkct_ma_xuat_kho"
        Me.xkct_ma_xuat_kho.ReadOnly = True
        Me.xkct_ma_xuat_kho.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cb_xk_chi_nhanh)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.date_xk_ngay_tao)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 386)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(96, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Chi nhánh:"
        '
        'cb_xk_chi_nhanh
        '
        Me.cb_xk_chi_nhanh.FormattingEnabled = True
        Me.cb_xk_chi_nhanh.Location = New System.Drawing.Point(197, 52)
        Me.cb_xk_chi_nhanh.Name = "cb_xk_chi_nhanh"
        Me.cb_xk_chi_nhanh.Size = New System.Drawing.Size(199, 23)
        Me.cb_xk_chi_nhanh.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btn_xk_xoa)
        Me.Panel2.Controls.Add(Me.btn_xk_sua)
        Me.Panel2.Controls.Add(Me.btn_xk_them)
        Me.Panel2.Location = New System.Drawing.Point(102, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 51)
        Me.Panel2.TabIndex = 20
        '
        'btn_xk_xoa
        '
        Me.btn_xk_xoa.Location = New System.Drawing.Point(218, 21)
        Me.btn_xk_xoa.Name = "btn_xk_xoa"
        Me.btn_xk_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xk_xoa.TabIndex = 2
        Me.btn_xk_xoa.Text = "Xóa"
        Me.btn_xk_xoa.UseVisualStyleBackColor = True
        '
        'btn_xk_sua
        '
        Me.btn_xk_sua.Location = New System.Drawing.Point(123, 21)
        Me.btn_xk_sua.Name = "btn_xk_sua"
        Me.btn_xk_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_xk_sua.TabIndex = 1
        Me.btn_xk_sua.Text = "Sửa"
        Me.btn_xk_sua.UseVisualStyleBackColor = True
        '
        'btn_xk_them
        '
        Me.btn_xk_them.Location = New System.Drawing.Point(24, 21)
        Me.btn_xk_them.Name = "btn_xk_them"
        Me.btn_xk_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_xk_them.TabIndex = 0
        Me.btn_xk_them.Text = "Thêm"
        Me.btn_xk_them.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(101, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ngày tạo:"
        '
        'date_xk_ngay_tao
        '
        Me.date_xk_ngay_tao.Enabled = False
        Me.date_xk_ngay_tao.Location = New System.Drawing.Point(197, 10)
        Me.date_xk_ngay_tao.Name = "date_xk_ngay_tao"
        Me.date_xk_ngay_tao.Size = New System.Drawing.Size(200, 23)
        Me.date_xk_ngay_tao.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_xk_xoa_san_pham)
        Me.GroupBox2.Controls.Add(Me.btn_xk_them_san_pham)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cb_xk_ten_san_pham)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.num_xk_gia_san_pham)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.num_xk_sl_san_pham)
        Me.GroupBox2.Location = New System.Drawing.Point(67, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 206)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thêm sản phẩm"
        '
        'btn_xk_xoa_san_pham
        '
        Me.btn_xk_xoa_san_pham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xk_xoa_san_pham.Location = New System.Drawing.Point(213, 156)
        Me.btn_xk_xoa_san_pham.Name = "btn_xk_xoa_san_pham"
        Me.btn_xk_xoa_san_pham.Size = New System.Drawing.Size(38, 34)
        Me.btn_xk_xoa_san_pham.TabIndex = 15
        Me.btn_xk_xoa_san_pham.Text = "-"
        Me.btn_xk_xoa_san_pham.UseVisualStyleBackColor = True
        '
        'btn_xk_them_san_pham
        '
        Me.btn_xk_them_san_pham.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_xk_them_san_pham.Location = New System.Drawing.Point(130, 156)
        Me.btn_xk_them_san_pham.Name = "btn_xk_them_san_pham"
        Me.btn_xk_them_san_pham.Size = New System.Drawing.Size(37, 34)
        Me.btn_xk_them_san_pham.TabIndex = 14
        Me.btn_xk_them_san_pham.Text = "+"
        Me.btn_xk_them_san_pham.UseVisualStyleBackColor = True
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
        'cb_xk_ten_san_pham
        '
        Me.cb_xk_ten_san_pham.FormattingEnabled = True
        Me.cb_xk_ten_san_pham.Location = New System.Drawing.Point(131, 26)
        Me.cb_xk_ten_san_pham.Name = "cb_xk_ten_san_pham"
        Me.cb_xk_ten_san_pham.Size = New System.Drawing.Size(200, 23)
        Me.cb_xk_ten_san_pham.TabIndex = 3
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
        'num_xk_gia_san_pham
        '
        Me.num_xk_gia_san_pham.Enabled = False
        Me.num_xk_gia_san_pham.Location = New System.Drawing.Point(131, 74)
        Me.num_xk_gia_san_pham.Name = "num_xk_gia_san_pham"
        Me.num_xk_gia_san_pham.Size = New System.Drawing.Size(200, 23)
        Me.num_xk_gia_san_pham.TabIndex = 2
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
        'num_xk_sl_san_pham
        '
        Me.num_xk_sl_san_pham.Location = New System.Drawing.Point(131, 124)
        Me.num_xk_sl_san_pham.Name = "num_xk_sl_san_pham"
        Me.num_xk_sl_san_pham.Size = New System.Drawing.Size(120, 23)
        Me.num_xk_sl_san_pham.TabIndex = 1
        '
        'err_provider_xk_cn
        '
        Me.err_provider_xk_cn.ContainerControl = Me
        '
        'err_provider_xk_ten_sp
        '
        Me.err_provider_xk_ten_sp.ContainerControl = Me
        '
        'err_provider_xk_sl_sp
        '
        Me.err_provider_xk_sl_sp.ContainerControl = Me
        '
        'err_provider_xkct
        '
        Me.err_provider_xkct.ContainerControl = Me
        '
        'FrmQuanLyXuatKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 564)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyXuatKho"
        Me.Text = "Xuất kho"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridXuatKho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtGridChiTietXuatKho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.num_xk_sl_san_pham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_xk_cn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_xk_ten_sp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_xk_sl_sp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_xkct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_loc_phieu_xuat_kho As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents date_to_xuat_kho As DateTimePicker
    Friend WithEvents date_from_xuat_kho As DateTimePicker
    Friend WithEvents dtGridXuatKho As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_xk_xoa As Button
    Friend WithEvents btn_xk_sua As Button
    Friend WithEvents btn_xk_them As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents date_xk_ngay_tao As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_xk_them_san_pham As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_xk_ten_san_pham As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents num_xk_gia_san_pham As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents num_xk_sl_san_pham As NumericUpDown
    Friend WithEvents dtGridChiTietXuatKho As DataGridView
    Friend WithEvents cb_xk_chi_nhanh As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_xk_xoa_san_pham As Button
    Friend WithEvents tooltip_xk_them_sp As ToolTip
    Friend WithEvents tooltip_xk_xoa_sp As ToolTip
    Friend WithEvents xk_ma As DataGridViewTextBoxColumn
    Friend WithEvents xk_ma_chi_nhanh As DataGridViewTextBoxColumn
    Friend WithEvents xk_ngay_tao As DataGridViewTextBoxColumn
    Friend WithEvents cn_ten As DataGridViewTextBoxColumn
    Friend WithEvents xk_xoa As DataGridViewCheckBoxColumn
    Friend WithEvents xkct_ma As DataGridViewTextBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents sp_gia As DataGridViewTextBoxColumn
    Friend WithEvents xkct_so_luong As DataGridViewTextBoxColumn
    Friend WithEvents xkct_thanh_tien As DataGridViewTextBoxColumn
    Friend WithEvents xkct_ma_san_pham As DataGridViewTextBoxColumn
    Friend WithEvents xkct_ma_xuat_kho As DataGridViewTextBoxColumn
    Friend WithEvents err_provider_xk_cn As ErrorProvider
    Friend WithEvents err_provider_xk_ten_sp As ErrorProvider
    Friend WithEvents err_provider_xk_sl_sp As ErrorProvider
    Friend WithEvents err_provider_xkct As ErrorProvider
End Class
