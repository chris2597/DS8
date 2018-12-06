'
' Creado por SharpDevelop.
' Usuario: chjimenez
' Fecha: 12/06/2018
' Hora: 02:57 PM
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.label1 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.pictureBox2 = New System.Windows.Forms.PictureBox()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.menuStrip1.SuspendLayout
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(93, 47)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(589, 44)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Proyecto #3"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(617, 115)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(110, 109)
		Me.pictureBox1.TabIndex = 3
		Me.pictureBox1.TabStop = false
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.White
		Me.label2.Location = New System.Drawing.Point(206, 119)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(361, 105)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Christopher Jiménez "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"8-922-2240"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"1LS-232"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.ForeColor = System.Drawing.Color.White
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(157, 20)
		Me.toolStripMenuItem1.Text = "Información por Producto"
		AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.ToolStripMenuItem1Click
		'
		'toolStripMenuItem2
		'
		Me.toolStripMenuItem2.ForeColor = System.Drawing.Color.White
		Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
		Me.toolStripMenuItem2.Size = New System.Drawing.Size(106, 20)
		Me.toolStripMenuItem2.Text = "Cantidad a Pedir"
		AddHandler Me.toolStripMenuItem2.Click, AddressOf Me.ToolStripMenuItem2Click
		'
		'menuStrip1
		'
		Me.menuStrip1.BackColor = System.Drawing.Color.Black
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.toolStripMenuItem2})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(784, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'pictureBox2
		'
		Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"),System.Drawing.Image)
		Me.pictureBox2.Location = New System.Drawing.Point(59, 115)
		Me.pictureBox2.Name = "pictureBox2"
		Me.pictureBox2.Size = New System.Drawing.Size(105, 103)
		Me.pictureBox2.TabIndex = 5
		Me.pictureBox2.TabStop = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(784, 328)
		Me.Controls.Add(Me.pictureBox2)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.menuStrip1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "indexProyect"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		CType(Me.pictureBox2,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private label2 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label1 As System.Windows.Forms.Label
	Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	

End Class
