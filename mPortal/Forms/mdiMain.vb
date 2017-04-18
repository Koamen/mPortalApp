Public Class mdiMain
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles btnInstitution.Click
        Dim frmInst As New frmInstitution
        frmInst.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        frmLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles btnSuperAdmin.Click
        Dim frmIA As New frmMain
        frmIA.ShowDialog(Me)
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        Dim frmTE As New frmTransactionEnquery
        frmTE.ShowDialog(Me)
    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim frmCE As New frmCustomerEnquery
        frmCE.ShowDialog(Me)
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles btnIAdmin.Click
        Dim frmIA As New frmMain
        frmIA.Show(Me)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage1)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage3)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage4)
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles btnBranch.Click
        Dim frmB As New frmBranchNew
        frmB.ShowDialog(Me)
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles btnIcollectors.Click
        Dim frmIA As New frmMain
        frmIA.Show(Me)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage1)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage2)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage4)
    End Sub

    Private Sub BunifuTileButton8_Click(sender As Object, e As EventArgs) Handles btnIUser.Click
        Dim frmIA As New frmMain
        frmIA.Show(Me)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage1)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage2)
        frmIA.TabControl1.TabPages.Remove(frmIA.TabPage3)
    End Sub

    Private Sub mdiMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        If UserRole = "super_user" Then
            btnSuperAdmin.Enabled = True
            btnInstitution.Enabled = True
            btnBranch.Enabled = True
            btnIAdmin.Enabled = True
            btnIUser.Enabled = True
            btnIcollectors.Enabled = True
        ElseIf UserRole.ToUpper = "ADMIN" Then
            btnIAdmin.Enabled = True
            btnIUser.Enabled = True
            btnIcollectors.Enabled = True
        End If



    End Sub
End Class