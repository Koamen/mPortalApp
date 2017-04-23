Imports System.Data.OleDb
Imports System.IO

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

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            dgvImpCust.Rows.Clear()
            TabControl2.SelectedIndex = 2
            Dim conn As OleDbConnection
            Dim dtr As OleDbDataReader
            Dim dta As OleDbDataAdapter
            Dim cmd As OleDbCommand
            Dim dts As DataSet
            Dim excel As String
            Dim OpenFileDialog As New OpenFileDialog

            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|XLS Files (*.xls)|*xls"

            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                Dim fi As New FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName

                excel = fi.FullName
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
                dts = New DataSet
                dta.Fill(dts, "[Sheet1$]")
                conn.Close()

                'If dts.Tables(0).Rows.Count > 100 Then
                '    MsgBox("SINGLE IMPORT LIMIT IS 100 CUSTOMERS. PLEASE REDUCE THE NUMBER ")
                '    Exit Sub
                'End If

                For Each row In dts.Tables(0).Rows
                    If Not String.IsNullOrWhiteSpace(row.Item(0).ToString) Then
                        'Dim dgvTemp As New DataGridView
                        Dim dtrow As DataRow = row
                        dgvImpCust.Rows.Add(dtrow.ItemArray)
                    End If
                Next
            End If
            MsgBox("CUSTOMER IMPORT COMPLETED PLEASE VERIFY AND PROCEED TO SAVE")

        Catch ex As Exception
            MsgBox("ERROR DURING IMPORT PLEASE CHECK YOUR DATA AND TRY AGAIN. IF THE ERROR PERSISTS CALL ADMIN")
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim invalidrow As Boolean = False
            Dim Dupl As Boolean = False

            For Each r In dgvImpCust.Rows
                For Each c In r.cells
                    If c.ColumnIndex.Equals(6) OrElse c.ColumnIndex.Equals(8) OrElse c.ColumnIndex.Equals(9) OrElse c.ColumnIndex.Equals(10) OrElse c.ColumnIndex.Equals(11) Then
                    Else
                        If String.IsNullOrWhiteSpace(c.value.ToString) Then
                            invalidrow = True
                            c.Style.BackColor = Color.Red
                        End If
                    End If
                    Dim Duplicate = FindAlistOfThings("SELECT *  FROM customers WHERE account_no = '" & r.cells(13).value.ToString & "'")

                    If Not Duplicate Is Nothing Then
                        If Duplicate.Count > 0 Then
                            Dupl = True
                            r.cells(13).Style.BackColor = Color.Yellow
                        End If
                    End If
                Next
            Next

            If invalidrow Then
            MsgBox("IMPORT ABORTED BECAUSE INVALIDE FIELD(s).")
            Exit Sub
        End If
        If Dupl Then
            MsgBox("IMPORT ABORTED BECAUSE EXISTING ACCOUNT NUMBER(s) DETECTED.")
            Exit Sub
        End If

        For Each r In dgvImpCust.Rows
            Dim email = If(String.IsNullOrWhiteSpace(r.cells(6).value.ToString), "", r.cells(6).value.ToString)
            Dim gender = If(String.IsNullOrWhiteSpace(r.cells(8).value.ToString), "", r.cells(8).value.ToString)
            Dim address = If(String.IsNullOrWhiteSpace(r.cells(9).value.ToString), "", r.cells(9).value.ToString)
            Dim id_type = If(String.IsNullOrWhiteSpace(r.cells(10).value.ToString), "", r.cells(10).value.ToString)
            Dim card_no = If(String.IsNullOrWhiteSpace(r.cells(11).value.ToString), "", r.cells(11).value.ToString)

            Dim insert = RunExecuteNonQuery("INSERT INTO `customers` (`institution_id`,`Branchid`,`collector_id`,`customer_id`,`name`,`first_name`," &
              "`last_name`,`email`,`phone`,`gender`,`address`,`id_type`,`card_no`,`account_type`,`account_no`,`creator`,`creator_id`) " &
              " VALUES (" & institutionId & "," & CInt(r.cells(0).value) & "," & CInt(r.cells(1).value) & ",'" & r.cells(2).value.ToString & "','" & r.cells(3).value.ToString & "','" &
              r.cells(4).value.ToString & "','" & r.cells(5).value.ToString & "','" & email & "','" & r.cells(7).value.ToString & "','" & gender & "','" & address & "','" & id_type & "','" & card_no &
              "','" & r.cells(12).value.ToString & "','" & r.cells(13).value.ToString & "','" & UserName & "'," & UserId & ")")
        Next

        MsgBox("CUSTOMER(s) SAVED SUCCESSFULLY.")
            dgvImpCust.Rows.Clear()

            'For Each r In dgvImpCust.Rows
            '    For Each i In r.cells
            '        If Not i.ColumnIndex.Equals(11) Or i.ColumnIndex.Equals(12) Then
            '            If String.IsNullOrWhiteSpace(i.value.ToString) Then
            '                r.BackColor = Color.Aqua
            '            End If
            '        End If
            '    Next
            'Next
        Catch ex As Exception
            MsgBox("ERROR DURING IMPORT PLEASE CHECK YOUR DATA AND TRY AGAIN. IF THE ERROR PERSISTS CALL ADMIN")
        Finally
        Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class