<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDangNhap
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
        Me.btn_dang_nhap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_dang_nhap_pass = New System.Windows.Forms.TextBox()
        Me.txt_dang_nhap_username = New System.Windows.Forms.TextBox()
        Me.err_provider_username = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err_provider_pass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.err_provider_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err_provider_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_dang_nhap)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_dang_nhap_pass)
        Me.GroupBox1.Controls.Add(Me.txt_dang_nhap_username)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tài khoản"
        '
        'btn_dang_nhap
        '
        Me.btn_dang_nhap.Location = New System.Drawing.Point(185, 129)
        Me.btn_dang_nhap.Name = "btn_dang_nhap"
        Me.btn_dang_nhap.Size = New System.Drawing.Size(75, 23)
        Me.btn_dang_nhap.TabIndex = 14
        Me.btn_dang_nhap.Text = "Đăng nhập"
        Me.btn_dang_nhap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(34, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Mật khẩu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(34, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tên đăng nhập:"
        '
        'txt_dang_nhap_pass
        '
        Me.txt_dang_nhap_pass.Location = New System.Drawing.Point(131, 90)
        Me.txt_dang_nhap_pass.Name = "txt_dang_nhap_pass"
        Me.txt_dang_nhap_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_dang_nhap_pass.Size = New System.Drawing.Size(203, 23)
        Me.txt_dang_nhap_pass.TabIndex = 1
        '
        'txt_dang_nhap_username
        '
        Me.txt_dang_nhap_username.Location = New System.Drawing.Point(131, 37)
        Me.txt_dang_nhap_username.Name = "txt_dang_nhap_username"
        Me.txt_dang_nhap_username.Size = New System.Drawing.Size(203, 23)
        Me.txt_dang_nhap_username.TabIndex = 0
        '
        'err_provider_username
        '
        Me.err_provider_username.ContainerControl = Me
        '
        'err_provider_pass
        '
        Me.err_provider_pass.ContainerControl = Me
        '
        'FrmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(410, 164)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmDangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err_provider_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err_provider_pass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_dang_nhap_pass As TextBox
    Friend WithEvents txt_dang_nhap_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_dang_nhap As Button
    Friend WithEvents err_provider_username As ErrorProvider
    Friend WithEvents err_provider_pass As ErrorProvider
End Class
