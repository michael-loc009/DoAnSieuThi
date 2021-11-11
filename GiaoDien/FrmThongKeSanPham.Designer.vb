<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmThongKeSanPham
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
        Me.tab_tk_sp = New System.Windows.Forms.TabControl()
        Me.tab_Tk_sp_theo_ngay = New System.Windows.Forms.TabPage()
        Me.tab_tk_sp_theo_thang = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.date_tk_sp_theo_ngay_from = New System.Windows.Forms.DateTimePicker()
        Me.date_tk_sp_theo_ngay_to = New System.Windows.Forms.DateTimePicker()
        Me.btn_tk_sp_loc_theo_ngay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtGrid_tk_sp_theo_ngay = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_tk_sp_loc_theo_thang = New System.Windows.Forms.Button()
        Me.dtGrid_tk_sp_theo_thang = New System.Windows.Forms.DataGridView()
        Me.dh_ngay_tao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sl_sp_ban = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_tk_sp_theo_thang_to = New System.Windows.Forms.DateTimePicker()
        Me.date_tk_sp_theo_thang_from = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_tk_sp.SuspendLayout()
        Me.tab_Tk_sp_theo_ngay.SuspendLayout()
        Me.tab_tk_sp_theo_thang.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGrid_tk_sp_theo_ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dtGrid_tk_sp_theo_thang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_tk_sp
        '
        Me.tab_tk_sp.Controls.Add(Me.tab_Tk_sp_theo_ngay)
        Me.tab_tk_sp.Controls.Add(Me.tab_tk_sp_theo_thang)
        Me.tab_tk_sp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_tk_sp.Location = New System.Drawing.Point(0, 0)
        Me.tab_tk_sp.Name = "tab_tk_sp"
        Me.tab_tk_sp.SelectedIndex = 0
        Me.tab_tk_sp.Size = New System.Drawing.Size(800, 450)
        Me.tab_tk_sp.TabIndex = 0
        '
        'tab_Tk_sp_theo_ngay
        '
        Me.tab_Tk_sp_theo_ngay.Controls.Add(Me.SplitContainer1)
        Me.tab_Tk_sp_theo_ngay.Location = New System.Drawing.Point(4, 24)
        Me.tab_Tk_sp_theo_ngay.Name = "tab_Tk_sp_theo_ngay"
        Me.tab_Tk_sp_theo_ngay.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Tk_sp_theo_ngay.Size = New System.Drawing.Size(792, 422)
        Me.tab_Tk_sp_theo_ngay.TabIndex = 0
        Me.tab_Tk_sp_theo_ngay.Text = "Theo ngày"
        Me.tab_Tk_sp_theo_ngay.UseVisualStyleBackColor = True
        '
        'tab_tk_sp_theo_thang
        '
        Me.tab_tk_sp_theo_thang.Controls.Add(Me.SplitContainer2)
        Me.tab_tk_sp_theo_thang.Location = New System.Drawing.Point(4, 24)
        Me.tab_tk_sp_theo_thang.Name = "tab_tk_sp_theo_thang"
        Me.tab_tk_sp_theo_thang.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_tk_sp_theo_thang.Size = New System.Drawing.Size(792, 422)
        Me.tab_tk_sp_theo_thang.TabIndex = 1
        Me.tab_tk_sp_theo_thang.Text = "Theo tháng"
        Me.tab_tk_sp_theo_thang.UseVisualStyleBackColor = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_tk_sp_loc_theo_ngay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_sp_theo_ngay_to)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_sp_theo_ngay_from)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGrid_tk_sp_theo_ngay)
        Me.SplitContainer1.Size = New System.Drawing.Size(786, 416)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 0
        '
        'date_tk_sp_theo_ngay_from
        '
        Me.date_tk_sp_theo_ngay_from.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_sp_theo_ngay_from.Location = New System.Drawing.Point(65, 32)
        Me.date_tk_sp_theo_ngay_from.Name = "date_tk_sp_theo_ngay_from"
        Me.date_tk_sp_theo_ngay_from.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_sp_theo_ngay_from.TabIndex = 0
        '
        'date_tk_sp_theo_ngay_to
        '
        Me.date_tk_sp_theo_ngay_to.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_sp_theo_ngay_to.Location = New System.Drawing.Point(357, 32)
        Me.date_tk_sp_theo_ngay_to.Name = "date_tk_sp_theo_ngay_to"
        Me.date_tk_sp_theo_ngay_to.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_sp_theo_ngay_to.TabIndex = 1
        '
        'btn_tk_sp_loc_theo_ngay
        '
        Me.btn_tk_sp_loc_theo_ngay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tk_sp_loc_theo_ngay.Location = New System.Drawing.Point(631, 31)
        Me.btn_tk_sp_loc_theo_ngay.Name = "btn_tk_sp_loc_theo_ngay"
        Me.btn_tk_sp_loc_theo_ngay.Size = New System.Drawing.Size(75, 23)
        Me.btn_tk_sp_loc_theo_ngay.TabIndex = 2
        Me.btn_tk_sp_loc_theo_ngay.Text = "Lọc"
        Me.btn_tk_sp_loc_theo_ngay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Từ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(307, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Đến:"
        '
        'dtGrid_tk_sp_theo_ngay
        '
        Me.dtGrid_tk_sp_theo_ngay.AllowUserToAddRows = False
        Me.dtGrid_tk_sp_theo_ngay.AllowUserToDeleteRows = False
        Me.dtGrid_tk_sp_theo_ngay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_tk_sp_theo_ngay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_tk_sp_theo_ngay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dh_ngay_tao, Me.sl_sp_ban})
        Me.dtGrid_tk_sp_theo_ngay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGrid_tk_sp_theo_ngay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_tk_sp_theo_ngay.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_tk_sp_theo_ngay.MultiSelect = False
        Me.dtGrid_tk_sp_theo_ngay.Name = "dtGrid_tk_sp_theo_ngay"
        Me.dtGrid_tk_sp_theo_ngay.ReadOnly = True
        Me.dtGrid_tk_sp_theo_ngay.RowTemplate.Height = 25
        Me.dtGrid_tk_sp_theo_ngay.Size = New System.Drawing.Size(786, 307)
        Me.dtGrid_tk_sp_theo_ngay.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_tk_sp_loc_theo_thang)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.date_tk_sp_theo_thang_to)
        Me.SplitContainer2.Panel1.Controls.Add(Me.date_tk_sp_theo_thang_from)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dtGrid_tk_sp_theo_thang)
        Me.SplitContainer2.Size = New System.Drawing.Size(786, 416)
        Me.SplitContainer2.SplitterDistance = 113
        Me.SplitContainer2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(24, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Từ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(341, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Đến:"
        '
        'btn_tk_sp_loc_theo_thang
        '
        Me.btn_tk_sp_loc_theo_thang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tk_sp_loc_theo_thang.Location = New System.Drawing.Point(646, 37)
        Me.btn_tk_sp_loc_theo_thang.Name = "btn_tk_sp_loc_theo_thang"
        Me.btn_tk_sp_loc_theo_thang.Size = New System.Drawing.Size(75, 23)
        Me.btn_tk_sp_loc_theo_thang.TabIndex = 12
        Me.btn_tk_sp_loc_theo_thang.Text = "Lọc"
        Me.btn_tk_sp_loc_theo_thang.UseVisualStyleBackColor = True
        '
        'dtGrid_tk_sp_theo_thang
        '
        Me.dtGrid_tk_sp_theo_thang.AllowUserToAddRows = False
        Me.dtGrid_tk_sp_theo_thang.AllowUserToDeleteRows = False
        Me.dtGrid_tk_sp_theo_thang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_tk_sp_theo_thang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_tk_sp_theo_thang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dtGrid_tk_sp_theo_thang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGrid_tk_sp_theo_thang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_tk_sp_theo_thang.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_tk_sp_theo_thang.MultiSelect = False
        Me.dtGrid_tk_sp_theo_thang.Name = "dtGrid_tk_sp_theo_thang"
        Me.dtGrid_tk_sp_theo_thang.ReadOnly = True
        Me.dtGrid_tk_sp_theo_thang.RowTemplate.Height = 25
        Me.dtGrid_tk_sp_theo_thang.Size = New System.Drawing.Size(786, 299)
        Me.dtGrid_tk_sp_theo_thang.TabIndex = 0
        '
        'dh_ngay_tao
        '
        Me.dh_ngay_tao.DataPropertyName = "dh_ngay_tao"
        Me.dh_ngay_tao.HeaderText = "Ngày"
        Me.dh_ngay_tao.Name = "dh_ngay_tao"
        Me.dh_ngay_tao.ReadOnly = True
        '
        'sl_sp_ban
        '
        Me.sl_sp_ban.DataPropertyName = "sl_sp_ban"
        Me.sl_sp_ban.HeaderText = "Số lượng sản phẩm được bán"
        Me.sl_sp_ban.Name = "sl_sp_ban"
        Me.sl_sp_ban.ReadOnly = True
        '
        'date_tk_sp_theo_thang_to
        '
        Me.date_tk_sp_theo_thang_to.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_sp_theo_thang_to.Location = New System.Drawing.Point(389, 37)
        Me.date_tk_sp_theo_thang_to.Name = "date_tk_sp_theo_thang_to"
        Me.date_tk_sp_theo_thang_to.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_sp_theo_thang_to.TabIndex = 1
        '
        'date_tk_sp_theo_thang_from
        '
        Me.date_tk_sp_theo_thang_from.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_sp_theo_thang_from.Location = New System.Drawing.Point(68, 37)
        Me.date_tk_sp_theo_thang_from.Name = "date_tk_sp_theo_thang_from"
        Me.date_tk_sp_theo_thang_from.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_sp_theo_thang_from.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dh_ngay_tao"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tháng"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sl_sp_ban"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Số lượng sản phẩm được bán"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'FrmThongKeSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab_tk_sp)
        Me.Name = "FrmThongKeSanPham"
        Me.Text = "Thống kê số lượng sản phẩm được bán"
        Me.tab_tk_sp.ResumeLayout(False)
        Me.tab_Tk_sp_theo_ngay.ResumeLayout(False)
        Me.tab_tk_sp_theo_thang.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGrid_tk_sp_theo_ngay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dtGrid_tk_sp_theo_thang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_tk_sp As TabControl
    Friend WithEvents tab_Tk_sp_theo_ngay As TabPage
    Friend WithEvents tab_tk_sp_theo_thang As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn_tk_sp_loc_theo_ngay As Button
    Friend WithEvents date_tk_sp_theo_ngay_to As DateTimePicker
    Friend WithEvents date_tk_sp_theo_ngay_from As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtGrid_tk_sp_theo_ngay As DataGridView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_tk_sp_loc_theo_thang As Button
    Friend WithEvents dtGrid_tk_sp_theo_thang As DataGridView
    Friend WithEvents dh_ngay_tao As DataGridViewTextBoxColumn
    Friend WithEvents sl_sp_ban As DataGridViewTextBoxColumn
    Friend WithEvents date_tk_sp_theo_thang_to As DateTimePicker
    Friend WithEvents date_tk_sp_theo_thang_from As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
