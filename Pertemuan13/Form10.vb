Imports System.Text

Public Class Form10

    Function factorial(ByVal n As Integer) As Integer
        If n = 1 Then
            factorial = 1
        Else
            factorial = n * factorial(n - 1)
        End If
    End Function

    Function GetFactorialSeries(ByVal n As Integer) As String
        'Buat String yang akan menampung daftar
        Dim series As New StringBuilder()
        ' mulai dengan menggabungkan angka yang ingin anda hitung dengan format "!# ="
        series.Append(" ! ")
        series.Append(n)
        series.Append(" = ")
        ' melakukan iterasi mundur
        For i = n To 1 Step -1
            ' dan menambahkan ke daftar
            series.Append(i)
            If i > 1 Then
                series.Append(" * ")
            Else
                series.Append(" = ")
            End If
            series.Append(factorial(i))
        Next
        ' Dapatkan hasil dari Metode Faktorial dan menambahkan ke akhir daftar
        series.Append(factorial(n))
        Return series.ToString()
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Integer.Parse(TextBox1.Text)
        Label1.Text = GetFactorialSeries(n)
        Console.WriteLine(GetFactorialSeries(n))
    End Sub
End Class