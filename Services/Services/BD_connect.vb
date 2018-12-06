'
' Creado por SharpDevelop.
' Usuario: chjimenez
' Fecha: 12/06/2018
' Hora: 12:52 PM
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Imports System
Imports MySql.Data.MySqlClient

Public Class BD_connect
    Dim connectionString As String
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim sql As String
    Dim sqlReader As MySqlDataReader


    Public Sub New()
        connectionString = "Data source=localhost; Database=Producto; User ID=root;password=root"
    End Sub

    'CONEXION A LA BASE DE DATOS
    Public Sub OpenBD()
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            MsgBox("Error al tener acceso a la Base de Datos" & ex.ToString())
        End Try
    End Sub

    Public Sub executeReader(sql As String)
        Try
            OpenBD()
            command = New MySqlCommand(sql, connection)
            sqlReader = command.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error al leer consulta" & ex.ToString())
        End Try
    End Sub

    Public Function Read()
        Return sqlReader.Read()
    End Function

    Public Function Item(campo As String) As String
        Return sqlReader.Item(campo)
    End Function

    Public Sub executeNonQuery(sql As String)
        Try
            OpenBD()
            command = New MySqlCommand(sql, connection)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta " + ex.ToString())
        End Try
    End Sub

    Public Sub CloseBD()
        connection.Close()
    End Sub

End Class

