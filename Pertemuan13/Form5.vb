Public Class Form5

    Private Function IsPrime(ByVal number As Integer) As Boolean
        If number <= 1 Then
            Return False
        End If

        If number Mod 2 = 0 Then
            Return number = 2
        End If

        Dim boundary As Integer = CInt(Math.Floor(Math.Sqrt(number)))

        For i As Integer = 3 To boundary Step 2
            If number Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim maksimal As Integer
        maksimal = TextBox1.Text
        For i = 1 To maksimal
            ListBox1.Items.Add(i)
            i = i + 1
        Next i
    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim maksimal As Integer
        maksimal = TextBox1.Text
        For i = 2 To maksimal
            ListBox1.Items.Add(i)
            i = i + 1
        Next i
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub

    ' Fungsi baru untuk tombol bilangan prima
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim i, maksimal As Integer
        maksimal = TextBox1.Text
        For i = 2 To maksimal
            If IsPrime(i) Then
                ListBox1.Items.Add(i)
            End If
        Next i
    End Sub
End Class