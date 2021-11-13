<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmQuanLyDonHang
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_dh_sua = New System.Windows.Forms.Button()
        Me.btn_dh_them = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_loc_don_hang = New System.Windows.Forms.Button()
        Me.date_to_don_hang = New System.Windows.Forms.DateTimePicker()
        Me.date_from_don_hang = New System.Windows.Forms.DateTimePicker()
        Me.cb_dh_cn = New System.Windows.Forms.ComboBox()
        Me.dtGridDonHangChiTiet = New System.Windows.Forms.DataGridView()
        Me.dhct_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_ma_don_hang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_ma_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhct_gia_ban = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtGridDonHang = New System.Windows.Forms.DataGridView()
        Me.dh_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_ma_khach_hang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhtt_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_tong_tien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_tien_khuyen_mai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thanh_tien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_ma_chi_nhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kh_ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cn_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtGridDonHangChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGridDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_dh_sua)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_dh_them)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridDonHangChiTiet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridDonHang)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 500)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_dh_sua
        '
        Me.btn_dh_sua.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_dh_sua.Enabled = False
        Me.btn_dh_sua.Location = New System.Drawing.Point(608, 60)
        Me.btn_dh_sua.Name = "btn_dh_sua"
        Me.btn_dh_sua.Size = New System.Drawing.Size(136, 34)
        Me.btn_dh_sua.TabIndex = 2
        Me.btn_dh_sua.Text = "Sửa đơn hàng"
        Me.btn_dh_sua.UseVisualStyleBackColor = True
        '
        'btn_dh_them
        '
        Me.btn_dh_them.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_dh_them.Enabled = False
        Me.btn_dh_them.Location = New System.Drawing.Point(397, 60)
        Me.btn_dh_them.Name = "btn_dh_them"
        Me.btn_dh_them.Size = New System.Drawing.Size(136, 34)
        Me.btn_dh_them.TabIndex = 1
        Me.btn_dh_them.Text = "Tạo đơn hàng"
        Me.btn_dh_them.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_loc_don_hang)
        Me.GroupBox1.Controls.Add(Me.date_to_don_hang)
        Me.GroupBox1.Controls.Add(Me.date_from_don_hang)
        Me.GroupBox1.Controls.Add(Me.cb_dh_cn)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lọc đơn hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(43, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Chi nhánh:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(43, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Từ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(43, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Đến:"
        '
        'btn_loc_don_hang
        '
        Me.btn_loc_don_hang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_loc_don_hang.Location = New System.Drawing.Point(161, 144)
        Me.btn_loc_don_hang.Name = "btn_loc_don_hang"
        Me.btn_loc_don_hang.Size = New System.Drawing.Size(75, 23)
        Me.btn_loc_don_hang.TabIndex = 3
        Me.btn_loc_don_hang.Text = "Lọc"
        Me.btn_loc_don_hang.UseVisualStyleBackColor = True
        '
        'date_to_don_hang
        '
        Me.date_to_don_hang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_to_don_hang.Location = New System.Drawing.Point(110, 106)
        Me.date_to_don_hang.Name = "date_to_don_hang"
        Me.date_to_don_hang.Size = New System.Drawing.Size(202, 23)
        Me.date_to_don_hang.TabIndex = 2
        '
        'date_from_don_hang
        '
        Me.date_from_don_hang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_from_don_hang.Location = New System.Drawing.Point(110, 60)
        Me.date_from_don_hang.Name = "date_from_don_hang"
        Me.date_from_don_hang.Size = New System.Drawing.Size(202, 23)
        Me.date_from_don_hang.TabIndex = 1
        '
        'cb_dh_cn
        '
        Me.cb_dh_cn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_dh_cn.FormattingEnabled = True
        Me.cb_dh_cn.Location = New System.Drawing.Point(110, 22)
        Me.cb_dh_cn.Name = "cb_dh_cn"
        Me.cb_dh_cn.Size = New System.Drawing.Size(202, 23)
        Me.cb_dh_cn.TabIndex = 0
        '
        'dtGridDonHangChiTiet
        '
        Me.dtGridDonHangChiTiet.AllowUserToAddRows = False
        Me.dtGridDonHangChiTiet.AllowUserToDeleteRows = False
        Me.dtGridDonHangChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridDonHangChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridDonHangChiTiet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dhct_ma, Me.dhct_ma_don_hang, Me.dhct_ma_san_pham, Me.sp_ten, Me.dhct_so_luong, Me.dhct_gia_ban})
        Me.dtGridDonHangChiTiet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridDonHangChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtGridDonHangChiTiet.Location = New System.Drawing.Point(0, 154)
        Me.dtGridDonHangChiTiet.MultiSelect = False
        Me.dtGridDonHangChiTiet.Name = "dtGridDonHangChiTiet"
        Me.dtGridDonHangChiTiet.ReadOnly = True
        Me.dtGridDonHangChiTiet.RowTemplate.Height = 25
        Me.dtGridDonHangChiTiet.Size = New System.Drawing.Size(800, 150)
        Me.dtGridDonHangChiTiet.TabIndex = 1
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
        'sp_ten
        '
        Me.sp_ten.DataPropertyName = "sp_ten"
        Me.sp_ten.HeaderText = "Sản phẩm"
        Me.sp_ten.Name = "sp_ten"
        Me.sp_ten.ReadOnly = True
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
        'dtGridDonHang
        '
        Me.dtGridDonHang.AllowUserToAddRows = False
        Me.dtGridDonHang.AllowUserToDeleteRows = False
        Me.dtGridDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridDonHang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dh_ma, Me.dh_ma_khach_hang, Me.dh_ngay, Me.dhtt_ten, Me.dh_tong_tien, Me.dh_tien_khuyen_mai, Me.thanh_tien, Me.dh_ma_chi_nhanh, Me.kh_ho_ten, Me.cn_ten})
        Me.dtGridDonHang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridDonHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridDonHang.Location = New System.Drawing.Point(0, 0)
        Me.dtGridDonHang.MultiSelect = False
        Me.dtGridDonHang.Name = "dtGridDonHang"
        Me.dtGridDonHang.ReadOnly = True
        Me.dtGridDonHang.RowTemplate.Height = 25
        Me.dtGridDonHang.Size = New System.Drawing.Size(800, 304)
        Me.dtGridDonHang.TabIndex = 0
        '
        'dh_ma
        '
        Me.dh_ma.DataPropertyName = "dh_ma"
        Me.dh_ma.HeaderText = "Mã"
        Me.dh_ma.Name = "dh_ma"
        Me.dh_ma.ReadOnly = True
        '
        'dh_ma_khach_hang
        '
        Me.dh_ma_khach_hang.DataPropertyName = "dh_ma_khach_hang"
        Me.dh_ma_khach_hang.HeaderText = "Mã khách hàng"
        Me.dh_ma_khach_hang.Name = "dh_ma_khach_hang"
        Me.dh_ma_khach_hang.ReadOnly = True
        Me.dh_ma_khach_hang.Visible = False
        '
        'dh_ngay
        '
        Me.dh_ngay.DataPropertyName = "dh_ngay"
        Me.dh_ngay.HeaderText = "Ngày tạo"
        Me.dh_ngay.Name = "dh_ngay"
        Me.dh_ngay.ReadOnly = True
        '
        'dhtt_ten
        '
        Me.dhtt_ten.DataPropertyName = "dhtt_ten"
        Me.dhtt_ten.HeaderText = "Trạng thái"
        Me.dhtt_ten.Name = "dhtt_ten"
        Me.dhtt_ten.ReadOnly = True
        '
        'dh_tong_tien
        '
        Me.dh_tong_tien.DataPropertyName = "dh_tong_tien"
        Me.dh_tong_tien.HeaderText = "Tổng tiền"
        Me.dh_tong_tien.Name = "dh_tong_tien"
        Me.dh_tong_tien.ReadOnly = True
        '
        'dh_tien_khuyen_mai
        '
        Me.dh_tien_khuyen_mai.DataPropertyName = "dh_tien_khuyen_mai"
        Me.dh_tien_khuyen_mai.HeaderText = "Tiền khuyến mãi"
        Me.dh_tien_khuyen_mai.Name = "dh_tien_khuyen_mai"
        Me.dh_tien_khuyen_mai.ReadOnly = True
        '
        'thanh_tien
        '
        Me.thanh_tien.DataPropertyName = "thanh_tien"
        Me.thanh_tien.HeaderText = "Thành tiền"
        Me.thanh_tien.Name = "thanh_tien"
        Me.thanh_tien.ReadOnly = True
        '
        'dh_ma_chi_nhanh
        '
        Me.dh_ma_chi_nhanh.DataPropertyName = "dh_ma_chi_nhanh"
        Me.dh_ma_chi_nhanh.HeaderText = "Mã chi nhánh"
        Me.dh_ma_chi_nhanh.Name = "dh_ma_chi_nhanh"
        Me.dh_ma_chi_nhanh.ReadOnly = True
        Me.dh_ma_chi_nhanh.Visible = False
        '
        'kh_ho_ten
        '
        Me.kh_ho_ten.DataPropertyName = "kh_ho_ten"
        Me.kh_ho_ten.HeaderText = "Khách hàng"
        Me.kh_ho_ten.Name = "kh_ho_ten"
        Me.kh_ho_ten.ReadOnly = True
        '
        'cn_ten
        '
        Me.cn_ten.DataPropertyName = "cn_ten"
        Me.cn_ten.HeaderText = "Chi nhánh"
        Me.cn_ten.Name = "cn_ten"
        Me.cn_ten.ReadOnly = True
        '
        'FrmQuanLyDonHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyDonHang"
        Me.Text = "Đơn hàng"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtGridDonHangChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGridDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_dh_them As Button
    Friend WithEvents btn_dh_sua As Button
    Friend WithEvents cb_dh_cn As ComboBox
    Friend WithEvents date_to_don_hang As DateTimePicker
    Friend WithEvents date_from_don_hang As DateTimePicker
    Friend WithEvents btn_loc_don_hang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtGridDonHang As DataGridView
    Friend WithEvents dtGridDonHangChiTiet As DataGridView
    Friend WithEvents dh_ma As DataGridViewTextBoxColumn
    Friend WithEvents dh_ma_khach_hang As DataGridViewTextBoxColumn
    Friend WithEvents dh_ngay As DataGridViewTextBoxColumn
    Friend WithEvents dhtt_ten As DataGridViewTextBoxColumn
    Friend WithEvents dh_tong_tien As DataGridViewTextBoxColumn
    Friend WithEvents dh_tien_khuyen_mai As DataGridViewTextBoxColumn
    Friend WithEvents thanh_tien As DataGridViewTextBoxColumn
    Friend WithEvents dh_ma_chi_nhanh As DataGridViewTextBoxColumn
    Friend WithEvents kh_ho_ten As DataGridViewTextBoxColumn
    Friend WithEvents cn_ten As DataGridViewTextBoxColumn
    Friend WithEvents dhct_ma As DataGridViewTextBoxColumn
    Friend WithEvents dhct_ma_don_hang As DataGridViewTextBoxColumn
    Friend WithEvents dhct_ma_san_pham As DataGridViewTextBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents dhct_so_luong As DataGridViewTextBoxColumn
    Friend WithEvents dhct_gia_ban As DataGridViewTextBoxColumn
End Class
