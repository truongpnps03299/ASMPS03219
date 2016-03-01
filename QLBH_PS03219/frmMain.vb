Public Class frmMain
    Private Sub btnkh_Click(sender As Object, e As EventArgs) Handles btnkh.Click
        frmkhachhang.ShowDialog()
    End Sub

    Private Sub btnsp_Click(sender As Object, e As EventArgs) Handles btnsp.Click
        frmsanpham.ShowDialog()
    End Sub


    Private Sub btnlsp_Click(sender As Object, e As EventArgs) Handles btnlsp.Click
        frmLoaisp.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmdangnhap.Hide()
    End Sub

    Private Sub btnxemsp_Click(sender As Object, e As EventArgs) Handles btnxemsp.Click
        frmxemsp.ShowDialog()
    End Sub

End Class
