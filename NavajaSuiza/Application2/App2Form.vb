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
        ''' <summary>
        ''' Función para comprobar que el número introducido es correcto.
        ''' </summary>
        ''' <param name="NumAConvertir">Número introducido por el usuario</param>
        Public Function Comprobar(ByVal NumAConvertir As String) As Boolean
            Dim Resultado As Double
            Dim Bool As Boolean = True
            If Double.TryParse(NumAConvertir, Resultado) = False Then
                lblConvertido.Text = "El número introducido" + vbCrLf + "no es valido."
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
                MainForm.TotalCalculaIva = ""
                Dim Dinero = tbxDinero.Text
                If Comprobar(Dinero) Then
                    lblConvertido.Text = Aplicacion.ConvertirDinero(Dinero, 0)
                    btnCalcula_IvaApp4.Visible = True
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblConvertido.Visible = True
            End Try
        End Sub
        ''' <summary>
        ''' Llama a la función para convertir, pasandole el valor 1 que convierte a euros.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnConvertir_Euros_Click(sender As Object, e As EventArgs) Handles btnConvertir_Euros.Click
            Try
                MainForm.TotalCalculaIva = ""
                Dim Dinero = tbxDinero.Text
                If Comprobar(Dinero) Then
                    lblConvertido.Text = Aplicacion.ConvertirDinero(Dinero, 1)
                    btnCalcula_IvaApp4.Visible = True
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblConvertido.Visible = True
            End Try
        End Sub
        ''' <summary>
        ''' Llama a el formulario de la APP4 el cual tiene establecido (si existe) el valor del lblConvertido
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnCalcula_IvaApp4_Click(sender As Object, e As EventArgs) Handles btnCalcula_IvaApp4.Click
            Dim frm As New Application4.App4Form()
            frm.Show()
        End Sub
    End Class
End Namespace
