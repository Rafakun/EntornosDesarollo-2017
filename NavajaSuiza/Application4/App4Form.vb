Namespace NavajaSuiza.Application4
    Partial Public Class App4Form
        ''' <summary>
        ''' Declaración de clases
        ''' </summary>
        Dim Aplicacion As New NavajaSuiza.Application4.App4Logica

        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App1Form()
            InitializeComponent()
        End Sub

        Public Function Comprobar(ByVal Nprimo As String) As Boolean
            Dim NumeroPrimo As Integer
            Dim Bool As Boolean = True
            If Int32.TryParse(Nprimo, NumeroPrimo) = False Then
                lblPrimo.Text = "El número introducido no es valido."
                Bool = False
            End If
            Return Bool
        End Function

        ''' <summary>
        ''' Llama a la función Calcular Primo
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnCalcular_Primo_Click(sender As Object, e As EventArgs) Handles btnCalcular_Primo.Click
            lblPrimo.Text = Aplicacion.CalculaPrimo(tbxPrimo.Text)
            lblPrimo.Visible = True
        End Sub
    End Class
End Namespace
