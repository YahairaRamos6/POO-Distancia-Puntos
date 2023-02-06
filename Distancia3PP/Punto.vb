Public Class Punto
    Protected x As Decimal

    Public Property X1() As Decimal
        Get
            Return x
        End Get
        Set(value As Decimal)
            x = value
        End Set
    End Property

    Public Sub New()
        x = 0
    End Sub

    Public Sub New(x As Decimal)
        Me.x = x
    End Sub

    Public Function Calcular_Distancia(Punto_a As Punto)
        Return Math.Abs(x - Punto_a.X1)
    End Function

    Public Overrides Function ToString() As String
        Return x + " "
    End Function

End Class
