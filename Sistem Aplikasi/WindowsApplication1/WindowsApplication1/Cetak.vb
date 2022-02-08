Imports MySql.Data.MySqlClient

Public Class Cetak
    Public usernameku As String
    Public namapetugas As String
    Public PilihLaporan As String = "laporan_absensi_siswa"
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("laporan")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Sub tampilTahunAjaran()
        ComboBoxTahunAjaran.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select tahun_ajaran From tahun_ajaran WHERE STATUS = 1 AND tahun_ajaran like '%" & TextBoxCariTahunAjaran.Text & "%' ORDER BY tahun_ajaran DESC"
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

    Private Sub Cetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTahunAjaran()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Try
            If PilihLaporan = "laporan_absensi_pegawai" Then
                Dim cetak As New Preview
                cetak.id = ComboBoxTahunAjaran.SelectedValue.ToString
                cetak.awal = DateTimePickerTglAwal.Value
                cetak.akhir = DateTimePickerTglAkhir.Value
                cetak.printWhat = "laporan_absensi_pegawai"
                cetak.ShowDialog()
            ElseIf PilihLaporan = "laporan_absensi_siswa" Then
                Dim cetak As New Preview
                cetak.id = ComboBoxTahunAjaran.SelectedValue.ToString
                cetak.awal = DateTimePickerTglAwal.Value
                cetak.akhir = DateTimePickerTglAkhir.Value
                cetak.printWhat = "laporan_absensi_siswa"
                cetak.ShowDialog()
            ElseIf PilihLaporan = "laporan_perizinan_pegawai" Then
                Dim cetak As New Preview
                cetak.id = ComboBoxTahunAjaran.SelectedValue.ToString
                cetak.awal = DateTimePickerTglAwal.Value
                cetak.akhir = DateTimePickerTglAkhir.Value
                cetak.printWhat = "laporan_perizinan_pegawai"
                cetak.ShowDialog()
            ElseIf PilihLaporan = "laporan_jadwal" Then
                Dim cetak As New Preview
                cetak.id = ComboBoxTahunAjaran.SelectedValue.ToString
                cetak.awal = DateTimePickerTglAwal.Value
                cetak.akhir = DateTimePickerTglAkhir.Value
                cetak.printWhat = "laporan_jadwal"
                cetak.ShowDialog()
            ElseIf PilihLaporan = "laporan_kelas" Then
                Dim cetak As New Preview
                cetak.id = ComboBoxTahunAjaran.SelectedValue.ToString
                cetak.awal = DateTimePickerTglAwal.Value
                cetak.akhir = DateTimePickerTglAkhir.Value
                cetak.printWhat = "laporan_kelas"
                cetak.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonCariTahun_Click(sender As Object, e As EventArgs) Handles ButtonCariTahun.Click
        tampilTahunAjaran()
    End Sub
End Class