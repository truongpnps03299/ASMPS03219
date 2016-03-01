<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkhachhang))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Diachi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvkhachhang = New System.Windows.Forms.DataGridView()
        Me.btnload = New System.Windows.Forms.Button()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Yellow
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(412, 144)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(54, 38)
        Me.btnclose.TabIndex = 22
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Diachi
        '
        Me.Diachi.HeaderText = "Địa Chỉ"
        Me.Diachi.Name = "Diachi"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'SDT
        '
        Me.SDT.HeaderText = "SĐT"
        Me.SDT.Name = "SDT"
        '
        'TenKH
        '
        Me.TenKH.HeaderText = "Tên KH"
        Me.TenKH.Name = "TenKH"
        '
        'MaKH
        '
        Me.MaKH.HeaderText = "Mã KH"
        Me.MaKH.Name = "MaKH"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(88, 65)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(137, 20)
        Me.txtSDT.TabIndex = 21
        '
        'dgvKH
        '
        Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKH, Me.TenKH, Me.SDT, Me.Email, Me.Diachi})
        Me.dgvKH.Location = New System.Drawing.Point(30, 198)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(0, 0)
        Me.dgvKH.TabIndex = 20
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Fuchsia
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(329, 144)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(54, 38)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(167, 144)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(48, 38)
        Me.btnThem.TabIndex = 18
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSua.BackgroundImage = CType(resources.GetObject("btnSua.BackgroundImage"), System.Drawing.Image)
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(250, 144)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(46, 38)
        Me.btnSua.TabIndex = 19
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(88, 118)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(377, 20)
        Me.txtDiachi.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(88, 91)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(137, 20)
        Me.txtEmail.TabIndex = 14
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(88, 39)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(137, 20)
        Me.txtTenKH.TabIndex = 15
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(88, 13)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(137, 20)
        Me.txtMaKH.TabIndex = 16
        '
        'btntimkiem
        '
        Me.btntimkiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btntimkiem.BackgroundImage = CType(resources.GetObject("btntimkiem.BackgroundImage"), System.Drawing.Image)
        Me.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntimkiem.Location = New System.Drawing.Point(92, 144)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(43, 38)
        Me.btntimkiem.TabIndex = 12
        Me.btntimkiem.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SĐT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tên KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã KH"
        '
        'dgvkhachhang
        '
        Me.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhachhang.Location = New System.Drawing.Point(13, 198)
        Me.dgvkhachhang.Name = "dgvkhachhang"
        Me.dgvkhachhang.Size = New System.Drawing.Size(547, 206)
        Me.dgvkhachhang.TabIndex = 23
        '
        'btnload
        '
        Me.btnload.BackgroundImage = CType(resources.GetObject("btnload.BackgroundImage"), System.Drawing.Image)
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnload.Location = New System.Drawing.Point(26, 145)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(43, 38)
        Me.btnload.TabIndex = 24
        Me.btnload.UseVisualStyleBackColor = True
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(591, 416)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.dgvkhachhang)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmkhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents Diachi As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents SDT As DataGridViewTextBoxColumn
    Friend WithEvents TenKH As DataGridViewTextBoxColumn
    Friend WithEvents MaKH As DataGridViewTextBoxColumn
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btntimkiem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvkhachhang As DataGridView
    Friend WithEvents btnload As Button
End Class
