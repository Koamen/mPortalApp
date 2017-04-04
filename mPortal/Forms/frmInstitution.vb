Imports System.IO

Public Class frmInstitution
    Private Sub frmInstitution_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim extns = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim ext = Path.GetExtension(OpenFileDialog1.FileName)
            If Not extns.Contains(ext.ToLower) Then
                MsgBox("Please select an image file with extension *.jpg;*.jpeg;*.png")
            Else
                txtLogoNN.Text = OpenFileDialog1.FileName.ToString
                txtLogoThumbnailNN.Text = OpenFileDialog1.FileName.ToString
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveInst(tlpMain, "institutions", errError, sender, txtEmailAddressNN, txtInstitutionNameNN)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAllControls(tlpMain)
    End Sub

    Private Sub txtPhoneNumberNN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumberNN.KeyPress
        Positive(sender, e)
    End Sub
End Class