Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        'Input Harga dan Jumlah
        harga = TextBox2.Text
        jumlah = TextBox3.Text
        'Perhitungan Total Harga
        total = harga * jumlah
        'Penentuan diskon
        diskon = 0.05 * total
        'Perhitungan total Bayar
        bayar = total - diskon
        'Set keluaran total Harga, diskon,total bayar, dan bonus
        TextBox4.Text = total
        TextBox5.Text = diskon
        TextBox6.Text = bayar
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub
End Class