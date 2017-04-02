<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtExit = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcompany = New System.Windows.Forms.Label()
        Me.lbllogo = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginUserName = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtExit
        '
        Me.txtExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExit.BackColor = System.Drawing.Color.SteelBlue
        Me.txtExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtExit.Location = New System.Drawing.Point(3, 3)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Size = New System.Drawing.Size(135, 27)
        Me.txtExit.TabIndex = 123
        Me.txtExit.Text = "&Exit"
        Me.txtExit.UseVisualStyleBackColor = False
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.SteelBlue
        Me.txtLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtLogin.Location = New System.Drawing.Point(3, 3)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(164, 27)
        Me.txtLogin.TabIndex = 121
        Me.txtLogin.Text = "&Login"
        Me.txtLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblcompany)
        Me.Panel1.Controls.Add(Me.lbllogo)
        Me.Panel1.Location = New System.Drawing.Point(-87, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 10)
        Me.Panel1.TabIndex = 119
        Me.Panel1.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-184, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(400, 37)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Monday to Friday 8 am to 5 pm"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-184, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(401, 37)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Email - Info@alias-solutions.net"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(-149, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 37)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Office Line  : 0302 955790"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(-325, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblcompany
        '
        Me.lblcompany.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcompany.AutoSize = True
        Me.lblcompany.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblcompany.ForeColor = System.Drawing.Color.White
        Me.lblcompany.Location = New System.Drawing.Point(-203, -87)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(436, 74)
        Me.lblcompany.TabIndex = 6
        Me.lblcompany.Text = "No. C3/3 Kwame Nkrumah Avenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   Accra"
        '
        'lbllogo
        '
        Me.lbllogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllogo.AutoSize = True
        Me.lbllogo.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogo.ForeColor = System.Drawing.Color.White
        Me.lbllogo.Location = New System.Drawing.Point(-205, -164)
        Me.lbllogo.Name = "lbllogo"
        Me.lbllogo.Size = New System.Drawing.Size(462, 54)
        Me.lbllogo.TabIndex = 5
        Me.lbllogo.Text = "Alias Solutions Limited "
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoPictureBox.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.LogoPictureBox, 3)
        Me.LogoPictureBox.Image = Global.mPortal.My.Resources.Resources.alias_mPortal
        Me.LogoPictureBox.InitialImage = CType(resources.GetObject("LogoPictureBox.InitialImage"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(205, 43)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(171, 126)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 116
        Me.LogoPictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox1, 3)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(147, 258)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(287, 4)
        Me.TextBox1.TabIndex = 124
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtLoginPassword, 3)
        Me.txtLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtLoginPassword.Location = New System.Drawing.Point(147, 280)
        Me.txtLoginPassword.Multiline = True
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(287, 23)
        Me.txtLoginPassword.TabIndex = 125
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'txtLoginUserName
        '
        Me.txtLoginUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtLoginUserName, 3)
        Me.txtLoginUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginUserName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoginUserName.Location = New System.Drawing.Point(147, 223)
        Me.txtLoginUserName.Name = "txtLoginUserName"
        Me.txtLoginUserName.Size = New System.Drawing.Size(287, 25)
        Me.txtLoginUserName.TabIndex = 126
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Red
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox4, 3)
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(147, 309)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(287, 4)
        Me.TextBox4.TabIndex = 127
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LogoPictureBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLoginPassword, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLoginUserName, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(581, 425)
        Me.TableLayoutPanel1.TabIndex = 128
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txtExit)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(296, 346)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(138, 30)
        Me.FlowLayoutPanel1.TabIndex = 128
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.txtLogin)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(147, 346)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(138, 30)
        Me.FlowLayoutPanel2.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 20)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "User Authentication"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox2, 5)
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(575, 4)
        Me.TextBox2.TabIndex = 131
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(581, 425)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtExit As Button
    Friend WithEvents txtLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblcompany As Label
    Friend WithEvents lbllogo As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents txtLoginUserName As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
