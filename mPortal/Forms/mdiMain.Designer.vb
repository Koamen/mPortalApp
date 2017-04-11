<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuTileButton6 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton5 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton4 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1188, 113)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 113)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.8!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 113)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "mPortal 1.0.1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(450, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dashboard"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(34, 290)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1094, 43)
        Me.BunifuSeparator1.TabIndex = 1
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuTileButton6
        '
        Me.BunifuTileButton6.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton6.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton6.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton6.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton6.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton6.Image = Global.mPortal.My.Resources.Resources.Money_Bag_64px
        Me.BunifuTileButton6.ImagePosition = 20
        Me.BunifuTileButton6.ImageZoom = 50
        Me.BunifuTileButton6.LabelPosition = 41
        Me.BunifuTileButton6.LabelText = "Collection"
        Me.BunifuTileButton6.Location = New System.Drawing.Point(945, 150)
        Me.BunifuTileButton6.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton6.Name = "BunifuTileButton6"
        Me.BunifuTileButton6.Size = New System.Drawing.Size(183, 140)
        Me.BunifuTileButton6.TabIndex = 7
        '
        'BunifuTileButton5
        '
        Me.BunifuTileButton5.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton5.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton5.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton5.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton5.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton5.Image = Global.mPortal.My.Resources.Resources.Branch_64px
        Me.BunifuTileButton5.ImagePosition = 20
        Me.BunifuTileButton5.ImageZoom = 50
        Me.BunifuTileButton5.LabelPosition = 41
        Me.BunifuTileButton5.LabelText = "Branch"
        Me.BunifuTileButton5.Location = New System.Drawing.Point(333, 150)
        Me.BunifuTileButton5.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton5.Name = "BunifuTileButton5"
        Me.BunifuTileButton5.Size = New System.Drawing.Size(183, 140)
        Me.BunifuTileButton5.TabIndex = 6
        '
        'BunifuTileButton4
        '
        Me.BunifuTileButton4.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton4.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton4.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton4.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton4.Image = Global.mPortal.My.Resources.Resources.Administrator_Male_64px
        Me.BunifuTileButton4.ImagePosition = 20
        Me.BunifuTileButton4.ImageZoom = 50
        Me.BunifuTileButton4.LabelPosition = 41
        Me.BunifuTileButton4.LabelText = "Inst.. Admin"
        Me.BunifuTileButton4.Location = New System.Drawing.Point(34, 150)
        Me.BunifuTileButton4.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton4.Name = "BunifuTileButton4"
        Me.BunifuTileButton4.Size = New System.Drawing.Size(183, 140)
        Me.BunifuTileButton4.TabIndex = 5
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton3.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = Global.mPortal.My.Resources.Resources.Under_Computer_64px
        Me.BunifuTileButton3.ImagePosition = 20
        Me.BunifuTileButton3.ImageZoom = 50
        Me.BunifuTileButton3.LabelPosition = 41
        Me.BunifuTileButton3.LabelText = "Super Admin"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(333, 571)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(183, 140)
        Me.BunifuTileButton3.TabIndex = 4
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton2.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = Global.mPortal.My.Resources.Resources.Receive_Cash_64px
        Me.BunifuTileButton2.ImagePosition = 20
        Me.BunifuTileButton2.ImageZoom = 50
        Me.BunifuTileButton2.LabelPosition = 41
        Me.BunifuTileButton2.LabelText = "Collector"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(630, 150)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(183, 140)
        Me.BunifuTileButton2.TabIndex = 3
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton1.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Global.mPortal.My.Resources.Resources.Organization_64px
        Me.BunifuTileButton1.ImagePosition = 20
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "Institution"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(34, 571)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(183, 140)
        Me.BunifuTileButton1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.mPortal.My.Resources.Resources.Shutdown_64px
        Me.PictureBox2.Location = New System.Drawing.Point(1099, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mPortal.My.Resources.Resources.Home_64px
        Me.PictureBox1.Location = New System.Drawing.Point(399, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 763)
        Me.Controls.Add(Me.BunifuTileButton6)
        Me.Controls.Add(Me.BunifuTileButton5)
        Me.Controls.Add(Me.BunifuTileButton4)
        Me.Controls.Add(Me.BunifuTileButton3)
        Me.Controls.Add(Me.BunifuTileButton2)
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mdiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mdiMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton4 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton5 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton6 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents PictureBox2 As PictureBox
End Class
