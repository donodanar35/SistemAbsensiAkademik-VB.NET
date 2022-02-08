Imports MySql.Data.MySqlClient

Public Class absensi_pegawai

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
            str = "select count(*) 'no' from habsensi_pegawai"
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

    Sub tambahDataHadirSemua()
        Try
            Dim id_status As Integer = 1
            Dim status As String = "Hadir"
            ambilSemuaPegawai()
            Dim i As Integer = 0
            Dim namaku As String = ""
            Dim idku As String = ""
            For Each ID_SISWAX In ID_SISWA_LIST
                idku = ID_SISWAX
                'For Each nama_siswax In NAMA_SISWA_LIST
                'namaku = nama_siswax
                'Next

                namaku = NAMA_SISWA_LIST.Item(i)
                status = "Hadir"
                DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, TextBoxId.Text, idku, namaku, status, status, TextBoxKeterangan.Text, "Cancel", 1, 0, 0)
                Dim totalMasuk As Integer = Integer.Parse(TextBoxTotalHadir.Text)
                totalMasuk = totalMasuk + 1
                TextBoxTotalHadir.Text = totalMasuk
                i = i + 1
                If DataGridView1.Rows.Count - 1 = NAMA_SISWA_LIST.Count Then
                    ID_SISWA_LIST.Clear()
                    NAMA_SISWA_LIST.Clear()
                    Exit Try
                End If
            Next
        Catch ex As Exception
            MsgBox("Tambah Data bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function CekAkunKembar_AbsensiPegawai(ParamTgl As Date)
        Dim qs As String = "SELECT TGL FROM HABSENSI_PEGAWAI WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim tgl As Date
            If DRX.HasRows Then
                While DRX.Read()
                    tgl = DRX.Item("TGL")
                    Dim STgl As String = Format(tgl, "yyyy-MM-dd")
                    Dim SParamTgl As String = Format(ParamTgl, "yyyy-MM-dd")
                    'MsgBox("tgl: " + tgl.ToString + " param: " + ParamTgl.ToString)
                    If STgl = SParamTgl Then
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

    Sub tambahData()
        Try
            Dim isSiswa As Integer = 0
            For i As Integer = 0 To DataGridView1.RowCount - 2
                Dim siswa As String = DataGridView1.Rows(i).Cells(1).Value.ToString
                If siswa = ComboBoxPegawai.SelectedValue.ToString Then
                    isSiswa = 1
                    MsgBox("Data pegawai telah diinput!")
                    Exit For
                End If
            Next
            Dim id_status As Integer = 1
            Dim status As String = "Hadir"
            Dim DataSiswa() As String = ambilPegawai()
            If isSiswa <> 1 Then
                If RadioButtonMasuk.Checked Then
                    id_status = 1
                    status = "Hadir"
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, TextBoxId.Text, ComboBoxPegawai.SelectedValue.ToString, DataSiswa(1), status, status, TextBoxKeterangan.Text, "Cancel", 1, 0, 0)
                ElseIf RadioButtonIzin.Checked Then
                    id_status = 2
                    status = "Izin"
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, TextBoxId.Text, ComboBoxPegawai.SelectedValue.ToString, DataSiswa(1), status, status, TextBoxKeterangan.Text, "Cancel", 0, 1, 0)
                ElseIf RadioButtonAlfa.Checked Then
                    id_status = 3
                    status = "Alfa"
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, TextBoxId.Text, ComboBoxPegawai.SelectedValue.ToString, DataSiswa(1), status, status, TextBoxKeterangan.Text, "Cancel", 0, 0, 1)
                End If
                Dim totalMasuk As Integer = Integer.Parse(TextBoxTotalHadir.Text)
                Dim totalIzin As Integer = Integer.Parse(TextBoxTotalIzin.Text)
                Dim totalAlfa As Integer = Integer.Parse(TextBoxTotalAlfa.Text)
                If id_status = 1 Then
                    totalMasuk = totalMasuk + 1
                    TextBoxTotalHadir.Text = totalMasuk
                ElseIf id_status = 2 Then
                    totalIzin = totalIzin + 1
                    TextBoxTotalIzin.Text = totalIzin
                ElseIf id_status = 3 Then
                    totalAlfa = totalAlfa + 1
                    TextBoxTotalAlfa.Text = totalAlfa
                End If
            End If
        Catch ex As Exception
            MsgBox("Tambah Data bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function ambilPegawai()
        usernameku = Form1.username
        ds.Clear()
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

    Dim ID_SISWA_LIST As New ArrayList
    Dim NAMA_SISWA_LIST As New ArrayList
    Sub ambilSemuaPegawai()
        usernameku = Form1.username
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT P.ID_PEGAWAI 'ID_PEGAWAI', P.NAMA 'NAMA_PEGAWAI' FROM PEGAWAI P WHERE P.STATUS LIKE '1'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            'MsgBox("yes")
            If DRX.HasRows Then
                While DRX.Read()
                    ID_SISWA_LIST.Add(DRX.Item("ID_PEGAWAI"))
                    NAMA_SISWA_LIST.Add(DRX.Item("NAMA_PEGAWAI"))
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambil data pegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tambahHeaderAbsensiPegawai()
        No()
        If TextBoxId.Text <> "" Then
            Try
                usernameku = Form1.id_pegawai
                conn = Form1.koneksi()

                Dim qs As String = "INSERT INTO HABSENSI_PEGAWAI (ID_APEGAWAI, ID_PEGAWAI, TAHUN_AJARAN, TGL, TOTAL_HADIR, TOTAL_IZIN, TOTAL_ALFA, STATUS) VALUES ('" & TextBoxId.Text & "','" & usernameku & "','" & ComboBoxTahunAjaran.SelectedValue.ToString & "','" & Format(DateTimePickerTgl.Value, "yyyy-MM-dd") & "','" & TextBoxTotalHadir.Text & "','" & TextBoxTotalIzin.Text & "','" & TextBoxTotalAlfa.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi absensi pegawai error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id pegawai kosong!")
        End If
    End Sub

    Sub tambahDetailAbsensiPegawai()
        tambahHeaderAbsensiPegawai()
        Dim qs As String = ""
        If TextBoxId.Text <> "" Then
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            Try
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    If DataGridView1.Rows(i).Cells(4).Value = "Hadir" Then
                        qs = "INSERT INTO DABSENSI_PEGAWAI (ID_APEGAWAI, ID_PEGAWAI, STATUS, KETERANGAN, HADIR, IZIN, ALFA) VALUES ('" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "',1,0,0)"
                    ElseIf DataGridView1.Rows(i).Cells(4).Value = "Izin" Then
                        qs = "INSERT INTO DABSENSI_PEGAWAI (ID_APEGAWAI, ID_PEGAWAI, STATUS, KETERANGAN, HADIR, IZIN, ALFA) VALUES ('" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "',0,1,0)"
                    ElseIf DataGridView1.Rows(i).Cells(4).Value = "Alfa" Then
                        qs = "INSERT INTO DABSENSI_PEGAWAI (ID_APEGAWAI, ID_PEGAWAI, STATUS, KETERANGAN, HADIR, IZIN, ALFA) VALUES ('" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(3).Value & "','" & DataGridView1.Rows(i).Cells(5).Value & "',0,0,1)"
                    End If
                    Dim cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                Next
                trans.Commit()
                cmd.Dispose()
                MessageBox.Show("Data transaksi absensi pegawai berhasil dilakukan!")

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Data transaksi absensi pegawai gagal dilakukan!" + ex.ToString)
            End Try
            conn.Close()
        Else
            MsgBox("Id kosong!")
        End If
    End Sub

    Private Sub Absensi_Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTahunAjaran()
        tampilPegawai()
        No()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Try
            If ComboBoxPegawai.Items.Count >= 0 Then
                tambahData()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim totalMasuk As Integer = Integer.Parse(TextBoxTotalHadir.Text)
            Dim totalIzin As Integer = Integer.Parse(TextBoxTotalIzin.Text)
            Dim totalAlfa As Integer = Integer.Parse(TextBoxTotalAlfa.Text)
            Dim id_status As Integer = 1
            If id_status = 1 Then
                totalMasuk = totalMasuk - 1
                TextBoxTotalHadir.Text = totalMasuk
            ElseIf id_status = 2 Then
                totalIzin = totalIzin - 1
                TextBoxTotalIzin.Text = totalIzin
            ElseIf id_status = 3 Then
                totalAlfa = totalAlfa - 1
                TextBoxTotalAlfa.Text = totalAlfa
            End If
            If DataGridView1.Rows(e.RowIndex).Cells(6).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonProsess_Click(sender As Object, e As EventArgs) Handles ButtonProsess.Click
        Try
            Dim cekTglAbsensiPegawai As String = CekAkunKembar_AbsensiPegawai(DateTimePickerTgl.Value)
            'MsgBox("cek " + cekTglAbsensiPegawai)
            If cekTglAbsensiPegawai = "1" Then
                MsgBox("Anda telah melakukan absensi pegawai pada tgl " + DateTimePickerTgl.Value.ToString)
                Exit Sub
            End If
            If ComboBoxPegawai.Items.Count <= 0 Then
                MsgBox("Harap isi data pegawai!")
            Else
                If DataGridView1.Rows.Count <= 1 Then
                    MsgBox("Harap tambahkan data pegawai!")
                Else
                    tambahDetailAbsensiPegawai()
                    ButtonClear.Enabled = False
                    ButtonProsess.Enabled = False
                    ButtonTambah.Enabled = False
                    ButtonCetak.Enabled = True
                    DataGridView1.Rows.Clear()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilPegawai()
    End Sub

    Private Sub ButtonCariTahun_Click(sender As Object, e As EventArgs) Handles ButtonCariTahun.Click
        tampilTahunAjaran()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim biodata As New karyawan
        biodata.ShowDialog()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearData()
    End Sub

    Sub ClearData()
        tampilTahunAjaran()
        tampilPegawai()
        No()
        TextBoxCariPegawai.Text = ""
        TextBoxCariTahunAjaran.Text = ""
        TextBoxKeterangan.Text = ""
        TextBoxTotalAlfa.Text = 0
        TextBoxTotalHadir.Text = 0
        TextBoxTotalIzin.Text = 0
        RadioButtonMasuk.Checked = True
    End Sub

    Private Sub ButtonSetujui_Click(sender As Object, e As EventArgs) Handles ButtonSetujui.Click
        ComboBoxTahunAjaran.Enabled = False
        DateTimePickerTgl.Enabled = False
        TextBoxCariTahunAjaran.Enabled = False
        ButtonCariTahun.Enabled = False
        ButtonSetujui.Enabled = False
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        DataGridView1.Rows.Clear()
        ClearData()
        ComboBoxTahunAjaran.Enabled = True
        DateTimePickerTgl.Enabled = True
        TextBoxCariTahunAjaran.Enabled = True
        ButtonCariTahun.Enabled = True
        ButtonSetujui.Enabled = True
        ButtonHadirSemua.Enabled = True
        ButtonTambah.Enabled = True
        ButtonProsess.Enabled = True
    End Sub

    Private Sub ButtonHadirSemua_Click(sender As Object, e As EventArgs) Handles ButtonHadirSemua.Click
        Try
            tambahDataHadirSemua()
            ButtonHadirSemua.Enabled = False
            ButtonTambah.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Try
            Dim cetak As New Preview
            cetak.id = TextBoxId.Text
            cetak.printWhat = "absensi_pegawai"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Sub tampilDetailPegawai(paramIDPegawai As String)
        ds.Clear()
        DataGridView2.Rows.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT P.NO_INDUK 'NO_INDUK', P.NAMA 'PEGAWAI', P.GENDER 'GENDER', P.ALAMAT 'ALAMAT', P.TELP 'TELP' FROM PEGAWAI P WHERE P.STATUS='1' AND P.ID_PEGAWAI ='" & paramIDPegawai & "'"
            'MsgBox(ComboBoxSiswa.SelectedValue.ToString)
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    Dim noinduk As String = DRX.Item("NO_INDUK")
                    Dim pegawai As String = DRX.Item("PEGAWAI")
                    Dim telp As String = DRX.Item("TELP")
                    Dim gender As String = DRX.Item("GENDER")
                    Dim alamat As String = DRX.Item("ALAMAT")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, noinduk, pegawai, gender, telp, alamat)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            cmd.Dispose()
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan detail pegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub ComboBoxPegawai_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxPegawai.SelectedValueChanged
        Try
            tampilDetailPegawai(ComboBoxPegawai.SelectedValue.ToString)
        Catch ex As Exception
        End Try
    End Sub
End Class