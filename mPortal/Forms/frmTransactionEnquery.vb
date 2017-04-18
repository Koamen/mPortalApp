Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Public Class frmTransactionEnquery
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
            dgvCollections.Rows.Clear()
            dgvCollector.Rows.Clear()
            txtTotal.Text = 0.00
            RefreshADgv(dgvBranch, "select id,BranchName,Address,Mobile,Telephone from branch where institution_id = " & cboInstitution.SelectedValue & " ORDER BY  BranchName")
        End If
    End Sub

    Private Sub dgvBranch_Click(sender As Object, e As EventArgs) Handles dgvBranch.Click
        If dgvBranch.Focused And dgvBranch.SelectedRows.Count = 1 Then
            RefreshADgv(dgvCollector, "SELECT id,NAME,phone,email,address,employeenumber FROM collectors where Branchid = " & dgvBranch.SelectedRows.Item(0).Cells(0).Value.ToString & " ORDER BY  NAME")
        End If
        TabControl2.SelectedIndex = 0
    End Sub
    Private Sub dgvCollector_Click(sender As Object, e As EventArgs) Handles dgvCollector.Click
        If dgvCollector.SelectedRows.Count = 1 Then
            LoadTransactions("c.collector_id = ", dgvCollector.SelectedRows.Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If cboInstitution.SelectedIndex > -1 Then
            LoadTransactions("c.institution_id = ", cboInstitution.SelectedValue)
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If dgvBranch.SelectedRows.Count = 1 Then
            LoadTransactions("c.branchid = ", dgvBranch.SelectedRows.Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If dgvCollector.SelectedRows.Count = 1 Then
            LoadTransactions("c.collector_id = ", dgvCollector.SelectedRows.Item(0).Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = True
    End Sub
    Private Sub LoadTransactions(col As String, id As Integer)
        txtTotal.Text = 0.00

        Dim S As String = dtFrom.Value.Date.ToString("yyyy-MM-dd")

        RefreshADgv(dgvCollections, "SELECT C.`date` AS `DATE`,i.name AS `INSTITUTION NAME`, b.`BranchName`  AS `BRANCH`, coltrs.`name` AS `COLLECTOR NAME`, ctmrs.`name` AS `CUSTOMER NAME`" &
                                    ", c.id AS `TRANSACTION ID`,C.`trans_type` AS `TRANSACTION TYPE`, C.`reference` AS `REFERENCE`, C.`amount` AS `AMOUNT`, C.`status` AS `TRANSACTION STATUS`" &
                                    " FROM collections c " &
                                    " INNER Join institutions i  ON c.institution_id = i.id  " &
                                    " INNER JOIN branch b ON c.`Branchid`=b.`id` " &
                                    " INNER Join collectors coltrs  ON c.`collector_id`=coltrs.`id` " &
                                    " INNER JOIN customers ctmrs  ON c.`customer_id`=ctmrs.`id` " &
                                    " WHERE " & col &
                                    id & " AND (C.`date` between  '" & dtFrom.Value.Date.ToString("yyyy-MM-dd") & "' AND '" & dtTo.Value.Date.ToString("yyyy-MM-dd") & "')  ORDER BY  `Date`")

        TabControl2.SelectedIndex = 1
        Dim total As Decimal = 0D
        If dgvCollections.Rows.Count > 0 Then
            For Each r In dgvCollections.Rows
                total += CDec(r.cells(8).value)
            Next
        End If
        txtTotal.Text = String.Format("{0:N2}", total)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        cmsExport.Show(btnExport, 0, btnExport.Height)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        cmsCustLoad.Show(btnReload, 0, btnReload.Height)
    End Sub

    Private Sub ExportToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cvs.Click
        If dgvCollections.Rows.Count > 0 Then
            Dim headers = (From header As DataGridViewColumn In dgvCollections.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In dgvCollections.Rows.Cast(Of DataGridViewRow)()
                       Where Not row.IsNewRow
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "txt files (*.txt)|*.csv"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim fileName As String = saveFileDialog1.FileName.ToString.Substring(0, saveFileDialog1.FileName.ToString.Length - 4) & " FROM " & dtFrom.Value.Date.ToString("dd-MM-yyyy") & " TO " & dtTo.Value.Date.ToString("dd-MM-yyyy") & ".txt"
                Using sw As New IO.StreamWriter(fileName)
                    sw.WriteLine(String.Join(",", headers))
                    For Each r In rows
                        sw.WriteLine(String.Join(",", r))
                    Next
                    If (sw IsNot Nothing) Then
                        sw.Close()
                    End If
                End Using
                Process.Start(fileName)
            End If
        End If
    End Sub

    Private Sub excel_Click(sender As Object, e As EventArgs) Handles excel.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Workbook
        Dim xlWorkSheet As Worksheet
        Dim misValue As Object = Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To dgvCollections.RowCount - 2
            For j = 0 To dgvCollections.ColumnCount - 1
                For k As Integer = 1 To dgvCollections.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgvCollections.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvCollections(j, i).Value.ToString()
                Next
            Next
        Next

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog1.FileName.ToString.Substring(0, saveFileDialog1.FileName.ToString.Length - 5) & " FROM " & dtFrom.Value.Date.ToString("dd-MM-yyyy") & " TO " & dtTo.Value.Date.ToString("dd-MM-yyyy") & ".xlsx"
            ' xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
            xlWorkSheet.SaveAs(fileName)
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("You can find the file " & fileName)
        End If
    End Sub
End Class