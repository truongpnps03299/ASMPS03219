<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsanpham))
        Me.dgvsanpham = New System.Windows.Forms.DataGridView()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.MaKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diachi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtdiachisx = New System.Windows.Forms.TextBox()
        Me.txtngaysx = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsanpham
        '
        Me.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsanpham.Location = New System.Drawing.Point(22, 198)
        Me.dgvsanpham.Name = "dgvsanpham"
        Me.dgvsanpham.Size = New System.Drawing.Size(547, 206)
        Me.dgvsanpham.TabIndex = 40
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(124, 65)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(137, 20)
        Me.txtMaLoai.TabIndex = 38
        '
        'dgvKH
        '
        Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKH, Me.TenKH, Me.SDT, Me.Email, Me.Diachi})
        Me.dgvKH.Location = New System.Drawing.Point(39, 198)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(0, 0)
        Me.dgvKH.TabIndex = 37
        '
        'MaKH
        '
        Me.MaKH.HeaderText = "Mã KH"
        Me.MaKH.Name = "MaKH"
        '
        'TenKH
        '
        Me.TenKH.HeaderText = "Tên KH"
        Me.TenKH.Name = "TenKH"
        '
        'SDT
        '
        Me.SDT.HeaderText = "SĐT"
        Me.SDT.Name = "SDT"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Diachi
        '
        Me.Diachi.HeaderText = "Địa Chỉ"
        Me.Diachi.Name = "Diachi"
        '
        'txtdiachisx
        '
        Me.txtdiachisx.Location = New System.Drawing.Point(125, 118)
        Me.txtdiachisx.Name = "txtdiachisx"
        Me.txtdiachisx.Size = New System.Drawing.Size(377, 20)
        Me.txtdiachisx.TabIndex = 30
        '
        'txtngaysx
        '
        Me.txtngaysx.Location = New System.Drawing.Point(125, 91)
        Me.txtngaysx.Name = "txtngaysx"
        Me.txtngaysx.Size = New System.Drawing.Size(137, 20)
        Me.txtngaysx.TabIndex = 31
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(124, 39)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(137, 20)
        Me.txtTenSP.TabIndex = 32
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(124, 13)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(137, 20)
        Me.txtMaSP.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(35, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Mã Loại"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Địa chỉ SX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Ngày SX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tên SP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Mã SP"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Yellow
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(410, 152)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(54, 38)
        Me.btnclose.TabIndex = 45
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Fuchsia
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(319, 152)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(54, 38)
        Me.btnXoa.TabIndex = 42
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(177, 152)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(48, 38)
        Me.btnThem.TabIndex = 43
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(244, 152)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(46, 38)
        Me.btnSua.TabIndex = 44
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btntimkiem
        '
        Me.btntimkiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btntimkiem.BackgroundImage = CType(resources.GetObject("btntimkiem.BackgroundImage"), System.Drawing.Image)
        Me.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntimkiem.Location = New System.Drawing.Point(109, 152)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(43, 38)
        Me.btntimkiem.TabIndex = 41
        Me.btntimkiem.UseVisualStyleBackColor = False
        '
        'btnload
        '
        Me.btnload.BackgroundImage = CType(resources.GetObject("btnload.BackgroundImage"), System.Drawing.Image)
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnload.Location = New System.Drawing.Point(41, 152)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(43, 38)
        Me.btnload.TabIndex = 46
        Me.btnload.UseVisualStyleBackColor = True
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(591, 416)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.dgvsanpham)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.txtdiachisx)
        Me.Controls.Add(Me.txtngaysx)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsanpham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sản Phẩm"
        CType(Me.dgvsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvsanpham As DataGridView
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents MaKH As DataGridViewTextBoxColumn
    Friend WithEvents TenKH As DataGridViewTextBoxColumn
    Friend WithEvents SDT As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Diachi As DataGridViewTextBoxColumn
    Friend WithEvents txtdiachisx As TextBox
    Friend WithEvents txtngaysx As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btntimkiem As Button
    Friend WithEvents btnload As Button
End Class
