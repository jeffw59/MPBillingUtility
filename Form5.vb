Public Class frmHelp

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Visible = True
        RichTextBox2.Visible = False
        RichTextBox3.Visible = False
        RichTextBox4.Visible = False
        RichTextBox5.Visible = False
        RichTextBox6.Visible = False
        RichTextBox7.Visible = False
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Visible = False
        RichTextBox2.Visible = True
        RichTextBox3.Visible = False
        RichTextBox4.Visible = False
        RichTextBox5.Visible = False
        RichTextBox6.Visible = False
        RichTextBox7.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        RichTextBox3.Visible = True
        RichTextBox4.Visible = False
        RichTextBox5.Visible = False
        RichTextBox6.Visible = False
        RichTextBox7.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        RichTextBox3.Visible = False
        RichTextBox4.Visible = True
        RichTextBox5.Visible = False
        RichTextBox6.Visible = False
        RichTextBox7.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        RichTextBox3.Visible = False
        RichTextBox4.Visible = False
        RichTextBox5.Visible = True
        RichTextBox6.Visible = False
        RichTextBox7.Visible = False
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        RichTextBox3.Visible = False
        RichTextBox4.Visible = False
        RichTextBox5.Visible = False
        RichTextBox6.Visible = True
        RichTextBox7.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        RichTextBox3.Visible = False
        RichTextBox4.Visible = False
        RichTextBox5.Visible = False
        RichTextBox6.Visible = False
        RichTextBox7.Visible = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class