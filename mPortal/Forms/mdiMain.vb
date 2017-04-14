Public Class mdiMain
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim frmInst As New frmInstitution
        frmInst.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click

    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        Dim frmTE As New frmTransactionEnquery
        frmTE.Show(Me)

    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        Dim frmCE As New frmCustomerEnquery
        frmCE.ShowDialog(Me)
    End Sub
End Class