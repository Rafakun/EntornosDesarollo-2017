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
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        Public Function Convertir(ByVal Dinero As String, ByVal TipoConversion As Integer) As String
            Try
                If Dinero < 0 Then
                    Throw New Exception
                End If
                If TipoConversion = 0 Then
                    Dim Total = CDbl(Dinero) * EurAPes
                    Dim Redondeado As String = Math.Round(Total, 2)
                    Redondeado += " Pesetas"
                    Return Redondeado
                Else
                    Dim Total = CDbl(Dinero) / EurAPes
                    Dim Redondeado As String = Math.Round(Total, 2)
                    Redondeado += " €"
                    Return Redondeado
                End If
            Catch ex As Exception
                Return "No has introducido" + vbCrLf + "un valor valido."
            End Try
        End Function
    End Class
End Namespace