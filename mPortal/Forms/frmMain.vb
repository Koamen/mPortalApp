Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmMain
    Private COLUMNS As String
    Private VALUES As String
    Dim ListOfFields As New List(Of Array)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RefreshAComboBox(cboInstitutionNN, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions  ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        'TabControl1.SelectedIndex = 3
        cboUserRollNN.Text = "super_user"
        RefreshAComboBox(cboIInstitutionNN, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboIInstitutionNN.SelectedValue = institutionId
        cboIInstitutionNN.Enabled = 0
        RefreshAComboBox(cboIBranchNN, "SELECT  DISTINCT(BranchName) AS BranchName, id AS BranchID FROM branch WHERE Institution_id = " & institutionId & " ORDER BY  BranchName", "BranchName", "BranchID")
        RefreshAComboBox(cboUInstitutionNN, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboUInstitutionNN.SelectedValue = institutionId
        cboUInstitutionNN.Enabled = 0
        RefreshAComboBox(cboUBranchNN, "SELECT  DISTINCT(BranchName) AS BranchName, id AS BranchID FROM branch WHERE Institution_id = " & institutionId & " ORDER BY  BranchName", "BranchName", "BranchID")
        RefreshAComboBox(cboCInstitutionNN, "SELECT  DISTINCT(name) AS InstitutionName, id AS InstitutionID FROM institutions  ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
        cboCInstitutionNN.SelectedValue = institutionId
        cboCInstitutionNN.Enabled = 0
        RefreshAComboBox(cboCBranchNN, "SELECT  DISTINCT(BranchName) AS BranchName, id AS BranchID FROM branch WHERE Institution_id = " & institutionId & " ORDER BY  BranchName", "BranchName", "BranchID")

        If UserRole = "super_user" Then
            cboIInstitutionNN.Enabled = True
            cboUInstitutionNN.Enabled = True
            cboCInstitutionNN.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnIExit.Text = "Create"
        Try
            Me.Cursor = Cursors.WaitCursor
            errError.Clear()

            If sender.text = "Edit" Then
                'EnableControlsForEdit()
                'sender.text = "Save"
                'Exit Sub
            End If
            'a

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
                            errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a requiered field.")
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
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a requiered field.")
                                        valide = False
                                    End If
                                Else
                                    If control.SelectedIndex = -1 Then
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 2).Remove(0, 3)
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a requiered field.")
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
                ''            errError.SetError(control, Regex.Replace(control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & " is a requiered field.")
                ''            valide = False
                ''        End If
                ''    End If
                ''End If

                ''''''If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
                ''''''    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                ''''''        If control.value >= Today Then
                ''''''            errError.SetError(control, Regex.Replace("Please provide a valide " & control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & "'")
                ''''''            valide = False
                ''''''        End If
                ''''''    End If
                ''''''End If

                ''If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
                ''    If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
                ''        If Not control.Checked Then
                ''            errError.SetError(control, Regex.Replace(control.name.ToString.Remove(control.name.ToString.Length - 4), "[A-Z]", " ${0}").Trim & " is a requiered field.")
                ''            valide = False
                ''        End If
                ''    End If
                ''End If

            Next

            ''''PASSWORD VALIDATION
            Dim crypt As New CustomCrypt
            Dim key As String = "123"
            Dim Password = crypt.Encrypt(txtPasswordNN.Text, key)
            Dim CPassword = crypt.Encrypt(txtConfirmPasswordNN.Text, key)

            Try
                Dim addr = New Net.Mail.MailAddress(txtEmailNN.Text)
            Catch
                valide = False
                MsgBox("SORRY WRONG EMAIL FORMAT...")
                Exit Sub
            End Try

            If Password <> CPassword Then
                valide = False
                MsgBox("SORRY PASSWORD MISMATCH...")
            End If
            ''''END CODE

            If Not valide Then
                Exit Sub
            End If

            'END CODE


            ''''CODE CHECK FOR DUPLICATION 
            Dim mainControl As New Object
            For Each control In tlpMain.Controls
                ''If control.name.ToString <> "" Then
                ''    If control.name.ToString.Substring(control.name.ToString.Length - 2) = "NN" Then
                ''        If control.name.ToString.Replace("Null", "") = txtEmployeeNumberNN.Text.ToString Then
                ''            mainControl = control
                ''            Exit For
                ''        End If
                ''    Else
                ''        If control.Name.ToString = cboPrimary.SelectedValue.ToString Then
                ''            mainControl = control
                ''            Exit For
                ''        End If
                ''    End If
                ''End If
            Next

            'If sender.text = "Create" Then
            Dim Duplicate As New List(Of Array)
            If txtEmployeeNumberNN.Text <> "" Then
                Duplicate = FindAlistOfThings("SELECT *  FROM super_users WHERE EmployeeNumber = '" & txtEmployeeNumberNN.Text.ToString & "'")
            End If

            If Not IsNothing(Duplicate) AndAlso Duplicate.Count > 0 Then
                MsgBox("Employee with the Number: [" & txtEmployeeNumberNN.Text.ToString.ToUpper & "] already exist.")
                Exit Sub
            End If

            If txtEmailNN.Text <> "" Then
                Duplicate = FindAlistOfThings("SELECT *  FROM super_users WHERE email = '" & txtEmailNN.Text.ToString & "'")
            End If

            If Not IsNothing(Duplicate) AndAlso Duplicate.Count > 0 Then
                MsgBox("User with the same email already exist.")
                Exit Sub
            End If

            If txtUserNameNN.Text <> "" Then
                Duplicate = FindAlistOfThings("SELECT *  FROM super_users WHERE name = '" & txtUserNameNN.Text.ToString & "'")
            End If

            If Not IsNothing(Duplicate) AndAlso Duplicate.Count > 0 Then
                MsgBox("User Name already exist.")
                Exit Sub
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
                                    genValList.Add(control.Text.ToString.Trim)
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
            If btnIExit.Text = "Create" Then
                Dim sql As String = "INSERT INTO super_users (" & COLUMNS & ")   VALUES   ( " & VALUES & ")"
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
                                MsgBox("User [" & txtUserNameNN.Text & "] has been successfully created", vbInformation + MessageBoxButtons.OK, "Created")
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

            End If

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
            Me.Cursor = Cursors.Default

        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAllControls(tlpMain)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnExit.Click, btnIExit.Click, btnUExit.Click, btnCExit.Click
        Me.Close()
    End Sub

    Private Sub btnISave_Click(sender As Object, e As EventArgs) Handles btnISave.Click
        Save(tlpIMain, "institution_admins", errError, sender, txtIEmailNN, txtIPasswordNN, txtIConfirmPasswordNN, txtIUserNameNN, txtIEmailNN, txtIUserNameNN)
    End Sub

    Private Sub btnUSave_Click(sender As Object, e As EventArgs) Handles btnUSave.Click
        Save(tlpUMain, "users", errError, sender, txtUEmailNN, txtUPasswordNN, txtUConfimPasswordNN, txtUEmployeeNumberNN, txtUEmailNN, txtUUserNameNN)
    End Sub

    Private Sub btnICancel_Click(sender As Object, e As EventArgs) Handles btnICancel.Click
        ClearAllControls(tlpIMain)
    End Sub

    Private Sub btnUCancel_Click(sender As Object, e As EventArgs) Handles btnUCancel.Click
        ClearAllControls(tlpUMain)
    End Sub

    Private Sub btnCSave_Click_1(sender As Object, e As EventArgs) Handles btnCSave.Click
        Save(tlpCMain, "collectors", errError, sender, txtCEmailNN, txtCPasswordNN, txtCConfirmPasswordNN, txtCEmployeeNumberNN, txtCEmailNN, txtCUserNameNN)

    End Sub

    Private Sub txtPhoneNumberNN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumberNN.KeyPress, txtIPhoneNumberNN.KeyPress, txtUPhoneNumberNN.KeyPress, txtCPhoneNumberNN.KeyPress, txtcCollectorLimitNN.KeyPress
        Positive(sender, e)
    End Sub

    Private Sub cboIInstitutionNN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIInstitutionNN.SelectedIndexChanged
        refreshBranch(cboIBranchNN, cboIInstitutionNN)
    End Sub

    Private Sub cboCInstitutionNN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCInstitutionNN.SelectedIndexChanged
        refreshBranch(cboCBranchNN, cboCInstitutionNN)
    End Sub

    Private Sub cboUInstitutionNN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUInstitutionNN.SelectedIndexChanged
        Try
            refreshBranch(cboUBranchNN, cboUInstitutionNN)
        Catch ex As Exception
            MsgBox("An error occured, please retry or contact Admin.")
        End Try
    End Sub
    Sub refreshBranch(cboB As ComboBox, cboInst As ComboBox)
        Try
            If cboInst.Focused Then
                RefreshAComboBox(cboB, "SELECT  DISTINCT(BranchName) AS BranchName, id AS BranchID FROM branch WHERE Institution_id = " & cboInst.SelectedValue & " ORDER BY  BranchName", "BranchName", "BranchID")
                If cboB.Items.Count > 0 Then
                    cboB.SelectedIndex = 0
                    Exit Sub
                End If
                cboB.DroppedDown = True
            End If
        Catch ex As Exception
            MsgBox("An error occured, please retry or contact Admin.")
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

End Class
