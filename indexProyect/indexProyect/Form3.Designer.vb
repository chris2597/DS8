'
' Creado por SharpDevelop.
' Usuario: chjimenez
' Fecha: 12/06/2018
' Hora: 03:09 PM
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class Form3
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label4 = New System.Windows.Forms.Label()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(129, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(563, 44)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Cantidad a Pedir por Producto"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(129, 172)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(211, 23)
		Me.label2.TabIndex = 6
		Me.label2.Text = "Ingrese código del producto"
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(129, 198)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(140, 20)
		Me.textBox1.TabIndex = 7
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(129, 235)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(93, 30)
		Me.button1.TabIndex = 8
		Me.button1.Text = "Buscar"
		Me.button1.UseVisualStyleBackColor = true
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(129, 315)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 9
		Me.label4.Text = "Descripción"
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(129, 341)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(93, 20)
		Me.textBox3.TabIndex = 13
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(226, 315)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(146, 23)
		Me.label6.TabIndex = 14
		Me.label6.Text = "Cantidad en Existencia"
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(247, 341)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(93, 20)
		Me.textBox2.TabIndex = 15
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(378, 315)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(127, 23)
		Me.label7.TabIndex = 16
		Me.label7.Text = "Punto de Reorden"
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(378, 341)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(93, 20)
		Me.textBox4.TabIndex = 17
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(511, 315)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(116, 23)
		Me.label3.TabIndex = 18
		Me.label3.Text = "Cantidad a Pedir"
		'
		'textBox5
		'
		Me.textBox5.Location = New System.Drawing.Point(511, 341)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(93, 20)
		Me.textBox5.TabIndex = 19
		'
		'Form3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(823, 413)
		Me.Controls.Add(Me.textBox5)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.textBox4)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "Form3"
		Me.Text = "Cantidad a Pedir"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox5 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private textBox3 As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private textBox1 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
