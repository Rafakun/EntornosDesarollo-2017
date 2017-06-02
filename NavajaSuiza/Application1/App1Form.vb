Namespace NavajaSuiza.Application1
    Partial Public Class App1Form
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App1Form()
            InitializeComponent()
        End Sub

        Dim Aplicacion As New NavajaSuiza.Application1.App1Class
        ''' <summary>
        ''' Llama a la función Calcular Primo
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnCalcular_Primo_Click(sender As Object, e As EventArgs) Handles btnCalcular_Primo.Click
            Aplicacion.CalculaPrimo()
        End Sub
    End Class
End Namespace
