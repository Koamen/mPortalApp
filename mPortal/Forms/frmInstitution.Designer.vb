<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstitution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.txtInstitutionNameNN = New System.Windows.Forms.TextBox()
        Me.txtShortNameNN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhoneNumberNN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddressNN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLogoNN = New System.Windows.Forms.TextBox()
        Me.txtEmailAddressNN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtLogoThumbnailNN = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboStatusNN = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.errError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.errError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 4)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(703, 523)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tlpMain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(695, 494)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Institution"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 7
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpMain.Controls.Add(Me.txtInstitutionNameNN, 1, 4)
        Me.tlpMain.Controls.Add(Me.txtShortNameNN, 5, 4)
        Me.tlpMain.Controls.Add(Me.Label3, 1, 6)
        Me.tlpMain.Controls.Add(Me.Label4, 5, 6)
        Me.tlpMain.Controls.Add(Me.txtPhoneNumberNN, 1, 7)
        Me.tlpMain.Controls.Add(Me.Label5, 1, 9)
        Me.tlpMain.Controls.Add(Me.txtAddressNN, 1, 10)
        Me.tlpMain.Controls.Add(Me.Label8, 1, 12)
        Me.tlpMain.Controls.Add(Me.txtLogoNN, 1, 13)
        Me.tlpMain.Controls.Add(Me.txtEmailAddressNN, 3, 7)
        Me.tlpMain.Controls.Add(Me.Label1, 1, 3)
        Me.tlpMain.Controls.Add(Me.Label2, 5, 3)
        Me.tlpMain.Controls.Add(Me.Label6, 1, 1)
        Me.tlpMain.Controls.Add(Me.TextBox8, 0, 0)
        Me.tlpMain.Controls.Add(Me.btnBrowse, 5, 13)
        Me.tlpMain.Controls.Add(Me.FlowLayoutPanel1, 3, 15)
        Me.tlpMain.Controls.Add(Me.txtLogoThumbnailNN, 1, 15)
        Me.tlpMain.Controls.Add(Me.Label10, 5, 9)
        Me.tlpMain.Controls.Add(Me.cboStatusNN, 5, 10)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(4, 4)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 16
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(687, 486)
        Me.tlpMain.TabIndex = 18
        '
        'txtInstitutionNameNN
        '
        Me.txtInstitutionNameNN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlpMain.SetColumnSpan(Me.txtInstitutionNameNN, 3)
        Me.txtInstitutionNameNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInstitutionNameNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstitutionNameNN.Location = New System.Drawing.Point(31, 109)
        Me.txtInstitutionNameNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInstitutionNameNN.MaxLength = 250
        Me.txtInstitutionNameNN.Name = "txtInstitutionNameNN"
        Me.txtInstitutionNameNN.Size = New System.Drawing.Size(457, 30)
        Me.txtInstitutionNameNN.TabIndex = 0
        Me.txtInstitutionNameNN.Tag = "name"
        '
        'txtShortNameNN
        '
        Me.txtShortNameNN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShortNameNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtShortNameNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortNameNN.Location = New System.Drawing.Point(507, 109)
        Me.txtShortNameNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShortNameNN.MaxLength = 12
        Me.txtShortNameNN.Name = "txtShortNameNN"
        Me.txtShortNameNN.Size = New System.Drawing.Size(149, 30)
        Me.txtShortNameNN.TabIndex = 1
        Me.txtShortNameNN.Tag = "short_name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(507, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email Address"
        '
        'txtPhoneNumberNN
        '
        Me.txtPhoneNumberNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPhoneNumberNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumberNN.Location = New System.Drawing.Point(31, 193)
        Me.txtPhoneNumberNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNumberNN.MaxLength = 16
        Me.txtPhoneNumberNN.Name = "txtPhoneNumberNN"
        Me.txtPhoneNumberNN.Size = New System.Drawing.Size(300, 30)
        Me.txtPhoneNumberNN.TabIndex = 2
        Me.txtPhoneNumberNN.Tag = "phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 259)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address"
        '
        'txtAddressNN
        '
        Me.tlpMain.SetColumnSpan(Me.txtAddressNN, 3)
        Me.txtAddressNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAddressNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddressNN.Location = New System.Drawing.Point(31, 281)
        Me.txtAddressNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddressNN.MaxLength = 60
        Me.txtAddressNN.Name = "txtAddressNN"
        Me.txtAddressNN.Size = New System.Drawing.Size(457, 30)
        Me.txtAddressNN.TabIndex = 4
        Me.txtAddressNN.Tag = "address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 341)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Select Institution Logo"
        '
        'txtLogoNN
        '
        Me.tlpMain.SetColumnSpan(Me.txtLogoNN, 3)
        Me.txtLogoNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLogoNN.Enabled = False
        Me.txtLogoNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogoNN.Location = New System.Drawing.Point(31, 363)
        Me.txtLogoNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogoNN.MaxLength = 64
        Me.txtLogoNN.Name = "txtLogoNN"
        Me.txtLogoNN.Size = New System.Drawing.Size(457, 30)
        Me.txtLogoNN.TabIndex = 5
        Me.txtLogoNN.Tag = "image_url"
        '
        'txtEmailAddressNN
        '
        Me.tlpMain.SetColumnSpan(Me.txtEmailAddressNN, 3)
        Me.txtEmailAddressNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmailAddressNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddressNN.Location = New System.Drawing.Point(351, 193)
        Me.txtEmailAddressNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailAddressNN.MaxLength = 60
        Me.txtEmailAddressNN.Name = "txtEmailAddressNN"
        Me.txtEmailAddressNN.Size = New System.Drawing.Size(305, 30)
        Me.txtEmailAddressNN.TabIndex = 3
        Me.txtEmailAddressNN.Tag = "email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Institution Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(507, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Short Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Create Institution"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpMain.SetColumnSpan(Me.TextBox8, 7)
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(4, 4)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(676, 4)
        Me.TextBox8.TabIndex = 22
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(506, 361)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(150, 33)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.tlpMain.SetColumnSpan(Me.FlowLayoutPanel1, 3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(351, 426)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(305, 56)
        Me.FlowLayoutPanel1.TabIndex = 18
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 2)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 39)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(132, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 39)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(43, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 39)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtLogoThumbnailNN
        '
        Me.txtLogoThumbnailNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogoThumbnailNN.Location = New System.Drawing.Point(31, 426)
        Me.txtLogoThumbnailNN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLogoThumbnailNN.MaxLength = 64
        Me.txtLogoThumbnailNN.Name = "txtLogoThumbnailNN"
        Me.txtLogoThumbnailNN.Size = New System.Drawing.Size(300, 30)
        Me.txtLogoThumbnailNN.TabIndex = 23
        Me.txtLogoThumbnailNN.TabStop = False
        Me.txtLogoThumbnailNN.Tag = "thumbnail_url"
        Me.txtLogoThumbnailNN.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(506, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Status*"
        '
        'cboStatusNN
        '
        Me.cboStatusNN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboStatusNN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatusNN.FormattingEnabled = True
        Me.cboStatusNN.Items.AddRange(New Object() {"active", "inactive"})
        Me.cboStatusNN.Location = New System.Drawing.Point(506, 279)
        Me.cboStatusNN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboStatusNN.Name = "cboStatusNN"
        Me.cboStatusNN.Size = New System.Drawing.Size(151, 33)
        Me.cboStatusNN.TabIndex = 33
        Me.cboStatusNN.Tag = "status"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(695, 494)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Activation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'errError
        '
        Me.errError.ContainerControl = Me
        '
        'frmInstitution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 526)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInstitution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Institution"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.errError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtAddressNN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmailAddressNN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNumberNN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtInstitutionNameNN As TextBox
    Friend WithEvents TabPage2 As TabPage

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents txtShortNameNN As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents txtLogoNN As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents errError As ErrorProvider
    Friend WithEvents txtLogoThumbnailNN As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboStatusNN As ComboBox
End Class
