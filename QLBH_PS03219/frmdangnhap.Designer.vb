<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdangnhap))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtmk = New System.Windows.Forms.TextBox()
        Me.txtTendn = New System.Windows.Forms.TextBox()
        Me.btndn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "-----sonhbps03219@fpt.edu.vn------"
        '
        'btnthoat
        '
        Me.btnthoat.BackgroundImage = CType(resources.GetObject("btnthoat.BackgroundImage"), System.Drawing.Image)
        Me.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnthoat.Location = New System.Drawing.Point(480, 153)
        Me.btnthoat.Margin = New System.Windows.Forms.Padding(5)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(44, 37)
        Me.btnthoat.TabIndex = 32
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'txtmk
        '
        Me.txtmk.Location = New System.Drawing.Point(356, 112)
        Me.txtmk.Margin = New System.Windows.Forms.Padding(5)
        Me.txtmk.Name = "txtmk"
        Me.txtmk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmk.Size = New System.Drawing.Size(170, 20)
        Me.txtmk.TabIndex = 30
        '
        'txtTendn
        '
        Me.txtTendn.Location = New System.Drawing.Point(356, 71)
        Me.txtTendn.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTendn.Name = "txtTendn"
        Me.txtTendn.Size = New System.Drawing.Size(170, 20)
        Me.txtTendn.TabIndex = 29
        '
        'btndn
        '
        Me.btndn.BackgroundImage = CType(resources.GetObject("btndn.BackgroundImage"), System.Drawing.Image)
        Me.btndn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndn.Location = New System.Drawing.Point(362, 153)
        Me.btndn.Margin = New System.Windows.Forms.Padding(5)
        Me.btndn.Name = "btndn"
        Me.btndn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndn.Size = New System.Drawing.Size(97, 38)
        Me.btndn.TabIndex = 28
        Me.btndn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Mật khẩu :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(237, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tên đăng nhập :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(313, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 31)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ĐĂNG NHẬP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Tên đăng nhập: sonhbps03219  -  Mật khẩu: 123"
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 254)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtmk)
        Me.Controls.Add(Me.txtTendn)
        Me.Controls.Add(Me.btndn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmdangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnthoat As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtmk As TextBox
    Friend WithEvents txtTendn As TextBox
    Friend WithEvents btndn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
