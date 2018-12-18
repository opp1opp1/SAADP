Public Class ChangeAdminPassword
    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        RichTextBox1.Text = RichTextBox1.Text + Num1.Text '將數字一輸入進密碼'
    End Sub
    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        RichTextBox1.Text = RichTextBox1.Text + Num2.Text   '將數字二輸入進密碼'
    End Sub
    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        RichTextBox1.Text = RichTextBox1.Text + Num3.Text '將數字三輸入進密碼'
    End Sub
    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        RichTextBox1.Text = RichTextBox1.Text + Num4.Text '將數字四輸入進密碼'
    End Sub
    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        RichTextBox1.Text = RichTextBox1.Text + Num5.Text '將數字五輸入進密碼'
    End Sub
    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        RichTextBox1.Text = RichTextBox1.Text + Num6.Text '將數字六輸入進密碼'
    End Sub
    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        RichTextBox1.Text = RichTextBox1.Text + Num7.Text '將數字七輸入進密碼'
    End Sub
    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        RichTextBox1.Text = RichTextBox1.Text + Num8.Text '將數字八輸入進密碼'
    End Sub
    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        RichTextBox1.Text = RichTextBox1.Text + Num9.Text '將數字九輸入進密碼'
    End Sub
    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        RichTextBox1.Text = RichTextBox1.Text + Num0.Text '將數字十輸入進密碼'
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        RichTextBox1.Text = "" '清除已輸入的密碼'
    End Sub

    Private Sub Button_enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        If Val(RichTextBox1.Text) = Form1.Admin_password Then
            Close()
        Else
            Form1.Admin_password = Val(RichTextBox1.Text)  '更改密碼'
            My.Settings.Admin_Password = Val(RichTextBox1.Text)  '更改密碼'
        End If
    End Sub
End Class