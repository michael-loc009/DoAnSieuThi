<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyMenu
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
        Me.dtGrid_menu_san_pham = New System.Windows.Forms.DataGridView()
        Me.sp_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp_xoa = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sp_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_menu_tim_sp = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.num_menu_sl_sp = New System.Windows.Forms.NumericUpDown()
        Me.btn_menu_xoa_sp = New System.Windows.Forms.Button()
        Me.btn_menu_them_sp = New System.Windows.Forms.Button()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_menu_cn = New System.Windows.Forms.ComboBox()
        Me.dtGrid_menu_cn_san_pham = New System.Windows.Forms.DataGridView()
        Me.m_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_ma_chi_nhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_ma_san_pham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_gia_ban = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m_so_luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGrid_menu_san_pham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.num_menu_sl_sp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtGrid_menu_cn_san_pham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGrid_menu_san_pham)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_menu_tim_sp)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGrid_menu_san_pham
        '
        Me.dtGrid_menu_san_pham.AllowUserToAddRows = False
        Me.dtGrid_menu_san_pham.AllowUserToDeleteRows = False
        Me.dtGrid_menu_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_menu_san_pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_menu_san_pham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sp_ma, Me.sp_gia, Me.sp_xoa, Me.sp_ten})
        Me.dtGrid_menu_san_pham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_menu_san_pham.Location = New System.Drawing.Point(0, 23)
        Me.dtGrid_menu_san_pham.MultiSelect = False
        Me.dtGrid_menu_san_pham.Name = "dtGrid_menu_san_pham"
        Me.dtGrid_menu_san_pham.ReadOnly = True
        Me.dtGrid_menu_san_pham.RowTemplate.Height = 25
        Me.dtGrid_menu_san_pham.Size = New System.Drawing.Size(266, 427)
        Me.dtGrid_menu_san_pham.TabIndex = 1
        '
        'sp_ma
        '
        Me.sp_ma.DataPropertyName = "sp_ma"
        Me.sp_ma.HeaderText = "Mã"
        Me.sp_ma.Name = "sp_ma"
        Me.sp_ma.ReadOnly = True
        '
        'sp_gia
        '
        Me.sp_gia.DataPropertyName = "sp_gia"
        Me.sp_gia.HeaderText = "Giá"
        Me.sp_gia.Name = "sp_gia"
        Me.sp_gia.ReadOnly = True
        Me.sp_gia.Visible = False
        '
        'sp_xoa
        '
        Me.sp_xoa.DataPropertyName = "sp_xoa"
        Me.sp_xoa.HeaderText = "Xóa"
        Me.sp_xoa.Name = "sp_xoa"
        Me.sp_xoa.ReadOnly = True
        Me.sp_xoa.Visible = False
        '
        'sp_ten
        '
        Me.sp_ten.DataPropertyName = "sp_ten"
        Me.sp_ten.HeaderText = "Tên"
        Me.sp_ten.Name = "sp_ten"
        Me.sp_ten.ReadOnly = True
        '
        'txt_menu_tim_sp
        '
        Me.txt_menu_tim_sp.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_menu_tim_sp.Location = New System.Drawing.Point(0, 0)
        Me.txt_menu_tim_sp.Name = "txt_menu_tim_sp"
        Me.txt_menu_tim_sp.Size = New System.Drawing.Size(266, 23)
        Me.txt_menu_tim_sp.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.num_menu_sl_sp)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_menu_xoa_sp)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_menu_them_sp)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(530, 450)
        Me.SplitContainer2.SplitterDistance = 76
        Me.SplitContainer2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(8, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Số lượng:"
        '
        'num_menu_sl_sp
        '
        Me.num_menu_sl_sp.Location = New System.Drawing.Point(6, 88)
        Me.num_menu_sl_sp.Name = "num_menu_sl_sp"
        Me.num_menu_sl_sp.Size = New System.Drawing.Size(67, 23)
        Me.num_menu_sl_sp.TabIndex = 0
        '
        'btn_menu_xoa_sp
        '
        Me.btn_menu_xoa_sp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_menu_xoa_sp.Location = New System.Drawing.Point(19, 183)
        Me.btn_menu_xoa_sp.Name = "btn_menu_xoa_sp"
        Me.btn_menu_xoa_sp.Size = New System.Drawing.Size(43, 30)
        Me.btn_menu_xoa_sp.TabIndex = 1
        Me.btn_menu_xoa_sp.Text = "-"
        Me.btn_menu_xoa_sp.UseVisualStyleBackColor = True
        '
        'btn_menu_them_sp
        '
        Me.btn_menu_them_sp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_menu_them_sp.Location = New System.Drawing.Point(19, 126)
        Me.btn_menu_them_sp.Name = "btn_menu_them_sp"
        Me.btn_menu_them_sp.Size = New System.Drawing.Size(43, 30)
        Me.btn_menu_them_sp.TabIndex = 0
        Me.btn_menu_them_sp.Text = "+"
        Me.btn_menu_them_sp.UseVisualStyleBackColor = True
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.dtGrid_menu_cn_san_pham)
        Me.SplitContainer3.Size = New System.Drawing.Size(450, 450)
        Me.SplitContainer3.SplitterDistance = 96
        Me.SplitContainer3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_menu_cn)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Chi nhánh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(60, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Chi nhánh:"
        '
        'cb_menu_cn
        '
        Me.cb_menu_cn.FormattingEnabled = True
        Me.cb_menu_cn.Location = New System.Drawing.Point(141, 41)
        Me.cb_menu_cn.Name = "cb_menu_cn"
        Me.cb_menu_cn.Size = New System.Drawing.Size(172, 23)
        Me.cb_menu_cn.TabIndex = 0
        '
        'dtGrid_menu_cn_san_pham
        '
        Me.dtGrid_menu_cn_san_pham.AllowUserToAddRows = False
        Me.dtGrid_menu_cn_san_pham.AllowUserToDeleteRows = False
        Me.dtGrid_menu_cn_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_menu_cn_san_pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_menu_cn_san_pham.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.m_ma, Me.DataGridViewTextBoxColumn1, Me.m_ma_chi_nhanh, Me.m_ma_san_pham, Me.m_gia_ban, Me.m_so_luong})
        Me.dtGrid_menu_cn_san_pham.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGrid_menu_cn_san_pham.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_menu_cn_san_pham.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_menu_cn_san_pham.MultiSelect = False
        Me.dtGrid_menu_cn_san_pham.Name = "dtGrid_menu_cn_san_pham"
        Me.dtGrid_menu_cn_san_pham.ReadOnly = True
        Me.dtGrid_menu_cn_san_pham.RowTemplate.Height = 25
        Me.dtGrid_menu_cn_san_pham.Size = New System.Drawing.Size(450, 350)
        Me.dtGrid_menu_cn_san_pham.TabIndex = 0
        '
        'm_ma
        '
        Me.m_ma.DataPropertyName = "m_ma"
        Me.m_ma.HeaderText = "Mã"
        Me.m_ma.Name = "m_ma"
        Me.m_ma.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sp_ten"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sản phẩm"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'm_ma_chi_nhanh
        '
        Me.m_ma_chi_nhanh.DataPropertyName = "m_ma_chi_nhanh"
        Me.m_ma_chi_nhanh.HeaderText = "Mã chi nhánh"
        Me.m_ma_chi_nhanh.Name = "m_ma_chi_nhanh"
        Me.m_ma_chi_nhanh.ReadOnly = True
        Me.m_ma_chi_nhanh.Visible = False
        '
        'm_ma_san_pham
        '
        Me.m_ma_san_pham.DataPropertyName = "m_ma_san_pham"
        Me.m_ma_san_pham.HeaderText = "Mã sản phẩm"
        Me.m_ma_san_pham.Name = "m_ma_san_pham"
        Me.m_ma_san_pham.ReadOnly = True
        Me.m_ma_san_pham.Visible = False
        '
        'm_gia_ban
        '
        Me.m_gia_ban.DataPropertyName = "m_gia_ban"
        Me.m_gia_ban.HeaderText = "Giá bán"
        Me.m_gia_ban.Name = "m_gia_ban"
        Me.m_gia_ban.ReadOnly = True
        '
        'm_so_luong
        '
        Me.m_so_luong.DataPropertyName = "m_so_luong"
        Me.m_so_luong.HeaderText = "Số lượng"
        Me.m_so_luong.Name = "m_so_luong"
        Me.m_so_luong.ReadOnly = True
        '
        'FrmQuanLyMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyMenu"
        Me.Text = "Quản lý menu"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGrid_menu_san_pham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.num_menu_sl_sp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtGrid_menu_cn_san_pham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_menu_tim_sp As TextBox
    Friend WithEvents dtGrid_menu_san_pham As DataGridView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents btn_menu_them_sp As Button
    Friend WithEvents btn_menu_xoa_sp As Button
    Friend WithEvents num_menu_sl_sp As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtGrid_menu_cn_san_pham As DataGridView
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_menu_cn As ComboBox
    Friend WithEvents sp_ma As DataGridViewTextBoxColumn
    Friend WithEvents sp_gia As DataGridViewTextBoxColumn
    Friend WithEvents sp_xoa As DataGridViewCheckBoxColumn
    Friend WithEvents sp_ten As DataGridViewTextBoxColumn
    Friend WithEvents m_ma As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents m_ma_chi_nhanh As DataGridViewTextBoxColumn
    Friend WithEvents m_ma_san_pham As DataGridViewTextBoxColumn
    Friend WithEvents m_gia_ban As DataGridViewTextBoxColumn
    Friend WithEvents m_so_luong As DataGridViewTextBoxColumn
End Class
