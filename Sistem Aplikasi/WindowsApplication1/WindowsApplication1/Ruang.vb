Imports MySql.Data.MySqlClient

Public Class Ruang
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("ruang")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahruang()
                tampilRuang()
                clearData()
                formatTampilanGrid()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data ruang " + TextBoxRuang.Text + "?", "Ubah Data Ruang " + TextBoxRuang.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahRuang()
                        tampilRuang()
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
            str = "select count(*) 'no' from ruang"
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

    Function CekAkunKembar_Ruang(paramRuang As String)
        Dim qs As String = "SELECT RUANG FROM RUANG WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim ruang As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    ruang = DRX.Item("RUANG")
                    If ruang = paramRuang Then
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

    Sub tambahruang()
        Try
            Dim indeks As Integer = 0
            indeks = No()
            Dim cekRuang As String = CekAkunKembar_Ruang(TextBoxRuang.Text)
            If cekRuang = "1" Then
                MsgBox("Ruang " + TextBoxRuang.Text + " telah ada!")
                Exit Sub
            End If
            If TextBoxID.Text <> "" Then
                conn = Form1.koneksi()
                Dim qs As String = "insert into ruang(ID_RUANG, RUANG, STATUS) VALUES('" & TextBoxID.Text & "','" & TextBoxRuang.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah ruang berhasil dilakukan!")
            Else
                MsgBox("ruang belum diisi!")
            End If
        Catch ex As Exception
            MsgBox("Tambah data ruang gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub tampilRuang()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_ruang 'ID Ruang', ruang 'Ruang' From ruang where status = 1 ORDER BY id_ruang"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil ruang bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahRuang()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update ruang set Ruang = '" & TextBoxRuang.Text & "' WHERE id_ruang = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit ruang berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Edit data ruang gagal dilakukan!")
        End Try
    End Sub

    Sub hapusRombel()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update ruang set STATUS=0 WHERE id_ruang = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus ruang berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Hapus data ruang gagal dilakukan!")
        End Try
    End Sub

    Private Sub satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilRuang()
        formatTampilanGrid()
    End Sub

    Public id As String = ""
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxRuang.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data ruang " + TextBoxRuang.Text + "?", "Hapus Data Ruang " + TextBoxRuang.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusRombel()
                tampilRuang()
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
        TextBoxRuang.Text = ""
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
            TextBoxRuang.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class