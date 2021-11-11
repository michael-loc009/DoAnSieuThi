<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmThongKeDoanhThu
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_tk_doanh_thu_loc = New System.Windows.Forms.Button()
        Me.date_tk_doanh_thu_to = New System.Windows.Forms.DateTimePicker()
        Me.date_tk_doanh_thu_from = New System.Windows.Forms.DateTimePicker()
        Me.dtGridTkDoanhThu = New System.Windows.Forms.DataGridView()
        Me.ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doanh_thu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGridTkDoanhThu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_tk_doanh_thu_loc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_doanh_thu_to)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_doanh_thu_from)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGridTkDoanhThu)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(310, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Đến:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(30, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Từ:"
        '
        'btn_tk_doanh_thu_loc
        '
        Me.btn_tk_doanh_thu_loc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tk_doanh_thu_loc.Location = New System.Drawing.Point(606, 33)
        Me.btn_tk_doanh_thu_loc.Name = "btn_tk_doanh_thu_loc"
        Me.btn_tk_doanh_thu_loc.Size = New System.Drawing.Size(75, 23)
        Me.btn_tk_doanh_thu_loc.TabIndex = 2
        Me.btn_tk_doanh_thu_loc.Text = "Lọc"
        Me.btn_tk_doanh_thu_loc.UseVisualStyleBackColor = True
        '
        'date_tk_doanh_thu_to
        '
        Me.date_tk_doanh_thu_to.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_doanh_thu_to.Location = New System.Drawing.Point(360, 35)
        Me.date_tk_doanh_thu_to.Name = "date_tk_doanh_thu_to"
        Me.date_tk_doanh_thu_to.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_doanh_thu_to.TabIndex = 1
        '
        'date_tk_doanh_thu_from
        '
        Me.date_tk_doanh_thu_from.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_doanh_thu_from.Location = New System.Drawing.Point(76, 35)
        Me.date_tk_doanh_thu_from.Name = "date_tk_doanh_thu_from"
        Me.date_tk_doanh_thu_from.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_doanh_thu_from.TabIndex = 0
        '
        'dtGridTkDoanhThu
        '
        Me.dtGridTkDoanhThu.AllowUserToAddRows = False
        Me.dtGridTkDoanhThu.AllowUserToDeleteRows = False
        Me.dtGridTkDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridTkDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridTkDoanhThu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ngay, Me.doanh_thu})
        Me.dtGridTkDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGridTkDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGridTkDoanhThu.Location = New System.Drawing.Point(0, 0)
        Me.dtGridTkDoanhThu.MultiSelect = False
        Me.dtGridTkDoanhThu.Name = "dtGridTkDoanhThu"
        Me.dtGridTkDoanhThu.ReadOnly = True
        Me.dtGridTkDoanhThu.RowTemplate.Height = 25
        Me.dtGridTkDoanhThu.Size = New System.Drawing.Size(800, 359)
        Me.dtGridTkDoanhThu.TabIndex = 0
        '
        'ngay
        '
        Me.ngay.DataPropertyName = "ngay"
        Me.ngay.HeaderText = "Ngày"
        Me.ngay.Name = "ngay"
        Me.ngay.ReadOnly = True
        '
        'doanh_thu
        '
        Me.doanh_thu.DataPropertyName = "doanh_thu"
        Me.doanh_thu.HeaderText = "Doanh Thu"
        Me.doanh_thu.Name = "doanh_thu"
        Me.doanh_thu.ReadOnly = True
        '
        'FrmThongKeDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmThongKeDoanhThu"
        Me.Text = "Thống kê doanh thu"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGridTkDoanhThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn_tk_doanh_thu_loc As Button
    Friend WithEvents date_tk_doanh_thu_to As DateTimePicker
    Friend WithEvents date_tk_doanh_thu_from As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtGridTkDoanhThu As DataGridView
    Friend WithEvents ngay As DataGridViewTextBoxColumn
    Friend WithEvents doanh_thu As DataGridViewTextBoxColumn
End Class
