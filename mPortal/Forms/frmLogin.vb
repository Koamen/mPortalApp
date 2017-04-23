Imports MySql.Data.MySqlClient

Public Class frmLogin


    Private Sub txtExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If String.IsNullOrEmpty(txtUserName.Text) Then
                showPopup(txtUserName, "Please fill in your username")
                Exit Sub
            End If

            If String.IsNullOrEmpty(txtPassword.Text) Then
                showPopup(txtPassword, "Please fill in your password")
                Exit Sub
            End If


            Dim crypt As New CustomCrypt
            Dim key As String = "123"
            Dim pass = GetMD5Hash(txtPassword.Text)
            Dim Sql As String = "SELECT  * FROM users WHERE name = '" & txtUserName.Text & "' AND password = '" & pass & "' LIMIT 0, 1"


            Using cn As New MySqlConnection(str)
                Using comm As New MySqlCommand(Sql, cn)
                    cn.Open()
                    Dim dt As New DataTable
                    Try
                        Using da As New MySqlDataAdapter(Sql, cn)
                            da.Fill(dt)
                        End Using
                    Catch ex As Exception
                        MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
                    Finally
                        cn.Close()
                    End Try

                    If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                        UserId = dt.Rows.Item(0).Item("id")
                        UserName = dt.Rows.Item(0).Item("name").ToString
                        institutionId = dt.Rows.Item(0).Item("institution_id")
                        branchId = dt.Rows.Item(0).Item("Branchid")
                        UserRole = dt.Rows.Item(0).Item("role").ToString
                        UserStatus = dt.Rows.Item(0).Item("status").ToString

                        If UserStatus = "inactive" Then
                            showPopup(txtUserName, "YOUR ACCOUNT HAS BEEN DEACTIVATED. PLEASE CONTACT THE ADMINISTRATOR.")
                            Exit Sub
                        End If

                        Dim f As New mdiMain
                        f.Show()

                        Me.Close()
                        Exit Sub
                    Else
                        MsgBox("INVALID CREDENTIALS...")
                        Exit Sub
                    End If

                End Using
            End Using

        Catch ex As Exception
            showPopup(txtUserName, ex.Message)
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Sub showPopup(ByVal control As Control, ByVal text As String)
        lblPop.Text = text
        Dim popup = New ToolStripDropDown()
        popup.Margin = Padding.Empty
        popup.Padding = Padding.Empty
        Dim host = New ToolStripControlHost(lblPop)
        host.Margin = Padding.Empty
        host.Padding = Padding.Empty
        popup.Items.Add(host)

        popup.Show(control.Parent, control.Location)
    End Sub


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPop.Visible = False
    End Sub
End Class