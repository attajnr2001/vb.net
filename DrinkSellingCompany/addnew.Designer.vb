<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addnew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 49)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 18.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(310, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SELL PRODUCT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Crimson
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(259, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PRODUCT NAME"
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(260, 113)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(325, 36)
        Me.txtname.TabIndex = 12
        Me.txtname.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(259, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PRICE"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(260, 196)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(325, 36)
        Me.txtprice.TabIndex = 14
        Me.txtprice.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(256, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "QUANTITY"
        '
        'txtquantity
        '
        Me.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(257, 271)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(325, 36)
        Me.txtquantity.TabIndex = 16
        Me.txtquantity.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(265, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 42)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "ADD NEW PRODUCT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'addnew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 428)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addnew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addnew"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtprice As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtquantity As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
