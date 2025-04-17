<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtID = New TextBox()
        txtNama = New TextBox()
        txtKategori = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        btnSimpan = New Button()
        lblID = New Label()
        lblNama = New Label()
        lblKategori = New Label()
        lblHarga = New Label()
        lblStok = New Label()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(100, 20)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(200, 27)
        txtID.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(100, 50)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(200, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtKategori
        ' 
        txtKategori.Location = New Point(100, 80)
        txtKategori.Name = "txtKategori"
        txtKategori.Size = New Size(200, 27)
        txtKategori.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(100, 110)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(200, 27)
        txtHarga.TabIndex = 3
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(100, 140)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(200, 27)
        txtStok.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(100, 180)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(100, 30)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(20, 23)
        lblID.Name = "lblID"
        lblID.Size = New Size(27, 20)
        lblID.TabIndex = 6
        lblID.Text = "ID:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(20, 53)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(52, 20)
        lblNama.TabIndex = 7
        lblNama.Text = "Nama:"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(20, 83)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(69, 20)
        lblKategori.TabIndex = 8
        lblKategori.Text = "Kategori:"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(20, 113)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(53, 20)
        lblHarga.TabIndex = 9
        lblHarga.Text = "Harga:"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(20, 143)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(41, 20)
        lblStok.TabIndex = 10
        lblStok.Text = "Stok:"
        ' 
        ' Form2
        ' 
        ClientSize = New Size(413, 231)
        Controls.Add(lblStok)
        Controls.Add(lblHarga)
        Controls.Add(lblKategori)
        Controls.Add(lblNama)
        Controls.Add(lblID)
        Controls.Add(btnSimpan)
        Controls.Add(txtStok)
        Controls.Add(txtHarga)
        Controls.Add(txtKategori)
        Controls.Add(txtNama)
        Controls.Add(txtID)
        Name = "Form2"
        Text = "Form Produk"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblStok As Label
End Class
