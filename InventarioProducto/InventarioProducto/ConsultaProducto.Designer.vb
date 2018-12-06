<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaProducto
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.lv_productos = New System.Windows.Forms.ListView()
        Me.lv_des = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_sale = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_cant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "codigo producto:"
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(200, 152)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(204, 20)
        Me.txtCodProd.TabIndex = 8
        '
        'lv_productos
        '
        Me.lv_productos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lv_des, Me.lv_sale, Me.lv_cant})
        Me.lv_productos.Location = New System.Drawing.Point(47, 209)
        Me.lv_productos.Name = "lv_productos"
        Me.lv_productos.Size = New System.Drawing.Size(564, 64)
        Me.lv_productos.TabIndex = 9
        Me.lv_productos.UseCompatibleStateImageBehavior = False
        Me.lv_productos.View = System.Windows.Forms.View.Details
        Me.lv_productos.Visible = False
        '
        'lv_des
        '
        Me.lv_des.Text = "DESCRIPCION"
        Me.lv_des.Width = 400
        '
        'lv_sale
        '
        Me.lv_sale.Text = "PRECIO"
        Me.lv_sale.Width = 80
        '
        'lv_cant
        '
        Me.lv_cant.Text = "CANTIDAD"
        Me.lv_cant.Width = 80
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(457, 149)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 10
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'ConsultaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 316)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.lv_productos)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ConsultaProducto"
        Me.Text = "ConsultaProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lv_des As ColumnHeader
    Friend WithEvents lv_sale As ColumnHeader
    Friend WithEvents lv_cant As ColumnHeader
    Friend WithEvents lv_productos As ListView
End Class
