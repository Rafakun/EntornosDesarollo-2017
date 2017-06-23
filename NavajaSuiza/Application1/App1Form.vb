Namespace NavajaSuiza.Application1
    Partial Public Class App1Form
        ''' <summary>
        ''' Declaración de clases
        ''' </summary>
        Dim Aplicacion As New NavajaSuiza.Application1.App1Logica

        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App1Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Función para comprobar que el número introducido es correcto.
        ''' </summary>
        ''' <param name="NprimoComprobar">Número introducido por el usuario</param>
        Public Function Comprobar(ByVal NprimoComprobar As String) As Boolean
            Dim NumeroPrimo As Integer
            Dim Bool As Boolean = True
            If Int32.TryParse(NprimoComprobar, NumeroPrimo) = False Then
                lblPrimo.Text = "El número introducido" + vbCrLf + "no es valido."
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
            Try
                If Comprobar(tbxPrimo.Text) Then
                    lblPrimo.Text = Aplicacion.CalculaPrimo(tbxPrimo.Text)
                Else
                    Throw New Exception
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblPrimo.Visible = True
            End Try
        End Sub
    End Class
End Namespace
