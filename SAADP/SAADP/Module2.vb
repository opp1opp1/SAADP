﻿Imports System.Data.SQLite
Module Module2
    Public Conn As SQLiteConnection
    Sub Connection()

        Conn = New SQLiteConnection("Data Source=POSSQL.db;Pooling=true;FailIfMissing=false")
        'If Conn.State <> ConnectionState.Open Then

        Conn.Open()

        'MsgBox("打开成功！")

        'End If
        'MsgBox("conn failed!")
    End Sub

    Sub Selection(ByRef Name As String, ByRef Price As Integer, ByRef Id As Integer)
        Call Connection()

        Dim sql As New SQLiteCommand With {
            .Connection = Conn
        }

        sql = Conn.CreateCommand()

        sql.CommandText = "insert into 'CART' (Cname,Cprice,Cpid)values(@Name,@Price,@Cpid);"
        sql.Parameters.Add("@Name", Data.DbType.String).Value = Name

        sql.Parameters.Add("@Price", Data.DbType.Int16).Value = Price

        sql.Parameters.Add("@Cpid", Data.DbType.Int16).Value = Id

        Dim result As Integer = sql.ExecuteNonQuery()

        sql.CommandText = "insert into 'ORDERS' (Oname,Oprice,Opid)values(@Name,@Price,@Cpid);"
        sql.Parameters.Add("@Name", Data.DbType.String).Value = Name

        sql.Parameters.Add("@Price", Data.DbType.Int16).Value = Price

        sql.Parameters.Add("@Cpid", Data.DbType.Int16).Value = Id

        result = sql.ExecuteNonQuery()

        'If result = 1 Then

        '    MsgBox("成功")

        'Else

        '    MsgBox(result)

        'End If

    End Sub

    Sub Clear()
        Call Connection()

        Dim sql As New SQLiteCommand With {
            .Connection = Conn
        }

        sql = Conn.CreateCommand()

        sql.CommandText = "DELETE FROM 'CART' ;"
        Dim result As Integer = sql.ExecuteNonQuery()
        'If result <> 0 Then

        'MsgBox("删除成功")

        'Else
        '    MsgBox("删除失敗")

        'End If

    End Sub

    Sub Pay()
        Call Connection()
        Dim sql As New SQLiteCommand With {
            .Connection = Conn
        }

        sql = Conn.CreateCommand()

        For i = 1 To 26
            sql.CommandText = "UPDATE PRODUCTS Set SoldQuantity=SoldQuantity+(Select count(Cpid) FROM CART where CART.Cpid=(@num) ) WHERE PRODUCTS.pid = (@num)"
            sql.Parameters.Add("@num", Data.DbType.Int16).Value = i
            Dim result As Integer = sql.ExecuteNonQuery()
        Next i

        'sql.CommandText = "update PRODUCTS SET SoldQuantity = SoldQuantity+1 where ( SELECT Cid From CART  WHERE CART.Cname=PRODUCTS.Pname);" '結帳 不要弄'

    End Sub

    Sub Totalreport()

        Call Module2.Connection()
        Dim sql As New SQLiteCommand With {
            .Connection = Conn
        }

        sql = Conn.CreateCommand()


        sql.CommandText = "SELECT Pname, Size, count(Price) FROM PRODUCTS GROUP BY Pname, Size ORDER BY Pname, Size"
        Dim result As Integer = sql.ExecuteNonQuery()
        MsgBox(result)


    End Sub


End Module
