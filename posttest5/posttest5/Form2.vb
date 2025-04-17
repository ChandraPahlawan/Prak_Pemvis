Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=supermarket_v2")
    Public Mode As String = "Tambah"
    Public idProduk As Integer

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Mode = "Tambah" Then
            SimpanData()
        Else
            UpdateData()
        End If
        Me.Close()
    End Sub

    Sub SimpanData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO produk (nama_produk, kategori, harga, stok) VALUES (@nama, @kategori, @harga, @stok)", conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@kategori", txtKategori.Text)
            cmd.Parameters.AddWithValue("@harga", CDbl(txtHarga.Text))
            cmd.Parameters.AddWithValue("@stok", CInt(txtStok.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!")
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub UpdateData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE produk SET nama_produk=@nama, kategori=@kategori, harga=@harga, stok=@stok WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@id", idProduk)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@kategori", txtKategori.Text)
            cmd.Parameters.AddWithValue("@harga", CDbl(txtHarga.Text))
            cmd.Parameters.AddWithValue("@stok", CInt(txtStok.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbarui!")
        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
