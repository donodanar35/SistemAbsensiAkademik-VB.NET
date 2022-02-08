Imports MySql.Data.MySqlClient

Public Class jadwal
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Dim kelas As String = ""
    Public id_stok As String = ""

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from jadwal"
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
            'TextBoxId.Text = temp.ToString + "-" + ComboBoxTahunAjaran.SelectedValue.ToString
        Catch ex As Exception
            'MsgBox(ex.ToString)
            'MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

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

    Sub tampilPegawai()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT P.ID_PEGAWAI, P.NAMA FROM PEGAWAI P WHERE P.STATUS = 1 AND P.NAMA LIKE '%" & TextBoxCariPegawai.Text & "%'"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtPegawai As New DataTable("pegawai")
            da.Fill(dtPegawai)

            ComboBoxPegawai.DataSource = dtPegawai
            ComboBoxPegawai.DisplayMember = "NAMA"
            ComboBoxPegawai.ValueMember = "ID_PEGAWAI"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan pegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilMapel()
        'ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT ID_MAPEL, MAPEL FROM MAPEL WHERE STATUS = 1 AND MAPEL LIKE '%" & TextBoxCariMapel.Text & "%'"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtMapel As New DataTable("mapel")
            da.Fill(dtMapel)

            ComboBoxMapel.DataSource = dtMapel
            ComboBoxMapel.DisplayMember = "MAPEL"
            ComboBoxMapel.ValueMember = "ID_MAPEL"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan mapel bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilKelas()
        ComboBoxKelas.DataSource = Nothing
        ds.Clear()
        Try
            Dim qs As String = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.TAHUN_AJARAN LIKE '" & ComboBoxTahunAjaran.SelectedValue.ToString & "' AND H.NAMA_KELAS LIKE '%" & TextBoxCariKelas.Text & "%' GROUP BY ID_KELAS"
            conn = Form1.koneksi()

            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("kelas")
            da.Fill(dt)

            ComboBoxKelas.DataSource = dt
            ComboBoxKelas.DisplayMember = "NAMA_KELAS"
            ComboBoxKelas.ValueMember = "ID_KELAS"
            conn.Close()
        Catch ex As Exception
            'MsgBox("Tampilan kelas bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub SimpanJadwal()
        If ButtonSetujui.Enabled = False Then
            Dim id As Integer = No()
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            Try
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim qs As String = "INSERT INTO JADWAL (ID_JADWAL, TAHUN_AJARAN, ID_MAPEL, ID_PEGAWAI, ID_KELAS, HARI, JAM_AWALMENGAJAR, JAM_AKHIRMENGAJAR, BERLAKUTGL, SAMPAITGL, TGL, STATUS) VALUES ('" & id & "','" & ComboBoxTahunAjaran.SelectedValue.ToString & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "','" & DataGridView1.Rows(i).Cells(6).Value & "','" & DataGridView1.Rows(i).Cells(8).Value & "','" & DataGridView1.Rows(i).Cells(9).Value & "','" & DataGridView1.Rows(i).Cells(10).Value & "','" & Format(DataGridView1.Rows(i).Cells(11).Value, "yyyy-MM-dd") & "','" & Format(DataGridView1.Rows(i).Cells(12).Value, "yyyy-MM-dd") & "','" & Format(Today, "yyyy-MM-dd") & "', 1)"
                    Dim cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                    id = id + 1
                Next
                trans.Commit()
                MessageBox.Show("Data transaksi jadwal mapel berhasil dilakukan!")
            Catch ex As Exception
                MessageBox.Show("Data transaksi jadwal mapel gagal dilakukan! " + ex.ToString)
                trans.Rollback()
            End Try
            conn.Close()
        Else
            MsgBox("Harap pilih tahun ajaran baru, lalu tekan tombol setujui!")
        End If
    End Sub

    Sub tambahData()
        Try
            Dim isID As Integer = 0
            Dim hari As String = "senin"
            If RadioButtonJumat.Checked Then
                hari = "jumat"
            ElseIf RadioButtonKamis.Checked Then
                hari = "kamis"
            ElseIf RadioButtonMinggu.Checked Then
                hari = "minggu"
            ElseIf RadioButtonRabu.Checked Then
                hari = "rabu"
            ElseIf RadioButtonSabtu.Checked Then
                hari = "sabtu"
            ElseIf RadioButtonSelasa.Checked Then
                hari = "selasa"
            ElseIf RadioButtonSenin.Checked Then
                hari = "senin"
            End If
            For i As Integer = 0 To DataGridView1.RowCount - 2
                Dim harix As String = DataGridView1.Rows(i).Cells(8).Value.ToString
                Dim mulai As String = DataGridView1.Rows(i).Cells(9).Value.ToString
                If (harix = hari) And (MaskedTextBoxJamMulai.Text = mulai) Then
                    isID = 1
                    MsgBox("Jadwal mata pelajaran bentrok!")
                    Exit Sub
                End If
            Next
            Dim cekJadwal As String = CekAkunKembar_Jadwal(hari, MaskedTextBoxJamMulai.Text.ToString, ComboBoxTahunAjaran.SelectedValue)
            If cekJadwal = "1" Then
                MsgBox("Jadwal mata pelajaran telah ada!")
                Exit Sub
            End If
            Dim DataPegawai() As String = ambilPegawai()
            Dim DataMapel() As String = ambilMapel()
            Dim DataKelas() As String = ambilKelas()
            If isID <> 1 Then
                DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, 0, ComboBoxTahunAjaran.SelectedValue.ToString, ComboBoxMapel.SelectedValue.ToString, DataMapel(1), ComboBoxPegawai.SelectedValue.ToString, DataPegawai(1), ComboBoxKelas.SelectedValue.ToString, DataKelas(1), hari, MaskedTextBoxJamMulai.Text, MaskedTextBoxJamSelesai.Text, DateTimePickerBerlakuTgl.Value, DateTimePickerSampaiTgl.Value, "Cancel")
            End If
        Catch ex As Exception
            MsgBox("Tambah Data bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function ambilPegawai()
        usernameku = Form1.username
        Dim temp() As String = {"", ""}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT P.ID_PEGAWAI 'ID_PEGAWAI', P.NAMA 'NAMA_PEGAWAI' FROM PEGAWAI P WHERE P.ID_PEGAWAI LIKE '" & ComboBoxPegawai.SelectedValue & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("ID_PEGAWAI")
                    temp(1) = DRX.Item("NAMA_PEGAWAI")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambil data pegawai bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function ambilMapel()
        usernameku = Form1.username
        Dim temp() As String = {"", ""}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT ID_MAPEL, MAPEL FROM MAPEL WHERE STATUS = 1 AND ID_MAPEL LIKE '" & ComboBoxMapel.SelectedValue & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("ID_MAPEL")
                    temp(1) = DRX.Item("MAPEL")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambil data mapel bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function ambilKelas()
        usernameku = Form1.username
        Dim temp() As String = {"", ""}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.ID_KELAS LIKE '%" & ComboBoxKelas.SelectedValue.ToString & "%' GROUP BY ID_KELAS"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("ID_KELAS")
                    temp(1) = DRX.Item("NAMA_KELAS")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambil data kelas bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function CekAkunKembar_Jadwal(ParamHari As String, ParamMulai As String, paramTahunAjaran As String)
        Dim qs As String = "SELECT HARI,JAM_AWALMENGAJAR, TAHUN_AJARAN FROM JADWAL WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim hari As String = ""
            Dim mulai As TimeSpan
            Dim tahunAjar As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    hari = DRX.Item("HARI")
                    mulai = DRX.Item("JAM_AWALMENGAJAR")
                    tahunAjar = DRX.Item("TAHUN_AJARAN")
                    If hari = ParamHari And mulai.ToString = ParamMulai And tahunAjar = paramTahunAjaran Then
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
            MsgBox("Cek tahun ajaran bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Try
            tambahData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTahunAjaran()
        tampilKelas()
        tampilMapel()
        tampilPegawai()
        No()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub


    Sub clearData()
        tampilTahunAjaran()
        tampilKelas()
        tampilMapel()
        tampilPegawai()
        No()
        TextBoxCariKelas.Text = ""
        TextBoxCariMapel.Text = ""
        TextBoxCariPegawai.Text = ""
        TextBoxCariTahunAjaran.Text = ""
        DateTimePickerBerlakuTgl.Value = Today
        DateTimePickerSampaiTgl.Value = Today
        RadioButtonSenin.Checked = True
        MaskedTextBoxJamMulai.Text = "00:00:00"
        MaskedTextBoxJamSelesai.Text = "00:00:00"
    End Sub

    Private Sub ButtonProsess_Click(sender As Object, e As EventArgs) Handles ButtonProsess.Click
        Try
            If ButtonSetujui.Enabled = False Then
                If ComboBoxPegawai.Items.Count <= 0 Then
                    MsgBox("Harap isi data pegawai!")
                Else
                    If DataGridView1.Rows.Count <= 1 Then
                        MsgBox("Harap tambahkan data pegawai!")
                    Else
                        SimpanJadwal()
                        ButtonClear.Enabled = False
                        ButtonProsess.Enabled = False
                        ButtonTambah.Enabled = False
                        DataGridView1.Rows.Clear()
                    End If
                End If
            Else
                MsgBox("Harap pilih tahun ajaran, lalu tekan setujui!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pengajar As New karyawan
        pengajar.ShowDialog()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        clearData()
        ButtonClear.Enabled = True
        ButtonProsess.Enabled = True
        ButtonTambah.Enabled = True
        DataGridView1.Rows.Clear()
        tampilTahunAjaran()
        tampilKelas()
        tampilMapel()
        tampilPegawai()
        No()
        ComboBoxTahunAjaran.Enabled = True
        TextBoxCariTahunAjaran.Enabled = True
        ButtonCariTahun.Enabled = True
        ButtonSetujui.Enabled = True
    End Sub

    Private Sub ButtonSetujui_Click(sender As Object, e As EventArgs) Handles ButtonSetujui.Click
        ComboBoxTahunAjaran.Enabled = False
        TextBoxCariTahunAjaran.Enabled = False
        ButtonCariTahun.Enabled = False
        ButtonSetujui.Enabled = False
    End Sub

    Private Sub ButtonCariKelas_Click(sender As Object, e As EventArgs) Handles ButtonCariKelas.Click
        tampilKelas()
    End Sub

    Private Sub ButtonCariPegawai_Click(sender As Object, e As EventArgs) Handles ButtonCariPegawai.Click
        tampilPegawai()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilMapel()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(13).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxTahunAjaran_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxTahunAjaran.SelectedValueChanged
        tampilKelas()
        No()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs)
        Try
            Dim cetak As New Preview
            'cetak.id = TextBoxId.Text
            cetak.TAHUN_AJARAN = ComboBoxTahunAjaran.SelectedValue.ToString
            cetak.printWhat = "jadwal"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonCariTahun_Click(sender As Object, e As EventArgs) Handles ButtonCariTahun.Click
        tampilTahunAjaran()
    End Sub
End Class