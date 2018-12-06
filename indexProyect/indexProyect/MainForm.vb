'
' Creado por SharpDevelop.
' Usuario: chjimenez
' Fecha: 12/06/2018
' Hora: 02:57 PM
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub

	
	Sub AcerdaDeToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim infoForm As Form1 = New Form1()
		infoForm.Show
	End Sub
	
	Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs)
		Dim productInformationForm As Form2 = New Form2()
		productInformationForm.Show()	
	End Sub
	
	
	
	Sub ToolStripMenuItem2Click(sender As Object, e As EventArgs)
		Dim productInformationForm As Form3 = New Form3()
		productInformationForm.Show()			
	End Sub
End Class
