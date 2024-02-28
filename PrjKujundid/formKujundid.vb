Public Class formKujundid
    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tyyp v2ljastamine
        lblTyyp.Text = kujund.annaTyyp

        'Pindala ja ymberm66du arvutamine ja v2ljastamine
        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub

    Private Sub btnKolmnurk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKolmnurk.Click
        'Objekt kolmnurga klassist
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuut.Click
        'Objekt ruudu klassist
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub
    Private Sub btnRistkylik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRistkylik.Click
        'otsene v2ljakutse meetodil tootleKujund
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub

End Class