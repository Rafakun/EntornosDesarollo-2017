Namespace Main
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.MainApp1 = New System.Windows.Forms.Button()
            Me.MainApp2 = New System.Windows.Forms.Button()
            Me.MainApp3 = New System.Windows.Forms.Button()
            Me.MainApp4 = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MainApp1
            '
            Me.MainApp1.Location = New System.Drawing.Point(44, 241)
            Me.MainApp1.Name = "MainApp1"
            Me.MainApp1.Size = New System.Drawing.Size(97, 45)
            Me.MainApp1.TabIndex = 0
            Me.MainApp1.Text = "Aplicación 1"
            Me.MainApp1.UseVisualStyleBackColor = True
            '
            'MainApp2
            '
            Me.MainApp2.Location = New System.Drawing.Point(196, 241)
            Me.MainApp2.Name = "MainApp2"
            Me.MainApp2.Size = New System.Drawing.Size(97, 45)
            Me.MainApp2.TabIndex = 1
            Me.MainApp2.Text = "Aplicación 2"
            Me.MainApp2.UseVisualStyleBackColor = True
            '
            'MainApp3
            '
            Me.MainApp3.Location = New System.Drawing.Point(355, 241)
            Me.MainApp3.Name = "MainApp3"
            Me.MainApp3.Size = New System.Drawing.Size(97, 45)
            Me.MainApp3.TabIndex = 2
            Me.MainApp3.Text = "Aplicación 3"
            Me.MainApp3.UseVisualStyleBackColor = True
            '
            'MainApp4
            '
            Me.MainApp4.Location = New System.Drawing.Point(509, 241)
            Me.MainApp4.Name = "MainApp4"
            Me.MainApp4.Size = New System.Drawing.Size(97, 45)
            Me.MainApp4.TabIndex = 3
            Me.MainApp4.Text = "Aplicación 4"
            Me.MainApp4.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(623, 233)
            Me.PictureBox1.TabIndex = 4
            Me.PictureBox1.TabStop = False
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(645, 298)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.MainApp4)
            Me.Controls.Add(Me.MainApp3)
            Me.Controls.Add(Me.MainApp2)
            Me.Controls.Add(Me.MainApp1)
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainApp1 As Button
        Friend WithEvents MainApp2 As Button
        Friend WithEvents MainApp3 As Button
        Friend WithEvents MainApp4 As Button
        Friend WithEvents PictureBox1 As PictureBox
    End Class
End Namespace
