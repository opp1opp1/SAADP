<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check_out
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.item_label = New System.Windows.Forms.Label()
        Me.discount_label = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.Label()
        Me.unit_price = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.total_price = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'item_label
        '
        Me.item_label.AutoSize = True
        Me.item_label.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.item_label.Location = New System.Drawing.Point(35, 100)
        Me.item_label.Name = "item_label"
        Me.item_label.Size = New System.Drawing.Size(112, 25)
        Me.item_label.TabIndex = 0
        Me.item_label.Text = "消費清單"
        '
        'discount_label
        '
        Me.discount_label.AutoSize = True
        Me.discount_label.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.discount_label.Location = New System.Drawing.Point(35, 349)
        Me.discount_label.Name = "discount_label"
        Me.discount_label.Size = New System.Drawing.Size(112, 25)
        Me.discount_label.TabIndex = 1
        Me.discount_label.Text = "折價優惠"
        '
        'number
        '
        Me.number.AutoSize = True
        Me.number.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.number.Location = New System.Drawing.Point(346, 42)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(62, 25)
        Me.number.TabIndex = 2
        Me.number.Text = "數量"
        '
        'unit_price
        '
        Me.unit_price.AutoSize = True
        Me.unit_price.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.unit_price.Location = New System.Drawing.Point(222, 42)
        Me.unit_price.Name = "unit_price"
        Me.unit_price.Size = New System.Drawing.Size(62, 25)
        Me.unit_price.TabIndex = 3
        Me.unit_price.Text = "單價"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.price.Location = New System.Drawing.Point(474, 42)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(62, 25)
        Me.price.TabIndex = 4
        Me.price.Text = "金額"
        '
        'total_price
        '
        Me.total_price.AutoSize = True
        Me.total_price.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.total_price.Location = New System.Drawing.Point(257, 532)
        Me.total_price.Name = "total_price"
        Me.total_price.Size = New System.Drawing.Size(117, 34)
        Me.total_price.TabIndex = 5
        Me.total_price.Text = "總金額"
        '
        'check_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 678)
        Me.Controls.Add(Me.total_price)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.unit_price)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.discount_label)
        Me.Controls.Add(Me.item_label)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "check_out"
        Me.Text = "結帳"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents item_label As Label
    Friend WithEvents discount_label As Label
    Friend WithEvents number As Label
    Friend WithEvents unit_price As Label
    Friend WithEvents price As Label
    Friend WithEvents total_price As Label
End Class
