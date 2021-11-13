<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyNguoiDung
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
        Me.dtGridNguoiDung = New System.Windows.Forms.DataGridView()
        Me.nd_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_nam_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_dia_chi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltk_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_nd_loai_tk = New System.Windows.Forms.ComboBox()
        Me.cb_nd_phan_quyen_cn = New System.Windows.Forms.Label()
        Me.cb_nd_loai_tai_khoan = New System.Windows.Forms.Label()
        Me.cb_list_nd_phan_quyen_cn = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nd_dia_chi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nd_ho_ten = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nd_confirm_pass = New System.Windows.Forms.TextBox()
        Me.date_nd_nam_sinh = New System.Windows.Forms.DateTimePicker()
        Me.txt_nd_pass = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txt_nd_username = New System.Windows.Forms.TextBox()
        Me.err_provider_username = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_pass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_confirm_pass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_hoten = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_diachi = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_namsinh = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_loai_tk = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_quyen_cn = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.err_provider_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_confirm_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_hoten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_diachi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_namsinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_loai_tk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_quyen_cn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridNguoiDung)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTimKiem)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(981, 621)
        Me.SplitContainer1.SplitterDistance = 341
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridNguoiDung
        '
        Me.dtGridNguoiDung.AllowUserToAddRows = False
        Me.dtGridNguoiDung.AllowUserToDeleteRows = False
        Me.dtGridNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridNguoiDung.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nd_ma, Me.nd_ho_ten, Me.nd_nam_sinh, Me.nd_dia_chi, Me.ltk_ten})
        Me.dtGridNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridNguoiDung.Location = New System.Drawing.Point(0, 23)
        Me.dtGridNguoiDung.MultiSelect = False
        Me.dtGridNguoiDung.Name = "dtGridNguoiDung"
        Me.dtGridNguoiDung.ReadOnly = True
        Me.dtGridNguoiDung.RowTemplate.Height = 25
        Me.dtGridNguoiDung.Size = New System.Drawing.Size(341, 598)
        Me.dtGridNguoiDung.TabIndex = 1
        '
        'nd_ma
        '
        Me.nd_ma.DataPropertyName = "nd_ma"
        Me.nd_ma.HeaderText = "Mã"
        Me.nd_ma.Name = "nd_ma"
        Me.nd_ma.ReadOnly = True
        '
        'nd_ho_ten
        '
        Me.nd_ho_ten.DataPropertyName = "nd_ho_ten"
        Me.nd_ho_ten.HeaderText = "Họ Tên"
        Me.nd_ho_ten.Name = "nd_ho_ten"
        Me.nd_ho_ten.ReadOnly = True
        '
        'nd_nam_sinh
        '
        Me.nd_nam_sinh.DataPropertyName = "nd_nam_sinh"
        Me.nd_nam_sinh.HeaderText = "Ngày sinh"
        Me.nd_nam_sinh.Name = "nd_nam_sinh"
        Me.nd_nam_sinh.ReadOnly = True
        '
        'nd_dia_chi
        '
        Me.nd_dia_chi.DataPropertyName = "nd_dia_chi"
        Me.nd_dia_chi.HeaderText = "Địa chỉ"
        Me.nd_dia_chi.Name = "nd_dia_chi"
        Me.nd_dia_chi.ReadOnly = True
        '
        'ltk_ten
        '
        Me.ltk_ten.DataPropertyName = "ltk_ten"
        Me.ltk_ten.HeaderText = "Loại tài khoản"
        Me.ltk_ten.Name = "ltk_ten"
        Me.ltk_ten.ReadOnly = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTimKiem.Location = New System.Drawing.Point(0, 0)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(341, 23)
        Me.txtTimKiem.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cb_nd_loai_tk)
        Me.Panel2.Controls.Add(Me.cb_nd_phan_quyen_cn)
        Me.Panel2.Controls.Add(Me.cb_nd_loai_tai_khoan)
        Me.Panel2.Controls.Add(Me.cb_list_nd_phan_quyen_cn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_nd_dia_chi)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_nd_ho_ten)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_nd_confirm_pass)
        Me.Panel2.Controls.Add(Me.date_nd_nam_sinh)
        Me.Panel2.Controls.Add(Me.txt_nd_pass)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.txt_nd_username)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 583)
        Me.Panel2.TabIndex = 7
        '
        'cb_nd_loai_tk
        '
        Me.cb_nd_loai_tk.FormattingEnabled = True
        Me.cb_nd_loai_tk.Location = New System.Drawing.Point(189, 311)
        Me.cb_nd_loai_tk.Name = "cb_nd_loai_tk"
        Me.cb_nd_loai_tk.Size = New System.Drawing.Size(248, 23)
        Me.cb_nd_loai_tk.TabIndex = 36
        '
        'cb_nd_phan_quyen_cn
        '
        Me.cb_nd_phan_quyen_cn.AutoSize = True
        Me.cb_nd_phan_quyen_cn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_nd_phan_quyen_cn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cb_nd_phan_quyen_cn.Location = New System.Drawing.Point(36, 410)
        Me.cb_nd_phan_quyen_cn.Name = "cb_nd_phan_quyen_cn"
        Me.cb_nd_phan_quyen_cn.Size = New System.Drawing.Size(131, 15)
        Me.cb_nd_phan_quyen_cn.TabIndex = 35
        Me.cb_nd_phan_quyen_cn.Text = "Phân quyền Chi nhánh:"
        '
        'cb_nd_loai_tai_khoan
        '
        Me.cb_nd_loai_tai_khoan.AutoSize = True
        Me.cb_nd_loai_tai_khoan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cb_nd_loai_tai_khoan.Location = New System.Drawing.Point(36, 314)
        Me.cb_nd_loai_tai_khoan.Name = "cb_nd_loai_tai_khoan"
        Me.cb_nd_loai_tai_khoan.Size = New System.Drawing.Size(86, 15)
        Me.cb_nd_loai_tai_khoan.TabIndex = 32
        Me.cb_nd_loai_tai_khoan.Text = "Loại tài khoản:"
        '
        'cb_list_nd_phan_quyen_cn
        '
        Me.cb_list_nd_phan_quyen_cn.FormattingEnabled = True
        Me.cb_list_nd_phan_quyen_cn.Location = New System.Drawing.Point(189, 362)
        Me.cb_list_nd_phan_quyen_cn.Name = "cb_list_nd_phan_quyen_cn"
        Me.cb_list_nd_phan_quyen_cn.Size = New System.Drawing.Size(248, 94)
        Me.cb_list_nd_phan_quyen_cn.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(36, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Địa chỉ:"
        '
        'txt_nd_dia_chi
        '
        Me.txt_nd_dia_chi.Location = New System.Drawing.Point(189, 232)
        Me.txt_nd_dia_chi.Multiline = True
        Me.txt_nd_dia_chi.Name = "txt_nd_dia_chi"
        Me.txt_nd_dia_chi.Size = New System.Drawing.Size(248, 49)
        Me.txt_nd_dia_chi.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Năm sinh:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Họ tên:"
        '
        'txt_nd_ho_ten
        '
        Me.txt_nd_ho_ten.Location = New System.Drawing.Point(189, 136)
        Me.txt_nd_ho_ten.Name = "txt_nd_ho_ten"
        Me.txt_nd_ho_ten.Size = New System.Drawing.Size(248, 23)
        Me.txt_nd_ho_ten.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(36, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Xác nhận mật khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(36, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Mật khẩu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(36, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Tên đăng nhập:"
        '
        'txt_nd_confirm_pass
        '
        Me.txt_nd_confirm_pass.Location = New System.Drawing.Point(189, 90)
        Me.txt_nd_confirm_pass.Name = "txt_nd_confirm_pass"
        Me.txt_nd_confirm_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nd_confirm_pass.Size = New System.Drawing.Size(248, 23)
        Me.txt_nd_confirm_pass.TabIndex = 10
        '
        'date_nd_nam_sinh
        '
        Me.date_nd_nam_sinh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_nd_nam_sinh.Location = New System.Drawing.Point(189, 183)
        Me.date_nd_nam_sinh.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.date_nd_nam_sinh.Name = "date_nd_nam_sinh"
        Me.date_nd_nam_sinh.Size = New System.Drawing.Size(248, 23)
        Me.date_nd_nam_sinh.TabIndex = 9
        Me.date_nd_nam_sinh.Value = New Date(2021, 8, 10, 0, 0, 0, 0)
        '
        'txt_nd_pass
        '
        Me.txt_nd_pass.Location = New System.Drawing.Point(189, 46)
        Me.txt_nd_pass.Name = "txt_nd_pass"
        Me.txt_nd_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nd_pass.Size = New System.Drawing.Size(248, 23)
        Me.txt_nd_pass.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Location = New System.Drawing.Point(164, 499)
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
        'txt_nd_username
        '
        Me.txt_nd_username.Location = New System.Drawing.Point(189, 8)
        Me.txt_nd_username.Name = "txt_nd_username"
        Me.txt_nd_username.Size = New System.Drawing.Size(248, 23)
        Me.txt_nd_username.TabIndex = 1
        '
        'err_provider_username
        '
        Me.err_provider_username.ContainerControl = Me
        '
        'err_provider_pass
        '
        Me.err_provider_pass.ContainerControl = Me
        '
        'err_provider_confirm_pass
        '
        Me.err_provider_confirm_pass.ContainerControl = Me
        '
        'err_provider_hoten
        '
        Me.err_provider_hoten.ContainerControl = Me
        '
        'err_provider_diachi
        '
        Me.err_provider_diachi.ContainerControl = Me
        '
        'err_provider_namsinh
        '
        Me.err_provider_namsinh.ContainerControl = Me
        '
        'err_provider_loai_tk
        '
        Me.err_provider_loai_tk.ContainerControl = Me
        '
        'err_provider_quyen_cn
        '
        Me.err_provider_quyen_cn.ContainerControl = Me
        '
        'FrmQuanLyNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(981, 621)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyNguoiDung"
        Me.Text = "Quản lý người dùng"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.err_provider_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_confirm_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_hoten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_diachi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_namsinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_loai_tk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_quyen_cn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dtGridNguoiDung As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txt_nd_username As TextBox
    Friend WithEvents txt_nd_pass As TextBox
    Friend WithEvents txt_nd_confirm_pass As TextBox
    Friend WithEvents date_nd_nam_sinh As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nd_ho_ten As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nd_dia_chi As TextBox
    Friend WithEvents cb_list_nd_phan_quyen_cn As CheckedListBox
    Friend WithEvents cb_nd_loai_tai_khoan As Label
    Friend WithEvents cb_nd_phan_quyen_cn As Label
    Friend WithEvents nd_ma As DataGridViewTextBoxColumn
    Friend WithEvents nd_ho_ten As DataGridViewTextBoxColumn
    Friend WithEvents nd_nam_sinh As DataGridViewTextBoxColumn
    Friend WithEvents nd_dia_chi As DataGridViewTextBoxColumn
    Friend WithEvents ltk_ten As DataGridViewTextBoxColumn
    Friend WithEvents cb_nd_loai_tk As ComboBox
    Friend WithEvents err_provider_username As ErrorProvider
    Friend WithEvents err_provider_pass As ErrorProvider
    Friend WithEvents err_provider_confirm_pass As ErrorProvider
    Friend WithEvents err_provider_hoten As ErrorProvider
    Friend WithEvents err_provider_diachi As ErrorProvider
    Friend WithEvents err_provider_namsinh As ErrorProvider
    Friend WithEvents err_provider_loai_tk As ErrorProvider
    Friend WithEvents err_provider_quyen_cn As ErrorProvider
End Class
