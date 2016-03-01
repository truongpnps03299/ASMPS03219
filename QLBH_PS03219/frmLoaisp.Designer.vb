<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaisp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoaisp))
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.MaLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvloaisp = New System.Windows.Forms.DataGridView()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btntimkiem = New System.Windows.Forms.Button()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvloaisp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvXemsp
        '
        Me.dgvXemsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaLoai, Me.TenLoai})
        Me.dgvXemsp.Location = New System.Drawing.Point(20, 75)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(0, 0)
        Me.dgvXemsp.TabIndex = 9
        '
        'MaLoai
        '
        Me.MaLoai.HeaderText = "Mã Loại"
        Me.MaLoai.Name = "MaLoai"
        '
        'TenLoai
        '
        Me.TenLoai.HeaderText = "Tên Loại"
        Me.TenLoai.Name = "TenLoai"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(89, 41)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(197, 20)
        Me.txtTenLoai.TabIndex = 8
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(89, 12)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(197, 20)
        Me.txtMaLoai.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên Loại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã Loại"
        '
        'dgvloaisp
        '
        Me.dgvloaisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvloaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvloaisp.Location = New System.Drawing.Point(12, 81)
        Me.dgvloaisp.Name = "dgvloaisp"
        Me.dgvloaisp.Size = New System.Drawing.Size(274, 268)
        Me.dgvloaisp.TabIndex = 10
        '
        'btnload
        '
        Me.btnload.BackgroundImage = CType(resources.GetObject("btnload.BackgroundImage"), System.Drawing.Image)
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnload.Location = New System.Drawing.Point(342, 15)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(43, 38)
        Me.btnload.TabIndex = 52
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Yellow
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(342, 302)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(43, 38)
        Me.btnclose.TabIndex = 51
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Fuchsia
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(342, 246)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(43, 38)
        Me.btnXoa.TabIndex = 48
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(342, 129)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(43, 38)
        Me.btnThem.TabIndex = 49
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(342, 190)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(43, 38)
        Me.btnSua.TabIndex = 50
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btntimkiem
        '
        Me.btntimkiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btntimkiem.BackgroundImage = CType(resources.GetObject("btntimkiem.BackgroundImage"), System.Drawing.Image)
        Me.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntimkiem.Location = New System.Drawing.Point(342, 73)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(43, 38)
        Me.btntimkiem.TabIndex = 47
        Me.btntimkiem.UseVisualStyleBackColor = False
        '
        'frmLoaisp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(429, 361)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.dgvloaisp)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoaisp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loại Sản Phẩm"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvloaisp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvXemsp As DataGridView
    Friend WithEvents MaLoai As DataGridViewTextBoxColumn
    Friend WithEvents TenLoai As DataGridViewTextBoxColumn
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvloaisp As DataGridView
    Friend WithEvents btnload As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btntimkiem As Button
End Class
