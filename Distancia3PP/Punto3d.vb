Public Class Punto3d
    Inherits Punto2d

    Protected z As Decimal

    Public Property Z1() As Decimal
        Get
            Return z
        End Get
        Set(value As Decimal)
            z = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        z = 0
    End Sub

    Public Sub New(x As Decimal, y As Decimal, z As Decimal)
        MyBase.New(x, y)
        Z1 = z
    End Sub

    Public Overloads Function Calcular_Distancia(a As Punto3d)
        Return Math.Sqrt(Math.Pow(x - a.X1, 2) + Math.Pow(y - a.Y1, 2) + Math.Pow(z - a.Z1, 2))
    End Function

    Public Overrides Function ToString() As String
        Return x + " " + y + " " + z
    End Function
End Class
