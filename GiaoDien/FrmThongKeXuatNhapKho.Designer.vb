<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThongKeXuatNhapKho
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_tk_nk = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_tk_nk_loc = New System.Windows.Forms.Button()
        Me.date_tk_nk_to = New System.Windows.Forms.DateTimePicker()
        Me.date_tk_nk_from = New System.Windows.Forms.DateTimePicker()
        Me.dtGrid_tk_sp_nhap_kho = New System.Windows.Forms.DataGridView()
        Me.ngay_tao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sl_sp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_tk_xk = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_tk_xk_loc = New System.Windows.Forms.Button()
        Me.date_tk_xk_to = New System.Windows.Forms.DateTimePicker()
        Me.date_tk_xk_from = New System.Windows.Forms.DateTimePicker()
        Me.dtGrid_tk_xk = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tab_tk_nk.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGrid_tk_sp_nhap_kho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_tk_xk.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dtGrid_tk_xk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_tk_nk)
        Me.TabControl1.Controls.Add(Me.tab_tk_xk)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0
        '
        'tab_tk_nk
        '
        Me.tab_tk_nk.Controls.Add(Me.SplitContainer1)
        Me.tab_tk_nk.Location = New System.Drawing.Point(4, 24)
        Me.tab_tk_nk.Name = "tab_tk_nk"
        Me.tab_tk_nk.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_tk_nk.Size = New System.Drawing.Size(792, 422)
        Me.tab_tk_nk.TabIndex = 0
        Me.tab_tk_nk.Text = "Nhập kho"
        Me.tab_tk_nk.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_tk_nk_loc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_nk_to)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_nk_from)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGrid_tk_sp_nhap_kho)
        Me.SplitContainer1.Size = New System.Drawing.Size(786, 416)
        Me.SplitContainer1.SplitterDistance = 106
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(309, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Đến:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Từ:"
        '
        'btn_tk_nk_loc
        '
        Me.btn_tk_nk_loc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tk_nk_loc.Location = New System.Drawing.Point(636, 41)
        Me.btn_tk_nk_loc.Name = "btn_tk_nk_loc"
        Me.btn_tk_nk_loc.Size = New System.Drawing.Size(75, 23)
        Me.btn_tk_nk_loc.TabIndex = 2
        Me.btn_tk_nk_loc.Text = "Lọc"
        Me.btn_tk_nk_loc.UseVisualStyleBackColor = True
        '
        'date_tk_nk_to
        '
        Me.date_tk_nk_to.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_nk_to.Location = New System.Drawing.Point(359, 41)
        Me.date_tk_nk_to.Name = "date_tk_nk_to"
        Me.date_tk_nk_to.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_nk_to.TabIndex = 1
        '
        'date_tk_nk_from
        '
        Me.date_tk_nk_from.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_nk_from.Location = New System.Drawing.Point(58, 41)
        Me.date_tk_nk_from.Name = "date_tk_nk_from"
        Me.date_tk_nk_from.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_nk_from.TabIndex = 0
        '
        'dtGrid_tk_sp_nhap_kho
        '
        Me.dtGrid_tk_sp_nhap_kho.AllowUserToAddRows = False
        Me.dtGrid_tk_sp_nhap_kho.AllowUserToDeleteRows = False
        Me.dtGrid_tk_sp_nhap_kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_tk_sp_nhap_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_tk_sp_nhap_kho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ngay_tao, Me.sl_sp})
        Me.dtGrid_tk_sp_nhap_kho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGrid_tk_sp_nhap_kho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_tk_sp_nhap_kho.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_tk_sp_nhap_kho.MultiSelect = False
        Me.dtGrid_tk_sp_nhap_kho.Name = "dtGrid_tk_sp_nhap_kho"
        Me.dtGrid_tk_sp_nhap_kho.ReadOnly = True
        Me.dtGrid_tk_sp_nhap_kho.RowTemplate.Height = 25
        Me.dtGrid_tk_sp_nhap_kho.Size = New System.Drawing.Size(786, 306)
        Me.dtGrid_tk_sp_nhap_kho.TabIndex = 0
        '
        'ngay_tao
        '
        Me.ngay_tao.DataPropertyName = "ngay_tao"
        Me.ngay_tao.HeaderText = "Tháng"
        Me.ngay_tao.Name = "ngay_tao"
        Me.ngay_tao.ReadOnly = True
        '
        'sl_sp
        '
        Me.sl_sp.DataPropertyName = "sl_sp"
        Me.sl_sp.HeaderText = "Số lượng sản phẩm nhập kho"
        Me.sl_sp.Name = "sl_sp"
        Me.sl_sp.ReadOnly = True
        '
        'tab_tk_xk
        '
        Me.tab_tk_xk.Controls.Add(Me.SplitContainer2)
        Me.tab_tk_xk.Location = New System.Drawing.Point(4, 24)
        Me.tab_tk_xk.Name = "tab_tk_xk"
        Me.tab_tk_xk.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_tk_xk.Size = New System.Drawing.Size(792, 422)
        Me.tab_tk_xk.TabIndex = 1
        Me.tab_tk_xk.Text = "Xuất kho"
        Me.tab_tk_xk.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_tk_xk_loc)
        Me.SplitContainer2.Panel1.Controls.Add(Me.date_tk_xk_to)
        Me.SplitContainer2.Panel1.Controls.Add(Me.date_tk_xk_from)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dtGrid_tk_xk)
        Me.SplitContainer2.Size = New System.Drawing.Size(786, 416)
        Me.SplitContainer2.SplitterDistance = 112
        Me.SplitContainer2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(331, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Đến:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(44, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Từ:"
        '
        'btn_tk_xk_loc
        '
        Me.btn_tk_xk_loc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tk_xk_loc.Location = New System.Drawing.Point(657, 42)
        Me.btn_tk_xk_loc.Name = "btn_tk_xk_loc"
        Me.btn_tk_xk_loc.Size = New System.Drawing.Size(75, 23)
        Me.btn_tk_xk_loc.TabIndex = 2
        Me.btn_tk_xk_loc.Text = "Lọc"
        Me.btn_tk_xk_loc.UseVisualStyleBackColor = True
        '
        'date_tk_xk_to
        '
        Me.date_tk_xk_to.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_xk_to.Location = New System.Drawing.Point(383, 42)
        Me.date_tk_xk_to.Name = "date_tk_xk_to"
        Me.date_tk_xk_to.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_xk_to.TabIndex = 1
        '
        'date_tk_xk_from
        '
        Me.date_tk_xk_from.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_xk_from.Location = New System.Drawing.Point(91, 42)
        Me.date_tk_xk_from.Name = "date_tk_xk_from"
        Me.date_tk_xk_from.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_xk_from.TabIndex = 0
        '
        'dtGrid_tk_xk
        '
        Me.dtGrid_tk_xk.AllowUserToAddRows = False
        Me.dtGrid_tk_xk.AllowUserToDeleteRows = False
        Me.dtGrid_tk_xk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_tk_xk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_tk_xk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dtGrid_tk_xk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGrid_tk_xk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_tk_xk.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_tk_xk.MultiSelect = False
        Me.dtGrid_tk_xk.Name = "dtGrid_tk_xk"
        Me.dtGrid_tk_xk.ReadOnly = True
        Me.dtGrid_tk_xk.RowTemplate.Height = 25
        Me.dtGrid_tk_xk.Size = New System.Drawing.Size(786, 300)
        Me.dtGrid_tk_xk.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ngay_tao"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tháng"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sl_sp"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Số lượng sản phẩm xuất kho"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'FrmThongKeXuatNhapKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmThongKeXuatNhapKho"
        Me.Text = "Thông kê sản phẩm xuất/nhập kho"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_tk_nk.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGrid_tk_sp_nhap_kho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_tk_xk.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dtGrid_tk_xk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_tk_nk As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tab_tk_xk As TabPage
    Friend WithEvents dtGrid_tk_sp_nhap_kho As DataGridView
    Friend WithEvents date_tk_nk_to As DateTimePicker
    Friend WithEvents date_tk_nk_from As DateTimePicker
    Friend WithEvents btn_tk_nk_loc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents btn_tk_xk_loc As Button
    Friend WithEvents date_tk_xk_to As DateTimePicker
    Friend WithEvents date_tk_xk_from As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtGrid_tk_xk As DataGridView
    Friend WithEvents ngay_tao As DataGridViewTextBoxColumn
    Friend WithEvents sl_sp As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
