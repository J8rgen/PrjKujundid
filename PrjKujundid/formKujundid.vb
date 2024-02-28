Imports System.Security.AccessControl

Public Class formKujundid

    Private Sub FormKujundid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tyyp v2ljastamine
        lblTyyp.Text = kujund.annaTyyp

        'Pindala ja ymberm66du arvutamine ja v2ljastamine

        'txtPindala.Text = kujund.leiaPindala
        txtPindala.Text = Math.Round(kujund.leiaPindala, Convert.ToInt32(ComboBox1.SelectedItem))
        'txtYmbermoot.Text = kujund.leiaYmberMoot
        txtYmbermoot.Text = Math.Round(kujund.leiaYmberMoot, Convert.ToInt32(ComboBox1.SelectedItem))
    End Sub

    Private Sub btnKolmnurk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKolmnurk.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) Or String.IsNullOrWhiteSpace(txtKylgB.Text) Then ' kui viga sisendis
            Dim objektKolmnurk As New Kolmnurk(0, 0)
            tootleKujund(objektKolmnurk)
            lblViga.Text = "Viga viimases sisendis"
        ElseIf Not IsNumeric(txtKylgA.Text) Or Not IsNumeric(txtKylgB.Text) Then
            Dim objektKolmnurk As New Kolmnurk(0, 0)
            tootleKujund(objektKolmnurk)
            lblViga.Text = "Viga viimases sisendis"
        Else

            Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
            tootleKujund(objektKolmnurk)
            lblViga.Text = ""
        End If

    End Sub

    Private Sub btnRuut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuut.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) Then ' kui viga sisendis
            'Objekt ruudu klassist
            Dim objektRuut As New Ruut(0)
            tootleKujund(objektRuut)
            lblViga.Text = "Viga viimases sisendis"
        ElseIf Not IsNumeric(txtKylgA.Text) Then
            'Objekt ruudu klassist
            Dim objektRuut As New Ruut(0)
            tootleKujund(objektRuut)
            lblViga.Text = "Viga viimases sisendis"
        Else
            'Objekt ruudu klassist
            Dim objektRuut As New Ruut(txtKylgA.Text)
            tootleKujund(objektRuut)
            lblViga.Text = ""
        End If

    End Sub
    Private Sub btnRistkylik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRistkylik.Click

        If String.IsNullOrWhiteSpace(txtKylgA.Text) Or String.IsNullOrWhiteSpace(txtKylgB.Text) Then ' kui viga sisendis
            tootleKujund(New Ristkylik(0, 0))
            lblViga.Text = "Viga viimases sisendis"
        ElseIf Not IsNumeric(txtKylgA.Text) Or Not IsNumeric(txtKylgB.Text) Then
            tootleKujund(New Ristkylik(0, 0))
            lblViga.Text = "Viga viimases sisendis"
        Else
            tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
            lblViga.Text = ""
        End If
    End Sub

    Private Sub btnRomb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRomb.Click

        If String.IsNullOrWhiteSpace(txtKylgA.Text) Or String.IsNullOrWhiteSpace(txtKorgus.Text) Then ' kui viga sisendis
            'otsene v2ljakutse meetodil tootleKujund
            tootleKujund(New Romb(0, 0))
            lblViga.Text = "Viga viimases sisendis"
        ElseIf Not IsNumeric(txtKylgA.Text) Or Not IsNumeric(txtKorgus.Text) Then
            tootleKujund(New Romb(0, 0))
            lblViga.Text = "Viga viimases sisendis"
        Else
            'otsene v2ljakutse meetodil tootleKujund
            tootleKujund(New Romb(txtKylgA.Text, txtKorgus.Text))
            lblViga.Text = ""
        End If
    End Sub

    Private Sub btnRoopkylik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoopkylik.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) Or String.IsNullOrWhiteSpace(txtKylgB.Text) Or String.IsNullOrWhiteSpace(txtKorgus.Text) Then ' kui viga sisendis
            tootleKujund(New Roopkylik(0, 0, 0))
            lblViga.Text = "Viga viimases sisendis"
        ElseIf Not IsNumeric(txtKylgA.Text) Or Not IsNumeric(txtKylgB.Text) Or Not IsNumeric(txtKorgus.Text) Then
            tootleKujund(New Roopkylik(0, 0, 0))
            lblViga.Text = "Viga viimases sisendis"
        Else
            tootleKujund(New Roopkylik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text))
            lblViga.Text = ""
        End If
    End Sub


End Class