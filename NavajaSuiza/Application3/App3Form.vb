Namespace NavajaSuiza.Application3
    Partial Public Class App3Form
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App3Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Función para comprobar que el número introducido es correcto.
        ''' </summary>
        ''' <param name="PesetasDouble">Número introducido por el usuario</param>
        Public Function Comprobar(ByVal PesetasDouble As String) As Boolean
            Dim Doble As Double
            Dim Bool As Boolean = True
            If Double.TryParse(PesetasDouble, Doble) = False Then
                lblBilletes.Text = "El número introducido" + vbCrLf + "no es valido."
                Bool = False
            End If
            Return Bool
        End Function

        ''' <summary>
        ''' Llama a la funcion DivideBilletes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub DivideBilletes(sender As Object, e As EventArgs) Handles btnDivide_Billetes.Click
            Try
                If Comprobar(tbxDinero.Text) Then
                    lblBilletes.Text = App3Logica.FDivideBilletes(tbxDinero.Text)
                Else
                    Throw New Exception
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblBilletes.Visible = True
            End Try
        End Sub
    End Class
End Namespace
