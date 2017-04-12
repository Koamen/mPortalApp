Public Class frmTransactionEnquery
    Private Sub frmTransactionEnquery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAComboBox(cboInstitution, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions WHERE id = 4 ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboInstitution.SelectedIndex = 0
        cboInstitution.Enabled = 0
    End Sub
End Class