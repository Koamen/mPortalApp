Public Class frmCustomerEnquery
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub frmCustomerEnquery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAComboBox(cboInstitution, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions WHERE id = 4 ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboInstitution.SelectedIndex = 0
        cboInstitution.Enabled = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class