Namespace Application1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App1Form))
            Me.btnCalcular_Primo = New System.Windows.Forms.Button()
            Me.lblPrimo = New System.Windows.Forms.Label()
            Me.tbxPrimo = New System.Windows.Forms.TextBox()
            Me.ImagenCabecera = New System.Windows.Forms.PictureBox()
            Me.App1Titulo = New System.Windows.Forms.Label()
            CType(Me.ImagenCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCalcular_Primo
            '
            Me.btnCalcular_Primo.Location = New System.Drawing.Point(84, 232)
            Me.btnCalcular_Primo.Name = "btnCalcular_Primo"
            Me.btnCalcular_Primo.Size = New System.Drawing.Size(220, 23)
            Me.btnCalcular_Primo.TabIndex = 0
            Me.btnCalcular_Primo.Text = "Calcular Número Primo"
            Me.btnCalcular_Primo.UseVisualStyleBackColor = True
            '
            'lblPrimo
            '
            Me.lblPrimo.AutoSize = True
            Me.lblPrimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPrimo.Location = New System.Drawing.Point(112, 258)
            Me.lblPrimo.Name = "lblPrimo"
            Me.lblPrimo.Size = New System.Drawing.Size(86, 24)
            Me.lblPrimo.TabIndex = 1
            Me.lblPrimo.Text = "lblPrimo"
            Me.lblPrimo.Visible = False
            '
            'tbxPrimo
            '
            Me.tbxPrimo.Location = New System.Drawing.Point(83, 206)
            Me.tbxPrimo.MaxLength = 10
            Me.tbxPrimo.Name = "tbxPrimo"
            Me.tbxPrimo.Size = New System.Drawing.Size(221, 20)
            Me.tbxPrimo.TabIndex = 2
            '
            'ImagenCabecera
            '
            Me.ImagenCabecera.Image = CType(resources.GetObject("ImagenCabecera.Image"), System.Drawing.Image)
            Me.ImagenCabecera.Location = New System.Drawing.Point(1, -1)
            Me.ImagenCabecera.Name = "ImagenCabecera"
            Me.ImagenCabecera.Size = New System.Drawing.Size(392, 146)
            Me.ImagenCabecera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.ImagenCabecera.TabIndex = 7
            Me.ImagenCabecera.TabStop = False
            '
            'App1Titulo
            '
            Me.App1Titulo.AutoSize = True
            Me.App1Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
            Me.App1Titulo.Location = New System.Drawing.Point(21, 148)
            Me.App1Titulo.Name = "App1Titulo"
            Me.App1Titulo.Size = New System.Drawing.Size(348, 31)
            Me.App1Titulo.TabIndex = 8
            Me.App1Titulo.Text = "Calculador número primo."
            '
            'App1Form
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(393, 327)
            Me.Controls.Add(Me.App1Titulo)
            Me.Controls.Add(Me.ImagenCabecera)
            Me.Controls.Add(Me.tbxPrimo)
            Me.Controls.Add(Me.lblPrimo)
            Me.Controls.Add(Me.btnCalcular_Primo)
            Me.Name = "App1Form"
            Me.Text = "App1Form"
            CType(Me.ImagenCabecera, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnCalcular_Primo As Button
        Friend WithEvents lblPrimo As Label
        Friend WithEvents tbxPrimo As TextBox
        Friend WithEvents ImagenCabecera As PictureBox
        Friend WithEvents App1Titulo As Label
    End Class
End Namespace
