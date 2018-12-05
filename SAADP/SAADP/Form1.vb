Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '按下卡啦雞腿堡' 
        RichTextBox1.Text = Button2.Text + vbCrLf + RichTextBox1.Text '將卡啦雞腿堡輸入在品項'

        Price.Text = 45 + Val(Price.Text) '輸入價錢 價錢為45 由於Price的文字是字串所以先轉換成數字'

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
        Price.Text = ""
    End Sub
End Class
