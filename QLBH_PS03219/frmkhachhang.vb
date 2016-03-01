Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmkhachhang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03219.mssql.somee.com;packet size=4096;user id=PS03219_SQLLogin_1;pwd=ecedtlonlt;data source=PS03219.mssql.somee.com;persist security info=False;initial catalog=PS03219"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KhachHang values(@MaKH,@TenKH,@SDT,@Email,@DiaChi)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Vui lòng nhập SĐT", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Vui lòng nhập Email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtEmail.Focus()
                            If txtDiachi.Text = "" Then
                                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                save.Parameters.AddWithValue("@Email", txtEmail.Text)
                                save.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                                txtDiachi.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH', TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa chỉ' from KhachHang", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub




    Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH', TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa chỉ' from KhachHang where MaKH like'%" & txtMaKH.Text & "%' ", connect)
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvkhachhang.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvkhachhang.DataSource = db.DefaultView
                    txtMaKH.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaKH.Text = Nothing

                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick
        Dim click As Integer = dgvkhachhang.CurrentCell.RowIndex
        txtMaKH.Text = dgvkhachhang.Item(0, click).Value
        txtTenKH.Text = dgvkhachhang.Item(1, click).Value
        txtSDT.Text = dgvkhachhang.Item(2, click).Value
        txtEmail.Text = dgvkhachhang.Item(3, click).Value
        txtDiachi.Text = dgvkhachhang.Item(4, click).Value
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTenKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenKH.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập SĐT", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập Email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtEmail.Focus()
                            If txtDiachi.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                Dim sql As String = <sql>
                                                    update KhachHang
                                                    set  TenKH= N'{0}', SDT= '{1}', Email= '{2}',DiaChi= N'{3}'
                                                    where MaKH='{4}' 
                                                </sql>
                                sql = String.Format(sql, txtTenKH.Text, txtSDT.Text, txtEmail.Text, txtDiachi.Text, txtMaKH.Text)
                                Excutenonquery(sql)


                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtMaKH.Text = Nothing
                                txtTenKH.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                                txtDiachi.Text = Nothing
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
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH', TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa chỉ' from KhachHang", conn)
        conn.Open()
        load.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView

    End Sub




    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE KhachHang WHERE MaKH = @MaKH") 'Truy van xoa
        Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
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
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên KH' ,SDT as 'SĐT',Email as 'Email', DiaChi as 'Địa chỉ' from KhachHang", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH', TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa chỉ' from KhachHang", conn)
        conn.Open()
        load.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub
End Class
'Imports System.Data.DataTable

'Public Class frmkhachhang
'    Dim db As New DataTable
'    Dim chuoiketnoi As String = "Data Source=localhost;Initial Catalog=PS03219;Integrated Security=True"
'    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

'    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
'        Close()
'    End Sub

'    Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
'        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
'        connect.Open()
'        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa chỉ' from KhachHang where MaKH='" & txtMaKH.Text & "'", connect)
'        Try
'            If txtMaKH.Text = "" Then
'                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

'            Else
'                db.Clear()
'                dgvkhachhang.DataSource = Nothing
'                xem.Fill(db)
'                If db.Rows.Count > 0 Then
'                    dgvkhachhang.DataSource = db.DefaultView
'                    txtMaKH.Text = Nothing

'                Else
'                    MessageBox.Show("Không tìm thấy")
'                    txtMaKH.Text = Nothing
'                End If
'            End If
'            connect.Close()
'        Catch ex As Exception
'        End Try
'    End Sub


'    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick
'        Dim click As Integer = dgvkhachhang.CurrentCell.RowIndex
'        txtMaKH.Text = dgvkhachhang.Item(0, click).Value
'        txtTenKH.Text = dgvkhachhang.Item(1, click).Value
'        txtSDT.Text = dgvkhachhang.Item(2, click).Value
'        txtEmail.Text = dgvkhachhang.Item(3, click).Value
'        txtDiachi.Text = dgvkhachhang.Item(4, click).Value
'    End Sub
'    'sự kiện làm mới
'    Private Sub LoadData()
'        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
'        Dim load As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã KH' ,TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa Chỉ' from KhachHang", conn)

'        conn.Open()
'        load.Fill(db)
'        dgvkhachhang.DataSource = db.DefaultView
'    End Sub

'    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
'        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
'        Dim updatequery As String = "update KhachHang set MaKH=@MaKH, TenKH=@TenKH, SDT=@SDT, Email=@Email,Diachi=@DiaChi  where MaKH=@MaKH"
'        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
'        conn.Open()
'        Try
'            txtMaKH.Focus()
'            If txtMaKH.Text = "" Then
'                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'            Else
'                txtTenKH.Focus()
'                If txtTenKH.Text = "" Then
'                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                Else
'                    txtSDT.Focus()
'                    If txtSDT.Text = "" Then
'                        MessageBox.Show("Bạn chưa nhập SĐT", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                    Else
'                        txtEmail.Focus()
'                        If txtEmail.Text = "" Then
'                            MessageBox.Show("Bạn chưa nhập Email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                        Else
'                            txtDiachi.Focus()
'                            If txtDiachi.Text = "" Then
'                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                            Else
'                                addupdate.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
'                                addupdate.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
'                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
'                                addupdate.Parameters.AddWithValue("@Email", txtEmail.Text)
'                                addupdate.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
'                                addupdate.ExecuteNonQuery()
'                                conn.Close() 'đóng kết nối
'                                MessageBox.Show("Cập nhật thành công")
'                                txtMaKH.Text = Nothing
'                                txtTenKH.Text = Nothing
'                                txtSDT.Text = Nothing
'                                txtEmail.Text = Nothing
'                                txtDiachi.Text = Nothing

'                            End If
'                        End If
'                    End If
'                End If
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
'        End Try

'        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
'        db.Clear()
'        dgvkhachhang.DataSource = db
'        dgvkhachhang.DataSource = Nothing
'        LoadData()
'    End Sub

'    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
'        Dim delquery As String = ("delete from KhachHang where MaKH=@MaKH")
'        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
'        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
'        conn.Open()
'        Try
'            If txtMaKH.Text = "" Then
'                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                txtMaKH.Focus()
'            Else
'                'If resulft = Windows.Forms.DialogResult.Yes Then
'                '    delete.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
'                '    delete.ExecuteNonQuery()
'                '    connect.Close()
'                '    MessageBox.Show("Xóa thành công")
'                '    'Sau khi xóa thành công, tự động làm mới các khung textbox
'                '    txtMaKH.Text = Nothing
'                '    txtTenKH.Text = Nothing
'                '    txtSDT.Text = Nothing
'                '    txtEmail.Text = Nothing
'                '    txtDiachi.Text = Nothing
'                'End If
'                Dim sql As String = <sql>
'                                        delete from KhachHang where MaKH = '{0}'        
'                                    </sql>
'                sql = String.Format(sql, txtMaKH.Text)
'                Excutenonquery(sql)
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
'        End Try

'        'làm mới bảng
'        db.Clear()
'        dgvkhachhang.DataSource = db
'        dgvkhachhang.DataSource = Nothing
'        LoadData()
'    End Sub

'    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
'        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
'        Dim query As String = "insert into KhachHang values(@MaKH,@TenKH,@SDT,@Email,@DiaChi)"
'        Dim save As SqlCommand = New SqlCommand(query, conn)
'        conn.Open()
'        Try
'            txtMaKH.Focus()
'            If txtMaKH.Text = "" Then
'                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'            Else
'                txtMaKH.Focus()
'                If txtTenKH.Text = "" Then
'                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                Else
'                    txtTenKH.Focus()
'                    If txtSDT.Text = "" Then
'                        MessageBox.Show("Bạn chưa nhập SDT", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                    Else
'                        txtSDT.Focus()
'                        If txtEmail.Text = "" Then
'                            MessageBox.Show("Bạn chưa nhập Email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                        Else
'                            txtEmail.Focus()
'                            If txtDiachi.Text = "" Then
'                                MessageBox.Show("Bạn chưa nhập địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
'                            Else
'                                save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
'                                save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
'                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)
'                                save.Parameters.AddWithValue("@Email", txtEmail.Text)
'                                save.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
'                                save.ExecuteNonQuery()

'                                MessageBox.Show("Lưu thành công")
'                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
'                                txtMaKH.Text = Nothing
'                                txtTenKH.Text = Nothing
'                                txtSDT.Text = Nothing
'                                txtEmail.Text = Nothing
'                                txtDiachi.Text = Nothing
'                            End If
'                        End If
'                    End If
'                End If
'            End If

'        Catch ex As Exception  'Ngược lại báo lỗi
'            MessageBox.Show("Không được trùng mã hóa đơn", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
'        End Try

'        'Làm mới lại bảng sau khi lưu thành công
'        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email', DiaChi as 'Địa chỉ' from KhachHang", conn)
'        db.Clear()
'        refesh.Fill(db)
'        dgvkhachhang.DataSource = db.DefaultView
'    End Sub

'    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
'        'Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên KH', SDT as 'SĐT', Email as 'Email',DiaChi as 'Địa Chỉ' from KhachHang", conn)

'        'conn.Open()
'        'load.Fill(db)
'        'dgvkhachhang.DataSource = db.DefaultView
'    End Sub
'End Class