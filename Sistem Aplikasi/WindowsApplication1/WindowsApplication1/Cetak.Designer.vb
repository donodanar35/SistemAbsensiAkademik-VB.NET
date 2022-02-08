<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.DateTimePickerTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButtonCariTahun = New System.Windows.Forms.Button()
        Me.TextBoxCariTahunAjaran = New System.Windows.Forms.TextBox()
        Me.ComboBoxTahunAjaran = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTglAkhir)
        Me.GroupBox1.Controls.Add(Me.ButtonCetak)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTglAwal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ButtonCariTahun)
        Me.GroupBox1.Controls.Add(Me.TextBoxCariTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTahunAjaran)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 152)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cetak Laporan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sampai Tgl :"
        '
        'DateTimePickerTglAkhir
        '
        Me.DateTimePickerTglAkhir.Location = New System.Drawing.Point(124, 103)
        Me.DateTimePickerTglAkhir.Name = "DateTimePickerTglAkhir"
        Me.DateTimePickerTglAkhir.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerTglAkhir.TabIndex = 5
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCetak.Image = Global.WindowsApplication1.My.Resources.Resources.printer_1_
        Me.ButtonCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCetak.Location = New System.Drawing.Point(340, 84)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(87, 45)
        Me.ButtonCetak.TabIndex = 6
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'DateTimePickerTglAwal
        '
        Me.DateTimePickerTglAwal.Location = New System.Drawing.Point(124, 65)
        Me.DateTimePickerTglAwal.Name = "DateTimePickerTglAwal"
        Me.DateTimePickerTglAwal.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerTglAwal.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Berlaku Tgl :"
        '
        'ButtonCariTahun
        '
        Me.ButtonCariTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCariTahun.Location = New System.Drawing.Point(444, 32)
        Me.ButtonCariTahun.Name = "ButtonCariTahun"
        Me.ButtonCariTahun.Size = New System.Drawing.Size(38, 23)
        Me.ButtonCariTahun.TabIndex = 3
        Me.ButtonCariTahun.Text = "Cari"
        Me.ButtonCariTahun.UseVisualStyleBackColor = True
        '
        'TextBoxCariTahunAjaran
        '
        Me.TextBoxCariTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCariTahunAjaran.Location = New System.Drawing.Point(330, 32)
        Me.TextBoxCariTahunAjaran.Name = "TextBoxCariTahunAjaran"
        Me.TextBoxCariTahunAjaran.Size = New System.Drawing.Size(108, 22)
        Me.TextBoxCariTahunAjaran.TabIndex = 2
        '
        'ComboBoxTahunAjaran
        '
        Me.ComboBoxTahunAjaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTahunAjaran.FormattingEnabled = True
        Me.ComboBoxTahunAjaran.Items.AddRange(New Object() {"manager", "kasir", "admin"})
        Me.ComboBoxTahunAjaran.Location = New System.Drawing.Point(124, 30)
        Me.ComboBoxTahunAjaran.Name = "ComboBoxTahunAjaran"
        Me.ComboBoxTahunAjaran.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxTahunAjaran.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tahun Ajaran :"
        '
        'Cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(521, 175)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cetak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonCariTahun As System.Windows.Forms.Button
    Friend WithEvents TextBoxCariTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTahunAjaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
