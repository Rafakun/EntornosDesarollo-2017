Namespace NavajaSuiza.Application4
    Partial Public Class App4Form
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App4Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Declaración de variables locales
        ''' </summary>
        Dim TotalCalculaIva = MainForm.TotalCalculaIva
        ''' <summary>
        ''' Se iguala el Textbox a la variable publica "TotalCalculaIva"
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub App4Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            tbxCalculaIVA.Text = TotalCalculaIva
            cbxIVA.SelectedIndex = 0
        End Sub
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App1Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Función para comprobar que el número introducido es correcto.
        ''' </summary>
        ''' <param name="NumeroIVA">Número introducido por el usuario</param>
        Public Function Comprobar(ByVal NumeroIVA As String) As Boolean
            Dim NumeroPrimo As Integer
            Dim Bool As Boolean = True
            If Double.TryParse(NumeroIVA, NumeroPrimo) = False Then
                lblTotal.Text = "El número introducido" + vbCrLf + "no es valido."
                Bool = False
            End If
            Return Bool
        End Function

        ''' <summary>
        ''' Llama a la función Calcular Primo
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnCalcular_Primo_Click(sender As Object, e As EventArgs) Handles btnCalcular_Iva.Click
            Try
                If Comprobar(tbxCalculaIVA.Text) Then
                    Dim IVA = cbxIVA.Text.Replace("%", "")
                    lblTotal.Text = App4Logica.CalculaPrimo(tbxCalculaIVA.Text, IVA)
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblTotal.Visible = True
            End Try

        End Sub
    End Class
End Namespace
