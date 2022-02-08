Imports MySql.Data.MySqlClient

Public Class jabatan
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("jabatan")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahJabatan()
                tampilJabatan()
                clearData()
                formatTampilanGrid()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data jabatan " + TextBoxID.Text + "?", "Ubah Data Jabatan " + TextBoxID.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahJabatan()
                        tampilJabatan()
                        clearData()
                        formatTampilanGrid()
                        ButtonTambahUbah.Text = "Tambah"
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from jabatan"
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
        TextBoxID.Text = temp
        Return temp
    End Function

    Sub tambahJabatan()
        Try
            Dim indeks As Integer = 0
            indeks = No()
            Dim jabatan As String = ""
            If RadioButtonKepsek.Checked Then
                jabatan = "kepsek"
            ElseIf RadioButtonwakasek.Checked Then
                jabatan = "wakasek"
            ElseIf RadioButtonTU.Checked Then
                jabatan = "TU"
            ElseIf RadioButtonLainnya.Checked Then
                jabatan = TextBoxJabatan.Text
            End If
            Dim cekJabatan As String = CekAkunKembar_Jabatan(jabatan)
            If cekJabatan = "1" Then
                MsgBox("Jabatan " + jabatan + " telah ada!")
                Exit Sub
            End If
            If TextBoxID.Text <> "" Then
                conn = Form1.koneksi()
                Dim qs As String = "insert into jabatan(ID_JABATAN, JABATAN, STATUS) VALUES('" & TextBoxID.Text & "','" & jabatan & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah jabatan berhasil dilakukan!")
            Else
                MsgBox("jabatan belum diisi!")
            End If
        Catch ex As Exception
            MsgBox("Tambah data jabatan gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub tampilJabatan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_jabatan 'ID Jabatan', jabatan 'Jabatan' From jabatan where status = 1 ORDER BY id_jabatan"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil jabatan bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahJabatan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update jabatan set Jabatan = '" & TextBoxJabatan.Text & "' WHERE id_jabatan = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit jabatan berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Edit data jabatan gagal dilakukan!")
        End Try
    End Sub

    Sub hapusJabatan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update jabatan set STATUS=0 WHERE id_jabatan = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus jabatan berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Hapus data jabatan gagal dilakukan!")
        End Try
    End Sub

    Function CekAkunKembar_Jabatan(paramJabatan As String)
        Dim qs As String = "SELECT JABATAN FROM JABATAN WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim jabatan As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    jabatan = DRX.Item("JABATAN")
                    If jabatan = paramJabatan Then
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
            MsgBox("Cek jabatan bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilJabatan()
        formatTampilanGrid()
    End Sub

    Public id As String = ""
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxJabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data jabatan " + TextBoxID.Text + "?", "Hapus Data Jabatan " + TextBoxID.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusJabatan()
                tampilJabatan()
                clearData()
                formatTampilanGrid()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub formatTampilanGrid()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Sub clearData()
        TextBoxID.Text = ""
        TextBoxJabatan.Text = ""
        ButtonTambahUbah.Text = "Tambah"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxJabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class