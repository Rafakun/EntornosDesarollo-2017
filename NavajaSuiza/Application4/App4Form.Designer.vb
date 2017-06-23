Namespace Application4
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class App4Form
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App4Form))
            Me.btnCalcular_Iva = New System.Windows.Forms.Button()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.txtCalculaIva = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.cbxIVA = New System.Windows.Forms.ComboBox()
            Me.App4Titulo = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCalcular_Iva
            '
            Me.btnCalcular_Iva.Location = New System.Drawing.Point(131, 245)
            Me.btnCalcular_Iva.Name = "btnCalcular_Iva"
            Me.btnCalcular_Iva.Size = New System.Drawing.Size(220, 23)
            Me.btnCalcular_Iva.TabIndex = 0
            Me.btnCalcular_Iva.Text = "Calcular IVA"
            Me.btnCalcular_Iva.UseVisualStyleBackColor = True
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(104, 280)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(78, 24)
            Me.lblTotal.TabIndex = 1
            Me.lblTotal.Text = "lblTotal"
            Me.lblTotal.Visible = False
            '
            'tbxCalculaIVA
            '
            Me.txtCalculaIva.Location = New System.Drawing.Point(131, 209)
            Me.txtCalculaIva.MaxLength = 10
            Me.txtCalculaIva.Name = "tbxCalculaIVA"
            Me.txtCalculaIva.Size = New System.Drawing.Size(155, 20)
            Me.txtCalculaIva.TabIndex = 2
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(4, -2)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(473, 157)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'cbxIVA
            '
            Me.cbxIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbxIVA.FormattingEnabled = True
            Me.cbxIVA.Items.AddRange(New Object() {"0%", "4%", "10%", "21%"})
            Me.cbxIVA.Location = New System.Drawing.Point(292, 209)
            Me.cbxIVA.Name = "cbxIVA"
            Me.cbxIVA.Size = New System.Drawing.Size(59, 21)
            Me.cbxIVA.TabIndex = 4
            '
            'App4Titulo
            '
            Me.App4Titulo.AutoSize = True
            Me.App4Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.App4Titulo.Location = New System.Drawing.Point(160, 160)
            Me.App4Titulo.Name = "App4Titulo"
            Me.App4Titulo.Size = New System.Drawing.Size(174, 32)
            Me.App4Titulo.TabIndex = 8
            Me.App4Titulo.Text = "Cálculo IVA"
            '
            'App4Form
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(483, 356)
            Me.Controls.Add(Me.App4Titulo)
            Me.Controls.Add(Me.cbxIVA)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.txtCalculaIva)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.btnCalcular_Iva)
            Me.Name = "App4Form"
            Me.Text = "App1Form"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnCalcular_Iva As Button
        Friend WithEvents lblTotal As Label
        Friend WithEvents txtCalculaIva As TextBox
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents cbxIVA As ComboBox
        Friend WithEvents App4Titulo As Label
    End Class
End Namespace
