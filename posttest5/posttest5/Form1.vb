Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=supermarket_v2")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Sub TampilData()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            da = New MySqlDataAdapter("SELECT * FROM produk", conn)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM produk WHERE nama_produk LIKE @cari", conn)
            cmd.Parameters.AddWithValue("@cari", "%" & txtSearch.Text & "%")
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error pencarian: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Form2.Mode = "Tambah"
        Form2.ShowDialog()
        TampilData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Form2.Mode = "Edit"
            Form2.idProduk = DataGridView1.SelectedRows(0).Cells("id").Value
            Form2.txtNama.Text = DataGridView1.SelectedRows(0).Cells("nama_produk").Value.ToString()
            Form2.txtKategori.Text = DataGridView1.SelectedRows(0).Cells("kategori").Value.ToString()
            Form2.txtHarga.Text = DataGridView1.SelectedRows(0).Cells("harga").Value.ToString()
            Form2.txtStok.Text = DataGridView1.SelectedRows(0).Cells("stok").Value.ToString()
            Form2.ShowDialog()
            TampilData()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id = DataGridView1.SelectedRows(0).Cells("id").Value
            Try
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM produk WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus!")
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal hapus data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class
