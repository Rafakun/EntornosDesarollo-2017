Namespace NavajaSuiza
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.MainApp1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'MainApp1
            '
            Me.MainApp1.Location = New System.Drawing.Point(12, 26)
            Me.MainApp1.Name = "MainApp1"
            Me.MainApp1.Size = New System.Drawing.Size(75, 23)
            Me.MainApp1.TabIndex = 0
            Me.MainApp1.Text = "Aplicación 1"
            Me.MainApp1.UseVisualStyleBackColor = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 261)
            Me.Controls.Add(Me.MainApp1)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainApp1 As Button
    End Class
End Namespace
