Imports MySql.Data.MySqlClient

Public Class History_Absensi_Pegawai
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public ID_APEGAWAI As String = ""
 
    Sub tampilHAbsensiPegawai()
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT H.ID_APEGAWAI 'ID', P.NAMA 'PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', H.TOTAL_HADIR 'TOTAL HADIR', H.TOTAL_IZIN 'TOTAL IZIN', H.TOTAL_ALFA 'TOTAL ALFA' FROM HABSENSI_PEGAWAI H, PEGAWAI P WHERE H.STATUS = 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI"

        If RadioButtonID.Checked Then
            qs = "SELECT H.ID_APEGAWAI 'ID', P.NAMA 'PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', H.TOTAL_HADIR 'TOTAL HADIR', H.TOTAL_IZIN 'TOTAL IZIN', H.TOTAL_ALFA 'TOTAL ALFA' FROM HABSENSI_PEGAWAI H, PEGAWAI P WHERE H.STATUS = 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.ID_APEGAWAI LIKE '%" & TextBoxCari.Text & "%' ORDER BY H.ID_APEGAWAI"
        ElseIf RadioButtonTTahunAjaran.Checked Then
            qs = "SELECT H.ID_APEGAWAI 'ID', P.NAMA 'PEGAWAI', H.TAHUN_AJARAN 'TAHUN_AJARAN', H.TGL 'TGL', H.TOTAL_HADIR 'TOTAL HADIR', H.TOTAL_IZIN 'TOTAL IZIN', H.TOTAL_ALFA 'TOTAL ALFA' FROM HABSENSI_PEGAWAI H, PEGAWAI P WHERE H.STATUS = 1 AND H.ID_PEGAWAI = P.ID_PEGAWAI AND H.TAHUN_AJARAN LIKE '%" & TextBoxCari.Text & "%' ORDER BY H.ID_APEGAWAI"
        End If

        usernameku = Form1.username
        ds.Clear()
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id_apegawai As String = ""
            Dim pegawai As String = ""
            Dim tahun_ajaran As String = ""
            Dim tgl As String = ""
            Dim totalKehadiran As String = ""
            Dim totalIzin As String = ""
            Dim totalAlfa As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id_apegawai = DRX.Item("ID")
                    pegawai = DRX.Item("PEGAWAI")
                    tahun_ajaran = DRX.Item("TAHUN_AJARAN")
                    tgl = DRX.Item("TGL")
                    totalKehadiran = DRX.Item("TOTAL HADIR")
                    totalIzin = DRX.Item("TOTAL IZIN")
                    totalAlfa = DRX.Item("TOTAL ALFA")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_apegawai, pegawai, tahun_ajaran, tgl, totalKehadiran, totalIzin, totalAlfa, "Detail")
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan HAPegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilDAbsensiPegawai(ParamIdApegawai As String)
        Dim cari As String = ""
        cari = TextBoxCari.Text
        Dim qs As String = "SELECT P.NAMA 'PEGAWAI', D.STATUS 'KEHADIRAN', D.KETERANGAN 'KETERANGAN' FROM DABSENSI_PEGAWAI D, PEGAWAI P WHERE D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID_APEGAWAI ='" & ParamIdApegawai & "'"

        usernameku = Form1.username
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim pegawai As String = ""
            Dim kehadiran As String = ""
            Dim keterangan As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    pegawai = DRX.Item("PEGAWAI")
                    kehadiran = DRX.Item("KEHADIRAN")
                    keterangan = DRX.Item("KETERANGAN")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, pegawai, kehadiran, keterangan)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan DAPegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub hapusAbsensiPegawai(ParamID As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update habsensi_pegawai set STATUS=0 WHERE id_apegawai = '" & ParamID & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data absensi pegawai berhasil dilakukan!")
            ID_APEGAWAI = ""
        Catch ex As Exception
            MsgBox("Hapus data absensi pegawai gagal dilakukan!")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ID_APEGAWAI = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            tampilDAbsensiPegawai(ID_APEGAWAI)
            'MsgBox("ok")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data absensi pegawai " + ID_APEGAWAI + "?", "Hapus Data Absensi Pegawai ", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusAbsensiPegawai(ID_APEGAWAI)
                tampilHAbsensiPegawai()
                ID_APEGAWAI = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ID_APEGAWAI = ""
        TextBoxCari.Text = ""
        tampilHAbsensiPegawai()
    End Sub

    Private Sub ButtonTambahUbah_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            Dim cetak As New Preview
            cetak.id = ID_APEGAWAI
            cetak.printWhat = "absensi_pegawai"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub History_Absensi_Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilHAbsensiPegawai()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilHAbsensiPegawai()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ID_APEGAWAI = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            tampilDAbsensiPegawai(ID_APEGAWAI)
            'MsgBox("ok")
        Catch ex As Exception
        End Try
    End Sub
End Class