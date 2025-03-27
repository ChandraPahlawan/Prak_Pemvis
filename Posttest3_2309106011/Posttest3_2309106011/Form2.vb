Public Class Form2
    ' Menerima data dari Form1
    Public Sub New(nama As String, umur As String, tanggalLahir As String, noTelp As String, alamat As String, jenisKelamin As String, hobby As String, imagePath As String)
        ' Inisialisasi form
        InitializeComponent()

        ' Nampilin data di Form2
        Label8.Text = nama
        Label9.Text = umur
        Label10.Text = tanggalLahir
        Label11.Text = noTelp
        Label12.Text = alamat
        Label13.Text = jenisKelamin
        Label14.Text = hobby

        ' Nampilin gambar yang dikirim dari Form1
        LoadImage(PictureBox2, imagePath) ' Pakai modul untuk load gambar
    End Sub
End Class
