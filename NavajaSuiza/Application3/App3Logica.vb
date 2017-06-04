Namespace NavajaSuiza.Application3
    Public Class App3Logica
        '''<Summary>
        '''Constructor, sin uso.
        '''</Summary>
        Sub New()
        End Sub

        '''<Summary>
        '''Método Principal, calcula el si el numero del textbox es primo.
        '''</Summary>
        '''<param name="Dinero">Valor introducido por el usuario para repartirse en billetes</param>
        Public Shared Function FDivideBilletes(ByVal Dinero As Double) As String
            Dim Billetes As Integer
            Dim TextoBilletes As String = ""
            Try
                If (Dinero >= 10000) Then
                    Billetes = Fix(Dinero / 10000)
                    TextoBilletes += Billetes.ToString + " billetes de 10.000 pesetas" + vbCrLf
                    Dinero = Dinero Mod 10000
                End If
                If (Dinero >= 5000) Then
                    Billetes = Fix(Dinero / 5000)
                    TextoBilletes += Billetes.ToString + " billetes de 5.000 pesetas" + vbCrLf
                    Dinero = Dinero Mod 5000
                End If

                If (Dinero >= 2000) Then
                    Billetes = Fix(Dinero / 2000)
                    TextoBilletes += Billetes.ToString + " billetes de 2.000 pesetas" + vbCrLf
                    Dinero = Dinero Mod 2000
                End If
                If (Dinero >= 1000) Then
                    Billetes = Fix(Dinero / 1000)
                    TextoBilletes += Billetes.ToString + " billetes de 1.000 pesetas" + vbCrLf
                    Dinero = Dinero Mod 1000
                End If
                If (Dinero >= 100) Then
                    Billetes = Fix(Dinero / 100)
                    TextoBilletes += Billetes.ToString + " monedas de 100 pesetas" + vbCrLf
                    Dinero = Dinero Mod 100
                End If
                If (Dinero >= 25) Then
                    Billetes = Fix(Dinero / 25)
                    TextoBilletes += Billetes.ToString + " monedas de 25 pesetas"
                End If
            Catch ex As Exception
                Return "Error en la introducción del dinero" + ex.Message
            End Try
            Return TextoBilletes
        End Function
    End Class
End Namespace