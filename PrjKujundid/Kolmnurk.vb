﻿Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    'konstruktor baasklassi atribuutide v22rtustamiseks
    Public Sub New(ByVal alus As Double, ByVal haar As Double)
        'kutsume v2lja baasklassi konstruktori
        MyBase.New("Võrdhaarne kolmnurk", alus, haar, haar)

        'kolmnurga k6rgus
        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub



    'Overrides - Kirjutame üle baasklassist Kujund päritud samanimelise meetodi LeiaPindala()
    'Kolmnurga pindala arvutamine
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus / 2
    End Function

    'Kolmnurga ymberm66du arvutamine
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function


End Class

