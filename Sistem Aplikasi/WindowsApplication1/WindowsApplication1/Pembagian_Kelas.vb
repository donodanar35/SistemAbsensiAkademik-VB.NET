Imports MySql.Data.MySqlClient
Public Class Pembagian_Kelas
    Public usernameku As String
    Public namapetugas As String
    Public id_sampel As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("kelas")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Public id_stok As String = ""
    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from hkelas"
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
        TextBoxId.Text = temp.ToString + "-" + rombel + "-" + ComboBoxTahunAjaran.SelectedValue
        Return temp
    End Function

    Sub tambahHeaderKelas()
        No()
        If TextBoxId.Text <> "" Then
            Try
                'usernameku = Form1.username
                conn = Form1.koneksi()

                Dim qs As String = "INSERT INTO HKELAS (TGL, NAMA_KELAS, ID_KELAS, ID_PEGAWAI, ID_ROMBEL, ID_RUANG, TAHUN_AJARAN, TOTAL_SISWA, STATUS) VALUES ('" & Format(Today, "yyyy-MM-dd") & "', '" & TextBoxKelas.Text & "','" & TextBoxId.Text & "','" & ComboBoxWaliKelas.SelectedValue.ToString & "','" & ComboBoxRombel.SelectedValue.ToString & "','" & ComboBoxRuang.SelectedValue.ToString & "','" & ComboBoxTahunAjaran.SelectedValue.ToString & "','" & DataGridView1.RowCount - 1 & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Header transaksi kelas error! " + ex.ToString)
            End Try
        Else
            MsgBox("Id_kelas kosong!")
        End If
    End Sub

    Sub tambahDetailKelas()
        tambahHeaderKelas()
        If TextBoxId.Text <> "" Then
            conn = Form1.koneksi()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            Try
                For i As Integer = 0 To DataGridView1.RowCount - 2
                    Dim qs As String = "INSERT INTO DKELAS (ID_KELAS, ID_SISWA,STATUS) VALUES ('" & TextBoxId.Text & "','" & DataGridView1.Rows(i).Cells(1).Value & "',1)"
                    Dim cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                Next
                trans.Commit()
                cmd.Dispose()
                MessageBox.Show("Data transaksi kelas berhasil dilakukan!")

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Data transaksi kelas gagal dilakukan!" + ex.ToString)
            End Try
            conn.Close()
        Else
            MsgBox("Id kosong!")
        End If
    End Sub

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

    Sub tampilWaliKelas()
        usernameku = Form1.username
        ds.Clear()
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT id_pegawai, nama From pegawai WHERE status = 1 AND nama like '%" & TextBoxCariWali.Text & "%' ORDER BY nama DESC"
            Dim cmd = New MySqlCommand(qs, conn)
            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("wali")
            da.Fill(dt)

            ComboBoxWaliKelas.DataSource = dt
            ComboBoxWaliKelas.DisplayMember = "nama"
            ComboBoxWaliKelas.ValueMember = "id_pegawai"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan wali bermasalah! ")
        End Try
    End Sub

    Sub tampilRombel()
        usernameku = Form1.username
        ds.Clear()
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT id_rombel, rombel From rombel WHERE status = 1 AND rombel like '%" & TextBoxCariRombel.Text & "%' ORDER BY rombel DESC"
            Dim cmd = New MySqlCommand(qs, conn)
            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("rombel")
            da.Fill(dt)

            ComboBoxRombel.DataSource = dt
            ComboBoxRombel.DisplayMember = "rombel"
            ComboBoxRombel.ValueMember = "id_rombel"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan rombel bermasalah! ")
        End Try
    End Sub

    Sub tampilRuang()
        usernameku = Form1.username
        ds.Clear()
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT id_ruang, ruang From ruang WHERE status = 1 AND ruang like '%" & TextBoxCariRuang.Text & "%' ORDER BY ruang DESC"
            Dim cmd = New MySqlCommand(qs, conn)
            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("ruang")
            da.Fill(dt)

            ComboBoxRuang.DataSource = dt
            ComboBoxRuang.DisplayMember = "ruang"
            ComboBoxRuang.ValueMember = "id_ruang"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan ruang bermasalah! ")
        End Try
    End Sub

    Sub tampilSiswa()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_siswa, nama_siswa From SISWA WHERE STATUS = 1 AND nama_siswa like '%" & TextBoxCariSiswa.Text & "%' ORDER BY nama_siswa DESC"
            da = New MySqlDataAdapter(qs, conn)
            Dim dtSiswa As New DataTable("siswa")
            da.Fill(dtSiswa)

            ComboBoxSiswa.DataSource = dtSiswa
            ComboBoxSiswa.DisplayMember = "nama_siswa"
            ComboBoxSiswa.ValueMember = "id_siswa"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan siswa bermasalah! ")
        End Try
    End Sub

    Function CekSiswa(paramIDSiswa As String, paramTahunAjar As String)
        ds.Clear()
        DataGridView2.Rows.Clear()
        Dim isSiswaExist As Integer = 0
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT S.NO_INDUK 'NO_INDUK', S.NAMA_SISWA 'SISWA', H.TAHUN_AJARAN 'TAHUN_AJARAN', R.ROMBEL 'ROMBEL', P.NAMA 'WALI_KELAS' FROM HKELAS H, ROMBEL R, PEGAWAI P, SISWA S, DKELAS D WHERE D.ID_KELAS = H.ID_KELAS AND R.ID_ROMBEL = H.ID_ROMBEL AND P.ID_PEGAWAI = H.ID_PEGAWAI AND S.ID_SISWA = D.ID_SISWA AND S.STATUS='1' AND D.ID_SISWA ='" & paramIDSiswa & "' AND H.TAHUN_AJARAN ='" & paramTahunAjar & "' ORDER BY H.TAHUN_AJARAN DESC"
            'MsgBox(ComboBoxSiswa.SelectedValue.ToString)
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            If DRX.HasRows Then
                While DRX.Read()
                    isSiswaExist = 1
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            cmd.Dispose()
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan detail siswa bermasalah! " + ex.ToString)
        End Try
        Return isSiswaExist
    End Function

    Sub tampilDetailSiswa(paramIDSiswa As String)
        ds.Clear()
        DataGridView2.Rows.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT S.NO_INDUK 'NO_INDUK', S.NAMA_SISWA 'SISWA', H.TAHUN_AJARAN 'TAHUN_AJARAN', R.ROMBEL 'ROMBEL', P.NAMA 'WALI_KELAS' FROM HKELAS H, ROMBEL R, PEGAWAI P, SISWA S, DKELAS D WHERE D.ID_KELAS = H.ID_KELAS AND R.ID_ROMBEL = H.ID_ROMBEL AND P.ID_PEGAWAI = H.ID_PEGAWAI AND S.ID_SISWA = D.ID_SISWA AND S.STATUS='1' AND D.ID_SISWA ='" & paramIDSiswa & "' ORDER BY H.TAHUN_AJARAN DESC"
            'MsgBox(ComboBoxSiswa.SelectedValue.ToString)
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    Dim noinduk As String = DRX.Item("NO_INDUK")
                    Dim siswa As String = DRX.Item("SISWA")
                    Dim tahun_ajaran As String = DRX.Item("TAHUN_AJARAN")
                    Dim wali As String = DRX.Item("WALI_KELAS")
                    Dim rombel As String = DRX.Item("ROMBEL")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, noinduk, siswa, tahun_ajaran, rombel, wali)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            cmd.Dispose()
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan detail siswa bermasalah! " + ex.ToString)
        End Try
    End Sub

    Dim rombel As String = ""
    Function ambilRombel()
        usernameku = Form1.username
        ds.Clear()
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT rombel From rombel WHERE id_rombel ='" & ComboBoxRombel.SelectedValue.ToString & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp = DRX.Item("rombel")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambil data rombel bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Function ambilSiswa()
        usernameku = Form1.username
        ds.Clear()
        Dim temp() As String = {"", ""}
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT id_siswa, nama_siswa From Siswa WHERE id_siswa like '" & ComboBoxSiswa.SelectedValue & "'"
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    temp(0) = DRX.Item("id_siswa")
                    temp(1) = DRX.Item("nama_siswa")
                End While
            End If

            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Fungsi ambil data siswa bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Try
            Dim issiswa As Integer = CekSiswa(ComboBoxSiswa.SelectedValue.ToString, ComboBoxTahunAjaran.SelectedValue.ToString)
            'MsgBox("isSiswa " + issiswa.ToString)
            If issiswa = 1 Then
                MsgBox("Siswa yang anda pilih telah ditempatkan pada tahun ajaran " + ComboBoxTahunAjaran.SelectedValue.ToString)
            Else
                If ComboBoxSiswa.Items.Count >= 0 Then
                    tambahData()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(3).Value = "Cancel" Then
                DataGridView1.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub

    Sub clearData()
        TextBoxCariRombel.Text = ""
        TextBoxCariRuang.Text = ""
        TextBoxCariSiswa.Text = ""
        TextBoxCariTahunAjaran.Text = ""
        TextBoxCariWali.Text = ""
        TextBoxKelas.Text = ""
        No()
        tampilRombel()
        tampilRuang()
        tampilTahunAjaran()
        tampilWaliKelas()
        tampilSiswa()
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        clearData()
        ButtonClear.Enabled = True
        ButtonProsess.Enabled = True
        ButtonTambah.Enabled = True
        ButtonCetak.Enabled = False

        No()
        ComboBoxRombel.Enabled = True
        ComboBoxRuang.Enabled = True
        ComboBoxTahunAjaran.Enabled = True
        ComboBoxWaliKelas.Enabled = True
        TextBoxCariRombel.Enabled = True
        TextBoxCariRuang.Enabled = True
        TextBoxCariTahunAjaran.Enabled = True
        TextBoxCariWali.Enabled = True
        ButtonCariRombel.Enabled = True
        ButtonCariRuang.Enabled = True
        ButtonCariTahun.Enabled = True
        ButtonCariWali.Enabled = True
        ButtonSetujui.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        Try
            Dim cetak As New Preview
            cetak.id = TextBoxId.Text
            cetak.printWhat = "kelas"
            cetak.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim brg As New Siswa
        brg.ShowDialog()
    End Sub

    Function CekAkunKembar_Kelas(ParamTahunAjar As String, ParamRombel As String, paramWali As String)
        Dim qs As String = "SELECT ID_PEGAWAI, ID_ROMBEL, TAHUN_AJARAN FROM HKELAS WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim wali As String = ""
            Dim rombel As String = ""
            Dim tahunAjar As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    wali = DRX.Item("ID_PEGAWAI")
                    rombel = DRX.Item("ID_ROMBEL")
                    tahunAjar = DRX.Item("TAHUN_AJARAN")
                    If wali = paramWali And rombel = ParamRombel And tahunAjar = ParamTahunAjar Then
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

    Private Sub ButtonProsess_Click(sender As Object, e As EventArgs) Handles ButtonProsess.Click
        Try
            Dim cekKelas As String = CekAkunKembar_Kelas(ComboBoxTahunAjaran.SelectedValue, ComboBoxRombel.SelectedValue, ComboBoxWaliKelas.SelectedValue)
            If cekKelas = "1" Then
                MsgBox("Kelas dengan rombel " + ComboBoxRombel.SelectedValue.ToString + " dan wali kelas " + ComboBoxWaliKelas.SelectedValue.ToString + " pada tahun ajaran " + ComboBoxTahunAjaran.SelectedValue.ToString + " telah ada!")
                Exit Sub
            End If
            If ButtonSetujui.Enabled = False Then
                If ComboBoxSiswa.Items.Count <= 0 Then
                    MsgBox("Harap isi data kelas!")
                Else
                    If DataGridView1.Rows.Count <= 1 Then
                        MsgBox("Harap tambahkan data kelas!")
                    Else
                        tambahDetailKelas()
                        ButtonClear.Enabled = False
                        ButtonProsess.Enabled = False
                        ButtonTambah.Enabled = False
                        ButtonCetak.Enabled = True
                        DataGridView1.Rows.Clear()
                    End If
                End If
            Else
                MsgBox("Harap isi data pembagian kelas, lalu tekan tombol setujui")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub tambahData()
        Try
            Dim isSiswa As Integer = 0
            For i As Integer = 0 To DataGridView1.RowCount - 2
                Dim siswa As String = DataGridView1.Rows(i).Cells(1).Value.ToString
                If siswa = ComboBoxSiswa.SelectedValue.ToString Then
                    isSiswa = 1
                    MsgBox("Data siswa telah diinput!")
                    Exit For
                End If
            Next
            Dim DataSiswa() As String = ambilSiswa()
            If isSiswa <> 1 Then
                DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, TextBoxId.Text, ComboBoxSiswa.SelectedValue.ToString, DataSiswa(1), "Cancel")
            End If
        Catch ex As Exception
            MsgBox("Tambah Data bermasalah!")
        End Try
    End Sub

    Private Sub sampel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilRombel()
        rombel = ambilRombel()
        tampilRuang()
        tampilTahunAjaran()
        tampilWaliKelas()
        tampilSiswa()
        No()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonSetujui.Click
        Try
            If TextBoxKelas.Text <> "" Then
                setujuiHeaderData()
            Else
                MsgBox("Harap isi nama kelas!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub setujuiHeaderData()
        No()
        ComboBoxRombel.Enabled = False
        ComboBoxRuang.Enabled = False
        ComboBoxTahunAjaran.Enabled = False
        ComboBoxWaliKelas.Enabled = False
        TextBoxCariRombel.Enabled = False
        TextBoxCariRuang.Enabled = False
        TextBoxCariTahunAjaran.Enabled = False
        TextBoxCariWali.Enabled = False
        ButtonCariRombel.Enabled = False
        ButtonCariRuang.Enabled = False
        ButtonCariTahun.Enabled = False
        ButtonCariWali.Enabled = False
        ButtonSetujui.Enabled = False
    End Sub

    Private Sub ComboBoxRombel_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxRombel.SelectedValueChanged
        rombel = ambilRombel()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilSiswa()
    End Sub

    Private Sub ButtonCariTahun_Click(sender As Object, e As EventArgs) Handles ButtonCariTahun.Click
        tampilTahunAjaran()
    End Sub

    Private Sub ButtonCariRombel_Click(sender As Object, e As EventArgs) Handles ButtonCariRombel.Click
        tampilRombel()
    End Sub

    Private Sub ButtonCariRuang_Click(sender As Object, e As EventArgs) Handles ButtonCariRuang.Click
        tampilRuang()
    End Sub

    Private Sub ButtonCariWali_Click(sender As Object, e As EventArgs) Handles ButtonCariWali.Click
        tampilWaliKelas()
    End Sub

    Private Sub ComboBoxSiswa_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSiswa.SelectedValueChanged
        tampilDetailSiswa(ComboBoxSiswa.SelectedValue.ToString)
    End Sub
End Class