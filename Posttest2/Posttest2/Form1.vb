Module ModuleBuku
    Public daftarBuku(100) As String
    Public jumlahBuku As Integer = 0

    Public Function CariIndeksBuku(judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).StartsWith(judul & " (") Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module

Public Class Form1
    Private Sub TambahBuku(ByRef daftar() As String, ByRef jumlah As Integer, judul As String, genre As String)
        If judul <> "" And genre <> "" Then
            daftar(jumlah) = judul & " (" & genre & ")"
            jumlah += 1
            TampilkanBuku()
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MessageBox.Show("Judul dan Genre nda boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub HapusBuku(ByRef daftar() As String, ByRef jumlah As Integer, judul As String)
        Dim indeks As Integer = CariIndeksBuku(judul)
        If indeks <> -1 Then
            For i As Integer = indeks To jumlah - 2
                daftar(i) = daftar(i + 1)
            Next
            daftar(jumlah - 1) = Nothing
            jumlah -= 1
            TampilkanBuku()
            TextBox3.Clear()
        Else
            MessageBox.Show("Buku tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TampilkanBuku()
        ListBox1.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            ListBox1.Items.Add(daftarBuku(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TambahBuku(daftarBuku, jumlahBuku, TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HapusBuku(daftarBuku, jumlahBuku, TextBox3.Text)
    End Sub
End Class
