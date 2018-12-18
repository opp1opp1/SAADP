Public Class Form1
    Dim employee_meal As Boolean = False '員餐變數'
    Dim Promo_Item As Boolean = False 'Promo變數'
    Public checkout_detail As String '結帳時的品項'
    Public checkout_price As Integer '結帳時的金額'
    Public FHOTG As String  '是否內用變數'
    Private Sub Burger1_Click(sender As Object, e As EventArgs) Handles Burger1.Click '按下卡啦雞腿堡' 
        RichTextBox1.Text = Burger1.Text + vbCrLf + RichTextBox1.Text '將卡啦雞腿堡輸入在品項'

        Price.Text = 45 + Val(Price.Text)  '輸入價錢 價錢為45 由於Price的文字是字串所以先轉換成數字'

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
    Private Sub Burger7_Click(sender As Object, e As EventArgs) Handles Burger7.Click  '按下牛肉蛋堡'
        RichTextBox1.Text = Burger7.Text + vbCrLf + RichTextBox1.Text '將牛肉蛋堡輸入在品項'

        Price.Text = 35 + Val(Price.Text) '輸入價錢 價錢為35 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Burger8_Click(sender As Object, e As EventArgs) Handles Burger8.Click  '按下總匯蛋堡 '
        RichTextBox1.Text = Burger8.Text + vbCrLf + RichTextBox1.Text '將總匯蛋堡輸入在品項'

        Price.Text = 40 + Val(Price.Text) '輸入價錢 價錢為40 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Eggroll1_Click(sender As Object, e As EventArgs) Handles Eggroll1.Click '按下卡啦雞蛋餅'
        RichTextBox1.Text = Eggroll1.Text + vbCrLf + RichTextBox1.Text '將卡啦雞蛋餅輸入在品項'

        Price.Text = 40 + Val(Price.Text) '輸入價錢 價錢為40 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll2_Click(sender As Object, e As EventArgs) Handles Eggroll2.Click '按下玉米蛋餅'
        RichTextBox1.Text = Eggroll2.Text + vbCrLf + RichTextBox1.Text '將玉米蛋餅輸入在品項'

        Price.Text = 20 + Val(Price.Text) '輸入價錢 價錢為20 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll3_Click(sender As Object, e As EventArgs) Handles Eggroll3.Click '按下鮪魚蛋餅'
        RichTextBox1.Text = Eggroll3.Text + vbCrLf + RichTextBox1.Text '將鮪魚蛋餅輸入在品項'

        Price.Text = 20 + Val(Price.Text) '輸入價錢 價錢為20 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll4_Click(sender As Object, e As EventArgs) Handles Eggroll4.Click '按下豬肉蛋餅'
        RichTextBox1.Text = Eggroll4.Text + vbCrLf + RichTextBox1.Text '將豬肉蛋餅輸入在品項'

        Price.Text = 25 + Val(Price.Text) '輸入價錢 價錢為25 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll5_Click(sender As Object, e As EventArgs) Handles Eggroll5.Click '按下烤肉蛋餅'
        RichTextBox1.Text = Eggroll5.Text + vbCrLf + RichTextBox1.Text '將烤肉蛋餅輸入在品項'

        Price.Text = 30 + Val(Price.Text) '輸入價錢 價錢為30 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll6_Click(sender As Object, e As EventArgs) Handles Eggroll6.Click '按下香雞蛋餅'
        RichTextBox1.Text = Eggroll6.Text + vbCrLf + RichTextBox1.Text '將香雞蛋餅輸入在品項'

        Price.Text = 30 + Val(Price.Text) '輸入價錢 價錢為30 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll7_Click(sender As Object, e As EventArgs) Handles Eggroll7.Click '按下牛肉蛋餅'
        RichTextBox1.Text = Eggroll7.Text + vbCrLf + RichTextBox1.Text '將牛肉蛋餅輸入在品項'

        Price.Text = 30 + Val(Price.Text) '輸入價錢 價錢為30 由於Price的文字是字串所以先轉換成數字'
    End Sub
    Private Sub Eggroll8_Click(sender As Object, e As EventArgs) Handles Eggroll8.Click '按下泡菜蛋餅'
        RichTextBox1.Text = Eggroll8.Text + vbCrLf + RichTextBox1.Text '將泡菜蛋餅輸入在品項'

        Price.Text = 20 + Val(Price.Text) '輸入價錢 價錢為20 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '按下結帳按鈕'
        If FHOTG = "" Then
            MsgBox("尚未選取外帶內用") '跳出提示畫面'
        ElseIf Promo_Item Then '已按過PROMO的話'
            Price.Text = 0 '免費處理'
            checkout_detail = RichTextBox1.Text '儲存品項至checkout_detail變數內'
            checkout_price = Val(Price.Text) '儲存價錢至checkout_price變數內'
            check_out.Show() '跳出結帳視窗'
            RichTextBox1.Text = "" '清空品項'
            Price.Text = "" '清空價錢'
            employee_meal = False '重設是否按過員餐'
            Promo_Item = False '重設是否為招待物品'
            FHOTG = "" '重設外帶內用變數'
        ElseIf employee_meal Then '已按過員餐的話'
            Price.Text = Val(Price.Text) / 2 '做折價處理'
            checkout_detail = RichTextBox1.Text '儲存品項至checkout_detail變數內'
            checkout_price = Val(Price.Text) '儲存價錢至checkout_price變數內'
            check_out.Show() '跳出結帳視窗'
            RichTextBox1.Text = "" '清空品項'
            Price.Text = "" '清空價錢'
            employee_meal = False '重設是否按過員餐'
            Promo_Item = False '重設是否為招待物品'
            FHOTG = "" '重設外帶內用變數'
        Else
            checkout_detail = RichTextBox1.Text '儲存品項至checkout_detail變數內'
            checkout_price = Val(Price.Text) '儲存價錢至checkout_price變數內'
            check_out.Show() '跳出結帳視窗'
            RichTextBox1.Text = "" '清空品項'
            Price.Text = "" '清空價錢'
            employee_meal = False '重設是否按過員餐'
            Promo_Item = False '重設是否為招待物品'
            FHOTG = "" '重設外帶內用變數'
        End If
    End Sub

    Private Sub Drink1_Click(sender As Object, e As EventArgs) Handles Drink1.Click '按下奶茶'
        RichTextBox1.Text = Drink1.Text + vbCrLf + RichTextBox1.Text '將奶茶輸入在品項'

        Price.Text = 25 + Val(Price.Text) '輸入價錢 價錢為25 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Drink2_Click(sender As Object, e As EventArgs) Handles Drink2.Click '按下紅茶'
        RichTextBox1.Text = Drink2.Text + vbCrLf + RichTextBox1.Text '將紅茶輸入在品項'

        Price.Text = 15 + Val(Price.Text) '輸入價錢 價錢為15 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Drink3_Click(sender As Object, e As EventArgs) Handles Drink3.Click '按下綠茶'
        RichTextBox1.Text = Drink3.Text + vbCrLf + RichTextBox1.Text '將綠茶輸入在品項'

        Price.Text = 15 + Val(Price.Text) '輸入價錢 價錢為15 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Drink4_Click(sender As Object, e As EventArgs) Handles Drink4.Click '按下柳橙汁'
        RichTextBox1.Text = Drink4.Text + vbCrLf + RichTextBox1.Text '將柳橙汁輸入在品項'

        Price.Text = 25 + Val(Price.Text) '輸入價錢 價錢為25 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Drink5_Click(sender As Object, e As EventArgs) Handles Drink5.Click '按下豆漿'
        RichTextBox1.Text = Drink5.Text + vbCrLf + RichTextBox1.Text '將豆漿輸入在品項'

        Price.Text = 15 + Val(Price.Text) '輸入價錢 價錢為15 由於Price的文字是字串所以先轉換成數字'
    End Sub

    Private Sub Admin1_Click(sender As Object, e As EventArgs) Handles Admin1.Click
        RichTextBox1.Text = "" '清空品項'
        Price.Text = "" '清空價錢'
        employee_meal = False '重設是否按過員餐'
        Promo_Item = False '重設是否為招待物品'
        FHOTG = "" '重設外帶內用變數'
    End Sub

    Private Sub Admin2_Click(sender As Object, e As EventArgs) Handles Admin2.Click '按下PROMO按鈕'

        If Promo_Item Then '已按過員餐的話'
            MsgBox("此餐點已為招待餐點") '跳出提示畫面'
        ElseIf employee_meal Then
            MsgBox("此餐點已為員工餐") '跳出提示畫面'
        ElseIf Promo_Item = False Then   '判斷是否已按過PROMO'
            Promo_Item = True  '將PROMO變數設為TRUE'
            RichTextBox1.Text = "Promo" + vbCrLf + RichTextBox1.Text '將PROMO輸入進品項內'
        Else
            MsgBox("發生意外請聯絡程式開發人員並詳述您遭遇的問題") '處理意外'
        End If
    End Sub

    Private Sub Admin3_Click(sender As Object, e As EventArgs) Handles Admin3.Click '按下管理組選項按鈕'
        Form2.Show() '顯示管理組選項視窗'
    End Sub

    Private Sub Admin4_Click(sender As Object, e As EventArgs) Handles Admin4.Click '按下查看上筆按鈕'
        check_out.Show() '跳出結帳視窗'
    End Sub

    Private Sub Admin5_Click(sender As Object, e As EventArgs) Handles Admin5.Click '按下員工餐按鈕'

        If employee_meal Then '已按過員餐的話'
            MsgBox("此餐點已為員工餐") '跳出提示畫面'
        ElseIf Promo_Item = True Then
            MsgBox("此餐點已為招待餐點") '跳出提示畫面'
        ElseIf employee_meal = False Then   '判斷是否已按過員工餐'
            employee_meal = True  '將員餐變數設為TRUE'
            RichTextBox1.Text = "員餐" + vbCrLf + RichTextBox1.Text '將員餐輸入進品項內'
        Else
            MsgBox("發生意外請聯絡程式開發人員並詳述您遭遇的問題") '處理意外'
        End If
    End Sub

    Private Sub Admin6_Click(sender As Object, e As EventArgs) Handles Admin6.Click

    End Sub

    Private Sub Admin7_Click(sender As Object, e As EventArgs) Handles Admin7.Click '按下外帶按鈕'
        If FHOTG = "FH" Then '如果已按下內用'
            FHOTG = "TG" '修改變數為外帶'
            RichTextBox1.Text = RichTextBox1.Text.Replace(Admin8.Text, Admin7.Text) '取代原有的內用品項'
        ElseIf FHOTG = "TG" Then '如果已按下外帶'
            MsgBox("此餐點已經外帶") '跳出提示畫面'
        Else '如果第一次按下'
            FHOTG = "TG" '修改變數為外帶'
            RichTextBox1.Text = Admin7.Text + vbCrLf + RichTextBox1.Text '將外帶輸入在品項'
        End If
    End Sub

    Private Sub Admin8_Click(sender As Object, e As EventArgs) Handles Admin8.Click '按下內用按鈕'
        If FHOTG = "TG" Then '如果已按下外帶'
            FHOTG = "FH" '修改變數為內用'
            RichTextBox1.Text = RichTextBox1.Text.Replace(Admin7.Text, Admin8.Text) '取代原有的外帶品項'
        ElseIf FHOTG = "FH" Then '如果已按下內用'
            MsgBox("此餐點已經內用") '跳出提示畫面'
        Else
            FHOTG = "FH" '如果第一次按下'
            RichTextBox1.Text = Admin8.Text + vbCrLf + RichTextBox1.Text '將外帶輸入在品項'
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click '按下套餐飲料折價按鈕'
        Price.Text = -5 + Val(Price.Text) '折價'
        '檢查此操作是否會讓值為負，如果會令值為零'
        If Val(Price.Text) < 0 Then
            Price.Text = 0
        Else RichTextBox1.Text = "套餐折價" + vbCrLf + RichTextBox1.Text '如果不為負 則新增套餐折價在品項上'
        End If
    End Sub
End Class
