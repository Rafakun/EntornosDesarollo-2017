Namespace Application4
    Public Class App4Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub
        '''<Summary>
        '''Método Principal, calcula el iva del numero introducido según el IVA seleccionado en el combobox.
        '''</Summary>
        '''<param name="numeroIVA">Numero a calcular IVA</param>
        '''<param name="IVA">El tipo de IVA a calcular(0%, 4%, 10% o 21%)</param>
        '''<returns>Devuelve una cadena de texto con el calculo del IVA según el valor y el IVA establecido.</returns>
        Public Shared Function CalculaIVA(ByVal numeroIVA As String, ByVal IVA As Integer) As String
            Try
                Dim numero As Double = CDbl(numeroIVA)
                If numero >= 0 Then
                    Dim total = numero + numero / 100 * IVA
                    Dim redondeado As String = Math.Round(total, 2)
                    Return "El total con " + IVA.ToString + "% IVA es: " + redondeado.ToString
                Else
                    Return "No has introducido" + vbCrLf + "un número valido."
                End If
            Catch ex As Exception
                Return "No has introducido" + vbCrLf + "un valor valido."
                'Aquí registraría un error en una hipotetica base de datos
            End Try
        End Function
    End Class
End Namespace