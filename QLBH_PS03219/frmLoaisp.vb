Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLoaisp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03219.mssql.somee.com;packet size=4096;user id=PS03219_SQLLogin_1;pwd=ecedtlonlt;data source=PS03219.mssql.somee.com;persist security info=False;initial catalog=PS03219"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select MaLoai as 'Mã Loại',TenLoai as 'Tên Loại' from LoaiSanPham", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvloaisp.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub
    Private Sub frmLoaisp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaLoai as 'Mã Loại',TenLoai as 'Tên Loại' from LoaiSanPham", conn)
        conn.Open()
        load.Fill(db)
        dgvloaisp.DataSource = db.DefaultView

    End Sub

    Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaLoai as 'Mã Loại',TenLoai as 'Tên Loại' from LoaiSanPham where MaLoai like'%" & txtMaLoai.Text & "%'", connect)
        Try
            If txtMaLoai.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvloaisp.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvloaisp.DataSource = db.DefaultView
                    txtMaLoai.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaLoai.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into LoaiSanPham values(@MaLoai,@TenLoai)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaLoai.Focus()
            If txtMaLoai.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaLoai.Focus()
                If txtTenLoai.Text = "" Then
                    MessageBox.Show("Vui lòng nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                Else
                    save.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
                    save.Parameters.AddWithValue("@TenLoai", txtTenLoai.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaLoai.Text = Nothing
                    txtTenLoai.Text = Nothing
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã loại sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaLoai as 'Mã Loại',TenLoai as 'Tên Loại' from LoaiSanPham", conn)
        db.Clear()
        refesh.Fill(db)
        dgvloaisp.DataSource = db.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            txtMaLoai.Focus()
            If txtMaLoai.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaLoai.Focus()
                If txtTenLoai.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên loại sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    Dim sql As String = <sql>
                                                    update LoaiSanPham
                                                    set  TenLoai=N'{0}'
                                                    where MaLoai='{1}' 
                                                </sql>
                    sql = String.Format(sql, txtTenLoai.Text, txtMaLoai.Text)
                    Excutenonquery(sql)


                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtMaLoai.Text = Nothing
                    txtTenLoai.Text = Nothing

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvloaisp.DataSource = db
        dgvloaisp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE LoaiSanPham WHERE MaLoai = @MaLoai") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaLoai.Focus()
            If txtMaLoai.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text)
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
        dgvloaisp.DataSource = db
        dgvloaisp.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub dgvloaisp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvloaisp.CellContentClick
        Dim click As Integer = dgvloaisp.CurrentCell.RowIndex
        txtMaLoai.Text = dgvloaisp.Item(0, click).Value
        txtTenLoai.Text = dgvloaisp.Item(1, click).Value

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaLoai as 'Mã Loại',TenLoai as 'Tên Loại' from LoaiSanPham", conn)
        conn.Open()
        load.Fill(db)
        dgvloaisp.DataSource = db.DefaultView
    End Sub
End Class