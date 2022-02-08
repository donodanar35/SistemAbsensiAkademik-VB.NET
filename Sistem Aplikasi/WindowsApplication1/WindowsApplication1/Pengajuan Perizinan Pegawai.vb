Imports MySql.Data.MySqlClient

Public Class Pengajuan_Perizinan_Pegawai
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public cmdx As MySqlCommand
    Public cmdy As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from dperizinan_pegawai"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            DR.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        TextBoxIDSurat.Text = temp.ToString + "-" + TextBoxTahunAjaran.Text + "-" + usernameku
        Return temp
    End Function

    Sub tampilHPerizinan()
        Dim qs As String = "SELECT ID_IZIN, TAHUN_AJARAN, PERIODEAWAL, PERIODEAKHIR, KETERANGAN FROM HPERIZINAN_PEGAWAI WHERE STATUS ='1' ORDER BY ID_IZIN DESC LIMIT 1"
        usernameku = Form1.username
        Dim temp As String = ""
        Try
            Dim id_izin As String = ""
            Dim tahun As String = ""
            Dim lama As String = ""
            Dim tglawal As Date = Now
            Dim tglakhir As Date = Now
            Dim ket As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    TextBoxIDPerizinan.Text = DRX.Item("ID_IZIN")
                    TextBoxTahunAjaran.Text = DRX.Item("TAHUN_AJARAN")
                    DateTimePickerPeriodeAwal.Value = DRX.Item("PERIODEAWAL")
                    DateTimePickerPeriodeAkhir.Value = DRX.Item("PERIODEAKHIR")
                    TextBoxKetPerizinan.Text = DRX.Item("KETERANGAN")
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan Hperizinan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Public totalIzin As String
    Function HitungTotalIzin()
        Try
            Dim qs As String = "SELECT COUNT(*) 'NO' FROM DPERIZINAN_PEGAWAI D, HPERIZINAN_PEGAWAI H WHERE D.ID_IZIN = H.ID_IZIN AND D.STATUS >= 1 AND D.ID_IZIN ='" & TextBoxIDPerizinan.Text & "'"
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    totalIzin = DRX.Item("NO")
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
        Catch ex As Exception
            MsgBox("Hitung total izin gagal! " + ex.ToString)
        End Try
        Return totalIzin
    End Function

    Public IDIZIN As String
    Sub tampilDPerizinan(IDpegawai As String)
        Dim qs As String = "SELECT D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', D.ID_IZIN 'ID_IZIN', D.SAMPAITGL 'SAMPAITGL', D.BERLAKUTGL 'BERLAKUTGL', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_PEGAWAI LIKE '%" & IDpegawai & "%' ORDER BY STATUS"
        If RadioButtonID.Checked Then
            qs = "SELECT D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', D.ID_IZIN 'ID_IZIN', D.SAMPAITGL 'SAMPAITGL', D.BERLAKUTGL 'BERLAKUTGL', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_PEGAWAI LIKE '%" & IDpegawai & "%' AND D.ID LIKE '%" & TextBoxCari.Text & "%' ORDER BY STATUS"
        ElseIf RadioButtonKet.Checked Then
            qs = "SELECT D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', D.ID_IZIN 'ID_IZIN', D.SAMPAITGL 'SAMPAITGL', D.BERLAKUTGL 'BERLAKUTGL', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_PEGAWAI LIKE '%" & IDpegawai & "%' AND D.KETERANGAN LIKE '%" & TextBoxCari.Text & "%' ORDER BY STATUS"
        End If

        usernameku = Form1.username
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim pegawai As String = ""
            Dim lama As String = ""
            Dim jenis As String = ""
            Dim tglIzin As Date = Now
            Dim tglSetujui As Date = Now
            Dim tglBerlaku As Date = Now
            Dim tglSampai As Date = Now
            Dim ket As String = ""
            Dim status As String = ""
            Dim diizinkan As String = ""
            Dim ditolak As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader


            If DRX.HasRows Then
                While DRX.Read()
                    IDIZIN = DRX.Item("ID_IZIN")
                    id = DRX.Item("ID")
                    pegawai = DRX.Item("NAMA")
                    jenis = DRX.Item("JENIS_IZIN")
                    tglIzin = DRX.Item("TGL_IZIN")
                    tglBerlaku = DRX.Item("BERLAKUTGL")
                    tglSampai = DRX.Item("SAMPAITGL")
                    ket = DRX.Item("KETERANGAN")
                    status = DRX.Item("STATUS")
                    diizinkan = DRX.Item("DIIZINKAN")
                    ditolak = DRX.Item("DITOLAK")
                    If status = "2" And diizinkan = "1" Then
                        status = "Disetujui"
                    ElseIf status = "2" And ditolak = "1" Then
                        status = "Ditolak"
                    ElseIf status = "1" And ditolak = "0" And diizinkan = "0" Then
                        status = "Belum"
                    ElseIf status = "1" Then
                        status = "Belum"
                    Else
                        status = "Belum"
                    End If
                    Dim isSetujui As String = "N/A"
                    If status = "Belum" Then
                        isSetujui = "N/A"
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, pegawai, id, jenis, Format(tglBerlaku, "yyyy-MM-dd"), Format(tglSampai, "yyyy-MM-dd"), Format(tglIzin, "yyyy-MM-dd"), isSetujui, ket, status)
                    Else
                        tglSetujui = Format(DRX.Item("TGL_DISETUJUI"), "yyyy-MM-dd")
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, pegawai, id, jenis, Format(tglBerlaku, "yyyy-MM-dd"), Format(tglSampai, "yyyy-MM-dd"), Format(tglIzin, "yyyy-MM-dd"), Format(tglSetujui, "yyyy-MM-dd"), ket, status)
                    End If
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DR.Dispose()
            DR.Close()
            DRX.Dispose()
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan Dperizinan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahSuratPerizinan()
        Dim indeks As Integer = No()
        Dim idPegawai As String = Form1.id_pegawai
        If TextBoxIDSurat.Text <> "" Or TextBoxKetPengajuan.Text <> "" Then
            Try
                Dim qs As String = ""
                Dim id_pegawaix As String = Form1.username
                Dim keperluan As String = "Dinas"
                If RadioButtonDinas.Checked Then
                    keperluan = "Dinas"
                    qs = "insert into dperizinan_pegawai(ID, ID_IZIN, ID_PEGAWAI, JENIS_IZIN, TGL_IZIN, BERLAKUTGL, SAMPAITGL, KETERANGAN, STATUS, DINAS, SAKIT, LAINNYA)VALUES('" & TextBoxIDSurat.Text & "','" & TextBoxIDPerizinan.Text & "','" & idPegawai & "','" & keperluan & "','" & Format(Today, "yyyy-MM-dd") & "','" & Format(DateTimePickerBerlakuTgl.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerSampaiTgl.Value, "yyyy-MM-dd") & "','" & TextBoxKetPengajuan.Text & "','1',1,0,0)"
                ElseIf RadioButtoSakit.Checked Then
                    keperluan = "Sakit"
                    qs = "insert into dperizinan_pegawai(ID, ID_IZIN, ID_PEGAWAI, JENIS_IZIN, TGL_IZIN, BERLAKUTGL, SAMPAITGL, KETERANGAN, STATUS, DINAS, SAKIT, LAINNYA)VALUES('" & TextBoxIDSurat.Text & "','" & TextBoxIDPerizinan.Text & "','" & idPegawai & "','" & keperluan & "','" & Format(Today, "yyyy-MM-dd") & "','" & Format(DateTimePickerBerlakuTgl.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerSampaiTgl.Value, "yyyy-MM-dd") & "','" & TextBoxKetPengajuan.Text & "','1',0,1,0)"
                ElseIf RadioButtonLainnya.Checked Then
                    keperluan = "Lainnya"
                    qs = "insert into dperizinan_pegawai(ID, ID_IZIN, ID_PEGAWAI, JENIS_IZIN, TGL_IZIN, BERLAKUTGL, SAMPAITGL, KETERANGAN, STATUS, DINAS, SAKIT, LAINNYA)VALUES('" & TextBoxIDSurat.Text & "','" & TextBoxIDPerizinan.Text & "','" & idPegawai & "','" & keperluan & "','" & Format(Today, "yyyy-MM-dd") & "','" & Format(DateTimePickerBerlakuTgl.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerSampaiTgl.Value, "yyyy-MM-dd") & "','" & TextBoxKetPengajuan.Text & "','1',0,0,1)"
                End If
                conn = Form1.koneksi()
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
                MsgBox("Tambah data surat perizinan pegawai berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data surat perizinan pegawai gagal dilakukan! " + ex.ToString)
            End Try
        Else
            MsgBox("ID kosong!")
        End If
    End Sub

    Sub ubahTotalIzin()
        Try
            Dim tIzin As Integer = HitungTotalIzin()
            conn = Form1.koneksi()
            Dim qs As String = "update hperizinan_pegawai set total_izin =" & tIzin & " WHERE id_izin = '" & TextBoxIDPerizinan.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Total izin pegawai gagal! " + ex.ToString)
        End Try
    End Sub

    Private Sub Pengajuan_Perizinan_Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idPegawai As String = Form1.id_pegawai
        tampilHPerizinan()
        No()
        tampilDPerizinan(idPegawai)
        TextBoxPegawai.Text = Form1.nama
    End Sub

    Private Sub ButtonProsess_Click(sender As Object, e As EventArgs) Handles ButtonProsess.Click
        Try
            If TextBoxIDPerizinan.Text <> "" Then
                Dim result As Integer = MessageBox.Show("Perhatian! Anda tidak bisa menghapus atau mengedit surat izin yang akan anda ajukan. Periksa kembali surat izin anda sebelum mengirimnya. Anda yakin hendak mengirim surat izin sekarang?", "Kirim Surat Izin ", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.Yes Then
                    Dim idPegawai As String = Form1.id_pegawai
                    tambahSuratPerizinan()
                    ubahTotalIzin()
                    tampilDPerizinan(idPegawai)
                    ClearData()
                End If
            Else
                MsgBox("Untuk sementara anda tidak bisa mengajukan surat perizinan pegawai karena periode perizinan pegawai belum tersedia. Untuk informasi lebih lanjut, silahkan hubungi kepala sekolah! Terima kasih.")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim idPegawai As String = Form1.id_pegawai
            tampilDPerizinan(idPegawai)
        Catch ex As Exception
        End Try
    End Sub

    Sub ClearData()
        DateTimePickerSampaiTgl.Value = Today
        DateTimePickerBerlakuTgl.Value = Today
        RadioButtonDinas.Checked = True
        TextBoxKetPengajuan.Text = ""
        TextBoxCari.Text = ""
        No()
        tampilHPerizinan()
        Dim idPegawai As String = Form1.id_pegawai
        tampilDPerizinan(idPegawai)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearData()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Try
            Dim cetak As New Preview
            Dim idPegawai As String = Form1.id_pegawai
            cetak.id = TextBoxIDSurat.Text
            cetak.id_pegawai = idPegawai
            cetak.printWhat = "surat_izin"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(8).Value <> "" Then
                TextBoxIDSurat.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub PerbaruiBacaSurat(paramIDSurat As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update dperizinan_pegawai set BACA=1 WHERE ID ='" & paramIDSurat & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Perbarui baca persetujuan surat izin gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Function Cek_BacaSuratPersetujuan(ParamIDPegawai As String, paramIDSurat As String)
        Dim qs As String = "SELECT BACA FROM DPERIZINAN_PEGAWAI WHERE STATUS = 2 AND  ID_PEGAWAI LIKE '" & ParamIDPegawai & "' AND ID LIKE '" & paramIDSurat & "'"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim baca As String
            If DRX.HasRows Then
                While DRX.Read()
                    baca = DRX.Item("BACA")
                    If baca = "1" Then
                        temp = "1"
                        Exit While
                    End If
                End While
            Else
                temp = "0"
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("notifikasi jadwal bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim idPegawai As String = Form1.id_pegawai
            Dim cekBacaSurat As String = Cek_BacaSuratPersetujuan(idPegawai, TextBoxIDSurat.Text)
            If cekBacaSurat = "0" Then
                PerbaruiBacaSurat(TextBoxIDSurat.Text)
            End If
                Dim cetak As New Preview
                cetak.id = TextBoxIDSurat.Text
                cetak.id_pegawai = idPegawai
                cetak.printWhat = "surat_persetujuan"
                cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(8).Value <> "" Then
                TextBoxIDSurat.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class