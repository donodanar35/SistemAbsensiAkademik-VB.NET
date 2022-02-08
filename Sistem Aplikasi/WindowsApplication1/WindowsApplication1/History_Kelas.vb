
Imports MySql.Data.MySqlClient

Public Class History_Kelas
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("siswa")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public ID_KELAS As String = ""

    Sub tampilHKelas()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.ID_KELAS 'ID', P.NAMA 'PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', R.ROMBEL 'ROMBEl', RU.RUANG 'RUANG', H.NAMA_KELAS 'KELAS', H.TOTAL_SISWA 'TOTAL_SISWA' FROM HKELAS H, PEGAWAI P, RUANG RU, ROMBEL R WHERE RU.ID_RUANG = H.ID_RUANG AND R.ID_ROMBEL = R.ID_ROMBEL AND H.STATUS = 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI GROUP BY H.ID_KELAS"

        If RadioButtonID.Checked Then
            qs = "SELECT H.ID_KELAS 'ID', P.NAMA 'PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', R.ROMBEL 'ROMBEl', RU.RUANG 'RUANG', H.NAMA_KELAS 'KELAS', H.TOTAL_SISWA 'TOTAL_SISWA' FROM HKELAS H, PEGAWAI P, RUANG RU, ROMBEL R WHERE RU.ID_RUANG = H.ID_RUANG AND R.ID_ROMBEL = R.ID_ROMBEL AND H.STATUS = 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.ID_KELAS LIKE '%" & TextBoxCari.Text & "%' GROUP BY H.ID_KELAS ORDER BY H.ID_KELAS"
        ElseIf RadioButtonTTahunAjaran.Checked Then
            qs = "SELECT H.ID_KELAS 'ID', P.NAMA 'PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', R.ROMBEL 'ROMBEl', RU.RUANG 'RUANG', H.NAMA_KELAS 'KELAS', H.TOTAL_SISWA 'TOTAL_SISWA' FROM HKELAS H, PEGAWAI P, RUANG RU, ROMBEL R WHERE RU.ID_RUANG = H.ID_RUANG AND R.ID_ROMBEL = R.ID_ROMBEL AND H.STATUS = 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.NAMA_KELAS LIKE '%" & TextBoxCari.Text & "%' GROUP BY H.ID_KELAS ORDER BY H.ID_KELAS"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id_kelas As String = ""
            Dim pegawai As String = ""
            Dim tahun_ajaran As String = ""
            Dim tgl As String = ""
            Dim kelas As String = ""
            Dim rombel As String = ""
            Dim ruang As String = ""
            Dim total_siswa As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id_kelas = DRX.Item("ID")
                    pegawai = DRX.Item("PEGAWAI")
                    tahun_ajaran = DRX.Item("TAHUN_AJARAN")
                    tgl = DRX.Item("TGL")
                    rombel = DRX.Item("ROMBEL")
                    ruang = DRX.Item("RUANG")
                    kelas = DRX.Item("KELAS")
                    total_siswa = DRX.Item("TOTAL_SISWA")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_kelas, pegawai, tahun_ajaran, kelas, rombel, ruang, total_siswa, tgl, "Detail")
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HKELAS bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDKelas(ParamIdApegawai As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT S.NAMA_SISWA 'SISWA' FROM DKELAS D, SISWA S WHERE D.ID_SISWA = S.ID_SISWA AND D.ID_KELAS ='" & ParamIdApegawai & "'"

        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim siswa As String = ""
            Dim kehadiran As String = ""
            Dim keterangan As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    siswa = DRX.Item("SISWA")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, siswa)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan DKELAS bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub hapusKelas(ParamID As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update hkelas set STATUS=0 WHERE id_kelas = '" & ParamID & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data kelas berhasil dilakukan!")
            ID_KELAS = ""
        Catch ex As Exception
            MsgBox("Hapus data kelas gagal dilakukan!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ID_KELAS = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            tampilDKelas(ID_KELAS)
            'MsgBox("ok")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data kelas " + ID_KELAS + "?", "Hapus Data Kelas ", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusKelas(ID_KELAS)
                tampilHKelas()
                ID_KELAS = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ID_KELAS = ""
        TextBoxCari.Text = ""
        tampilHKelas()
    End Sub

    Private Sub ButtonTambahUbah_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            Dim cetak As New Preview
            cetak.id = ID_KELAS
            cetak.printWhat = "kelas"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub History_Absensi_Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHKelas()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHKelas()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ID_KELAS = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            tampilDKelas(ID_KELAS)
            'MsgBox("ok")
        Catch ex As Exception
        End Try
    End Sub
End Class