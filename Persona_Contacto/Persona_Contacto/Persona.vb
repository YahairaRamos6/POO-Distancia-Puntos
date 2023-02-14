Public Class Persona
    Protected Nombre As String
    Protected AP As String
    Protected AM As String
    Protected fecha_nac As Date

    Public Property NombreP As String 'NombreP es nombre de la clase persona  'clase contiene atributos
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property APP As String
        Get
            Return AP
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property AMP As String
        Get
            Return AM
        End Get
        Set(value As String)
        End Set
    End Property

    Public Property Fecha_nacP As Date
        Get
            Return Fecha_nac
        End Get
        Set(value As Date)
        End Set
    End Property

    Public Sub New(ByVal Nombre As String, ByVal AP As String, ByVal AM As String, ByVal fecha_nac As Date)
        Me.Nombre = Nombre
        Me.AP = AP
        Me.AM = AM
        Me.fecha_nac = fecha_nac
    End Sub
End Class
