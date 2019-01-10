Imports System.Data.SQLite
Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeAdminPassword.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call totalSelectShowInfo()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call sellSelectShowInfo()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call singleSelectShowInfo()

    End Sub
    Public Sub totalSelectShowInfo() '所有銷售數量'
        Call Module2.Connection()
        Dim sa As New SQLiteDataAdapter("SELECT Pname, Size,Soldquantity,sum(soldquantity*price) FROM PRODUCTS GROUP BY Pname, Size ORDER BY Pname, Size;", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

    Public Sub sellSelectShowinfo() '總營業額'
        Call Module2.Connection()
        Dim sa As New SQLiteDataAdapter("SELECT  sum(soldquantity*price) FROM PRODUCTS ;", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

    Public Sub singleSelectShowInfo() '某筆訂單查詢'
        MsgBox("包含在本POS之資訊得隨時不經通知變更。
Copyright © 2018-2019 OPAY Inc. All rights reserved.
OPAY Inc.,No.2, Ln. 183, Nanyao Rd., Changhua City, Changhua County 500, Taiwan (R.O.C.) ") '跳出提示畫面'
    End Sub

End Class