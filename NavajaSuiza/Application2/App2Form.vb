Namespace NavajaSuiza.Application2
    Partial Public Class App2Form
        ''' <summary>
        ''' Declaración de clases
        ''' </summary>
        Dim Aplicacion As New App2Logica
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App2Form()
            InitializeComponent()
        End Sub

        Public Function Comprobar(ByVal NumAConvertir As String) As Boolean
            Dim Resultado As Double
            Dim Bool As Boolean = True
            If Double.TryParse(NumAConvertir, Resultado) = False Then
                lblConvertido.Text = "Error al introducir número."
                Bool = False
            End If
            Return Bool
        End Function

        ''' <summary>
        ''' Llama a la función para convertir, pasandole el valor 0 que convierte a pesetas.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnConvertir_Pesetas_Click(sender As Object, e As EventArgs) Handles btnConvertir_Pesetas.Click
            Try
                If Comprobar(tbxDinero.Text) = True Then
                    lblConvertido.Text = Aplicacion.Convertir(tbxDinero.Text, 0)
                    lblConvertido.Visible = True
                End If
            Catch ex As Exception
                lblConvertido.Text = "Error: " + ex.Message
            End Try
        End Sub
        ''' <summary>
        ''' Llama a la función para convertir, pasandole el valor 1 que convierte a euros.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnConvertir_Euros_Click(sender As Object, e As EventArgs) Handles btnConvertir_Euros.Click
            Try
                If Comprobar(tbxDinero.Text) = True Then
                    lblConvertido.Text = Aplicacion.Convertir(tbxDinero.Text, 1)
                    lblConvertido.Visible = True
                End If
            Catch ex As Exception
                lblConvertido.Text = "Error: " + ex.Message
            End Try
        End Sub
    End Class
End Namespace
