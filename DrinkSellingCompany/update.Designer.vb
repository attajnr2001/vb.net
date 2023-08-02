<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbname = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcompany = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.RichTextBox()
        Me.txtnewprice = New System.Windows.Forms.RichTextBox()
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
        Me.Label2.Location = New System.Drawing.Point(284, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "UPDATE PRODUCT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NAME"
        '
        'cmbname
        '
        Me.cmbname.BackColor = System.Drawing.SystemColors.Control
        Me.cmbname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbname.FormattingEnabled = True
        Me.cmbname.Location = New System.Drawing.Point(82, 154)
        Me.cmbname.Name = "cmbname"
        Me.cmbname.Size = New System.Drawing.Size(323, 33)
        Me.cmbname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PRICE"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.Location = New System.Drawing.Point(82, 234)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(323, 36)
        Me.txtprice.TabIndex = 8
        Me.txtprice.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Crimson
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(423, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(424, 315)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(326, 36)
        Me.txtTotal.TabIndex = 12
        Me.txtTotal.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Crimson
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(426, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "COMPANY"
        '
        'cmbcompany
        '
        Me.cmbcompany.BackColor = System.Drawing.SystemColors.Control
        Me.cmbcompany.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cmbcompany.FormattingEnabled = True
        Me.cmbcompany.Location = New System.Drawing.Point(427, 154)
        Me.cmbcompany.Name = "cmbcompany"
        Me.cmbcompany.Size = New System.Drawing.Size(323, 33)
        Me.cmbcompany.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(303, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 42)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(430, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "NEW PRICE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Crimson
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(85, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 22)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "QUANTITY"
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(82, 315)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(323, 36)
        Me.txtQuantity.TabIndex = 17
        Me.txtQuantity.Text = ""
        '
        'txtnewprice
        '
        Me.txtnewprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnewprice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewprice.Location = New System.Drawing.Point(427, 234)
        Me.txtnewprice.Name = "txtnewprice"
        Me.txtnewprice.Size = New System.Drawing.Size(323, 36)
        Me.txtnewprice.TabIndex = 19
        Me.txtnewprice.Text = ""
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 479)
        Me.Controls.Add(Me.txtnewprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbcompany)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbname)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "update"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbname As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbcompany As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantity As RichTextBox
    Friend WithEvents txtnewprice As RichTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
