
Public Class frmSourceDataEdit
    Dim blnAdd As Boolean
    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text.ToLower() = "add" Then 'if caption is ADD then perform Add process  
            txtCol1.Enabled = True
            txtCol2.Enabled = True
            txtCol3.Enabled = True
            If Me.Text = "Edit Services List" Then
                txtCol4.Visible = True
                txtCol4.Enabled = True
            End If
            btnAdd.Text = "Save"
            btnEdit.Text = "Cancel"
            btnDelete.Enabled = False
            txtCol1.Focus()
            txtCol1.Text = ""
            txtCol2.Text = ""
            txtCol3.Text = ""
            If Me.Text = "Edit Services List" Then
                txtCol4.Text = ""
            End If
            blnAdd = True
        Else 'save process  button is now in Save mode
            If txtCol1.Text = "" Or txtCol2.Text = "" Or txtCol3.Text = "" Then
                MsgBox("You need to fill in all the boxes", vbOKOnly, "Greg' Billing Gadget")
                Exit Sub
            End If
            If Me.Text = "Edit Services List" Then
                If txtCol4.Text = "" Then  'posting account
                    MsgBox("You need to fill in all the boxes", vbOKOnly, "Greg' Billing Gadget")
                    Exit Sub
                End If
                'If txtCol3.Text = "" Then  'dollars
                'MsgBox("You need to fill in all the boxes", vbOKOnly, "Greg' Billing Gadget")
                'Exit Sub
            End If
            txtCol1.Enabled = False
            txtCol2.Enabled = False
            txtCol3.Enabled = False
            If Me.Text = "Edit Services List" Then
                txtCol4.Visible = True
                txtCol4.Enabled = False
            End If
            btnAdd.Text = "Add"
            btnEdit.Text = "Edit"
            btnDelete.Enabled = True
            If blnAdd Then
                AddItemToListView()
            Else
                EditItemInListView()  ' button is in the save mode
            End If
            'clean out the txt boxes
            txtCol1.Text = ""
            txtCol2.Text = ""
            txtCol3.Text = ""
            If Me.Text = "Edit Services List" Then
                txtCol4.Text = ""
            End If
            btnSave.Text = "Confirm Changes"
        End If
    End Sub
    Private Sub AddItemToListView()
        'The first unique column is the root item  
        Dim lv As ListViewItem = ListView1.Items.Add(txtCol1.Text)
        'The remaining columns are subitems  
        lv.SubItems.Add(txtCol2.Text)
        lv.SubItems.Add(txtCol3.Text)
        If Me.Text = "Edit Services List" Then
            lv.SubItems.Add(txtCol4.Text)
        End If
    End Sub 
    Private Sub EditItemInListView()
        If ListView1.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify  
            If Me.Text = "Edit Traders List" Then
                ListView1.SelectedItems(0).Text = txtCol1.Text
                ListView1.SelectedItems(0).SubItems(1).Text = txtCol2.Text
                ListView1.SelectedItems(0).SubItems(2).Text = txtCol3.Text
            ElseIf Me.Text = "Edit Services List" Then
                ListView1.SelectedItems(0).Text = txtCol1.Text
                ListView1.SelectedItems(0).SubItems(1).Text = txtCol2.Text
                ListView1.SelectedItems(0).SubItems(2).Text = txtCol3.Text
                ListView1.SelectedItems(0).SubItems(3).Text = txtCol4.Text
            End If
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text.ToLower() = "edit" Then 'if caption is EDIT then perform EDIT process  
            If txtCol1.Text.Length > 0 Then
                txtCol1.Enabled = True
                txtCol2.Enabled = True
                txtCol3.Enabled = True
                If Me.Text = "Edit Services List" Then
                    txtCol4.Enabled = True
                End If
                btnAdd.Text = "Save"
                btnEdit.Text = "Cancel"
                btnDelete.Enabled = False
                blnAdd = False
            Else
                MessageBox.Show("Please select record to edit")
            End If
        Else 'cancel process      button is in Cancel Mode
            txtCol1.Enabled = False
            txtCol2.Enabled = False
            txtCol3.Enabled = False
            If Me.Text = "Edit Services List" Then
                txtCol4.Enabled = False
            End If
            btnAdd.Text = "Add"
            btnEdit.Text = "Edit"
            btnDelete.Enabled = True
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count > 0 AndAlso MessageBox.Show("Do you want to delete this item?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then 'make sure there is a selected item to delete  
            ListView1.SelectedItems(0).Remove()
        End If
        'clean out the txt boxes
        txtCol1.Text = ""
        txtCol2.Text = ""
        txtCol3.Text = ""
        If Me.Text = "Edit Services List" Then
            txtCol4.Text = ""
        End If
        btnSave.Text = "Confirm Changes"
    End Sub   
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            If Me.Text = "Edit Traders List" Then
                txtCol1.Text = ListView1.SelectedItems(0).Text
                txtCol2.Text = ListView1.SelectedItems(0).SubItems(1).Text
                txtCol3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            ElseIf Me.Text = "Edit Services List" Then
                txtCol1.Text = ListView1.SelectedItems(0).Text
                txtCol2.Text = ListView1.SelectedItems(0).SubItems(1).Text
                txtCol3.Text = ListView1.SelectedItems(0).SubItems(2).Text
                txtCol4.Text = ListView1.SelectedItems(0).SubItems(3).Text
            End If
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click    
        If btnSave.Text.ToLower() = "confirm changes" Then
            Dim Path As String = ""
            Dim aryOutFile(0) As String
            Dim FileOk As Boolean = False
            Dim MsgBoxResult As Integer = MsgBox("Your changes will be saved to the master file.", vbYesNo, "Greg's Billing Gadget")
            If MsgBoxResult = vbYes Then
                'We need to now transfer the contents of the list view into the correct text file.
                ListView1.Sorting = SortOrder.Ascending 'sort it alphabetically first
                If Me.Text = "Edit Traders List" Then 'we are editing the traders list
                    'Transfer contents of List View into array 3 columns
                    For i As Integer = 0 To ListView1.Items.Count - 1
                        ReDim Preserve aryOutFile(i)
                        Dim strBuild As String = ""
                        For si As Integer = 1 To My.Settings.TradersListCols - 1
                            strBuild = strBuild & "," & ListView1.Items(i).SubItems(si).Text
                        Next si
                        aryOutFile(i) = ListView1.Items(i).Text & strBuild
                    Next i
                    My.Settings.TradersXml.Clear()
                    My.Settings.TradersXml.AddRange(aryOutFile)
                    My.Settings.Save()
                    FileOk = True
                    frmMain.btnTradersRefresh.Visible = True
                    'Rename existing file to old file
                    'Path = frmMain.strDataSourceFilePath & frmMain.strDataSourceFileTraders
                    'If System.IO.File.Exists(Path) = True AndAlso MessageBox.Show("The existing Traders list will be overwritten?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then 'make sure there is a selected item to delete  
                    'If System.IO.File.Exists(frmMain.strDataSourceFilePath & "OldTraders.txt") Then
                    'My.Computer.FileSystem.DeleteFile(frmMain.strDataSourceFilePath & "OldTraders.txt")
                    'End If
                    'My.Computer.FileSystem.RenameFile(Path, "OldTraders.txt")
                    'End If
                    ' Create a file to write to.
                    'Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                    'For l As Integer = 0 To UBound(aryOutFile)
                    'sw.WriteLine(aryOutFile(l))
                    'Next l
                    'sw.Flush()
                    'sw.Close()
                    'FileOk = True
                ElseIf Me.Text = "Edit Services List" Then 'we are editing the services list
                    'Transfer contents of List View into array  4 columns
                    For i As Integer = 0 To ListView1.Items.Count - 1
                        ReDim Preserve aryOutFile(i)
                        Dim strBuild As String = ""
                        For si As Integer = 1 To My.Settings.ServicesListCols - 1
                            strBuild = strBuild & "," & ListView1.Items(i).SubItems(si).Text
                        Next si
                        aryOutFile(i) = ListView1.Items(i).Text & strBuild
                    Next i
                    My.Settings.ServicesXml.Clear()
                    My.Settings.ServicesXml.AddRange(aryOutFile)
                    My.Settings.Save()
                    FileOk = True
                    frmMain.btnServicesRefresh.Visible = True
                    'Rename existing file to old file
                    'Path = frmMain.strDataSourceFilePath & frmMain.strDataSourceFileServices
                    'If System.IO.File.Exists(Path) = True AndAlso MessageBox.Show("The existing Services list will be overwritten?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then 'make sure there is a selected item to delete  
                    'If System.IO.File.Exists(frmMain.strDataSourceFilePath & "OldServices.txt") Then
                    'My.Computer.FileSystem.DeleteFile(frmMain.strDataSourceFilePath & "OldServices.txt")
                    'End If
                    'My.Computer.FileSystem.RenameFile(Path, "OldServices.txt")
                    'End If
                    ' Create a file to write to.
                    'Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(Path)
                    'For l As Integer = 0 To UBound(aryOutFile)
                    'sw.WriteLine(aryOutFile(l))
                    'Next l
                    'sw.Flush()
                    'sw.Close()
                    'FileOk = True
                End If
                If FileOk Then MsgBox("Don't forget to refresh your lists", vbOKOnly, "Greg's MP-Billing Gadget")
            End If
            Me.Close()

        Else  'button was in exit mode
            Me.Close()
        End If
    End Sub
    Private Sub frmSourceDataEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'clear the listview
        ListView1.Clear()
        Dim ListCount As Integer = 0
        Dim Cols As Integer 'this is the number of columns in the listview
        Dim ColHead(Cols - 1) As String
        Dim ColWidth(Cols - 1) As String
        Dim itmListItem As ListViewItem
        If Me.Text = "Edit Services List" Then 'we are loading services
            Cols = My.Settings.ServicesListCols
            ListCount = My.Settings.ServicesXml.Count
            ReDim ColHead(Cols - 1)
            ReDim ColWidth(Cols - 1)
            ColHead(0) = "Service"
            ColHead(1) = "Def Qty"
            ColHead(2) = "Unit Cost"
            ColHead(3) = "Posting Account"
            ColWidth(0) = 150
            ColWidth(1) = 40
            ColWidth(2) = 40
            ColWidth(3) = 120
        Else  'we are loading traders
            Cols = My.Settings.TradersListCols
            ListCount = My.Settings.TradersXml.Count
            ReDim ColHead(Cols - 1)
            ReDim ColWidth(Cols - 1)
            ColHead(0) = "Trader"
            ColHead(1) = "Account"
            ColHead(2) = "Rent"
            ColWidth(0) = 150
            ColWidth(1) = 80
            ColWidth(2) = 65
        End If
        Dim lvwColumn As ColumnHeader
        For c As Integer = 0 To Cols - 1
            lvwColumn = New ColumnHeader()
            lvwColumn.Text = ColHead(c)
            lvwColumn.Width = ColWidth(c)
            ListView1.Columns.Add(lvwColumn)
        Next c
        'Code to populate listview
        Dim Readline As String
        Dim aryReadLine(Cols - 1) As String
        For i As Integer = 0 To ListCount - 1 'this would be the number of traders or services stored in the settings list
            If Me.Text = "Edit Services List" Then 'we are loading services
                Readline = My.Settings.ServicesXml(i)
            Else
                Readline = My.Settings.TradersXml(i)
            End If
            aryReadLine = Readline.Split(",")
            itmListItem = New ListViewItem()
            itmListItem.Text = aryReadLine(0)
            For c As Integer = 1 To Cols - 1
                itmListItem.SubItems.Add(aryReadLine(c))
            Next c
            ListView1.Items.Add(itmListItem)
        Next i
    End Sub
End Class
