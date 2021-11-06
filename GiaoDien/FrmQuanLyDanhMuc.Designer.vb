<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyDanhMuc
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
        Me.dtGridDanhMucSanPham = New System.Windows.Forms.DataGridView()
        Me.dmsp_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dmsp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dmsp_mo_ta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dmsp_xoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiemDanhMucSanPham = New System.Windows.Forms.TextBox()
        Me.dtGridSanPham = New System.Windows.Forms.DataGridView()
        Me.sp_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_mo_ta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_xoa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dmsp_mo_ta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txt_dmsp_ten = New System.Windows.Forms.TextBox()
        Me.err_provider_dmsp_ten = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridDanhMucSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGridSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.err_provider_dmsp_ten, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridDanhMucSanPham)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTimKiemDanhMucSanPham)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridSanPham)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 323
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridDanhMucSanPham
        '
        Me.dtGridDanhMucSanPham.AllowUserToAddRows = False
        Me.dtGridDanhMucSanPham.AllowUserToDeleteRows = False
        Me.dtGridDanhMucSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridDanhMucSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dmsp_ma, Me.dmsp_ten, Me.dmsp_mo_ta, Me.dmsp_xoa})
        Me.dtGridDanhMucSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridDanhMucSanPham.Location = New System.Drawing.Point(0, 23)
        Me.dtGridDanhMucSanPham.MultiSelect = False
        Me.dtGridDanhMucSanPham.Name = "dtGridDanhMucSanPham"
        Me.dtGridDanhMucSanPham.ReadOnly = True
        Me.dtGridDanhMucSanPham.RowTemplate.Height = 25
        Me.dtGridDanhMucSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGridDanhMucSanPham.Size = New System.Drawing.Size(323, 427)
        Me.dtGridDanhMucSanPham.TabIndex = 2
        '
        'dmsp_ma
        '
        Me.dmsp_ma.DataPropertyName = "dmsp_ma"
        Me.dmsp_ma.HeaderText = "Mã"
        Me.dmsp_ma.Name = "dmsp_ma"
        Me.dmsp_ma.ReadOnly = True
        '
        'dmsp_ten
        '
        Me.dmsp_ten.DataPropertyName = "dmsp_ten"
        Me.dmsp_ten.HeaderText = "Tên"
        Me.dmsp_ten.Name = "dmsp_ten"
        Me.dmsp_ten.ReadOnly = True
        '
        'dmsp_mo_ta
        '
        Me.dmsp_mo_ta.DataPropertyName = "dmsp_mo_ta"
        Me.dmsp_mo_ta.HeaderText = "Mô tả"
        Me.dmsp_mo_ta.Name = "dmsp_mo_ta"
        Me.dmsp_mo_ta.ReadOnly = True
        '
        'dmsp_xoa
        '
        Me.dmsp_xoa.DataPropertyName = "dmsp_xoa"
        Me.dmsp_xoa.HeaderText = "Xóa"
        Me.dmsp_xoa.Name = "dmsp_xoa"
        Me.dmsp_xoa.ReadOnly = True
        Me.dmsp_xoa.Visible = False
        '
        'txtTimKiemDanhMucSanPham
        '
        Me.txtTimKiemDanhMucSanPham.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTimKiemDanhMucSanPham.Location = New System.Drawing.Point(0, 0)
        Me.txtTimKiemDanhMucSanPham.Name = "txtTimKiemDanhMucSanPham"
        Me.txtTimKiemDanhMucSanPham.Size = New System.Drawing.Size(323, 23)
        Me.txtTimKiemDanhMucSanPham.TabIndex = 1
        '
        'dtGridSanPham
        '
        Me.dtGridSanPham.AllowUserToAddRows = False
        Me.dtGridSanPham.AllowUserToDeleteRows = False
        Me.dtGridSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridSanPham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sp_ma, Me.sp_ten, Me.sp_mo_ta, Me.sp_gia, Me.sp_so_luong, Me.sp_xoa, Me.DataGridViewTextBoxColumn1})
        Me.dtGridSanPham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridSanPham.Location = New System.Drawing.Point(0, 225)
        Me.dtGridSanPham.MultiSelect = False
        Me.dtGridSanPham.Name = "dtGridSanPham"
        Me.dtGridSanPham.ReadOnly = True
        Me.dtGridSanPham.RowTemplate.Height = 25
        Me.dtGridSanPham.Size = New System.Drawing.Size(473, 225)
        Me.dtGridSanPham.TabIndex = 8
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
        'sp_so_luong
        '
        Me.sp_so_luong.DataPropertyName = "sp_so_luong_toi_thieu"
        Me.sp_so_luong.HeaderText = "Số lượng"
        Me.sp_so_luong.Name = "sp_so_luong"
        Me.sp_so_luong.ReadOnly = True
        '
        'sp_xoa
        '
        Me.sp_xoa.DataPropertyName = "sp_xoa"
        Me.sp_xoa.HeaderText = "Xóa"
        Me.sp_xoa.Name = "sp_xoa"
        Me.sp_xoa.ReadOnly = True
        Me.sp_xoa.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sp_ma_danh_muc"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Danh mục sản phẩm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_dmsp_mo_ta)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.txt_dmsp_ten)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 225)
        Me.Panel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mô tả"
        '
        'txt_dmsp_mo_ta
        '
        Me.txt_dmsp_mo_ta.Location = New System.Drawing.Point(145, 47)
        Me.txt_dmsp_mo_ta.Multiline = True
        Me.txt_dmsp_mo_ta.Name = "txt_dmsp_mo_ta"
        Me.txt_dmsp_mo_ta.Size = New System.Drawing.Size(248, 79)
        Me.txt_dmsp_mo_ta.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 13)
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
        Me.Panel1.Location = New System.Drawing.Point(101, 152)
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
        'txt_dmsp_ten
        '
        Me.txt_dmsp_ten.Location = New System.Drawing.Point(145, 10)
        Me.txt_dmsp_ten.Name = "txt_dmsp_ten"
        Me.txt_dmsp_ten.Size = New System.Drawing.Size(248, 23)
        Me.txt_dmsp_ten.TabIndex = 1
        '
        'err_provider_dmsp_ten
        '
        Me.err_provider_dmsp_ten.ContainerControl = Me
        '
        'FrmQuanLyDanhMuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyDanhMuc"
        Me.Text = "Quản lý danh mục"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridDanhMucSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGridSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.err_provider_dmsp_ten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtTimKiemDanhMucSanPham As TextBox
    Friend WithEvents dtGridDanhMuc As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txt_dmsp_ten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_dmsp_mo_ta As TextBox
    Friend WithEvents dmsp_ma As DataGridViewTextBoxColumn
    Friend WithEvents dmsp_ten As DataGridViewTextBoxColumn
    Friend WithEvents dmsp_mo_ta As DataGridViewTextBoxColumn
    Friend WithEvents dmsp_xoa As DataGridViewTextBoxColumn
    Friend WithEvents dtGridDanhMucSanPham As DataGridView
    Friend WithEvents dtGridSanPham As DataGridView
    Friend WithEvents sp_ma As DataGridViewTextBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents sp_mo_ta As DataGridViewTextBoxColumn
    Friend WithEvents sp_gia As DataGridViewTextBoxColumn
    Friend WithEvents sp_so_luong As DataGridViewTextBoxColumn
    Friend WithEvents sp_xoa As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents err_provider_dmsp_ten As ErrorProvider
End Class
