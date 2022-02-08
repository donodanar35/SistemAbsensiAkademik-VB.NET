<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembagian_Kelas
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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonSetujui = New System.Windows.Forms.Button()
        Me.ComboBoxRuang = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRombel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxWaliKelas = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonCariTahun = New System.Windows.Forms.Button()
        Me.TextBoxCariTahunAjaran = New System.Windows.Forms.TextBox()
        Me.ComboBoxTahunAjaran = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonProsess = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxKelas = New System.Windows.Forms.TextBox()
        Me.ButtonCariWali = New System.Windows.Forms.Button()
        Me.TextBoxCariWali = New System.Windows.Forms.TextBox()
        Me.ButtonCariRuang = New System.Windows.Forms.Button()
        Me.TextBoxCariRuang = New System.Windows.Forms.TextBox()
        Me.ButtonCariRombel = New System.Windows.Forms.Button()
        Me.TextBoxCariRombel = New System.Windows.Forms.TextBox()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxCariSiswa = New System.Windows.Forms.TextBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ComboBoxSiswa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Siswa"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Cancel"
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Text = "cancel"
        '
        'ButtonSetujui
        '
        Me.ButtonSetujui.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSetujui.Image = Global.WindowsApplication1.My.Resources.Resources.apply
        Me.ButtonSetujui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSetujui.Location = New System.Drawing.Point(457, 211)
        Me.ButtonSetujui.Name = "ButtonSetujui"
        Me.ButtonSetujui.Size = New System.Drawing.Size(108, 45)
        Me.ButtonSetujui.TabIndex = 14
        Me.ButtonSetujui.Text = "Setujui"
        Me.ButtonSetujui.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSetujui.UseVisualStyleBackColor = True
        '
        'ComboBoxRuang
        '
        Me.ComboBoxRuang.FormattingEnabled = True
        Me.ComboBoxRuang.Location = New System.Drawing.Point(124, 135)
        Me.ComboBoxRuang.Name = "ComboBoxRuang"
        Me.ComboBoxRuang.Size = New System.Drawing.Size(327, 28)
        Me.ComboBoxRuang.TabIndex = 7
        '
        'ComboBoxRombel
        '
        Me.ComboBoxRombel.FormattingEnabled = True
        Me.ComboBoxRombel.Location = New System.Drawing.Point(124, 95)
        Me.ComboBoxRombel.Name = "ComboBoxRombel"
        Me.ComboBoxRombel.Size = New System.Drawing.Size(327, 28)
        Me.ComboBoxRombel.TabIndex = 4
        '
        'ComboBoxWaliKelas
        '
        Me.ComboBoxWaliKelas.FormattingEnabled = True
        Me.ComboBoxWaliKelas.Location = New System.Drawing.Point(124, 176)
        Me.ComboBoxWaliKelas.Name = "ComboBoxWaliKelas"
        Me.ComboBoxWaliKelas.Size = New System.Drawing.Size(327, 28)
        Me.ComboBoxWaliKelas.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Ruang :"
        '
        'ButtonCariTahun
        '
        Me.ButtonCariTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariTahun.Location = New System.Drawing.Point(572, 60)
        Me.ButtonCariTahun.Name = "ButtonCariTahun"
        Me.ButtonCariTahun.Size = New System.Drawing.Size(38, 23)
        Me.ButtonCariTahun.TabIndex = 3
        Me.ButtonCariTahun.Text = "Cari"
        Me.ButtonCariTahun.UseVisualStyleBackColor = True
        '
        'TextBoxCariTahunAjaran
        '
        Me.TextBoxCariTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariTahunAjaran.Location = New System.Drawing.Point(457, 61)
        Me.TextBoxCariTahunAjaran.Name = "TextBoxCariTahunAjaran"
        Me.TextBoxCariTahunAjaran.Size = New System.Drawing.Size(108, 22)
        Me.TextBoxCariTahunAjaran.TabIndex = 2
        '
        'ComboBoxTahunAjaran
        '
        Me.ComboBoxTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTahunAjaran.FormattingEnabled = True
        Me.ComboBoxTahunAjaran.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxTahunAjaran.Location = New System.Drawing.Point(124, 61)
        Me.ComboBoxTahunAjaran.Name = "ComboBoxTahunAjaran"
        Me.ComboBoxTahunAjaran.Size = New System.Drawing.Size(327, 24)
        Me.ComboBoxTahunAjaran.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'ButtonProsess
        '
        Me.ButtonProsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProsess.Image = Global.WindowsApplication1.My.Resources.Resources.document_save
        Me.ButtonProsess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProsess.Location = New System.Drawing.Point(251, 376)
        Me.ButtonProsess.Name = "ButtonProsess"
        Me.ButtonProsess.Size = New System.Drawing.Size(107, 45)
        Me.ButtonProsess.TabIndex = 19
        Me.ButtonProsess.Text = "Simpan"
        Me.ButtonProsess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonProsess.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(380, 376)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(83, 45)
        Me.ButtonClear.TabIndex = 35
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.Image = Global.WindowsApplication1.My.Resources.Resources.new_doc
        Me.ButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNew.Location = New System.Drawing.Point(12, 376)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(78, 45)
        Me.ButtonNew.TabIndex = 20
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxKelas)
        Me.GroupBox1.Controls.Add(Me.ButtonSetujui)
        Me.GroupBox1.Controls.Add(Me.ButtonCariWali)
        Me.GroupBox1.Controls.Add(Me.TextBoxCariWali)
        Me.GroupBox1.Controls.Add(Me.ButtonCariRuang)
        Me.GroupBox1.Controls.Add(Me.TextBoxCariRuang)
        Me.GroupBox1.Controls.Add(Me.ButtonCariRombel)
        Me.GroupBox1.Controls.Add(Me.TextBoxCariRombel)
        Me.GroupBox1.Controls.Add(Me.ComboBoxRuang)
        Me.GroupBox1.Controls.Add(Me.ComboBoxRombel)
        Me.GroupBox1.Controls.Add(Me.ComboBoxWaliKelas)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ButtonCariTahun)
        Me.GroupBox1.Controls.Add(Me.TextBoxCariTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 266)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembagian Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Nama Kelas :"
        '
        'TextBoxKelas
        '
        Me.TextBoxKelas.Location = New System.Drawing.Point(124, 219)
        Me.TextBoxKelas.Name = "TextBoxKelas"
        Me.TextBoxKelas.Size = New System.Drawing.Size(327, 26)
        Me.TextBoxKelas.TabIndex = 13
        '
        'ButtonCariWali
        '
        Me.ButtonCariWali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariWali.Location = New System.Drawing.Point(572, 178)
        Me.ButtonCariWali.Name = "ButtonCariWali"
        Me.ButtonCariWali.Size = New System.Drawing.Size(38, 23)
        Me.ButtonCariWali.TabIndex = 12
        Me.ButtonCariWali.Text = "Cari"
        Me.ButtonCariWali.UseVisualStyleBackColor = True
        '
        'TextBoxCariWali
        '
        Me.TextBoxCariWali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariWali.Location = New System.Drawing.Point(457, 179)
        Me.TextBoxCariWali.Name = "TextBoxCariWali"
        Me.TextBoxCariWali.Size = New System.Drawing.Size(108, 22)
        Me.TextBoxCariWali.TabIndex = 11
        '
        'ButtonCariRuang
        '
        Me.ButtonCariRuang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariRuang.Location = New System.Drawing.Point(572, 137)
        Me.ButtonCariRuang.Name = "ButtonCariRuang"
        Me.ButtonCariRuang.Size = New System.Drawing.Size(38, 23)
        Me.ButtonCariRuang.TabIndex = 9
        Me.ButtonCariRuang.Text = "Cari"
        Me.ButtonCariRuang.UseVisualStyleBackColor = True
        '
        'TextBoxCariRuang
        '
        Me.TextBoxCariRuang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariRuang.Location = New System.Drawing.Point(457, 138)
        Me.TextBoxCariRuang.Name = "TextBoxCariRuang"
        Me.TextBoxCariRuang.Size = New System.Drawing.Size(108, 22)
        Me.TextBoxCariRuang.TabIndex = 8
        '
        'ButtonCariRombel
        '
        Me.ButtonCariRombel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariRombel.Location = New System.Drawing.Point(572, 97)
        Me.ButtonCariRombel.Name = "ButtonCariRombel"
        Me.ButtonCariRombel.Size = New System.Drawing.Size(38, 23)
        Me.ButtonCariRombel.TabIndex = 6
        Me.ButtonCariRombel.Text = "Cari"
        Me.ButtonCariRombel.UseVisualStyleBackColor = True
        '
        'TextBoxCariRombel
        '
        Me.TextBoxCariRombel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariRombel.Location = New System.Drawing.Point(457, 98)
        Me.TextBoxCariRombel.Name = "TextBoxCariRombel"
        Me.TextBoxCariRombel.Size = New System.Drawing.Size(108, 22)
        Me.TextBoxCariRombel.TabIndex = 5
        '
        'TextBoxId
        '
        Me.TextBoxId.Enabled = False
        Me.TextBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(124, 25)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(327, 22)
        Me.TextBoxId.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tahun Ajaran :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Wali Kelas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rombel :"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Siswa"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Enabled = False
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.WindowsApplication1.My.Resources.Resources.printer_1_
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(136, 376)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(87, 45)
        Me.ButtonCetak.TabIndex = 32
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Username.DataPropertyName = "id_kelas"
        Me.Username.HeaderText = "ID Kelas"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lime
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.TextBoxCariSiswa)
        Me.GroupBox3.Controls.Add(Me.ButtonTambah)
        Me.GroupBox3.Controls.Add(Me.ComboBoxSiswa)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(627, 72)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tambahkan Anggota Kelas"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(401, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 22)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxCariSiswa
        '
        Me.TextBoxCariSiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariSiswa.Location = New System.Drawing.Point(311, 28)
        Me.TextBoxCariSiswa.Name = "TextBoxCariSiswa"
        Me.TextBoxCariSiswa.Size = New System.Drawing.Size(84, 22)
        Me.TextBoxCariSiswa.TabIndex = 16
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Image = Global.WindowsApplication1.My.Resources.Resources.increase
        Me.ButtonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambah.Location = New System.Drawing.Point(457, 16)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(108, 45)
        Me.ButtonTambah.TabIndex = 18
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ComboBoxSiswa
        '
        Me.ComboBoxSiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSiswa.FormattingEnabled = True
        Me.ComboBoxSiswa.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxSiswa.Location = New System.Drawing.Point(124, 27)
        Me.ComboBoxSiswa.Name = "ComboBoxSiswa"
        Me.ComboBoxSiswa.Size = New System.Drawing.Size(171, 24)
        Me.ComboBoxSiswa.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Siswa :"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.find1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(487, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 44)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Biodata Siswa"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Username, Me.Column1, Me.Column2, Me.Cancel})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(423, 629)
        Me.DataGridView1.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lime
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(645, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 660)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Kelas"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 440)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(624, 232)
        Me.DataGridView2.TabIndex = 0
        '
        'Column3
        '
        Me.Column3.HeaderText = "No Induk"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Siswa"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Tahun Ajaran"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Rombel"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Wali Kelas"
        Me.Column7.Name = "Column7"
        '
        'Pembagian_Kelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1092, 684)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonProsess)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Pembagian_Kelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembagian_Kelas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ButtonSetujui As System.Windows.Forms.Button
    Friend WithEvents ComboBoxRuang As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxRombel As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxWaliKelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonCariTahun As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTahunAjaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonProsess As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCariWali As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariWali As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCariRuang As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariRuang As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCariRombel As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariRombel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents Username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariSiswa As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSiswa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKelas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
