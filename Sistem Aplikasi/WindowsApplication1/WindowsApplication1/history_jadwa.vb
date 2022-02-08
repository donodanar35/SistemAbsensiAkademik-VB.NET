Imports MySql.Data.MySqlClient

Public Class history_jadwa
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("jadwal")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public TAHUN_AJARANX As String = ""
    Public ID_PEGAWAIX As String = ""
    Public ID_jadwal As String = ""
   
    Sub tampilHJadwal()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.STATUS 'STATUS', H.ID_JADWAL 'ID', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', P.ID_PEGAWAI 'ID_PENGAJAR', M.ID_MAPEL 'ID_MAPEL' FROM JADWAL H, HKELAS K, PEGAWAI P, MAPEL M WHERE H.ID_MAPEL = M.ID_MAPEL AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.STATUS >= 1 AND H.ID_KELAS = K.ID_KELAS"

        If RadioButtonID.Checked Then
            qs = "SELECT H.STATUS 'STATUS', H.ID_JADWAL 'ID', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', P.ID_PEGAWAI 'ID_PENGAJAR', M.ID_MAPEL 'ID_MAPEL' FROM JADWAL H, HKELAS K, PEGAWAI P, MAPEL M WHERE H.ID_MAPEL = M.ID_MAPEL AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.STATUS = 1 AND H.ID_KELAS >= K.ID_KELAS AND H.ID_JADWAL LIKE '%" & TextBoxCari.Text & "%' ORDER BY H.ID_JADWAL"
        ElseIf RadioButtonTTahunAjaran.Checked Then
            qs = "SELECT H.STATUS 'STATUS', H.ID_JADWAL 'ID', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', P.ID_PEGAWAI 'ID_PENGAJAR', M.ID_MAPEL 'ID_MAPEL' FROM JADWAL H, HKELAS K, PEGAWAI P, MAPEL M WHERE H.ID_MAPEL = M.ID_MAPEL AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.STATUS = 1 AND H.ID_KELAS >= K.ID_KELAS AND K.NAMA_KELAS LIKE '%" & TextBoxCari.Text & "%' ORDER BY H.ID_JADWAL"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id_jadwal As String = ""
            Dim tahun_ajaran As String = ""
            Dim tgl As String = ""
            Dim id_pengajar As String = ""
            Dim status As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            'MsgBox("status")
            If DRX.HasRows Then
                While DRX.Read()
                    id_jadwal = DRX.Item("ID")
                    tahun_ajaran = DRX.Item("TAHUN_AJARAN")
                    tgl = DRX.Item("TGL")
                    id_pengajar = DRX.Item("ID_PENGAJAR")
                    status = DRX.Item("STATUS")
                    'MsgBox(status)
                    If status = "1" Then
                        'MsgBox(status + "1")
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_jadwal, tgl, tahun_ajaran, id_pengajar, "aktif", "Detail")
                    ElseIf status = "2" Then
                        'MsgBox(status + "2")
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_jadwal, tgl, tahun_ajaran, id_pengajar, "kadaluarsa", "Detail")
                    End If
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            'MsgBox("statusx")
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HJadwal bermasalah! " + ex.ToString)
        End Try
    End Sub

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

    Sub tampilDJadwal(ParamThnAjaran As String, paramId_pegawai As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT P.NAMA 'PENGAJAR', K.NAMA_KELAS 'KELAS', M.MAPEL 'MAPEL', D.HARI 'HARI', D.JAM_AWALMENGAJAR 'AWAL', D.JAM_AKHIRMENGAJAR 'AKHIR', D.BERLAKUTGL 'BERLAKU', D.SAMPAITGL 'SAMPAI' FROM JADWAL D, PEGAWAI P, MAPEL M, HKELAS K WHERE D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_KELAS = K.ID_KELAS AND D.ID_MAPEL = M.ID_MAPEL AND D.TAHUN_AJARAN LIKE '" & ParamThnAjaran & "' AND D.ID_PEGAWAI LIKE '" & paramId_pegawai & "'"

        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim pengajar As String = ""
            Dim kekelas As String = ""
            Dim mapel As String = ""
            Dim hari As String = ""
            Dim jamAwal As String = ""
            Dim jamAkhir As String = ""
            Dim berlakuTgl As String = ""
            Dim sampaiTgl As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    pengajar = DRX.Item("PENGAJAR")
                    kekelas = DRX.Item("KELAS")
                    mapel = DRX.Item("MAPEL")
                    hari = DRX.Item("HARI")
                    'jamAwal = DRX.Item("AWAL")
                    'jamAkhir = DRX.Item("AKHIR")
                    berlakuTgl = DRX.Item("BERLAKU")
                    sampaiTgl = DRX.Item("SAMPAI")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, pengajar, kekelas, hari, DRX.Item("AWAL"), DRX.Item("AKHIR"), mapel, berlakuTgl, sampaiTgl)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan DJadwal bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub hapusJadwal(ParamID As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update jadwal set STATUS=0 WHERE id_jadwal = '" & ParamID & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data jadwal berhasil dilakukan!")
            ID_jadwal = ""
        Catch ex As Exception
            MsgBox("Hapus data jadwal gagal dilakukan!")
        End Try
    End Sub

    Sub PerbaruiStatusJadwal()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update jadwal set STATUS=2 WHERE SAMPAITGL <'" & Format(Today, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Pembaruan status jadwal berhasil dilakukan!")
            ID_jadwal = ""
        Catch ex As Exception
            MsgBox("Pembaruan status jadwal gagal dilakukan!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ID_jadwal = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TAHUN_AJARANX = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            ID_PEGAWAIX = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            tampilDJadwal(TAHUN_AJARANX, ID_PEGAWAIX)
            'MsgBox("ok")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data jadwal " + ID_jadwal + "?", "Hapus Data Jadwal Mata Pelajaran ", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusJadwal(ID_jadwal)
                tampilHJadwal()
                ID_jadwal = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ID_jadwal = ""
        ID_PEGAWAIX = ""
        TAHUN_AJARANX = ""
        TextBoxCari.Text = ""
        RadioButtonID.Checked = False
        RadioButtonTTahunAjaran.Checked = False
        tampilHJadwal()
    End Sub

    Private Sub ButtonTambahUbah_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            Dim cetak As New Preview
            cetak.id = ID_jadwal
            cetak.TAHUN_AJARAN = TAHUN_AJARANX
            cetak.printWhat = "jadwal"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub History_Absensi_Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kadalursaJadwal As String = CekKadaluarsa_Jadwal(Today)
        If kadalursaJadwal = "1" Then
            Try
                Dim result As Integer = MessageBox.Show("Anda mempunyai status data jadwal yang kadalursa, perbarui sekarang?", "Perbarui Status Data Jadwal Mata Pelajaran yang Kadalursa", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.Yes Then
                    PerbaruiStatusJadwal()
                    tampilHJadwal()
                    ID_jadwal = ""
                End If
            Catch ex As Exception
            End Try
        End If
        tampilHJadwal()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHJadwal()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ID_jadwal = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TAHUN_AJARANX = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            ID_PEGAWAIX = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            tampilDJadwal(TAHUN_AJARANX, ID_PEGAWAIX)
            'MsgBox("ok")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin hendak memperbarui seluruh status data jadwal yang kadalursa?", "Perbarui Status Data Jadwal Mata Pelajaran yang Kadalursa", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                PerbaruiStatusJadwal()
                tampilHJadwal()
                ID_jadwal = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class