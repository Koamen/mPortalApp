Public Class frmTransactionEnquery
    Private Sub frmTransactionEnquery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAComboBox(cboInstitution, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions WHERE id = 1 ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboInstitution.SelectedValue = 1
        cboInstitution.Enabled = 0
        RefreshADgv(dgvBranch, "select id,BranchName,Address,Mobile,Telephone from branch where institution_id = 1 ORDER BY  BranchName")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboInstitution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstitution.SelectedIndexChanged
        If cboInstitution.Focused Then
            RefreshADgv(dgvBranch, "select id,BranchName,Address,Mobile,Telephone from branch where institution_id = " & cboInstitution.SelectedItem.ToString & " ORDER BY  BranchName")
        End If
    End Sub

    Private Sub dgvBranch_Click(sender As Object, e As EventArgs) Handles dgvBranch.Click
        If dgvBranch.Focused And dgvBranch.SelectedRows.Count = 1 Then
            RefreshADgv(dgvCollector, "SELECT id,NAME,phone,email,address,employeenumber FROM collectors where Branchid = " & dgvBranch.SelectedRows.Item(0).Cells(0).Value.ToString & " ORDER BY  NAME")
        End If
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub dgvCollector_Click(sender As Object, e As EventArgs) Handles dgvCollector.Click
        txtTotal.Text = 0.00
        Dim S As String = dtFrom.Value.Date.ToString("yyyy-MM-dd")

        If dgvCollector.Focused And dgvCollector.SelectedRows.Count = 1 Then
            RefreshADgv(dgvCollections, "SELECT C.`date` AS `DATE`,i.name AS `INSTITUTION NAME`, b.`BranchName`  AS `BRANCH`, coltrs.`name` AS `COLLECTOR NAME`, ctmrs.`name` AS `CUSTOMER NAME`" &
                                        ", c.id AS `TRANSACTION ID`,C.`trans_type` AS `TRANSACTION TYPE`, C.`reference` AS `REFERENCE`, C.`amount` AS `AMOUNT`, C.`status` AS `TRANSACTION STATUS`" &
                                        " FROM collections c " &
                                        " INNER Join institutions i  ON c.institution_id = i.id  " &
                                        " INNER JOIN branch b ON c.`Branchid`=b.`id` " &
                                        " INNER Join collectors coltrs  ON c.`collector_id`=coltrs.`id` " &
                                        " INNER JOIN customers ctmrs  ON c.`customer_id`=ctmrs.`id` " &
                                        " WHERE c.collector_id = " &
                                        dgvCollector.SelectedRows.Item(0).Cells(0).Value.ToString & " AND (C.`date` between  '" & dtFrom.Value.Date.ToString("yyyy-MM-dd") & "' AND '" & dtTo.Value.Date.ToString("yyyy-MM-dd") & "')  ORDER BY  `Date`")

            TabControl2.SelectedIndex = 1
            Dim total As Decimal = 0D
            If dgvCollections.Rows.Count > 0 Then
                For Each r In dgvCollections.Rows
                    total += CDec(r.cells(8).value)
                Next
            End If
            txtTotal.Text = String.Format("{0:N2}", total)
        End If

    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = True
    End Sub


End Class