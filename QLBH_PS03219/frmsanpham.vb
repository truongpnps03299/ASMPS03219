Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmsanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03219.mssql.somee.com;packet size=4096;user id=PS03219_SQLLogin_1;pwd=ecedtlonlt;data source=PS03219.mssql.somee.com;persist security info=False;initial catalog=PS03219"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)



    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtMaLoai.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã Loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMaLoai.Focus()
                        If txtngaysx.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ngày SX", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtngaysx.Focus()
                            If txtdiachisx.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập địa chỉ SX", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                Dim sql As String = <sql>
                                                    update SanPham
                                                    set  TenSP=N'{0}', MaLoai= '{1}', NgaySX= '{2}',DiaChiSX= N'{3}'
                                                    where MaSP='{4}' 
                                                </sql>
                                sql = String.Format(sql, txtTenSP.Text, txtMaLoai.Text, txtngaysx.Text, txtdiachisx.Text, txtMaSP.Text)
                                Excutenonquery(sql)


                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtMaSP.Text = Nothing
                                txtTenSP.Text = Nothing
                                txtMaLoai.Text = Nothing
                                txtngaysx.Text = Nothing
                                txtdiachisx.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvsanpham.DataSource = db
        dgvsanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai", conn)
        conn.Open()
        load.Fill(db)
        dgvsanpham.DataSource = db.DefaultView

    End Sub




    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE SanPham WHERE MaSP = @MaSP") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close() 'Dong ket noi CSDL
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
            'Thong bao xoa that bai
            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi lai CSDL
        db.Clear()
        dgvsanpham.DataSource = db
        dgvsanpham.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvsanpham.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btntimkiem_Click_1(sender As Object, e As EventArgs) Handles btntimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai where SanPham.MaSP like'%" & txtMaSP.Text & "%'", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvsanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvsanpham.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvsanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsanpham.CellContentClick
        Dim click As Integer = dgvsanpham.CurrentCell.RowIndex
        txtMaSP.Text = dgvsanpham.Item(0, click).Value
        txtTenSP.Text = dgvsanpham.Item(1, click).Value
        txtMaLoai.Text = dgvsanpham.Item(2, click).Value
        txtngaysx.Text = dgvsanpham.Item(3, click).Value
        txtdiachisx.Text = dgvsanpham.Item(4, click).Value
    End Sub

    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SanPham values(@MaSP,@TenSP,@MaLoai,@NgaySX,@DiaChiSX)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaSP.Focus()
                If txtTenSP.Text = "" Then
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenSP.Focus()
                    If txtMaLoai.Text = "" Then
                        MessageBox.Show("Vui lòng nhập mã loại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtMaLoai.Focus()
                        If txtngaysx.Text = "" Then
                            MessageBox.Show("Vui lòng nhập ngày SX", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtngaysx.Focus()
                            If txtdiachisx.Text = "" Then
                                MessageBox.Show("Vui lòng nhập địa chỉ SX", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                                save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                                save.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
                                save.Parameters.AddWithValue("@NgaySX", txtngaysx.Text)
                                save.Parameters.AddWithValue("@DiaChiSX", txtdiachisx.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaSP.Text = Nothing
                                txtTenSP.Text = Nothing
                                txtMaLoai.Text = Nothing
                                txtngaysx.Text = Nothing
                                txtdiachisx.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai", conn)
        db.Clear()
        refesh.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai", conn)
        conn.Open()
        load.Fill(db)
        dgvsanpham.DataSource = db.DefaultView
    End Sub
End Class