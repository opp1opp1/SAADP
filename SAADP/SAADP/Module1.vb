'Module Module1
'    Imports System.Data.SQLite

'    Public Class Form1

'        Dim conn As SQLiteConnection

'        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

'            If System.IO.File.Exists("test.db3") = True Then

'                System.IO.File.Delete("test.db3")

'            End If

'            SQLiteConnection.CreateFile("test.db3")

'            conn = New SQLiteConnection("Data Source=POSSQL.db;Pooling=true;FailIfMissing=false")

'            If conn.State <> ConnectionState.Open Then

'                conn.Open()

'                MsgBox("打开成功！")

'            End If
'            MsgBox("conn failed!")




'            Dim sql As New SQLiteCommand

'            sql.Connection = conn

'            sql.CommandText = "CREATE TABLE Test (ID INTEGER PRIMARY KEY,TestName VARCHAR(500),TestTime DateTime,Operator VARCHAR(100))"

'            Dim result As Integer = cmd.ExecuteNonQuery()

'            If result = 0 Then

'                MsgBox("成功")

'            Else

'                MsgBox("失败")

'            End If



'            cmd = conn.CreateCommand()

'            cmd.CommandText = "insert into Test(TestName,TestTime,Operator)values(@Name,@TestTime,@Operator)" '"insert into 資料表名稱 (entitiy,entity,entity)values(@值,@值,@質)"'

'            cmd.Parameters.Add("@Name", Data.DbType.String).Value = "动静"

'            cmd.Parameters.Add("@TestTime", Data.DbType.DateTime).Value = Now()

'            cmd.Parameters.Add("@Operator", Data.DbType.String).Value = "peer"

'            result = cmd.ExecuteNonQuery()

'            If result <> 0 Then

'                MsgBox("插入成功")

'            End If

'            'SelectShowInfo()



'            '

'            cmd = conn.CreateCommand()

'            cmd.CommandText = "Update Test set TestName ='動靜一'"

'            result = cmd.ExecuteNonQuery()

'            If result <> 0 Then

'                MsgBox("更新成功")

'            End If

'            'SelectShowInfo()



'            '



'            cmd = conn.CreateCommand()

'            cmd.CommandText = "delete from Test"

'            result = cmd.ExecuteNonQuery()

'            If result <> 0 Then

'                MsgBox("删除成功")

'            End If

'            'SelectShowInfo()



'            cmd.Dispose()



'            If conn.State = ConnectionState.Open Then

'                conn.Close()

'            End If

'        End Sub



'        'Public Sub SelectShowInfo()

'        'Dim sa As New SQLiteDataAdapter("select * from Test", conn)

'        'Dim ds As New System.Data.DataSet

'        'sa.Fill(ds, "Test")

'        'Dim mytable As New System.Data.DataTable

'        ' mytable = ds.Tables("Test")

'        'Me.DataGridView1.DataSource = mytable

'        'Me.DataGridView1.Refresh()

'        ' End Sub

'    End Class
'End Module
