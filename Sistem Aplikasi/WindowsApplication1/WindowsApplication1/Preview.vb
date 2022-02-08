Public Class Preview
    Public printWhat As String = ""
    Public id As String = ""
    Public awal As Date = Today
    Public akhir As Date = Today
    Public no As String = ""
    Public kepada As String = ""
    Public id_PO As String = ""
    Public id_pegawai As String = ""
    Public TAHUN_AJARAN As String = ""
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        'MsgBox(printWhat + " " + id)
        Try
            If printWhat = "surat_izin" Then
                Dim rp As New LapSurat
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("ID_PEGAWAI", id_pegawai)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "surat_persetujuan" Then
                Dim rp As New LapPersetujuan
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("ID_PEGAWAI", id_pegawai)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "jadwal" Then
                Dim rp As New LapJadwal
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("TAHUN_AJARAN", TAHUN_AJARAN)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "kelas" Then
                Dim rp As New LapKelas
                rp.SetParameterValue("ID", id)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "absensi_siswa" Then
                Dim rp As New LapAbsensi_Siswa
                rp.SetParameterValue("ID", id)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "absensi_pegawai" Then
                Dim rp As New Lap_Absensi_Pegawai
                rp.SetParameterValue("ID", id)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "laporan_absensi_siswa" Then
                Dim rp As New RepAbsensiSiswa
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("TGLAWAL", awal)
                rp.SetParameterValue("TGLAKHIR", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "laporan_absensi_pegawai" Then
                Dim rp As New RepAbsensiPegawai
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("TGLAWAL", awal)
                rp.SetParameterValue("TGLAKHIR", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "laporan_perizinan_pegawai" Then
                Dim rp As New RepPerizinanPegawai
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("TGLAWAL", awal)
                rp.SetParameterValue("TGLAKHIR", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "laporan_jadwal" Then
                Dim rp As New RepJadwal
                rp.SetParameterValue("ID", id)
                rp.SetParameterValue("TGLAWAL", awal)
                rp.SetParameterValue("TGLAKHIR", akhir)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            ElseIf printWhat = "laporan_kelas" Then
                Dim rp As New RepKelas
                rp.SetParameterValue("ID", id)
                CrystalReportViewer1.ReportSource = rp
                CrystalReportViewer1.Refresh()
            End If
        Catch ex As Exception
            MsgBox("cetak error! " + ex.ToString)
        End Try
    End Sub
End Class