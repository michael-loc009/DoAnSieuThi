<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLySanPham
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
        Me.dtGridSanPham = New System.Windows.Forms.DataGridView()
        Me.sp_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_mo_ta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_so_luong_toi_thieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dmsp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ma_danh_muc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_xoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_tim_kiem_sp = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_sp_danh_muc_san_pham = New System.Windows.Forms.ComboBox()
        Me.num_sp_so_luong_toi_thieu = New System.Windows.Forms.NumericUpDown()
        Me.num_sp_gia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_sp_mo_ta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txt_sp_ten = New System.Windows.Forms.TextBox()
        Me.err_provider_sp_ten = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_sp_gia = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_sp_so_luong_toi_thieu = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_sp_danh_muc = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.num_sp_so_luong_toi_thieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.err_provider_sp_ten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_sp_gia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_sp_so_luong_toi_thieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_sp_danh_muc, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridSanPham)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_tim_kiem_sp)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1025, 450)
        Me.SplitContainer1.SplitterDistance = 501
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridSanPham
        '
        Me.dtGridSanPham.AllowUserToAddRows = False
        Me.dtGridSanPham.AllowUserToDeleteRows = False
        Me.dtGridSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sp_ma, Me.sp_ten, Me.sp_mo_ta, Me.sp_gia, Me.sp_so_luong_toi_thieu, Me.dmsp_ten, Me.sp_ma_danh_muc, Me.sp_xoa})
        Me.dtGridSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridSanPham.Location = New System.Drawing.Point(0, 23)
        Me.dtGridSanPham.MultiSelect = False
        Me.dtGridSanPham.Name = "dtGridSanPham"
        Me.dtGridSanPham.ReadOnly = True
        Me.dtGridSanPham.RowTemplate.Height = 25
        Me.dtGridSanPham.Size = New System.Drawing.Size(501, 427)
        Me.dtGridSanPham.TabIndex = 1
        '
        'sp_ma
        '
        Me.sp_ma.DataPropertyName = "sp_ma"
        Me.sp_ma.HeaderText = "Mã"
        Me.sp_ma.Name = "sp_ma"
        Me.sp_ma.ReadOnly = True
        '
        'sp_ten
        '
        Me.sp_ten.DataPropertyName = "sp_ten"
        Me.sp_ten.HeaderText = "Tên"
        Me.sp_ten.Name = "sp_ten"
        Me.sp_ten.ReadOnly = True
        '
        'sp_mo_ta
        '
        Me.sp_mo_ta.DataPropertyName = "sp_mo_ta"
        Me.sp_mo_ta.HeaderText = "Mô tả"
        Me.sp_mo_ta.Name = "sp_mo_ta"
        Me.sp_mo_ta.ReadOnly = True
        '
        'sp_gia
        '
        Me.sp_gia.DataPropertyName = "sp_gia"
        Me.sp_gia.HeaderText = "Giá"
        Me.sp_gia.Name = "sp_gia"
        Me.sp_gia.ReadOnly = True
        '
        'sp_so_luong_toi_thieu
        '
        Me.sp_so_luong_toi_thieu.DataPropertyName = "sp_so_luong_toi_thieu"
        Me.sp_so_luong_toi_thieu.HeaderText = "SL tối thiểu"
        Me.sp_so_luong_toi_thieu.Name = "sp_so_luong_toi_thieu"
        Me.sp_so_luong_toi_thieu.ReadOnly = True
        '
        'dmsp_ten
        '
        Me.dmsp_ten.DataPropertyName = "dmsp_ten"
        Me.dmsp_ten.HeaderText = "Danh mục sản phẩm"
        Me.dmsp_ten.Name = "dmsp_ten"
        Me.dmsp_ten.ReadOnly = True
        '
        'sp_ma_danh_muc
        '
        Me.sp_ma_danh_muc.DataPropertyName = "sp_ma_danh_muc"
        Me.sp_ma_danh_muc.HeaderText = "Mã danh mục sản phẩm"
        Me.sp_ma_danh_muc.Name = "sp_ma_danh_muc"
        Me.sp_ma_danh_muc.ReadOnly = True
        Me.sp_ma_danh_muc.Visible = False
        '
        'sp_xoa
        '
        Me.sp_xoa.DataPropertyName = "sp_xoa"
        Me.sp_xoa.HeaderText = "Xóa"
        Me.sp_xoa.Name = "sp_xoa"
        Me.sp_xoa.ReadOnly = True
        Me.sp_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sp_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sp_xoa.Visible = False
        '
        'txt_tim_kiem_sp
        '
        Me.txt_tim_kiem_sp.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_tim_kiem_sp.Location = New System.Drawing.Point(0, 0)
        Me.txt_tim_kiem_sp.Name = "txt_tim_kiem_sp"
        Me.txt_tim_kiem_sp.Size = New System.Drawing.Size(501, 23)
        Me.txt_tim_kiem_sp.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cb_sp_danh_muc_san_pham)
        Me.Panel2.Controls.Add(Me.num_sp_so_luong_toi_thieu)
        Me.Panel2.Controls.Add(Me.num_sp_gia)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_sp_mo_ta)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.txt_sp_ten)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 312)
        Me.Panel2.TabIndex = 8
        '
        'cb_sp_danh_muc_san_pham
        '
        Me.cb_sp_danh_muc_san_pham.FormattingEnabled = True
        Me.cb_sp_danh_muc_san_pham.Location = New System.Drawing.Point(144, 213)
        Me.cb_sp_danh_muc_san_pham.Name = "cb_sp_danh_muc_san_pham"
        Me.cb_sp_danh_muc_san_pham.Size = New System.Drawing.Size(248, 23)
        Me.cb_sp_danh_muc_san_pham.TabIndex = 13
        '
        'num_sp_so_luong_toi_thieu
        '
        Me.num_sp_so_luong_toi_thieu.Location = New System.Drawing.Point(144, 176)
        Me.num_sp_so_luong_toi_thieu.Name = "num_sp_so_luong_toi_thieu"
        Me.num_sp_so_luong_toi_thieu.Size = New System.Drawing.Size(248, 23)
        Me.num_sp_so_luong_toi_thieu.TabIndex = 12
        '
        'num_sp_gia
        '
        Me.num_sp_gia.Location = New System.Drawing.Point(144, 139)
        Me.num_sp_gia.Name = "num_sp_gia"
        Me.num_sp_gia.Size = New System.Drawing.Size(248, 23)
        Me.num_sp_gia.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Danh mục"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SL tối thiểu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Giá"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mô tả"
        '
        'txt_sp_mo_ta
        '
        Me.txt_sp_mo_ta.Location = New System.Drawing.Point(144, 45)
        Me.txt_sp_mo_ta.Multiline = True
        Me.txt_sp_mo_ta.Name = "txt_sp_mo_ta"
        Me.txt_sp_mo_ta.Size = New System.Drawing.Size(248, 80)
        Me.txt_sp_mo_ta.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Location = New System.Drawing.Point(114, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 52)
        Me.Panel1.TabIndex = 5
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(0, 15)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(242, 15)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(124, 15)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'txt_sp_ten
        '
        Me.txt_sp_ten.Location = New System.Drawing.Point(144, 8)
        Me.txt_sp_ten.Name = "txt_sp_ten"
        Me.txt_sp_ten.Size = New System.Drawing.Size(248, 23)
        Me.txt_sp_ten.TabIndex = 1
        '
        'err_provider_sp_ten
        '
        Me.err_provider_sp_ten.ContainerControl = Me
        '
        'err_provider_sp_gia
        '
        Me.err_provider_sp_gia.ContainerControl = Me
        '
        'err_provider_sp_so_luong_toi_thieu
        '
        Me.err_provider_sp_so_luong_toi_thieu.ContainerControl = Me
        '
        'err_provider_sp_danh_muc
        '
        Me.err_provider_sp_danh_muc.ContainerControl = Me
        '
        'FrmQuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1025, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLySanPham"
        Me.Text = "Quản lý sản phẩm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.num_sp_so_luong_toi_thieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.err_provider_sp_ten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_sp_gia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_sp_so_luong_toi_thieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_sp_danh_muc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_tim_kiem_sp As TextBox
    Friend WithEvents dtGridSanPham As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_sp_mo_ta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txt_sp_ten As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents num_sp_gia As TextBox
    Friend WithEvents num_sp_so_luong_toi_thieu As NumericUpDown
    Friend WithEvents cb_sp_danh_muc_san_pham As ComboBox
    Friend WithEvents sp_ma As DataGridViewTextBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents sp_mo_ta As DataGridViewTextBoxColumn
    Friend WithEvents sp_gia As DataGridViewTextBoxColumn
    Friend WithEvents sp_so_luong_toi_thieu As DataGridViewTextBoxColumn
    Friend WithEvents dmsp_ten As DataGridViewTextBoxColumn
    Friend WithEvents sp_ma_danh_muc As DataGridViewTextBoxColumn
    Friend WithEvents sp_xoa As DataGridViewTextBoxColumn
    Friend WithEvents err_provider_sp_ten As ErrorProvider
    Friend WithEvents err_provider_sp_gia As ErrorProvider
    Friend WithEvents err_provider_sp_so_luong_toi_thieu As ErrorProvider
    Friend WithEvents err_provider_sp_danh_muc As ErrorProvider
End Class
