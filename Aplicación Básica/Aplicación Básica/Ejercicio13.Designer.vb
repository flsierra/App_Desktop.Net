<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio13
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicio13))
        Me.FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.FechaActual = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblCumpleaños = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.Location = New System.Drawing.Point(103, 77)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.FechaNacimiento.TabIndex = 0
        '
        'FechaActual
        '
        Me.FechaActual.Location = New System.Drawing.Point(103, 126)
        Me.FechaActual.Name = "FechaActual"
        Me.FechaActual.Size = New System.Drawing.Size(200, 20)
        Me.FechaActual.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(122, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblCumpleaños
        '
        Me.LblCumpleaños.AutoSize = True
        Me.LblCumpleaños.Location = New System.Drawing.Point(100, 322)
        Me.LblCumpleaños.Name = "LblCumpleaños"
        Me.LblCumpleaños.Size = New System.Drawing.Size(0, 13)
        Me.LblCumpleaños.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(303, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Ejercicio13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(564, 382)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LblCumpleaños)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FechaActual)
        Me.Controls.Add(Me.FechaNacimiento)
        Me.Name = "Ejercicio13"
        Me.Text = "Ejercicio13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblCumpleaños As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
