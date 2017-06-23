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
            Dim a As Integer = 0
            Dim n As Integer = CInt(nPrimo)

            Try
                If n < 0 Then
                    Return "No has introducido " + vbCrLf + " un valor valido.(" + n.ToString + ")"
                End If
                For i As Integer = 1 To n + 1
                    If (n Mod i = 0) Then
                        a = a + 1
                    End If
                Next i
                If (a <> 2) Then
                    Return "El número " + n.ToString + vbCrLf + " NO es primo."
                Else
                    Return "El número " + n.ToString + vbCrLf + " es primo."
                End If
            Catch ex As Exception
                Return ex.Message
                'Aquí registraría un error en una hipotetica base de datos
            End Try
        End Function
    End Class
End Namespace