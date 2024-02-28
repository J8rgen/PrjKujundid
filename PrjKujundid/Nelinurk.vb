Public MustInherit Class Nelinurk
    Inherits Kujund

    Protected kylgD As Double

    'konstruktor baasklassi atribuutide v22rtustamiseks
    'ning klassi atribuudi kylgD v22rtustamiseks
    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double, ByVal kylgB As Double, ByVal kylgC As Double, ByVal kylgD As Double)

        'Baasklassi konstruktori v2ljakutse
        MyBase.New(tyyp, kylgA, kylgB, kylgC)

        'Atribuudi kylgD algv22rtustamine
        Me.kylgD = kylgD
    End Sub

    'Funktsioon arvutab ja tagastab nelinurga pindala
    Public Overrides Function leiaPindala() As Double
        Return 0
    End Function

    'Funktsioon arvutab ja tagastab nelinurga ymberm66du
    Public Overrides Function leiaYmbermoot() As Double
        If kylgA = 0 Or kylgB = 0 Or kylgC = 0 Or kylgD = 0 Then
            Return 0
        Else
            Return kylgA + kylgB + kylgC + kylgD
        End If
    End Function

End Class

