﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace PedidoProd
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="inventarioProductos", [Namespace]:="http://tempuri.org/"),  _
     System.SerializableAttribute()>  _
    Partial Public Class inventarioProductos
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CodProductField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DescriptionField As String
        
        Private CantExistenceField As Integer
        
        Private CantReOrdenField As Integer
        
        Private SalePriceField As Decimal
        
        Private CantPedirField As Decimal
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property CodProduct() As String
            Get
                Return Me.CodProductField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CodProductField, value) <> true) Then
                    Me.CodProductField = value
                    Me.RaisePropertyChanged("CodProduct")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false)>  _
        Public Property Description() As String
            Get
                Return Me.DescriptionField
            End Get
            Set
                If (Object.ReferenceEquals(Me.DescriptionField, value) <> true) Then
                    Me.DescriptionField = value
                    Me.RaisePropertyChanged("Description")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=2)>  _
        Public Property CantExistence() As Integer
            Get
                Return Me.CantExistenceField
            End Get
            Set
                If (Me.CantExistenceField.Equals(value) <> true) Then
                    Me.CantExistenceField = value
                    Me.RaisePropertyChanged("CantExistence")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=3)>  _
        Public Property CantReOrden() As Integer
            Get
                Return Me.CantReOrdenField
            End Get
            Set
                If (Me.CantReOrdenField.Equals(value) <> true) Then
                    Me.CantReOrdenField = value
                    Me.RaisePropertyChanged("CantReOrden")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=4)>  _
        Public Property SalePrice() As Decimal
            Get
                Return Me.SalePriceField
            End Get
            Set
                If (Me.SalePriceField.Equals(value) <> true) Then
                    Me.SalePriceField = value
                    Me.RaisePropertyChanged("SalePrice")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true, Order:=5)>  _
        Public Property CantPedir() As Decimal
            Get
                Return Me.CantPedirField
            End Get
            Set
                If (Me.CantPedirField.Equals(value) <> true) Then
                    Me.CantPedirField = value
                    Me.RaisePropertyChanged("CantPedir")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="PedidoProd.WebService2Soap")>  _
    Public Interface WebService2Soap
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento codProducto del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/PointReorder", ReplyAction:="*")>  _
        Function PointReorder(ByVal request As PedidoProd.PointReorderRequest) As PedidoProd.PointReorderResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/PointReorder", ReplyAction:="*")>  _
        Function PointReorderAsync(ByVal request As PedidoProd.PointReorderRequest) As System.Threading.Tasks.Task(Of PedidoProd.PointReorderResponse)
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento codProducto del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CantPedir", ReplyAction:="*")>  _
        Function CantPedir(ByVal request As PedidoProd.CantPedirRequest) As PedidoProd.CantPedirResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CantPedir", ReplyAction:="*")>  _
        Function CantPedirAsync(ByVal request As PedidoProd.CantPedirRequest) As System.Threading.Tasks.Task(Of PedidoProd.CantPedirResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class PointReorderRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="PointReorder", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PedidoProd.PointReorderRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PedidoProd.PointReorderRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class PointReorderRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public codProducto As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal codProducto As String)
            MyBase.New
            Me.codProducto = codProducto
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class PointReorderResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="PointReorderResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PedidoProd.PointReorderResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PedidoProd.PointReorderResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class PointReorderResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public PointReorderResult As PedidoProd.inventarioProductos
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal PointReorderResult As PedidoProd.inventarioProductos)
            MyBase.New
            Me.PointReorderResult = PointReorderResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CantPedirRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="CantPedir", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PedidoProd.CantPedirRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PedidoProd.CantPedirRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class CantPedirRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public codProducto As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal codProducto As String)
            MyBase.New
            Me.codProducto = codProducto
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CantPedirResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="CantPedirResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As PedidoProd.CantPedirResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As PedidoProd.CantPedirResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class CantPedirResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public CantPedirResult As PedidoProd.inventarioProductos
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal CantPedirResult As PedidoProd.inventarioProductos)
            MyBase.New
            Me.CantPedirResult = CantPedirResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebService2SoapChannel
        Inherits PedidoProd.WebService2Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebService2SoapClient
        Inherits System.ServiceModel.ClientBase(Of PedidoProd.WebService2Soap)
        Implements PedidoProd.WebService2Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PedidoProd_WebService2Soap_PointReorder(ByVal request As PedidoProd.PointReorderRequest) As PedidoProd.PointReorderResponse Implements PedidoProd.WebService2Soap.PointReorder
            Return MyBase.Channel.PointReorder(request)
        End Function
        
        Public Function PointReorder(ByVal codProducto As String) As PedidoProd.inventarioProductos
            Dim inValue As PedidoProd.PointReorderRequest = New PedidoProd.PointReorderRequest()
            inValue.Body = New PedidoProd.PointReorderRequestBody()
            inValue.Body.codProducto = codProducto
            Dim retVal As PedidoProd.PointReorderResponse = CType(Me,PedidoProd.WebService2Soap).PointReorder(inValue)
            Return retVal.Body.PointReorderResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PedidoProd_WebService2Soap_PointReorderAsync(ByVal request As PedidoProd.PointReorderRequest) As System.Threading.Tasks.Task(Of PedidoProd.PointReorderResponse) Implements PedidoProd.WebService2Soap.PointReorderAsync
            Return MyBase.Channel.PointReorderAsync(request)
        End Function
        
        Public Function PointReorderAsync(ByVal codProducto As String) As System.Threading.Tasks.Task(Of PedidoProd.PointReorderResponse)
            Dim inValue As PedidoProd.PointReorderRequest = New PedidoProd.PointReorderRequest()
            inValue.Body = New PedidoProd.PointReorderRequestBody()
            inValue.Body.codProducto = codProducto
            Return CType(Me,PedidoProd.WebService2Soap).PointReorderAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PedidoProd_WebService2Soap_CantPedir(ByVal request As PedidoProd.CantPedirRequest) As PedidoProd.CantPedirResponse Implements PedidoProd.WebService2Soap.CantPedir
            Return MyBase.Channel.CantPedir(request)
        End Function
        
        Public Function CantPedir(ByVal codProducto As String) As PedidoProd.inventarioProductos
            Dim inValue As PedidoProd.CantPedirRequest = New PedidoProd.CantPedirRequest()
            inValue.Body = New PedidoProd.CantPedirRequestBody()
            inValue.Body.codProducto = codProducto
            Dim retVal As PedidoProd.CantPedirResponse = CType(Me,PedidoProd.WebService2Soap).CantPedir(inValue)
            Return retVal.Body.CantPedirResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function PedidoProd_WebService2Soap_CantPedirAsync(ByVal request As PedidoProd.CantPedirRequest) As System.Threading.Tasks.Task(Of PedidoProd.CantPedirResponse) Implements PedidoProd.WebService2Soap.CantPedirAsync
            Return MyBase.Channel.CantPedirAsync(request)
        End Function
        
        Public Function CantPedirAsync(ByVal codProducto As String) As System.Threading.Tasks.Task(Of PedidoProd.CantPedirResponse)
            Dim inValue As PedidoProd.CantPedirRequest = New PedidoProd.CantPedirRequest()
            inValue.Body = New PedidoProd.CantPedirRequestBody()
            inValue.Body.codProducto = codProducto
            Return CType(Me,PedidoProd.WebService2Soap).CantPedirAsync(inValue)
        End Function
    End Class
End Namespace
