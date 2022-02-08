Imports MySql.Data.MySqlClient

Public Class Siswa
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("siswa")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id As String

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from siswa"
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
        Dim qs As String = "Select tempat_lahir, tgl_lahir, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp From SISWA WHERE status = 1 ORDER BY id_siswa"

        Dim berdasarkan As String = "nama"
        If RadioButton_NoInduk.Checked Then
            berdasarkan = "noInduk"
        ElseIf RadioButton_NISN.Checked Then
            berdasarkan = "NISN"
        ElseIf RadioButton_Nama.Checked Then
            berdasarkan = "nama"
        End If

        If berdasarkan = "nama" Then
            qs = "Select tempat_lahir, tgl_lahir, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp From SISWA WHERE status = 1 AND nama_siswa like '%" & TextBoxCari.Text & "%' ORDER BY id_siswa"
        ElseIf berdasarkan = "noInduk" Then
            qs = "Select tempat_lahir, tgl_lahir, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp From SISWA WHERE status = 1 AND no_induk like '%" & TextBoxCari.Text & "%' ORDER BY id_siswa"
        ElseIf berdasarkan = "NISN" Then
            qs = "Select tempat_lahir, tgl_lahir, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp From SISWA WHERE status = 1 AND NISN like '%" & TextBoxCari.Text & "%' ORDER BY id_siswa"
        Else
            qs = "Select tempat_lahir, tgl_lahir, id_siswa, no_induk, nisn, nama_siswa, alamat, gender, agama, tgl_masuk, asal_sd, ayah, ibu, telp From SISWA WHERE status = 1 AND nama_siswa like '%" & TextBoxCari.Text & "%' ORDER BY id_siswa"
        End If

        ds.Clear()
        DataGridView1.Rows.Clear()
        Dim temp As String = ""
        Try
            Dim id As String = ""
            Dim noInduk As String = ""
            Dim NISN As String = ""
            Dim nama_siswa As String = ""
            Dim alamat As String = ""
            Dim gender As String = ""
            Dim agama As String = ""
            Dim tgl_masuk As Date = Today
            Dim asalSD As String = ""
            Dim ayah As String = ""
            Dim ibu As String = ""
            Dim telp As String = ""
            Dim tempatlahir As String = ""
            Dim tgllahir As String = ""

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader

            If DRX.HasRows Then
                While DRX.Read()
                    id = DRX.Item("id_siswa")
                    noInduk = DRX.Item("no_induk")
                    NISN = DRX.Item("nisn")
                    nama_siswa = DRX.Item("nama_siswa")
                    alamat = DRX.Item("alamat")
                    gender = DRX.Item("gender")
                    agama = DRX.Item("agama")
                    tgl_masuk = DRX.Item("tgl_masuk")
                    asalSD = DRX.Item("asal_sd")
                    ayah = DRX.Item("ayah")
                    ibu = DRX.Item("ibu")
                    telp = DRX.Item("telp")
                    tempatlahir = DRX.Item("tempat_lahir")
                    tgllahir = DRX.Item("tgl_lahir")
                    DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, id, noInduk, NISN, nama_siswa, tempatlahir, tgllahir, alamat, gender, agama, tgl_masuk, asalSD, ayah, ibu, telp)
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan data siswa bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function CekAkunKembar_Siswa(paramNOInduk As String)
        Dim qs As String = "SELECT NO_INDUK FROM SISWA WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim noInduk As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    noInduk = DRX.Item("NO_INDUK")
                    If noInduk = paramNOInduk Then
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
            MsgBox("Cek no induk bermasalah! " + ex.ToString)
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

        Dim Cek_noInduk As String = CekAkunKembar_Siswa(TextBoxNoInduk.Text)
        If Cek_noInduk = "1" Then
            MsgBox("Nomer induk siswa " + TextBoxNoInduk.Text + " telah ada!")
            Exit Sub
        End If
        If TextBoxNama.Text <> "" Then
            If TextBoxNoInduk.Text <> "" And TextBoxNISN.Text <> "" Then
                Try
                    conn = Form1.koneksi()
                    Dim qs As String = "INSERT INTO SISWA(TEMPAT_LAHIR, TGL_LAHIR, ID_SISWA, NO_INDUK, NISN, NAMA_SISWA, ALAMAT, GENDER, AGAMA, TGL_MASUK, ASAL_SD, AYAH, IBU, TELP,STATUS) VALUES ('" & TextBoxTempatLahir.Text & "','" & Format(DateTimePickerTglLahir.Value, "yyyy-MM-dd") & "','" & indeks & "','" & TextBoxNoInduk.Text & "','" & TextBoxNISN.Text & "','" & TextBoxNama.Text & "','" & TextBoxAlamat.Text & "','" & gender & "','Islam','" & Format(DateTimePickerTglMasuk.Value, "yyyy-MM-dd") & "','" & TextBoxAsalSD.Text & "','" & TextBoxAyah.Text & "','" & TextBoxIbu.Text & "','" & TextBoxTelp.Text & "',1)"
                    cmd = New MySqlCommand(qs, conn)
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MsgBox("Tambah data siswa berhasil dilakukan!")
                Catch ex As Exception
                    MsgBox("Tambah data siswa gagal dilakukan! " + ex.ToString)
                End Try
            Else
            End If
        Else
            MsgBox("Nama siswa belum dimasukkan!")
        End If
    End Sub

    Sub ubahSiswa()
        Dim gender As String = ""
        If RadioButtonPria.Checked Then
            gender = "Laki-laki"
        ElseIf RadioButtonWanita.Checked Then
            gender = "Perempuan"
        End If

        If TextBoxNama.Text <> "" Then
            Try
                conn = Form1.koneksi()
                Dim qs As String = "update siswa set tgl_masuk ='" & Format(DateTimePickerTglMasuk.Value, "yyyy-MM-dd") & "', tempat_lahir = '" & TextBoxTempatLahir.Text & "', tgl_lahir ='" & Format(DateTimePickerTglLahir.Value, "yyyy-MM-dd") & "', gender ='" & gender & "', nama_siswa ='" & TextBoxNama.Text & "', no_induk ='" & TextBoxNoInduk.Text & "', NISN = '" & TextBoxNISN.Text & "', agama = 'Islam', alamat ='" & TextBoxAlamat.Text & "', asal_sd ='" & TextBoxAsalSD.Text & "', ayah ='" & TextBoxAyah.Text & "', ibu ='" & TextBoxIbu.Text & "', telp ='" & TextBoxTelp.Text & "' WHERE id_siswa ='" & id & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data siswa berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data siswa gagal dilakukan!")
            End Try
        Else
            MsgBox("Nama siswa wajib dimasukkan!")
        End If
    End Sub

    Sub hapusSiswa()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update siswa set STATUS=0 WHERE no_induk = '" & TextBoxNoInduk.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data siswa berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data siswa gagal dilakukan!")
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
            End If
        Next
    End Sub

    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilSiswa()
        tampilSiswa()
        formatTampilanGrid()
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
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data siswa " + TextBoxNama.Text + "?", "Ubah Data Pegawai Siswa " + TextBoxNama.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahSiswa()
                        tampilSiswa()
                        id = ""
                        ButtonTambahUbah.Text = "Tambah"
                        clearData()
                        formatTampilanGrid()
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data siswa " + TextBoxNama.Text + "?", "Hapus Data Pegawai Siswa " + TextBoxNama.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusSiswa()
                tampilSiswa()
                formatTampilanGrid()
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
        ButtonTambahUbah.Text = "Ubah"

        Try
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNoInduk.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxNISN.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString

            TextBoxAsalSD.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
            TextBoxAyah.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
            TextBoxIbu.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
            TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString
            TextBoxTempatLahir.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            DateTimePickerTglLahir.Value = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            gender = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            If gender = "Laki-laki" Then
                RadioButtonPria.Checked = True
            ElseIf gender = "Perempuan" Then
                RadioButtonWanita.Checked = True
            End If
            DateTimePickerTglMasuk.Value = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
        Catch ex As Exception
        End Try
    End Sub


    Sub clearData()
        TextBoxNoInduk.Text = ""
        TextBoxNISN.Text = ""
        TextBoxNama.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxAsalSD.Text = ""
        TextBoxTelp.Text = ""
        TextBoxIbu.Text = ""
        TextBoxAyah.Text = ""
        TextBoxTempatLahir.Text = ""
        DateTimePickerTglMasuk.Value = Today
        DateTimePickerTglLahir.Value = Today
        TextBoxCari.Text = ""
        id = ""
        ButtonTambahUbah.Text = "Tambah"
        tampilSiswa()
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

    Private Sub TextBoxTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelp.KeyPress
        Try
            Dim allowedChars As String = "0123456789.-,+"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
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