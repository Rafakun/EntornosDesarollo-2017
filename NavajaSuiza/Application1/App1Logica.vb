Namespace Application1
    Public Class App1Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub
        '''<Summary>
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        '''<param name="nPrimo">Pasa el número primo desde el textbox del formulario</param>
        '''<returns>Devuelve una cadena de texto según el número calculado sea primo o no.</returns>
        Public Function CalculaPrimo(ByVal nPrimo As String) As String
            Dim auxiliarCuenta As Integer = 0
            Dim numeroPrimo As Integer = CInt(nPrimo)

            Try
                If numeroPrimo < 0 Then
                    Return "No has introducido " + vbCrLf + " un valor valido.(" + numeroPrimo.ToString + ")"
                End If
                For i As Integer = 1 To numeroPrimo + 1
                    If (numeroPrimo Mod i = 0) Then
                        auxiliarCuenta = auxiliarCuenta + 1
                    End If
                Next i
                If (auxiliarCuenta <> 2) Then
                    Return "El número " + numeroPrimo.ToString + vbCrLf + " NO es primo."
                Else
                    Return "El número " + numeroPrimo.ToString + vbCrLf + " es primo."
                End If
            Catch ex As Exception
                Return "Error en la función: " + ex.Message
                'Aquí registraría un error en una hipotetica base de datos
            End Try
        End Function
    End Class
End Namespace