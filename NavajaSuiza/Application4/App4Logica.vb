Namespace NavajaSuiza.Application4
    Public Class App4Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub
        '''<Summary>
        '''Método Principal, calcula el iva del numero introducido según el IVA seleccionado en el combobox.
        '''</Summary>
        '''<param name="NumeroIVA">Numero a calcular IVA</param>
        '''<param name="IVA">El tipo de IVA a calcular(0%, 4%, 10% o 21%)</param>
        '''<returns>Devuelve una cadena de texto con el calculo del IVA según el valor y el IVA establecido.</returns>
        Public Shared Function CalculaIVA(ByVal NumeroIVA As Double, ByVal IVA As Integer) As String
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