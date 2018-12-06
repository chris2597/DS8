'
' Creado por SharpDevelop.
' Usuario: chjimenez
' Fecha: 12/06/2018
' Hora: 12:05 PM
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Imports System.Data
Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

<WebService> _
Public Class Soap
	Inherits System.Web.Services.WebService
	''' <summary>
	''' Logs into the web service
	''' </summary>
	''' <param name="userName">The User Name to login in as</param>
	''' <param name="password">User's password</param>
	''' <returns>True on successful login.</returns>
	<WebMethod(EnableSession := True)> _
	Public Function Login(userName As String, password As String) As Boolean
		'NOTE: There are better ways of doing authentication. This is just illustrates Session usage.
		Me.UserName = userName
		Return True
	End Function

	''' <summary>
	''' Logs out of the Session.
	''' </summary>
	<WebMethod(EnableSession := True)> _
	Public Sub Logout()
		Context.Session.Abandon()
	End Sub

	''' <summary>
	''' UserName of the logged in user.
	''' </summary>
	Private Property UserName() As String
		Get
			Return DirectCast(Context.Session("User"), String)
		End Get
		Set
			Context.Session("User") = value
		End Set
	End Property
End Class
