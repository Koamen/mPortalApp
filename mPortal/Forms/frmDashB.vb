Public Class frmDashB
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles Me.Load, BunifuTileButton1.Click
        RefreshAttachDgv(dgvBranch, "SELECT   b.`BranchName`  AS `BRANCH`, SUM(c.amount) AS `TOTAL` " &
                                    " FROM collections c  INNER JOIN institutions i  ON c.institution_id = i.id   INNER JOIN branch b ON c.`Branchid`=b.`id`  INNER JOIN collectors coltrs  ON c.`collector_id`=coltrs.`id`  INNER JOIN customers ctmrs  ON c.`customer_id`=ctmrs.`id`   " &
                                    " WHERE c.institution_id = " & institutionId & " AND DATE(C.`date_created`)=DATE(NOW() )   " &
                                    " GROUP BY b.`BranchName` " &
                                    " ORDER BY  `BRANCH`")
        dgvBranch.Columns.Item(0).Width = 220
        dgvBranch.Columns.Item(1).Width = 120


        RefreshAttachDgv(dgvCollector, "SELECT   coltrs.`employeenumber` AS `COLLECTOR NUMBER`, coltrs.`name` AS `COLLECTOR NAME`, coltrs.`phone` AS `TELEPHONE`,coltrs.`collectorlimit` AS `COLLECTOR LIMIT`, SUM(c.amount) AS `TOTAL` " &
                                            " FROM collections c  INNER JOIN institutions i  ON c.institution_id = i.id   INNER JOIN branch b ON c.`Branchid`=b.`id`  INNER JOIN collectors coltrs  ON c.`collector_id`=coltrs.`id`  INNER JOIN customers ctmrs  ON c.`customer_id`=ctmrs.`id`   " &
                                            " WHERE c.institution_id = " & institutionId & " AND DATE(C.`date_created`)=DATE(NOW() )   " &
                                            " GROUP BY coltrs.`employeenumber`, coltrs.`name`, coltrs.`phone`,coltrs.`collectorlimit`  ORDER BY  `COLLECTOR NAME`")
        dgvCollector.Columns.Item(0).Width = 100
        dgvCollector.Columns.Item(1).Width = 300
        dgvCollector.Columns.Item(2).Width = 230
        dgvCollector.Columns.Item(3).Width = 120
        dgvCollector.Columns.Item(4).Width = 120
    End Sub
End Class