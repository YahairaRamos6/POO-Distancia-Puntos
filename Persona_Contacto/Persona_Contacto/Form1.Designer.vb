<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Lbl_correo = New System.Windows.Forms.Label()
        Me.Txt_correo = New System.Windows.Forms.TextBox()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Lbl_Contacto = New System.Windows.Forms.Label()
        Me.Lbl_Persona = New System.Windows.Forms.Label()
        Me.Lbl_FN = New System.Windows.Forms.Label()
        Me.Lbl_AP = New System.Windows.Forms.Label()
        Me.Txt_AP = New System.Windows.Forms.TextBox()
        Me.Lbl_AM = New System.Windows.Forms.Label()
        Me.Txt_AM = New System.Windows.Forms.TextBox()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.Lbl_rfc = New System.Windows.Forms.Label()
        Me.Txt_rfc = New System.Windows.Forms.TextBox()
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Lbl_correo
        '
        Me.Lbl_correo.AutoSize = True
        Me.Lbl_correo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_correo.Location = New System.Drawing.Point(444, 206)
        Me.Lbl_correo.Name = "Lbl_correo"
        Me.Lbl_correo.Size = New System.Drawing.Size(68, 18)
        Me.Lbl_correo.TabIndex = 44
        Me.Lbl_correo.Text = "Correo:"
        '
        'Txt_correo
        '
        Me.Txt_correo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_correo.Location = New System.Drawing.Point(547, 200)
        Me.Txt_correo.Name = "Txt_correo"
        Me.Txt_correo.Size = New System.Drawing.Size(146, 27)
        Me.Txt_correo.TabIndex = 43
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefono.Location = New System.Drawing.Point(444, 152)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(84, 18)
        Me.Lbl_Telefono.TabIndex = 42
        Me.Lbl_Telefono.Text = "Telefono:"
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Telefono.Location = New System.Drawing.Point(547, 143)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(146, 27)
        Me.Txt_Telefono.TabIndex = 41
        '
        'Lbl_Contacto
        '
        Me.Lbl_Contacto.AutoSize = True
        Me.Lbl_Contacto.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Contacto.Location = New System.Drawing.Point(544, 82)
        Me.Lbl_Contacto.Name = "Lbl_Contacto"
        Me.Lbl_Contacto.Size = New System.Drawing.Size(87, 18)
        Me.Lbl_Contacto.TabIndex = 40
        Me.Lbl_Contacto.Text = "Contacto"
        '
        'Lbl_Persona
        '
        Me.Lbl_Persona.AutoSize = True
        Me.Lbl_Persona.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Persona.Location = New System.Drawing.Point(158, 82)
        Me.Lbl_Persona.Name = "Lbl_Persona"
        Me.Lbl_Persona.Size = New System.Drawing.Size(81, 18)
        Me.Lbl_Persona.TabIndex = 39
        Me.Lbl_Persona.Text = "Persona"
        '
        'Lbl_FN
        '
        Me.Lbl_FN.AutoSize = True
        Me.Lbl_FN.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FN.Location = New System.Drawing.Point(15, 308)
        Me.Lbl_FN.Name = "Lbl_FN"
        Me.Lbl_FN.Size = New System.Drawing.Size(186, 18)
        Me.Lbl_FN.TabIndex = 38
        Me.Lbl_FN.Text = "Fecha de Nacimiento:"
        '
        'Lbl_AP
        '
        Me.Lbl_AP.AutoSize = True
        Me.Lbl_AP.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AP.Location = New System.Drawing.Point(21, 206)
        Me.Lbl_AP.Name = "Lbl_AP"
        Me.Lbl_AP.Size = New System.Drawing.Size(150, 18)
        Me.Lbl_AP.TabIndex = 36
        Me.Lbl_AP.Text = "Apellido Paterno:"
        '
        'Txt_AP
        '
        Me.Txt_AP.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AP.Location = New System.Drawing.Point(203, 203)
        Me.Txt_AP.Name = "Txt_AP"
        Me.Txt_AP.Size = New System.Drawing.Size(146, 27)
        Me.Txt_AP.TabIndex = 35
        '
        'Lbl_AM
        '
        Me.Lbl_AM.AutoSize = True
        Me.Lbl_AM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AM.Location = New System.Drawing.Point(18, 261)
        Me.Lbl_AM.Name = "Lbl_AM"
        Me.Lbl_AM.Size = New System.Drawing.Size(153, 18)
        Me.Lbl_AM.TabIndex = 34
        Me.Lbl_AM.Text = "Apellido Materno:"
        '
        'Txt_AM
        '
        Me.Txt_AM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AM.Location = New System.Drawing.Point(203, 255)
        Me.Txt_AM.Name = "Txt_AM"
        Me.Txt_AM.Size = New System.Drawing.Size(146, 27)
        Me.Txt_AM.TabIndex = 33
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(21, 158)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(78, 18)
        Me.Lbl_Nombre.TabIndex = 32
        Me.Lbl_Nombre.Text = "Nombre:"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nombre.Location = New System.Drawing.Point(203, 149)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(146, 27)
        Me.Txt_Nombre.TabIndex = 31
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Calcular.Location = New System.Drawing.Point(480, 367)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(97, 45)
        Me.Btn_Calcular.TabIndex = 30
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Lbl_rfc
        '
        Me.Lbl_rfc.AutoSize = True
        Me.Lbl_rfc.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rfc.Location = New System.Drawing.Point(444, 258)
        Me.Lbl_rfc.Name = "Lbl_rfc"
        Me.Lbl_rfc.Size = New System.Drawing.Size(46, 18)
        Me.Lbl_rfc.TabIndex = 46
        Me.Lbl_rfc.Text = "RFC:"
        '
        'Txt_rfc
        '
        Me.Txt_rfc.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rfc.Location = New System.Drawing.Point(547, 252)
        Me.Txt_rfc.Name = "Txt_rfc"
        Me.Txt_rfc.Size = New System.Drawing.Size(146, 27)
        Me.Txt_rfc.TabIndex = 45
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Fecha.Location = New System.Drawing.Point(203, 303)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(146, 27)
        Me.DTP_Fecha.TabIndex = 47
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Location = New System.Drawing.Point(602, 367)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(97, 45)
        Me.Btn_Limpiar.TabIndex = 48
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 29)
        Me.Panel1.TabIndex = 49
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Location = New System.Drawing.Point(1, 427)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 29)
        Me.Panel2.TabIndex = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(744, 453)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.DTP_Fecha)
        Me.Controls.Add(Me.Lbl_rfc)
        Me.Controls.Add(Me.Txt_rfc)
        Me.Controls.Add(Me.Lbl_correo)
        Me.Controls.Add(Me.Txt_correo)
        Me.Controls.Add(Me.Lbl_Telefono)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.Lbl_Contacto)
        Me.Controls.Add(Me.Lbl_Persona)
        Me.Controls.Add(Me.Lbl_FN)
        Me.Controls.Add(Me.Lbl_AP)
        Me.Controls.Add(Me.Txt_AP)
        Me.Controls.Add(Me.Lbl_AM)
        Me.Controls.Add(Me.Txt_AM)
        Me.Controls.Add(Me.Lbl_Nombre)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Btn_Calcular)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Lbl_correo As Label
    Private WithEvents Txt_correo As TextBox
    Private WithEvents Lbl_Telefono As Label
    Private WithEvents Txt_Telefono As TextBox
    Private WithEvents Lbl_Contacto As Label
    Private WithEvents Lbl_Persona As Label
    Private WithEvents Lbl_FN As Label
    Private WithEvents Lbl_AP As Label
    Private WithEvents Txt_AP As TextBox
    Private WithEvents Lbl_AM As Label
    Private WithEvents Txt_AM As TextBox
    Private WithEvents Lbl_Nombre As Label
    Private WithEvents Txt_Nombre As TextBox
    Private WithEvents Btn_Calcular As Button
    Private WithEvents Lbl_rfc As Label
    Private WithEvents Txt_rfc As TextBox
    Friend WithEvents DTP_Fecha As DateTimePicker
    Private WithEvents Btn_Limpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
