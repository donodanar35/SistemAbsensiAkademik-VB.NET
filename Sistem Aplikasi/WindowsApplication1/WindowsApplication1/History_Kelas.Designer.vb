<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History_Kelas
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.RadioButtonTTahunAjaran = New System.Windows.Forms.RadioButton()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.RadioButtonID = New System.Windows.Forms.RadioButton()
        Me.ButtonTambahUbah = New System.Windows.Forms.Button()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(901, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(437, 523)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Rekam Jejak Kelas"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(419, 498)
        Me.DataGridView2.TabIndex = 63
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Anggota Kelas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(883, 523)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rekam Jejak Kelas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnId, Me.Column1, Me.Column2, Me.Column8, Me.Column5, Me.Column7, Me.Column9, Me.Column3, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(871, 498)
        Me.DataGridView1.TabIndex = 59
        '
        'ColumnId
        '
        Me.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnId.HeaderText = "ID"
        Me.ColumnId.Name = "ColumnId"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Petugas"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Tahun Ajaran"
        Me.Column2.Name = "Column2"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Kelas"
        Me.Column8.Name = "Column8"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Rombel"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Ruang"
        Me.Column7.Name = "Column7"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Total Siswa"
        Me.Column9.Name = "Column9"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tgl Transaksi"
        Me.Column3.Name = "Column3"
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Detail"
        Me.Column10.Name = "Column10"
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ButtonHapus)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.RadioButtonID)
        Me.GroupBox1.Controls.Add(Me.ButtonTambahUbah)
        Me.GroupBox1.Controls.Add(Me.TextBoxCari)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 158)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kelas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = Global.WindowsApplication1.My.Resources.Resources.Search_icon
        Me.Label7.Location = New System.Drawing.Point(22, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 40)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     "
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.Image = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.ButtonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHapus.Location = New System.Drawing.Point(56, 96)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(85, 42)
        Me.ButtonHapus.TabIndex = 42
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'RadioButtonTTahunAjaran
        '
        Me.RadioButtonTTahunAjaran.AutoSize = True
        Me.RadioButtonTTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTTahunAjaran.Location = New System.Drawing.Point(131, 28)
        Me.RadioButtonTTahunAjaran.Name = "RadioButtonTTahunAjaran"
        Me.RadioButtonTTahunAjaran.Size = New System.Drawing.Size(60, 20)
        Me.RadioButtonTTahunAjaran.TabIndex = 28
        Me.RadioButtonTTahunAjaran.Text = "Kelas"
        Me.RadioButtonTTahunAjaran.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Image = Global.WindowsApplication1.My.Resources.Resources.edit_clear
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(191, 96)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(83, 45)
        Me.ButtonClear.TabIndex = 41
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'RadioButtonID
        '
        Me.RadioButtonID.AutoSize = True
        Me.RadioButtonID.Checked = True
        Me.RadioButtonID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonID.Location = New System.Drawing.Point(56, 28)
        Me.RadioButtonID.Name = "RadioButtonID"
        Me.RadioButtonID.Size = New System.Drawing.Size(39, 20)
        Me.RadioButtonID.TabIndex = 27
        Me.RadioButtonID.TabStop = True
        Me.RadioButtonID.Text = "ID"
        Me.RadioButtonID.UseVisualStyleBackColor = True
        '
        'ButtonTambahUbah
        '
        Me.ButtonTambahUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambahUbah.Image = Global.WindowsApplication1.My.Resources.Resources.Document_Preview_icon
        Me.ButtonTambahUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTambahUbah.Location = New System.Drawing.Point(317, 96)
        Me.ButtonTambahUbah.Name = "ButtonTambahUbah"
        Me.ButtonTambahUbah.Size = New System.Drawing.Size(91, 45)
        Me.ButtonTambahUbah.TabIndex = 40
        Me.ButtonTambahUbah.Text = "Lihat"
        Me.ButtonTambahUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTambahUbah.UseVisualStyleBackColor = True
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCari.Location = New System.Drawing.Point(56, 56)
        Me.TextBoxCari.Multiline = True
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(352, 23)
        Me.TextBoxCari.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.find1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(422, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 32)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Cari"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(1055, 227)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(101, 42)
        Me.ButtonRefresh.TabIndex = 39
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'History_Kelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "History_Kelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekam Jejak Kelas"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonTTahunAjaran As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents RadioButtonID As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonTambahUbah As System.Windows.Forms.Button
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ColumnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
