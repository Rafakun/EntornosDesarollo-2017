Namespace NavajaSuiza.Application1
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class App1Form
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
            Me.btnCalcular_Primo = New System.Windows.Forms.Button()
            Me.lblPrimo = New System.Windows.Forms.Label()
            Me.tbxPrimo = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'btnCalcular_Primo
            '
            Me.btnCalcular_Primo.Location = New System.Drawing.Point(24, 65)
            Me.btnCalcular_Primo.Name = "btnCalcular_Primo"
            Me.btnCalcular_Primo.Size = New System.Drawing.Size(220, 23)
            Me.btnCalcular_Primo.TabIndex = 0
            Me.btnCalcular_Primo.Text = "CalcularPrimo"
            Me.btnCalcular_Primo.UseVisualStyleBackColor = True
            '
            'lblPrimo
            '
            Me.lblPrimo.AutoSize = True
            Me.lblPrimo.Location = New System.Drawing.Point(55, 108)
            Me.lblPrimo.Name = "lblPrimo"
            Me.lblPrimo.Size = New System.Drawing.Size(43, 13)
            Me.lblPrimo.TabIndex = 1
            Me.lblPrimo.Text = "lblPrimo"
            Me.lblPrimo.Visible = False
            '
            'tbxPrimo
            '
            Me.tbxPrimo.Location = New System.Drawing.Point(23, 28)
            Me.tbxPrimo.MaxLength = 10
            Me.tbxPrimo.Name = "tbxPrimo"
            Me.tbxPrimo.Size = New System.Drawing.Size(221, 20)
            Me.tbxPrimo.TabIndex = 2
            '
            'App1Form
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(266, 148)
            Me.Controls.Add(Me.tbxPrimo)
            Me.Controls.Add(Me.lblPrimo)
            Me.Controls.Add(Me.btnCalcular_Primo)
            Me.Name = "App1Form"
            Me.Text = "App1Form"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnCalcular_Primo As Button
        Friend WithEvents lblPrimo As Label
        Friend WithEvents tbxPrimo As TextBox
    End Class
End Namespace
