Imports System.Text.RegularExpressions

Public Class frmMain
    Private COLUMNS As String
    Private VALUES As String
    Dim ListOfFields As New List(Of Array)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshAComboBox(cboInstitutionNN, "SELECT  DISTINCT(`name`) AS InstitutionName, id AS InstitutionID FROM `institutions`  ORDER BY  InstitutionName", "InstitutionName", "InstitutionID")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Me.Cursor = Cursors.WaitCursor
            errError.Clear()

            If sender.text = "Edit" Then
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
                            Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 4).Remove(0, 3)
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
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 4).Remove(0, 3)
                                        errError.SetError(control, Regex.Replace(ctrlName, "[A-Z]", " ${0}").Trim & " is a requiered field.")
                                        valide = False
                                    End If
                                Else
                                    If control.SelectedIndex = -1 Then
                                        Dim ctrlName = control.name.ToString.Remove(control.name.ToString.Length - 4).Remove(0, 3)
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
            If Not valide Then
                Exit Sub
            End If

            'END CODE

            '''CODE CHECK FOR DUPLICATION 
            ''Dim mainControl As New Object
            ''For Each control In tlpMain.Controls
            ''    If control.name.ToString <> "" Then
            ''        If control.name.ToString.Substring(control.name.ToString.Length - 4) = "Null" Then
            ''            If control.name.ToString.Replace("Null", "") = cboPrimary.SelectedValue.ToString Then
            ''                mainControl = control
            ''                Exit For
            ''            End If
            ''        Else
            ''            If control.Name.ToString = cboPrimary.SelectedValue.ToString Then
            ''                mainControl = control
            ''                Exit For
            ''            End If
            ''        End If
            ''    End If
            ''Next

            ''If sender.text = "Create" Then
            ''    Dim Duplicate As List(Of Array)
            ''    Duplicate = FindAlistOfThings("SELECT " & cboPrimary.SelectedValue.ToString & "  FROM " & cboPrimary.SelectedValue.ToString & " WHERE " & cboPrimary.SelectedValue.ToString & "  =  '" & mainControl.Text.ToString.Trim.Replace("'", "''") & "'", "")

            ''    If Not IsNothing(Duplicate) Then
            ''        MsgBox("[" & mainControl.Text.ToString.ToUpper & "] already exist.")
            ''        cnn.Close()
            ''        Exit Sub
            ''    End If
            ''End If
            '''END CODE

            '''CODE PRODUCE QUERY ELEMENTS
            ''Dim genCol As String = ""
            ''Dim genParam As String = ""

            ''Dim genNullCol As String = ""
            ''Dim genNullParam As String = ""

            ''Dim genPicCol As String = ""
            ''Dim genPicParam As String = ""

            ''For Each control In tlpMain.Controls
            ''    'If control.tag <> "" Then
            ''    If control.GetType.ToString = "System.Windows.Forms.ComboBox" Then
            ''        If control.name <> "cboPrimary" Then
            ''            If Not control.name.ToString.Contains("Avail") Then
            ''                If control.SelectedIndex <> -1 Then
            ''                    genCol += control.tag & ", "
            ''                    genParam += "@" & control.Tag & ", "
            ''                    genParamList.Add("@" & control.tag)
            ''                    genValList.Add(UCase(control.SelectedValue.ToString.Trim))
            ''                Else
            ''                    genNullCol += control.tag & ", "
            ''                    genNullParam += "@" & control.Tag & ", "
            ''                    genNullParamList.Add("@" & control.tag)
            ''                    genNullValList.Add("NULL")
            ''                End If
            ''            End If
            ''        End If
            ''    End If


            ''    If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
            ''        If control.text <> "" Then
            ''            genCol += control.tag & ", "
            ''            genParam += "@" & control.Tag & ", "
            ''            genParamList.Add("@" & control.tag)
            ''            genValList.Add(StrConv(control.text.ToString.Trim, VbStrConv.ProperCase))
            ''        Else
            ''            genNullCol += control.tag & ", "
            ''            genNullParam += "@" & control.Tag & ", "
            ''            genNullParamList.Add("@" & control.tag)
            ''            genNullValList.Add("NULL")
            ''        End If
            ''    End If


            ''    If control.GetType.ToString = "System.Windows.Forms.CheckBox" Then
            ''        If control.checked Then
            ''            genCol += control.tag & ", "
            ''            genParam += "@" & control.Tag & ", "
            ''            genParamList.Add("@" & control.tag)
            ''            genValList.Add(StrConv(control.text.ToString.Trim, VbStrConv.ProperCase))
            ''        Else
            ''            genNullCol += control.tag & ", "
            ''            genNullParam += "@" & control.Tag & ", "
            ''            genNullParamList.Add("@" & control.tag)
            ''            genNullValList.Add("NULL")
            ''        End If
            ''    End If


            ''    If control.GetType.ToString = "System.Windows.Forms.DateTimePicker" Then
            ''        'Provision for dtp restric
            ''        'If control.Value < Today Then
            ''        genCol += control.tag & ", "
            ''        genParam += "@" & control.Tag & ", "
            ''        genParamList.Add("@" & control.tag)
            ''        genValList.Add(GetSQLDateFormat(control))
            ''        'Else
            ''        '    genNullCol += control.tag & ", "
            ''        '    genNullParam += "@" & control.Tag & ", "
            ''        '    genNullParamList.Add("@" & control.tag)
            ''        '    genNullValList.Add("NULL")
            ''        'End If
            ''    End If

            ''    If control.GetType.ToString = "System.Windows.Forms.PictureBox" Then
            ''        If Not IsNothing(control.Image) Then
            ''            genPicCol += control.tag & ", "
            ''            genPicParam += "@" & control.Tag & ", "
            ''            genPicParamList.Add("@" & control.tag)
            ''            Dim pxb As PictureBox = control
            ''            Dim ms As New MemoryStream()
            ''            Dim bm As Bitmap = New Bitmap(pxb.Image)
            ''            bm.Save(ms, control.Image.RawFormat)
            ''            Dim data As Byte() = ms.GetBuffer()
            ''            genPicValList.Add(data)

            ''        Else
            ''            genNullCol += control.tag & ", "
            ''            genNullParam += "@" & control.Tag & ", "
            ''            genNullParamList.Add("@" & control.tag)
            ''            genNullValList.Add("NULL")
            ''        End If

            ''    End If
            ''    'End If
            ''Next

            ''If genPicCol.Length > 0 Then
            ''    genCol = genCol & genPicCol
            ''    genParam = genParam & genPicParam
            ''End If

            ''If genNullCol.Length > 0 Then
            ''    genCol = genCol & genNullCol
            ''    genParam = genParam & genNullParam
            ''End If



            ''COLUMNS = genCol.Remove(genCol.LastIndexOf(","))
            ''VALUES = genParam.Remove(genParam.LastIndexOf(","))
            '''END CODE

            '''CODE SAVE CREATED DATA
            ''If sender.Text = "Create" Then
            ''    Dim sql As String = "INSERT INTO " & cboPrimary.SelectedValue & " (" & COLUMNS & ")   VALUES   ( " & VALUES & ")"
            ''    Dim cmd As New SqlCommand(sql, cnn)

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

            ''    Dim count As Int16 = 0
            ''    cnn.Open()
            ''    count = cmd.ExecuteNonQuery()
            ''    cnn.Close()
            ''    If count > 0 Then
            ''        MsgBox(cboPrimary.Text & " has been successfully created", vbInformation + MessageBoxButtons.OK, "Created")
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
            ''        MsgBox(cboPrimary.Text & " has not been created due to some error", vbCritical + MessageBoxButtons.OK, "Saving Error")
            ''        Exit Sub
            ''    End If

            ''    Exit Sub

            ''End If

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
            'Me.Cursor = Cursors.Default

        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
