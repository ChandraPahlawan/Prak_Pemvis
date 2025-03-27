Module ModuleHelper
    ' Memastikan input tidak kosong
    Public Function IsInputEmpty(ParamArray inputs() As String) As Boolean
        For Each input As String In inputs
            If String.IsNullOrWhiteSpace(input) Then
                Return True
            End If
        Next
        Return False
    End Function

    ' Memastikan hanya angka yang bisa diinput
    Public Function IsNumericInput(e As KeyPressEventArgs) As Boolean
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return False
        End If
        Return True
    End Function

    ' Memastikan hanya huruf yang bisa diinput
    Public Function IsLetterInput(e As KeyPressEventArgs) As Boolean
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            Return False
        End If
        Return True
    End Function

    ' Menampilkan gambar di PictureBox
    Public Sub LoadImage(pictureBox As PictureBox, imagePath As String)
        If System.IO.File.Exists(imagePath) Then
            pictureBox.Image = Image.FromFile(imagePath)
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage ' Agar gambar tidak terpotong
        End If
    End Sub
End Module
