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
    Public Sub totalSelectShowInfo()
        Call Module2.Connection() '總營業額'
        Dim sa As New SQLiteDataAdapter("SELECT sum(soldquantity*price) FROM PRODUCTS ", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

    Public Sub sellSelectShowinfo() '產品銷售'
        Call Module2.Connection()
        Dim sa As New SQLiteDataAdapter("SELECT Pname, Size, SoldQUANTITY,sum(soldquantity*price) FROM PRODUCTS GROUP BY Pname, Size ORDER BY Pname, Size;", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

    Public Sub singleSelectShowInfo() '版本說明'
        MsgBox("Copyright © 2018-2019 SAADP Inc. 保留一切權利。")

    End Sub

End Class