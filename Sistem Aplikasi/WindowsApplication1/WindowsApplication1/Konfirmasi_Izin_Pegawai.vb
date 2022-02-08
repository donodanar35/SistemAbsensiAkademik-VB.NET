Imports MySql.Data.MySqlClient

Public Class Konfirmasi_Izin_Pegawai
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public ID_PERIZINAN As String = ""
    Public ID_Surat As String
    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from hperizinan_pegawai"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            cmd.Dispose()
            DR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        TextBoxId.Text = temp.ToString + "-" + ComboBoxTahunAjaran.SelectedValue.ToString
        Return temp
    End Function

    Sub tampilTahunAjaran(paramTahun As String)
        ComboBoxTahunAjaran.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select tahun_ajaran From tahun_ajaran WHERE STATUS = 1 AND tahun_ajaran like '%" & paramTahun & "%' ORDER BY tahun_ajaran DESC"
            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("tahun_ajaran")
            da.Fill(dt)

            ComboBoxTahunAjaran.DataSource = dt
            ComboBoxTahunAjaran.DisplayMember = "tahun_ajaran"
            ComboBoxTahunAjaran.ValueMember = "tahun_ajaran"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan tahun_ajaran bermasalah! ")
        End Try
    End Sub

    Sub SetujuiSemua(paramID As String)
        Try
            If TextBoxId.Text <> "" Then
                conn = Form1.koneksi()
                Dim trans As MySqlTransaction = conn.BeginTransaction()
                Try
                    For i As Integer = 0 To DataGridView2.RowCount - 2
                        Dim qs As String = "update dperizinan_pegawai set tgl_disetujui ='" & Format(Now, "yyyy-MM-dd") & "', status = '2', diizinkan = '1', ditolak = '0', persetujuan ='', konfirmasi = 'Diterima' WHERE id_izin = '" & TextBoxId.Text & "'"
                        Dim cmd = New MySqlCommand(qs, conn)
                        cmd.ExecuteNonQuery()
                    Next
                    trans.Commit()
                    MsgBox("Semua surat izin berhasil disetujui!")
                    cmd.Dispose()
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox("surat izin gagal disetujui semuanya!" + ex.ToString)
                End Try
                conn.Close()
            Else
                MsgBox("Id kosong!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub ubahPerizinan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update hperizinan_pegawai set tahun_ajaran ='" & ComboBoxTahunAjaran.SelectedValue.ToString & "', periodeawal ='" & Format(DateTimePickerTglAwal.Value, "yyyy-MM-dd") & "', periodeakhir ='" & Format(DateTimePickerTglAkhir.Value, "yyyy-MM-dd") & "', keterangan ='" & TextBoxKet.Text & "'  WHERE id_izin = '" & TextBoxId.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit perizinan berhasil dilakukan!")
            ID_PERIZINAN = ""
        Catch ex As Exception
            MsgBox("Edit data perizinan gagal dilakukan!")
        End Try
    End Sub

    Sub hapusPerizinan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update hperizinan_pegawai set STATUS=0 WHERE id_izin = '" & ID_PERIZINAN & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data perizinan berhasil dilakukan!")
            ID_PERIZINAN = ""
        Catch ex As Exception
            MsgBox("Hapus data perizinan gagal dilakukan!")
        End Try
    End Sub

    Sub tambahPerizinan()
        Dim indeks As Integer = No()
        Dim id_pegawai As String = Form1.id_pegawai
        If TextBoxId.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "insert into hperizinan_pegawai(ID_IZIN, ID_PEGAWAI, TAHUN_AJARAN, TGL, PERIODEAWAL, PERIODEAKHIR, TOTAL_IZIN, TOTAL_DISETUJUI, KETERANGAN, STATUS) VALUES('" & TextBoxId.Text & "','" & id_pegawai & "','" & ComboBoxTahunAjaran.SelectedValue.ToString & "','" & Format(Now, "yyyy-MM-dd") & "','" & Format(DateTimePickerTglAwal.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerTglAkhir.Value, "yyyy-MM-dd") & "','" & 0 & "','" & 0 & "','" & TextBoxKet.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah data perizinan pegawai berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data perizinan pegawai gagal dilakukan!")
            End Try
        Else
            MsgBox("ID kosong!")
        End If
    End Sub

    Sub tampilHPerizinan()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.STATUS 'STATUS', H.ID_IZIN 'ID_IZIN', H.ID_PEGAWAI 'ID_PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', H.PERIODEAWAL 'PERIODEAWAL', H.PERIODEAKHIR 'PERIODEAKHIR', H.TOTAL_IZIN 'TOTAL_IZIN', H.TOTAL_DISETUJUI 'TOTAL_DISETUJUI', H.KETERANGAN 'KETERANGAN', P.NAMA 'NAMA' FROM HPERIZINAN_PEGAWAI H, PEGAWAI P WHERE H.STATUS >= 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI"

        If RadioButtonID.Checked Then
            qs = "SELECT H.STATUS 'STATUS', H.ID_IZIN 'ID_IZIN', H.ID_PEGAWAI 'ID_PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', H.PERIODEAWAL 'PERIODEAWAL', H.PERIODEAKHIR 'PERIODEAKHIR', H.TOTAL_IZIN 'TOTAL_IZIN', H.TOTAL_DISETUJUI 'TOTAL_DISETUJUI', H.KETERANGAN 'KETERANGAN', P.NAMA 'NAMA' FROM HPERIZINAN_PEGAWAI H, PEGAWAI P WHERE H.STATUS >= 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.ID_IZIN LIKE '%" & TextBoxCari.Text & "%' ORDER BY H.ID_IZIN"
        ElseIf RadioButtonTTahunAjaran.Checked Then
            qs = "SELECT H.STATUS 'STATUS', H.ID_IZIN 'ID_IZIN', H.ID_PEGAWAI 'ID_PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', H.PERIODEAWAL 'PERIODEAWAL', H.PERIODEAKHIR 'PERIODEAKHIR', H.TOTAL_IZIN 'TOTAL_IZIN', H.TOTAL_DISETUJUI 'TOTAL_DISETUJUI', H.KETERANGAN 'KETERANGAN', P.NAMA 'NAMA' FROM HPERIZINAN_PEGAWAI H, PEGAWAI P WHERE H.STATUS >= 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.TAHUN_AJARAN LIKE '%" & TextBoxCari.Text & "%' ORDER BY H.ID_IZIN"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id_izin As String = ""
            Dim pegawai As String = ""
            Dim tahun_ajaran As String = ""
            Dim tgl As String = ""
            Dim tglawal As String = ""
            Dim tglakhir As String = ""
            Dim totalIzin As String = ""
            Dim totalSetujui As String = ""
            Dim ket As String = ""
            Dim status As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id_izin = DRX.Item("ID_IZIN")
                    pegawai = DRX.Item("NAMA")
                    tahun_ajaran = DRX.Item("TAHUN_AJARAN")
                    tgl = DRX.Item("TGL")
                    tglawal = DRX.Item("PERIODEAWAL")
                    tglakhir = DRX.Item("PERIODEAKHIR")
                    ket = DRX.Item("KETERANGAN")
                    totalIzin = DRX.Item("TOTAL_IZIN")
                    totalSetujui = DRX.Item("TOTAL_DISETUJUI")
                    status = DRX.Item("STATUS")
                    If status = "1" Then
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_izin, pegawai, tahun_ajaran, tgl, tglawal, tglakhir, totalIzin, totalSetujui, "aktif", "Detail")
                    ElseIf status = "2" Then
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_izin, pegawai, tahun_ajaran, tgl, tglawal, tglakhir, totalIzin, totalSetujui, "kadaluarsa", "Detail")
                    End If
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan Hperizinan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDPerizinan(idx As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT D.PERSETUJUAN 'PERSETUJUAN', D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.BERLAKUTGL 'BERLAKUTGL', D.SAMPAITGL 'SAMPAITGL',  D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_IZIN LIKE '" & idx & "' ORDER BY STATUS"
        If RadioButtonKetSurat.Checked Then
            qs = "SELECT D.PERSETUJUAN 'PERSETUJUAN', D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.BERLAKUTGL 'BERLAKUTGL', D.SAMPAITGL 'SAMPAITGL',  D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_IZIN LIKE '%" & idx & "%' AND D.KETERANGAN LIKE '" & TextBoxCariSurat.Text & "' ORDER BY STATUS"
        ElseIf RadioButtonIDSurat.Checked Then
            qs = "SELECT D.PERSETUJUAN 'PERSETUJUAN', D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.BERLAKUTGL 'BERLAKUTGL', D.SAMPAITGL 'SAMPAITGL',  D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_IZIN LIKE '%" & idx & "%' AND D.ID LIKE '" & TextBoxCariSurat.Text & "' ORDER BY STATUS"
        End If
        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim pegawai As String = ""
            Dim jenis As String = ""
            Dim tglberlaku As Date = Now
            Dim tglSampai As Date = Now
            Dim tglIzin As Date = Now
            Dim tglSetujui As Date = Now
            Dim ket As String = ""
            Dim status As String = ""
            Dim diizinkan As String = ""
            Dim ditolak As String = ""
            Dim persetujuan As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id = DRX.Item("ID")
                    pegawai = DRX.Item("NAMA")
                    jenis = DRX.Item("JENIS_IZIN")
                    tglberlaku = DRX.Item("BERLAKUTGL")
                    tglSampai = DRX.Item("SAMPAITGL")
                    tglIzin = DRX.Item("TGL_IZIN")
                    ket = DRX.Item("KETERANGAN")
                    status = DRX.Item("STATUS")
                    diizinkan = DRX.Item("DIIZINKAN")
                    ditolak = DRX.Item("DITOLAK")
                    persetujuan = DRX.Item("PERSETUJUAN")
                    If status = "2" And diizinkan = "1" Then
                        status = "Disetujui"
                    ElseIf status = "2" And ditolak = "1" Then
                        status = "Ditolak"
                    ElseIf status = "1" Then
                        status = "Belum"
                    Else
                        status = "Belum"
                    End If
                    If status = "Disetujui" Or status = "Ditolak" Then
                        tglSetujui = DRX.Item("TGL_DISETUJUI")
                        DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, id, pegawai, jenis, Format(tglberlaku, "yyyy-MM-dd"), Format(tglSampai, "yyyy-MM-dd"), Format(tglIzin, "yyyy-MM-dd"), Format(tglSetujui, "yyyy-MM-dd"), ket, status)
                    Else
                        Dim isSetujui As String = "N/A"
                        DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, id, pegawai, jenis, Format(tglberlaku, "yyyy-MM-dd"), Format(tglSampai, "yyyy-MM-dd"), Format(tglIzin, "yyyy-MM-dd"), isSetujui, ket, status)
                    End If
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan Dperizinan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function CekKadaluarsa_PeriodeSuratIzin(ParamTgl As Date)
        Dim qs As String = "SELECT PERIODEAKHIR FROM HPERIZINAN_PEGAWAI WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim tgl As Date
            If DRX.HasRows Then
                While DRX.Read()
                    tgl = DRX.Item("PERIODEAKHIR")
                    Dim STgl As String = Format(tgl, "yyyy-MM-dd")
                    Dim SParamTgl As String = Format(ParamTgl, "yyyy-MM-dd")
                    If SParamTgl > STgl Then
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

    Sub PerbaruiPeriodeSuratIzn()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update hperizinan_pegawai set STATUS=2 WHERE PERIODEAKHIR <'" & Format(Today, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Pembaruan status periode surat izin pegawai berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Pembaruan status periode surat izin pegawai gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Function CekPeriodeSuratIzinKembar()
        Dim qs As String = "SELECT STATUS FROM HPERIZINAN_PEGAWAI WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim status As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    status = DRX.Item("STATUS")
                    If status = "1" Then
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
            MsgBox("Cek periode surat izin bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub Menyetujui_Izin_Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cekPeriodeSurat As String = CekKadaluarsa_PeriodeSuratIzin(Today)
            If cekPeriodeSurat = "1" Then
                Dim result As Integer = MessageBox.Show("Anda yakin memperbarui seluruh periode surat izin yang kadaluarsa?", "Pembaruan Status Periode Surat Izin Pegawai ", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.Yes Then
                    PerbaruiPeriodeSuratIzn()
                    tampilHPerizinan()
                    ID_PERIZINAN = ""
                End If
            End If
            tampilTahunAjaran(TextBoxCariTahunAjaran.Text)
            No()
            tampilHPerizinan()
            clearDAta()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonCariTahun_Click(sender As Object, e As EventArgs) Handles ButtonCariTahun.Click
        tampilTahunAjaran(TextBoxCariTahunAjaran.Text)
        No()
    End Sub

    Private Sub ButtonSetujui_Click(sender As Object, e As EventArgs) Handles ButtonSetujui.Click
        Try
            If ButtonSetujui.Text = "Ubah" Then
                Dim result As Integer = MessageBox.Show("Anda yakin mengubah data perizinan " + ID_PERIZINAN + "?", "Ubah Data Perizinan Pegawai " + ID_PERIZINAN, MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.Yes Then
                    ubahPerizinan()
                    tampilHPerizinan()
                    ID_PERIZINAN = ""
                    ButtonSetujui.Text = "Tambah"
                End If
            Else
                Dim cekPeriodeSurat As String = CekPeriodeSuratIzinKembar()
                If cekPeriodeSurat = "0" Then
                    tambahPerizinan()
                    tampilHPerizinan()
                Else
                    MsgBox("Anda masih mempunyai periode surat izin yang aktif. Silahkan tunggu periode surat izin menjadi kadaluarsa!")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHPerizinan()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ButtonSetujui.Text = "Ubah"
            ID_PERIZINAN = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            tampilDPerizinan(ID_PERIZINAN)
            TextBoxId.Text = ID_PERIZINAN
            'ID_PERIZINAN = ""
            tampilTahunAjaran(DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
            TextBoxKet.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
            DateTimePickerTglAwal.Value = DataGridView1.Rows(e.RowIndex).Cells(4).Value 'Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value, "yyyy-MM-dd")
            DateTimePickerTglAkhir.Value = DataGridView1.Rows(e.RowIndex).Cells(5).Value 'Format(DataGridView1.Rows(e.RowIndex).Cells(5).Value, "yyyy-MM-dd")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearDAta()
    End Sub
    Sub clearDAta()
        RadioButtonID.Checked = False
        RadioButtonTTahunAjaran.Checked = False
        ButtonSetujui.Text = "Tambah"
        tampilHPerizinan()
        tampilTahunAjaran(TextBoxCariTahunAjaran.Text)
        No()
        TextBoxKet.Text = ""
        TextBoxCari.Text = ""
        DateTimePickerTglAkhir.Value = Today
        DateTimePickerTglAwal.Value = Today
        TextBoxCariTahunAjaran.Text = ""
        RadioButtonIDSurat.Checked = False
        RadioButtonKetSurat.Checked = False
        RadioButtonTTahunAjaran.Checked = False
        RadioButtonID.Checked = False
    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            If (DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString = "Disetujui") Or (DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString = "Belum") Or (DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString = "Ditolak") Then
                ID_Surat = DataGridView2.Rows(e.RowIndex).Cells(0).Value
                ' MsgBox(ID_Surat)
                Dim tampilSurat As New Detail_Izin
                tampilSurat.TextBoxID.Text = ID_Surat
                If DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString = "Belum" Then
                    tampilSurat.TextBoxStatus.Text = "Belum disetujui"
                    tampilSurat.ButtonSetujui.Enabled = True
                Else
                    tampilSurat.TextBoxStatus.Text = "Telah disetujui"
                    tampilSurat.ButtonSetujui.Enabled = False
                End If
                tampilSurat.ShowDialog()
                'tampilSurat.ID = ID_Surat
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data perizinan " + ID_PERIZINAN + "?", "Hapus Perizinan Pegawai " + ID_PERIZINAN, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusPerizinan()
                tampilHPerizinan()
                ID_PERIZINAN = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            tampilDPerizinan(TextBoxId.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonSetujuiSemua_Click(sender As Object, e As EventArgs) Handles ButtonSetujuiSemua.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menyetujui semua surat perizinan?", "Setujui Semua Surat Perizinan Pegawai " + ID_PERIZINAN, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                SetujuiSemua(TextBoxId.Text)
                tampilDPerizinan(TextBoxId.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin memperbarui seluruh periode surat izin yang kadaluarsa?", "Pembaruan Status Periode Surat Izin Pegawai ", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                PerbaruiPeriodeSuratIzn()
                tampilHPerizinan()
                ID_PERIZINAN = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class