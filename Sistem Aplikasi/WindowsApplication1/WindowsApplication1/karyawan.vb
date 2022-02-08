Imports MySql.Data.MySqlClient
Public Class karyawan
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("pegawai")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public id_karyawan As String

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from pegawai"
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
            MsgBox(ex.ToString)
            MessageBox.Show("Indexing gagal dilakukan!")
        End Try
        Return temp
    End Function

    Sub tampilPegawai()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_pegawai 'ID', no_induk 'No Induk', nama 'Nama', tempat_lahir 'Tempat Lahir', tgl_lahir 'Tgl Lahir', gender 'Gender', agama 'Agama', alamat 'Alamat', telp 'Telp', tgl_masuk 'Tgl Masuk', password 'Password' From pegawai where status = 1 ORDER BY id_pegawai"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan pegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function CekAkunKembar_Pegawai(paramNoInduk As String)
        Dim qs As String = "SELECT NO_INDUK FROM PEGAWAI WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim no_induk As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    no_induk = DRX.Item("NO_INDUK")
                    If no_induk = paramNoInduk Then
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
            MsgBox("Cek pegawai bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub tambahPegawai()
        Dim indeks As Integer = No()
        Dim gender As String = ""
        If RadioButtonPria.Checked Then
            gender = "Laki-laki"
        ElseIf RadioButtonWanita.Checked Then
            gender = "Perempuan"
        End If

        Dim cekPegawai As String = CekAkunKembar_Pegawai(TextBoxNoInduk.Text)
        If cekPegawai = "1" Then
            MsgBox("No induk pegawai " + TextBoxNoInduk.Text + " telah ada!")
            Exit Sub
        End If

        If TextBoxPass.Text = TextBoxRePass.Text Then
            Try
                Dim passwordMD5 As String = Form1.getMD5Hash(TextBoxPass.Text)
                conn = Form1.koneksi()
                Dim qs As String = "insert into pegawai(tempat_lahir, tgl_lahir, id_pegawai, no_induk, nama, password, agama, gender, alamat, telp, tgl_masuk, status) VALUES('" & TextBoxTempatLahir.Text & "','" & Format(DateTimePickerTglLahir.Value, "yyyy-MM-dd") & "'," & indeks & ",'" & TextBoxNoInduk.Text & "','" & TextBoxNama.Text & "','" & passwordMD5 & "','Islam','" & gender & "','" & TextBoxAlamat.Text & "','" & TextBoxTelp.Text & "','" & Format(DateTimePickerTglMasuk.Value, "yyyy-MM-dd") & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah data pegawai berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Tambah data pegawai gagal dilakukan! " + ex.ToString)
            End Try
        Else
            MsgBox("Password dan re-Password tidak sama!")
        End If
    End Sub

    Sub ubahKaryawan()
        Dim gender As String = ""
        If RadioButtonPria.Checked Then
            gender = "Laki-laki"
        ElseIf RadioButtonWanita.Checked Then
            gender = "Perempuan"
        End If

        If TextBoxPass.Text = TextBoxRePass.Text Then
            Try
                Dim passwordMD5 As String = Form1.getMD5Hash(TextBoxPass.Text)
                conn = Form1.koneksi()
                Dim qs As String = "update pegawai set tgl_lahir ='" & Format(DateTimePickerTglLahir.Value, "yyyy-MM-dd") & "', tempat_lahir ='" & TextBoxTempatLahir.Text & "', no_induk = '" & TextBoxNoInduk.Text & "', NAMA ='" & TextBoxNama.Text & "', PASSWORD ='" & passwordMD5 & "', Agama = '" & TextBoxAgama.Text & "', alamat = '" & TextBoxAlamat.Text & "', telp = '" & TextBoxTelp.Text & "', tgl_masuk ='" & Format(DateTimePickerTglMasuk.Value, "yyyy-MM-dd") & "', gender ='" & gender & "' WHERE id_pegawai = '" & id_karyawan & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Edit data pegawai berhasil dilakukan!")
            Catch ex As Exception
                MsgBox("Edit data pegawai gagal dilakukan!")
            End Try
        Else
            MsgBox("Password dan re-Password tidak sama!")
        End If
    End Sub

    Sub hapusKaryawan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update pegawai set STATUS=0 WHERE id_pegawai = '" & id_karyawan & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data pegawai berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data pegawai gagal dilakukan!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSimpanUbah.Click
        Try
            If ButtonSimpanUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data pegawai " + TextBoxNama.Text + "?", "Hapus Data Pegawai Pegawai " + TextBoxNama.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahKaryawan()
                        tampilPegawai()
                        ButtonSimpanUbah.Text = "Tambah"
                        id_karyawan = ""
                        clearData()
                        formatTampilanGrid()
                    End If
                Catch ex As Exception
                End Try
            Else
                tambahPegawai()
                tampilPegawai()
                clearData()
                formatTampilanGrid()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilPegawai()
        formatTampilanGrid()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ButtonSimpanUbah.Text = "Ubah"
        Dim gender As String = ""
        Dim tgl_masuk As Date = Today
        Try
            id_karyawan = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxNoInduk.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            TextBoxTempatLahir.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            DateTimePickerTglLahir.Value = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            gender = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            If gender = "Laki-laki" Then
                RadioButtonPria.Checked = True
            ElseIf gender = "Perempuan" Then
                RadioButtonWanita.Checked = True
            End If
            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            'tgl_masuk = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
            DateTimePickerTglMasuk.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString 'Format(tgl_masuk, "yyyy-MM-dd")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data pegawai " + TextBoxNama.Text + "?", "Hapus Data Pegawai Pegawai " + TextBoxNama.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusKaryawan()
                tampilPegawai()
                formatTampilanGrid()
                id_karyawan = ""
                ButtonSimpanUbah.Text = "Tambah"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub clearData()
        TextBoxCari.Text = ""
        TextBoxNama.Text = ""
        TextBoxPass.Text = ""
        TextBoxNoInduk.Text = ""
        TextBoxRePass.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxRePass.Text = ""
        TextBoxTelp.Text = ""
        TextBoxTempatLahir.Text = ""
        DateTimePickerTglLahir.Value = Today
        DateTimePickerTglMasuk.Value = Today
        RadioButtonPria.Checked = True
        ButtonSimpanUbah.Text = "Tambah"
        id_karyawan = ""
        tampilPegawai()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearData()
        formatTampilanGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tampilPegawai()
        formatTampilanGrid()
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
            End If
        Next
    End Sub

    Sub CariKaryawan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Dim berdasarkan As String = "nama"
        If RadioButton_NoInduk.Checked Then
            berdasarkan = "no_induk"
        ElseIf RadioButton_Nama.Checked Then
            berdasarkan = "nama"
        End If

        Dim qs As String = "Select id_pegawai 'ID', no_induk 'No Induk', nama 'Nama', tempat_lahir 'Tempat Lahir', tgl_lahir 'Tgl Lahir', gender 'Gender', agama 'Agama', alamat 'Alamat', telp 'Telp', tgl_masuk 'Tgl Masuk', password 'Password' From pegawai where status = 1 ORDER BY id_pegawai"
        If berdasarkan = "no_induk" Then
            qs = "Select id_pegawai 'ID', no_induk 'No Induk', nama 'Nama', tempat_lahir 'Tempat Lahir', tgl_lahir 'Tgl Lahir', gender 'Gender', agama 'Agama', alamat 'Alamat', telp 'Telp', tgl_masuk 'Tgl Masuk', password 'Password' From pegawai where status = 1  AND no_induk like '%" & TextBoxCari.Text & "%' ORDER BY id_pegawai"
        ElseIf berdasarkan = "nama" Then
            qs = "Select id_pegawai 'ID', no_induk 'No Induk', nama 'Nama', tempat_lahir 'Tempat Lahir', tgl_lahir 'Tgl Lahir', gender 'Gender', agama 'Agama', alamat 'Alamat', telp 'Telp', tgl_masuk 'Tgl Masuk', password 'Password' From pegawai where status = 1  AND nama like '%" & TextBoxCari.Text & "%' ORDER BY id_pegawai"
        End If
        Try
            conn = Form1.koneksi()
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan pegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            CariKaryawan()
            formatTampilanGrid()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            formatTampilanGrid()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBoxNoInduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNoInduk.KeyPress
        Try
            Dim allowedChars As String = "0123456789.-,"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
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
End Class