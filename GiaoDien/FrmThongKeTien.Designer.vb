<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThongKeTien
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
        Me.date_tk_tien = New System.Windows.Forms.DateTimePicker()
        Me.dtGrid_tk_tien = New System.Windows.Forms.DataGridView()
        Me.ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doanh_thu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dtGrid_tk_tien, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_tk_tien)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtGrid_tk_tien)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 66
        Me.SplitContainer1.TabIndex = 0
        '
        'date_tk_tien
        '
        Me.date_tk_tien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.date_tk_tien.Enabled = False
        Me.date_tk_tien.Location = New System.Drawing.Point(296, 12)
        Me.date_tk_tien.Name = "date_tk_tien"
        Me.date_tk_tien.Size = New System.Drawing.Size(200, 23)
        Me.date_tk_tien.TabIndex = 0
        '
        'dtGrid_tk_tien
        '
        Me.dtGrid_tk_tien.AllowUserToAddRows = False
        Me.dtGrid_tk_tien.AllowUserToDeleteRows = False
        Me.dtGrid_tk_tien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid_tk_tien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid_tk_tien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ngay, Me.doanh_thu})
        Me.dtGrid_tk_tien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtGrid_tk_tien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid_tk_tien.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid_tk_tien.MultiSelect = False
        Me.dtGrid_tk_tien.Name = "dtGrid_tk_tien"
        Me.dtGrid_tk_tien.ReadOnly = True
        Me.dtGrid_tk_tien.RowTemplate.Height = 25
        Me.dtGrid_tk_tien.Size = New System.Drawing.Size(800, 380)
        Me.dtGrid_tk_tien.TabIndex = 0
        '
        'ngay
        '
        Me.ngay.DataPropertyName = "ngay"
        Me.ngay.HeaderText = "Ngày"
        Me.ngay.Name = "ngay"
        Me.ngay.ReadOnly = True
        Me.ngay.Visible = False
        '
        'doanh_thu
        '
        Me.doanh_thu.DataPropertyName = "doanh_thu"
        Me.doanh_thu.HeaderText = "Doanh Thu"
        Me.doanh_thu.Name = "doanh_thu"
        Me.doanh_thu.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(208, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Ngày hiện tại:"
        '
        'FrmThongKeTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmThongKeTien"
        Me.Text = "Thống kê tiền"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dtGrid_tk_tien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents date_tk_tien As DateTimePicker
    Friend WithEvents dtGrid_tk_tien As DataGridView
    Friend WithEvents ngay As DataGridViewTextBoxColumn
    Friend WithEvents doanh_thu As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
