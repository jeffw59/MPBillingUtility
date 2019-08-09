<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ListBoxTraders = New System.Windows.Forms.ListBox()
        Me.lblSelTrader = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnServicesRefresh = New System.Windows.Forms.Button()
        Me.btnTradersRefresh = New System.Windows.Forms.Button()
        Me.lblSelService = New System.Windows.Forms.Label()
        Me.ListBoxServices = New System.Windows.Forms.ListBox()
        Me.mnuNew = New System.Windows.Forms.MenuStrip()
        Me.mnuFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBillingSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TradersListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportListsDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportListsDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewManualBillingSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampingInvoiceFileImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxTransaction = New System.Windows.Forms.GroupBox()
        Me.btnNextTrader = New System.Windows.Forms.Button()
        Me.lblTransTotal = New System.Windows.Forms.Label()
        Me.lblUnitCost = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblTrader = New System.Windows.Forms.Label()
        Me.btnAcceptTrans = New System.Windows.Forms.Button()
        Me.txtBoxTransTotal = New System.Windows.Forms.TextBox()
        Me.txtBoxTransUnitCost = New System.Windows.Forms.TextBox()
        Me.txtBoxTransQty = New System.Windows.Forms.TextBox()
        Me.txtBoxTransService = New System.Windows.Forms.TextBox()
        Me.txtBoxTransTrader = New System.Windows.Forms.TextBox()
        Me.listBoxTransList = New System.Windows.Forms.ListBox()
        Me.grpboxTransactionList = New System.Windows.Forms.GroupBox()
        Me.lblProgMon = New System.Windows.Forms.Label()
        Me.ListViewProgress = New System.Windows.Forms.ListView()
        Me.btnFinished = New System.Windows.Forms.Button()
        Me.txtboxOutputFile = New System.Windows.Forms.TextBox()
        Me.lblOutPutFile = New System.Windows.Forms.Label()
        Me.btnEmailFile = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.CampingInvoiceFileImportAdjustmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.mnuNew.SuspendLayout()
        Me.GroupBoxTransaction.SuspendLayout()
        Me.grpboxTransactionList.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxTraders
        '
        Me.ListBoxTraders.FormattingEnabled = True
        Me.ListBoxTraders.Location = New System.Drawing.Point(384, 31)
        Me.ListBoxTraders.Name = "ListBoxTraders"
        Me.ListBoxTraders.Size = New System.Drawing.Size(364, 121)
        Me.ListBoxTraders.TabIndex = 1
        '
        'lblSelTrader
        '
        Me.lblSelTrader.AutoSize = True
        Me.lblSelTrader.Location = New System.Drawing.Point(531, 11)
        Me.lblSelTrader.Name = "lblSelTrader"
        Me.lblSelTrader.Size = New System.Drawing.Size(71, 13)
        Me.lblSelTrader.TabIndex = 2
        Me.lblSelTrader.Text = "Select Trader"
        Me.lblSelTrader.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnServicesRefresh)
        Me.GroupBox1.Controls.Add(Me.btnTradersRefresh)
        Me.GroupBox1.Controls.Add(Me.lblSelService)
        Me.GroupBox1.Controls.Add(Me.ListBoxServices)
        Me.GroupBox1.Controls.Add(Me.ListBoxTraders)
        Me.GroupBox1.Controls.Add(Me.lblSelTrader)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Information"
        '
        'btnServicesRefresh
        '
        Me.btnServicesRefresh.BackColor = System.Drawing.Color.Lime
        Me.btnServicesRefresh.ForeColor = System.Drawing.Color.DarkRed
        Me.btnServicesRefresh.Location = New System.Drawing.Point(309, 31)
        Me.btnServicesRefresh.Name = "btnServicesRefresh"
        Me.btnServicesRefresh.Size = New System.Drawing.Size(60, 20)
        Me.btnServicesRefresh.TabIndex = 6
        Me.btnServicesRefresh.Tag = "Refresh"
        Me.btnServicesRefresh.Text = "Refresh"
        Me.btnServicesRefresh.UseVisualStyleBackColor = False
        Me.btnServicesRefresh.Visible = False
        '
        'btnTradersRefresh
        '
        Me.btnTradersRefresh.BackColor = System.Drawing.Color.Lime
        Me.btnTradersRefresh.ForeColor = System.Drawing.Color.DarkRed
        Me.btnTradersRefresh.Location = New System.Drawing.Point(674, 31)
        Me.btnTradersRefresh.Name = "btnTradersRefresh"
        Me.btnTradersRefresh.Size = New System.Drawing.Size(60, 20)
        Me.btnTradersRefresh.TabIndex = 5
        Me.btnTradersRefresh.Tag = "Refresh"
        Me.btnTradersRefresh.Text = "Refresh"
        Me.btnTradersRefresh.UseVisualStyleBackColor = False
        Me.btnTradersRefresh.Visible = False
        '
        'lblSelService
        '
        Me.lblSelService.AutoSize = True
        Me.lblSelService.Location = New System.Drawing.Point(163, 11)
        Me.lblSelService.Name = "lblSelService"
        Me.lblSelService.Size = New System.Drawing.Size(76, 13)
        Me.lblSelService.TabIndex = 4
        Me.lblSelService.Text = "Select Service"
        Me.lblSelService.Visible = False
        '
        'ListBoxServices
        '
        Me.ListBoxServices.FormattingEnabled = True
        Me.ListBoxServices.Location = New System.Drawing.Point(12, 31)
        Me.ListBoxServices.Name = "ListBoxServices"
        Me.ListBoxServices.Size = New System.Drawing.Size(366, 121)
        Me.ListBoxServices.TabIndex = 3
        '
        'mnuNew
        '
        Me.mnuNew.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileToolStripMenuItem, Me.BillingToolStripMenuItem, Me.mnuAboutToolStripMenuItem})
        Me.mnuNew.Location = New System.Drawing.Point(0, 0)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(1008, 24)
        Me.mnuNew.TabIndex = 4
        Me.mnuNew.Text = "New"
        '
        'mnuFileToolStripMenuItem
        '
        Me.mnuFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.mnuFileToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.mnuFileToolStripMenuItem.Name = "mnuFileToolStripMenuItem"
        Me.mnuFileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.mnuFileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBillingSessionToolStripMenuItem})
        Me.NewToolStripMenuItem.Enabled = False
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'NewBillingSessionToolStripMenuItem
        '
        Me.NewBillingSessionToolStripMenuItem.Enabled = False
        Me.NewBillingSessionToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.NewBillingSessionToolStripMenuItem.Name = "NewBillingSessionToolStripMenuItem"
        Me.NewBillingSessionToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NewBillingSessionToolStripMenuItem.Text = "New Billing Session"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TradersListToolStripMenuItem, Me.ServicesListToolStripMenuItem})
        Me.UpdateToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UpdateToolStripMenuItem.Text = "Update Lists"
        '
        'TradersListToolStripMenuItem
        '
        Me.TradersListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.TradersListToolStripMenuItem.Name = "TradersListToolStripMenuItem"
        Me.TradersListToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.TradersListToolStripMenuItem.Text = "Traders List"
        '
        'ServicesListToolStripMenuItem
        '
        Me.ServicesListToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ServicesListToolStripMenuItem.Name = "ServicesListToolStripMenuItem"
        Me.ServicesListToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ServicesListToolStripMenuItem.Text = "Services List"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportListsDataToolStripMenuItem, Me.ImportListsDataToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem1.Text = "Bulk List Operations"
        '
        'ExportListsDataToolStripMenuItem
        '
        Me.ExportListsDataToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ExportListsDataToolStripMenuItem.Name = "ExportListsDataToolStripMenuItem"
        Me.ExportListsDataToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExportListsDataToolStripMenuItem.Text = "Export Lists Data"
        '
        'ImportListsDataToolStripMenuItem
        '
        Me.ImportListsDataToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ImportListsDataToolStripMenuItem.Name = "ImportListsDataToolStripMenuItem"
        Me.ImportListsDataToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ImportListsDataToolStripMenuItem.Text = "Import Lists Data"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewManualBillingSessionToolStripMenuItem, Me.CampingInvoiceFileImportToolStripMenuItem, Me.CampingInvoiceFileImportAdjustmentToolStripMenuItem})
        Me.BillingToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'NewManualBillingSessionToolStripMenuItem
        '
        Me.NewManualBillingSessionToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.NewManualBillingSessionToolStripMenuItem.Name = "NewManualBillingSessionToolStripMenuItem"
        Me.NewManualBillingSessionToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.NewManualBillingSessionToolStripMenuItem.Text = "New Manual Billing Session"
        '
        'CampingInvoiceFileImportToolStripMenuItem
        '
        Me.CampingInvoiceFileImportToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CampingInvoiceFileImportToolStripMenuItem.Name = "CampingInvoiceFileImportToolStripMenuItem"
        Me.CampingInvoiceFileImportToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.CampingInvoiceFileImportToolStripMenuItem.Text = "Camping Invoice File Import New"
        '
        'mnuAboutToolStripMenuItem
        '
        Me.mnuAboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuAboutToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.mnuAboutToolStripMenuItem.Name = "mnuAboutToolStripMenuItem"
        Me.mnuAboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.mnuAboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GroupBoxTransaction
        '
        Me.GroupBoxTransaction.Controls.Add(Me.btnNextTrader)
        Me.GroupBoxTransaction.Controls.Add(Me.lblTransTotal)
        Me.GroupBoxTransaction.Controls.Add(Me.lblUnitCost)
        Me.GroupBoxTransaction.Controls.Add(Me.lblQty)
        Me.GroupBoxTransaction.Controls.Add(Me.lblService)
        Me.GroupBoxTransaction.Controls.Add(Me.lblTrader)
        Me.GroupBoxTransaction.Controls.Add(Me.btnAcceptTrans)
        Me.GroupBoxTransaction.Controls.Add(Me.txtBoxTransTotal)
        Me.GroupBoxTransaction.Controls.Add(Me.txtBoxTransUnitCost)
        Me.GroupBoxTransaction.Controls.Add(Me.txtBoxTransQty)
        Me.GroupBoxTransaction.Controls.Add(Me.txtBoxTransService)
        Me.GroupBoxTransaction.Controls.Add(Me.txtBoxTransTrader)
        Me.GroupBoxTransaction.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxTransaction.Location = New System.Drawing.Point(12, 191)
        Me.GroupBoxTransaction.Name = "GroupBoxTransaction"
        Me.GroupBoxTransaction.Size = New System.Drawing.Size(991, 89)
        Me.GroupBoxTransaction.TabIndex = 6
        Me.GroupBoxTransaction.TabStop = False
        Me.GroupBoxTransaction.Text = "Transaction Build"
        '
        'btnNextTrader
        '
        Me.btnNextTrader.Enabled = False
        Me.btnNextTrader.Location = New System.Drawing.Point(16, 60)
        Me.btnNextTrader.Name = "btnNextTrader"
        Me.btnNextTrader.Size = New System.Drawing.Size(112, 23)
        Me.btnNextTrader.TabIndex = 11
        Me.btnNextTrader.Text = "Next Trader"
        Me.btnNextTrader.UseVisualStyleBackColor = True
        '
        'lblTransTotal
        '
        Me.lblTransTotal.AutoSize = True
        Me.lblTransTotal.Location = New System.Drawing.Point(291, 24)
        Me.lblTransTotal.Name = "lblTransTotal"
        Me.lblTransTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTransTotal.TabIndex = 10
        Me.lblTransTotal.Text = "Total"
        '
        'lblUnitCost
        '
        Me.lblUnitCost.AutoSize = True
        Me.lblUnitCost.Location = New System.Drawing.Point(209, 24)
        Me.lblUnitCost.Name = "lblUnitCost"
        Me.lblUnitCost.Size = New System.Drawing.Size(50, 13)
        Me.lblUnitCost.TabIndex = 9
        Me.lblUnitCost.Text = "Unit Cost"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(149, 24)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(23, 13)
        Me.lblQty.TabIndex = 8
        Me.lblQty.Text = "Qty"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(461, 24)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(43, 13)
        Me.lblService.TabIndex = 7
        Me.lblService.Text = "Service"
        '
        'lblTrader
        '
        Me.lblTrader.AutoSize = True
        Me.lblTrader.Location = New System.Drawing.Point(700, 24)
        Me.lblTrader.Name = "lblTrader"
        Me.lblTrader.Size = New System.Drawing.Size(38, 13)
        Me.lblTrader.TabIndex = 6
        Me.lblTrader.Text = "Trader"
        '
        'btnAcceptTrans
        '
        Me.btnAcceptTrans.Enabled = False
        Me.btnAcceptTrans.Location = New System.Drawing.Point(16, 18)
        Me.btnAcceptTrans.Name = "btnAcceptTrans"
        Me.btnAcceptTrans.Size = New System.Drawing.Size(112, 24)
        Me.btnAcceptTrans.TabIndex = 5
        Me.btnAcceptTrans.Text = "Accept"
        Me.btnAcceptTrans.UseVisualStyleBackColor = True
        '
        'txtBoxTransTotal
        '
        Me.txtBoxTransTotal.Enabled = False
        Me.txtBoxTransTotal.Location = New System.Drawing.Point(273, 40)
        Me.txtBoxTransTotal.Name = "txtBoxTransTotal"
        Me.txtBoxTransTotal.Size = New System.Drawing.Size(68, 20)
        Me.txtBoxTransTotal.TabIndex = 4
        '
        'txtBoxTransUnitCost
        '
        Me.txtBoxTransUnitCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoxTransUnitCost.Enabled = False
        Me.txtBoxTransUnitCost.Location = New System.Drawing.Point(203, 40)
        Me.txtBoxTransUnitCost.Name = "txtBoxTransUnitCost"
        Me.txtBoxTransUnitCost.Size = New System.Drawing.Size(64, 20)
        Me.txtBoxTransUnitCost.TabIndex = 3
        '
        'txtBoxTransQty
        '
        Me.txtBoxTransQty.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoxTransQty.Enabled = False
        Me.txtBoxTransQty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBoxTransQty.Location = New System.Drawing.Point(134, 40)
        Me.txtBoxTransQty.Name = "txtBoxTransQty"
        Me.txtBoxTransQty.Size = New System.Drawing.Size(55, 20)
        Me.txtBoxTransQty.TabIndex = 2
        '
        'txtBoxTransService
        '
        Me.txtBoxTransService.Enabled = False
        Me.txtBoxTransService.Location = New System.Drawing.Point(347, 40)
        Me.txtBoxTransService.Name = "txtBoxTransService"
        Me.txtBoxTransService.Size = New System.Drawing.Size(310, 20)
        Me.txtBoxTransService.TabIndex = 1
        '
        'txtBoxTransTrader
        '
        Me.txtBoxTransTrader.Enabled = False
        Me.txtBoxTransTrader.Location = New System.Drawing.Point(674, 40)
        Me.txtBoxTransTrader.Name = "txtBoxTransTrader"
        Me.txtBoxTransTrader.Size = New System.Drawing.Size(310, 20)
        Me.txtBoxTransTrader.TabIndex = 0
        '
        'listBoxTransList
        '
        Me.listBoxTransList.FormattingEnabled = True
        Me.listBoxTransList.Location = New System.Drawing.Point(7, 19)
        Me.listBoxTransList.Name = "listBoxTransList"
        Me.listBoxTransList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listBoxTransList.Size = New System.Drawing.Size(640, 121)
        Me.listBoxTransList.TabIndex = 7
        '
        'grpboxTransactionList
        '
        Me.grpboxTransactionList.Controls.Add(Me.listBoxTransList)
        Me.grpboxTransactionList.ForeColor = System.Drawing.Color.Maroon
        Me.grpboxTransactionList.Location = New System.Drawing.Point(12, 286)
        Me.grpboxTransactionList.Name = "grpboxTransactionList"
        Me.grpboxTransactionList.Size = New System.Drawing.Size(657, 153)
        Me.grpboxTransactionList.TabIndex = 8
        Me.grpboxTransactionList.TabStop = False
        Me.grpboxTransactionList.Text = "Transaction List"
        '
        'lblProgMon
        '
        Me.lblProgMon.AutoSize = True
        Me.lblProgMon.Location = New System.Drawing.Point(435, 27)
        Me.lblProgMon.Name = "lblProgMon"
        Me.lblProgMon.Size = New System.Drawing.Size(86, 13)
        Me.lblProgMon.TabIndex = 9
        Me.lblProgMon.Text = "Progress Monitor"
        Me.lblProgMon.Visible = False
        '
        'ListViewProgress
        '
        Me.ListViewProgress.BackColor = System.Drawing.Color.OldLace
        Me.ListViewProgress.ForeColor = System.Drawing.Color.MediumBlue
        Me.ListViewProgress.GridLines = True
        Me.ListViewProgress.Location = New System.Drawing.Point(686, 286)
        Me.ListViewProgress.MultiSelect = False
        Me.ListViewProgress.Name = "ListViewProgress"
        Me.ListViewProgress.Size = New System.Drawing.Size(310, 153)
        Me.ListViewProgress.TabIndex = 10
        Me.ListViewProgress.UseCompatibleStateImageBehavior = False
        Me.ListViewProgress.View = System.Windows.Forms.View.Details
        Me.ListViewProgress.Visible = False
        '
        'btnFinished
        '
        Me.btnFinished.Enabled = False
        Me.btnFinished.Location = New System.Drawing.Point(7, 26)
        Me.btnFinished.Name = "btnFinished"
        Me.btnFinished.Size = New System.Drawing.Size(105, 23)
        Me.btnFinished.TabIndex = 11
        Me.btnFinished.Text = "Finished"
        Me.btnFinished.UseVisualStyleBackColor = True
        '
        'txtboxOutputFile
        '
        Me.txtboxOutputFile.Location = New System.Drawing.Point(131, 29)
        Me.txtboxOutputFile.Name = "txtboxOutputFile"
        Me.txtboxOutputFile.Size = New System.Drawing.Size(409, 20)
        Me.txtboxOutputFile.TabIndex = 12
        Me.txtboxOutputFile.Visible = False
        '
        'lblOutPutFile
        '
        Me.lblOutPutFile.AutoSize = True
        Me.lblOutPutFile.Location = New System.Drawing.Point(128, 13)
        Me.lblOutPutFile.Name = "lblOutPutFile"
        Me.lblOutPutFile.Size = New System.Drawing.Size(58, 13)
        Me.lblOutPutFile.TabIndex = 13
        Me.lblOutPutFile.Text = "Output File"
        Me.lblOutPutFile.Visible = False
        '
        'btnEmailFile
        '
        Me.btnEmailFile.Enabled = False
        Me.btnEmailFile.Location = New System.Drawing.Point(546, 26)
        Me.btnEmailFile.Name = "btnEmailFile"
        Me.btnEmailFile.Size = New System.Drawing.Size(74, 22)
        Me.btnEmailFile.TabIndex = 14
        Me.btnEmailFile.Text = "Email File"
        Me.btnEmailFile.UseVisualStyleBackColor = True
        Me.btnEmailFile.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEmailFile)
        Me.GroupBox3.Controls.Add(Me.btnFinished)
        Me.GroupBox3.Controls.Add(Me.lblOutPutFile)
        Me.GroupBox3.Controls.Add(Me.txtboxOutputFile)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(12, 460)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 66)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output Debtors Upload File"
        '
        'picBox1
        '
        Me.picBox1.BackColor = System.Drawing.Color.Transparent
        Me.picBox1.BackgroundImage = Global.MPBilling.My.Resources.Resources.CoffeePic4
        Me.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBox1.Location = New System.Drawing.Point(917, 489)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(79, 65)
        Me.picBox1.TabIndex = 16
        Me.picBox1.TabStop = False
        '
        'CampingInvoiceFileImportAdjustmentToolStripMenuItem
        '
        Me.CampingInvoiceFileImportAdjustmentToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon
        Me.CampingInvoiceFileImportAdjustmentToolStripMenuItem.Name = "CampingInvoiceFileImportAdjustmentToolStripMenuItem"
        Me.CampingInvoiceFileImportAdjustmentToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.CampingInvoiceFileImportAdjustmentToolStripMenuItem.Text = "Camping Invoice File Import Adjustment"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 564)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.lblProgMon)
        Me.Controls.Add(Me.grpboxTransactionList)
        Me.Controls.Add(Me.ListViewProgress)
        Me.Controls.Add(Me.GroupBoxTransaction)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuNew)
        Me.Controls.Add(Me.GroupBox3)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuNew
        Me.Name = "frmMain"
        Me.Text = "MP Billing - Transaction Builder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnuNew.ResumeLayout(False)
        Me.mnuNew.PerformLayout()
        Me.GroupBoxTransaction.ResumeLayout(False)
        Me.GroupBoxTransaction.PerformLayout()
        Me.grpboxTransactionList.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxTraders As System.Windows.Forms.ListBox
    Friend WithEvents lblSelTrader As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mnuNew As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBoxServices As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxTransaction As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxTransUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTransQty As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTransService As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTransTrader As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTransTotal As System.Windows.Forms.TextBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTransTotal As System.Windows.Forms.Label
    Friend WithEvents lblUnitCost As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblService As System.Windows.Forms.Label
    Friend WithEvents lblTrader As System.Windows.Forms.Label
    Friend WithEvents btnAcceptTrans As System.Windows.Forms.Button
    Friend WithEvents listBoxTransList As System.Windows.Forms.ListBox
    Friend WithEvents grpboxTransactionList As System.Windows.Forms.GroupBox
    Friend WithEvents btnNextTrader As System.Windows.Forms.Button
    Friend WithEvents lblProgMon As System.Windows.Forms.Label
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBillingSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListViewProgress As System.Windows.Forms.ListView
    Friend WithEvents lblSelService As System.Windows.Forms.Label
    Friend WithEvents btnFinished As System.Windows.Forms.Button
    Friend WithEvents txtboxOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents lblOutPutFile As System.Windows.Forms.Label
    Friend WithEvents btnEmailFile As System.Windows.Forms.Button
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TradersListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnServicesRefresh As System.Windows.Forms.Button
    Friend WithEvents btnTradersRefresh As System.Windows.Forms.Button
    Friend WithEvents picBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportListsDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportListsDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewManualBillingSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampingInvoiceFileImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampingInvoiceFileImportAdjustmentToolStripMenuItem As ToolStripMenuItem
End Class
