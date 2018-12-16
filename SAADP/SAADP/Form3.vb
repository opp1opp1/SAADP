Public Class check_out
    Private Sub check_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Detail1.Text = Detail1.Text + vbCrLf + Form1.checkout_detail
        Label1.Text = Label1.Text + vbCrLf + Format(Form1.checkout_price)
    End Sub
End Class