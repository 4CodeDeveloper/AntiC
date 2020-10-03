<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataGridViewExample
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgProducto = New System.Windows.Forms.DataGridView()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtgMovimientos = New System.Windows.Forms.DataGridView()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.lblMovimiento = New System.Windows.Forms.Label()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblFechaMovimiento = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblPrecioUnitario = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblPresentacion = New System.Windows.Forms.Label()
        Me.txtMovimiento = New System.Windows.Forms.TextBox()
        Me.txtTipoMovimiento = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtFechaMovimiento = New System.Windows.Forms.TextBox()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DSDataProyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDataProy = New EjemploGridDB.DSDataProy()
        Me.ProductoTableAdapter = New EjemploGridDB.DSDataProyTableAdapters.ProductoTableAdapter()
        Me.DSDataProy1 = New EjemploGridDB.DSDataProy()
        Me.ProductoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dtgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DSDataProyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDataProy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDataProy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgProducto
        '
        Me.dtgProducto.AllowUserToAddRows = False
        Me.dtgProducto.AllowUserToDeleteRows = False
        Me.dtgProducto.AllowUserToResizeColumns = False
        Me.dtgProducto.AllowUserToResizeRows = False
        Me.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgProducto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProducto.Location = New System.Drawing.Point(20, 61)
        Me.dtgProducto.MultiSelect = False
        Me.dtgProducto.Name = "dtgProducto"
        Me.dtgProducto.ReadOnly = True
        Me.dtgProducto.Size = New System.Drawing.Size(453, 351)
        Me.dtgProducto.TabIndex = 0
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.DSDataProyBindingSource
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        Me.ProductoBindingSource1.DataSource = Me.DSDataProyBindingSource
        '
        'ProductoBindingSource3
        '
        Me.ProductoBindingSource3.DataMember = "Producto"
        Me.ProductoBindingSource3.DataSource = Me.DSDataProyBindingSource
        '
        'dtgMovimientos
        '
        Me.dtgMovimientos.AllowUserToAddRows = False
        Me.dtgMovimientos.AllowUserToDeleteRows = False
        Me.dtgMovimientos.AllowUserToResizeColumns = False
        Me.dtgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMovimientos.Location = New System.Drawing.Point(21, 61)
        Me.dtgMovimientos.MultiSelect = False
        Me.dtgMovimientos.Name = "dtgMovimientos"
        Me.dtgMovimientos.ReadOnly = True
        Me.dtgMovimientos.Size = New System.Drawing.Size(453, 351)
        Me.dtgMovimientos.TabIndex = 1
        '
        'lblDetalles
        '
        Me.lblDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalles.Location = New System.Drawing.Point(-3, 475)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.Size = New System.Drawing.Size(1039, 46)
        Me.lblDetalles.TabIndex = 3
        Me.lblDetalles.Text = "Detalles"
        Me.lblDetalles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMovimiento
        '
        Me.lblMovimiento.AutoSize = True
        Me.lblMovimiento.Location = New System.Drawing.Point(123, 550)
        Me.lblMovimiento.Name = "lblMovimiento"
        Me.lblMovimiento.Size = New System.Drawing.Size(67, 13)
        Me.lblMovimiento.TabIndex = 4
        Me.lblMovimiento.Text = "Movimiento: "
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.AutoSize = True
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(123, 583)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(91, 13)
        Me.lblTipoMovimiento.TabIndex = 4
        Me.lblTipoMovimiento.Text = "Tipo Movimiento: "
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(123, 613)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(55, 13)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad: "
        '
        'lblFechaMovimiento
        '
        Me.lblFechaMovimiento.AutoSize = True
        Me.lblFechaMovimiento.Location = New System.Drawing.Point(374, 550)
        Me.lblFechaMovimiento.Name = "lblFechaMovimiento"
        Me.lblFechaMovimiento.Size = New System.Drawing.Size(97, 13)
        Me.lblFechaMovimiento.TabIndex = 4
        Me.lblFechaMovimiento.Text = "Fecha Movimiento:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(374, 583)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto.TabIndex = 4
        Me.lblProducto.Text = "Producto:"
        '
        'lblPrecioUnitario
        '
        Me.lblPrecioUnitario.AutoSize = True
        Me.lblPrecioUnitario.Location = New System.Drawing.Point(654, 550)
        Me.lblPrecioUnitario.Name = "lblPrecioUnitario"
        Me.lblPrecioUnitario.Size = New System.Drawing.Size(79, 13)
        Me.lblPrecioUnitario.TabIndex = 4
        Me.lblPrecioUnitario.Text = "Precio Unitario:"
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Location = New System.Drawing.Point(654, 583)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(64, 13)
        Me.lblPrecioTotal.TabIndex = 4
        Me.lblPrecioTotal.Text = "PrecioTotal:"
        '
        'lblPresentacion
        '
        Me.lblPresentacion.AutoSize = True
        Me.lblPresentacion.Location = New System.Drawing.Point(374, 613)
        Me.lblPresentacion.Name = "lblPresentacion"
        Me.lblPresentacion.Size = New System.Drawing.Size(72, 13)
        Me.lblPresentacion.TabIndex = 4
        Me.lblPresentacion.Text = "Presentacion:"
        '
        'txtMovimiento
        '
        Me.txtMovimiento.Location = New System.Drawing.Point(212, 547)
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.ReadOnly = True
        Me.txtMovimiento.Size = New System.Drawing.Size(145, 20)
        Me.txtMovimiento.TabIndex = 5
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(212, 580)
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.ReadOnly = True
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(145, 20)
        Me.txtTipoMovimiento.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(212, 610)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(145, 20)
        Me.txtCantidad.TabIndex = 5
        '
        'txtFechaMovimiento
        '
        Me.txtFechaMovimiento.Location = New System.Drawing.Point(485, 547)
        Me.txtFechaMovimiento.Name = "txtFechaMovimiento"
        Me.txtFechaMovimiento.ReadOnly = True
        Me.txtFechaMovimiento.Size = New System.Drawing.Size(145, 20)
        Me.txtFechaMovimiento.TabIndex = 5
        '
        'txtPresentacion
        '
        Me.txtPresentacion.Location = New System.Drawing.Point(485, 610)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.ReadOnly = True
        Me.txtPresentacion.Size = New System.Drawing.Size(145, 20)
        Me.txtPresentacion.TabIndex = 5
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(485, 580)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(145, 20)
        Me.txtProducto.TabIndex = 5
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(747, 580)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.ReadOnly = True
        Me.txtPrecioTotal.Size = New System.Drawing.Size(145, 20)
        Me.txtPrecioTotal.TabIndex = 5
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(747, 547)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.ReadOnly = True
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(145, 20)
        Me.txtPrecioUnitario.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtgProducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 429)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtgMovimientos)
        Me.GroupBox2.Location = New System.Drawing.Point(527, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 429)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Blue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Listado Productos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(493, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Movimientos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSDataProyBindingSource
        '
        Me.DSDataProyBindingSource.DataSource = Me.DSDataProy
        Me.DSDataProyBindingSource.Position = 0
        '
        'DSDataProy
        '
        Me.DSDataProy.DataSetName = "DSDataProy"
        Me.DSDataProy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'DSDataProy1
        '
        Me.DSDataProy1.DataSetName = "DSDataProy"
        Me.DSDataProy1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource2
        '
        Me.ProductoBindingSource2.DataMember = "Producto"
        Me.ProductoBindingSource2.DataSource = Me.DSDataProy1
        '
        'ProductoBindingSource4
        '
        Me.ProductoBindingSource4.DataMember = "Producto"
        Me.ProductoBindingSource4.DataSource = Me.DSDataProy1
        '
        'frmDataGridViewExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1035, 651)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPresentacion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.txtPrecioTotal)
        Me.Controls.Add(Me.txtFechaMovimiento)
        Me.Controls.Add(Me.txtTipoMovimiento)
        Me.Controls.Add(Me.txtMovimiento)
        Me.Controls.Add(Me.lblPresentacion)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblPrecioUnitario)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblFechaMovimiento)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblTipoMovimiento)
        Me.Controls.Add(Me.lblMovimiento)
        Me.Controls.Add(Me.lblDetalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDataGridViewExample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4CodeDeveloper Creation"
        CType(Me.dtgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DSDataProyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDataProy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDataProy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgProducto As DataGridView
    Friend WithEvents DSDataProyBindingSource As BindingSource
    Friend WithEvents DSDataProy As DSDataProy
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As DSDataProyTableAdapters.ProductoTableAdapter
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents ProductoBindingSource2 As BindingSource
    Friend WithEvents DSDataProy1 As DSDataProy
    Friend WithEvents ProductoBindingSource3 As BindingSource
    Friend WithEvents ProductoBindingSource4 As BindingSource
    Friend WithEvents dtgMovimientos As DataGridView
    Friend WithEvents lblDetalles As Label
    Friend WithEvents lblMovimiento As Label
    Friend WithEvents lblTipoMovimiento As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblFechaMovimiento As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblPrecioUnitario As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblPresentacion As Label
    Friend WithEvents txtMovimiento As TextBox
    Friend WithEvents txtTipoMovimiento As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaMovimiento As TextBox
    Friend WithEvents txtPresentacion As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
End Class
