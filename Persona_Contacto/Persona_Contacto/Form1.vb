Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        Dim J As New Contacto(Txt_Nombre.Text, Txt_AP.Text, Txt_AM.Text, DTP_Fecha.Value, Txt_Telefono.Text, Txt_correo.Text)
        Txt_rfc.Text = J.CalcularRFC
        MessageBox.Show("zisisii")
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Txt_rfc.Clear()
        Txt_AM.Text = ("")
        Txt_AP.Text = ("")
        Txt_correo.Text = ("")
        Txt_Nombre.Text = ("")
        Txt_Telefono.Text = ("")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_rfc.Enabled = False
    End Sub
End Class
