Public Class Form11

    Dim q As Queue = New Queue()
    Dim nomorUrut As Integer = 1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim n As String
        n = TextBox1.Text
        Console.WriteLine("Masuk Antrian : " + n)
        q.Enqueue(n)

        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = q.Count
        Console.WriteLine("Jumlah Antrian: " + jumAntrian.ToString)
        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Console.WriteLine("Belum Ada Antrian")
        Else
            ch = q.Dequeue()
            Label2.Text = ch
            Console.WriteLine("Keluar Antrian:" + ch)
        End If

        If jumAntrian = 0 Then
            Label3.Text = "antrian habis"
        Else
            Label3.Text = "Antrian ke: " & nomorUrut
            nomorUrut += 1
            Console.WriteLine("antrian habis")
        End If
    End Sub
End Class