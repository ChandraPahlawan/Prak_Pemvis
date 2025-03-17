Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim ipSemester As Double

        ' Validasi input angka dan batas maksimum IP Semester = 5
        If Double.TryParse(tbips.Text, ipSemester) Then
            If ipSemester > 5 Then
                MessageBox.Show("IP Semester tidak boleh lebih dari 5!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbips.Clear()
                tbips.Focus()
                Return
            End If

            totalIP += ipSemester
            jumlahSemester += 1

            ' Hitung IP Kumulatif
            Dim ipk As Double = totalIP / jumlahSemester

            ' Batasi IPK maksimal 4.0
            If ipk > 4 Then
                ipk = 4
            End If

            tbipk.Text = ipk.ToString("0.00")

            ' Tentukan Predikat
            If ipk >= 3.01 Then
                LabelPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                LabelPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                LabelPredikat.Text = "Cukup"
            Else
                LabelPredikat.Text = "Kurang"
            End If

            ' Kosongkan input
            tbips.Clear()
            tbips.Focus()
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        totalIP = 0
        jumlahSemester = 0
        tbipk.Clear()
        LabelPredikat.Text = ""
        tbips.Clear()
        tbips.Focus()
    End Sub
End Class
