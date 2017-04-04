Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
'**********
'Create a New user user id=Alias; password=AliasPassw0rd On the cloud 
Module mdlGlobal
    Public str As String = "server=127.0.0.1; user id=Alias; password=AliasPassw0rd; database=mcollect; pooling=false; port=3306;ConnectionTimeout=30"
    'Public User As New List(Of Array)
    Public UserId As Integer = 0
    Public UserName As String = ""
    Public institutionId As Integer = 0
    Public branchId As Integer = 0
    Public UserRole As String = ""
    Public UserStatus As String = ""

    ''Public myConn As New MySqlConnection(str)
    Private COLUMNS As String
    Private VALUES As String
    Dim ListOfFields As New List(Of Array)



#Region "Validate"
    Public Sub Positive(textControl As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                If (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
                    e.Handled = True
                    Return
                End If
            End If
        Catch ex As Exception
            MsgBox("Contact Administrator!" & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "App Error")
        End Try
    End Sub
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

    Public Function FindAlistOfThings(SQL As String) As List(Of Array)
        Dim FoundList As New List(Of Array)
        Using cn As New MySqlConnection(str)
            Using comm As New MySqlCommand(SQL, cn)
                cn.Open()
                Dim dt As New DataTable
                Try
                    Using da As New MySqlDataAdapter(SQL, cn)
                        da.Fill(dt)
                    End Using
                Catch ex As Exception
                    MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
                Finally
                    cn.Close()
                End Try

                If dt.Rows.Count > 0 Then
                    For Each row In dt.Rows
                        FoundList.Add(row.ItemArray)
                    Next
                    Return FoundList
                Else
                    Return Nothing
                End If

            End Using
        End Using
    End Function


    Public Sub ClearAllControls(tlpM As TableLayoutPanel)
        For Each control In tlpM.Controls
            If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
                control.Text = ""
            End If
            If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
                control.value = Today
            End If
            If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                control.Checked = False
            End If
            If control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
                If Not control.name.ToString.ToLower.Contains("institution") Then
                    control.SelectedIndex = -1
                End If
            End If
        Next
        For Each control In tlpM.Controls
            If control.Name.ToString.Contains("Avail") Then
                control.SelectedIndex = -1
            End If
        Next
    End Sub


    Function DupicateOnFields(field As TextBox, tablename As String) As Boolean
        Dim Duplicate As New List(Of Array)

        If field.Text <> "" Then
            Duplicate = FindAlistOfThings("SELECT *  FROM " & tablename & " WHERE " & field.Tag & " = '" & field.Text.ToString & "'")
        End If

        If Not IsNothing(Duplicate) AndAlso Duplicate.Count > 0 Then
            MsgBox("Record with a field: [" & field.Text.ToString.ToUpper & "] already exist.")
            Return 0
        End If
        Return 1
    End Function
#End Region

#Region "Saving"
    Public Sub Save(tlpMain As TableLayoutPanel, tableName As String, errError As ErrorProvider, sender As Button, txtEmailNN As TextBox, txtPasswordNN As TextBox, txtConfirmPasswordNN As TextBox, Optional field1 As Object = Nothing, Optional field2 As Object = Nothing, Optional field3 As Object = Nothing)
        Try
            errError.Clear()

            If sender.Text = "Edit" Then
                'EnableControlsForEdit()
                'sender.text = "Save"
                'Exit Sub
            End If

            COLUMNS = ""
            VALUES = ""

            Dim genParamList As New List(Of String)
            Dim genValList As New List(Of String)
            Dim genPicParamList As New List(Of String)
            Dim genPicValList As New List(Of Byte())
            Dim genNullParamList As New List(Of String)
            Dim genNullValList As New List(Of String)

            'CODE VALIDATION
            Dim valide As Boolean = True

            For Each control In tlpMain.Controls
                If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
                    If control.name.ToString.Substring(control.name.ToString.Length - 2).Equals("NN") Then

                        If control.text = "" Then
                            Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 4)
                            errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a required field.")
                            valide = False
                        End If
                    End If
                End If

                If control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
                    If control.name <> "cboPrimary" Then
                        If Not control.name.ToString.Contains("AvailData") Then
                            If control.name.ToString.Substring(control.name.ToString.Length - 2).Equals("NN") Then
                                If control.Name.ToString.Contains("Id") Then
                                    If control.SelectedIndex = -1 Then
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 4)
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a required field.")
                                        valide = False
                                    End If
                                Else
                                    If control.SelectedIndex = -1 Then
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 4)
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a required field.")
                                        valide = False
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

                ''If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                ''    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                ''        If Not control.Checked Then
                ''            errError.SetError(control, Regex.Replace(control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & " is a required field.")
                ''            valide = False
                ''        End If
                ''    End If
                ''End If

                ''If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
                ''    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                ''        If control.value >= Today Then
                ''            errError.SetError(control, Regex.Replace("Please provide a valide " & control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & "'")
                ''            valide = False
                ''        End If
                ''    End If
                ''End If

                ''If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                ''    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                ''        If Not control.Checked Then
                ''            errError.SetError(control, Regex.Replace(control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & " is a required field.")
                ''            valide = False
                ''        End If
                ''    End If
                ''End If

            Next

            If Not valide Then
                Exit Sub
            End If
            ''''EMAIL & PASSWORD VALIDATION
            Dim crypt As New CustomCrypt
            Dim key As String = "123"
            Dim Password = crypt.Encrypt(txtPasswordNN.Text, key)
            Dim CPassword = crypt.Encrypt(txtConfirmPasswordNN.Text, key)

            If Password <> CPassword Then
                valide = False
                MsgBox("SORRY PASSWORD MISMATCH...")
                Exit Sub
            End If

            Try
                Dim addr = New Net.Mail.MailAddress(txtEmailNN.Text)
            Catch
                valide = False
                MsgBox("SORRY WRONG EMAIL FORMAT...")
                Exit Sub
            End Try
            ''''END CODE


            'END CODE


            ''''CODE CHECK FOR DUPLICATION 
            Dim mainControl As New Object
            ''For Each control In tlpMain.Controls
            ''    ''If control.name.ToString <> "" Then
            ''    ''    If control.name.ToString.Substring(control.name.ToString.Length - 2) = "NN" Then
            ''    ''        If control.name.ToString.Replace("Null", "") = txtEmployeeNumberNN.Text.ToString Then
            ''    ''            mainControl = control
            ''    ''            Exit For
            ''    ''        End If
            ''    ''    Else
            ''    ''        If control.Name.ToString = cboPrimary.SelectedValue.ToString Then
            ''    ''            mainControl = control
            ''    ''            Exit For
            ''    ''        End If
            ''    ''    End If
            ''    ''End If
            ''Next

            'If sender.text = "Create" Then

            If field1 IsNot Nothing Then
                Dim dupf1 As Boolean = DupicateOnFields(field1, tableName)

                If Not dupf1 Then
                    Exit Sub
                End If
            End If

            If field2 IsNot Nothing Then
                Dim dupf2 As Boolean = DupicateOnFields(field2, tableName)

                If Not dupf2 Then
                    Exit Sub
                End If
            End If

            If field3 IsNot Nothing Then
                Dim dupf3 As Boolean = DupicateOnFields(field3, tableName)

                If Not dupf3 Then
                    Exit Sub
                End If
            End If
            'End If
            ''''END CODE

            ''''CODE PRODUCE QUERY ELEMENTS
            Dim genCol As String = ""
            Dim genParam As String = ""

            Dim genNullCol As String = ""
            Dim genNullParam As String = ""

            Dim genPicCol As String = ""
            Dim genPicParam As String = ""

            For Each control In tlpMain.Controls
                'If control.tag <> "" Then
                If control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
                    If control.name <> "cboPrimary" Then
                        If control.tag <> "" Then
                            If Not control.name.ToString.Contains("Avail") Then
                                If control.SelectedIndex <> -1 Then
                                    genCol += control.tag & ", "
                                    genParam += "@" & control.Tag & ", "
                                    genParamList.Add("@" & control.tag)
                                    If control.tag.ToString.ToLower.Contains("id") Then
                                        genValList.Add(control.selectedvalue)
                                    Else
                                        genValList.Add(control.text.trim)
                                    End If
                                Else
                                    genNullCol += control.tag & ", "
                                    genNullParam += "@" & control.Tag & ", "
                                    genNullParamList.Add("@" & control.tag)
                                    genNullValList.Add("NULL")
                                End If
                            End If
                        End If
                    End If
                End If


                If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
                    If control.tag <> "" Then
                        If control.text <> "" Then
                            genCol += control.tag & ", "
                            genParam += "@" & control.Tag & ", "
                            genParamList.Add("@" & control.tag)
                            If control.name.ToString.ToUpper.Contains("PASSWORD") Then
                                genValList.Add(Password)
                            Else
                                genValList.Add(control.text.ToString.Trim)
                            End If
                        Else
                            genNullCol += control.tag & ", "
                            genNullParam += "@" & control.Tag & ", "
                            genNullParamList.Add("@" & control.tag)
                            genNullValList.Add("NULL")
                        End If
                    End If
                End If


                If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                    If control.checked Then
                        genCol += control.tag & ", "
                        genParam += "@" & control.Tag & ", "
                        genParamList.Add("@" & control.tag)
                        genValList.Add(StrConv(control.text.ToString.Trim, VbStrConv.ProperCase))
                    Else
                        genNullCol += control.tag & ", "
                        genNullParam += "@" & control.Tag & ", "
                        genNullParamList.Add("@" & control.tag)
                        genNullValList.Add("NULL")
                    End If
                End If


                If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
                    'Provision for dtp restric
                    'If control.Value < Today Then
                    genCol += control.tag & ", "
                    genParam += "@" & control.Tag & ", "
                    genParamList.Add("@" & control.tag)
                    genValList.Add(control.value.ToString("dd/MM/yyyy"))
                    'Else
                    '    genNullCol += control.tag & ", "
                    '    genNullParam += "@" & control.Tag & ", "
                    '    genNullParamList.Add("@" & control.tag)
                    '    genNullValList.Add("NULL")
                    'End If
                End If

                ''If control.GetType.ToString = "System.Windows.Forms.PictureBox" Then
                ''    If Not IsNothing(control.Image) Then
                ''        genPicCol += control.tag & ", "
                ''        genPicParam += "@" & control.Tag & ", "
                ''        genPicParamList.Add("@" & control.tag)
                ''        Dim pxb As PictureBox = control
                ''        Dim ms As New MemoryStream()
                ''        Dim bm As Bitmap = New Bitmap(pxb.Image)
                ''        bm.Save(ms, control.Image.RawFormat)
                ''        Dim data As Byte() = ms.GetBuffer()
                ''        genPicValList.Add(data)

                ''    Else
                ''        genNullCol += control.tag & ", "
                ''        genNullParam += "@" & control.Tag & ", "
                ''        genNullParamList.Add("@" & control.tag)
                ''        genNullValList.Add("NULL")
                ''    End If

                ''End If
                'End If
            Next

            If genPicCol.Length > 0 Then
                genCol = genCol & genPicCol
                genParam = genParam & genPicParam
            End If

            If genNullCol.Length > 0 Then
                genCol = genCol & genNullCol
                genParam = genParam & genNullParam
            End If



            COLUMNS = genCol.Remove(genCol.LastIndexOf(","))
            VALUES = genParam.Remove(genParam.LastIndexOf(","))
            ''''END CODE

            ''''CODE SAVE CREATED DATA
            'If sender.Text = "Create" Then
            Dim sql As String = "INSERT INTO  " & tableName & "  (" & COLUMNS & ")   VALUES   ( " & VALUES & ")"
            Using cn As New MySqlConnection(str)
                Using cmd As New MySqlCommand(sql, cn)
                    Try
                        For i As Int16 = 0 To genParamList.Count - 1
                            Dim p As New MySqlParameter(genParamList(i), genValList(i))
                            cmd.Parameters.Add(p)
                        Next

                        If genPicCol.Length > 0 Then
                            For i As Int16 = 0 To genPicParamList.Count - 1
                                Dim p As New MySqlParameter(genPicParamList(i), genPicValList(i))
                                cmd.Parameters.Add(p)
                            Next
                        End If

                        For i As Int16 = 0 To genNullParamList.Count - 1
                            Dim p As New MySqlParameter(genNullParamList(i), DBNull.Value) 'genNullValList(i)) 
                            cmd.Parameters.Add(p)
                        Next

                        Dim count As Int16 = 0
                        cn.Open()
                        count = cmd.ExecuteNonQuery()
                        cn.Close()
                        If count > 0 Then
                            MsgBox("Record Successfully saved", vbInformation + MessageBoxButtons.OK, "Saved")
                            ''EnableAllControls()
                            ClearAllControls(tlpMain)
                        Else
                            MsgBox("Sorry, an error has occured operation cancelled.", vbCritical + MessageBoxButtons.OK, "Saving Error")
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
                    Finally
                        cn.Close()
                    End Try
                End Using
            End Using

            Exit Sub

            'End If

            ''If sender.Text = "Save" Then

            ''    Dim UpdateStatement As String = "UPDATE " & cboPrimary.SelectedValue & " SET "


            ''    For i As Int16 = 0 To genParamList.Count - 1
            ''        UpdateStatement += genParamList(i).Remove(0, 1) & " = " & genParamList(i) & ", "
            ''    Next

            ''    For i As Int16 = 0 To genPicParamList.Count - 1
            ''        UpdateStatement += genPicParamList(i).Remove(0, 1) & " = " & genPicParamList(i) & ", "
            ''    Next

            ''    For i As Int16 = 0 To genNullParamList.Count - 1
            ''        UpdateStatement += genNullParamList(i).Remove(0, 1) & " = " & genNullValList(i) & ", "
            ''    Next

            ''    Dim IdControl As New Object
            ''    For Each control In tlpMain.Controls
            ''        If control.Name.ToString.Contains("Avail") Then
            ''            IdControl = control
            ''        End If
            ''    Next

            ''    UpdateStatement = UpdateStatement.Remove(UpdateStatement.LastIndexOf(",")) & " WHERE Id = " & IdControl.SelectedValue

            ''    Dim cmd As New SqlCommand(UpdateStatement, cnn)

            ''    For i As Int16 = 0 To genParamList.Count - 1
            ''        Dim p As New SqlParameter(genParamList(i), genValList(i))
            ''        cmd.Parameters.Add(p)
            ''    Next

            ''    If genPicCol.Length > 0 Then
            ''        For i As Int16 = 0 To genPicParamList.Count - 1
            ''            Dim p As New SqlParameter(genPicParamList(i), genPicValList(i))
            ''            cmd.Parameters.Add(p)
            ''        Next
            ''    End If

            ''    For i As Int16 = 0 To genNullParamList.Count - 1
            ''        Dim p As New SqlParameter(genNullParamList(i), DBNull.Value) 'genNullValList(i)) 
            ''        cmd.Parameters.Add(p)
            ''    Next

            ''    cnn.Close()
            ''    cnn.Open()
            ''    cmd.ExecuteNonQuery()
            ''    cnn.Close()


            ''    Dim count As Int16 = 0
            ''    cnn.Open()
            ''    count = cmd.ExecuteNonQuery()
            ''    cnn.Close()
            ''    If count > 0 Then
            ''        MsgBox(cboPrimary.Text & " has been successfully updated", vbInformation + MessageBoxButtons.OK, "Saved")
            ''        For Each control In tlpMain.Controls
            ''            If control.name.ToString.Contains("Avail") Then
            ''                control.datasource = Nothing
            ''                rfsCboKeyValue(control, "SELECT  DISTINCT " & cboPrimary.SelectedValue & ", Id  FROM " & cboPrimary.SelectedValue & "  ORDER BY " & cboPrimary.SelectedValue)
            ''                Exit For
            ''            End If
            ''        Next
            ''        EnableAllControls()
            ''        ClearAllControls()
            ''    Else
            ''        MsgBox(cboPrimary.Text & " has not been upadted due to some error", vbCritical + MessageBoxButtons.OK, "Saving Error")
            ''        Exit Sub
            ''    End If

            ''    Exit Sub
            ''End If
            ''Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
        Finally
            'If Not cnn.State = ConnectionState.Closed Then
            '    cnn.Close()
            'End If

        End Try
    End Sub

    Public Sub SaveInst(tlpMain As TableLayoutPanel, tableName As String, errError As ErrorProvider, sender As Button, txtEmail As TextBox, Optional field1 As Object = Nothing, Optional field2 As Object = Nothing, Optional field3 As Object = Nothing)
        Try
            errError.Clear()

            If sender.Text = "Edit" Then
                'EnableControlsForEdit()
                'sender.text = "Save"
                'Exit Sub
            End If

            COLUMNS = ""
            VALUES = ""

            Dim genParamList As New List(Of String)
            Dim genValList As New List(Of String)
            Dim genPicParamList As New List(Of String)
            Dim genPicValList As New List(Of Byte())
            Dim genNullParamList As New List(Of String)
            Dim genNullValList As New List(Of String)

            'CODE VALIDATION
            Dim valide As Boolean = True

            For Each control In tlpMain.Controls
                If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
                    If control.name.ToString.Substring(control.name.ToString.Length - 2).Equals("NN") Then

                        If control.text = "" Then
                            Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 3)
                            errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a required field.")
                            valide = False
                        End If
                    End If
                End If

                If control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
                    If control.name <> "cboPrimary" Then
                        If Not control.name.ToString.Contains("AvailData") Then
                            If control.name.ToString.Substring(control.name.ToString.Length - 2).Equals("NN") Then
                                If control.Name.ToString.Contains("Id") Then
                                    If control.SelectedIndex = -1 Then
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 3)
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a required field.")
                                        valide = False
                                    End If
                                Else
                                    If control.SelectedIndex = -1 Then
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 3)
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a required field.")
                                        valide = False
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

                'If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                '    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                '        If Not control.Checked Then
                '            errError.SetError(control, Regex.Replace(control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & " is a required field.")
                '            valide = False
                '        End If
                '    End If
                'End If

                'If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
                '    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                '        If control.value >= Today Then
                '            errError.SetError(control, Regex.Replace("Please provide a valide " & control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & "'")
                '            valide = False
                '        End If
                '    End If
                'End If

                'If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                '    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                '        If Not control.Checked Then
                '            errError.SetError(control, Regex.Replace(control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & " is a required field.")
                '            valide = False
                '        End If
                '    End If
                'End If

            Next

            If Not valide Then
                Exit Sub
            End If
            ''''EMAIL & PASSWORD VALIDATION
            ''Dim crypt As New CustomCrypt
            ''Dim key As String = "123"
            ''Dim Password = crypt.Encrypt(txtPasswordNN.Text, key)
            ''Dim CPassword = crypt.Encrypt(txtConfirmPasswordNN.Text, key)

            ''If Password <> CPassword Then
            ''    valide = False
            ''    MsgBox("SORRY PASSWORD MISMATCH...")
            ''    Exit Sub
            ''End If

            Try
                Dim addr = New Net.Mail.MailAddress(txtEmail.Text)
            Catch
                valide = False
                MsgBox("SORRY WRONG EMAIL FORMAT...")
                Exit Sub
            End Try
            ''''END CODE


            'END CODE


            ''''CODE CHECK FOR DUPLICATION 


            'If sender.text = "Create" Then

            If field1 IsNot Nothing Then
                Dim dupf1 As Boolean = DupicateOnFields(field1, tableName)

                If Not dupf1 Then
                    Exit Sub
                End If
            End If

            If field2 IsNot Nothing Then
                Dim dupf2 As Boolean = DupicateOnFields(field2, tableName)

                If Not dupf2 Then
                    Exit Sub
                End If
            End If

            If field3 IsNot Nothing Then
                Dim dupf3 As Boolean = DupicateOnFields(field3, tableName)

                If Not dupf3 Then
                    Exit Sub
                End If
            End If
            'End If
            ''''END CODE

            ''''CODE PRODUCE QUERY ELEMENTS
            Dim genCol As String = ""
            Dim genParam As String = ""

            Dim genNullCol As String = ""
            Dim genNullParam As String = ""

            Dim genPicCol As String = ""
            Dim genPicParam As String = ""

            For Each control In tlpMain.Controls
                'If control.tag <> "" Then
                If control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
                    If control.name <> "cboPrimary" Then
                        If control.tag <> "" Then
                            If Not control.name.ToString.Contains("Avail") Then
                                If control.SelectedIndex <> -1 Then
                                    genCol += control.tag & ", "
                                    genParam += "@" & control.Tag & ", "
                                    genParamList.Add("@" & control.tag)
                                    If control.tag.ToString.ToLower.Contains("id") Then
                                        genValList.Add(control.selectedvalue)
                                    Else
                                        genValList.Add(control.text.trim)
                                    End If
                                Else
                                    genNullCol += control.tag & ", "
                                    genNullParam += "@" & control.Tag & ", "
                                    genNullParamList.Add("@" & control.tag)
                                    genNullValList.Add("NULL")
                                End If
                            End If
                        End If
                    End If
                End If


                If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
                    If control.tag <> "" Then
                        If control.text <> "" Then
                            genCol += control.tag & ", "
                            genParam += "@" & control.Tag & ", "
                            genParamList.Add("@" & control.tag)
                            genValList.Add(control.text.ToString.Trim)
                        Else
                            genNullCol += control.tag & ", "
                            genNullParam += "@" & control.Tag & ", "
                            genNullParamList.Add("@" & control.tag)
                            genNullValList.Add("NULL")
                        End If
                    End If
                End If


                If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                    If control.checked Then
                        genCol += control.tag & ", "
                        genParam += "@" & control.Tag & ", "
                        genParamList.Add("@" & control.tag)
                        genValList.Add(StrConv(control.text.ToString.Trim, VbStrConv.ProperCase))
                    Else
                        genNullCol += control.tag & ", "
                        genNullParam += "@" & control.Tag & ", "
                        genNullParamList.Add("@" & control.tag)
                        genNullValList.Add("NULL")
                    End If
                End If


                If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
                    'Provision for dtp restric
                    'If control.Value < Today Then
                    genCol += control.tag & ", "
                    genParam += "@" & control.Tag & ", "
                    genParamList.Add("@" & control.tag)
                    genValList.Add(control.value.ToString("dd/MM/yyyy"))
                    'Else
                    '    genNullCol += control.tag & ", "
                    '    genNullParam += "@" & control.Tag & ", "
                    '    genNullParamList.Add("@" & control.tag)
                    '    genNullValList.Add("NULL")
                    'End If
                End If

                ''If control.GetType.ToString = "System.Windows.Forms.PictureBox" Then
                ''    If Not IsNothing(control.Image) Then
                ''        genPicCol += control.tag & ", "
                ''        genPicParam += "@" & control.Tag & ", "
                ''        genPicParamList.Add("@" & control.tag)
                ''        Dim pxb As PictureBox = control
                ''        Dim ms As New MemoryStream()
                ''        Dim bm As Bitmap = New Bitmap(pxb.Image)
                ''        bm.Save(ms, control.Image.RawFormat)
                ''        Dim data As Byte() = ms.GetBuffer()
                ''        genPicValList.Add(data)

                ''    Else
                ''        genNullCol += control.tag & ", "
                ''        genNullParam += "@" & control.Tag & ", "
                ''        genNullParamList.Add("@" & control.tag)
                ''        genNullValList.Add("NULL")
                ''    End If

                ''End If
                'End If
            Next

            If genPicCol.Length > 0 Then
                genCol = genCol & genPicCol
                genParam = genParam & genPicParam
            End If

            If genNullCol.Length > 0 Then
                genCol = genCol & genNullCol
                genParam = genParam & genNullParam
            End If



            COLUMNS = genCol.Remove(genCol.LastIndexOf(","))
            VALUES = genParam.Remove(genParam.LastIndexOf(","))
            ''''END CODE

            ''''CODE SAVE CREATED DATA
            'If sender.Text = "Create" Then
            Dim sql As String = "INSERT INTO  " & tableName & "  (" & COLUMNS & ")   VALUES   ( " & VALUES & ")"
            Using cn As New MySqlConnection(str)
                Using cmd As New MySqlCommand(sql, cn)
                    Try
                        For i As Int16 = 0 To genParamList.Count - 1
                            Dim p As New MySqlParameter(genParamList(i), genValList(i))
                            cmd.Parameters.Add(p)
                        Next

                        If genPicCol.Length > 0 Then
                            For i As Int16 = 0 To genPicParamList.Count - 1
                                Dim p As New MySqlParameter(genPicParamList(i), genPicValList(i))
                                cmd.Parameters.Add(p)
                            Next
                        End If

                        For i As Int16 = 0 To genNullParamList.Count - 1
                            Dim p As New MySqlParameter(genNullParamList(i), DBNull.Value) 'genNullValList(i)) 
                            cmd.Parameters.Add(p)
                        Next

                        Dim count As Int16 = 0
                        cn.Open()
                        count = cmd.ExecuteNonQuery()
                        cn.Close()
                        If count > 0 Then
                            MsgBox("Record Successfully saved", vbInformation + MessageBoxButtons.OK, "Saved")
                            ''EnableAllControls()
                            ClearAllControls(tlpMain)
                        Else
                            MsgBox("Sorry, an error has occured operation cancelled.", vbCritical + MessageBoxButtons.OK, "Saving Error")
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
                    Finally
                        cn.Close()
                    End Try
                End Using
            End Using

            Exit Sub

            'End If

            ''If sender.Text = "Save" Then

            ''    Dim UpdateStatement As String = "UPDATE " & cboPrimary.SelectedValue & " SET "


            ''    For i As Int16 = 0 To genParamList.Count - 1
            ''        UpdateStatement += genParamList(i).Remove(0, 1) & " = " & genParamList(i) & ", "
            ''    Next

            ''    For i As Int16 = 0 To genPicParamList.Count - 1
            ''        UpdateStatement += genPicParamList(i).Remove(0, 1) & " = " & genPicParamList(i) & ", "
            ''    Next

            ''    For i As Int16 = 0 To genNullParamList.Count - 1
            ''        UpdateStatement += genNullParamList(i).Remove(0, 1) & " = " & genNullValList(i) & ", "
            ''    Next

            ''    Dim IdControl As New Object
            ''    For Each control In tlpMain.Controls
            ''        If control.Name.ToString.Contains("Avail") Then
            ''            IdControl = control
            ''        End If
            ''    Next

            ''    UpdateStatement = UpdateStatement.Remove(UpdateStatement.LastIndexOf(",")) & " WHERE Id = " & IdControl.SelectedValue

            ''    Dim cmd As New SqlCommand(UpdateStatement, cnn)

            ''    For i As Int16 = 0 To genParamList.Count - 1
            ''        Dim p As New SqlParameter(genParamList(i), genValList(i))
            ''        cmd.Parameters.Add(p)
            ''    Next

            ''    If genPicCol.Length > 0 Then
            ''        For i As Int16 = 0 To genPicParamList.Count - 1
            ''            Dim p As New SqlParameter(genPicParamList(i), genPicValList(i))
            ''            cmd.Parameters.Add(p)
            ''        Next
            ''    End If

            ''    For i As Int16 = 0 To genNullParamList.Count - 1
            ''        Dim p As New SqlParameter(genNullParamList(i), DBNull.Value) 'genNullValList(i)) 
            ''        cmd.Parameters.Add(p)
            ''    Next

            ''    cnn.Close()
            ''    cnn.Open()
            ''    cmd.ExecuteNonQuery()
            ''    cnn.Close()


            ''    Dim count As Int16 = 0
            ''    cnn.Open()
            ''    count = cmd.ExecuteNonQuery()
            ''    cnn.Close()
            ''    If count > 0 Then
            ''        MsgBox(cboPrimary.Text & " has been successfully updated", vbInformation + MessageBoxButtons.OK, "Saved")
            ''        For Each control In tlpMain.Controls
            ''            If control.name.ToString.Contains("Avail") Then
            ''                control.datasource = Nothing
            ''                rfsCboKeyValue(control, "SELECT  DISTINCT " & cboPrimary.SelectedValue & ", Id  FROM " & cboPrimary.SelectedValue & "  ORDER BY " & cboPrimary.SelectedValue)
            ''                Exit For
            ''            End If
            ''        Next
            ''        EnableAllControls()
            ''        ClearAllControls()
            ''    Else
            ''        MsgBox(cboPrimary.Text & " has not been upadted due to some error", vbCritical + MessageBoxButtons.OK, "Saving Error")
            ''        Exit Sub
            ''    End If

            ''    Exit Sub
            ''End If
            ''Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Contact Administrator!" & vbCrLf & "Error while connecting to SQL Server. " & vbCrLf & ex.Message & vbCrLf & ex.Source, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Server Error")
        Finally
            'If Not cnn.State = ConnectionState.Closed Then
            '    cnn.Close()
            'End If

        End Try
    End Sub

#End Region

End Module
