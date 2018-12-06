'FORMULARIO CONSULTA PRODUCTO, BUSCA EL PRODUCTO POR MEDIO DEL CODIGO 
' VARIABLES DEL FORMULARIO:
'  lv_productos = se muestra la info. del producto
'  txtCodProd = se coloca el codigo del producto para buscar


'D = existencia (5)
'B = punto de reorden (10)
'Te = Tiempo de entrega promediado en días (30)
' 30 * (5/10) = 15^3 -> 3,375 unidades a pedir 


Public Class ConsultaProducto
    Dim prod As Producto.ProductoSoapClient = New Producto.ProductoSoapClient()

    'BOTON BUSCAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim regiProd As Producto.inventarioProductos = New Producto.inventarioProductos()
        Dim lista As ListViewItem
        Try
            'ENVIA EL CODIGO AL METODO QUE CONSULTA EN LA BD
            regiProd = prod.Feature(txtCodProd.Text)

            lv_productos.Visible = True
            lv_productos.Items.Clear()

            lista = New ListViewItem("*" & regiProd.Description)
            lista.SubItems.Add("*" & regiProd.SalePrice)
            lista.SubItems.Add("*" & regiProd.CantExistence)
            lv_productos.Items.Add(lista) ' MUESTRA LA CONSULTA 

            Borrar()
        Catch ex As Exception
            MsgBox("Producto no encontrado")
        End Try
    End Sub
    'BORRA EL TEXTO DEL TEXTVIEW txtCodProd
    Public Function Borrar()
        txtCodProd.Text = ""
    End Function
End Class