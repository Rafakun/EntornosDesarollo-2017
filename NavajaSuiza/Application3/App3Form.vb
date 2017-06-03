Namespace NavajaSuiza.Application3
    Partial Public Class App3Form
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App3Form()
            InitializeComponent()
        End Sub

        Public Function Comprobar(ByVal Pesetas As String) As Boolean
            Dim Doble As Double
            Dim Bool As Boolean = True
            If Double.TryParse(Pesetas, Doble) = False Then
                lblBilletes.Text = "El número introducido no es valido."
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
                If Comprobar(tbxDinero.Text) = True Then
                    lblBilletes.Text = App3Logica.FDivideBilletes(tbxDinero.Text)
                    lblBilletes.Visible = True
                Else
                    Throw New Exception
                End If
            Catch ex As Exception
                lblBilletes.Visible = True
            End Try

        End Sub
    End Class
End Namespace
