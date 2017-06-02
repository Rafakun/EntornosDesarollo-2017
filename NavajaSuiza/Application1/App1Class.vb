Namespace NavajaSuiza.Application1
    Public Class App1Class
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()

        End Sub
        Dim AppForm As New App1Form
        '''<Summary>
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        Public Sub CalculaPrimo()
            Try
                Dim a As Integer = 0
                Dim n As Integer = CInt(AppForm.tbxPrimo.Text)

                For i As Integer = 1 To n + 1
                    If (n Mod i = 0) Then
                        a = a + 1
                    End If
                Next i
                If (a <> 2) Then
                    AppForm.lblPrimo.Text = "El número introducido NO es primo."
                Else
                    AppForm.lblPrimo.Text = "El número introducido es primo."
                End If
            Catch ex As Exception
                AppForm.lblPrimo.Text = "No has introducido un número valido."
            End Try
        End Sub
    End Class
End Namespace