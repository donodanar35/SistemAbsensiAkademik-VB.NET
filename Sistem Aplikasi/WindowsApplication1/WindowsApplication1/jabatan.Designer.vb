<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jabatan
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
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonLainnya = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTU = New System.Windows.Forms.RadioButton()
        Me.RadioButtonwakasek = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKepsek = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxJabatan = New System.Windows.Forms.TextBox()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonTambahUbah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Location = New System.Drawing.Point(117, 40)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(262, 29)
        Me.TextBoxID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Jabatan :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonLainnya)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTU)
        Me.GroupBox1.Controls.Add(Me.RadioButtonwakasek)
        Me.GroupBox1.Controls.Add(Me.RadioButtonKepsek)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxJabatan)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 176)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jabatan"
        '
        'RadioButtonLainnya
        '
        Me.RadioButtonLainnya.AutoSize = True
        Me.RadioButtonLainnya.Checked = True
        Me.RadioButtonLainnya.Location = New System.Drawing.Point(117, 125)
        Me.RadioButtonLainnya.Name = "RadioButtonLainnya"
        Me.RadioButtonLainnya.Size = New System.Drawing.Size(100, 28)
        Me.RadioButtonLainnya.TabIndex = 2
        Me.RadioButtonLainnya.TabStop = True
        Me.RadioButtonLainnya.Text = "Lainnya"
        Me.RadioButtonLainnya.UseVisualStyleBackColor = True
        '
        'RadioButtonTU
        '
        Me.RadioButtonTU.AutoSize = True
        Me.RadioButtonTU.Location = New System.Drawing.Point(56, 125)
        Me.RadioButtonTU.Name = "RadioButtonTU"
        Me.RadioButtonTU.Size = New System.Drawing.Size(55, 28)
        Me.RadioButtonTU.TabIndex = 2
        Me.RadioButtonTU.TabStop = True
        Me.RadioButtonTU.Text = "TU"
        Me.RadioButtonTU.UseVisualStyleBackColor = True
        '
        'RadioButtonwakasek
        '
        Me.RadioButtonwakasek.AutoSize = True
        Me.RadioButtonwakasek.Location = New System.Drawing.Point(220, 91)
        Me.RadioButtonwakasek.Name = "RadioButtonwakasek"
        Me.RadioButtonwakasek.Size = New System.Drawing.Size(107, 28)
        Me.RadioButtonwakasek.TabIndex = 2
        Me.RadioButtonwakasek.TabStop = True
        Me.RadioButtonwakasek.Text = "wakasek"
        Me.RadioButtonwakasek.UseVisualStyleBackColor = True
        '
        'RadioButtonKepsek
        '
        Me.RadioButtonKepsek.AutoSize = True
        Me.RadioButtonKepsek.Location = New System.Drawing.Point(117, 90)
        Me.RadioButtonKepsek.Name = "RadioButtonKepsek"
        Me.RadioButtonKepsek.Size = New System.Drawing.Size(94, 28)
        Me.RadioButtonKepsek.TabIndex = 2
        Me.RadioButtonKepsek.TabStop = True
        Me.RadioButtonKepsek.Text = "kepsek"
        Me.RadioButtonKepsek.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Jabatan :"
        '
        'TextBoxJabatan
        '
        Me.TextBoxJabatan.Location = New System.Drawing.Point(220, 125)
        Me.TextBoxJabatan.Name = "TextBoxJabatan"
        Me.TextBoxJabatan.Size = New System.Drawing.Size(159, 29)
        Me.TextBoxJabatan.TabIndex = 2
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Image = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus.Location = New System.Drawing.Point(13, 193)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(86, 40)
        Me.Hapus.TabIndex = 56
        Me.Hapus.Text = "Hapus"
        Me.Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(331, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 41)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Clear"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonTambahUbah
        '
        Me.ButtonTambahUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambahUbah.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.ButtonTambahUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambahUbah.Location = New System.Drawing.Point(168, 192)
        Me.ButtonTambahUbah.Name = "ButtonTambahUbah"
        Me.ButtonTambahUbah.Size = New System.Drawing.Size(101, 41)
        Me.ButtonTambahUbah.TabIndex = 3
        Me.ButtonTambahUbah.Text = "Tambah"
        Me.ButtonTambahUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambahUbah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(400, 211)
        Me.DataGridView1.TabIndex = 54
        '
        'jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(424, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonTambahUbah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "jabatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jabatan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJabatan As System.Windows.Forms.TextBox
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonTambahUbah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButtonLainnya As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTU As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonwakasek As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonKepsek As System.Windows.Forms.RadioButton
End Class
