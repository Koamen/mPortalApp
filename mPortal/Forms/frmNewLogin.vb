Public Class frmNewLogin
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmNewLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Now.ToLongDateString
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        'Me.Close()
    End Sub
End Class