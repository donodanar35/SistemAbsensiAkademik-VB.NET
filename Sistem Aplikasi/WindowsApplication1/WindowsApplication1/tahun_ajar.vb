Imports MySql.Data.MySqlClient
Public Class tahun_ajar
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("tahun_ajaran")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Sub tampilKategori()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select tahun_ajaran 'Tahun_Ajaran', tahun 'Dari Tahun', tahun2 'Sampai Tahun', semester 'Semester' From tahun_ajaran where status = 1 ORDER BY tahun_ajaran"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil tahun ajaran bermasalah! " + ex.ToString)
        End Try
    End Sub

    Function CekAkunKembar_TahunAjaran(ParamTahun1 As String, ParamTahun2 As String, paramSemester As String)
        Dim qs As String = "SELECT TAHUN, TAHUN2, SEMESTER FROM TAHUN_AJARAN WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim tahun1 As String = ""
            Dim tahun2 As String = ""
            Dim semester As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    tahun1 = DRX.Item("TAHUN")
                    tahun2 = DRX.Item("TAHUN2")
                    semester = DRX.Item("SEMESTER")
                    If tahun1 = ParamTahun1 And tahun2 = ParamTahun2 And semester = paramSemester Then
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

    Sub tambahKategori()
        Try
            Dim semester As String = ""
            If RadioButtonGasal.Checked Then
                semester = "Gasal"
            ElseIf RadioButtonGenap.Checked Then
                semester = "Genap"
            End If

            Dim cekThnAjaran As String = CekAkunKembar_TahunAjaran(TextBoxTahun.Text, TextBoxTahun2.Text, semester)
            If cekThnAjaran = "1" Then
                MsgBox("Tahun ajaran " + TextBoxTahun.Text + " / " + TextBoxTahun2.Text + " semester " + semester + " telah ada!")
                Exit Sub
            End If
            conn = Form1.koneksi()
            Dim qs As String = "insert into tahun_ajaran(tahun_ajaran,tahun,tahun2,semester,status) VALUES('" & TextBoxTahun.Text & " / " & TextBoxTahun2.Text & " - " & semester & "','" & TextBoxTahun.Text & "','" & TextBoxTahun2.Text & "','" & semester & "',1)"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Tambah tahun ajaran berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Tambah data tahun ajaran gagal dilakukan!")
        End Try
    End Sub

    Sub ubahKategori()
        Try
            Dim semester As String = ""
            If RadioButtonGasal.Checked Then
                semester = "gasal"
            ElseIf RadioButtonGenap.Checked Then
                semester = "genap"
            End If
            conn = Form1.koneksi()
            Dim qs As String = "update tahun_ajaran set tahun ='" & TextBoxTahun.Text & "',semester ='" & semester & "',STATUS=1 WHERE tahun_ajaran = '" & TextBoxTahunAjaran.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit data tahun_ajaran berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Edit data tahun_ajaran gagal dilakukan!")
        End Try
    End Sub

    Sub hapusKategori()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update tahun_ajaran set STATUS=0 WHERE tahun_ajaran = '" & TextBoxTahunAjaran.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus data tahun_ajaran berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Hapus data tahun_ajaran gagal dilakukan!")
        End Try
    End Sub

    Sub ClearData()
        TextBoxTahun.Text = ""
        TextBoxTahunAjaran.Text = ""
        TextBoxTahun2.Text = ""
        ButtonTambahUbah.Text = "Tambah"
    End Sub


    Private Sub Kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilKategori()
        formatTampilanGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahKategori()
                tampilKategori()
                ClearData()
                formatTampilanGrid()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data tahun ajaran " + TextBoxTahunAjaran.Text + "?", "Ubah Data Tahun Ajaran " + TextBoxTahunAjaran.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahKategori()
                        tampilKategori()
                        ClearData()
                        formatTampilanGrid()
                        ButtonTambahUbah.Text = "Tambah"
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data tahun ajaran " + TextBoxTahunAjaran.Text + "?", "Ubah Data Tahun Ajaran " + TextBoxTahunAjaran.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusKategori()
                tampilKategori()
                ClearData()
                formatTampilanGrid()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            TextBoxTahunAjaran.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxTahun.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearData()
    End Sub

    Private Sub TextBoxTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTahun.KeyPress
        Try
            Dim allowedChars As String = "0123456789.-,+"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTahun2.KeyPress
        Try
            Dim allowedChars As String = "0123456789.-,+"
            If allowedChars.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class