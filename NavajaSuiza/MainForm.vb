Namespace Main
    Public Class MainForm
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub MainForm()
            InitializeComponent()
        End Sub
        Public totalCalculaIVA
        ''' <summary>
        ''' Abre el formulario de la App1
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MainApp1_Click(sender As Object, e As EventArgs) Handles MainApp1.Click
            Dim frm As New Application1.App1Form()
            frm.Show()
        End Sub
        ''' <summary>
        ''' Abre el formulario de la App2
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MainApp2_Click(sender As Object, e As EventArgs) Handles MainApp2.Click
            Dim frm As New Application2.App2Form()
            frm.Show()
        End Sub
        ''' <summary>
        ''' Abre el formulario de la App3
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MainApp3_Click(sender As Object, e As EventArgs) Handles MainApp3.Click
            Dim frm As New Application3.App3Form()
            frm.Show()
        End Sub
        ''' <summary>
        ''' Abre el formulario de la App4
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MainApp4_Click(sender As Object, e As EventArgs) Handles MainApp4.Click
            Dim frm As New Application4.App4Form()
            frm.Show()
        End Sub
    End Class
End Namespace