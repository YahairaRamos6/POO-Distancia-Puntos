Public Class Punto2d
    Inherits Punto
    Protected y As Decimal

    Public Property Y1() As Decimal
        Get
            Return y
        End Get
        Set(value As Decimal)
            y = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        y = 0
    End Sub

    Public Sub New(x As Decimal, y As Decimal)
        MyBase.New(x)
        Y1 = y
    End Sub

    Public Overloads Function Calcular_Distancia(a As Punto2d)
        Return Math.Sqrt(Math.Pow(x - a.X1, 2) + Math.Pow(y - a.Y1, 2))
    End Function

    Public Overrides Function ToString() As String
        Return x + " " + y
    End Function
End Class
