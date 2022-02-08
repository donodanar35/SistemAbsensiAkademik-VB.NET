Imports MySql.Data.MySqlClient

Public Class home
    Public notice As String = 0
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("satuan")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public jabatan As String = Form1.jabatan
    Public username As String = Form1.username
    Public myName As String = Form1.nama

    Function AmbilJabatan(paramIDPegawai As String)
        Dim temp As New ArrayList
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "SELECT J.JABATAN 'JABATAN' FROM JABATAN J, DETAIL_JABATAN DJ WHERE DJ.STATUS = 1 AND J.ID_JABATAN = DJ.ID_JABATAN AND DJ.ID_PEGAWAI ='" & paramIDPegawai & "' GROUP BY J.JABATAN"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then

                While DR.Read()
                    temp.Add(DR.Item("JABATAN"))
                End While
            End If
            cmd.Dispose()
            DR.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub cekHakAkses()
        Dim id As String = Form1.id_pegawai
        Dim temp As New ArrayList
        temp = AmbilJabatan(id)
        Dim cekjabatan As String = ""
        If temp.Count = 0 Then
            MasterToolStripMenuItem.Visible = False

            PembagianKelasToolStripMenuItem.Visible = False
            TransaksiPembagianKelasToolStripMenuItem.Visible = False
            RekamJejakKelasToolStripMenuItem.Visible = False

            JadwalMataPelajaranToolStripMenuItem.Visible = False
            TransaksiJadwalMataPelajaranToolStripMenuItem.Visible = False
            RekamJejakJadwalMataPelajaranToolStripMenuItem.Visible = False

            PerizinanPegawaiToolStripMenuItem.Visible = True
            BuatPerizinanPeriodikToolStripMenuItem.Visible = False
            AjukanPerizinanToolStripMenuItem.Visible = True

            AbsensiPegawaiToolStripMenuItem.Visible = False
            TransaksiAbsensiPegawaiToolStripMenuItem.Visible = False
            RekamJejakAbsensiPegawaiToolStripMenuItem.Visible = False

            AbsensiSiswaToolStripMenuItem.Visible = False
            TransaksiAbsensiSiswaToolStripMenuItem.Visible = False
            RekamJejakAbsensiSiswaToolStripMenuItem.Visible = False

            KelasPeriodikToolStripMenuItem.Visible = False
            JadwalPeriodikToolStripMenuItem.Visible = True
            JadwalMengajarToolStripMenuItem.Visible = True
            JadwalMengajarPeriodikToolStripMenuItem.Visible = False
            RekapitulasiPerizinanPegawaiToolStripMenuItem.Visible = False
            RekapitulasiAbsensiPegawaiToolStripMenuItem.Visible = False
            RekapitulasiAbsensiSiswaToolStripMenuItem.Visible = False

            'cek surat izin terkonfirmasi
            Dim MyidPegawai As String = Form1.id_pegawai
            Dim MycekSuratIzin As String = CekSuratIzin_Terkonfirmasi(MyidPegawai)
            If MycekSuratIzin = "1" Then
                NotifyIconSuratIzinTerkonfirmasi.Visible = True
                NotifyIconSuratIzinTerkonfirmasi.BalloonTipText = "Surat izin anda telah dikonfirmasi. Silahkan baca persetujuan surat izin anda!"
                NotifyIconSuratIzinTerkonfirmasi.BalloonTipTitle = "Surat Izin Terkonfirmasi"
                NotifyIconSuratIzinTerkonfirmasi.Text = "Notifikasi Surat Izin Pegawai Terkonfirmasi"
                NotifyIconSuratIzinTerkonfirmasi.ShowBalloonTip(5000)
            End If
        Else
            For Each cekjabatan In temp
                'MsgBox(cekjabatan)
                If cekjabatan = "TU" Then
                    MasterToolStripMenuItem.Visible = True

                    PembagianKelasToolStripMenuItem.Visible = True
                    PindahKelasToolStripMenuItem.Visible = True
                    TransaksiPembagianKelasToolStripMenuItem.Visible = True
                    RekamJejakKelasToolStripMenuItem.Visible = True

                    JadwalMataPelajaranToolStripMenuItem.Visible = False
                    TransaksiJadwalMataPelajaranToolStripMenuItem.Visible = False
                    RekamJejakJadwalMataPelajaranToolStripMenuItem.Visible = False

                    PerizinanPegawaiToolStripMenuItem.Visible = True
                    BuatPerizinanPeriodikToolStripMenuItem.Visible = False
                    AjukanPerizinanToolStripMenuItem.Visible = True

                    AbsensiPegawaiToolStripMenuItem.Visible = True
                    TransaksiAbsensiPegawaiToolStripMenuItem.Visible = True
                    RekamJejakAbsensiPegawaiToolStripMenuItem.Visible = True

                    AbsensiSiswaToolStripMenuItem.Visible = True
                    TransaksiAbsensiSiswaToolStripMenuItem.Visible = True
                    RekamJejakAbsensiSiswaToolStripMenuItem.Visible = True

                    KelasPeriodikToolStripMenuItem.Visible = True
                    JadwalPeriodikToolStripMenuItem.Visible = True
                    JadwalMengajarToolStripMenuItem.Visible = True
                    JadwalMengajarPeriodikToolStripMenuItem.Visible = True
                    RekapitulasiPerizinanPegawaiToolStripMenuItem.Visible = True
                    RekapitulasiAbsensiPegawaiToolStripMenuItem.Visible = True
                    RekapitulasiAbsensiSiswaToolStripMenuItem.Visible = True

                    'cek masa jabatan
                    Dim cekMasaJabatan As String = CekKadaluarsa_MasaJabatan(Today)
                    If cekMasaJabatan = "1" Then
                        NotifyIconMasaJabatan.Visible = True
                        NotifyIconMasaJabatan.BalloonTipText = "Anda mempunyai akun masa jabatan yang kadaluarsa"
                        NotifyIconMasaJabatan.BalloonTipTitle = "Akun Masa Jabatan Kadaluarsa"
                        NotifyIconMasaJabatan.Text = "Notifikasi Masa Jabatan"
                        NotifyIconMasaJabatan.ShowBalloonTip(5000)
                    End If

                    'cek surat izin terkonfirmasi
                    Dim MyidPegawai As String = Form1.id_pegawai
                    Dim MycekSuratIzin As String = CekSuratIzin_Terkonfirmasi(MyidPegawai)
                    If MycekSuratIzin = "1" Then
                        NotifyIconSuratIzinTerkonfirmasi.Visible = True
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipText = "Surat izin anda telah dikonfirmasi. Silahkan baca persetujuan surat izin anda!"
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipTitle = "Surat Izin Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.Text = "Notifikasi Surat Izin Pegawai Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.ShowBalloonTip(5000)
                    End If
                ElseIf cekjabatan = "kepsek" Then
                    MasterToolStripMenuItem.Visible = False
                    'MsgBox("cek kepsek")
                    PembagianKelasToolStripMenuItem.Visible = False
                    TransaksiPembagianKelasToolStripMenuItem.Visible = False
                    RekamJejakKelasToolStripMenuItem.Visible = False

                    JadwalMataPelajaranToolStripMenuItem.Visible = False
                    TransaksiJadwalMataPelajaranToolStripMenuItem.Visible = False
                    RekamJejakJadwalMataPelajaranToolStripMenuItem.Visible = False

                    PerizinanPegawaiToolStripMenuItem.Visible = True
                    BuatPerizinanPeriodikToolStripMenuItem.Visible = True
                    AjukanPerizinanToolStripMenuItem.Visible = True

                    AbsensiPegawaiToolStripMenuItem.Visible = False
                    TransaksiAbsensiPegawaiToolStripMenuItem.Visible = False
                    RekamJejakAbsensiPegawaiToolStripMenuItem.Visible = False

                    AbsensiSiswaToolStripMenuItem.Visible = False
                    TransaksiAbsensiSiswaToolStripMenuItem.Visible = False
                    RekamJejakAbsensiSiswaToolStripMenuItem.Visible = False

                    KelasPeriodikToolStripMenuItem.Visible = True
                    JadwalPeriodikToolStripMenuItem.Visible = True
                    JadwalMengajarToolStripMenuItem.Visible = True
                    JadwalMengajarPeriodikToolStripMenuItem.Visible = True
                    RekapitulasiPerizinanPegawaiToolStripMenuItem.Visible = True
                    RekapitulasiAbsensiPegawaiToolStripMenuItem.Visible = True
                    RekapitulasiAbsensiSiswaToolStripMenuItem.Visible = True

                    'cek kadalursa periode surat izin
                    'MsgBox("cek kepsek")
                    Dim cekPeriodeSuratIzin As String = CekKadaluarsa_PeriodeSuratIzin(Today)
                    If cekPeriodeSuratIzin = "1" Then
                        NotifyIconPeriodeSuratIzin.Visible = True
                        NotifyIconPeriodeSuratIzin.BalloonTipText = "Anda mempunyai akun periode surat izin pegawai yang kadaluarsa"
                        NotifyIconPeriodeSuratIzin.BalloonTipTitle = "Akun Periode Surat Izin Pegawai Kadaluarsa"
                        NotifyIconPeriodeSuratIzin.Text = "Notifikasi Periode Surat Izin Pegawai"
                        NotifyIconPeriodeSuratIzin.ShowBalloonTip(5000)
                    End If

                    'cek surat izin baru
                    Dim idPegawai As String = Form1.id_pegawai
                    Dim cekSuratIzinBaru As String = CekSuratIzin_Baru(idPegawai)
                    If cekSuratIzinBaru = "1" Then
                        NotifyIconSuratIzinBaru.Visible = True
                        NotifyIconSuratIzinBaru.BalloonTipText = "Anda menerima surat izin pegawai baru."
                        NotifyIconSuratIzinBaru.BalloonTipTitle = "Surat Izin Pegawai Baru"
                        NotifyIconSuratIzinBaru.Text = "Notifikasi Surat Izin Pegawai Baru"
                        NotifyIconSuratIzinBaru.ShowBalloonTip(5000)
                        'MsgBox("cek kepsek")
                    End If

                    'cek surat izin terkonfirmasi
                    Dim MyidPegawai As String = Form1.id_pegawai
                    Dim MycekSuratIzin As String = CekSuratIzin_Terkonfirmasi(MyidPegawai)
                    If MycekSuratIzin = "1" Then
                        NotifyIconSuratIzinTerkonfirmasi.Visible = True
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipText = "Surat izin anda telah dikonfirmasi. Silahkan baca persetujuan surat izin anda!"
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipTitle = "Surat Izin Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.Text = "Notifikasi Surat Izin Pegawai Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.ShowBalloonTip(5000)
                    End If
                ElseIf cekjabatan = "wakasek" Then
                    MasterToolStripMenuItem.Visible = False

                    PembagianKelasToolStripMenuItem.Visible = False
                    TransaksiPembagianKelasToolStripMenuItem.Visible = False
                    RekamJejakKelasToolStripMenuItem.Visible = False

                    JadwalMataPelajaranToolStripMenuItem.Visible = True
                    TransaksiJadwalMataPelajaranToolStripMenuItem.Visible = True
                    RekamJejakJadwalMataPelajaranToolStripMenuItem.Visible = True

                    PerizinanPegawaiToolStripMenuItem.Visible = True
                    BuatPerizinanPeriodikToolStripMenuItem.Visible = False
                    AjukanPerizinanToolStripMenuItem.Visible = True

                    AbsensiPegawaiToolStripMenuItem.Visible = False
                    TransaksiAbsensiPegawaiToolStripMenuItem.Visible = False
                    RekamJejakAbsensiPegawaiToolStripMenuItem.Visible = False

                    AbsensiSiswaToolStripMenuItem.Visible = False
                    TransaksiAbsensiSiswaToolStripMenuItem.Visible = False
                    RekamJejakAbsensiSiswaToolStripMenuItem.Visible = False

                    KelasPeriodikToolStripMenuItem.Visible = False
                    JadwalPeriodikToolStripMenuItem.Visible = True
                    JadwalMengajarToolStripMenuItem.Visible = True
                    JadwalMengajarPeriodikToolStripMenuItem.Visible = True
                    RekapitulasiPerizinanPegawaiToolStripMenuItem.Visible = False
                    RekapitulasiAbsensiPegawaiToolStripMenuItem.Visible = False
                    RekapitulasiAbsensiSiswaToolStripMenuItem.Visible = False

                    'cek jadwal
                    Dim cekJadwal As String = CekKadaluarsa_Jadwal(Today)
                    If cekJadwal = "1" Then
                        NotifyIconJadwal.Visible = True
                        NotifyIconJadwal.BalloonTipText = "Anda mempunyai jadwal yang kadaluarsa"
                        NotifyIconJadwal.BalloonTipTitle = "Jadwal Kadaluarsa"
                        NotifyIconJadwal.Text = "Notifikasi Jadwal"
                        NotifyIconJadwal.ShowBalloonTip(5000)
                    End If

                    'cek surat izin terkonfirmasi
                    Dim MyidPegawai As String = Form1.id_pegawai
                    Dim MycekSuratIzin As String = CekSuratIzin_Terkonfirmasi(MyidPegawai)
                    If MycekSuratIzin = "1" Then
                        NotifyIconSuratIzinTerkonfirmasi.Visible = True
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipText = "Surat izin anda telah dikonfirmasi. Silahkan baca persetujuan surat izin anda!"
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipTitle = "Surat Izin Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.Text = "Notifikasi Surat Izin Pegawai Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.ShowBalloonTip(5000)
                    End If
                Else
                    MasterToolStripMenuItem.Visible = False

                    PembagianKelasToolStripMenuItem.Visible = False
                    TransaksiPembagianKelasToolStripMenuItem.Visible = False
                    RekamJejakKelasToolStripMenuItem.Visible = False

                    JadwalMataPelajaranToolStripMenuItem.Visible = False
                    TransaksiJadwalMataPelajaranToolStripMenuItem.Visible = False
                    RekamJejakJadwalMataPelajaranToolStripMenuItem.Visible = False

                    PerizinanPegawaiToolStripMenuItem.Visible = True
                    BuatPerizinanPeriodikToolStripMenuItem.Visible = False
                    AjukanPerizinanToolStripMenuItem.Visible = True

                    AbsensiPegawaiToolStripMenuItem.Visible = False
                    TransaksiAbsensiPegawaiToolStripMenuItem.Visible = False
                    RekamJejakAbsensiPegawaiToolStripMenuItem.Visible = False

                    AbsensiSiswaToolStripMenuItem.Visible = False
                    TransaksiAbsensiSiswaToolStripMenuItem.Visible = False
                    RekamJejakAbsensiSiswaToolStripMenuItem.Visible = False

                    KelasPeriodikToolStripMenuItem.Visible = False
                    JadwalPeriodikToolStripMenuItem.Visible = True
                    JadwalMengajarToolStripMenuItem.Visible = True
                    JadwalMengajarPeriodikToolStripMenuItem.Visible = False
                    RekapitulasiPerizinanPegawaiToolStripMenuItem.Visible = False
                    RekapitulasiAbsensiPegawaiToolStripMenuItem.Visible = False
                    RekapitulasiAbsensiSiswaToolStripMenuItem.Visible = False

                    'cek surat izin terkonfirmasi
                    Dim MyidPegawai As String = Form1.id_pegawai
                    Dim MycekSuratIzin As String = CekSuratIzin_Terkonfirmasi(MyidPegawai)
                    If MycekSuratIzin = "1" Then
                        NotifyIconSuratIzinTerkonfirmasi.Visible = True
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipText = "Surat izin anda telah dikonfirmasi. Silahkan baca persetujuan surat izin anda!"
                        NotifyIconSuratIzinTerkonfirmasi.BalloonTipTitle = "Surat Izin Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.Text = "Notifikasi Surat Izin Pegawai Terkonfirmasi"
                        NotifyIconSuratIzinTerkonfirmasi.ShowBalloonTip(5000)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim login As New Form1
        login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub KonfigurasiUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KonfigurasiUserToolStripMenuItem1.Click
        Dim konf_user As New konf_user
        konf_user.ShowDialog()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim karyawan As New karyawan
        karyawan.ShowDialog()
    End Sub

    Private Sub TokoMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilUser()
        cekHakAkses()
    End Sub

    Sub tampilUser()
        LinkLabelUsername.Text = myName
        LabelJabatan.Text = jabatan
    End Sub


    Private Sub MataPelajaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataPelajaranToolStripMenuItem.Click
        Dim mapel As New mapel
        mapel.ShowDialog()
    End Sub

    Private Sub RombonganBelajarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RombonganBelajarToolStripMenuItem.Click
        Dim rombel As New rombel
        rombel.ShowDialog()
    End Sub

    Private Sub RuangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuangToolStripMenuItem.Click
        Dim ruang As New Ruang
        ruang.ShowDialog()
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        Dim pegawai As New karyawan
        pegawai.ShowDialog()
    End Sub

    Private Sub SiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaToolStripMenuItem.Click
        Dim siswa As New Siswa
        siswa.ShowDialog()
    End Sub

    Private Sub JabatanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JabatanToolStripMenuItem1.Click
        Dim jabatan As New jabatan
        jabatan.ShowDialog()
    End Sub

    Private Sub MasaJabatanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasaJabatanToolStripMenuItem.Click
        Dim jabatan As New Menjabat
        jabatan.ShowDialog()
    End Sub

    Private Sub MutasiSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MutasiSiswaToolStripMenuItem.Click
        Dim mutusi As New mutasi
        mutusi.ShowDialog()
    End Sub

    Private Sub BuatPerizinanPeriodikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatPerizinanPeriodikToolStripMenuItem.Click
        Dim menyetujui As New Konfirmasi_Izin_Pegawai
        menyetujui.ShowDialog()
    End Sub

    Private Sub AjukanPerizinanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjukanPerizinanToolStripMenuItem.Click
        Dim ajukan As New Pengajuan_Perizinan_Pegawai
        ajukan.ShowDialog()
    End Sub

    Private Sub JadwalMengajarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadwalMengajarToolStripMenuItem.Click
        Try
            Dim id_pegawai As String = Form1.id_pegawai
            'MsgBox(id_pegawai)
            Dim cetak As New Preview
            cetak.id = id_pegawai
            cetak.printWhat = "jadwal"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PerTahunAjaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerTahunAjaranToolStripMenuItem.Click
        Dim cetak As New Cetak
        cetak.Text = "Cetak Laporan Pembagian Kelas"
        cetak.DateTimePickerTglAwal.Enabled = False
        cetak.DateTimePickerTglAkhir.Enabled = False
        cetak.PilihLaporan = "laporan_kelas"
        cetak.ShowDialog()
    End Sub

    Private Sub JadwalMengajarPeriodikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadwalMengajarPeriodikToolStripMenuItem.Click
        Dim cetak As New Cetak
        cetak.Text = "Cetak Laporan Jadwal Mata Pelajaran"
        cetak.PilihLaporan = "laporan_jadwal"
        cetak.ShowDialog()
    End Sub

    Private Sub RekapitulasiPerizinanPegawaiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RekapitulasiPerizinanPegawaiToolStripMenuItem1.Click
        Dim cetak As New Cetak
        cetak.Text = "Cetak Laporan Rekapitulasi Perizinan Pegawai"
        cetak.PilihLaporan = "laporan_perizinan_pegawai"
        cetak.ShowDialog()
    End Sub

    Private Sub RekapitulasiAbsensiPegawaiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RekapitulasiAbsensiPegawaiToolStripMenuItem1.Click
        Dim cetak As New Cetak
        cetak.Text = "Cetak Laporan Rekapitulasi Absensi Pegawai"
        cetak.PilihLaporan = "laporan_absensi_pegawai"
        cetak.ShowDialog()
    End Sub

    Private Sub RekapitulasiAbsensiSiswaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RekapitulasiAbsensiSiswaToolStripMenuItem1.Click
        Dim cetak As New Cetak
        cetak.Text = "Cetak Laporan Rekapitulasi Absensi Siswa"
        cetak.PilihLaporan = "laporan_absensi_siswa"
        cetak.ShowDialog()
    End Sub

    Private Sub TahunAjaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TahunAjaranToolStripMenuItem.Click
        Dim thn As New tahun_ajar
        thn.ShowDialog()
    End Sub

    Private Sub LinkLabelUsername_Click(sender As Object, e As EventArgs) Handles LinkLabelUsername.Click
        Dim frm As New konf_user
        frm.ShowDialog()
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Dispose()
    End Sub

    Private Sub TransaksiAbsensiPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiAbsensiPegawaiToolStripMenuItem.Click
        Dim absensi_pegawai As New absensi_pegawai
        absensi_pegawai.ShowDialog()
    End Sub

    Private Sub RekamJejakAbsensiPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamJejakAbsensiPegawaiToolStripMenuItem.Click
        Dim absensi_pegawai As New History_Absensi_Pegawai
        absensi_pegawai.ShowDialog()
    End Sub

    Private Sub TransaksiAbsensiSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiAbsensiSiswaToolStripMenuItem.Click
        Dim absensi_siswa As New Absensi_Siswa
        absensi_siswa.ShowDialog()
    End Sub

    Private Sub RekamJejakAbsensiSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamJejakAbsensiSiswaToolStripMenuItem.Click
        Dim absensi_siswa As New History_Absensi_Siswa
        absensi_siswa.ShowDialog()
    End Sub

    Private Sub TransaksiPembagianKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPembagianKelasToolStripMenuItem.Click
        Dim kelas As New Pembagian_Kelas
        kelas.ShowDialog()
    End Sub

    Private Sub RekamJejakKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamJejakKelasToolStripMenuItem.Click
        Dim kelas As New History_Kelas
        kelas.ShowDialog()
    End Sub

    Private Sub TransaksiJadwalMataPelajaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiJadwalMataPelajaranToolStripMenuItem.Click
        Dim jadwal As New jadwal
        jadwal.ShowDialog()
    End Sub

    Private Sub RekamJejakJadwalMataPelajaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamJejakJadwalMataPelajaranToolStripMenuItem.Click
        Dim jadwal As New history_jadwa
        jadwal.ShowDialog()
    End Sub

    Function CekKadaluarsa_MasaJabatan(ParamTgl As Date)
        Dim qs As String = "SELECT AKHIR_BAKTI FROM DETAIL_JABATAN WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim tgl As Date
            If DRX.HasRows Then
                While DRX.Read()
                    tgl = DRX.Item("AKHIR_BAKTI")
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
            MsgBox("notifikasi masa jabatan bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function CekKadaluarsa_Jadwal(ParamTgl As Date)
        Dim qs As String = "SELECT SAMPAITGL FROM JADWAL WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim tgl As Date
            If DRX.HasRows Then
                While DRX.Read()
                    tgl = DRX.Item("SAMPAITGL")
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

    Function CekSuratIzin_Baru(ParamIDPegawai As String)
        Dim qs As String = "SELECT ID FROM DPERIZINAN_PEGAWAI WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            If DRX.HasRows Then
                temp = "1"
            Else
                temp = "0"
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("notifikasi surat izin baru bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function CekSuratIzin_Terkonfirmasi(ParamIDPegawai As String)
        Dim qs As String = "SELECT ID FROM DPERIZINAN_PEGAWAI WHERE STATUS = 2 AND ID_PEGAWAI ='" & ParamIDPegawai & "' AND BACA =0"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            If DRX.HasRows Then
                temp = "1"
            Else
                temp = "0"
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("notifikasi surat izin terkonfirmasi bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub NotifyIconMasaJabatan_Click(sender As Object, e As EventArgs) Handles NotifyIconMasaJabatan.Click
        Dim masaJabatan As New Menjabat
        masaJabatan.ShowDialog()
    End Sub

    Private Sub NotifyIconMasaJabatan_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIconMasaJabatan.BalloonTipClicked
        Dim masaJabatan As New Menjabat
        masaJabatan.ShowDialog()
    End Sub

    Private Sub NotifyIconJadwal_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIconJadwal.BalloonTipClicked
        Dim jadwal As New history_jadwa
        jadwal.ShowDialog()
    End Sub

    Private Sub NotifyIconJadwal_Click(sender As Object, e As EventArgs) Handles NotifyIconJadwal.Click
        Dim jadwal As New history_jadwa
        jadwal.ShowDialog()
    End Sub

    Private Sub NotifyIconSuratIzinBaru_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIconSuratIzinBaru.BalloonTipClicked
        Dim suratizinbaru As New Konfirmasi_Izin_Pegawai
        suratizinbaru.ShowDialog()
    End Sub

    Private Sub NotifyIconSuratIzinBaru_Click(sender As Object, e As EventArgs) Handles NotifyIconSuratIzinBaru.Click
        Dim suratizinbaru As New Konfirmasi_Izin_Pegawai
        suratizinbaru.ShowDialog()
    End Sub

    Private Sub NotifyIconSuratIzinTerkonfirmasi_Click(sender As Object, e As EventArgs) Handles NotifyIconSuratIzinTerkonfirmasi.Click
        Dim suratIzinTerkonfirmasi As New Pengajuan_Perizinan_Pegawai
        suratIzinTerkonfirmasi.ShowDialog()
    End Sub

    Private Sub NotifyIconSuratIzinTerkonfirmasi_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIconSuratIzinTerkonfirmasi.BalloonTipClicked
        Dim suratIzinTerkonfirmasi As New Pengajuan_Perizinan_Pegawai
        suratIzinTerkonfirmasi.ShowDialog()
    End Sub

    Private Sub NotifyIconPeriodeSuratIzin_Click(sender As Object, e As EventArgs) Handles NotifyIconPeriodeSuratIzin.Click
        Dim periodeSurat As New Konfirmasi_Izin_Pegawai
        periodeSurat.ShowDialog()
    End Sub

    Private Sub NotifyIconPeriodeSuratIzin_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIconPeriodeSuratIzin.BalloonTipClicked
        Dim periodeSurat As New Konfirmasi_Izin_Pegawai
        periodeSurat.ShowDialog()
    End Sub

    Private Sub PindahKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PindahKelasToolStripMenuItem.Click
        Dim pindah As New Pindah_Kelas
        pindah.ShowDialog()
    End Sub
End Class