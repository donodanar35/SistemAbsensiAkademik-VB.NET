Imports MySql.Data.MySqlClient

Public Class mutasi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("siswa")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id_mutasi As String
    Public nama_siswaku As String = ""

    Sub tampilMutasiSiswa(siswa As String)
       Dim qs As String = "Select tempat_lahir, tgl_lahir, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp From SISWA WHERE status = 1 AND id_siswa = '" & siswa & "'"
        Dim temp As String = ""
        Try
            Dim id_mutasi As String = ""
            Dim id As String = ""
            Dim noInduk As String = ""
            Dim NISN As String = ""
            Dim alamat As String = ""
            Dim gender As String = ""
            Dim agama As String = ""
            Dim tgl_masuk As Date = Today
            Dim tgl_keluar As Date = Today
            Dim asalSD As String = ""
            Dim ayah As String = ""
            Dim ibu As String = ""
            Dim telp As String = ""
            Dim tempat_lahir As String = ""
            Dim tgl_lahir As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    'id_mutasi = DRX.Item("id_mutasi")
                    'id = DRX.Item("id_siswa")
                    TextBoxNoInduk.Text = DRX.Item("no_induk")
                    TextBoxNISN.Text = DRX.Item("nisn")
                    nama_siswaku = DRX.Item("nama_siswa")
                    TextBoxAlamat.Text = DRX.Item("alamat")
                    gender = DRX.Item("gender")
                    If gender = "Laki-laki" Then
                        RadioButtonPria.Checked = True
                    ElseIf gender = "Perempuan" Then
                        RadioButtonWanita.Checked = True
                    End If
                    TextBoxAgama.Text = DRX.Item("agama")
                    DateTimePickerTglMasuk.Value = DRX.Item("tgl_masuk")
                    TextBoxAsalSD.Text = DRX.Item("asal_sd")
                    TextBoxAyah.Text = DRX.Item("ayah")
                    TextBoxIbu.Text = DRX.Item("ibu")
                    TextBoxTelp.Text = DRX.Item("telp")
                    TextBoxTempatLahir.Text = DRX.Item("tempat_lahir")
                    DateTimePickerTglLahir.Value = DRX.Item("tgl_lahir")
                End While
            Else
                ' MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan data mutasi siswa bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub tampilMasterSiswa(siswa As String)
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp  From siswa WHERE STATUS = 1 AND nama_siswa like '%" & siswa & "%'"
            Dim dax As New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("siswa")
            dax.Fill(dt)

            ComboBoxNama.DataSource = dt
            ComboBoxNama.DisplayMember = "nama_siswa"
            ComboBoxNama.ValueMember = "id_siswa"
            conn.Close()
        Catch ex As Exception
            'MsgBox("Tampilan master siswa bermasalah! ")
        End Try
    End Sub

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from mutasi_siswa"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    temp = DR.Item("no") + 1
                End While
            Else
                temp = 1
            End If
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilSiswa()
        DataGridView1.Rows.Clear()
        Dim qs As String = "Select tempat_lahir, tgl_lahir, id_mutasi, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, tgl_keluar, asal_sd, ayah, ibu, telp From MUTASI_SISWA WHERE status = 1 ORDER BY id_mutasi"

        Dim berdasarkan As String = "nama"
        If RadioButton_NoInduk.Checked Then
            berdasarkan = "noInduk"
        ElseIf RadioButton_NISN.Checked Then
            berdasarkan = "NISN"
        ElseIf RadioButton_Nama.Checked Then
            berdasarkan = "nama"
        End If

        If berdasarkan = "nama" Then
            qs = "Select tempat_lahir, tgl_lahir, id_mutasi, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, tgl_keluar, asal_sd, ayah, ibu, telp From MUTASI_SISWA WHERE status = 1 AND nama_siswa like '%" & TextBoxCari.Text & "%' ORDER BY id_mutasi"
        ElseIf berdasarkan = "noInduk" Then
            qs = "Select tempat_lahir, tgl_lahir, id_mutasi, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, tgl_keluar, asal_sd, ayah, ibu, telp From MUTASI_SISWA WHERE status = 1 AND no_induk like '%" & TextBoxCari.Text & "%' ORDER BY id_mutasi"
        ElseIf berdasarkan = "NISN" Then
            qs = "Select tempat_lahir, tgl_lahir, id_mutasi, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, tgl_keluar, asal_sd, ayah, ibu, telp From MUTASI_SISWA WHERE status = 1 AND NISN like '%" & TextBoxCari.Text & "%' ORDER BY id_mutasi"
        Else
            qs = "Select tempat_lahir, tgl_lahir, id_mutasi, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, tgl_keluar, asal_sd, ayah, ibu, telp From MUTASI_SISWA WHERE status = 1 AND nama_siswa like '%" & TextBoxCari.Text & "%' ORDER BY id_mutasi"
        End If

        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id_mutasi As String = ""
            Dim id As String = ""
            Dim noInduk As String = ""
            Dim NISN As String = ""
            Dim nama_siswa As String
            Dim alamat As String = ""
            Dim gender As String = ""
            Dim agama As String = ""
            Dim tgl_masuk As Date = Today
            Dim tgl_keluar As Date = Today
            Dim asalSD As String = ""
            Dim ayah As String = ""
            Dim ibu As String = ""
            Dim telp As String = ""
            Dim tempat_lahir As String = ""
            Dim tgl_lahir As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id_mutasi = DRX.Item("id_mutasi")
                    id = DRX.Item("id_siswa")
                    noInduk = DRX.Item("no_induk")
                    NISN = DRX.Item("nisn")
                    nama_siswa = DRX.Item("nama_siswa")
                    alamat = DRX.Item("alamat")
                    gender = DRX.Item("gender")
                    agama = DRX.Item("agama")
                    tgl_masuk = DRX.Item("tgl_masuk")
                    tgl_keluar = DRX.Item("tgl_keluar")
                    asalSD = DRX.Item("asal_sd")
                    ayah = DRX.Item("ayah")
                    ibu = DRX.Item("ibu")
                    telp = DRX.Item("telp")
                    tempat_lahir = DRX.Item("tempat_lahir")
                    tgl_lahir = DRX.Item("tgl_lahir")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id_mutasi, id, noInduk, NISN, nama_siswa, tempat_lahir, tgl_lahir, alamat, gender, agama, asalSD, ayah, ibu, telp, tgl_masuk, tgl_keluar)
                End While
            Else
                'MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan data mutasi siswa bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function CekAkunKembar_Mutasi(paramNISN As String)
        Dim qs As String = "SELECT NISN FROM MUTASI_SISWA WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim NISN As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    NISN = DRX.Item("NISN")
                    If NISN = paramNISN Then
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
            MsgBox("Cek mutasi bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub tambahSiswa()
        Dim indeks As Integer = No()
        Dim gender As String = ""
        If RadioButtonPria.Checked Then
            gender = "Laki-laki"
        ElseIf RadioButtonWanita.Checked Then
            gender = "Perempuan"
        End If

        Dim cekNISN As String = CekAkunKembar_Mutasi(TextBoxNISN.Text)
        If cekNISN = "1" Then
            MsgBox("Siswa dengan NISN " + TextBoxNISN.Text + " telah dimutasi!")
            Exit Sub
        End If
        If TextBoxNoInduk.Text <> "" And TextBoxNISN.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "INSERT INTO MUTASI_SISWA(ID_MUTASI, ID_SISWA, NO_INDUK, NISN, NAMA_SISWA, ALAMAT, GENDER, AGAMA, TGL_MASUK, TGL_KELUAR, ASAL_SD, AYAH, IBU, TELP, TEMPAT_LAHIR, TGL_LAHIR, STATUS) VALUES ('" & indeks & "','" & ComboBoxNama.SelectedValue.ToString & "','" & TextBoxNoInduk.Text & "','" & TextBoxNISN.Text & "','" & nama_siswaku & "','" & TextBoxAlamat.Text & "','" & gender & "','" & TextBoxAgama.Text & "','" & Format(DateTimePickerTglMasuk.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerKeluar.Value, "yyyy-MM-dd") & "','" & TextBoxAsalSD.Text & "','" & TextBoxAyah.Text & "','" & TextBoxIbu.Text & "','" & TextBoxTelp.Text & "','" & TextBoxTempatLahir.Text & "','" & Format(DateTimePickerTglLahir.Value, "yyyy-MM-dd") & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                nama_siswaku = ""
                MsgBox("Tambah data mutasi siswa berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data siswa gagal dilakukan! " + ex.ToString)
            End Try
        Else
        End If
    End Sub

    Sub ubahSiswa()
        Dim gender As String = ""
        If RadioButtonPria.Checked Then
            gender = "Laki-laki"
        ElseIf RadioButtonWanita.Checked Then
            gender = "Perempuan"
        End If

        Try
            conn = Form1.koneksi()
            Dim qs As String = "update mutasi_siswa set gender ='" & gender & "', no_induk ='" & TextBoxNoInduk.Text & "', NISN = '" & TextBoxNISN.Text & "', agama = '" & TextBoxAgama.Text & "', alamat ='" & TextBoxAlamat.Text & "', asal_sd ='" & TextBoxAsalSD.Text & "', ayah ='" & TextBoxAyah.Text & "', ibu ='" & TextBoxIbu.Text & "', telp ='" & TextBoxTelp.Text & "', tgl_lahir ='" & Format(DateTimePickerTglLahir.Value, "yyyy-MM-dd") & "', tempat_lahir='" & TextBoxTempatLahir.Text & "', tgl_masuk='" & Format(DateTimePickerTglMasuk.Value, "yyyy-MM-dd") & "', tgl_keluar ='" & Format(DateTimePickerKeluar.Value, "yyyy-MM-dd") & "' WHERE id_mutasi = '" & id_mutasi & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit data mutasi siswa berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Edit data mutasi siswa gagal dilakukan!")
        End Try

    End Sub

    Sub hapusSiswa()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update mutasi_siswa set STATUS=0 WHERE id_mutasi = '" & id_mutasi & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data mutasi siswa berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data mutasi siswa gagal dilakukan!")
        End Try
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(8).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(9).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(10).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(11).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(13).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(14).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(15).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(8).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(9).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(10).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(11).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(12).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(13).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(14).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(15).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tampilMasterSiswa("")
            tampilSiswa()
            formatTampilanGrid()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahSiswa()
                tampilSiswa()
                clearData()
                formatTampilanGrid()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data mutasi siswa no. induk " + TextBoxNoInduk.Text + "?", "Ubah Data Mutasi Siswa No. Induk " + TextBoxNoInduk.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahSiswa()
                        tampilSiswa()
                        clearData()
                        formatTampilanGrid()
                        ButtonTambahUbah.Text = "Tambah"
                        id_mutasi = ""
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data mutasi siswa no. induk " + TextBoxNoInduk.Text + "?", "Hapus Data Mutasi Siswa No. Induk " + TextBoxNoInduk.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusSiswa()
                tampilSiswa()
                formatTampilanGrid()
                ButtonTambahUbah.Text = "Tambah"
                id_mutasi = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        tampilSiswa()
        formatTampilanGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim gender As String = ""
        Dim tgl_masuk As Date = Today
        Dim tgl_keluar As Date = Today
        ButtonTambahUbah.Text = "Ubah"
        Try
            id_mutasi = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNoInduk.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxNISN.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            tampilMasterSiswa(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
            TextBoxTempatLahir.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            DateTimePickerTglLahir.Value = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            gender = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            If gender = "Laki-laki" Then
                RadioButtonPria.Checked = True
            ElseIf gender = "Perempuan" Then
                RadioButtonWanita.Checked = True
            End If
            TextBoxAgama.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
            TextBoxAsalSD.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
            TextBoxAyah.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
            TextBoxIbu.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
            TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString
            DateTimePickerTglMasuk.Value = DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString
            DateTimePickerKeluar.Value = DataGridView1.Rows(e.RowIndex).Cells(15).Value.ToString
        Catch ex As Exception
        End Try
    End Sub


    Sub clearData()
        tampilMasterSiswa("")
        TextBoxNoInduk.Text = ""
        TextBoxNISN.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxAsalSD.Text = ""
        TextBoxTelp.Text = ""
        TextBoxIbu.Text = ""
        TextBoxAyah.Text = ""
        TextBoxCariSiswa.Text = ""
        TextBoxCari.Text = ""
        TextBoxTempatLahir.Text = ""
        RadioButtonPria.Checked = True
        DateTimePickerTglMasuk.Value = Today
        DateTimePickerTglLahir.Value = Today
        DateTimePickerKeluar.Value = Today
        tampilSiswa()
        ButtonTambahUbah.Text = "Tambah"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        TextBoxCari.Text = ""
        tampilSiswa()
        formatTampilanGrid()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
        formatTampilanGrid()
    End Sub
 
    Private Sub ComboBoxNama_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxNama.SelectedValueChanged
        tampilMutasiSiswa(ComboBoxNama.SelectedValue.ToString)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        tampilMasterSiswa(TextBoxCariSiswa.Text)
    End Sub

    Private Sub TextBoxNISN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNISN.KeyPress
        Try
            Dim allowedChars As String = "0123456789.-,+"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxNoInduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNoInduk.KeyPress
        Try
            Dim allowedChars As String = "0123456789.-,+"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class