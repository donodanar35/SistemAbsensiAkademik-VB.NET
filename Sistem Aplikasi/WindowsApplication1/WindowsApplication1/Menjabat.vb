Imports MySql.Data.MySqlClient

Public Class Menjabat

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("jabatan")
    Public ds As New DataSet
    Public DR As MySqlDataReader

    Function No()
        Dim temp As Integer
        Try
            conn = Form1.koneksi()
            Dim str As String
            str = "select count(*) 'no' from detail_jabatan"
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
        TextBoxID.Text = temp
        Return temp
    End Function

    Sub tampilMasterPegawai()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_pegawai, nama From pegawai WHERE STATUS = 1 AND nama like '%" & TextBoxCari.Text & "%'"
            Dim dax As New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("pegawai")
            dax.Fill(dt)

            ComboBoxPegawai.DataSource = dt
            ComboBoxPegawai.DisplayMember = "nama"
            ComboBoxPegawai.ValueMember = "id_pegawai"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan pegawai bermasalah! ")
        End Try
    End Sub

    Sub tampilMasterJabatan()
        ds.Clear()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "Select id_jabatan, jabatan From jabatan WHERE STATUS = 1"
            da = New MySqlDataAdapter(qs, conn)
            Dim dt As New DataTable("jabatan")
            da.Fill(dt)

            ComboBoxJabatan.DataSource = dt
            ComboBoxJabatan.DisplayMember = "jabatan"
            ComboBoxJabatan.ValueMember = "id_jabatan"
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan jabatan bermasalah! ")
        End Try
    End Sub

    Function CekKepsek()
        Dim qs As String = "SELECT P.NAMA 'NAMA' FROM PEGAWAI P, DETAIL_JABATAN D, JABATAN J WHERE P.ID_PEGAWAI = D.ID_PEGAWAI AND D.ID_JABATAN = J.ID_JABATAN AND D.STATUS = 1 AND J.JABATAN ='kepsek'"
        Dim temp As String = "0"
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            If DRX.HasRows Then
                While DRX.Read()
                    temp = DRX.Item("NAMA")
                    Exit While
                End While
            Else
                temp = "0"
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Cek kepsek bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTambahUbah.Click
        Try
            'Dim cek_Kepsek As String = CekKepsek()
            If ButtonTambahUbah.Text = "Tambah" Then
                tambahJabatan()
                tampilJabatan()
                clearData()
                formatTampilanGrid()
                No()
            ElseIf ButtonTambahUbah.Text = "Ubah" Then
                Try
                    Dim result As Integer = MessageBox.Show("Anda yakin mengubah data menjabat " + TextBoxID.Text + "?", "Ubah Data Menjabat " + TextBoxID.Text, MessageBoxButtons.YesNoCancel)
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

    Sub tambahJabatan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "insert into detail_jabatan(ID_MENJABAT, ID_JABATAN, ID_PEGAWAI, AWAL_BAKTI, AKHIR_BAKTI,STATUS) VALUES('" & TextBoxID.Text & "','" & ComboBoxJabatan.SelectedValue.ToString & "','" & ComboBoxPegawai.SelectedValue.ToString & "','" & Format(DateTimePicker1Awal.Value, "yyyy-MM-dd") & "','" & Format(DateTimePickerAkhir.Value, "yyyy-MM-dd") & "',1)"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Tambah data pegawai menjabat berhasil dilakukan!")
        Catch ex As Exception
            MsgBox("Tambah data pegawai menjabat gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub tampilJabatan()
        DataGridView1.DataSource = Nothing
        ds.Clear()
        Try
            Dim qs As String = "Select d.status 'status', d.id_menjabat, d.id_pegawai 'id_pegawai', d.id_jabatan 'id_jabatan', p.nama 'nama', j.jabatan 'jabatan', d.awal_bakti 'awal_bakti', d.akhir_bakti 'akhir_bakti' From jabatan j, pegawai p, detail_jabatan d where d.status >= 1 AND p.id_pegawai = d.id_pegawai AND d.id_jabatan = j.id_jabatan ORDER BY p.nama"
            Dim ID As String = ""
            Dim IDJ As String = ""
            Dim IDP As String = ""
            Dim Jabatan As String = ""
            Dim Pegawai As String = ""
            Dim AwalBakti As String = ""
            Dim AkhirBakti As String = ""
            Dim status As Decimal = 0

            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            If DRX.HasRows Then
                While DRX.Read()
                    ID = DRX.Item("id_menjabat")
                    IDJ = DRX.Item("id_jabatan")
                    IDP = DRX.Item("id_pegawai")
                    Pegawai = DRX.Item("nama")
                    Jabatan = DRX.Item("jabatan")
                    AwalBakti = DRX.Item("awal_bakti")
                    AkhirBakti = DRX.Item("akhir_bakti")
                    status = DRX.Item("status")
                    If status = 1 Then
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, IDJ, IDP, Jabatan, Pegawai, AwalBakti, AkhirBakti, ID, "aktif")
                    ElseIf status = 2 Then
                        DataGridView1.Rows.Insert(DataGridView1.NewRowIndex, IDJ, IDP, Jabatan, Pegawai, AwalBakti, AkhirBakti, ID, "kadaluarsa")
                    End If
                End While
            Else
                MsgBox("Data tidak tersedia!")
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampil jabatan bermasalah! " + ex.ToString)
        End Try

    End Sub

    Sub ubahJabatan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update detail_jabatan set id_jabatan = '" & ComboBoxJabatan.SelectedValue.ToString & "', id_pegawai ='" & ComboBoxPegawai.SelectedValue.ToString & "', awal_bakti ='" & Format(DateTimePicker1Awal.Value, "yyyy-MM-dd") & "', akhir_bakti ='" & Format(DateTimePickerAkhir.Value, "yyyy-MM-dd") & "' WHERE id_menjabat = '" & TextBoxID.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Edit jabatan berhasil dilakukan!")
            idj = ""
            idp = ""
        Catch ex As Exception
            MsgBox("Edit data jabatan gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Sub PerbaruiStatusJabatan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update detail_jabatan set STATUS=2 WHERE AKHIR_BAKTI <'" & Format(Today, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Pembaruan status jabatan berhasil dilakukan!")
            idj = ""
            idp = ""
        Catch ex As Exception
            MsgBox("Pembaruan status jabatan gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Function CekKadaluarsa_MasaJabatan(ParamTgl As Date)
        Dim qs As String = "SELECT AKHIR_BAKTI FROM DETAIL_JABATAN WHERE STATUS = 1"
        Dim temp As String = ""
        Try
            conn = Form1.koneksi()
            Dim cmd = New MySqlCommand(qs, conn)
            Dim DRX As MySqlDataReader
            DRX = cmd.ExecuteReader
            Dim tgl As Date
            If DRX.HasRows Then
                While DRX.Read()
                    tgl = DRX.Item("AKHIR_BAKTI")
                    Dim STgl As String = Format(tgl, "yyyy-MM-dd")
                    Dim SParamTgl As String = Format(ParamTgl, "yyyy-MM-dd")
                    If SParamTgl > STgl Then
                        temp = "1"
                        Exit While
                    End If
                End While
            End If
            DRX.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("notifikasi masa jabatan bermasalah! " + ex.ToString)
        End Try
        Return temp
    End Function

    Sub hapusJabatan()
        Try
            conn = Form1.koneksi()
            Dim qs As String = "update detail_jabatan set STATUS=0 WHERE id_menjabat ='" & TextBoxID.Text & "'"
            cmd = New MySqlCommand(qs, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Hapus jabatan berhasil dilakukan!")
            idj = ""
            idp = ""
        Catch ex As Exception
            MsgBox("Hapus data jabatan gagal dilakukan! " + ex.ToString)
        End Try
    End Sub

    Private Sub satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cekMasaJabatan As String = CekKadaluarsa_MasaJabatan(Today)
        If cekMasaJabatan = "1" Then
            Try
                Dim result As Integer = MessageBox.Show("Anda mempunyai akun data menjabat yang kadalursa, perbarui sekarang?", "Perbarui Status AKun Data Menjabat yang Kadaluarsa ", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.Yes Then
                    PerbaruiStatusJabatan()
                    tampilJabatan()
                    clearData()
                    formatTampilanGrid()
                End If
            Catch ex As Exception
            End Try
        End If
        No()
        tampilMasterJabatan()
        tampilMasterPegawai()
        tampilJabatan()
        formatTampilanGrid()
    End Sub

    Public idj As String = ""
    Public idp As String = ""

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin menghapus data menjabat " + TextBoxID.Text + "?", "Hapus Data Menjabat " + TextBoxID.Text, MessageBoxButtons.YesNoCancel)
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
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.White
                DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.White
            Else
                DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(1).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(2).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(3).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(4).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(6).Style.BackColor = Color.GreenYellow
                DataGridView1.Rows(i).Cells(7).Style.BackColor = Color.GreenYellow
            End If
        Next
    End Sub

    Sub clearData()
        DateTimePicker1Awal.Text = Today
        DateTimePickerAkhir.Text = Today
        TextBoxCari.Text = ""
        ButtonTambahUbah.Text = "Tambah"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearData()
        No()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tampilMasterPegawai()
    End Sub

    Dim idx As String = ""

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            'idj = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            'idp = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            idx = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            TextBoxID.Text = idx
            DateTimePicker1Awal.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString, "yyyy-MM-dd")
            DateTimePickerAkhir.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString, "yyyy-MM-dd")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ButtonTambahUbah.Text = "Ubah"
            'idj = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            'idp = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            idx = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            TextBoxID.Text = idx
            DateTimePicker1Awal.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString, "yyyy-MM-dd")
            DateTimePickerAkhir.Text = Format(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString, "yyyy-MM-dd")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim result As Integer = MessageBox.Show("Anda yakin hendak memperbarui status seluruh akun data menjabat yang kadalursa?", "Perbarui Status Seluruh AKun Data Menjabat yang Kadaluarsa ", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
            ElseIf result = DialogResult.No Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.Yes Then
                PerbaruiStatusJabatan()
                tampilJabatan()
                clearData()
                formatTampilanGrid()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class