<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionEnquery
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvCollector = New System.Windows.Forms.DataGridView()
        Me.CId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollectorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEmployeeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvCollections = New System.Windows.Forms.DataGridView()
        Me.tDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tInstitutionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tBranch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tCollectorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tTransactionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tTransactionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tReference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tTransactionStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvBranch = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboInstitution = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmsCustLoad = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cvs = New System.Windows.Forms.ToolStripMenuItem()
        Me.excel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvCollector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvCollections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.cmsCustLoad.SuspendLayout()
        Me.cmsExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.333333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1400, 700)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(402, 100)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(998, 555)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvCollector)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(990, 525)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Collectors"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvCollector
        '
        Me.dgvCollector.AllowUserToAddRows = False
        Me.dgvCollector.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.dgvCollector.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCollector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCollector.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CId, Me.CollectorName, Me.cPhone, Me.cEmail, Me.cAddress, Me.cEmployeeNumber})
        Me.dgvCollector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCollector.Location = New System.Drawing.Point(4, 4)
        Me.dgvCollector.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCollector.Name = "dgvCollector"
        Me.dgvCollector.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCollector.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCollector.RowHeadersWidth = 20
        Me.dgvCollector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCollector.Size = New System.Drawing.Size(982, 517)
        Me.dgvCollector.TabIndex = 4
        '
        'CId
        '
        Me.CId.HeaderText = "CId"
        Me.CId.Name = "CId"
        Me.CId.ReadOnly = True
        Me.CId.Visible = False
        '
        'CollectorName
        '
        Me.CollectorName.HeaderText = "COLLECTOR NAME"
        Me.CollectorName.Name = "CollectorName"
        Me.CollectorName.ReadOnly = True
        Me.CollectorName.Width = 300
        '
        'cPhone
        '
        Me.cPhone.HeaderText = "PHONE"
        Me.cPhone.Name = "cPhone"
        Me.cPhone.ReadOnly = True
        Me.cPhone.Width = 130
        '
        'cEmail
        '
        Me.cEmail.HeaderText = "EMAIL"
        Me.cEmail.Name = "cEmail"
        Me.cEmail.ReadOnly = True
        Me.cEmail.Width = 180
        '
        'cAddress
        '
        Me.cAddress.HeaderText = "ADDRESS"
        Me.cAddress.Name = "cAddress"
        Me.cAddress.ReadOnly = True
        Me.cAddress.Width = 220
        '
        'cEmployeeNumber
        '
        Me.cEmployeeNumber.HeaderText = "EMPLOYEE NUMBER"
        Me.cEmployeeNumber.Name = "cEmployeeNumber"
        Me.cEmployeeNumber.ReadOnly = True
        Me.cEmployeeNumber.Width = 120
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvCollections)
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(990, 525)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Transactions"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvCollections
        '
        Me.dgvCollections.AllowUserToAddRows = False
        Me.dgvCollections.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.dgvCollections.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCollections.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tDATE, Me.tInstitutionName, Me.tBranch, Me.tCollectorName, Me.tCustomerName, Me.tTransactionId, Me.tTransactionType, Me.tReference, Me.tAmount, Me.tTransactionStatus})
        Me.dgvCollections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCollections.Location = New System.Drawing.Point(4, 4)
        Me.dgvCollections.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCollections.Name = "dgvCollections"
        Me.dgvCollections.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCollections.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvCollections.RowHeadersWidth = 20
        Me.dgvCollections.Size = New System.Drawing.Size(982, 517)
        Me.dgvCollections.TabIndex = 5
        '
        'tDATE
        '
        DataGridViewCellStyle12.Format = "D"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.tDATE.DefaultCellStyle = DataGridViewCellStyle12
        Me.tDATE.HeaderText = "DATE"
        Me.tDATE.Name = "tDATE"
        Me.tDATE.ReadOnly = True
        '
        'tInstitutionName
        '
        Me.tInstitutionName.HeaderText = "INSTITUTION NAME"
        Me.tInstitutionName.Name = "tInstitutionName"
        Me.tInstitutionName.ReadOnly = True
        '
        'tBranch
        '
        Me.tBranch.HeaderText = "BRANCH"
        Me.tBranch.Name = "tBranch"
        Me.tBranch.ReadOnly = True
        '
        'tCollectorName
        '
        Me.tCollectorName.HeaderText = "COLLECTOR NAME"
        Me.tCollectorName.Name = "tCollectorName"
        Me.tCollectorName.ReadOnly = True
        '
        'tCustomerName
        '
        Me.tCustomerName.HeaderText = "CUSTOMER NAME"
        Me.tCustomerName.Name = "tCustomerName"
        Me.tCustomerName.ReadOnly = True
        '
        'tTransactionId
        '
        Me.tTransactionId.HeaderText = "TRANSACTION ID"
        Me.tTransactionId.Name = "tTransactionId"
        Me.tTransactionId.ReadOnly = True
        '
        'tTransactionType
        '
        Me.tTransactionType.HeaderText = "TRANSACTION TYPE"
        Me.tTransactionType.Name = "tTransactionType"
        Me.tTransactionType.ReadOnly = True
        '
        'tReference
        '
        Me.tReference.HeaderText = "REFERENCE"
        Me.tReference.Name = "tReference"
        Me.tReference.ReadOnly = True
        '
        'tAmount
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.tAmount.DefaultCellStyle = DataGridViewCellStyle13
        Me.tAmount.HeaderText = "AMOUNT"
        Me.tAmount.Name = "tAmount"
        Me.tAmount.ReadOnly = True
        '
        'tTransactionStatus
        '
        Me.tTransactionStatus.HeaderText = "TRANSACTION STATUS"
        Me.tTransactionStatus.Name = "tTransactionStatus"
        Me.tTransactionStatus.ReadOnly = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExit)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReload)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(406, 659)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(990, 37)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(890, 2)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 33)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(785, 2)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(99, 33)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "Export | »"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReload.Location = New System.Drawing.Point(658, 2)
        Me.btnReload.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(121, 33)
        Me.btnReload.TabIndex = 15
        Me.btnReload.Text = "Custom Load | »"
        Me.btnReload.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(452, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 31)
        Me.Panel2.TabIndex = 3
        '
        'txtTotal
        '
        Me.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(0, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(200, 30)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 31)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "TOTAL:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TableLayoutPanel1.SetRowSpan(Me.TabControl1, 2)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(402, 655)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(394, 625)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71958!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28043!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgvBranch, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cboInstitution, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.338028!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.66197!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(386, 617)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'dgvBranch
        '
        Me.dgvBranch.AllowUserToAddRows = False
        Me.dgvBranch.AllowUserToDeleteRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dgvBranch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBranch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.BranchName, Me.Address, Me.Mobile, Me.Telephone})
        Me.TableLayoutPanel2.SetColumnSpan(Me.dgvBranch, 2)
        Me.dgvBranch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBranch.Location = New System.Drawing.Point(4, 43)
        Me.dgvBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBranch.Name = "dgvBranch"
        Me.dgvBranch.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBranch.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvBranch.RowHeadersWidth = 20
        Me.dgvBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBranch.Size = New System.Drawing.Size(378, 570)
        Me.dgvBranch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Institution"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboInstitution
        '
        Me.cboInstitution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInstitution.FormattingEnabled = True
        Me.cboInstitution.Location = New System.Drawing.Point(107, 4)
        Me.cboInstitution.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInstitution.Name = "cboInstitution"
        Me.cboInstitution.Size = New System.Drawing.Size(270, 25)
        Me.cboInstitution.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(405, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 94)
        Me.Panel1.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dtTo, 5, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.dtFrom, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.02128!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.97872!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(992, 94)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'dtTo
        '
        Me.dtTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtTo.Location = New System.Drawing.Point(837, 66)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(152, 22)
        Me.dtTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(551, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FROM:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtFrom
        '
        Me.dtFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFrom.Location = New System.Drawing.Point(612, 66)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(172, 22)
        Me.dtFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(790, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TRANSACTION ENQUIRY"
        '
        'cmsCustLoad
        '
        Me.cmsCustLoad.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsCustLoad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.cmsCustLoad.Name = "cmsExport"
        Me.cmsCustLoad.Size = New System.Drawing.Size(262, 82)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(261, 26)
        Me.ToolStripMenuItem1.Text = "All Institution's Transaction"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(261, 26)
        Me.ToolStripMenuItem2.Text = "Branch's Transactions"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(261, 26)
        Me.ToolStripMenuItem3.Text = "Collector's Transactions"
        '
        'cmsExport
        '
        Me.cmsExport.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cvs, Me.excel})
        Me.cmsExport.Name = "cmsExport"
        Me.cmsExport.Size = New System.Drawing.Size(187, 56)
        '
        'cvs
        '
        Me.cvs.Name = "cvs"
        Me.cvs.Size = New System.Drawing.Size(186, 26)
        Me.cvs.Text = "Export To CSV"
        '
        'excel
        '
        Me.excel.Name = "excel"
        Me.excel.Size = New System.Drawing.Size(186, 26)
        Me.excel.Text = "Export To Excel"
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'BranchName
        '
        Me.BranchName.HeaderText = "BRANCH / KIOSK  NAME"
        Me.BranchName.Name = "BranchName"
        Me.BranchName.ReadOnly = True
        Me.BranchName.Width = 350
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Visible = False
        '
        'Mobile
        '
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        Me.Mobile.ReadOnly = True
        Me.Mobile.Visible = False
        '
        'Telephone
        '
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        Me.Telephone.Visible = False
        '
        'frmTransactionEnquery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 700)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTransactionEnquery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransactionEnquery"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvCollector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvCollections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgvBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.cmsCustLoad.ResumeLayout(False)
        Me.cmsExport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnReload As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cboInstitution As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgvBranch As DataGridView
    Friend WithEvents dgvCollector As DataGridView
    Friend WithEvents dgvCollections As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tDATE As DataGridViewTextBoxColumn
    Friend WithEvents tInstitutionName As DataGridViewTextBoxColumn
    Friend WithEvents tBranch As DataGridViewTextBoxColumn
    Friend WithEvents tCollectorName As DataGridViewTextBoxColumn
    Friend WithEvents tCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents tTransactionId As DataGridViewTextBoxColumn
    Friend WithEvents tTransactionType As DataGridViewTextBoxColumn
    Friend WithEvents tReference As DataGridViewTextBoxColumn
    Friend WithEvents tAmount As DataGridViewTextBoxColumn
    Friend WithEvents tTransactionStatus As DataGridViewTextBoxColumn
    Friend WithEvents cmsCustLoad As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents cmsExport As ContextMenuStrip
    Friend WithEvents cvs As ToolStripMenuItem
    Friend WithEvents excel As ToolStripMenuItem
    Friend WithEvents CId As DataGridViewTextBoxColumn
    Friend WithEvents CollectorName As DataGridViewTextBoxColumn
    Friend WithEvents cPhone As DataGridViewTextBoxColumn
    Friend WithEvents cEmail As DataGridViewTextBoxColumn
    Friend WithEvents cAddress As DataGridViewTextBoxColumn
    Friend WithEvents cEmployeeNumber As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents BranchName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Mobile As DataGridViewTextBoxColumn
    Friend WithEvents Telephone As DataGridViewTextBoxColumn
End Class
