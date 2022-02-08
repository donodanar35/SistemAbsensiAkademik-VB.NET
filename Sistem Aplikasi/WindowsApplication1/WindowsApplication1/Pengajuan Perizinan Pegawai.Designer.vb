<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengajuan_Perizinan_Pegawai
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
        Me.Disetujui = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTahunAjaran = New System.Windows.Forms.TextBox()
        Me.TextBoxKetPerizinan = New System.Windows.Forms.TextBox()
        Me.DateTimePickerPeriodeAkhir = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerPeriodeAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxIDPerizinan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonProsess = New System.Windows.Forms.Button()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonKet = New System.Windows.Forms.RadioButton()
        Me.RadioButtonID = New System.Windows.Forms.RadioButton()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerSampaiTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButtonLainnya = New System.Windows.Forms.RadioButton()
        Me.RadioButtoSakit = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDinas = New System.Windows.Forms.RadioButton()
        Me.TextBoxIDSurat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxKetPengajuan = New System.Windows.Forms.TextBox()
        Me.DateTimePickerBerlakuTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxPegawai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.find1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(434, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Cari"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Disetujui
        '
        Me.Disetujui.HeaderText = "Disetujui"
        Me.Disetujui.Name = "Disetujui"
        Me.Disetujui.ReadOnly = True
        Me.Disetujui.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Disetujui.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column8
        '
        Me.Column8.HeaderText = "Dinas"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sakit"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Lainnya"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.TextBoxTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.TextBoxKetPerizinan)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPeriodeAkhir)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerPeriodeAwal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBoxIDPerizinan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 154)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periode Perizinan Pegawai"
        '
        'TextBoxTahunAjaran
        '
        Me.TextBoxTahunAjaran.Enabled = False
        Me.TextBoxTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTahunAjaran.Location = New System.Drawing.Point(105, 52)
        Me.TextBoxTahunAjaran.Name = "TextBoxTahunAjaran"
        Me.TextBoxTahunAjaran.Size = New System.Drawing.Size(237, 22)
        Me.TextBoxTahunAjaran.TabIndex = 33
        '
        'TextBoxKetPerizinan
        '
        Me.TextBoxKetPerizinan.Enabled = False
        Me.TextBoxKetPerizinan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKetPerizinan.Location = New System.Drawing.Point(356, 22)
        Me.TextBoxKetPerizinan.Multiline = True
        Me.TextBoxKetPerizinan.Name = "TextBoxKetPerizinan"
        Me.TextBoxKetPerizinan.Size = New System.Drawing.Size(347, 123)
        Me.TextBoxKetPerizinan.TabIndex = 31
        '
        'DateTimePickerPeriodeAkhir
        '
        Me.DateTimePickerPeriodeAkhir.Enabled = False
        Me.DateTimePickerPeriodeAkhir.Location = New System.Drawing.Point(105, 116)
        Me.DateTimePickerPeriodeAkhir.Name = "DateTimePickerPeriodeAkhir"
        Me.DateTimePickerPeriodeAkhir.Size = New System.Drawing.Size(237, 26)
        Me.DateTimePickerPeriodeAkhir.TabIndex = 30
        '
        'DateTimePickerPeriodeAwal
        '
        Me.DateTimePickerPeriodeAwal.Enabled = False
        Me.DateTimePickerPeriodeAwal.Location = New System.Drawing.Point(105, 82)
        Me.DateTimePickerPeriodeAwal.Name = "DateTimePickerPeriodeAwal"
        Me.DateTimePickerPeriodeAwal.Size = New System.Drawing.Size(237, 26)
        Me.DateTimePickerPeriodeAwal.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Periode Awal :"
        '
        'TextBoxIDPerizinan
        '
        Me.TextBoxIDPerizinan.Enabled = False
        Me.TextBoxIDPerizinan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDPerizinan.Location = New System.Drawing.Point(105, 22)
        Me.TextBoxIDPerizinan.Name = "TextBoxIDPerizinan"
        Me.TextBoxIDPerizinan.Size = New System.Drawing.Size(237, 22)
        Me.TextBoxIDPerizinan.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tahun Ajaran :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Periode Akhir :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Perizinan:"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Keterangan"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'ButtonProsess
        '
        Me.ButtonProsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProsess.Image = Global.WindowsApplication1.My.Resources.Resources.document_save
        Me.ButtonProsess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProsess.Location = New System.Drawing.Point(479, 434)
        Me.ButtonProsess.Name = "ButtonProsess"
        Me.ButtonProsess.Size = New System.Drawing.Size(99, 45)
        Me.ButtonProsess.TabIndex = 5
        Me.ButtonProsess.Text = "Simpan"
        Me.ButtonProsess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonProsess.UseVisualStyleBackColor = True
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.WindowsApplication1.My.Resources.Resources.printer_off
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(12, 434)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(197, 45)
        Me.ButtonCetak.TabIndex = 52
        Me.ButtonCetak.Text = "Lihat Permohonan"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(647, 434)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(87, 45)
        Me.ButtonClear.TabIndex = 55
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = Global.WindowsApplication1.My.Resources.Resources.Search_icon
        Me.Label2.Location = New System.Drawing.Point(16, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 26)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              "
        '
        'RadioButtonKet
        '
        Me.RadioButtonKet.AutoSize = True
        Me.RadioButtonKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonKet.Location = New System.Drawing.Point(143, 9)
        Me.RadioButtonKet.Name = "RadioButtonKet"
        Me.RadioButtonKet.Size = New System.Drawing.Size(95, 20)
        Me.RadioButtonKet.TabIndex = 48
        Me.RadioButtonKet.Text = "Keterangan"
        Me.RadioButtonKet.UseVisualStyleBackColor = True
        '
        'RadioButtonID
        '
        Me.RadioButtonID.AutoSize = True
        Me.RadioButtonID.Checked = True
        Me.RadioButtonID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonID.Location = New System.Drawing.Point(70, 10)
        Me.RadioButtonID.Name = "RadioButtonID"
        Me.RadioButtonID.Size = New System.Drawing.Size(39, 20)
        Me.RadioButtonID.TabIndex = 47
        Me.RadioButtonID.TabStop = True
        Me.RadioButtonID.Text = "ID"
        Me.RadioButtonID.UseVisualStyleBackColor = True
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCari.Location = New System.Drawing.Point(68, 34)
        Me.TextBoxCari.Multiline = True
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(352, 23)
        Me.TextBoxCari.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.printer_1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(243, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 45)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Lihat Persetujuan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tgl
        '
        Me.Tgl.HeaderText = "Tgl Disetujui"
        Me.Tgl.Name = "Tgl"
        Me.Tgl.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lime
        Me.GroupBox3.Controls.Add(Me.DateTimePickerSampaiTgl)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.RadioButtonLainnya)
        Me.GroupBox3.Controls.Add(Me.RadioButtoSakit)
        Me.GroupBox3.Controls.Add(Me.RadioButtonDinas)
        Me.GroupBox3.Controls.Add(Me.TextBoxIDSurat)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBoxKetPengajuan)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerBerlakuTgl)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBoxPegawai)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(722, 202)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pengajuan Surat Perizinan Pegawai"
        '
        'DateTimePickerSampaiTgl
        '
        Me.DateTimePickerSampaiTgl.Location = New System.Drawing.Point(107, 127)
        Me.DateTimePickerSampaiTgl.Name = "DateTimePickerSampaiTgl"
        Me.DateTimePickerSampaiTgl.Size = New System.Drawing.Size(237, 26)
        Me.DateTimePickerSampaiTgl.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Sampai Tgl :"
        '
        'RadioButtonLainnya
        '
        Me.RadioButtonLainnya.AutoSize = True
        Me.RadioButtonLainnya.Location = New System.Drawing.Point(261, 165)
        Me.RadioButtonLainnya.Name = "RadioButtonLainnya"
        Me.RadioButtonLainnya.Size = New System.Drawing.Size(89, 24)
        Me.RadioButtonLainnya.TabIndex = 3
        Me.RadioButtonLainnya.Text = "Lainnya"
        Me.RadioButtonLainnya.UseVisualStyleBackColor = True
        '
        'RadioButtoSakit
        '
        Me.RadioButtoSakit.AutoSize = True
        Me.RadioButtoSakit.Location = New System.Drawing.Point(184, 165)
        Me.RadioButtoSakit.Name = "RadioButtoSakit"
        Me.RadioButtoSakit.Size = New System.Drawing.Size(68, 24)
        Me.RadioButtoSakit.TabIndex = 3
        Me.RadioButtoSakit.Text = "Sakit"
        Me.RadioButtoSakit.UseVisualStyleBackColor = True
        '
        'RadioButtonDinas
        '
        Me.RadioButtonDinas.AutoSize = True
        Me.RadioButtonDinas.Checked = True
        Me.RadioButtonDinas.Location = New System.Drawing.Point(105, 165)
        Me.RadioButtonDinas.Name = "RadioButtonDinas"
        Me.RadioButtonDinas.Size = New System.Drawing.Size(73, 24)
        Me.RadioButtonDinas.TabIndex = 3
        Me.RadioButtonDinas.TabStop = True
        Me.RadioButtonDinas.Text = "Dinas"
        Me.RadioButtonDinas.UseVisualStyleBackColor = True
        '
        'TextBoxIDSurat
        '
        Me.TextBoxIDSurat.Enabled = False
        Me.TextBoxIDSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIDSurat.Location = New System.Drawing.Point(105, 31)
        Me.TextBoxIDSurat.Name = "TextBoxIDSurat"
        Me.TextBoxIDSurat.Size = New System.Drawing.Size(237, 22)
        Me.TextBoxIDSurat.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "No Surat Izin :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(483, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Keterangan :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Keperluan Izin :"
        '
        'TextBoxKetPengajuan
        '
        Me.TextBoxKetPengajuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKetPengajuan.Location = New System.Drawing.Point(356, 30)
        Me.TextBoxKetPengajuan.Multiline = True
        Me.TextBoxKetPengajuan.Name = "TextBoxKetPengajuan"
        Me.TextBoxKetPengajuan.Size = New System.Drawing.Size(347, 159)
        Me.TextBoxKetPengajuan.TabIndex = 4
        '
        'DateTimePickerBerlakuTgl
        '
        Me.DateTimePickerBerlakuTgl.Location = New System.Drawing.Point(105, 91)
        Me.DateTimePickerBerlakuTgl.Name = "DateTimePickerBerlakuTgl"
        Me.DateTimePickerBerlakuTgl.Size = New System.Drawing.Size(237, 26)
        Me.DateTimePickerBerlakuTgl.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Berlaku Tgl :"
        '
        'TextBoxPegawai
        '
        Me.TextBoxPegawai.Enabled = False
        Me.TextBoxPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPegawai.Location = New System.Drawing.Point(105, 60)
        Me.TextBoxPegawai.Name = "TextBoxPegawai"
        Me.TextBoxPegawai.Size = New System.Drawing.Size(237, 22)
        Me.TextBoxPegawai.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Pegawai :"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Tgl Izin"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column4, Me.Column6, Me.Column5, Me.Tgl, Me.Column7, Me.Disetujui, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 485)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(722, 248)
        Me.DataGridView1.TabIndex = 51
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Pegawai"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Jenis Izin"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Berlaku Tgl"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Sampai Tgl"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Pengajuan_Perizinan_Pegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(746, 742)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonProsess)
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButtonKet)
        Me.Controls.Add(Me.RadioButtonID)
        Me.Controls.Add(Me.TextBoxCari)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Pengajuan_Perizinan_Pegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengajuan_Perizinan_Pegawai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Disetujui As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKetPerizinan As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerPeriodeAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerPeriodeAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxIDPerizinan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonProsess As System.Windows.Forms.Button
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonKet As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonID As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerSampaiTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonLainnya As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtoSakit As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDinas As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxIDSurat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKetPengajuan As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerBerlakuTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
