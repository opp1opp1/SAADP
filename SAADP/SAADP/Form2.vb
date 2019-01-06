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
        Call Module2.Connection()
        Dim sa As New SQLiteDataAdapter("SELECT Pname, Size, sum(soldquantity*price) FROM PRODUCTS GROUP BY Pname, Size ORDER BY Pname, Size;", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

    Public Sub sellSelectShowinfo() '銷售數量排行'
        Call Module2.Connection()
        Dim sa As New SQLiteDataAdapter("SELECT Pname, Size, sum(soldquantity*price) FROM PRODUCTS GROUP BY Pname, Size ORDER BY Pname, Size;", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

    Public Sub singleSelectShowInfo() '單品項查詢'
        Call Module2.Connection()
        Dim sa As New SQLiteDataAdapter("SELECT Pname, Size, sum(soldquantity*price) FROM PRODUCTS GROUP BY Pname, Size ORDER BY Pname, Size;", Conn)
        Dim ds As New System.Data.DataSet
        sa.Fill(ds, "Test")
        Dim mytable As New System.Data.DataTable
        mytable = ds.Tables("Test")
        Me.DataGridView1.DataSource = mytable
        Me.DataGridView1.Refresh()
    End Sub

End Class