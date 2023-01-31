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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Lbl_Puntoa = New System.Windows.Forms.Label()
        Me.Lbl_PuntoB = New System.Windows.Forms.Label()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Txt_x1 = New System.Windows.Forms.TextBox()
        Me.Text_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_x1 = New System.Windows.Forms.Label()
        Me.Lbl_y1 = New System.Windows.Forms.Label()
        Me.Txt_y1 = New System.Windows.Forms.TextBox()
        Me.Lbl_y2 = New System.Windows.Forms.Label()
        Me.Txt_y2 = New System.Windows.Forms.TextBox()
        Me.Lbl_x2 = New System.Windows.Forms.Label()
        Me.Txt_x2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Titulo.Location = New System.Drawing.Point(201, 58)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(306, 35)
        Me.Lbl_Titulo.TabIndex = 0
        Me.Lbl_Titulo.Text = "DISTANCIA ENTRE PUNTOS"
        '
        'Lbl_Puntoa
        '
        Me.Lbl_Puntoa.AutoSize = True
        Me.Lbl_Puntoa.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Puntoa.Location = New System.Drawing.Point(67, 131)
        Me.Lbl_Puntoa.Name = "Lbl_Puntoa"
        Me.Lbl_Puntoa.Size = New System.Drawing.Size(84, 28)
        Me.Lbl_Puntoa.TabIndex = 1
        Me.Lbl_Puntoa.Text = "Punto A:"
        '
        'Lbl_PuntoB
        '
        Me.Lbl_PuntoB.AutoSize = True
        Me.Lbl_PuntoB.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PuntoB.Location = New System.Drawing.Point(345, 131)
        Me.Lbl_PuntoB.Name = "Lbl_PuntoB"
        Me.Lbl_PuntoB.Size = New System.Drawing.Size(84, 28)
        Me.Lbl_PuntoB.TabIndex = 2
        Me.Lbl_PuntoB.Text = "Punto B:"
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Resultado.Location = New System.Drawing.Point(134, 339)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(96, 28)
        Me.Lbl_Resultado.TabIndex = 3
        Me.Lbl_Resultado.Text = "Resultado:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Thistle
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 24)
        Me.Panel1.TabIndex = 4
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Calcular.Location = New System.Drawing.Point(459, 325)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(107, 42)
        Me.Btn_Calcular.TabIndex = 6
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Location = New System.Drawing.Point(603, 325)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(99, 42)
        Me.Btn_Limpiar.TabIndex = 7
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Txt_x1
        '
        Me.Txt_x1.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_x1.Location = New System.Drawing.Point(72, 181)
        Me.Txt_x1.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_x1.Name = "Txt_x1"
        Me.Txt_x1.Size = New System.Drawing.Size(104, 36)
        Me.Txt_x1.TabIndex = 9
        '
        'Text_Resultado
        '
        Me.Text_Resultado.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Resultado.Location = New System.Drawing.Point(237, 329)
        Me.Text_Resultado.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_Resultado.Name = "Text_Resultado"
        Me.Text_Resultado.Size = New System.Drawing.Size(104, 36)
        Me.Text_Resultado.TabIndex = 11
        '
        'Lbl_x1
        '
        Me.Lbl_x1.AutoSize = True
        Me.Lbl_x1.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_x1.Location = New System.Drawing.Point(29, 171)
        Me.Lbl_x1.Name = "Lbl_x1"
        Me.Lbl_x1.Size = New System.Drawing.Size(41, 28)
        Me.Lbl_x1.TabIndex = 16
        Me.Lbl_x1.Text = "X1:"
        '
        'Lbl_y1
        '
        Me.Lbl_y1.AutoSize = True
        Me.Lbl_y1.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_y1.Location = New System.Drawing.Point(29, 225)
        Me.Lbl_y1.Name = "Lbl_y1"
        Me.Lbl_y1.Size = New System.Drawing.Size(40, 28)
        Me.Lbl_y1.TabIndex = 18
        Me.Lbl_y1.Text = "Y1:"
        '
        'Txt_y1
        '
        Me.Txt_y1.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_y1.Location = New System.Drawing.Point(72, 235)
        Me.Txt_y1.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_y1.Name = "Txt_y1"
        Me.Txt_y1.Size = New System.Drawing.Size(104, 36)
        Me.Txt_y1.TabIndex = 17
        '
        'Lbl_y2
        '
        Me.Lbl_y2.AutoSize = True
        Me.Lbl_y2.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_y2.Location = New System.Drawing.Point(300, 235)
        Me.Lbl_y2.Name = "Lbl_y2"
        Me.Lbl_y2.Size = New System.Drawing.Size(40, 28)
        Me.Lbl_y2.TabIndex = 22
        Me.Lbl_y2.Text = "Y2:"
        '
        'Txt_y2
        '
        Me.Txt_y2.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_y2.Location = New System.Drawing.Point(350, 232)
        Me.Txt_y2.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_y2.Name = "Txt_y2"
        Me.Txt_y2.Size = New System.Drawing.Size(104, 36)
        Me.Txt_y2.TabIndex = 21
        '
        'Lbl_x2
        '
        Me.Lbl_x2.AutoSize = True
        Me.Lbl_x2.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_x2.Location = New System.Drawing.Point(300, 181)
        Me.Lbl_x2.Name = "Lbl_x2"
        Me.Lbl_x2.Size = New System.Drawing.Size(41, 28)
        Me.Lbl_x2.TabIndex = 20
        Me.Lbl_x2.Text = "X2:"
        '
        'Txt_x2
        '
        Me.Txt_x2.Font = New System.Drawing.Font("Segoe Print", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_x2.Location = New System.Drawing.Point(350, 178)
        Me.Txt_x2.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_x2.Name = "Txt_x2"
        Me.Txt_x2.Size = New System.Drawing.Size(104, 36)
        Me.Txt_x2.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Thistle
        Me.Panel2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 402)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 21)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(471, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 425)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Lbl_y2)
        Me.Controls.Add(Me.Txt_y2)
        Me.Controls.Add(Me.Lbl_x2)
        Me.Controls.Add(Me.Txt_x2)
        Me.Controls.Add(Me.Lbl_y1)
        Me.Controls.Add(Me.Txt_y1)
        Me.Controls.Add(Me.Lbl_x1)
        Me.Controls.Add(Me.Text_Resultado)
        Me.Controls.Add(Me.Txt_x1)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Calcular)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Lbl_PuntoB)
        Me.Controls.Add(Me.Lbl_Puntoa)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "DistanciaP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Lbl_Puntoa As Label
    Friend WithEvents Lbl_PuntoB As Label
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Calcular As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Txt_x1 As TextBox
    Friend WithEvents Text_Resultado As TextBox
    Friend WithEvents Lbl_x1 As Label
    Friend WithEvents Lbl_y1 As Label
    Friend WithEvents Txt_y1 As TextBox
    Friend WithEvents Lbl_y2 As Label
    Friend WithEvents Txt_y2 As TextBox
    Friend WithEvents Lbl_x2 As Label
    Friend WithEvents Txt_x2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
