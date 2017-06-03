Namespace NavajaSuiza.Application3
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class App3Form
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App3Form))
            Me.btnDivide_Billetes = New System.Windows.Forms.Button()
            Me.lblBilletes = New System.Windows.Forms.Label()
            Me.tbxDinero = New System.Windows.Forms.TextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnDivide_Billetes
            '
            Me.btnDivide_Billetes.Location = New System.Drawing.Point(107, 264)
            Me.btnDivide_Billetes.Name = "btnDivide_Billetes"
            Me.btnDivide_Billetes.Size = New System.Drawing.Size(220, 23)
            Me.btnDivide_Billetes.TabIndex = 0
            Me.btnDivide_Billetes.Text = "Dividir en Billetes"
            Me.btnDivide_Billetes.UseVisualStyleBackColor = True
            '
            'lblBilletes
            '
            Me.lblBilletes.AutoSize = True
            Me.lblBilletes.Location = New System.Drawing.Point(142, 302)
            Me.lblBilletes.Name = "lblBilletes"
            Me.lblBilletes.Size = New System.Drawing.Size(50, 13)
            Me.lblBilletes.TabIndex = 1
            Me.lblBilletes.Text = "lblBileltes"
            Me.lblBilletes.Visible = False
            '
            'tbxDinero
            '
            Me.tbxDinero.Location = New System.Drawing.Point(106, 217)
            Me.tbxDinero.MaxLength = 10
            Me.tbxDinero.Name = "tbxDinero"
            Me.tbxDinero.Size = New System.Drawing.Size(221, 20)
            Me.tbxDinero.TabIndex = 2
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(416, 144)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 169)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(414, 32)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Conversor cantidad a Billetes"
            '
            'App3Form
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(440, 417)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.tbxDinero)
            Me.Controls.Add(Me.lblBilletes)
            Me.Controls.Add(Me.btnDivide_Billetes)
            Me.Name = "App3Form"
            Me.Text = "App3Form"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnDivide_Billetes As Button
        Friend WithEvents lblBilletes As Label
        Friend WithEvents tbxDinero As TextBox
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label1 As Label
    End Class
End Namespace
