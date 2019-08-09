Public Class frmMain
    'Public strDataSourceFilePath As String = "C:\Users\Greg\Documents\Visual Studio 2010\Projects\GregsBillingGadget\"
    'Public strDataSourceFileTraders As String = "GBG_TraderList.txt"
    'Public strDataSourceFileServices As String = "GBG_TransItems.txt"
    Public strDebtorType As String = My.Settings.DebtorType
    Public dtTransDate As Date = Date.Today
    Public strRentMonth As String = "NotYetSet" 'last month is used to append on rent transactions
    Public strUser As String = GetUserName()
    Public strDataFileNameStub As String = "CampingDebInvoice"
    Public strDataFileNameWithdraw As String = "CampingDebAdjust"
    Public strSpecifiedTraderService As String = My.Settings.TraderSpecificService
    Public blnBillingSession As Boolean = False
    Public blnClosedOnce As Boolean = False  'used to show exit splash on close
    Public strCampingDebtorType As String = My.Settings.CampingDebtorType
    Public strCampingGSTAcct As String = My.Settings.CampingGSTAccount
    Public strCampingIncomeAcct As String = My.Settings.CampingIncomeAccount
    Public strCampingDepositAcct As String = My.Settings.CampingDepositAccount
    Public strCampingInvLeadText As String = My.Settings.CampingInvLeadText   'This is typically the season dates
    Public strCampingWithdrawLeadText As String = My.Settings.CampingWithdrawLeadText

    Dim aryTraderName() As String
    Dim aryTraderAccount() As String
    Dim aryTraderRent() As String
    Dim intTraderLines As Integer = 0
    Dim intSelectedTraderIndex As Integer
    Dim aryTransItemName() As String
    Dim aryTransItemDefQty() As String
    Dim aryTransItemDefCost() As String
    Dim aryTransItemPostAcc() As String
    Dim intSelectedServiceIndex As Integer
    Dim aryTransList() As String
    Dim intTransLines As Integer = 0
    Dim TransValue As String = 0
    Dim GrandTotal As Double = 0
    Dim intProgressLines As Integer = 0
    Dim aryProgressTrader() As String
    Dim aryTraderTransactions() As Integer
    Dim aryTraderTransValue() As Double

    Sub PopulateTraders()
        'MsgBox("Populate T")
        'Code to extract trader data from settings file and populate listview
        Dim Cols As Integer = My.Settings.TradersListCols
        Dim ListCount As Integer = My.Settings.TradersXml.Count
        Dim Readline As String
        Dim aryReadLine(Cols - 1) As String
        ListBoxTraders.Items.Clear()
        For i As Integer = 0 To ListCount - 1 'this would be the number of traders or services stored in the settings list
            Readline = My.Settings.TradersXml(i)
            aryReadLine = Readline.Split(",")
            ReDim Preserve aryTraderName(i)
            ReDim Preserve aryTraderAccount(i)
            ReDim Preserve aryTraderRent(i)
            For x = 0 To UBound(aryReadLine)
                Select Case x
                    Case 0
                        aryTraderName(i) = aryReadLine(x)
                    Case 1
                        aryTraderAccount(i) = aryReadLine(x)
                    Case 2
                        aryTraderRent(i) = aryReadLine(x)
                End Select
            Next x
            ListBoxTraders.Items.Add(aryTraderName(i)) 'populate the traders list box
        Next i

    End Sub
    Sub PopulateServices()
        'MsgBox("Populate S")
        'Code to extract Services data from settings file and populate listview
        Dim Cols As Integer = My.Settings.ServicesListCols
        Dim ListCount As Integer = My.Settings.ServicesXml.Count
        Dim Readline As String
        Dim aryReadLine(Cols - 1) As String
        ListBoxServices.Items.Clear()
        For i As Integer = 0 To ListCount - 1
            Readline = My.Settings.ServicesXml(i)
            aryReadLine = Readline.Split(",")
            ReDim Preserve aryTransItemName(i)
            ReDim Preserve aryTransItemDefQty(i)
            ReDim Preserve aryTransItemDefCost(i)
            ReDim Preserve aryTransItemPostAcc(i)
            For x = 0 To UBound(aryReadLine)
                Select Case x
                    Case 0
                        aryTransItemName(i) = aryReadLine(x)
                    Case 1
                        aryTransItemDefQty(i) = aryReadLine(x)
                    Case 2
                        aryTransItemDefCost(i) = aryReadLine(x)
                    Case 3
                        aryTransItemPostAcc(i) = aryReadLine(x)
                End Select
            Next x
            ListBoxServices.Items.Add(aryTransItemName(i))
        Next i
        ListBoxServices.SelectedIndex = 0
    End Sub

    Public Sub NewBillingSessionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBillingSessionToolStripMenuItem.Click
        '******Old Code*************************************************
        'If Microsoft.VisualBasic.Strings.Right(strDataSourceFilePath, 1) <> "\" Then
        'strDataSourceFilePath = strDataSourceFilePath & "\"
        'End If
        'Dim TraderFile As String = strDataSourceFilePath & strDataSourceFileTraders
        'Dim TradersElementsPerLine As Integer = 2 'zero numbered number of elements in each line
        'Dim aryTextLineTraders(TradersElementsPerLine) As String
        'Dim TransItemsFile As String = strDataSourceFilePath & strDataSourceFileServices
        'Dim TransItemsElementsPerLine As Integer = 3 'zero numbered number of elements in each line
        'Dim aryTextLineTransItems(TransItemsElementsPerLine) As String
        'Dim TextLine As String = vbNullString
        'Dim i As Integer = 0 'lines in file
        'Dim x As Integer = 0 'elements in line
        'check Traders file exists open it and read each line and populate trader list box


        'If System.IO.File.Exists(TraderFile) = True Then
        'Dim objReader As New System.IO.StreamReader(TraderFile)
        'Do While objReader.Peek() <> -1
        'TextLine = objReader.ReadLine()
        'split the line and place elements in arrays
        'aryTextLineTraders = TextLine.Split(",") 'comma seperated
        'ReDim Preserve aryTraderName(i)
        'ReDim Preserve aryTraderAccount(i)
        'ReDim Preserve aryTraderRent(i)
        'For x = 0 To UBound(aryTextLineTraders)
        'Select Case x
        '   Case 0
        'aryTraderName(i) = aryTextLineTraders(x)
        '   Case 1
        'aryTraderAccount(i) = aryTextLineTraders(x)
        '   Case 2
        'aryTraderRent(i) = aryTextLineTraders(x)
        'End Select
        'Next x
        'ListBoxTraders.Items.Add(aryTraderName(i))
        'i = i + 1
        'MsgBox(aryTraderName(i))
        'Loop
        'objReader.Close()
        'Else
        'MsgBox("File Does Not Exist")
        'Exit Sub
        'End If
        'x = 0
        'i = 0
        'TextLine = ""
        'check Transaction Items  file exists open it and read each line and populate Tran Items list box
        'If System.IO.File.Exists(TransItemsFile) = True Then
        'Dim objReader As New System.IO.StreamReader(TransItemsFile)
        'Do While objReader.Peek() <> -1
        'TextLine = objReader.ReadLine()
        'split the line and place elements in arrays
        'aryTextLineTransItems = TextLine.Split(",") 'comma seperated
        'ReDim Preserve aryTransItemName(i)
        'ReDim Preserve aryTransItemDefQty(i)
        'ReDim Preserve aryTransItemDefCost(i)
        'ReDim Preserve aryTransItemPostAcc(i)
        'For x = 0 To UBound(aryTextLineTransItems)
        'Select Case x
        'Case 0
        '     aryTransItemName(i) = aryTextLineTransItems(x)
        '  Case 1
        '       aryTransItemDefQty(i) = aryTextLineTransItems(x)
        '    Case 2
        '         aryTransItemDefCost(i) = aryTextLineTransItems(x)
        '      Case 3
        '           aryTransItemPostAcc(i) = aryTextLineTransItems(x)
        '    End Select
        ' Next x
        '  ListBoxServices.Items.Add(aryTransItemName(i))
        '   i = i + 1
        'Loop
        ' objReader.Close()

        'Else
        '  MsgBox("File Does Not Exist")
        '   Exit Sub
        'End If
        '*****NEw Code************************************
        blnBillingSession = True
        GrandTotal = 0
        'disable the refresh buttons
        btnTradersRefresh.Visible = False
        btnServicesRefresh.Visible = False
        NewBillingSessionToolStripMenuItem.Enabled = False ' make sure its not selected again
        SettingsToolStripMenuItem.Enabled = False 'make sure setting are not changed mid stream
        'clear the two list boxes in case they have left overs
        ListBoxTraders.Items.Clear()
        ListBoxServices.Items.Clear()
        'disable the services list for the moment until a trader is selected
        ListBoxServices.Enabled = False
        ListBoxServices.Visible = False
        'Code to extract trader data from settings file and populate listview
        PopulateTraders()
        'Code to extract services data from settings file and populate listview
        PopulateServices()
        'MANAGE CONTROLS
        lblSelTrader.Text = "Select Trader (" & ListBoxTraders.Items.Count & ")"
        lblSelTrader.ForeColor = Color.Blue
        lblSelTrader.Visible = True
        lblSelService.Visible = False
        lblSelService.Text = "Select Service (" & ListBoxServices.Items.Count & ")"
        ListViewProgress.Visible = False
        ListViewProgress.Clear()
        ' Set the Progress view to show details.
        ListViewProgress.View = View.Details  'important
        ' Allow the user to edit item text.
        ListViewProgress.LabelEdit = True
        ' Allow the user to rearrange columns.
        ListViewProgress.AllowColumnReorder = True
        ' Display check boxes.
        ListViewProgress.CheckBoxes = True
        ' Select the item and subitems when selection is made.
        ListViewProgress.FullRowSelect = True
        ' Display grid lines.
        ListViewProgress.GridLines = True
        ' Sort the items in the list in ascending order.
        ListViewProgress.Sorting = SortOrder.Ascending
        'ListViewProgress.View = View.Details  'important
    End Sub
    Public Sub ListBoxTraders_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxTraders.SelectedIndexChanged
        If blnBillingSession Then
            txtBoxTransTrader.Text = ListBoxTraders.SelectedItem 'populate the transaction builder text box
            intSelectedTraderIndex = ListBoxTraders.SelectedIndex 'record the list index of the selected trader for later
            'crap  Cause the services list to change so that the changed Index event is triggered to update the transaction builder
            'Dim z As Integer = ListBoxServices.SelectedIndex
            'If ListBoxServices.SelectedIndex = -1 Then
            'ListBoxServices.SelectedIndex = 0
            'ElseIf ListBoxServices.SelectedIndex = 0 Then
            'ListBoxServices.SelectedIndex = 1
            'ListBoxServices.SelectedIndex = 0
            'End If
            'Populate the transaction Builder
            PopulateTransactionBuilder()
            ListBoxServices.Enabled = True
            lblSelService.Visible = True
            lblSelService.ForeColor = Color.Blue
            ListBoxServices.Visible = True
            ListBoxServices.Focus()

        End If
    End Sub
    Public Sub ListBoxServices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxServices.SelectedIndexChanged
        'This will populate the transaction builder
        'using data recovered from tlhe service data that has been collected from file into an array
        'and calculate the total 
        'and wait for the user to accept
        PopulateTransactionBuilder()
    End Sub
    Sub PopulateTransactionBuilder()
        txtBoxTransService.Text = ListBoxServices.SelectedItem
        If txtBoxTransService.Text = strSpecifiedTraderService Then 'ie Rent
            txtBoxTransQty.Text = 1
            txtBoxTransUnitCost.Text = aryTraderRent(ListBoxTraders.SelectedIndex) 'get the individual rent for that trader
            If strRentMonth = "NotYetSet" Then
                If Month(Date.Today) = 1 Then
                    strRentMonth = "December"
                Else
                    strRentMonth = MonthName(Month(Date.Today) - 1)
                End If
            End If
            txtBoxTransService.Text = txtBoxTransService.Text & " " & strRentMonth
        Else  'use the default quantity and unit costs
            txtBoxTransQty.Text = aryTransItemDefQty(ListBoxServices.SelectedIndex)
            txtBoxTransUnitCost.Text = aryTransItemDefCost(ListBoxServices.SelectedIndex)
        End If
        txtBoxTransTotal.Text = CStr(Val(txtBoxTransQty.Text) * Val(txtBoxTransUnitCost.Text)) 'multiply
        txtBoxTransQty.Enabled = True
        txtBoxTransUnitCost.Enabled = True
        txtBoxTransQty.BackColor = Color.LightSkyBlue
        txtBoxTransUnitCost.BackColor = Color.LightSkyBlue
        intSelectedServiceIndex = ListBoxServices.SelectedIndex
        btnAcceptTrans.Enabled = True 'allow user to accept the transaction
        btnAcceptTrans.Focus()
    End Sub
    Private Sub txtBoxTransQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxTransQty.TextChanged
        'This will recalculate the total if the quantity textbox is changed.
        txtBoxTransTotal.Text = CStr(Val(txtBoxTransQty.Text) * Val(txtBoxTransUnitCost.Text))
    End Sub
    Private Sub txtBoxTransUnitCost_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxTransUnitCost.TextChanged
        'This will recalculate the total if the unit cost textbox is changed.
        txtBoxTransTotal.Text = CStr(Val(txtBoxTransQty.Text) * Val(txtBoxTransUnitCost.Text))
    End Sub
    Private Sub btnNextTrader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextTrader.Click
        'This will prepare and allow the user to select a new trader
        btnAcceptTrans.Enabled = False
        btnFinished.Enabled = False
        ListBoxTraders.Enabled = True
        ListBoxTraders.Focus()
        ListBoxServices.Enabled = False
        lblSelTrader.ForeColor = Color.Blue
        lblSelService.Visible = False
    End Sub
    Public Sub btnAcceptTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptTrans.Click
        'When the Accept button is clicked the transaction must be built
        ' and placed in the output array and also the transaction list.
        'At this point we can gather more data for the Transaction Data
        Dim TransType As String = "debinvoice"
        Dim TransAcct As String = aryTraderAccount(intSelectedTraderIndex)
        Dim TransRef As String = strUser '& Date.Today.ToShortDateString
        TransValue = txtBoxTransTotal.Text
        Dim TransDesc As String = txtBoxTransService.Text
        Dim PostingAccount As String = aryTransItemPostAcc(intSelectedServiceIndex)
        Dim TransDataLine As String
        'Command Button Management
        ListBoxTraders.Enabled = False 'if not already false
        ListBoxServices.Focus()  'so user can select next service
        btnAcceptTrans.Enabled = False
        btnNextTrader.Enabled = True 'allow user to select next trader if they want
        'Generate Transaction Data
        TransDataLine = TransAcct & "||||||||"
        TransDataLine = TransDataLine & strDebtorType & "|" & dtTransDate & "|"
        TransDataLine = TransDataLine & TransRef & "|" & TransType & "|"
        TransDataLine = TransDataLine & TransValue & "|||" & TransDesc & "|||"
        TransDataLine = TransDataLine & PostingAccount
        'Keep building the output array that will be used to build the output file
        ReDim Preserve aryTransList(intTransLines)
        aryTransList(intTransLines) = TransDataLine
        listBoxTransList.Items.Add(aryTransList(intTransLines))
        '==========================================================================
        'CREATE A NEW PROGRESS REPORT IN THE LIST VIEW
        'We do this by making 3 arrays to store the Trader's Name, the
        ' number of transactions per trader and the value of those transactions per trader.
        Dim strThisTrader As String
        Dim intThisTradersSpot As Integer
        Dim blnNewSpotReqd As Boolean = True

        'look at the trader for this transaction
        strThisTrader = aryTraderName(intSelectedTraderIndex) 'the trader name array was initially extracted from the textfile
        'check if we already have listed this trader in our Progress Listing
        'if not the increase the size of the array that holds the trader names
        If intTransLines = 0 Then    'special case for the first transaction that we make
            ReDim Preserve aryProgressTrader(0)
            aryProgressTrader(0) = strThisTrader
        End If
        For t As Integer = 0 To UBound(aryProgressTrader)
            If aryProgressTrader(t) = strThisTrader Then 'this trader holds position t in the progress array
                intThisTradersSpot = t
                blnNewSpotReqd = False
            End If
        Next
        If blnNewSpotReqd Then
            ReDim Preserve aryProgressTrader(UBound(aryProgressTrader) + 1)
            intThisTradersSpot = UBound(aryProgressTrader)
            aryProgressTrader(intThisTradersSpot) = strThisTrader
        End If
        'Now look at the array that holds the number of transactions for each trader in the progress list
        'and increase the size of the array if another trader is encountered
        If intTransLines = 0 Then
            ReDim Preserve aryTraderTransactions(0)
            aryTraderTransactions(intThisTradersSpot) = 0
        ElseIf intThisTradersSpot > UBound(aryTraderTransactions) Then
            ReDim Preserve aryTraderTransactions(intThisTradersSpot)
        End If
        'increment the number of transactions for the trader of this transaction
        aryTraderTransactions(intThisTradersSpot) = aryTraderTransactions(intThisTradersSpot) + 1
        'Now look at the array that holds the value of the transactions for each trader in the progress list
        'and increase the size of the array if another trader is encountered
        If intTransLines = 0 Then
            ReDim Preserve aryTraderTransValue(0)
            aryTraderTransValue(intThisTradersSpot) = 0
        ElseIf intThisTradersSpot > UBound(aryTraderTransValue) Then
            ReDim Preserve aryTraderTransValue(intThisTradersSpot)
        End If
        'Top up the Transaction and Value arrays as well
        aryTraderTransValue(intThisTradersSpot) = aryTraderTransValue(intThisTradersSpot) + TransValue
        'clear the listview
        ListViewProgress.Clear()
        'Specify 3 columns for the listview
        Dim lvwColumn As ColumnHeader
        Dim MaxCols As Integer = 2 'zero numbered
        Dim ColHead(MaxCols) As String
        Dim ColWidth(MaxCols) As String
        ColHead(0) = "Trader"
        ColHead(1) = "Trans"
        ColHead(2) = "Value"
        ColWidth(0) = 210
        ColWidth(1) = 50
        ColWidth(2) = 45
        For ColNo = 0 To MaxCols
            lvwColumn = New ColumnHeader()
            lvwColumn.Text = ColHead(ColNo)
            lvwColumn.Width = ColWidth(ColNo)
            ListViewProgress.Columns.Add(lvwColumn)
        Next
        For ProgTrader As Integer = 0 To UBound(aryProgressTrader)
            Dim itmListItem As ListViewItem
            'Specify the first column's data of the item
            itmListItem = New ListViewItem()
            itmListItem.Text = aryProgressTrader(ProgTrader)
            itmListItem.SubItems.Add(aryTraderTransactions(ProgTrader))
            itmListItem.SubItems.Add(aryTraderTransValue(ProgTrader))
            'Now chuck the whole row into the list View
            ListViewProgress.Items.Add(itmListItem)
        Next
        picBox1.Visible = False  'get rid of the coffee cup pic
        ListViewProgress.Visible = True
        lblProgMon.Visible = True
        'increment the counter that records the number or lines recorded
        intTransLines = intTransLines + 1  'This records the number of lines in the Transaction list that is being assembled
        'Record Running Total
        GrandTotal = GrandTotal + CDbl(TransValue)
        grpboxTransactionList.Text = "Output File: Lines(" & intTransLines & ") Value(" & GrandTotal & ")"
        btnFinished.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btnFinished_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinished.Click
        Dim msgOK As String
        Dim FileOK As Boolean = False
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\"
        Dim mydocName As String
        btnNextTrader.Enabled = False
        ListBoxServices.Enabled = False
        mydocName = strDataFileNameStub & "_" & strUser
        mydocName = mydocName & "_" & DateTime.Today.Day & DateTime.Today.Month & DateTime.Today.Year
        mydocName = mydocName & ".txt"
        Dim Path As String = mydocpath & mydocName
        msgOK = MsgBox("Have you finished creating all your transactions for this billing session?" & vbCrLf & vbCrLf & _
               "Click Yes to continue and write all transactions to text file which can be uploaded directly into Proclaim Sundry Debtors." & vbCrLf & vbCrLf & _
               "Click No to enter more transactions or to close the application.", vbYesNo, "MyT Billing Gadget")
        If msgOK = vbYes Then
            If System.IO.File.Exists(Path) = False Then
                ' Create a file to write to.
                Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                sw.WriteLine(strDebtorType & "|" & CStr(GrandTotal)) 'this is the file header required by proclaim
                For l As Integer = 0 To UBound(aryTransList)
                    sw.WriteLine(aryTransList(l))
                Next l
                sw.Flush()
                sw.Close()
                FileOK = True
            Else
                msgOK = MsgBox("File " & mydocName & " exists in " & mydocpath & "." & vbCrLf & _
               "Click OK to overwite file." & vbCrLf & _
               "Click Cancel for some other choice that hasn't been thought of yet!", vbOKCancel, "MyT Billing Gadget")
                If msgOK = vbOK Then
                    ' Create a file to write to.
                    Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                    sw.WriteLine(strDebtorType & "|" & CStr(GrandTotal))
                    For l As Integer = 0 To UBound(aryTransList)
                        sw.WriteLine(aryTransList(l))
                    Next l
                    sw.Flush()
                    sw.Close()
                    FileOK = True
                End If
            End If
        End If
        If FileOK = True Then
            btnFinished.Enabled = False
            txtboxOutputFile.Text = Path
            txtboxOutputFile.Visible = True
            lblOutPutFile.Visible = True
            lblOutPutFile.ForeColor = Color.Blue
            btnEmailFile.Enabled = False
            btnEmailFile.Visible = False
            btnAcceptTrans.Enabled = False
            'its no good allowing the user to start again unless you clear everything up first. too hard for now.
            'NewBillingSessionToolStripMenuItem.Enabled = True
            'SettingsToolStripMenuItem.Enabled = True
        End If
    End Sub
    Private Sub btnEmailFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailFile.Click

    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Activate()
        AboutBox.Visible = True
        AboutBox.Focus()
        AboutBox.OKButton.Focus()
    End Sub

    Public Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.DateTimePicker1.Value = dtTransDate.ToShortDateString
        frmSettings.lblDateConfirm.Text = dtTransDate.ToLongDateString
        frmSettings.txtBoxDebtorType.Text = strDebtorType
        frmSettings.txtBoxUserName.Text = strUser
        frmSettings.txtBoxOutFileNameStub.Text = strDataFileNameStub 'first part of output file name
        If strRentMonth = "NotYetSet" Then  'set the default to last month
            If Month(Date.Today) = 1 Then
                strRentMonth = "December"
            Else
                strRentMonth = MonthName(Month(Date.Today) - 1)
            End If
        End If
        frmSettings.txtBoxRentSuffix.Text = strRentMonth   'rent suffix
        frmSettings.txtBoxSpecificTraderTransaction.Text = strSpecifiedTraderService 'ie Rent
        'load camping settings
        frmSettings.txtBoxCampingDebtorType.Text = strCampingDebtorType
        frmSettings.txtBoxCampingGST.Text = strCampingGSTAcct
        frmSettings.Activate()
        frmSettings.Visible = True

    End Sub

    Private Sub TradersListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TradersListToolStripMenuItem.Click
        frmSourceDataEdit.Text = "Edit Traders List"
        frmSourceDataEdit.Visible = True
        frmSourceDataEdit.Activate()

        'Next
        'check Traders file exists open it and read each line and populate trader list box
        'If System.IO.File.Exists(strDataSourceFilePath & strDataSourceFileTraders) Then
        'Dim objReader As New System.IO.StreamReader(strDataSourceFilePath & strDataSourceFileTraders)
        'Do While objReader.Peek() <> -1
        'Dim i As Integer
        'Dim ReadLine As String = objReader.ReadLine()
        'split the line and place elements in arrays
        'Dim aryReadLineTraders() = ReadLine.Split(",") 'comma seperated
        'ReDim Preserve aryTraderName(i)
        'ReDim Preserve aryTraderAccount(i)
        'ReDim Preserve aryTraderRent(i)
        'For x = 0 To UBound(aryReadLineTraders)
        'Select Case x
        '   Case 0
        'aryTraderName(i) = aryReadLineTraders(x)
        '   Case 1
        'aryTraderAccount(i) = aryReadLineTraders(x)
        '   Case 2
        'aryTraderRent(i) = aryReadLineTraders(x)
        'End Select
        'Next x
        'we have stored a line of data in 3 arrays ready to write it into the list view
        'Dim itmListItem As ListViewItem
        'Specify the first column's data of the item
        'itmListItem = New ListViewItem()
        'itmListItem.Text = aryTraderName(i)
        'itmListItem.SubItems.Add(aryTraderAccount(i))
        'itmListItem.SubItems.Add(aryTraderRent(i))
        'Now chuck the whole row into the list View
        'frmSourceDataEdit.ListView1.Items.Add(itmListItem)
        'i = i + 1
        'MsgBox(aryTraderName(i))
        'Loop
        'objReader.Close()
        'End If
    End Sub
    Declare Function GetUserName Lib "advapi32.dll" Alias _
       "GetUserNameA" (ByVal lpBuffer As String, _
       ByRef nSize As Integer) As Integer

    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function

    Private Sub ServicesListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesListToolStripMenuItem.Click
        frmSourceDataEdit.Text = "Edit Services List"
        frmSourceDataEdit.Visible = True
        frmSourceDataEdit.Activate()
        'old stuff
        'First prepare the list view in the edit form.
        'clear the listview
        'frmSourceDataEdit.ListView1.Clear()
        'Specify 3 columns for the listview
        'Dim lvwColumn As ColumnHeader
        'Dim MaxCols As Integer = 3 'zero numbered
        'Dim ColHead(MaxCols) As String
        'Dim ColWidth(MaxCols) As String
        'ColHead(0) = "Service"
        'ColHead(1) = "Def Qty"
        'ColHead(2) = "Unit Cost"
        'ColHead(3) = "Posting Account"
        'ColWidth(0) = 150
        'ColWidth(1) = 40
        'ColWidth(2) = 40
        'ColWidth(3) = 120
        'For ColNo = 0 To MaxCols
        'lvwColumn = New ColumnHeader()
        'lvwColumn.Text = ColHead(ColNo)
        'lvwColumn.Width = ColWidth(ColNo)
        'frmSourceDataEdit.ListView1.Columns.Add(lvwColumn)
        'Next
        'check Services file exists open it and read each line and populate trader list box
        'If System.IO.File.Exists(strDataSourceFilePath & strDataSourceFileServices) Then
        'Dim objReader As New System.IO.StreamReader(strDataSourceFilePath & strDataSourceFileServices)
        'Do While objReader.Peek() <> -1
        'Dim i As Integer
        'Dim ReadLine As String = objReader.ReadLine()
        'split the line and place elements in arrays
        'Dim aryReadLineService() = ReadLine.Split(",") 'comma seperated
        'ReDim Preserve aryTransItemName(i)
        'ReDim Preserve aryTransItemDefQty(i)
        'ReDim Preserve aryTransItemDefCost(i)
        'ReDim Preserve aryTransItemPostAcc(i)
        'For x = 0 To UBound(aryReadLineService)
        'Select Case x
        '   Case 0
        'aryTransItemName(i) = aryReadLineService(x)
        '   Case 1
        'aryTransItemDefQty(i) = aryReadLineService(x)
        '   Case 2
        'aryTransItemDefCost(i) = aryReadLineService(x)
        '   Case 3
        'aryTransItemPostAcc(i) = aryReadLineService(x)
        'End Select
        'Next x
        'we have stored a line of data in 4 arrays ready to write it into the list view
        'Dim itmListItem As ListViewItem
        'Specify the first column's data of the item
        'itmListItem = New ListViewItem()
        'itmListItem.Text = aryTransItemName(i)
        'itmListItem.SubItems.Add(aryTransItemDefQty(i))
        'itmListItem.SubItems.Add(aryTransItemDefCost(i))
        'itmListItem.SubItems.Add(aryTransItemPostAcc(i))
        'itmListItem.Text = My.Settings.TradersXml.Item(1)
        'Now chuck the whole row into the list View
        'frmSourceDataEdit.ListView1.Items.Add(itmListItem)
        'i = i + 1
        'MsgBox(aryTraderName(i))
        'Loop
        'objReader.Close()
        'End If      
    End Sub
    Private Sub btnTradersRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTradersRefresh.Click
        If ListBoxTraders.Items.Count > 0 Then
            Dim blnStatus As Boolean = ListBoxTraders.Visible
            PopulateTraders()
            lblSelTrader.Text = "Select Trader (" & ListBoxTraders.Items.Count & ")"
            ListBoxTraders.Visible = blnStatus
        End If
        btnTradersRefresh.Visible = False
    End Sub
    Private Sub btnServicesRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicesRefresh.Click
        If ListBoxServices.Items.Count > 0 Then
            Dim blnStatus As Boolean = ListBoxServices.Visible
            PopulateServices()
            lblSelService.Text = "Select Service (" & ListBoxServices.Items.Count & ")"
            ListBoxServices.Visible = blnStatus
        End If
        btnServicesRefresh.Visible = False  'turn the button off
    End Sub
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        'Stop the exit process the first time thru this
        If blnClosedOnce Then
            e.Cancel = False
        Else
            e.Cancel = True
            blnClosedOnce = True
            frmExitSplash.Visible = True
            'frmExitSplash.SetDesktopLocation(60, 60)
            ' Keep the current form active by calling the Activate method.
            frmExitSplash.Activate()
            frmExitSplash.Show()
            frmExitSplash.Focus()
            'frmExitSplash.PictureBox1.Focus()
            Me.Enabled = False
        End If


    End Sub
    Private Sub ExportListsDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportListsDataToolStripMenuItem.Click
        If MessageBox.Show("Are you sure wish to export your Trader and Transaction data to a text file?", "MP Billing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        'Code to extract trader data from settings file
        Dim Cols As Integer = My.Settings.TradersListCols
        Dim ListCount As Integer = My.Settings.TradersXml.Count
        Dim Readline As String
        Dim aryReadLine(Cols - 1) As String
        Dim aryExport() As String
        Dim i As Integer = 0
        aryExport = New String() {"x"} 'initialise the first array element with a dummy string which will get changed below
        'Read the trader data held in the xml settings file into an array
        For t As Integer = 0 To ListCount - 1 'this would be the number of traders stored in the settings list
            Readline = My.Settings.TradersXml(t) 'read the first line
            ReDim Preserve aryExport(t)
            aryExport(i) = "Trader" & "," & Readline
            i = i + 1
        Next t
        'now read the services data
        Cols = My.Settings.ServicesListCols
        ListCount = My.Settings.ServicesXml.Count
        ReDim aryReadLine(Cols - 1)  'no need too preserve stuff from before
        'Nw read the services data held in the xml settings file into an array
        For j As Integer = 0 To ListCount - 1 'this would be the number of traders stored in the settings list
            Readline = My.Settings.ServicesXml(j) 'read the first line of services
            ReDim Preserve aryExport(i + j)
            aryExport(i) = "Service" & "," & Readline
            i = i + 1
        Next j
        'Now write the data held in the array to a text file.
        Dim FileOK As Boolean = False
        'define the path and file name 
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\"
        Dim mydocName As String
        mydocName = "MP_Billing_Invoice_Data_" & strUser
        mydocName = mydocName & "_" & DateTime.Today.Day & DateTime.Today.Month & DateTime.Today.Year
        mydocName = mydocName & ".txt"
        Dim Path As String = mydocpath & mydocName
        'have a look in the file system
        If System.IO.File.Exists(Path) = False Then
            ' Create a file to write to.
            Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
            For l As Integer = 0 To UBound(aryExport)
                sw.WriteLine(aryExport(l))
            Next l
            sw.Flush()
            sw.Close()
            FileOK = True
        Else
            If MessageBox.Show("File " & mydocName & " exists in " & mydocpath & "." & vbCrLf & _
           "Click Yes to overwite file.", "Help Me Out Here", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Create a file to write to.
                Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                For l As Integer = 0 To UBound(aryExport)
                    sw.WriteLine(aryExport(l))
                Next l
                sw.Flush()
                sw.Close()
                FileOK = True
            End If
            'tell the user that it worked OK
        End If
        If FileOK Then
            MessageBox.Show("File written OK to..." & vbCrLf & Path, "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub ImportListsDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportListsDataToolStripMenuItem.Click
        If MessageBox.Show("Are you sure wish to Import Trader and Transaction data from a pre-prepared text file?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "MP Billing Setup File Import"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        fdlg.FilterIndex = 1  'use the first filter defined above as the default
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim x As String = fdlg.FileName
            If System.IO.File.Exists(fdlg.FileName) = False Then
                MsgBox("File does not exist")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        'Dim myStream As New System.IO.StreamReader(fdlg.FileName)
        Dim objReader As New System.IO.StreamReader(fdlg.FileName)

        Try
            If (objReader IsNot Nothing) Then
                'get the current sizes of the lists
                Dim ListCountTraders As Integer
                Dim ListCountServices As Integer
                ListCountTraders = My.Settings.TradersXml.Count
                ListCountServices = My.Settings.ServicesXml.Count
                Dim aryTradersOut() As String
                Dim aryServicesOut() As String
                aryTradersOut = New String() {"x"}
                aryServicesOut = New String() {"x"}
                'Code to read the stream here.
                Dim i As Integer = 0
                Dim t As Integer = 0
                Dim s As Integer = 0
                Do While objReader.Peek() <> -1
                    i = i + 1
                    Dim ReadLine As String = objReader.ReadLine()
                    'split the line and place elements in arrays
                    Dim aryReadLine() = ReadLine.Split(",") 'comma seperated
                    If aryReadLine(0) = "Trader" Then
                        ReDim Preserve aryTradersOut(t)
                        aryTradersOut(t) = aryReadLine(1) & "," & aryReadLine(2) & "," & aryReadLine(3)
                        t = t + 1
                    ElseIf aryReadLine(0) = "Service" Then
                        ReDim Preserve aryServicesOut(s)
                        aryServicesOut(s) = aryReadLine(1) & "," & aryReadLine(2) & "," & aryReadLine(3) & "," & aryReadLine(4)
                        s = s + 1
                    ElseIf aryReadLine(0) = "" Then

                    Else
                        MsgBox("There is an error with the file syntax in line " & i)
                    End If
                Loop
                My.Settings.TradersXml.Clear()
                My.Settings.TradersXml.AddRange(aryTradersOut)
                My.Settings.ServicesXml.Clear()
                My.Settings.ServicesXml.AddRange(aryServicesOut)
                My.Settings.Save()
            End If
        Catch Ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        Finally
            ' Check this again, since we need to make sure we didn't throw an exception on open.
            If (objReader IsNot Nothing) Then
                objReader.Close()
            End If
        End Try
        MessageBox.Show("File imported OK" & vbCrLf & "Your Trader and Transaction lists should now contain the data from the text file.", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        frmHelp.Visible = True
        frmHelp.Activate()
    End Sub
    Private Sub NewManualBillingSessionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewManualBillingSessionToolStripMenuItem.Click
        '******Old Code*************************************************
        'If Microsoft.VisualBasic.Strings.Right(strDataSourceFilePath, 1) <> "\" Then
        'strDataSourceFilePath = strDataSourceFilePath & "\"
        'End If
        'Dim TraderFile As String = strDataSourceFilePath & strDataSourceFileTraders
        'Dim TradersElementsPerLine As Integer = 2 'zero numbered number of elements in each line
        'Dim aryTextLineTraders(TradersElementsPerLine) As String
        'Dim TransItemsFile As String = strDataSourceFilePath & strDataSourceFileServices
        'Dim TransItemsElementsPerLine As Integer = 3 'zero numbered number of elements in each line
        'Dim aryTextLineTransItems(TransItemsElementsPerLine) As String
        'Dim TextLine As String = vbNullString
        'Dim i As Integer = 0 'lines in file
        'Dim x As Integer = 0 'elements in line
        'check Traders file exists open it and read each line and populate trader list box
        'If System.IO.File.Exists(TraderFile) = True Then
        'Dim objReader As New System.IO.StreamReader(TraderFile)
        'Do While objReader.Peek() <> -1
        'TextLine = objReader.ReadLine()
        'split the line and place elements in arrays
        'aryTextLineTraders = TextLine.Split(",") 'comma seperated
        'ReDim Preserve aryTraderName(i)
        'ReDim Preserve aryTraderAccount(i)
        'ReDim Preserve aryTraderRent(i)
        'For x = 0 To UBound(aryTextLineTraders)
        'Select Case x
        '   Case 0
        'aryTraderName(i) = aryTextLineTraders(x)
        '   Case 1
        'aryTraderAccount(i) = aryTextLineTraders(x)
        '   Case 2
        'aryTraderRent(i) = aryTextLineTraders(x)
        'End Select
        'Next x
        'ListBoxTraders.Items.Add(aryTraderName(i))
        'i = i + 1
        'MsgBox(aryTraderName(i))
        'Loop
        'objReader.Close()
        'Else
        'MsgBox("File Does Not Exist")
        'Exit Sub
        'End If
        'x = 0
        'i = 0
        'TextLine = ""
        'check Transaction Items  file exists open it and read each line and populate Tran Items list box
        'If System.IO.File.Exists(TransItemsFile) = True Then
        'Dim objReader As New System.IO.StreamReader(TransItemsFile)
        'Do While objReader.Peek() <> -1
        'TextLine = objReader.ReadLine()
        'split the line and place elements in arrays
        'aryTextLineTransItems = TextLine.Split(",") 'comma seperated
        'ReDim Preserve aryTransItemName(i)
        'ReDim Preserve aryTransItemDefQty(i)
        'ReDim Preserve aryTransItemDefCost(i)
        'ReDim Preserve aryTransItemPostAcc(i)
        'For x = 0 To UBound(aryTextLineTransItems)
        'Select Case x
        'Case 0
        '     aryTransItemName(i) = aryTextLineTransItems(x)
        '  Case 1
        '       aryTransItemDefQty(i) = aryTextLineTransItems(x)
        '    Case 2
        '         aryTransItemDefCost(i) = aryTextLineTransItems(x)
        '      Case 3
        '           aryTransItemPostAcc(i) = aryTextLineTransItems(x)
        '    End Select
        ' Next x
        '  ListBoxServices.Items.Add(aryTransItemName(i))
        '   i = i + 1
        'Loop
        ' objReader.Close()

        'Else
        '  MsgBox("File Does Not Exist")
        '   Exit Sub
        'End If
        '*****NEw Code************************************
        blnBillingSession = True
        GrandTotal = 0
        'disable the refresh buttons
        btnTradersRefresh.Visible = False
        btnServicesRefresh.Visible = False
        NewManualBillingSessionToolStripMenuItem.Enabled = False ' make sure its not selected again
        CampingInvoiceFileImportToolStripMenuItem.Enabled = False ' make sure its not selected again
        SettingsToolStripMenuItem.Enabled = False 'make sure setting are not changed mid stream
        'clear the two list boxes in case they have left overs
        ListBoxTraders.Items.Clear()
        ListBoxServices.Items.Clear()
        'disable the services list for the moment until a trader is selected
        ListBoxServices.Enabled = False
        ListBoxServices.Visible = False
        'Code to extract trader data from settings file and populate listview
        PopulateTraders()
        'Code to extract services data from settings file and populate listview
        PopulateServices()
        'MANAGE CONTROLS
        lblSelTrader.Text = "Select Trader (" & ListBoxTraders.Items.Count & ")"
        lblSelTrader.ForeColor = Color.Blue
        lblSelTrader.Visible = True
        lblSelService.Visible = False
        lblSelService.Text = "Select Service (" & ListBoxServices.Items.Count & ")"
        ListViewProgress.Visible = False
        ListViewProgress.Clear()
        ' Set the Progress view to show details.
        ListViewProgress.View = View.Details  'important
        ' Allow the user to edit item text.
        ListViewProgress.LabelEdit = True
        ' Allow the user to rearrange columns.
        ListViewProgress.AllowColumnReorder = True
        ' Display check boxes.
        ListViewProgress.CheckBoxes = True
        ' Select the item and subitems when selection is made.
        ListViewProgress.FullRowSelect = True
        ' Display grid lines.
        ListViewProgress.GridLines = True
        ' Sort the items in the list in ascending order.
        ListViewProgress.Sorting = SortOrder.Ascending
        'ListViewProgress.View = View.Details  'important
    End Sub

    Private Sub CampingInvoiceFileImportToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CampingInvoiceFileImportToolStripMenuItem.Click
        'Advise user how camping billing works and allow escape.
        If MessageBox.Show("You are about to process raw billing data that you have previously extracted from the RMS camping management system" & vbCrLf & "You should have your .txt file already saved to a file location that you can access." & vbCrLf & "You will soon be asked to browse to the billing file." & vbCrLf & "Do You Wish To Continue?", "Foreshore Camping Debtors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        'Check that the user actually has the text file handy
        If MessageBox.Show("Your settings indicate that you will print..." & vbCrLf & strCampingInvLeadText & vbCrLf & "Are you sure wish to proceed now to import the RMS Camping bookings data from your pre-prepared text file?", "Foreshore Camping Debtors", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        'Find out where the camping invoice file is and create a file dialog to browse to the file
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Camping File Import"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "CSV files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        fdlg.FilterIndex = 1  'use the first filter defined above as the default
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim x As String = fdlg.FileName
            If System.IO.File.Exists(fdlg.FileName) = False Then
                MsgBox("File does not exist")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        'Start a stream reader to read the file
        Dim objReader As New System.IO.StreamReader(fdlg.FileName)
        Dim i As Integer = 0   'i will be the line number read from the file
        '???????start an array to hold the data as it is read from the file
        'Dim aryCampingRaw() As String
        'aryCampingRaw = New String() {"x"}   'need to put something in the array to start it off.
        '?????????????????
        Dim intElementsInArray As Integer 'Holds the number of elements in each readline
        'start an array to hold the output data as it is built from the data we are reading
        Dim aryCampingTransactionsOut() As String
        aryCampingTransactionsOut = New String() {"x"}
        'Prpare variable for the output billing file
        Dim intCampingTransactionsOutCounter As Integer = 0  'This will be incremented prior to storing the first transaction leaving element 0 as x for the moment which will be used later to store the transaction file header
        Dim decCampingTransactionsOutTotal = 0 'This will accumulate the total valu of the file to be used later in the header
        Dim intBadAccNo As Integer = 0  'These are used to report on common problems with data
        Dim intBadTariff As Integer = 0
        Dim intMissAccNo As Integer = 0
        Dim intGoodLine As Integer = 0 'Use to record the number of lines with valid data

        Try
            If (objReader IsNot Nothing) Then
                'Code to read the stream here.
                Do While objReader.Peek() <> -1
                    Dim ReadLine As String = objReader.ReadLine()
                    'MsgBox("ReadLine=" & ReadLine)
                    If i = 0 Then 'check that the first line for correct headers to prove file is valid
                        If Strings.Left(ReadLine, 12) <> "Debtors A/C:" Then 'this should be the first element of the first line
                            MsgBox("There is an error with the file syntax in line " & i & vbCrLf & "Finding  " & ReadLine & "   instead of Debtors A/C:  " & vbCrLf & "You have probably selected the wrong file.")
                            Exit Sub
                        End If
                        If ReadLine <> "Debtors A/C:,TitleGivenSurname,Reservation_No,Site,Arrive_Date_Short,Depart_Date_Short,Nights,Deposit_Amt,Tariff" Then
                            MessageBox.Show("First line of file is not as expected." & vbCrLf & "Seeing... " & ReadLine & vbCrLf & " but expecting... Debtors_A/C:,TitleGivenSurname,Res_No,Site,Arr_Date_Short,Dep_Date_Short,Nights,Deposit_Amt,Tariff", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            Exit Sub
                        Else 'File is valid so we can prepare a few things
                            'Each read line is a comma seperated string
                            intElementsInArray = UBound(ReadLine.Split(","))  'should be = 8 (ie 9 elements)
                            'Turn off Billing Menu Item options so they can't be selected again
                            'disable the refresh buttons
                            btnTradersRefresh.Visible = False
                            btnServicesRefresh.Visible = False
                            NewManualBillingSessionToolStripMenuItem.Enabled = False ' make sure its not selected again
                            CampingInvoiceFileImportToolStripMenuItem.Enabled = False ' make sure its not selected again
                            SettingsToolStripMenuItem.Enabled = False 'make sure the settings are not changed mid stream
                            ToolStripMenuItem1.Enabled = False
                            UpdateToolStripMenuItem.Enabled = False
                        End If
                    Else  'READ THE SECOND & SUBSEQUENT LINES WHICH WILL BE THE FIRST LINE OF DATA
                        'Code here to examine the right hand end of the readline for unwanted commas used as thousands seperator
                        'We are going to strip out any unnecessary comma's as thousands seperators in two potential places
                        'STEP 1.
                        Dim intDollarSpot As Integer = 0  'this will be the first position where a $ sign is found in the string reading from the right
zRestartAnalysisPoint:
                        '                        For z = 1 To Len(ReadLine)
                        '                            Select Case z
                        '                                Case 1 To 2 'should be both numeric ie 00 23 etc
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - z, 1)) Then  ' the last two characters should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case 3
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - z, 1) = "." Then  'should be a decimal point
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " third last character ought to be a .  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case 4 ' this is potentially 9 dollars but should be alway numeric
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - z, 1)) Then  ' the character should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case 5 To 10 ' these are potentially numeric characters and we need to keep going until we find a dollar sign but could be ,$ or 99 or $9
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - z, 1)) Then  ' the character should be numeric
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - z, 1) = "$" Then 'there was no thousands comma found
                        '                                        intDollarSpot = z 'first dollar sign is found from right end of string
                        '                                        Exit For
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - z, 1) = "," Then 'this comma has to be deleted
                        '                                        ReadLine = Strings.Left(ReadLine, Len(ReadLine) - z) & Strings.Right(ReadLine, z - 1)
                        '                                        GoTo zRestartAnalysisPoint
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case Else
                        '                            End Select
                        '                        Next z
                        '                        'STEP2
                        'yRestartAnalysisPoint:
                        '                        For y = intDollarSpot To Len(ReadLine)
                        '                            Select Case y
                        '                                Case intDollarSpot 'should be a $
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "$" Then  ' this is the dollar form the tarriff
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 1 'should be a ,
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "," Then  ' this comma is a good one
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 2 To intDollarSpot + 3 'should be both numeric ie 00 23 etc
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - y, 1)) Then  ' the last two characters should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 4
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "." Then  'should be a decimal point
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " ought to be a . in the deposit  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 5 ' this is potentially 9 dollars but should be alway numeric
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - y, 1)) Then  ' the character should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 6 To intDollarSpot + 11 ' these are potentially numeric characters and we need to keep going until we find a dollar sign but could be ,$ or 99 or $9
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - y, 1)) Then  ' the character should be numeric
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "$" Then 'there was no thousands comma found
                        '                                        intDollarSpot = y 'second dollar sign is found from right end of string, stop checking now
                        '                                        Exit For
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "," Then 'this comma has to be deleted
                        '                                        ReadLine = Strings.Left(ReadLine, Len(ReadLine) - y) & Strings.Right(ReadLine, y - 1)
                        '                                        GoTo yRestartAnalysisPoint
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case Else
                        '                            End Select
                        '                        Next y
                        '                        'We should now have a readline that should not have too many commas in it
                        'Read the first line of the input file, split on commas and place into a temp array
                        'Each line will look like... Debtors_A/C:,TitleGivenSurname,Res_No,Site,Arr_Date_Short,Dep_Date_Short,Nights,Deposit_Amt,Tariff
                        Dim aryReadLine() = ReadLine.Split(",") 'each line is a comma seperated string
                        If UBound(aryReadLine) <> intElementsInArray Then 'something is very wrong
                            MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " An extra comma was found in the data and couldn't be removed." & vbCrLf & "Your Billing Session will end", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        End If
                        'From this data we need to pick out and cleanup some of the data
                        If aryReadLine(0) = "" Then
                            intMissAccNo = intMissAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                        ElseIf aryReadLine(0) = " " Then
                            intMissAccNo = intMissAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                        ElseIf Strings.Left(aryReadLine(0), 3) <> "A28" Then
                            intBadAccNo = intBadAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                        ElseIf Len(aryReadLine(0)) <> 9 Then
                            intBadAccNo = intBadAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                            'ElseIf aryReadLine(8) = "0" Then
                            '   intBadTariff = intBadTariff + 1
                            '  GoTo ShortCCt 'Lines with no tariff need to be skipped
                        End If
                        Dim RawAmt As Decimal = 0
                        'If Strings.Left(aryReadLine(8), 1) = "$" Then  'get rid of the leading $ sign
                        RawAmt = Strings.Right(aryReadLine(8), Strings.Len(aryReadLine(8)))
                        'Else
                        'MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " Expecting a dollar sign in the Tariff" & vbCrLf & "Your Billing Session will end", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        'Exit Sub
                        'End If
                        If RawAmt = 0 Then  'All Tariffs ought to be more than zero
                            MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " The Tariff has ended up zero at this point" & vbCrLf & "Your Billing Session will end", "Foreshore Camping Debtors", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            Exit Sub
                            End If
                            Dim RawDeposit As Decimal = 0
                        'If Strings.Left(aryReadLine(7), 1) = "$" Then  'get rid of the leading $ sign
                        RawDeposit = Strings.Right(aryReadLine(7), Strings.Len(aryReadLine(7)))
                        'Else
                        'MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " Expecting a dollar sign in the Deposit" & vbCrLf & "Your Billing Session will end", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        'Exit Sub
                        'End If
                        Dim Nights As Integer = 0
                            If IsNumeric(aryReadLine(6)) Then  'convert to integer
                                Nights = CInt(aryReadLine(6))
                            Else
                            MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " Expecting an integer for the nights value" & vbCrLf & "Your Billing Session will end", "Foreshore Camping Debtors", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            Exit Sub
                            End If
                            Dim TariffComponent As Decimal
                            Dim GSTComponent As Decimal
                            GSTComponent = CampingGSTCalc(RawAmt, aryReadLine(6))  'uses the CampingGSTCalc user function to calculate the GST component
                            TariffComponent = RawAmt - GSTComponent
                            Dim TariffDesc As String
                            TariffDesc = strCampingInvLeadText & " Reservation_No: " & aryReadLine(2) & "  Site: " & aryReadLine(3) & ".  Arrival_date: " & aryReadLine(4) & ".  Departure_date: " & aryReadLine(5) & ".  Total_nights: " & aryReadLine(6)
                            Dim DepositDesc As String
                            Dim DepositComponent As Decimal
                            If RawDeposit > 0 Then
                                DepositDesc = "Deposit/Payments already received: ($" & RawDeposit & ")"
                                DepositComponent = RawDeposit * -1 'convert to negative
                            Else
                                DepositDesc = "No pre-payments:"
                                DepositComponent = 0
                            End If
                            Dim GSTDesc As String
                            GSTDesc = "GST payable on Tariff"
                            intGoodLine = intGoodLine + 1
                            'From this data we need to generate three transactions for the output file, one for the charge, one for the deposit and one for the GST
                            Dim OutputLine1 As String = ""
                            Dim OutputLine2 As String = ""
                            Dim OutputLine3 As String = "" 'the GST component
                            Dim TransType As String = "debinvoice"
                            Dim TransReference As String = ""
                            TransReference = "Reservation# " & aryReadLine(2) 'Reservation No
                            'Generate First Transaction of the triple  Amount
                            OutputLine1 = aryReadLine(0) & "||||||||"
                            OutputLine1 = OutputLine1 & strCampingDebtorType & "|" & dtTransDate & "|"
                            OutputLine1 = OutputLine1 & TransReference & "|" & TransType & "|"
                            OutputLine1 = OutputLine1 & TariffComponent & "|||" & TariffDesc & "|||"
                        OutputLine1 = OutputLine1 & strCampingIncomeAcct '****** COMMENT OUT TO REMOVE GL ACCOUNT **************
                        'Generate Second Transaction of the triple Deposit
                        OutputLine2 = aryReadLine(0) & "||||||||"
                            OutputLine2 = OutputLine2 & strCampingDebtorType & "|" & dtTransDate & "|"
                            OutputLine2 = OutputLine2 & TransReference & "|" & TransType & "|"
                            OutputLine2 = OutputLine2 & DepositComponent & "|||" & DepositDesc & "|||"
                        OutputLine2 = OutputLine2 & strCampingDepositAcct
                        'Generate THird Transaction of the pair  GST
                        OutputLine3 = aryReadLine(0) & "||||||||"
                            OutputLine3 = OutputLine3 & strCampingDebtorType & "|" & dtTransDate & "|"
                            OutputLine3 = OutputLine3 & TransReference & "|" & TransType & "|"
                            OutputLine3 = OutputLine3 & GSTComponent & "|||" & GSTDesc & "|||"
                            OutputLine3 = OutputLine3 & strCampingGSTAcct
                            'Keep building the output array that will be used to build the output file
                            intCampingTransactionsOutCounter = intCampingTransactionsOutCounter + 1 'increment counter
                            ReDim Preserve aryCampingTransactionsOut(intCampingTransactionsOutCounter)
                            aryCampingTransactionsOut(intCampingTransactionsOutCounter) = OutputLine1
                            listBoxTransList.Items.Add(aryCampingTransactionsOut(intCampingTransactionsOutCounter)) 'add a line to the listbox to show the user
                            intCampingTransactionsOutCounter = intCampingTransactionsOutCounter + 1 'increment counter
                            ReDim Preserve aryCampingTransactionsOut(intCampingTransactionsOutCounter)
                            aryCampingTransactionsOut(intCampingTransactionsOutCounter) = OutputLine2
                            listBoxTransList.Items.Add(aryCampingTransactionsOut(intCampingTransactionsOutCounter)) 'add a line to the listbox to show the user
                            intCampingTransactionsOutCounter = intCampingTransactionsOutCounter + 1 'increment counter
                            ReDim Preserve aryCampingTransactionsOut(intCampingTransactionsOutCounter)
                            aryCampingTransactionsOut(intCampingTransactionsOutCounter) = OutputLine3
                            listBoxTransList.Items.Add(aryCampingTransactionsOut(intCampingTransactionsOutCounter)) 'add a line to the listbox to show the user
                            'Tally the total file value
                            decCampingTransactionsOutTotal = decCampingTransactionsOutTotal + TariffComponent + DepositComponent + GSTComponent
                            'MessageBox.Show("OutputLine1 = " & OutputLine1 & vbCrLf & "OutputLine2 = " & OutputLine2 & vbCrLf & "OutputLine3 = " & OutputLine3 & vbCrLf & "Tally = " & decCampingTransactionsOutTotal, "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
ShortCCt:
                        End If
                        i = i + 1
                Loop
            End If
        Catch Ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        Finally
            ' Check this again, since we need to make sure we didn't throw an exception on open.
            If (objReader IsNot Nothing) Then
                objReader.Close()
            End If
        End Try
        'Add the header info to element 0 of the transaction array
        aryCampingTransactionsOut(0) = strCampingDebtorType & "|" & decCampingTransactionsOutTotal
        'Advise user of outcome and next steps they should take
        MessageBox.Show("Transaction Listing Now Complete" & vbCrLf & _
            "There were " & i - 1 & " lines of data read from the file." & vbCrLf & _
            "There were " & intBadAccNo & " lines with bad account numbers" & vbCrLf & _
            "There were " & intMissAccNo & " lines with missing account numbers." & vbCrLf & _
            "There were " & intBadTariff & " lines with zero tariff's." & vbCrLf & _
            "There were " & intGoodLine & " lines with valid data." & vbCrLf & _
            "There are " & intCampingTransactionsOutCounter & " transactions with a total value of $" & decCampingTransactionsOutTotal & vbCrLf & _
            "~", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
        'Let the transactions be written to a file.
        Dim MsgOK As String
        Dim FileOK As Boolean = False
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\"
        Dim mydocName As String
        mydocName = strDataFileNameStub & "_" & strUser
        mydocName = mydocName & "_" & DateTime.Today.Day & DateTime.Today.Month & DateTime.Today.Year
        mydocName = mydocName & ".txt"
        Dim Path As String = mydocpath & mydocName
        MsgOK = MsgBox("Create File For Import to Property and Rating Sundry Debtors?" & vbCrLf & vbCrLf &
               "Click Yes to continue and create the file." & vbCrLf & vbCrLf &
               "Click No to Cancel.", vbYesNo, "Foreshore Camping Debtors")
        If MsgOK = vbYes Then
            If System.IO.File.Exists(Path) = False Then
                ' Create a file to write the records into.
                Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                For l As Integer = 0 To UBound(aryCampingTransactionsOut)
                    sw.WriteLine(aryCampingTransactionsOut(l))
                Next l
                sw.Flush()
                sw.Close()
                FileOK = True
            ElseIf System.IO.File.Exists(Path) = True Then  'this would occur if the file existed and the user would be prompted to overwrite
                MsgOK = MsgBox("File " & mydocName & " exists in " & mydocpath & "." & vbCrLf &
               "Click OK to overwite file." & vbCrLf &
               "Click Cancel for some other choice that hasn't been thought of yet!", vbOKCancel, "Foreshore Camping Debtors")
                If MsgOK = vbOK Then
                    ' Create a file to write records into.
                    Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                    For l As Integer = 0 To UBound(aryCampingTransactionsOut)
                        sw.WriteLine(aryCampingTransactionsOut(l))
                    Next l
                    sw.Flush()
                    sw.Close()
                    FileOK = True
                Else
                    FileOK = False
                End If
            End If
        End If
        If FileOK = True Then
            MessageBox.Show("Transaction File Now Complete" & vbCrLf & "File is located on your computer ... " & Path & vbCrLf & "It would pay to manually validate the file has the correct format.", "Foreshore Camping Debtors", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            MessageBox.Show("File not written." & vbCrLf & "Something went wrong." & Path & vbCrLf & "Try again later perhaps.", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If

    End Sub
    Public Function CampingGSTCalc(ByVal TotFeeInclGST As Decimal, ByVal StayDays As Integer)
        'Function to calculate concessional GST on camping stays longer than 27 days.
        'The first 27 days are taxed normally at 10%
        'The remaining days (max 10 weeks so 43 days) have the rate halved then taxed at 10% AND
        'Then that amount is added to the daily GST excluded rate.
        'In our case our rate/day is set by council as including GST so we have to work out
        'how much we GST we have to pay as it won't always be a flat 10%
        If StayDays = 0 Or TotFeeInclGST = 0 Then
            CampingGSTCalc = 0            ' Exit to calling procedure.
        ElseIf StayDays < 28 Then
            CampingGSTCalc = Math.Round(TotFeeInclGST / 11, 2) 'Divide by 11 to calculate GST and then round to 2 places
        ElseIf StayDays > 27 Then
            Dim DailyChargeIncGST As Decimal
            Dim FirstPeriodGST As Decimal
            Dim SecondPeriodGST As Decimal
            DailyChargeIncGST = TotFeeInclGST / StayDays
            'DailyChargeExclGST = TotFeeInclGST / StayDays / 1.1  'interesting but irelevant
            FirstPeriodGST = 27 * DailyChargeIncGST / 11
            'For the remaining days after the first 27...
            'You halve the daily charge which includes GST...
            'then calculate 10% of it. (yes its tax on tax technically at this point)
            'you would then add this concessional GST that you just calculated onto the daily rate EXcluding GST
            'Perhaps strange but true according to the ATO
            SecondPeriodGST = (StayDays - 27) * DailyChargeIncGST / 2 / 10
            CampingGSTCalc = Math.Round(FirstPeriodGST + SecondPeriodGST, 2)
        Else
            CampingGSTCalc = 0
        End If

    End Function

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CampingInvoiceFileImportAdjustmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampingInvoiceFileImportAdjustmentToolStripMenuItem.Click
        'Advise user how camping billing works and allow escape.
        If MessageBox.Show("You are about to process raw billing data that you have previously extracted from the RMS camping management system" & vbCrLf & "You should have your .txt file already saved to a file location that you can access." & vbCrLf & "You will soon be asked to browse to the billing file." & vbCrLf & "Do You Wish To Continue?", "Foreshore Camping Debtors Reversal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        'Check that the user actually has the text file handy
        If MessageBox.Show("Your settings indicate that you will print..." & vbCrLf & strCampingInvLeadText & vbCrLf & "Are you sure wish to proceed with the creation of the RMS Camping reversal of bookings file from your pre-prepared text file?", "Foreshore Camping Debtors Reversal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        'Find out where the camping invoice file is and create a file dialog to browse to the file
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Camping Reversal File Import"
        fdlg.InitialDirectory = "c:\"
        fdlg.Filter = "CSV files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        fdlg.FilterIndex = 1  'use the first filter defined above as the default
        fdlg.RestoreDirectory = True
        If fdlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim x As String = fdlg.FileName
            If System.IO.File.Exists(fdlg.FileName) = False Then
                MsgBox("File does not exist")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
        'Start a stream reader to read the file
        Dim objReader As New System.IO.StreamReader(fdlg.FileName)
        Dim i As Integer = 0   'i will be the line number read from the file
        '???????start an array to hold the data as it is read from the file
        'Dim aryCampingRaw() As String
        'aryCampingRaw = New String() {"x"}   'need to put something in the array to start it off.
        '?????????????????
        Dim intElementsInArray As Integer 'Holds the number of elements in each readline
        'start an array to hold the output data as it is built from the data we are reading
        Dim aryCampingTransactionsOut() As String
        aryCampingTransactionsOut = New String() {"x"}
        'Prpare variable for the output billing file
        Dim intCampingTransactionsOutCounter As Integer = 0  'This will be incremented prior to storing the first transaction leaving element 0 as x for the moment which will be used later to store the transaction file header
        Dim decCampingTransactionsOutTotal = 0 'This will accumulate the total valu of the file to be used later in the header
        Dim intBadAccNo As Integer = 0  'These are used to report on common problems with data
        Dim intBadTariff As Integer = 0
        Dim intMissAccNo As Integer = 0
        Dim intGoodLine As Integer = 0 'Use to record the number of lines with valid data

        Try
            If (objReader IsNot Nothing) Then
                'Code to read the stream here.
                Do While objReader.Peek() <> -1
                    Dim ReadLine As String = objReader.ReadLine()
                    'MsgBox("ReadLine=" & ReadLine)
                    If i = 0 Then 'check that the first line for correct headers to prove file is valid
                        If Strings.Left(ReadLine, 12) <> "Debtors A/C:" Then 'this should be the first element of the first line
                            MsgBox("There is an error with the file syntax in line " & i & vbCrLf & "Finding  " & ReadLine & "   instead of Debtors A/C:  " & vbCrLf & "You have probably selected the wrong file.")
                            Exit Sub
                        End If
                        If ReadLine <> "Debtors A/C:,TitleGivenSurname,Reservation_No,Site,Arrive_Date_Short,Depart_Date_Short,Nights,Deposit_Amt,Tariff" Then
                            MessageBox.Show("First line of file is not as expected." & vbCrLf & "Seeing... " & ReadLine & vbCrLf & " but expecting... Debtors_A/C:,TitleGivenSurname,Res_No,Site,Arr_Date_Short,Dep_Date_Short,Nights,Deposit_Amt,Tariff", "Foreshore Camping Debtors Reversal", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            Exit Sub
                        Else 'File is valid so we can prepare a few things
                            'Each read line is a comma seperated string
                            intElementsInArray = UBound(ReadLine.Split(","))  'should be = 8 (ie 9 elements)
                            'Turn off Billing Menu Item options so they can't be selected again
                            'disable the refresh buttons
                            btnTradersRefresh.Visible = False
                            btnServicesRefresh.Visible = False
                            NewManualBillingSessionToolStripMenuItem.Enabled = False ' make sure its not selected again
                            CampingInvoiceFileImportToolStripMenuItem.Enabled = False ' make sure its not selected again
                            SettingsToolStripMenuItem.Enabled = False 'make sure the settings are not changed mid stream
                            ToolStripMenuItem1.Enabled = False
                            UpdateToolStripMenuItem.Enabled = False
                        End If
                    Else  'READ THE SECOND & SUBSEQUENT LINES WHICH WILL BE THE FIRST LINE OF DATA
                        'Code here to examine the right hand end of the readline for unwanted commas used as thousands seperator
                        'We are going to strip out any unnecessary comma's as thousands seperators in two potential places
                        'STEP 1.
                        Dim intDollarSpot As Integer = 0  'this will be the first position where a $ sign is found in the string reading from the right
zRestartAnalysisPoint:
                        '                        For z = 1 To Len(ReadLine)
                        '                            Select Case z
                        '                                Case 1 To 2 'should be both numeric ie 00 23 etc
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - z, 1)) Then  ' the last two characters should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case 3
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - z, 1) = "." Then  'should be a decimal point
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " third last character ought to be a .  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case 4 ' this is potentially 9 dollars but should be alway numeric
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - z, 1)) Then  ' the character should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case 5 To 10 ' these are potentially numeric characters and we need to keep going until we find a dollar sign but could be ,$ or 99 or $9
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - z, 1)) Then  ' the character should be numeric
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - z, 1) = "$" Then 'there was no thousands comma found
                        '                                        intDollarSpot = z 'first dollar sign is found from right end of string
                        '                                        Exit For
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - z, 1) = "," Then 'this comma has to be deleted
                        '                                        ReadLine = Strings.Left(ReadLine, Len(ReadLine) - z) & Strings.Right(ReadLine, z - 1)
                        '                                        GoTo zRestartAnalysisPoint
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case Else
                        '                            End Select
                        '                        Next z
                        '                        'STEP2
                        'yRestartAnalysisPoint:
                        '                        For y = intDollarSpot To Len(ReadLine)
                        '                            Select Case y
                        '                                Case intDollarSpot 'should be a $
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "$" Then  ' this is the dollar form the tarriff
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 1 'should be a ,
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "," Then  ' this comma is a good one
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 2 To intDollarSpot + 3 'should be both numeric ie 00 23 etc
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - y, 1)) Then  ' the last two characters should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " last two characters ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 4
                        '                                    If Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "." Then  'should be a decimal point
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " ought to be a . in the deposit  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 5 ' this is potentially 9 dollars but should be alway numeric
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - y, 1)) Then  ' the character should be numeric
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case intDollarSpot + 6 To intDollarSpot + 11 ' these are potentially numeric characters and we need to keep going until we find a dollar sign but could be ,$ or 99 or $9
                        '                                    If IsNumeric(Mid(ReadLine, Len(ReadLine) + 1 - y, 1)) Then  ' the character should be numeric
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "$" Then 'there was no thousands comma found
                        '                                        intDollarSpot = y 'second dollar sign is found from right end of string, stop checking now
                        '                                        Exit For
                        '                                    ElseIf Mid(ReadLine, Len(ReadLine) + 1 - y, 1) = "," Then 'this comma has to be deleted
                        '                                        ReadLine = Strings.Left(ReadLine, Len(ReadLine) - y) & Strings.Right(ReadLine, y - 1)
                        '                                        GoTo yRestartAnalysisPoint
                        '                                    Else
                        '                                        MsgBox("There is an error with the file syntax in line " & i & vbCrLf & " character ought to be numeric  " & ReadLine(i) & "" & vbCrLf & "You have probably selected the wrong file.")
                        '                                        Exit Sub
                        '                                    End If
                        '                                Case Else
                        '                            End Select
                        '                        Next y
                        '                        'We should now have a readline that should not have too many commas in it
                        'Read the first line of the input file, split on commas and place into a temp array
                        'Each line will look like... Debtors_A/C:,TitleGivenSurname,Res_No,Site,Arr_Date_Short,Dep_Date_Short,Nights,Deposit_Amt,Tariff
                        Dim aryReadLine() = ReadLine.Split(",") 'each line is a comma seperated string
                        If UBound(aryReadLine) <> intElementsInArray Then 'something is very wrong
                            MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " An extra comma was found in the data and couldn't be removed." & vbCrLf & "Your Billing Session will end", "Foreshore Camping Debtors Reversal", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        End If
                        'From this data we need to pick out and cleanup some of the data
                        If aryReadLine(0) = "" Then
                            intMissAccNo = intMissAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                        ElseIf aryReadLine(0) = " " Then
                            intMissAccNo = intMissAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                        ElseIf Strings.Left(aryReadLine(0), 3) <> "A28" Then
                            intBadAccNo = intBadAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                        ElseIf Len(aryReadLine(0)) <> 9 Then
                            intBadAccNo = intBadAccNo + 1
                            GoTo ShortCCt 'Lines with no account number need to be skipped
                            'ElseIf aryReadLine(8) = "0" Then
                            '   intBadTariff = intBadTariff + 1
                            '  GoTo ShortCCt 'Lines with no tariff need to be skipped
                        End If
                        Dim RawAmt As Decimal = 0
                        'If Strings.Left(aryReadLine(8), 1) = "$" Then  'get rid of the leading $ sign
                        RawAmt = Strings.Right(aryReadLine(8), Strings.Len(aryReadLine(8)))
                        'Else
                        'MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " Expecting a dollar sign in the Tariff" & vbCrLf & "Your Billing Session will end", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        'Exit Sub
                        'End If
                        If RawAmt = 0 Then  'All Tariffs ought to be more than zero
                            MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " The Tariff has ended up zero at this point" & vbCrLf & "Your Billing Session will end", "Foreshore Camping Debtors Reversal", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            Exit Sub
                        End If
                        Dim RawDeposit As Decimal = 0
                        'If Strings.Left(aryReadLine(7), 1) = "$" Then  'get rid of the leading $ sign
                        RawDeposit = Strings.Right(aryReadLine(7), Strings.Len(aryReadLine(7)))
                        'Else
                        'MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " Expecting a dollar sign in the Deposit" & vbCrLf & "Your Billing Session will end", "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        'Exit Sub
                        'End If
                        Dim Nights As Integer = 0
                        If IsNumeric(aryReadLine(6)) Then  'convert to integer
                            Nights = CInt(aryReadLine(6))
                        Else
                            MessageBox.Show("There is a problem with data in line " & i & vbCrLf & " Expecting an integer for the nights value" & vbCrLf & "Your Billing Session will end", "Foreshore Camping Debtors Reversal", MessageBoxButtons.OK, MessageBoxIcon.Question)
                            Exit Sub
                        End If
                        Dim TariffComponent As Decimal
                        Dim GSTComponent As Decimal
                        GSTComponent = CampingGSTCalc(RawAmt, aryReadLine(6))   'uses the CampingGSTCalc user function to calculate the GST component
                        TariffComponent = RawAmt - GSTComponent
                        GSTComponent = GSTComponent * -1 'convert to negative
                        TariffComponent = TariffComponent * -1 'convert to negative
                        Dim TariffDesc As String
                        TariffDesc = strCampingWithdrawLeadText & " Reservation_No: " & aryReadLine(2) & "  Site: " & aryReadLine(3) & ".  Arrival_date: " & aryReadLine(4) & ".  Departure_date: " & aryReadLine(5) & ".  Total_nights: " & aryReadLine(6)
                        Dim DepositDesc As String
                        Dim DepositComponent As Decimal
                        If RawDeposit > 0 Then
                            DepositDesc = "Reversal of Deposit/Payments already received: ($" & RawDeposit & ")"
                            DepositComponent = RawDeposit  'convert to negative
                        Else
                            DepositDesc = "No pre-payments:"
                            DepositComponent = 0
                        End If
                        Dim GSTDesc As String
                        GSTDesc = "Withdrawal of GST payable on Tariff"
                        intGoodLine = intGoodLine + 1
                        'From this data we need to generate three transactions for the output file, one for the charge, one for the deposit and one for the GST
                        Dim OutputLine1 As String = ""
                        Dim OutputLine2 As String = ""
                        Dim OutputLine3 As String = "" 'the GST component
                        Dim TransType As String = "debadjust"
                        Dim TransReference As String = ""
                        TransReference = "Reservation# " & aryReadLine(2) 'Reservation No
                        'Generate First Transaction of the triple  Amount
                        OutputLine1 = aryReadLine(0) & "||||||||"
                        OutputLine1 = OutputLine1 & strCampingDebtorType & "|" & dtTransDate & "|"
                        OutputLine1 = OutputLine1 & TransReference & "|" & TransType & "|"
                        OutputLine1 = OutputLine1 & TariffComponent & "|||" & TariffDesc & "|||"
                        OutputLine1 = OutputLine1 & strCampingIncomeAcct '****** COMMENT OUT TO REMOVE GL ACCOUNT **************
                        'Generate Second Transaction of the triple Deposit
                        OutputLine2 = aryReadLine(0) & "||||||||"
                        OutputLine2 = OutputLine2 & strCampingDebtorType & "|" & dtTransDate & "|"
                        OutputLine2 = OutputLine2 & TransReference & "|" & TransType & "|"
                        OutputLine2 = OutputLine2 & DepositComponent & "|||" & DepositDesc & "|||"
                        OutputLine2 = OutputLine2 & strCampingDepositAcct
                        'Generate THird Transaction of the pair  GST
                        OutputLine3 = aryReadLine(0) & "||||||||"
                        OutputLine3 = OutputLine3 & strCampingDebtorType & "|" & dtTransDate & "|"
                        OutputLine3 = OutputLine3 & TransReference & "|" & TransType & "|"
                        OutputLine3 = OutputLine3 & GSTComponent & "|||" & GSTDesc & "|||"
                        OutputLine3 = OutputLine3 & strCampingGSTAcct
                        'Keep building the output array that will be used to build the output file
                        intCampingTransactionsOutCounter = intCampingTransactionsOutCounter + 1 'increment counter
                        ReDim Preserve aryCampingTransactionsOut(intCampingTransactionsOutCounter)
                        aryCampingTransactionsOut(intCampingTransactionsOutCounter) = OutputLine1
                        listBoxTransList.Items.Add(aryCampingTransactionsOut(intCampingTransactionsOutCounter)) 'add a line to the listbox to show the user
                        intCampingTransactionsOutCounter = intCampingTransactionsOutCounter + 1 'increment counter
                        ReDim Preserve aryCampingTransactionsOut(intCampingTransactionsOutCounter)
                        aryCampingTransactionsOut(intCampingTransactionsOutCounter) = OutputLine2
                        listBoxTransList.Items.Add(aryCampingTransactionsOut(intCampingTransactionsOutCounter)) 'add a line to the listbox to show the user
                        intCampingTransactionsOutCounter = intCampingTransactionsOutCounter + 1 'increment counter
                        ReDim Preserve aryCampingTransactionsOut(intCampingTransactionsOutCounter)
                        aryCampingTransactionsOut(intCampingTransactionsOutCounter) = OutputLine3
                        listBoxTransList.Items.Add(aryCampingTransactionsOut(intCampingTransactionsOutCounter)) 'add a line to the listbox to show the user
                        'Tally the total file value
                        decCampingTransactionsOutTotal = decCampingTransactionsOutTotal + TariffComponent + DepositComponent + GSTComponent
                        'MessageBox.Show("OutputLine1 = " & OutputLine1 & vbCrLf & "OutputLine2 = " & OutputLine2 & vbCrLf & "OutputLine3 = " & OutputLine3 & vbCrLf & "Tally = " & decCampingTransactionsOutTotal, "MP Billing at your service", MessageBoxButtons.OK, MessageBoxIcon.Question)
ShortCCt:
                    End If
                    i = i + 1
                Loop
            End If
        Catch Ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        Finally
            ' Check this again, since we need to make sure we didn't throw an exception on open.
            If (objReader IsNot Nothing) Then
                objReader.Close()
            End If
        End Try
        'Add the header info to element 0 of the transaction array
        aryCampingTransactionsOut(0) = strCampingDebtorType & "|" & decCampingTransactionsOutTotal
        'Advise user of outcome and next steps they should take
        MessageBox.Show("Transaction Listing Now Complete" & vbCrLf &
            "There were " & i - 1 & " lines of data read from the file." & vbCrLf &
            "There were " & intBadAccNo & " lines with bad account numbers" & vbCrLf &
            "There were " & intMissAccNo & " lines with missing account numbers." & vbCrLf &
            "There were " & intBadTariff & " lines with zero tariff's." & vbCrLf &
            "There were " & intGoodLine & " lines with valid data." & vbCrLf &
            "There are " & intCampingTransactionsOutCounter & " transactions with a total value of $" & decCampingTransactionsOutTotal & vbCrLf &
            "~", "MP Foreshore Camping Billing", MessageBoxButtons.OK, MessageBoxIcon.Question)
        'Let the transactions be written to a file.
        Dim MsgOK As String
        Dim FileOK As Boolean = False
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\"
        Dim mydocName As String
        mydocName = strDataFileNameWithdraw & "_" & strUser
        mydocName = mydocName & "_" & DateTime.Today.Day & DateTime.Today.Month & DateTime.Today.Year
        mydocName = mydocName & ".txt"
        Dim Path As String = mydocpath & mydocName
        MsgOK = MsgBox("Ready to create the reversal file for import into Property and Rating Sundry Debtors?" & vbCrLf & vbCrLf &
               "Click Yes to continue and create the file." & vbCrLf & vbCrLf &
               "Click No to Cancel.", vbYesNo, "Foreshore Camping Debtors Reversal")
        If MsgOK = vbYes Then
            If System.IO.File.Exists(Path) = False Then
                ' Create a file to write the records into.
                Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                For l As Integer = 0 To UBound(aryCampingTransactionsOut)
                    sw.WriteLine(aryCampingTransactionsOut(l))
                Next l
                sw.Flush()
                sw.Close()
                FileOK = True
            ElseIf System.IO.File.Exists(Path) = True Then  'this would occur if the file existed and the user would be prompted to overwrite
                MsgOK = MsgBox("File " & mydocName & " exists in " & mydocpath & "." & vbCrLf &
               "Click OK to overwite file." & vbCrLf &
               "Click Cancel to abort the operation.", vbOKCancel, "Foreshore Camping Debtors Reversal")
                If MsgOK = vbOK Then
                    ' Create a file to write records into.
                    Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                    For l As Integer = 0 To UBound(aryCampingTransactionsOut)
                        sw.WriteLine(aryCampingTransactionsOut(l))
                    Next l
                    sw.Flush()
                    sw.Close()
                    FileOK = True
                Else
                    FileOK = False
                End If
            End If
        End If
        If FileOK = True Then
            MessageBox.Show("Transaction File Now Complete" & vbCrLf & "File is located on your computer ... " & Path & vbCrLf & "It would pay to manually validate the file has the correct format.", "Foreshore Camping Debtors Reversal", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            MessageBox.Show("File not written." & vbCrLf & "Something went wrong." & Path & vbCrLf & "Correct any Problems & Try Again.", "Foreshore Camping Debtors Reversal", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If

    End Sub
End Class

