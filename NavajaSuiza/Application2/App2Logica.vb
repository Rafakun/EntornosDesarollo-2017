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
        Public Function Convertir(ByVal Dinero As Double, ByVal TipoConversion As Integer) As String
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