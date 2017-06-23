Namespace Application2
    Public Class App2Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub

        '''<Summary>
        '''Se encapsula el valor de conversión Euro-Peseta.
        '''</Summary>
        Dim eurAPes As Double = 166.386
        '''<Summary>
        '''Convierte el valor que se pasa de Euros a Pesetas y viceversa.
        '''</Summary>
        '''<param name="dinero">El valor del dinero a convertir</param>
        '''<param name="tipoConversion">Pasa el tipo de conversión que quiere el usuario, en este caso 0 para pasar a pesetas y 1 a euros</param>
        '''<returns>Devuelve una cadena de texto concatenada con el tipo de dinero al cual se ha convertdo, además encapsula el resultado en TotalCalculaIVa para la App4</returns>
        Public Function ConvertirDinero(ByVal dinero As Double, ByVal tipoConversion As Integer) As String
            Try
                If dinero < 0 Then
                    Return "No has introducido" + vbCrLf + "un valor valido."
                End If
                If tipoConversion = 0 Then
                    Dim total = CDbl(dinero) * eurAPes
                    Dim redondeado As String = Math.Round(total, 2)
                    Main.MainForm.totalCalculaIVA = redondeado
                    redondeado += " Pesetas"
                    Return redondeado
                Else
                    Dim total = CDbl(dinero) / eurAPes
                    Dim redondeado As String = Math.Round(total, 2)
                    Main.MainForm.totalCalculaIVA = redondeado
                    redondeado += " €"
                    Return redondeado
                End If
            Catch ex As Exception
                Return ex.Message
                'Aquí registraría un error en una hipotetica base de datos
            End Try
        End Function
    End Class
End Namespace