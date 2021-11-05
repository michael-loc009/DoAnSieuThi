<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Index
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
        Me.menuUngDung = New System.Windows.Forms.MenuStrip()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiNhánhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NgườiDùngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMụcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BánHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐơnHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUngDung.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuUngDung
        '
        Me.menuUngDung.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinToolStripMenuItem, Me.QuảnLýToolStripMenuItem, Me.BánHàngToolStripMenuItem})
        Me.menuUngDung.Location = New System.Drawing.Point(0, 0)
        Me.menuUngDung.Name = "menuUngDung"
        Me.menuUngDung.Size = New System.Drawing.Size(800, 24)
        Me.menuUngDung.TabIndex = 0
        Me.menuUngDung.Text = "MenuStrip1"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoátToolStripMenuItem})
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ThôngTinToolStripMenuItem.Text = "Thông tin"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChiNhánhToolStripMenuItem, Me.NgườiDùngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.DanhMụcToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'ChiNhánhToolStripMenuItem
        '
        Me.ChiNhánhToolStripMenuItem.Name = "ChiNhánhToolStripMenuItem"
        Me.ChiNhánhToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ChiNhánhToolStripMenuItem.Text = "Chi nhánh"
        '
        'NgườiDùngToolStripMenuItem
        '
        Me.NgườiDùngToolStripMenuItem.Name = "NgườiDùngToolStripMenuItem"
        Me.NgườiDùngToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NgườiDùngToolStripMenuItem.Text = "Người dùng"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'DanhMụcToolStripMenuItem
        '
        Me.DanhMụcToolStripMenuItem.Name = "DanhMụcToolStripMenuItem"
        Me.DanhMụcToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DanhMụcToolStripMenuItem.Text = "Danh mục sản phẩm"
        '
        'BánHàngToolStripMenuItem
        '
        Me.BánHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐơnHàngToolStripMenuItem})
        Me.BánHàngToolStripMenuItem.Name = "BánHàngToolStripMenuItem"
        Me.BánHàngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.BánHàngToolStripMenuItem.Text = "Bán hàng"
        '
        'ĐơnHàngToolStripMenuItem
        '
        Me.ĐơnHàngToolStripMenuItem.Name = "ĐơnHàngToolStripMenuItem"
        Me.ĐơnHàngToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ĐơnHàngToolStripMenuItem.Text = "Đơn hàng"
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.menuUngDung)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuUngDung
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ứng dụng quản lí siêu thị"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuUngDung.ResumeLayout(False)
        Me.menuUngDung.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuUngDung As MenuStrip
    Friend WithEvents ThôngTinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiNhánhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NgườiDùngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhMụcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BánHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĐơnHàngToolStripMenuItem As ToolStripMenuItem
End Class
