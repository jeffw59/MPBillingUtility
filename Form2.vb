Public Class frmSettings

    Public Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        MPBilling.frmMain.dtTransDate = DateTimePicker1.Value.ToShortDateString
        MPBilling.frmMain.strDebtorType = txtBoxDebtorType.Text
        MPBilling.frmMain.strUser = txtBoxUserName.Text
        MPBilling.frmMain.strSpecifiedTraderService = txtBoxSpecificTraderTransaction.Text
        MPBilling.frmMain.strRentMonth = txtBoxRentSuffix.Text
        'Also make the permanent adjustments to settings
        My.Settings.TraderSpecificService = txtBoxSpecificTraderTransaction.Text
        My.Settings.DebtorType = txtBoxDebtorType.Text
        My.Settings.CampingGSTAccount = txtBoxCampingGST.Text
        My.Settings.CampingDebtorType = txtBoxCampingDebtorType.Text
        My.Settings.CampingDebtorType = txtBoxInvLeadText.Text
        My.Settings.CampingDepositAccount = txtBoxCampingDeposit.Text
        My.Settings.CampingIncomeAccount = txtBoxCampingIncome.Text

        ActiveForm.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        lblDateConfirm.Text = DateTimePicker1.Value.ToLongDateString

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxSpecificTraderTransaction.Text = My.Settings.TraderSpecificService
        txtBoxDebtorType.Text = My.Settings.DebtorType
        txtBoxCampingGST.Text = My.Settings.CampingGSTAccount
        txtBoxCampingDebtorType.Text = My.Settings.CampingDebtorType
        txtBoxInvLeadText.Text = My.Settings.CampingInvLeadText
        txtBoxCampingDeposit.Text = My.Settings.CampingDepositAccount
        txtBoxCampingIncome.Text = My.Settings.CampingIncomeAccount
    End Sub
End Class