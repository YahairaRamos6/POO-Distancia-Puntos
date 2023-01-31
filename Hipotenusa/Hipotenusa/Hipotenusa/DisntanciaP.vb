Public Class Form1
    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        Dim d As Double
        Dim dis As New Distancia(Txt_x1.Text, Txt_x2.Text, Txt_y1.Text, Txt_y2.Text)
        d = dis.Calcular()

        Text_Resultado.Text = d
    End Sub
    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        Text_Resultado.Clear()
        Txt_x1.Text = ("")
        Txt_x2.Text = ("")
        Txt_y2.Text = ("")
        Txt_y1.Text = ("")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_Resultado.Enabled = False
    End Sub
End Class
