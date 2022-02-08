Imports MySql.Data.MySqlClient
Public Class konf_user
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("kategori")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public usernameku As String = Form1.username

    Sub tampilPegawai()
        ds.Clear()
        Try
            Dim gender As String = ""
            conn = Form1.koneksi()
            Dim qs As String = "Select id_pegawai, no_induk, nama, gender, agama, alamat, telp, tgl_masuk From pegawai where no_induk = '" & usernameku & "'"
            da = New MySqlDataAdapter(qs, conn)
            da.Fill(ds, 0)
            dt = ds.Tables(0)
            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row.Field(Of Decimal)(1)) Then
                    TextBoxNoInduk.Text = row.Field(Of Decimal)(1)
                End If
                If Not IsDBNull(row.Field(Of String)(2)) Then
                    TextBoxNama.Text = row.Field(Of String)(2)
                End If
                If Not IsDBNull(row.Field(Of String)(3)) Then
                    gender = row.Field(Of String)(3)
                    If gender = "Laki-laki" Then
                        RadioButtonPria.Checked = True
                    ElseIf gender = "Perempuan" Then
                        RadioButtonWanita.Checked = True
                    End If
                End If
                If Not IsDBNull(row.Field(Of String)(4)) Then
                    TextBoxAgama.Text = row.Field(Of String)(4)
                End If
                If Not IsDBNull(row.Field(Of String)(5)) Then
                    TextBoxAlamat.Text = row.Field(Of String)(5)
                End If
                If Not IsDBNull(row.Field(Of String)(6)) Then
                    TextBoxTelp.Text = row.Field(Of String)(6)
                End If
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox("Tampilan pegawai bermasalah! " + ex.ToString)
        End Try
    End Sub

    Sub ubahPegawai()
        If TextBoxPass.Text = TextBoxRePass.Text Then
            Try
                Dim passwordMD5 As String = Form1.getMD5Hash(TextBoxPass.Text)
                conn = Form1.koneksi()
                Dim qs As String = "update pegawai set PASSWORD ='" & passwordMD5 & "' WHERE NO_INDUK = '" & usernameku & "'"
                cmd = New MySqlCommand(qs, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Password berhasil diganti!")
            Catch ex As Exception
                MsgBox("Password gagal diganti!")
            End Try
        Else
            MsgBox("Password dan re-Password tidak sama!")
        End If
    End Sub

    Private Sub konf_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilPegawai()
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            If ButtonSimpan.Text = "Simpan" Then
                Dim result As Integer = MessageBox.Show("Anda yakin hendak mengubah password akun " + TextBoxNama.Text + "?", "Konfigurasi Pengguna", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("Dibatalkan!")
                ElseIf result = DialogResult.Yes Then
                    ubahPegawai()
                    TextBoxPass.Enabled = False
                    TextBoxPass.Text = ""
                    TextBoxRePass.Enabled = False
                    TextBoxRePass.Text = ""
                    ButtonSimpan.Text = "Ubah"
                    TextBoxPass.Enabled = False
                    TextBoxRePass.Enabled = False
                End If
            Else
                ButtonSimpan.Text = "Simpan"
                TextBoxPass.Enabled = True
                TextBoxRePass.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class