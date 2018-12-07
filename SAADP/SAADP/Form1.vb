Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Burger1.Click '按下卡啦雞腿堡' 
        RichTextBox1.Text = Burger1.Text + vbCrLf + RichTextBox1.Text '將卡啦雞腿堡輸入在品項'

        Price.Text = 45 + Val(Price.Text) '輸入價錢 價錢為45 由於Price的文字是字串所以先轉換成數字'

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
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Burger8.Click
        RichTextBox1.Text = Burger8.Text + vbCrLf + RichTextBox1.Text '將牛肉蛋堡輸入在品項'

        Price.Text = 35 + Val(Price.Text) '輸入價錢 價錢為35 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Burger7_Click_1(sender As Object, e As EventArgs) Handles Burger7.Click
        RichTextBox1.Text = Burger7.Text + vbCrLf + RichTextBox1.Text '將總匯輸入在品項'

        Price.Text = 35 + Val(Price.Text) '輸入價錢 價錢為35 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '按下結帳按鈕'
        RichTextBox1.Text = "" '清空品項'
        Price.Text = "" '清空價錢'
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Drink1_Click(sender As Object, e As EventArgs) Handles Drink1.Click
        RichTextBox1.Text = Drink1.Text + vbCrLf + RichTextBox1.Text '將總匯輸入在品項'

        Price.Text = 35 + Val(Price.Text)
    End Sub

    Private Sub Drink2_Click(sender As Object, e As EventArgs) Handles Drink2.Click
        RichTextBox1.Text = Drink2.Text + vbCrLf + RichTextBox1.Text '將總匯輸入在品項'

        Price.Text = 35 + Val(Price.Text)
    End Sub

    Private Sub Drink3_Click(sender As Object, e As EventArgs) Handles Drink3.Click
        RichTextBox1.Text = Drink3.Text + vbCrLf + RichTextBox1.Text '將總匯輸入在品項'

        Price.Text = 35 + Val(Price.Text)
    End Sub

    Private Sub Drink4_Click(sender As Object, e As EventArgs) Handles Drink4.Click
        RichTextBox1.Text = Drink4.Text + vbCrLf + RichTextBox1.Text '將總匯輸入在品項'

        Price.Text = 35 + Val(Price.Text)
    End Sub
End Class
