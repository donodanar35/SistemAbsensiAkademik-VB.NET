Imports MySql.Data.MySqlClient

Public Class Pindah_Kelas
    Public usernameku As String
    Public namapetugas As String
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public cmdx As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Dim kelas As String = ""
    Public id_stok As String = ""

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

    Sub tampilKelas2()
        ComboBoxKelas2.DataSource = Nothing
        ds.Clear()
        Try
            Dim qs As String = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.NAMA_KELAS LIKE '%" & TextBoxCariRombel.Text & "%' GROUP BY ID_KELAS"
            If IsDBNull(ComboBoxTahunAjaran.SelectedValue) Then
                qs = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.TAHUN_AJARAN LIKE '%" & ComboBoxTahunAjaran.SelectedValue & "%' AND H.NAMA_KELAS LIKE '%" & TextBoxCariRombel2.Text & "%' GROUP BY ID_KELAS"
            ElseIf Not IsDBNull(ComboBoxTahunAjaran.SelectedValue) Then
                qs = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.TAHUN_AJARAN LIKE '%" & ComboBoxTahunAjaran.SelectedValue.ToString & "%' AND H.NAMA_KELAS LIKE '%" & TextBoxCariRombel2.Text & "%' GROUP BY ID_KELAS"
            End If
            conn = Form1.koneksi()

            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("kelas")
            da.Fill(dt)

            ComboBoxKelas2.DataSource = dt
            ComboBoxKelas2.DisplayMember = "NAMA_KELAS"
            ComboBoxKelas2.ValueMember = "ID_KELAS"
            conn.Close()
        Catch ex As Exception
            'MsgBox("Tampilan kelas bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilKelas()
        ComboBoxKelas.DataSource = Nothing
        ds.Clear()
        Try
            Dim qs As String = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.NAMA_KELAS LIKE '%" & TextBoxCariRombel.Text & "%' GROUP BY ID_KELAS"
            If IsDBNull(ComboBoxTahunAjaran.SelectedValue) Then
                qs = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.TAHUN_AJARAN LIKE '%" & ComboBoxTahunAjaran.SelectedValue & "%' AND H.NAMA_KELAS LIKE '%" & TextBoxCariRombel.Text & "%' GROUP BY ID_KELAS"
            ElseIf Not IsDBNull(ComboBoxTahunAjaran.SelectedValue) Then
                qs = "SELECT D.ID_KELAS 'ID_KELAS', H.NAMA_KELAS 'NAMA_KELAS' FROM DKELAS D, HKELAS H, SISWA S WHERE D.ID_KELAS = H.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND H.TAHUN_AJARAN LIKE '%" & ComboBoxTahunAjaran.SelectedValue.ToString & "%' AND H.NAMA_KELAS LIKE '%" & TextBoxCariRombel.Text & "%' GROUP BY ID_KELAS"
            End If
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

    Sub tampilSiswa()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT D.ID_SISWA, S.NAMA_SISWA FROM DKELAS D, SISWA S, HKELAS H  WHERE D.ID_SISWA = S.ID_SISWA  AND D.ID_KELAS = H.ID_KELAS AND H.ID_KELAS LIKE '" & ComboBoxKelas.SelectedValue & "' AND S.NAMA_SISWA LIKE '%" & TextBoxCariSiswa.Text & "%' AND D.STATUS='1'"
            If RadioButtonKelasLain.Checked Then
                qs = "SELECT D.ID_SISWA, S.NAMA_SISWA FROM DKELAS D, SISWA S, HKELAS H  WHERE D.ID_SISWA = S.ID_SISWA  AND D.ID_KELAS = H.ID_KELAS AND H.ID_KELAS LIKE '" & ComboBoxKelas.SelectedValue & "' AND S.NAMA_SISWA LIKE '%" & TextBoxCariSiswa.Text & "%' AND D.STATUS='1'"
            ElseIf RadioButtonSekolahLain.Checked Then
                qs = "SELECT S.ID_SISWA, S.NAMA_SISWA FROM SISWA S WHERE S.NAMA_SISWA LIKE '%" & TextBoxCariSiswa.Text & "%' AND S.STATUS='1'"
            End If
            da = New MySqlDataAdapter(qs, conn)
            Dim dtSiswa As New DataTable("siswa")
            da.Fill(dtSiswa)

            ComboBoxSiswa.DataSource = dtSiswa
            ComboBoxSiswa.DisplayMember = "nama_siswa"
            ComboBoxSiswa.ValueMember = "id_siswa"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan siswa bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub Pindah_Kelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilTahunAjaran()
        tampilKelas()
        tampilSiswa()
    End Sub

    Private Sub ComboBoxTahunAjaran_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxTahunAjaran.SelectedValueChanged
        tampilKelas()
        tampilKelas2()
    End Sub

    Private Sub ComboBoxKelas_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxKelas.SelectedValueChanged
        tampilSiswa()
    End Sub

    Sub tampilDetailSiswa(paramIDSiswa As String)
        ds.Clear()
        DataGridView2.Rows.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT S.NO_INDUK 'NO_INDUK', S.NISN 'NISN', S.NAMA_SISWA 'SISWA', S.GENDER 'GENDER', S.ALAMAT 'ALAMAT' FROM SISWA S WHERE S.STATUS='1' AND S.ID_SISWA ='" & paramIDSiswa & "'"
            'MsgBox(ComboBoxSiswa.SelectedValue.ToString)
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    Dim noinduk As String = DRX.Item("NO_INDUK")
                    Dim siswa As String = DRX.Item("SISWA")
                    Dim nisn As String = DRX.Item("NISN")
                    Dim gender As String = DRX.Item("GENDER")
                    Dim alamat As String = DRX.Item("ALAMAT")
                    DataGridView2.Rows.Insert(DataGridView2.NewRowIndex, noinduk, nisn, siswa, gender, alamat)
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

    Sub tampilDetailKelas(paramIDKelas As String)
        ds.Clear()
        DataGridView1.Rows.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "SELECT S.NO_INDUK 'NO_INDUK', S.NISN 'NISN', S.NAMA_SISWA 'SISWA', S.GENDER 'GENDER', S.ALAMAT 'ALAMAT' FROM SISWA S, HKELAS H, DKELAS D WHERE H.ID_KELAS = D.ID_KELAS AND S.ID_SISWA = D.ID_SISWA AND S.STATUS='1' AND D.STATUS='1' AND H.ID_KELAS ='" & paramIDKelas & "'"
            'MsgBox(ComboBoxSiswa.SelectedValue.ToString)
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    Dim noinduk As String = DRX.Item("NO_INDUK")
                    Dim siswa As String = DRX.Item("SISWA")
                    Dim nisn As String = DRX.Item("NISN")
                    Dim gender As String = DRX.Item("GENDER")
                    Dim alamat As String = DRX.Item("ALAMAT")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, noinduk, nisn, siswa, gender, alamat)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            cmd.Dispose()
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan detail kelas bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub ComboBoxSiswa_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSiswa.SelectedValueChanged
        Try
            tampilDetailSiswa(ComboBoxSiswa.SelectedValue.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBoxKelas2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxKelas2.SelectedValueChanged
        Try
            tampilDetailKelas(ComboBoxKelas2.SelectedValue.ToString)
        Catch ex As Exception
        End Try
    End Sub

    Sub PindahkanSiswa()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "INSERT INTO DKELAS (ID_SISWA, ID_KELAS, STATUS) VALUES ('" & ComboBoxSiswa.SelectedValue.ToString & "','" & ComboBoxKelas2.SelectedValue.ToString & "',1)"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            Dim qsx As String = "update dkelas set status =2 WHERE ID_SISWA = '" & ComboBoxSiswa.SelectedValue.ToString & "' AND ID_KELAS = '" & ComboBoxKelas.SelectedValue.ToString & "'"
            cmdx = New MySqlCommand(qsx, conn)
            cmdx.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            MsgBox("Siswa berhasil dipindahkan!")
        Catch ex As Exception
            MsgBox("Siswa pindah bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Try
            PindahkanSiswa()
            tampilDetailKelas(ComboBoxKelas2.SelectedValue.ToString)
            tampilSiswa()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilTahunAjaran()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampilKelas()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tampilSiswa()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilKelas2()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSekolahLain.CheckedChanged
        If RadioButtonSekolahLain.Checked Then
            ComboBoxKelas.Enabled = False
            TextBoxCariRombel.Enabled = False
            Button2.Enabled = False
            tampilSiswa()
        End If
    End Sub

    Private Sub RadioButtonKelasLain_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKelasLain.CheckedChanged
        If RadioButtonKelasLain.Checked Then
            ComboBoxKelas.Enabled = True
            TextBoxCariRombel.Enabled = True
            Button2.Enabled = True
            tampilSiswa()
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        tampilTahunAjaran()
        tampilKelas()
        tampilSiswa()
        TextBoxCariRombel.Text = ""
        TextBoxCariRombel2.Text = ""
        TextBoxCariSiswa.Text = ""
        TextBoxCariTahunAjaran.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim biodata As New Siswa
        biodata.ShowDialog()
    End Sub
End Class