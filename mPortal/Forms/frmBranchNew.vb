﻿Public Class frmBranchNew
    Private Sub frmBranchNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAComboBox(cboInstitutionIDNN, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboInstitutionIDNN.SelectedValue = institutionId
        cboInstitutionIDNN.Enabled = 0
        If UserRole = "super_user" Then
            cboInstitutionIDNN.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveInst(tlpMain, "branch", errError, sender, , txtBranchNameNN)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAllControls(tlpMain)
    End Sub

    Private Sub txtPhoneNumberNN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephoneNumber.KeyPress, txtMobileNumberNN.KeyPress
        Positive(sender, e)
    End Sub
End Class