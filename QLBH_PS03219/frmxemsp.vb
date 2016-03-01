Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmxemsp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03219.mssql.somee.com;packet size=4096;user id=PS03219_SQLLogin_1;pwd=ecedtlonlt;data source=PS03219.mssql.somee.com;persist security info=False;initial catalog=PS03219"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai where SanPham.MaSP like'%" & txtMASP.Text & "%'", connect)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMASP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SanPham.MaSP as 'Mã SP',SanPham.TenSP as 'Tên SP', LoaiSanPham.MaLoai as 'Mã Loại',SanPham.NgaySX as 'Ngày SX',SanPham.DiaChiSX as 'Địa chỉ SX' from SanPham inner join LoaiSanPham on SanPham.MaLoai=LoaiSanPham.MaLoai", conn)
        conn.Open()
        load.Fill(db)
        dgvXemsp.DataSource = db.DefaultView
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub

    Private Sub frmxemsp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class