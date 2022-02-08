Imports MySql.Data.MySqlClient
Public Class mapel
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("mapel")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahsatuan()
                tampilSatuan()
                clearData()
                formatTampilanGrid()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data mata pelajaran " + TextBoxMapel.Text + "?", "Ubah Data Mata Pelajaran " + TextBoxMapel.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahSatuan()
                        tampilSatuan()
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
            str = "select count(*) 'no' from mapel"
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

    Function CekAkunKembar_Mapel(paramMapel As String)
        Dim qs As String = "SELECT MAPEL FROM MAPEL WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim mapel As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    mapel = DRX.Item("MAPEL")
                    If mapel = paramMapel Then
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

    Sub tambahsatuan()
        Try
            Dim indeks As Integer = 0
            indeks = No()
            Dim cekMapel As String = CekAkunKembar_Mapel(TextBoxMapel.Text)
            If cekMapel = "1" Then
                MsgBox("Mapel " + TextBoxMapel.Text + " telah ada!")
                Exit Sub
            End If
            If TextBoxID.Text <> "" Then
                conn = Form1.koneksi()
                Dim qs As String = "insert into mapel(ID_MAPEL,MAPEL,STATUS) VALUES('" & indeks & "','" & TextBoxMapel.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah mapel berhasil dilakukan!")
            Else
                MsgBox("mapel belum diisi!")
            End If
        Catch ex As Exception
            MsgBox("Tambah data mapel gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub tampilSatuan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_mapel 'ID', mapel 'Mapel' From mapel where status = 1 ORDER BY id_mapel"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil mapel bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahSatuan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update mapel set MAPEL = '" & TextBoxMapel.Text & "' WHERE id_mapel = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit mapel berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Edit data mapel gagal dilakukan!")
        End Try
    End Sub

    Sub hapusSatuan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update mapel set STATUS=0 WHERE id_mapel = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus mapel berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Hapus data mapel gagal dilakukan!")
        End Try
    End Sub

    Private Sub satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilSatuan()
        formatTampilanGrid()
    End Sub

    Public id As String = ""
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxMapel.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data mata pelajaran " + TextBoxMapel.Text + "?", "Hapus Data Mata Pelajaran " + TextBoxMapel.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusSatuan()
                tampilSatuan()
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
        TextBoxMapel.Text = ""
        TextBoxID.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxMapel.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class