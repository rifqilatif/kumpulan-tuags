Public Class Form6

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim NilaiAbs As Byte
        Dim NilaiTugas As Byte
        Dim NilaiUTS As Byte
        Dim NilaiUAS As Byte
        Dim NilaiAkhir As Byte

        NilaiAbs = TextBox1.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        TextBox2.Text = NilaiAbs

        NilaiTugas = TextBox4.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        TextBox3.Text = NilaiTugas

        NilaiUTS = TextBox6.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        TextBox5.Text = NilaiUTS

        NilaiUAS = TextBox8.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        TextBox7.Text = NilaiUAS

        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        TextBox9.Text = NilaiAkhir
    End Sub
End Class