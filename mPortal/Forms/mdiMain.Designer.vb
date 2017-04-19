<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCollection = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnIAdmin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnIcollectors = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCustomers = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInstitution = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnIUser = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSuperAdmin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnBranch = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 156)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BunifuImageButton1, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1203, 156)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.mPortal.My.Resources.Resources.Shutdown_64px1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1129, 61)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 8
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.Image = Global.mPortal.My.Resources.Resources.Home_64px
        Me.PictureBox1.Location = New System.Drawing.Point(363, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(411, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 162)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dashboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.8!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 162)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "mPortal 1.0.1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.659524!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.96062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.659525!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.96062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.659525!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.96062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.659525!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.96062!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.659525!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.959726!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.660241!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCollection, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIAdmin, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIcollectors, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCustomers, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuSeparator1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuCircleProgressbar1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInstitution, 7, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIUser, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSuperAdmin, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBranch, 9, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 156)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1203, 479)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'btnCollection
        '
        Me.btnCollection.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCollection.color = System.Drawing.Color.SeaGreen
        Me.btnCollection.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnCollection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCollection.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnCollection.ForeColor = System.Drawing.Color.White
        Me.btnCollection.Image = Global.mPortal.My.Resources.Resources.Money_Bag_64px
        Me.btnCollection.ImagePosition = 14
        Me.btnCollection.ImageZoom = 50
        Me.btnCollection.LabelPosition = 29
        Me.btnCollection.LabelText = "Collection"
        Me.btnCollection.Location = New System.Drawing.Point(758, 36)
        Me.btnCollection.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCollection.Name = "btnCollection"
        Me.btnCollection.Size = New System.Drawing.Size(136, 138)
        Me.btnCollection.TabIndex = 7
        '
        'btnIAdmin
        '
        Me.btnIAdmin.BackColor = System.Drawing.Color.SeaGreen
        Me.btnIAdmin.color = System.Drawing.Color.SeaGreen
        Me.btnIAdmin.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnIAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIAdmin.Enabled = False
        Me.btnIAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnIAdmin.ForeColor = System.Drawing.Color.White
        Me.btnIAdmin.Image = Global.mPortal.My.Resources.Resources.Administrator_Male_64px
        Me.btnIAdmin.ImagePosition = 14
        Me.btnIAdmin.ImageZoom = 50
        Me.btnIAdmin.LabelPosition = 29
        Me.btnIAdmin.LabelText = "Inst.. Admin"
        Me.btnIAdmin.Location = New System.Drawing.Point(83, 36)
        Me.btnIAdmin.Margin = New System.Windows.Forms.Padding(6)
        Me.btnIAdmin.Name = "btnIAdmin"
        Me.btnIAdmin.Size = New System.Drawing.Size(136, 138)
        Me.btnIAdmin.TabIndex = 5
        '
        'btnIcollectors
        '
        Me.btnIcollectors.BackColor = System.Drawing.Color.SeaGreen
        Me.btnIcollectors.color = System.Drawing.Color.SeaGreen
        Me.btnIcollectors.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnIcollectors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIcollectors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnIcollectors.Enabled = False
        Me.btnIcollectors.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnIcollectors.ForeColor = System.Drawing.Color.White
        Me.btnIcollectors.Image = Global.mPortal.My.Resources.Resources.Receive_Cash_64px
        Me.btnIcollectors.ImagePosition = 14
        Me.btnIcollectors.ImageZoom = 50
        Me.btnIcollectors.LabelPosition = 29
        Me.btnIcollectors.LabelText = "Collector"
        Me.btnIcollectors.Location = New System.Drawing.Point(533, 36)
        Me.btnIcollectors.Margin = New System.Windows.Forms.Padding(6)
        Me.btnIcollectors.Name = "btnIcollectors"
        Me.btnIcollectors.Size = New System.Drawing.Size(136, 138)
        Me.btnIcollectors.TabIndex = 3
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCustomers.color = System.Drawing.Color.SeaGreen
        Me.btnCustomers.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCustomers.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Image = Global.mPortal.My.Resources.Resources.Queue_64px
        Me.btnCustomers.ImagePosition = 14
        Me.btnCustomers.ImageZoom = 50
        Me.btnCustomers.LabelPosition = 29
        Me.btnCustomers.LabelText = "Customers"
        Me.btnCustomers.Location = New System.Drawing.Point(983, 36)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(136, 138)
        Me.btnCustomers.TabIndex = 8
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.BunifuSeparator1, 10)
        Me.BunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(81, 184)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1118, 39)
        Me.BunifuSeparator1.TabIndex = 9
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.White
        Me.BunifuCircleProgressbar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineThickness = 10
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(79, 229)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(150, 150)
        Me.BunifuCircleProgressbar1.TabIndex = 17
        Me.BunifuCircleProgressbar1.Value = 75
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel3, 11)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 459)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1203, 20)
        Me.Panel3.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1203, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Copyright © Alias Solutions, 2017"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInstitution
        '
        Me.btnInstitution.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInstitution.color = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInstitution.colorActive = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnInstitution.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInstitution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInstitution.Enabled = False
        Me.btnInstitution.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnInstitution.ForeColor = System.Drawing.Color.White
        Me.btnInstitution.Image = Global.mPortal.My.Resources.Resources.Organization_64px
        Me.btnInstitution.ImagePosition = 14
        Me.btnInstitution.ImageZoom = 50
        Me.btnInstitution.LabelPosition = 29
        Me.btnInstitution.LabelText = "Institution"
        Me.btnInstitution.Location = New System.Drawing.Point(756, 231)
        Me.btnInstitution.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInstitution.Name = "btnInstitution"
        Me.btnInstitution.Size = New System.Drawing.Size(140, 146)
        Me.btnInstitution.TabIndex = 2
        '
        'btnIUser
        '
        Me.btnIUser.BackColor = System.Drawing.Color.SeaGreen
        Me.btnIUser.color = System.Drawing.Color.SeaGreen
        Me.btnIUser.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnIUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIUser.Enabled = False
        Me.btnIUser.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnIUser.ForeColor = System.Drawing.Color.White
        Me.btnIUser.Image = Global.mPortal.My.Resources.Resources.User_Male_64px
        Me.btnIUser.ImagePosition = 14
        Me.btnIUser.ImageZoom = 50
        Me.btnIUser.LabelPosition = 29
        Me.btnIUser.LabelText = "User"
        Me.btnIUser.Location = New System.Drawing.Point(308, 36)
        Me.btnIUser.Margin = New System.Windows.Forms.Padding(6)
        Me.btnIUser.Name = "btnIUser"
        Me.btnIUser.Size = New System.Drawing.Size(136, 138)
        Me.btnIUser.TabIndex = 26
        '
        'btnSuperAdmin
        '
        Me.btnSuperAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSuperAdmin.color = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSuperAdmin.colorActive = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnSuperAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuperAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSuperAdmin.Enabled = False
        Me.btnSuperAdmin.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnSuperAdmin.ForeColor = System.Drawing.Color.White
        Me.btnSuperAdmin.Image = Global.mPortal.My.Resources.Resources.Under_Computer_64px
        Me.btnSuperAdmin.ImagePosition = 14
        Me.btnSuperAdmin.ImageZoom = 50
        Me.btnSuperAdmin.LabelPosition = 29
        Me.btnSuperAdmin.LabelText = "Super Admin"
        Me.btnSuperAdmin.Location = New System.Drawing.Point(531, 231)
        Me.btnSuperAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSuperAdmin.Name = "btnSuperAdmin"
        Me.btnSuperAdmin.Size = New System.Drawing.Size(140, 146)
        Me.btnSuperAdmin.TabIndex = 4
        '
        'btnBranch
        '
        Me.btnBranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBranch.color = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBranch.colorActive = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBranch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBranch.Enabled = False
        Me.btnBranch.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnBranch.ForeColor = System.Drawing.Color.White
        Me.btnBranch.Image = Global.mPortal.My.Resources.Resources.Branch_64px
        Me.btnBranch.ImagePosition = 14
        Me.btnBranch.ImageZoom = 50
        Me.btnBranch.LabelPosition = 29
        Me.btnBranch.LabelText = "Branch"
        Me.btnBranch.Location = New System.Drawing.Point(983, 233)
        Me.btnBranch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBranch.Name = "btnBranch"
        Me.btnBranch.Size = New System.Drawing.Size(136, 142)
        Me.btnBranch.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1203, 635)
        Me.Panel2.TabIndex = 9
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 635)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mdiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mdiMain"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInstitution As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIcollectors As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSuperAdmin As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnIAdmin As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnBranch As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCollection As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCustomers As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnIUser As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label6 As Label
End Class
