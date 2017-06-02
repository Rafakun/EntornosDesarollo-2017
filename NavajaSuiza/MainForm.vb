Namespace NavajaSuiza
    Public Class MainForm
        Public Sub Hola()

        End Sub

        ''' <summary>
        ''' Abre el formulario de la App1
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MainApp1_Click(sender As Object, e As EventArgs) Handles MainApp1.Click
            Dim frm As New Application1.App1Form()
            frm.Show()
        End Sub
    End Class
End Namespace