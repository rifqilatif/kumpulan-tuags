Public Class Form9

    Private Function Hitung()
        Dim b1, b2, hasil As Integer
        b1 = TextBox1.Text
        b2 = TextBox2.Text
        If RadioButton1.Checked = True Then
            b2 = Math.Sqrt(b1)
            'MsgBox("Akar kuadrat dari " & b1 & " adalah " & b2)
            TextBox3.Text = "Akar kuadrat dari " & b1 & " adalah " & b2
        ElseIf RadioButton2.Checked = True Then
            hasil = Math.Pow(b1, b2)
            TextBox3.Text = hasil
        ElseIf RadioButton3.Checked = True Then
            hasil = b1 / b2
            TextBox3.Text = hasil
        ElseIf RadioButton4.Checked = True Then
            hasil = b1 * b2
            TextBox3.Text = hasil
        ElseIf RadioButton5.Checked = True Then
            hasil = b1 - b2
            TextBox3.Text = hasil
        ElseIf RadioButton6.Checked = True Then
            hasil = b1 + b2
            TextBox3.Text = hasil
        End If
        Return hasil
    End Function
    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Call Hitung()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class