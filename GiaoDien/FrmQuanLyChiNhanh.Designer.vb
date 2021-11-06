<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuanLyChiNhanh
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
        Me.dtGridChiNhanh = New System.Windows.Forms.DataGridView()
        Me.cn_ma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cn_ten = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cn_dia_chi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cn_xoa = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txt_tim_kiem_chi_nhanh = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cn_dia_chi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txt_cn_ten = New System.Windows.Forms.TextBox()
        Me.err_provider_cn_ten = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridChiNhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.err_provider_cn_ten, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtGridChiNhanh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_tim_kiem_chi_nhanh)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGridChiNhanh
        '
        Me.dtGridChiNhanh.AllowUserToAddRows = False
        Me.dtGridChiNhanh.AllowUserToDeleteRows = False
        Me.dtGridChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridChiNhanh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cn_ma, Me.cn_ten, Me.cn_dia_chi, Me.cn_xoa})
        Me.dtGridChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridChiNhanh.Location = New System.Drawing.Point(0, 23)
        Me.dtGridChiNhanh.MultiSelect = False
        Me.dtGridChiNhanh.Name = "dtGridChiNhanh"
        Me.dtGridChiNhanh.ReadOnly = True
        Me.dtGridChiNhanh.RowTemplate.Height = 25
        Me.dtGridChiNhanh.Size = New System.Drawing.Size(266, 427)
        Me.dtGridChiNhanh.TabIndex = 1
        '
        'cn_ma
        '
        Me.cn_ma.DataPropertyName = "cn_ma"
        Me.cn_ma.HeaderText = "Mã"
        Me.cn_ma.Name = "cn_ma"
        Me.cn_ma.ReadOnly = True
        '
        'cn_ten
        '
        Me.cn_ten.DataPropertyName = "cn_ten"
        Me.cn_ten.HeaderText = "Tên"
        Me.cn_ten.Name = "cn_ten"
        Me.cn_ten.ReadOnly = True
        '
        'cn_dia_chi
        '
        Me.cn_dia_chi.DataPropertyName = "cn_dia_chi"
        Me.cn_dia_chi.HeaderText = "Địa chỉ"
        Me.cn_dia_chi.Name = "cn_dia_chi"
        Me.cn_dia_chi.ReadOnly = True
        '
        'cn_xoa
        '
        Me.cn_xoa.DataPropertyName = "cn_xoa"
        Me.cn_xoa.HeaderText = "Xóa"
        Me.cn_xoa.Name = "cn_xoa"
        Me.cn_xoa.ReadOnly = True
        Me.cn_xoa.Visible = False
        '
        'txt_tim_kiem_chi_nhanh
        '
        Me.txt_tim_kiem_chi_nhanh.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_tim_kiem_chi_nhanh.Location = New System.Drawing.Point(0, 0)
        Me.txt_tim_kiem_chi_nhanh.Name = "txt_tim_kiem_chi_nhanh"
        Me.txt_tim_kiem_chi_nhanh.Size = New System.Drawing.Size(266, 23)
        Me.txt_tim_kiem_chi_nhanh.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_cn_dia_chi)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.txt_cn_ten)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(530, 236)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Địa chỉ"
        '
        'txt_cn_dia_chi
        '
        Me.txt_cn_dia_chi.Location = New System.Drawing.Point(145, 71)
        Me.txt_cn_dia_chi.Multiline = True
        Me.txt_cn_dia_chi.Name = "txt_cn_dia_chi"
        Me.txt_cn_dia_chi.Size = New System.Drawing.Size(248, 74)
        Me.txt_cn_dia_chi.TabIndex = 6
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
        Me.Panel1.Location = New System.Drawing.Point(98, 167)
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
        'txt_cn_ten
        '
        Me.txt_cn_ten.Location = New System.Drawing.Point(145, 10)
        Me.txt_cn_ten.Name = "txt_cn_ten"
        Me.txt_cn_ten.Size = New System.Drawing.Size(248, 23)
        Me.txt_cn_ten.TabIndex = 1
        '
        'err_provider_cn_ten
        '
        Me.err_provider_cn_ten.ContainerControl = Me
        '
        'FrmQuanLyChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmQuanLyChiNhanh"
        Me.Text = "Quản lí chi nhánh"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridChiNhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.err_provider_cn_ten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt_tim_kiem_chi_nhanh As TextBox
    Friend WithEvents dtGridChiNhanh As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cn_ten As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_cn_dia_chi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents err_provider_cn_ten As ErrorProvider
    Friend WithEvents cn_ma As DataGridViewTextBoxColumn
    Friend WithEvents cn_ten As DataGridViewTextBoxColumn
    Friend WithEvents cn_dia_chi As DataGridViewTextBoxColumn
    Friend WithEvents cn_xoa As DataGridViewCheckBoxColumn
End Class
