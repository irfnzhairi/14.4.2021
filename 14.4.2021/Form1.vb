Public Class Form1
    Private Sub lblNamaHari_Click(sender As Object, e As EventArgs) Handles lblNamaHari.Click
        Dim strNamaHari(6) As String

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"

        lblNamaHari.Text = strNamaHari(1)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strNamaHari() As String = {"Ahad", "Isnin", "Selasa", "Rabu", "Khamis", "Jumaat", "Sabtu"}

        Dim i As Integer

        Array.Reverse(strNamaHari)
        For i = 0 To 6
            lstbox.Items.Add(strNamaHari(i))
        Next
    End Sub

End Class
