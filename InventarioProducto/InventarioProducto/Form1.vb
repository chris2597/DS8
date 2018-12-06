Public Class form1
    Private Sub ConsultarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarProductosToolStripMenuItem.Click
        Dim cons_prod As ConsultaProducto = New ConsultaProducto()
        cons_prod.MdiParent = Me
        cons_prod.WindowState = FormWindowState.Maximized
        cons_prod.Show()
    End Sub


    Private Sub CantidadDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeProductosToolStripMenuItem.Click
        Dim cant_prod As cant_productos = New cant_productos()
        cant_prod.MdiParent = Me
        cant_prod.WindowState = FormWindowState.Maximized
        cant_prod.Show()
    End Sub

    Private Sub cerrarVentanas()
        For Each ventana As Form In Me.MdiChildren
            ventana.Close()
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
