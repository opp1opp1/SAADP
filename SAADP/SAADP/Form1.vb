Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Burger1.Click '按下卡啦雞腿堡' 
        RichTextBox1.Text = Burger1.Text + vbCrLf + RichTextBox1.Text '將卡啦雞腿堡輸入在品項'

        Price.Text = 45 +  '輸入價錢 價錢為45 由於Price的文字是字串所以先轉換成數字'

    End Sub
    Private Sub Burger2_Click(sender As Object, e As EventArgs) Handles Burger2.Click '按下玉米蛋堡'
        RichTextBox1.Text = Burger2.Text + vbCrLf + RichTextBox1.Text '將玉米蛋堡輸入在品項'

        Price.Text = 25 + Val(Price.Text) '輸入價錢 價錢為25 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger3_Click(sender As Object, e As EventArgs) Handles Burger3.Click '按下肉鬆蛋堡'
        RichTextBox1.Text = Burger3.Text + vbCrLf + RichTextBox1.Text '將肉鬆蛋堡輸入在品項'

        Price.Text = 25 + Val(Price.Text) '輸入價錢 價錢為25 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger4_Click(sender As Object, e As EventArgs) Handles Burger4.Click '按下豬肉蛋堡'
        RichTextBox1.Text = Burger4.Text + vbCrLf + RichTextBox1.Text '將豬肉蛋堡輸入在品項'

        Price.Text = 30 + Val(Price.Text) '輸入價錢 價錢為30 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger5_Click(sender As Object, e As EventArgs) Handles Burger5.Click '按下烤肉蛋堡'
        RichTextBox1.Text = Burger5.Text + vbCrLf + RichTextBox1.Text '將烤肉蛋堡輸入在品項'

        Price.Text = 35 + Val(Price.Text) '輸入價錢 價錢為35 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger6_Click(sender As Object, e As EventArgs) Handles Burger6.Click '按下香雞蛋堡'
        RichTextBox1.Text = Burger6.Text + vbCrLf + RichTextBox1.Text '將香雞蛋堡輸入在品項'

        Price.Text = 35 + Val(Price.Text) '輸入價錢 價錢為35 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger7_Click(sender As Object, e As EventArgs)  '按下牛肉蛋堡'
        RichTextBox1.Text = Burger7.Text + vbCrLf + RichTextBox1.Text '將牛肉蛋堡輸入在品項'

        Price.Text = 35 + Val(Price.Text) '輸入價錢 價錢為35 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger8_Click(sender As Object, e As EventArgs)  '按下牛肉蛋堡'
        RichTextBox1.Text = Burger8.Text + vbCrLf + RichTextBox1.Text '將牛肉蛋堡輸入在品項'

        Price.Text = 40 + Val(Price.Text) '輸入價錢 價錢為40 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '按下結帳按鈕'
        RichTextBox1.Text = "" '清空品項'
        Price.Text = "" '清空價錢'
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
