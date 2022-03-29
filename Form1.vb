Public Class Form1
    Dim prvi As Double
    Dim drugi As Double
    Private Sub btnOduzmi_Click(sender As Object, e As EventArgs) Handles btnOduzmi.Click
        Dim odu As Double
        prvi = TextBoxPrviBR.Text
        drugi = TextBoxDrugiBroj.Text
        odu = prvi - drugi
        TextBoxOduzmi.Text = odu
    End Sub
    Private Sub btnPomnozi_Click(sender As Object, e As EventArgs) Handles btnPomnozi.Click
        Dim pom As Double
        prvi = TextBoxPrviBR.Text
        drugi = TextBoxDrugiBroj.Text
        pom = prvi * drugi
        TextBoxPomnozi.Text = pom
    End Sub

    Private Sub btnPodijeli_Click(sender As Object, e As EventArgs) Handles btnPodijeli.Click
        Dim pod As Double
        prvi = TextBoxPrviBR.Text
        drugi = TextBoxDrugiBroj.Text
        pod = prvi / drugi
        TextBoxPodijeli.Text = pod
    End Sub

    Private Sub btnSaberi_Click(sender As Object, e As EventArgs) Handles btnSaberi.Click
        Dim rez As Double
        prvi = TextBoxPrviBR.Text
        drugi = TextBoxDrugiBroj.Text
        rez = prvi + drugi
        TextBoxSaberi.Text = rez

    End Sub
End Class
