Public Class Distancia
    Inherits Puntos

    Public Sub New(x1 As Integer, x2 As Integer, y1 As Integer, y2 As Integer)
        Me.X1 = x1
        Me.X2 = x2
        Me.Y1 = y1
        Me.Y2 = y2
    End Sub


    Public Function Calcular() As Double
        Dim d As Double
        d = ((Math.Pow(X2 - X1, 2)) + (Math.Pow(Y2 - Y1, 2)))
        d = (Math.Sqrt(d))
        Return d
    End Function
End Class
