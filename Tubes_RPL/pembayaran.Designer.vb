<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pembayaran
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Simpan = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.Simpan)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1108, 638)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(320, 211)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(541, 36)
        Me.Guna2ComboBox1.TabIndex = 11
        '
        'Simpan
        '
        Me.Simpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Simpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Simpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Simpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Simpan.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Simpan.Font = New System.Drawing.Font("Product Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Simpan.ForeColor = System.Drawing.Color.White
        Me.Simpan.Location = New System.Drawing.Point(445, 471)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(180, 45)
        Me.Simpan.TabIndex = 9
        Me.Simpan.Text = "Simpan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Product Sans", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No BPJS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Product Sans", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pemilihan Pembayaran"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Product Sans", 12.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(320, 295)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(541, 45)
        Me.Guna2TextBox1.TabIndex = 13
        '
        'pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 638)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pembayaran"
        Me.Text = "pembayaran"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Simpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
