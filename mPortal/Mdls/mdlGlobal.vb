Imports MySql.Data.MySqlClient
'**********
'Create a New user user id=Alias; password=AliasPassw0rd On the cloud 
Module mdlGlobal
    Dim str As String = "server=127.0.0.1; user id=Alias; password=AliasPassw0rd; database=mcollect; pooling=false; port=3306;ConnectionTimeout=30"

    ''Public myConn As New MySqlConnection(str)
    Private COLUMNS As String
    Private VALUES As String
    Dim ListOfFields As New List(Of Array)



#Region "Validat"
    Public Sub RefreshAComboBox(cboName As ComboBox, SQL As String, DisplayMember As String, ValueMember As String)
        cboName.DataSource = Nothing
        Dim table As New DataTable()
        Using cn As New MySqlConnection(str)
            Using comm As New MySqlCommand(SQL, cn)
                Using da As New MySqlDataAdapter(comm)
                    Try
                        cn.Open()
                        da.Fill(table)
                        cboName.DataSource = New BindingSource(table, Nothing)
                    Catch ex As Exception
                        MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
                    Finally
                        cn.Close()
                    End Try
                End Using
            End Using
        End Using
        If table.Rows.Count > 0 Then
            cboName.DisplayMember = DisplayMember
            cboName.ValueMember = ValueMember
            cboName.SelectedIndex = -1
        End If
    End Sub

#End Region
End Module
