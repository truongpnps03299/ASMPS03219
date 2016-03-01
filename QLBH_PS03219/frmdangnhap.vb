Public Class frmdangnhap
    'Private Sub btndn_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
    '    If e.Control Then
    '        If e.KeyCode = Keys.Enter Then
    '            btndn_Click(sender, e)
    '        End If
    '    End If
    'End Sub
    Private Sub btndn_Click(sender As Object, e As EventArgs) Handles btndn.Click
        'Điều kiện báo lỗi
        If txtTendn.Text = "" And txtmk.Text = "" Then
            MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If txtTendn.Text = "sonhbps03219" And txtmk.Text = "123" Then
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Mở giao diện Main , đồng thời đóng giao diện đăng nhập
                frmMain.ShowDialog()
                Me.Close()

            Else

                MessageBox.Show("Nhập sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click

        Close()
    End Sub

    Private Sub frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class