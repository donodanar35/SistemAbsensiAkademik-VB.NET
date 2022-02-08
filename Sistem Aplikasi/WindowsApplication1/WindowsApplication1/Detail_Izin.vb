Imports MySql.Data.MySqlClient

Public Class Detail_Izin
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public cmdx As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public totalDisetujui As Integer
    Public id_izin As String
    Public id_pegawai As String

    Sub tampilDetailSurat(idx As String)
        Dim qs As String = "SELECT D.DITOLAK 'DITOLAK', D.DIIZINKAN 'DIIZINKAN', D.PERSETUJUAN 'PERSETUJUAN', D.ID_PEGAWAI 'ID_PEGAWAI', D.ID_IZIN 'ID_IZIN', P.NAMA 'NAMA', D.ID 'ID', D.JENIS_IZIN 'JENIS_IZIN', D.BERLAKUTGL 'BERLAKUTGL', D.SAMPAITGL 'SAMPAITGL',  D.TGL_IZIN 'TGL_IZIN', D.TGL_DISETUJUI 'TGL_DISETUJUI', D.KETERANGAN 'KETERANGAN', D.STATUS 'STATUS' FROM DPERIZINAN_PEGAWAI D, PEGAWAI P  WHERE D.STATUS >= 1 AND D.ID_PEGAWAI = P.ID_PEGAWAI AND D.ID LIKE '" & idx & "' ORDER BY STATUS"
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim status As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    id_pegawai = DRX.Item("ID_PEGAWAI")
                    id_izin = DRX.Item("ID_IZIN")
                    TextBoxID.Text = DRX.Item("ID")
                    TextBoxPegawai.Text = DRX.Item("NAMA")
                    TextBoxJenis.Text = DRX.Item("JENIS_IZIN")
                    DateTimePickerBerlakuTgl.Value = Format(DRX.Item("BERLAKUTGL"), "yyyy-MM-dd")
                    DateTimePickerSampaiTgl.Value = Format(DRX.Item("SAMPAITGL"), "yyyy-MM-dd")
                    DateTimePickerTgl_Izin.Value = Format(DRX.Item("TGL_IZIN"), "yyyy-MM-dd")
                    'DateTimePickerTglSetujui.Value = Format(DRX.Item("TGL_DISETUJUI"), "yyyy-MM-dd")
                    TextBoxKetPengajuan.Text = DRX.Item("KETERANGAN")
                    TextBoxPersetujuan.Text = DRX.Item("PERSETUJUAN")
                    status = DRX.Item("STATUS")
                    Dim diizinkan As String = DRX.Item("DIIZINKAN")
                    Dim ditolak As String = DRX.Item("DITOLAK")
                    If status = 1 Then
                        TextBoxStatus.Text = "Belum disetujui"
                    ElseIf status = 2 And diizinkan = "1" Then
                        TextBoxStatus.Text = "Telah disetujui"
                    ElseIf status = 2 And ditolak = "1" Then
                        TextBoxStatus.Text = "Telah ditolak"
                    End If
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan surat perizinan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahStatusSurat()
        Try
            Dim tSetujui As Integer = HitungTotalDisetujui()

            conn = Form1.koneksi()
            Dim qs As String = "update dperizinan_pegawai set sampaitgl ='" & Format(DateTimePickerSampaiTgl.Value, "yyyy-MM-dd") & "', berlakutgl ='" & Format(DateTimePickerBerlakuTgl.Value, "yyyy-MM-dd") & "', tgl_disetujui ='" & Format(Now, "yyyy-MM-dd") & "', status = '2', diizinkan = '1', ditolak = '0', persetujuan ='" & TextBoxPersetujuan.Text & "', konfirmasi = 'Diterima' WHERE id = '" & TextBoxID.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            tSetujui = tSetujui + 1
            Dim qsx As String = "update hperizinan_pegawai set total_disetujui =" & tSetujui & " WHERE id_izin = '" & id_izin & "'"
            cmdx = New MySqlCommand(qsx, conn)
            cmdx.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            'MsgBox("id izin:" + id_izin.ToString + " tSetuju :" + tSetujui.ToString)
            MsgBox("Surat izin pegawai setujui!")
        Catch ex As Exception
            MsgBox("Surat izin pegawai gagal disetujui! " + ex.ToString)
        End Try
    End Sub

    Sub TolakSurat()
        Try
            Dim tSetujui As Integer = HitungTotalDisetujui()
            conn = Form1.koneksi()
            Dim qs As String = "update dperizinan_pegawai set sampaitgl ='" & Format(DateTimePickerSampaiTgl.Value, "yyyy-MM-dd") & "', berlakutgl ='" & Format(DateTimePickerBerlakuTgl.Value, "yyyy-MM-dd") & "', tgl_disetujui ='" & Format(Now, "yyyy-MM-dd") & "', status = '2', diizinkan = '0', ditolak = '1', persetujuan ='" & TextBoxPersetujuan.Text & "', konfirmasi = 'Ditolak' WHERE id = '" & TextBoxID.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            tSetujui = tSetujui + 1
            Dim qsx As String = "update hperizinan_pegawai set total_disetujui =" & tSetujui & " WHERE id_izin = '" & id_izin & "'"
            cmdx = New MySqlCommand(qsx, conn)
            cmdx.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            MsgBox("Surat izin pegawai ditolak!")
        Catch ex As Exception
            MsgBox("Surat izin pegawai gagal ditolak! " + ex.ToString)
        End Try
    End Sub
    Function HitungTotalDisetujui()
        Try
            Dim qs As String = "SELECT COUNT(*) 'NO' FROM DPERIZINAN_PEGAWAI D, HPERIZINAN_PEGAWAI H WHERE D.ID_IZIN = H.ID_IZIN AND D.STATUS = 2 AND D.ID_IZIN ='" & id_izin & "'"
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    totalDisetujui = DRX.Item("NO")
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
        Catch ex As Exception
            MsgBox("Hitung total disetujui gagal!")
        End Try
        Return totalDisetujui
    End Function

    Private Sub Detail_Izin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tampilDetailSurat(TextBoxID.Text)
            If TextBoxStatus.Text = "Telah disetujui" Then
                ButtonSetujui.Enabled = False
                TextBoxKetPengajuan.Enabled = False
                ButtonTolak.Enabled = False
            ElseIf TextBoxStatus.Text = "Telah ditolak" Then
                ButtonTolak.Enabled = False
                TextBoxKetPengajuan.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonSetujui_Click(sender As Object, e As EventArgs) Handles ButtonSetujui.Click
        Try
            ubahStatusSurat()
            TextBoxStatus.Text = "Telah disetujui"
            ButtonSetujui.Enabled = False
            ButtonTolak.Enabled = False
            'Konfirmasi_Izin_Pegawai.tampilDPerizinan(id_izin)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Try
            Dim cetak As New Preview
            cetak.id = TextBoxID.Text
            cetak.id_pegawai = id_pegawai
            cetak.printWhat = "surat_izin"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonTolak.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin hendak menolak surat izin pegawai no." + TextBoxID.Text + "?", "Konfirmasi Penolakan Surat Izin Pegawai ", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                TolakSurat()
                TextBoxStatus.Text = "Telah ditolak"
                ButtonSetujui.Enabled = False
                ButtonTolak.Enabled = False
                'Konfirmasi_Izin_Pegawai.tampilDPerizinan(id_izin)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class