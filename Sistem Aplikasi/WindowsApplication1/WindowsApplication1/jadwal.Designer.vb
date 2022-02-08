<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jadwal
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
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePickerSampaiTgl = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerBerlakuTgl = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxCariMapel = New System.Windows.Forms.TextBox()
        Me.ComboBoxMapel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButtonMinggu = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSabtu = New System.Windows.Forms.RadioButton()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButtonJumat = New System.Windows.Forms.RadioButton()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ComboBoxTahunAjaran = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSetujui = New System.Windows.Forms.Button()
        Me.ButtonCariTahun = New System.Windows.Forms.Button()
        Me.TextBoxCariTahunAjaran = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButtonKamis = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRabu = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSelasa = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSenin = New System.Windows.Forms.RadioButton()
        Me.ButtonCariPegawai = New System.Windows.Forms.Button()
        Me.TextBoxCariPegawai = New System.Windows.Forms.TextBox()
        Me.ButtonCariKelas = New System.Windows.Forms.Button()
        Me.TextBoxCariKelas = New System.Windows.Forms.TextBox()
        Me.ComboBoxPegawai = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxJamSelesai = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonProsess = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxJamMulai = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxKelas = New System.Windows.Forms.ComboBox()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Berlaku"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Sampai Tgl :"
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "Jam Selesai"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Jam Mulai"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Hari"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Berlaku Tgl :"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "ID Kelas"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Pengajar"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "ID Pegawai"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'DateTimePickerSampaiTgl
        '
        Me.DateTimePickerSampaiTgl.Location = New System.Drawing.Point(124, 243)
        Me.DateTimePickerSampaiTgl.Name = "DateTimePickerSampaiTgl"
        Me.DateTimePickerSampaiTgl.Size = New System.Drawing.Size(327, 26)
        Me.DateTimePickerSampaiTgl.TabIndex = 18
        '
        'DateTimePickerBerlakuTgl
        '
        Me.DateTimePickerBerlakuTgl.Location = New System.Drawing.Point(124, 204)
        Me.DateTimePickerBerlakuTgl.Name = "DateTimePickerBerlakuTgl"
        Me.DateTimePickerBerlakuTgl.Size = New System.Drawing.Size(327, 26)
        Me.DateTimePickerBerlakuTgl.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(619, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 22)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxCariMapel
        '
        Me.TextBoxCariMapel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariMapel.Location = New System.Drawing.Point(464, 131)
        Me.TextBoxCariMapel.Name = "TextBoxCariMapel"
        Me.TextBoxCariMapel.Size = New System.Drawing.Size(145, 22)
        Me.TextBoxCariMapel.TabIndex = 13
        '
        'ComboBoxMapel
        '
        Me.ComboBoxMapel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMapel.FormattingEnabled = True
        Me.ComboBoxMapel.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxMapel.Location = New System.Drawing.Point(124, 131)
        Me.ComboBoxMapel.Name = "ComboBoxMapel"
        Me.ComboBoxMapel.Size = New System.Drawing.Size(327, 24)
        Me.ComboBoxMapel.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Mapel :"
        '
        'RadioButtonMinggu
        '
        Me.RadioButtonMinggu.AutoSize = True
        Me.RadioButtonMinggu.Location = New System.Drawing.Point(572, 27)
        Me.RadioButtonMinggu.Name = "RadioButtonMinggu"
        Me.RadioButtonMinggu.Size = New System.Drawing.Size(85, 24)
        Me.RadioButtonMinggu.TabIndex = 5
        Me.RadioButtonMinggu.TabStop = True
        Me.RadioButtonMinggu.Text = "Minggu"
        Me.RadioButtonMinggu.UseVisualStyleBackColor = True
        '
        'RadioButtonSabtu
        '
        Me.RadioButtonSabtu.AutoSize = True
        Me.RadioButtonSabtu.Location = New System.Drawing.Point(495, 26)
        Me.RadioButtonSabtu.Name = "RadioButtonSabtu"
        Me.RadioButtonSabtu.Size = New System.Drawing.Size(75, 24)
        Me.RadioButtonSabtu.TabIndex = 5
        Me.RadioButtonSabtu.TabStop = True
        Me.RadioButtonSabtu.Text = "Sabtu"
        Me.RadioButtonSabtu.UseVisualStyleBackColor = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Kelas"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "ID Mapel"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'RadioButtonJumat
        '
        Me.RadioButtonJumat.AutoSize = True
        Me.RadioButtonJumat.Location = New System.Drawing.Point(421, 27)
        Me.RadioButtonJumat.Name = "RadioButtonJumat"
        Me.RadioButtonJumat.Size = New System.Drawing.Size(76, 24)
        Me.RadioButtonJumat.TabIndex = 5
        Me.RadioButtonJumat.TabStop = True
        Me.RadioButtonJumat.Text = "Jumat"
        Me.RadioButtonJumat.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(411, 404)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(83, 45)
        Me.ButtonClear.TabIndex = 51
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ComboBoxTahunAjaran
        '
        Me.ComboBoxTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTahunAjaran.FormattingEnabled = True
        Me.ComboBoxTahunAjaran.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxTahunAjaran.Location = New System.Drawing.Point(124, 42)
        Me.ComboBoxTahunAjaran.Name = "ComboBoxTahunAjaran"
        Me.ComboBoxTahunAjaran.Size = New System.Drawing.Size(264, 24)
        Me.ComboBoxTahunAjaran.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tahun Ajaran :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.ButtonSetujui)
        Me.GroupBox1.Controls.Add(Me.ButtonCariTahun)
        Me.GroupBox1.Controls.Add(Me.TextBoxCariTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 88)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Penjadwalan Mata Pelajaran"
        '
        'ButtonSetujui
        '
        Me.ButtonSetujui.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetujui.Image = Global.WindowsApplication1.My.Resources.Resources.apply
        Me.ButtonSetujui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSetujui.Location = New System.Drawing.Point(555, 25)
        Me.ButtonSetujui.Name = "ButtonSetujui"
        Me.ButtonSetujui.Size = New System.Drawing.Size(102, 44)
        Me.ButtonSetujui.TabIndex = 4
        Me.ButtonSetujui.Text = "Setujui"
        Me.ButtonSetujui.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSetujui.UseVisualStyleBackColor = True
        '
        'ButtonCariTahun
        '
        Me.ButtonCariTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariTahun.Location = New System.Drawing.Point(495, 46)
        Me.ButtonCariTahun.Name = "ButtonCariTahun"
        Me.ButtonCariTahun.Size = New System.Drawing.Size(38, 23)
        Me.ButtonCariTahun.TabIndex = 3
        Me.ButtonCariTahun.Text = "Cari"
        Me.ButtonCariTahun.UseVisualStyleBackColor = True
        '
        'TextBoxCariTahunAjaran
        '
        Me.TextBoxCariTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariTahunAjaran.Location = New System.Drawing.Point(402, 44)
        Me.TextBoxCariTahunAjaran.Name = "TextBoxCariTahunAjaran"
        Me.TextBoxCariTahunAjaran.Size = New System.Drawing.Size(80, 22)
        Me.TextBoxCariTahunAjaran.TabIndex = 2
        '
        'Cancel
        '
        Me.Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Text = "cancel"
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column13.HeaderText = "Sampai"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Mata Pelajaran"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'RadioButtonKamis
        '
        Me.RadioButtonKamis.AutoSize = True
        Me.RadioButtonKamis.Location = New System.Drawing.Point(346, 26)
        Me.RadioButtonKamis.Name = "RadioButtonKamis"
        Me.RadioButtonKamis.Size = New System.Drawing.Size(75, 24)
        Me.RadioButtonKamis.TabIndex = 5
        Me.RadioButtonKamis.TabStop = True
        Me.RadioButtonKamis.Text = "Kamis"
        Me.RadioButtonKamis.UseVisualStyleBackColor = True
        '
        'RadioButtonRabu
        '
        Me.RadioButtonRabu.AutoSize = True
        Me.RadioButtonRabu.Location = New System.Drawing.Point(276, 26)
        Me.RadioButtonRabu.Name = "RadioButtonRabu"
        Me.RadioButtonRabu.Size = New System.Drawing.Size(70, 24)
        Me.RadioButtonRabu.TabIndex = 5
        Me.RadioButtonRabu.TabStop = True
        Me.RadioButtonRabu.Text = "Rabu"
        Me.RadioButtonRabu.UseVisualStyleBackColor = True
        '
        'RadioButtonSelasa
        '
        Me.RadioButtonSelasa.AutoSize = True
        Me.RadioButtonSelasa.Location = New System.Drawing.Point(196, 26)
        Me.RadioButtonSelasa.Name = "RadioButtonSelasa"
        Me.RadioButtonSelasa.Size = New System.Drawing.Size(82, 24)
        Me.RadioButtonSelasa.TabIndex = 5
        Me.RadioButtonSelasa.TabStop = True
        Me.RadioButtonSelasa.Text = "Selasa"
        Me.RadioButtonSelasa.UseVisualStyleBackColor = True
        '
        'RadioButtonSenin
        '
        Me.RadioButtonSenin.AutoSize = True
        Me.RadioButtonSenin.Checked = True
        Me.RadioButtonSenin.Location = New System.Drawing.Point(124, 26)
        Me.RadioButtonSenin.Name = "RadioButtonSenin"
        Me.RadioButtonSenin.Size = New System.Drawing.Size(73, 24)
        Me.RadioButtonSenin.TabIndex = 5
        Me.RadioButtonSenin.TabStop = True
        Me.RadioButtonSenin.Text = "Senin"
        Me.RadioButtonSenin.UseVisualStyleBackColor = True
        '
        'ButtonCariPegawai
        '
        Me.ButtonCariPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariPegawai.Location = New System.Drawing.Point(619, 94)
        Me.ButtonCariPegawai.Name = "ButtonCariPegawai"
        Me.ButtonCariPegawai.Size = New System.Drawing.Size(38, 22)
        Me.ButtonCariPegawai.TabIndex = 11
        Me.ButtonCariPegawai.Text = "Cari"
        Me.ButtonCariPegawai.UseVisualStyleBackColor = True
        '
        'TextBoxCariPegawai
        '
        Me.TextBoxCariPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariPegawai.Location = New System.Drawing.Point(464, 95)
        Me.TextBoxCariPegawai.Name = "TextBoxCariPegawai"
        Me.TextBoxCariPegawai.Size = New System.Drawing.Size(145, 22)
        Me.TextBoxCariPegawai.TabIndex = 10
        '
        'ButtonCariKelas
        '
        Me.ButtonCariKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariKelas.Location = New System.Drawing.Point(619, 55)
        Me.ButtonCariKelas.Name = "ButtonCariKelas"
        Me.ButtonCariKelas.Size = New System.Drawing.Size(38, 22)
        Me.ButtonCariKelas.TabIndex = 8
        Me.ButtonCariKelas.Text = "Cari"
        Me.ButtonCariKelas.UseVisualStyleBackColor = True
        '
        'TextBoxCariKelas
        '
        Me.TextBoxCariKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariKelas.Location = New System.Drawing.Point(464, 58)
        Me.TextBoxCariKelas.Name = "TextBoxCariKelas"
        Me.TextBoxCariKelas.Size = New System.Drawing.Size(145, 22)
        Me.TextBoxCariKelas.TabIndex = 7
        '
        'ComboBoxPegawai
        '
        Me.ComboBoxPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPegawai.FormattingEnabled = True
        Me.ComboBoxPegawai.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxPegawai.Location = New System.Drawing.Point(124, 95)
        Me.ComboBoxPegawai.Name = "ComboBoxPegawai"
        Me.ComboBoxPegawai.Size = New System.Drawing.Size(327, 24)
        Me.ComboBoxPegawai.TabIndex = 9
        '
        'MaskedTextBoxJamSelesai
        '
        Me.MaskedTextBoxJamSelesai.Location = New System.Drawing.Point(321, 169)
        Me.MaskedTextBoxJamSelesai.Mask = "00:00:00"
        Me.MaskedTextBoxJamSelesai.Name = "MaskedTextBoxJamSelesai"
        Me.MaskedTextBoxJamSelesai.Size = New System.Drawing.Size(76, 26)
        Me.MaskedTextBoxJamSelesai.TabIndex = 16
        Me.MaskedTextBoxJamSelesai.Text = "000000"
        '
        'ButtonProsess
        '
        Me.ButtonProsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProsess.Image = Global.WindowsApplication1.My.Resources.Resources.document_save
        Me.ButtonProsess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProsess.Location = New System.Drawing.Point(216, 404)
        Me.ButtonProsess.Name = "ButtonProsess"
        Me.ButtonProsess.Size = New System.Drawing.Size(107, 45)
        Me.ButtonProsess.TabIndex = 20
        Me.ButtonProsess.Text = "Simpan"
        Me.ButtonProsess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonProsess.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Pengajar :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Kelas :"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Image = Global.WindowsApplication1.My.Resources.Resources.increase
        Me.ButtonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambah.Location = New System.Drawing.Point(464, 224)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(145, 45)
        Me.ButtonTambah.TabIndex = 19
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hari :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lime
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerSampaiTgl)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerBerlakuTgl)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBoxCariMapel)
        Me.GroupBox3.Controls.Add(Me.ComboBoxMapel)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.RadioButtonMinggu)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSabtu)
        Me.GroupBox3.Controls.Add(Me.RadioButtonJumat)
        Me.GroupBox3.Controls.Add(Me.RadioButtonKamis)
        Me.GroupBox3.Controls.Add(Me.RadioButtonRabu)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSelasa)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSenin)
        Me.GroupBox3.Controls.Add(Me.ButtonCariPegawai)
        Me.GroupBox3.Controls.Add(Me.TextBoxCariPegawai)
        Me.GroupBox3.Controls.Add(Me.ButtonCariKelas)
        Me.GroupBox3.Controls.Add(Me.TextBoxCariKelas)
        Me.GroupBox3.Controls.Add(Me.ComboBoxPegawai)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBoxJamSelesai)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBoxJamMulai)
        Me.GroupBox3.Controls.Add(Me.ComboBoxKelas)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.ButtonTambah)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(678, 282)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Penjadwalan Mata Pelajaran"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Jam Selesai :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Jam Mulai :"
        '
        'MaskedTextBoxJamMulai
        '
        Me.MaskedTextBoxJamMulai.Location = New System.Drawing.Point(124, 168)
        Me.MaskedTextBoxJamMulai.Mask = "00:00:00"
        Me.MaskedTextBoxJamMulai.Name = "MaskedTextBoxJamMulai"
        Me.MaskedTextBoxJamMulai.Size = New System.Drawing.Size(85, 26)
        Me.MaskedTextBoxJamMulai.TabIndex = 15
        Me.MaskedTextBoxJamMulai.Text = "000000"
        '
        'ComboBoxKelas
        '
        Me.ComboBoxKelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxKelas.FormattingEnabled = True
        Me.ComboBoxKelas.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxKelas.Location = New System.Drawing.Point(124, 60)
        Me.ComboBoxKelas.Name = "ComboBoxKelas"
        Me.ComboBoxKelas.Size = New System.Drawing.Size(327, 24)
        Me.ComboBoxKelas.TabIndex = 6
        '
        'ButtonNew
        '
        Me.ButtonNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.Image = Global.WindowsApplication1.My.Resources.Resources.new_doc
        Me.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNew.Location = New System.Drawing.Point(12, 404)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(78, 45)
        Me.ButtonNew.TabIndex = 21
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.find1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(519, 405)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 44)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Biodata Pengajar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Cancel})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 458)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(678, 281)
        Me.DataGridView1.TabIndex = 47
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "ID_Jadwal"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Tahun Ajaran"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'jadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(702, 742)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonProsess)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "jadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jadwal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePickerSampaiTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerBerlakuTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariMapel As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxMapel As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonMinggu As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSabtu As System.Windows.Forms.RadioButton
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButtonJumat As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTahunAjaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSetujui As System.Windows.Forms.Button
    Friend WithEvents ButtonCariTahun As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButtonKamis As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRabu As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSelasa As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSenin As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonCariPegawai As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariPegawai As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCariKelas As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariKelas As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBoxJamSelesai As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonProsess As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxJamMulai As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBoxKelas As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
