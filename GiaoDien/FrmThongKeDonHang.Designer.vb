<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThongKeDonHang
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
        Me.dtGrid_tk_dh = New System.Windows.Forms.DataGridView()
        Me.date_tk_dh_from = New System.Windows.Forms.DateTimePicker()
        Me.date_tk_dh_to = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_tk_dh_loc = New System.Windows.Forms.Button()
        Me.ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dh_sl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGrid_tk_dh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_tk_dh_loc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_dh_to)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_dh_from)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGrid_tk_dh)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 0
        '
        'dtGrid_tk_dh
        '
        Me.dtGrid_tk_dh.AllowUserToAddRows = False
        Me.dtGrid_tk_dh.AllowUserToDeleteRows = False
        Me.dtGrid_tk_dh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_tk_dh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_tk_dh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ngay, Me.dh_sl})
        Me.dtGrid_tk_dh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_tk_dh.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_tk_dh.MultiSelect = False
        Me.dtGrid_tk_dh.Name = "dtGrid_tk_dh"
        Me.dtGrid_tk_dh.ReadOnly = True
        Me.dtGrid_tk_dh.RowTemplate.Height = 25
        Me.dtGrid_tk_dh.Size = New System.Drawing.Size(800, 337)
        Me.dtGrid_tk_dh.TabIndex = 0
        '
        'date_tk_dh_from
        '
        Me.date_tk_dh_from.Location = New System.Drawing.Point(76, 32)
        Me.date_tk_dh_from.Name = "date_tk_dh_from"
        Me.date_tk_dh_from.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_dh_from.TabIndex = 0
        '
        'date_tk_dh_to
        '
        Me.date_tk_dh_to.Location = New System.Drawing.Point(388, 32)
        Me.date_tk_dh_to.Name = "date_tk_dh_to"
        Me.date_tk_dh_to.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_dh_to.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Từ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(340, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Đến:"
        '
        'btn_tk_dh_loc
        '
        Me.btn_tk_dh_loc.Location = New System.Drawing.Point(657, 34)
        Me.btn_tk_dh_loc.Name = "btn_tk_dh_loc"
        Me.btn_tk_dh_loc.Size = New System.Drawing.Size(75, 23)
        Me.btn_tk_dh_loc.TabIndex = 11
        Me.btn_tk_dh_loc.Text = "Lọc"
        Me.btn_tk_dh_loc.UseVisualStyleBackColor = True
        '
        'ngay
        '
        Me.ngay.DataPropertyName = "ngay"
        Me.ngay.HeaderText = "Ngày"
        Me.ngay.Name = "ngay"
        Me.ngay.ReadOnly = True
        '
        'dh_sl
        '
        Me.dh_sl.DataPropertyName = "dh_sl"
        Me.dh_sl.HeaderText = "Số lượng đơn hàng"
        Me.dh_sl.Name = "dh_sl"
        Me.dh_sl.ReadOnly = True
        '
        'FrmThongKeDonHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmThongKeDonHang"
        Me.Text = "Thống kê đơn hàng"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGrid_tk_dh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dtGrid_tk_dh As DataGridView
    Friend WithEvents date_tk_dh_to As DateTimePicker
    Friend WithEvents date_tk_dh_from As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_tk_dh_loc As Button
    Friend WithEvents ngay As DataGridViewTextBoxColumn
    Friend WithEvents dh_sl As DataGridViewTextBoxColumn
End Class
