Namespace NavajaSuiza.Application2
    Public Class App2Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub

        '''<Summary>
        '''Se encapsula el valor de conversión Euro-Peseta.
        '''</Summary>
        Dim EurAPes As Double = 166.386
        '''<Summary>
        '''Convierte el valor que se pasa de Euros a Pesetas y viceversa.
        '''</Summary>
        '''<param name="Dinero">El valor del dinero a convertir</param>
        '''<param name="TipoConversion">Pasa el tipo de conversión que quiere el usuario, en este caso 0 para pasar a pesetas y 1 a euros</param>
        '''<returns>Devuelve una cadena de texto concatenada con el tipo de dinero al cual se ha convertdo, además encapsula el resultado en TotalCalculaIVa para la App4</returns>
        Public Function ConvertirDinero(ByVal Dinero As Double, ByVal TipoConversion As Integer) As String
            Try
                If Dinero < 0 Then
                    Throw New Exception
                End If
                If TipoConversion = 0 Then
                    Dim Total = CDbl(Dinero) * EurAPes
                    Dim Redondeado As String = Math.Round(Total, 2)
                    MainForm.TotalCalculaIva = Redondeado
                    Redondeado += " Pesetas"
                    Return Redondeado
                Else
                    Dim Total = CDbl(Dinero) / EurAPes
                    Dim Redondeado As String = Math.Round(Total, 2)
                    MainForm.TotalCalculaIva = Redondeado
                    Redondeado += " €"
                    Return Redondeado
                End If
            Catch ex As Exception
                Return "No has introducido" + vbCrLf + "un valor valido."
                'Aquí registraría un error en una hipotetica base de datos
            End Try
        End Function
    End Class
End Namespace