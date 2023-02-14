Public Class Contacto
    Inherits Persona

    Protected telefono As String
    Protected _correo As String

    Public Property telefonoC As Integer
        Get
            Return telefono
        End Get
        Set(value As Integer)
        End Set
    End Property

    Protected Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Sub New(ByVal Nombre As String, ByVal AP As String, ByVal AM As String, ByVal fecha_nac As Date, ByVal telefono As String, ByVal _correo As String)
        MyBase.New(Nombre, AP, AM, fecha_nac)
        Me.telefono = telefono
        Me._correo = _correo

    End Sub

    Public Function CalcularRFC() As String
        Dim rfc As String

        rfc = Left(AP, 2) ' Toma las primeras dos letras del apellido paterno
        rfc = rfc & Left(AM, 1) ' Toma la primera letra del apellido materno
        rfc = rfc & Left(Nombre, 1) ' Toma la primera letra del nombre
        rfc = rfc & Right(fecha_nac.Year.ToString(), 2) ' Toma los últimos dos dígitos del año de nacimiento,Podemos obtener los 2 últimos caracteres de la cadena
        rfc = rfc & Right("0" & fecha_nac.Month.ToString(), 2) ' Toma los dos dígitos del mes de nacimiento
        rfc = rfc & Right("0" & fecha_nac.Day.ToString(), 2) ' Toma los dos dígitos del día de nacimiento
        Return rfc.ToUpper() ' Devuelve el resultado en mayúsculas

    End Function

End Class
