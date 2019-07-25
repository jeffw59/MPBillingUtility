<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSourceDataEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSourceDataEdit))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCol2 = New System.Windows.Forms.TextBox()
        Me.txtCol1 = New System.Windows.Forms.TextBox()
        Me.txtCol3 = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCol4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(26, 32)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(350, 156)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(161, 253)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 22)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCol2
        '
        Me.txtCol2.Enabled = False
        Me.txtCol2.Location = New System.Drawing.Point(127, 213)
        Me.txtCol2.Name = "txtCol2"
        Me.txtCol2.Size = New System.Drawing.Size(87, 20)
        Me.txtCol2.TabIndex = 4
        '
        'txtCol1
        '
        Me.txtCol1.Enabled = False
        Me.txtCol1.Location = New System.Drawing.Point(26, 213)
        Me.txtCol1.Name = "txtCol1"
        Me.txtCol1.Size = New System.Drawing.Size(95, 20)
        Me.txtCol1.TabIndex = 3
        '
        'txtCol3
        '
        Me.txtCol3.Enabled = False
        Me.txtCol3.Location = New System.Drawing.Point(220, 213)
        Me.txtCol3.Name = "txtCol3"
        Me.txtCol3.Size = New System.Drawing.Size(77, 20)
        Me.txtCol3.TabIndex = 5
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(26, 250)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(66, 25)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(312, 253)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 24)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(303, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 27)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Exit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCol4
        '
        Me.txtCol4.Enabled = False
        Me.txtCol4.Location = New System.Drawing.Point(303, 213)
        Me.txtCol4.Name = "txtCol4"
        Me.txtCol4.Size = New System.Drawing.Size(73, 20)
        Me.txtCol4.TabIndex = 6
        '
        'frmSourceDataEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 336)
        Me.Controls.Add(Me.txtCol4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtCol3)
        Me.Controls.Add(Me.txtCol1)
        Me.Controls.Add(Me.txtCol2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSourceDataEdit"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCol2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCol1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCol3 As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCol4 As System.Windows.Forms.TextBox
End Class
