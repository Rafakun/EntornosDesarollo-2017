Namespace Application3
    Public Class App3Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub

        '''<Summary>
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        '''<param name="dinero">Valor introducido por el usuario para repartirse en billetes</param>
        '''<returns>Devuelve una cadena de texto con las cantidades de billetes divididos y el tipo de billete.</returns>
        Public Shared Function FDivideBilletes(ByVal dinero As String) As String
            Dim textoBilletes As String = ""
            Try
                Dim billetes As Integer
                If dinero > 0 Then
                    If (dinero >= 10000) Then
                        billetes = Fix(dinero / 10000)
                        textoBilletes += billetes.ToString + " billetes de 10.000 pesetas" + vbCrLf
                        dinero = dinero Mod 10000
                    End If
                    If (dinero >= 5000) Then
                        billetes = Fix(dinero / 5000)
                        textoBilletes += billetes.ToString + " billetes de 5.000 pesetas" + vbCrLf
                        dinero = dinero Mod 5000
                    End If

                    If (dinero >= 2000) Then
                        billetes = Fix(dinero / 2000)
                        textoBilletes += billetes.ToString + " billetes de 2.000 pesetas" + vbCrLf
                        dinero = dinero Mod 2000
                    End If
                    If (dinero >= 1000) Then
                        billetes = Fix(dinero / 1000)
                        textoBilletes += billetes.ToString + " billetes de 1.000 pesetas" + vbCrLf
                        dinero = dinero Mod 1000
                    End If
                    If (dinero >= 100) Then
                        billetes = Fix(dinero / 100)
                        textoBilletes += billetes.ToString + " monedas de 100 pesetas" + vbCrLf
                        dinero = dinero Mod 100
                    End If
                    If (dinero >= 25) Then
                        billetes = Fix(dinero / 25)
                        textoBilletes += billetes.ToString + " monedas de 25 pesetas"
                    End If
                Else
                    textoBilletes = "No has introducido" + vbCrLf + "un número valido"
                End If
            Catch ex As Exception
                Return "No has introducido" + vbCrLf + "un valor válido."
                'Aquí registraría un error en una hipotetica base de datos
            End Try
            Return textoBilletes
        End Function
    End Class
End Namespace