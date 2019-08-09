<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxDebtorType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxOutFileNameStub = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBoxSpecificTraderTransaction = New System.Windows.Forms.TextBox()
        Me.lblDateConfirm = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoxRentSuffix = New System.Windows.Forms.TextBox()
        Me.lblRentSuffix = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBoxCampingDeposit = New System.Windows.Forms.TextBox()
        Me.txtBoxCampingIncome = New System.Windows.Forms.TextBox()
        Me.txtBoxInvLeadText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxCampingDebtorType = New System.Windows.Forms.TextBox()
        Me.txtBoxCampingGST = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBoxWithdrawLeadText = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Session Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(82, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(382, 453)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(68, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Debtor Type"
        '
        'txtBoxDebtorType
        '
        Me.txtBoxDebtorType.Location = New System.Drawing.Point(147, 28)
        Me.txtBoxDebtorType.Name = "txtBoxDebtorType"
        Me.txtBoxDebtorType.Size = New System.Drawing.Size(79, 20)
        Me.txtBoxDebtorType.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User Name"
        '
        'txtBoxUserName
        '
        Me.txtBoxUserName.Location = New System.Drawing.Point(146, 48)
        Me.txtBoxUserName.Name = "txtBoxUserName"
        Me.txtBoxUserName.Size = New System.Drawing.Size(161, 20)
        Me.txtBoxUserName.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Output File Name Stub"
        '
        'txtBoxOutFileNameStub
        '
        Me.txtBoxOutFileNameStub.Location = New System.Drawing.Point(146, 100)
        Me.txtBoxOutFileNameStub.Name = "txtBoxOutFileNameStub"
        Me.txtBoxOutFileNameStub.Size = New System.Drawing.Size(161, 20)
        Me.txtBoxOutFileNameStub.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Specified Transaction"
        '
        'txtBoxSpecificTraderTransaction
        '
        Me.txtBoxSpecificTraderTransaction.Location = New System.Drawing.Point(147, 54)
        Me.txtBoxSpecificTraderTransaction.Name = "txtBoxSpecificTraderTransaction"
        Me.txtBoxSpecificTraderTransaction.Size = New System.Drawing.Size(160, 20)
        Me.txtBoxSpecificTraderTransaction.TabIndex = 14
        '
        'lblDateConfirm
        '
        Me.lblDateConfirm.AutoSize = True
        Me.lblDateConfirm.Location = New System.Drawing.Point(290, 24)
        Me.lblDateConfirm.Name = "lblDateConfirm"
        Me.lblDateConfirm.Size = New System.Drawing.Size(68, 13)
        Me.lblDateConfirm.TabIndex = 15
        Me.lblDateConfirm.Text = "Date Confirm"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoxRentSuffix)
        Me.GroupBox1.Controls.Add(Me.lblRentSuffix)
        Me.GroupBox1.Controls.Add(Me.lblDateConfirm)
        Me.GroupBox1.Controls.Add(Me.txtBoxOutFileNameStub)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBoxUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 129)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Session Settings"
        '
        'txtBoxRentSuffix
        '
        Me.txtBoxRentSuffix.Location = New System.Drawing.Point(146, 74)
        Me.txtBoxRentSuffix.Name = "txtBoxRentSuffix"
        Me.txtBoxRentSuffix.Size = New System.Drawing.Size(161, 20)
        Me.txtBoxRentSuffix.TabIndex = 17
        '
        'lblRentSuffix
        '
        Me.lblRentSuffix.AutoSize = True
        Me.lblRentSuffix.Location = New System.Drawing.Point(24, 81)
        Me.lblRentSuffix.Name = "lblRentSuffix"
        Me.lblRentSuffix.Size = New System.Drawing.Size(110, 13)
        Me.lblRentSuffix.TabIndex = 16
        Me.lblRentSuffix.Text = "Specified Trans Suffix"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBoxSpecificTraderTransaction)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBoxDebtorType)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 94)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Semi Permanent Settings"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBoxWithdrawLeadText)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtBoxCampingDeposit)
        Me.GroupBox3.Controls.Add(Me.txtBoxCampingIncome)
        Me.GroupBox3.Controls.Add(Me.txtBoxInvLeadText)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtBoxCampingDebtorType)
        Me.GroupBox3.Controls.Add(Me.txtBoxCampingGST)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 186)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Camping Settings"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Deposit Account"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Income Account"
        '
        'txtBoxCampingDeposit
        '
        Me.txtBoxCampingDeposit.Location = New System.Drawing.Point(141, 67)
        Me.txtBoxCampingDeposit.Name = "txtBoxCampingDeposit"
        Me.txtBoxCampingDeposit.Size = New System.Drawing.Size(159, 20)
        Me.txtBoxCampingDeposit.TabIndex = 7
        '
        'txtBoxCampingIncome
        '
        Me.txtBoxCampingIncome.Location = New System.Drawing.Point(141, 43)
        Me.txtBoxCampingIncome.Name = "txtBoxCampingIncome"
        Me.txtBoxCampingIncome.Size = New System.Drawing.Size(159, 20)
        Me.txtBoxCampingIncome.TabIndex = 6
        '
        'txtBoxInvLeadText
        '
        Me.txtBoxInvLeadText.Location = New System.Drawing.Point(141, 115)
        Me.txtBoxInvLeadText.Name = "txtBoxInvLeadText"
        Me.txtBoxInvLeadText.Size = New System.Drawing.Size(282, 20)
        Me.txtBoxInvLeadText.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Invoice Lead Text"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Debtor Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GST Account"
        '
        'txtBoxCampingDebtorType
        '
        Me.txtBoxCampingDebtorType.Location = New System.Drawing.Point(141, 91)
        Me.txtBoxCampingDebtorType.Name = "txtBoxCampingDebtorType"
        Me.txtBoxCampingDebtorType.Size = New System.Drawing.Size(80, 20)
        Me.txtBoxCampingDebtorType.TabIndex = 1
        '
        'txtBoxCampingGST
        '
        Me.txtBoxCampingGST.Location = New System.Drawing.Point(141, 19)
        Me.txtBoxCampingGST.Name = "txtBoxCampingGST"
        Me.txtBoxCampingGST.Size = New System.Drawing.Size(160, 20)
        Me.txtBoxCampingGST.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Withdrawal Lead Text"
        '
        'txtBoxWithdrawLeadText
        '
        Me.txtBoxWithdrawLeadText.Location = New System.Drawing.Point(141, 140)
        Me.txtBoxWithdrawLeadText.Name = "txtBoxWithdrawLeadText"
        Me.txtBoxWithdrawLeadText.Size = New System.Drawing.Size(282, 20)
        Me.txtBoxWithdrawLeadText.TabIndex = 11
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 531)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "frmSettings"
        Me.Text = "MP Billing - Session Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoxDebtorType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBoxOutFileNameStub As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBoxSpecificTraderTransaction As System.Windows.Forms.TextBox
    Friend WithEvents lblDateConfirm As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxRentSuffix As System.Windows.Forms.TextBox
    Friend WithEvents lblRentSuffix As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCampingDebtorType As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxCampingGST As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBoxInvLeadText As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBoxCampingDeposit As TextBox
    Friend WithEvents txtBoxCampingIncome As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBoxWithdrawLeadText As TextBox
    Friend WithEvents Label11 As Label
End Class
