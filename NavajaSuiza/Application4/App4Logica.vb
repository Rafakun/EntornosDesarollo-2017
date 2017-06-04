Namespace NavajaSuiza.Application4
    Public Class App4Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub
        '''<Summary>
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        '''<param name="NumeroIVA">Numero a calcular IVA</param>
        '''<
        Public Shared Function CalculaPrimo(ByVal NumeroIVA As Double, ByVal IVA As Integer) As String
            Try
                Dim n As Double = NumeroIVA
                If NumeroIVA >= 0 Then
                    Dim Total = NumeroIVA + NumeroIVA / 100 * IVA
                    Return "El total con " + IVA.ToString + "% IVA es: " + Total.ToString
                Else
                    Throw New Exception
                End If
            Catch ex As Exception
                Return "No has introducido" + vbCrLf + "un valor valido."
                'Aquí registraría un error en una hipotetica base de datos
            End Try
        End Function
    End Class
End Namespace