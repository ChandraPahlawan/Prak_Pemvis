<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(310, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(310, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 1
        Label2.Text = "umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(310, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 2
        Label3.Text = "tanggal lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(310, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 3
        Label4.Text = "No Telp"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(310, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 4
        Label5.Text = "Alamat"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(432, 134)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(216, 27)
        DateTimePicker1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(432, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(432, 92)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(216, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(432, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(216, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(432, 207)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(216, 27)
        TextBox4.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(211, 253)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(182, 118)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 56)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(76, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Wanita"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(55, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pria"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox10)
        GroupBox2.Controls.Add(CheckBox9)
        GroupBox2.Controls.Add(CheckBox8)
        GroupBox2.Controls.Add(CheckBox7)
        GroupBox2.Controls.Add(CheckBox6)
        GroupBox2.Controls.Add(CheckBox5)
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(481, 249)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(294, 176)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(160, 152)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(72, 24)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Teater"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(160, 128)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(104, 24)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "badminton"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(160, 98)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(67, 24)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "futsal"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(160, 64)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(97, 24)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Buzzer sty"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(160, 34)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(133, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Ngolok Arsenal"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(16, 151)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(125, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Dukung EMYU"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(16, 121)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(65, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Salto"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(16, 91)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "mangan"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(16, 61)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(75, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Guring"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(16, 34)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(88, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Mancing"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(34, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(166, 169)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(43, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 28)
        Button1.TabIndex = 13
        Button1.Text = "Pilih Foto"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(294, 397)
        Button2.Name = "Button2"
        Button2.Size = New Size(157, 28)
        Button2.TabIndex = 14
        Button2.Text = "cetak"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox

End Class
