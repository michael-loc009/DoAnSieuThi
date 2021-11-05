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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtGridNguoiDung = New System.Windows.Forms.DataGridView()
        Me.nd_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_hoten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_ngaysinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_matkhau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nd_chinhanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.lbCode = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.dateNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.cbChiNhanh = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1012, 360)
        Me.SplitContainer1.SplitterDistance = 508
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridNguoiDung
        '
        Me.dtGridNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridNguoiDung.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nd_ma, Me.nd_Code, Me.nd_hoten, Me.nd_ngaysinh, Me.nd_matkhau, Me.nd_chinhanh})
        Me.dtGridNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridNguoiDung.Location = New System.Drawing.Point(0, 23)
        Me.dtGridNguoiDung.Name = "dtGridNguoiDung"
        Me.dtGridNguoiDung.RowTemplate.Height = 25
        Me.dtGridNguoiDung.Size = New System.Drawing.Size(508, 337)
        Me.dtGridNguoiDung.TabIndex = 1
        '
        'nd_ma
        '
        Me.nd_ma.HeaderText = "Mã"
        Me.nd_ma.Name = "nd_ma"
        '
        'nd_Code
        '
        Me.nd_Code.HeaderText = "Code"
        Me.nd_Code.Name = "nd_Code"
        '
        'nd_hoten
        '
        Me.nd_hoten.HeaderText = "Họ Tên"
        Me.nd_hoten.Name = "nd_hoten"
        '
        'nd_ngaysinh
        '
        Me.nd_ngaysinh.HeaderText = "Ngày sinh"
        Me.nd_ngaysinh.Name = "nd_ngaysinh"
        '
        'nd_matkhau
        '
        Me.nd_matkhau.HeaderText = "Mật khẩu"
        Me.nd_matkhau.Name = "nd_matkhau"
        '
        'nd_chinhanh
        '
        Me.nd_chinhanh.HeaderText = "Chi nhánh"
        Me.nd_chinhanh.Name = "nd_chinhanh"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTimKiem.Location = New System.Drawing.Point(0, 0)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(508, 23)
        Me.txtTimKiem.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbChiNhanh)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtMatKhau)
        Me.Panel2.Controls.Add(Me.dateNgaySinh)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Controls.Add(Me.lbNgaySinh)
        Me.Panel2.Controls.Add(Me.lbCode)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.txtHoTen)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 292)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Họ tên"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnThem)
        Me.Panel1.Controls.Add(Me.btnXoa)
        Me.Panel1.Controls.Add(Me.btnSua)
        Me.Panel1.Location = New System.Drawing.Point(113, 237)
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
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(144, 8)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(248, 23)
        Me.txtHoTen.TabIndex = 1
        '
        'lbCode
        '
        Me.lbCode.AutoSize = True
        Me.lbCode.Location = New System.Drawing.Point(86, 49)
        Me.lbCode.Name = "lbCode"
        Me.lbCode.Size = New System.Drawing.Size(35, 15)
        Me.lbCode.TabIndex = 6
        Me.lbCode.Text = "Code"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Location = New System.Drawing.Point(64, 90)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(60, 15)
        Me.lbNgaySinh.TabIndex = 7
        Me.lbNgaySinh.Text = "Ngày sinh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mật khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Chi nhánh"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(144, 46)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(248, 23)
        Me.txtCode.TabIndex = 8
        '
        'dateNgaySinh
        '
        Me.dateNgaySinh.Location = New System.Drawing.Point(144, 84)
        Me.dateNgaySinh.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dateNgaySinh.Name = "dateNgaySinh"
        Me.dateNgaySinh.Size = New System.Drawing.Size(248, 23)
        Me.dateNgaySinh.TabIndex = 9
        Me.dateNgaySinh.Value = New Date(2021, 8, 10, 0, 0, 0, 0)
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(144, 122)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(248, 23)
        Me.txtMatKhau.TabIndex = 10
        '
        'cbChiNhanh
        '
        Me.cbChiNhanh.FormattingEnabled = True
        Me.cbChiNhanh.Location = New System.Drawing.Point(144, 160)
        Me.cbChiNhanh.Name = "cbChiNhanh"
        Me.cbChiNhanh.Size = New System.Drawing.Size(248, 23)
        Me.cbChiNhanh.TabIndex = 11
        '
        'FrmQuanLyNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 360)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dtGridNguoiDung As DataGridView
    Friend WithEvents nd_ma As DataGridViewTextBoxColumn
    Friend WithEvents nd_Code As DataGridViewTextBoxColumn
    Friend WithEvents nd_hoten As DataGridViewTextBoxColumn
    Friend WithEvents nd_ngaysinh As DataGridViewTextBoxColumn
    Friend WithEvents nd_matkhau As DataGridViewTextBoxColumn
    Friend WithEvents nd_chinhanh As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents lbCode As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents dateNgaySinh As DateTimePicker
    Friend WithEvents cbChiNhanh As ComboBox
End Class
