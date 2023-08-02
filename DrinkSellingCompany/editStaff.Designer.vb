<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStaff
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Crimson
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(68, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 22)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "PHONE"
        '
        'txtphone
        '
        Me.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphone.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(69, 366)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(333, 36)
        Me.txtphone.TabIndex = 42
        Me.txtphone.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(472, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 42)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "ADD STAFF"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Crimson
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(431, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "GENDER"
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.SystemColors.Control
        Me.txtgender.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtgender.Location = New System.Drawing.Point(432, 292)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(336, 33)
        Me.txtgender.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Crimson
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(65, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 22)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "ROLE"
        '
        'txtrole
        '
        Me.txtrole.BackColor = System.Drawing.SystemColors.Control
        Me.txtrole.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtrole.FormattingEnabled = True
        Me.txtrole.Items.AddRange(New Object() {"Admin", "Not Admin"})
        Me.txtrole.Location = New System.Drawing.Point(66, 292)
        Me.txtrole.Name = "txtrole"
        Me.txtrole.Size = New System.Drawing.Size(336, 33)
        Me.txtrole.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(428, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "PASSWORD"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(429, 125)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(333, 36)
        Me.txtpassword.TabIndex = 33
        Me.txtpassword.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(431, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "LAST NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Crimson
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(68, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "FIRST NAME"
        '
        'txtfirstname
        '
        Me.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfirstname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(64, 202)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(325, 36)
        Me.txtfirstname.TabIndex = 29
        Me.txtfirstname.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 18.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(342, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "UPDATE STAFF"
        '
        'txtlastname
        '
        Me.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlastname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(432, 202)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(325, 36)
        Me.txtlastname.TabIndex = 31
        Me.txtlastname.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 49)
        Me.Panel1.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(63, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(336, 33)
        Me.ComboBox1.TabIndex = 44
        '
        'editStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 467)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editStaff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtphone As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtgender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrole As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpassword As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfirstname As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlastname As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
