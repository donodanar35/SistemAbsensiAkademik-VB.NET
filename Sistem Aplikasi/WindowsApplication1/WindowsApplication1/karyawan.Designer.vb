<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class karyawan
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.TextBoxTempatLahir = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePickerTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RadioButtonWanita = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPria = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Nama = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePickerTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioButton_NoInduk = New System.Windows.Forms.RadioButton()
        Me.TextBoxTelp = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonSimpanUbah = New System.Windows.Forms.Button()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxRePass = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.TextBoxNoInduk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAgama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(337, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 39)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Clear"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Location = New System.Drawing.Point(47, 46)
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(737, 29)
        Me.TextBoxCari.TabIndex = 10
        '
        'TextBoxTempatLahir
        '
        Me.TextBoxTempatLahir.Location = New System.Drawing.Point(124, 227)
        Me.TextBoxTempatLahir.Name = "TextBoxTempatLahir"
        Me.TextBoxTempatLahir.Size = New System.Drawing.Size(309, 29)
        Me.TextBoxTempatLahir.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Tempat Lahir :"
        '
        'DateTimePickerTglLahir
        '
        Me.DateTimePickerTglLahir.Location = New System.Drawing.Point(124, 267)
        Me.DateTimePickerTglLahir.Name = "DateTimePickerTglLahir"
        Me.DateTimePickerTglLahir.Size = New System.Drawing.Size(309, 29)
        Me.DateTimePickerTglLahir.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Tgl Lahir :"
        '
        'RadioButtonWanita
        '
        Me.RadioButtonWanita.AutoSize = True
        Me.RadioButtonWanita.Location = New System.Drawing.Point(743, 116)
        Me.RadioButtonWanita.Name = "RadioButtonWanita"
        Me.RadioButtonWanita.Size = New System.Drawing.Size(136, 28)
        Me.RadioButtonWanita.TabIndex = 10
        Me.RadioButtonWanita.TabStop = True
        Me.RadioButtonWanita.Text = "Perempuan"
        Me.RadioButtonWanita.UseVisualStyleBackColor = True
        '
        'RadioButtonPria
        '
        Me.RadioButtonPria.AutoSize = True
        Me.RadioButtonPria.Checked = True
        Me.RadioButtonPria.Location = New System.Drawing.Point(614, 116)
        Me.RadioButtonPria.Name = "RadioButtonPria"
        Me.RadioButtonPria.Size = New System.Drawing.Size(103, 28)
        Me.RadioButtonPria.TabIndex = 10
        Me.RadioButtonPria.TabStop = True
        Me.RadioButtonPria.Text = "Laki-laki"
        Me.RadioButtonPria.UseVisualStyleBackColor = True
        '
        'RadioButton_Nama
        '
        Me.RadioButton_Nama.AutoSize = True
        Me.RadioButton_Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Nama.Location = New System.Drawing.Point(274, 20)
        Me.RadioButton_Nama.Name = "RadioButton_Nama"
        Me.RadioButton_Nama.Size = New System.Drawing.Size(63, 20)
        Me.RadioButton_Nama.TabIndex = 12
        Me.RadioButton_Nama.Text = "Nama"
        Me.RadioButton_Nama.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.WindowsApplication1.My.Resources.Resources.find1
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(801, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 29)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Cari"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePickerTglMasuk
        '
        Me.DateTimePickerTglMasuk.Location = New System.Drawing.Point(603, 72)
        Me.DateTimePickerTglMasuk.Name = "DateTimePickerTglMasuk"
        Me.DateTimePickerTglMasuk.Size = New System.Drawing.Size(276, 29)
        Me.DateTimePickerTglMasuk.TabIndex = 9
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(602, 158)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(277, 127)
        Me.TextBoxAlamat.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(525, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Gender :"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.arrow_refresh
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(470, 426)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 38)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Refresh"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RadioButton_NoInduk
        '
        Me.RadioButton_NoInduk.AutoSize = True
        Me.RadioButton_NoInduk.Checked = True
        Me.RadioButton_NoInduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_NoInduk.Location = New System.Drawing.Point(155, 20)
        Me.RadioButton_NoInduk.Name = "RadioButton_NoInduk"
        Me.RadioButton_NoInduk.Size = New System.Drawing.Size(79, 20)
        Me.RadioButton_NoInduk.TabIndex = 14
        Me.RadioButton_NoInduk.TabStop = True
        Me.RadioButton_NoInduk.Text = "No Induk"
        Me.RadioButton_NoInduk.UseVisualStyleBackColor = True
        '
        'TextBoxTelp
        '
        Me.TextBoxTelp.Location = New System.Drawing.Point(603, 31)
        Me.TextBoxTelp.Name = "TextBoxTelp"
        Me.TextBoxTelp.Size = New System.Drawing.Size(276, 29)
        Me.TextBoxTelp.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.RadioButton_NoInduk)
        Me.GroupBox3.Controls.Add(Me.RadioButton_Nama)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.TextBoxCari)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(905, 91)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = Global.WindowsApplication1.My.Resources.Resources.Search_icon
        Me.Label6.Location = New System.Drawing.Point(7, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 48)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(507, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tgl Masuk :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(525, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Alamat :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(549, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Telp :"
        '
        'ButtonSimpanUbah
        '
        Me.ButtonSimpanUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpanUbah.Image = Global.WindowsApplication1.My.Resources.Resources.user_male_add
        Me.ButtonSimpanUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpanUbah.Location = New System.Drawing.Point(168, 425)
        Me.ButtonSimpanUbah.Name = "ButtonSimpanUbah"
        Me.ButtonSimpanUbah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSimpanUbah.Size = New System.Drawing.Size(102, 39)
        Me.ButtonSimpanUbah.TabIndex = 12
        Me.ButtonSimpanUbah.Text = "Tambah"
        Me.ButtonSimpanUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSimpanUbah.UseVisualStyleBackColor = True
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(124, 145)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(309, 29)
        Me.TextBoxNama.TabIndex = 4
        '
        'TextBoxRePass
        '
        Me.TextBoxRePass.Location = New System.Drawing.Point(124, 107)
        Me.TextBoxRePass.Name = "TextBoxRePass"
        Me.TextBoxRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRePass.Size = New System.Drawing.Size(309, 29)
        Me.TextBoxRePass.TabIndex = 3
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(124, 68)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(309, 29)
        Me.TextBoxPass.TabIndex = 2
        '
        'TextBoxNoInduk
        '
        Me.TextBoxNoInduk.Location = New System.Drawing.Point(125, 30)
        Me.TextBoxNoInduk.Name = "TextBoxNoInduk"
        Me.TextBoxNoInduk.Size = New System.Drawing.Size(308, 29)
        Me.TextBoxNoInduk.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Re-Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Agama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama :"
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.Image = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus.Location = New System.Drawing.Point(13, 426)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(83, 38)
        Me.Hapus.TabIndex = 17
        Me.Hapus.Text = "Hapus"
        Me.Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxAgama)
        Me.GroupBox1.Controls.Add(Me.TextBoxTempatLahir)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTglLahir)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.RadioButtonWanita)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPria)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTglMasuk)
        Me.GroupBox1.Controls.Add(Me.TextBoxAlamat)
        Me.GroupBox1.Controls.Add(Me.TextBoxTelp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxNama)
        Me.GroupBox1.Controls.Add(Me.TextBoxRePass)
        Me.GroupBox1.Controls.Add(Me.TextBoxPass)
        Me.GroupBox1.Controls.Add(Me.TextBoxNoInduk)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(905, 312)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master Pegawai"
        '
        'TextBoxAgama
        '
        Me.TextBoxAgama.Enabled = False
        Me.TextBoxAgama.Location = New System.Drawing.Point(125, 187)
        Me.TextBoxAgama.Name = "TextBoxAgama"
        Me.TextBoxAgama.Size = New System.Drawing.Size(309, 29)
        Me.TextBoxAgama.TabIndex = 5
        Me.TextBoxAgama.Text = "Islam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Induk :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 475)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(905, 212)
        Me.DataGridView1.TabIndex = 15
        '
        'karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(930, 679)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonSimpanUbah)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pegawai"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonWanita As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPria As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Nama As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerTglMasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RadioButton_NoInduk As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxTelp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ButtonSimpanUbah As System.Windows.Forms.Button
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRePass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNoInduk As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxAgama As System.Windows.Forms.TextBox
End Class
