Public Class frmCustomerEnquery
    Private Sub frmTransactionEnquery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAComboBox(cboInstitution, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboInstitution.SelectedValue = institutionId
        cboInstitution.Enabled = 0
        RefreshADgv(dgvBranch, "select id,BranchName,Address,Mobile,Telephone from branch where institution_id = " & institutionId & " ORDER BY  BranchName")

        If UserRole = "super_user" Then
            cboInstitution.Enabled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub cboInstitution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstitution.SelectedIndexChanged
        If cboInstitution.Focused Then
            dgvCustomers.DataSource = Nothing
            dgvCollector.Rows.Clear()
            txtTotal.Text = 0
            RefreshADgv(dgvBranch, "select id,BranchName,Address,Mobile,Telephone from branch where institution_id = " & cboInstitution.SelectedValue & " ORDER BY  BranchName")
        End If
    End Sub

    Private Sub dgvBranch_Click(sender As Object, e As EventArgs) Handles dgvBranch.Click
        If dgvBranch.Focused And dgvBranch.SelectedRows.Count = 1 Then
            RefreshADgv(dgvCollector, "SELECT id,NAME,phone,email,address,employeenumber FROM collectors where Branchid = " & dgvBranch.SelectedRows.Item(0).Cells(0).Value.ToString & " ORDER BY  NAME")
        End If
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub dgvCollector_Click(sender As Object, e As EventArgs) Handles dgvCollector.Click, ToolStripMenuItem3.Click
        If dgvCollector.SelectedRows.Count = 1 Then
            LoadCustomer("c.collector_id = ", dgvCollector.SelectedRows.Item(0).Cells(5).Value.ToString)
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If cboInstitution.SelectedIndex > -1 Then
            LoadCustomer("c.institution_id = ", cboInstitution.SelectedValue)
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If dgvBranch.SelectedRows.Count = 1 Then
            LoadCustomer("c.branchid = ", dgvBranch.SelectedRows.Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    'Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
    '    If dgvCollector.SelectedRows.Count = 1 Then
    '        LoadCustomer("c.collector_id = ", dgvCollector.SelectedRows.Item(0).Cells(5).Value.ToString)
    '    End If
    'End Sub

    Private Sub LoadCustomer(col As String, id As Integer)
        txtTotal.Text = 0.00

        Dim S As String = dtFrom.Value.Date.ToString("yyyy-MM-dd")

        RefreshCustDgv(dgvCustomers, "SELECT   DATE(C.`date_created`) AS `DATE`,i.name AS `INSTITUTION NAME`, b.`BranchName`  AS `BRANCH`, coltrs.`name` AS `COLLECTOR NAME`, c.id AS `CUSTOMER ID`, c.`name` AS `CUSTOMER FULL NAME`, c.`first_name` AS `FIRST NAME`, c.`last_name` AS `LAST NAME`,C.`email` AS `EMAIL`, C.`phone` AS `PHONE NUMBER`, C.`gender` AS `GENDER`, C.`address` AS `ADDRESS`,  c.`id_type` AS `ID TYPE`, c.`card_no` AS `ID NUMBER`," &
                                     " c.`account_type` AS `ACCOUNT TYPE`,c.`account_no` AS `ACCOUNT NUMBER`,c.`balance` AS `BALANCE`,c.`status` AS `STATUS` FROM customers c  INNER JOIN institutions i  ON c.institution_id = i.id   INNER JOIN branch b ON c.`Branchid`=b.`id`  INNER JOIN collectors coltrs  ON c.`collector_id`=coltrs.`id`  INNER JOIN customers ctmrs  ON c.`customer_id`=ctmrs.`id`  " &
                                     " WHERE " & col &
                                    id & "  ORDER BY  `CUSTOMER FULL NAME`")
        'dgvCollector.SelectedRows.Item(0).Cells(0).Value.ToString & " AND (C.`date` between  '" & dtFrom.Value.Date.ToString("yyyy-MM-dd") & "' AND '" & dtTo.Value.Date.ToString("yyyy-MM-dd") & "')  ORDER BY  `Date`")

        TabControl2.SelectedIndex = 1
        Dim total As Integer = 0
        If dgvCustomers.Rows.Count > 0 Then
            total += dgvCustomers.Rows.Count
        End If
        txtTotal.Text = total
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        cmsCustLoad.Show(btnReload, 0, btnReload.Height)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

    End Sub
End Class