Public Class Form1

    ' nyimpan path gambar yang dipilih
    Private selectedImagePath As String = ""

    ' Tombol milih gambar
    Private Sub btnPilihFoto_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            selectedImagePath = ofd.FileName
            LoadImage(PictureBox1, selectedImagePath) ' Pakai modul untuk load gambar
        End If
    End Sub

    ' inputan Nama hanya huruf
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        IsLetterInput(e) ' Pakai modul validasi huruf
    End Sub

    ' inputan Umur hanya angka
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        IsNumericInput(e) ' Pakai modul validasi angka
    End Sub

    ' inputan Nomor Telepon hanya angka
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        IsNumericInput(e) ' Pakai modul validasi angka
    End Sub

    ' Tombol ngirim data ke Form2
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Validasi input tidak boleh kosong
        If IsInputEmpty(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tanggal lahir tidak boleh melebihi hari ini
        If DateTimePicker1.Value.Date > DateTime.Now.Date Then
            MessageBox.Show("Tanggal lahir tidak boleh melebihi hari ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Pastikan RadioButton dipilih
        If Not (RadioButton1.Checked Or RadioButton2.Checked) Then
            MessageBox.Show("Silakan pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Minimal satu hobi dipilih
        Dim hobbyList As New List(Of String)
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    hobbyList.Add(chk.Text)
                End If
            End If
        Next

        If hobbyList.Count = 0 Then
            MessageBox.Show("Silakan pilih minimal satu hobi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil semua nilai inputan yang valid
        Dim nama As String = TextBox1.Text
        Dim umur As String = TextBox2.Text
        Dim tanggalLahir As String = DateTimePicker1.Value.ToString("dddd, dd MMMM yyyy")
        Dim noTelp As String = TextBox3.Text
        Dim alamat As String = TextBox4.Text
        Dim jenisKelamin As String = If(RadioButton1.Checked, "Pria", "Wanita")
        Dim hobby As String = String.Join(", ", hobbyList)

        ' Buka Form2 dan mengirimkan data
        Dim formKartu As New Form2(nama, umur, tanggalLahir, noTelp, alamat, jenisKelamin, hobby, selectedImagePath)
        formKartu.Show()
    End Sub
End Class
