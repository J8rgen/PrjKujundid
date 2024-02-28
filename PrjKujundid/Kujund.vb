' Abstrakktne baasklass kujundite jaoks
Public MustInherit Class Kujund
    ' klass on abstraktne, sellest objekte luua ei saa
    ' Antud klassist tuleb luua alamklass
    Private tyyp As String
    Protected kylgA As Double
    Protected kylgB As Double
    Protected kylgC As Double



    ' KONSTRUKTOR atribuuttide algv22rtustamiseks
    ' atribuudid: kylg_a, kylg_b, kylg_c
    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double, ByVal kylgB As Double, ByVal kylgC As Double)
        Me.tyyp = tyyp
        Me.kylgA = kylgA
        Me.kylgB = kylgB
        Me.kylgC = kylgC
    End Sub

    'MEETODID
    'funktsioon tagastab kujundi tyybi
    Public Function annaTyyp() As String
        Return tyyp
    End Function

    'abstraktne funktsioon kujundi ymberm66du arvutamiseks
    Public MustOverride Function leiaYmberMoot() As Double

    'abstraktne funktsioon kujundi pindala arvutamiseks
    Public MustOverride Function leiaPindala() As Double

End Class

