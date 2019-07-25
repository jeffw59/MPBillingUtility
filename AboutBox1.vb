Public NotInheritable Class AboutBox

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.lblProductName.Text = My.Application.Info.ProductName
        'Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.lblVersion.Text = "Version " & My.Application.Info.Version.ToString  'Version is set in properties assembly information
        Me.lblCopyright.Text = My.Application.Info.Copyright
        Me.lblCompanyName.Text = My.Application.Info.CompanyName
        'Me.txtBoxDescription.Text = My.Application.Info.Description
        Me.txtBoxDescription.Text = "This application will allow the user to create billing data suitable for direct upload into the Sundry Debtors system" _
        & vbCrLf & "There are two methods. " _
        & vbCrLf & "(1) Manually using lists of traders and services or" _
        & vbCrLf & "(2) Automaticaly from a text file exported from the RMS Camping Bookings system." & vbCrLf _
        & vbCrLf & "To start, choose the method you want from the Billing menu " & vbCrLf _
        & "Trader and services data can be updated by choosing File - Update..." & vbCrLf _
        & vbCrLf & "Please contact Greg Brough for further information. (04 1812 8146)"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
