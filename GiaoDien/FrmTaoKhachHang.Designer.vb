<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaoKhachHang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_kh_them = New System.Windows.Forms.Button()
        Me.txt_kh_ho_ten = New System.Windows.Forms.TextBox()
        Me.date_kh_ngay_tao = New System.Windows.Forms.DateTimePicker()
        Me.err_provider_kh_ho_ten = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.err_provider_kh_ho_ten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_kh_them)
        Me.GroupBox1.Controls.Add(Me.txt_kh_ho_ten)
        Me.GroupBox1.Controls.Add(Me.date_kh_ngay_tao)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ngày tạo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(23, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Họ và tên:"
        '
        'btn_kh_them
        '
        Me.btn_kh_them.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_kh_them.Location = New System.Drawing.Point(153, 150)
        Me.btn_kh_them.Name = "btn_kh_them"
        Me.btn_kh_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_kh_them.TabIndex = 2
        Me.btn_kh_them.Text = "Tạo mới"
        Me.btn_kh_them.UseVisualStyleBackColor = True
        '
        'txt_kh_ho_ten
        '
        Me.txt_kh_ho_ten.Location = New System.Drawing.Point(108, 94)
        Me.txt_kh_ho_ten.Name = "txt_kh_ho_ten"
        Me.txt_kh_ho_ten.Size = New System.Drawing.Size(200, 23)
        Me.txt_kh_ho_ten.TabIndex = 1
        '
        'date_kh_ngay_tao
        '
        Me.date_kh_ngay_tao.Enabled = False
        Me.date_kh_ngay_tao.Location = New System.Drawing.Point(108, 40)
        Me.date_kh_ngay_tao.Name = "date_kh_ngay_tao"
        Me.date_kh_ngay_tao.Size = New System.Drawing.Size(200, 23)
        Me.date_kh_ngay_tao.TabIndex = 0
        '
        'err_provider_kh_ho_ten
        '
        Me.err_provider_kh_ho_ten.ContainerControl = Me
        '
        'FrmTaoKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(385, 194)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTaoKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tạo khách hàng mới"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err_provider_kh_ho_ten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_kh_ho_ten As TextBox
    Friend WithEvents date_kh_ngay_tao As DateTimePicker
    Friend WithEvents btn_kh_them As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents err_provider_kh_ho_ten As ErrorProvider
End Class
