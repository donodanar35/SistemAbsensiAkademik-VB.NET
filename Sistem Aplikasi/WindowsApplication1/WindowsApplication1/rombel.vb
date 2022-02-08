Imports MySql.Data.MySqlClient

Public Class rombel

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("satuan")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahrombel()
                tampilRombel()
                clearData()
                formatTampilanGrid()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data rombel " + TextBoxRombel.Text + "?", "Ubah Data Rombel " + TextBoxRombel.Text, MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        MessageBox.Show("Dibatalkan!")
                    ElseIf result = DialogResult.Yes Then
                        ubahRombel()
                        tampilRombel()
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
            str = "select count(*) 'no' from rombel"
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

    Function CekAkunKembar_Rombel(paramRombel As String)
        Dim qs As String = "SELECT ROMBEL FROM ROMBEL WHERE STATUS = 1"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim rombel As String = ""
            If DRX.HasRows Then
                While DRX.Read()
                    rombel = DRX.Item("ROMBEL")
                    If rombel = paramRombel Then
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
            MsgBox("Cek rombel bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub tambahrombel()
        Try
            Dim indeks As Integer = 0
            indeks = No()
            Dim cekRombel As String = CekAkunKembar_Rombel(TextBoxRombel.Text)
            If cekRombel = "1" Then
                MsgBox("Rombel " + TextBoxRombel.Text + " telah ada!")
                Exit Sub
            End If
            If TextBoxID.Text <> "" Then
                conn = Form1.koneksi()
                Dim qs As String = "insert into rombel(ID_ROMBEL, ROMBEL, STATUS) VALUES('" & TextBoxID.Text & "','" & TextBoxRombel.Text & "',1)"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Tambah rombel berhasil dilakukan!")
            Else
                MsgBox("rombel belum diisi!")
            End If
        Catch ex As Exception
            MsgBox("Tambah data rombel gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub tampilRombel()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_rombel 'Rombel', rombel 'Rombel' From rombel where status = 1 ORDER BY id_rombel"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil rombel bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahRombel()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update rombel set Rombel = '" & TextBoxRombel.Text & "' WHERE id_rombel = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit rombel berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Edit data rombel gagal dilakukan!")
        End Try
    End Sub

    Sub hapusRombel()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update rombel set STATUS=0 WHERE id_rombel = '" & id & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus rombel berhasil dilakukan!")
            id = ""
        Catch ex As Exception
            MsgBox("Hapus data rombel gagal dilakukan!")
        End Try
    End Sub

    Private Sub satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilRombel()
        formatTampilanGrid()
    End Sub

    Public id As String = ""
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            TextBoxRombel.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data rombel " + TextBoxRombel.Text + "?", "Hapus Data Ruang " + TextBoxRombel.Text, MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                hapusRombel()
                tampilRombel()
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
        TextBoxRombel.Text = ""
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
            TextBoxRombel.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        Catch ex As Exception
        End Try
    End Sub
End Class