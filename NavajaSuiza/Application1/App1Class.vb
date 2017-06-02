Namespace NavajaSuiza.Application1
    Public Class App1Class
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub
        '''<Summary>
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        Public Function CalculaPrimo(ByVal NPrimo As String) As String
            Try
                Dim a As Integer = 0
                Dim n As Integer = CInt(NPrimo)

                For i As Integer = 1 To n + 1
                    If (n Mod i = 0) Then
                        a = a + 1
                    End If
                Next i
                If (a <> 2) Then
                    Return "El número introducido NO es primo."
                Else
                    Return "El número introducido es primo."
                End If
            Catch ex As Exception
                Return "No has introducido un número valido."
            End Try
        End Function
    End Class
End Namespace