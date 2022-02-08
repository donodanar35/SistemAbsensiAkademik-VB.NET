Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Text
Imports System.Xml

Public Class Form1
    Public conn As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DR As MySqlDataReader
    Public cmd As MySqlCommand
    Public DS As DataSet
    Public Tabel As DataTable
    Public isConnected As Integer
    Public username As String
    Public id_pegawai As String
    Public jabatan As String
    Public password As String
    Public nama As String
    Public Function getKoneksiKonfigurasi()
        Dim result As String = ""
        Try
            Dim xmlFile As XmlReader
            xmlFile = XmlReader.Create(Application.StartupPath + "/xml/koneksi.xml", New XmlReaderSettings())
            Dim ds As New DataSet
            Dim dv As DataView
            ds.ReadXml(xmlFile)

            Dim dt As DataTable = ds.Tables("koneksi")
            dv = New DataView(ds.Tables("koneksi"))
            result = dv(0)("server").ToString
            result = result + "-" + dv(0)("database").ToString
            result = result + "-" + dv(0)("username").ToString
            result = result + "-" + dv(0)("password").ToString
            xmlFile.Close()
        Catch ex As Exception
            MsgBox("Tampilan koneksi bermasalah!" + ex.ToString)
        End Try
        Return result
    End Function

    Public Function koneksi()
        Try
            Dim str As String
            Dim result As String
            Dim arrResult() As String
            result = getKoneksiKonfigurasi()
            arrResult = result.Split("-")
            str = "Server=" + arrResult(0) + "; user id=" + arrResult(2) + "; password=" + arrResult(3) + "; database=" + arrResult(1)
            'MsgBox(str)
            conn = New MySqlConnection(str)
            conn.Open()
            isConnected = 1
            'MsgBox("koneksi berhasil!")
        Catch ex As Exception
            MsgBox("koneksi gagal! " + ex.ToString)
            isConnected = 0
        End Try
        Return conn
    End Function

    Public Sub login()
        Try
            koneksi()
            Dim str As String
            str = "SELECT nama, id_pegawai, no_induk, password FROM pegawai WHERE no_induk like '" & TextBox1.Text & "'"
            Dim cmd = New MySqlCommand(str, conn)
            DR = cmd.ExecuteReader

            If DR.HasRows Then
                While DR.Read()
                    nama = DR.Item("nama")
                    id_pegawai = DR.Item("id_pegawai")
                    username = DR.Item("no_induk")
                    password = DR.Item("password")
                End While
            End If
            'MsgBox("password: " + password)
            DR.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(" gagal dilakukan")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Harap isi username dan password!")
        Else
            login()
            Dim passwordToMD5 As String = ""
            passwordToMD5 = getMD5Hash(TextBox2.Text)
            'MsgBox("passwordMD5: " + passwordToMD5)
            'MsgBox("password: " + password)
            If TextBox1.Text = username And passwordToMD5 = password Then
                MsgBox("Login berhasil!")
                Dim home As New home
                home.ShowDialog()
            Else
                MsgBox("Username atau password salah!")
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        End If
    End Sub

    Public Shared Function getMD5Hash(ByVal password As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim byteToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(password)
        byteToHash = md5Obj.ComputeHash(byteToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In byteToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

End Class

