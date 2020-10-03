Public Class frmDataGridViewExample
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DSDataProyProd = New DSDataProyTableAdapters.ProductoTableAdapter()
        dtgProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgProducto.DataSource = DSDataProyProd.GetData()
        dtgProducto.Columns("IdProducto").Visible = False
        dtgMovimientos.Columns("IdMovimiento").Visible = False
        dtgProducto.ClearSelection()
        dtgMovimientos.ClearSelection()
    End Sub
    Private Sub dtgProducto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProducto.CellValueChanged
        MessageBox.Show("Row2")
    End Sub

    Private Sub dtgProducto_SelectionChanged(sender As Object, e As EventArgs) Handles dtgProducto.SelectionChanged
        Dim rowCount As Integer = dtgProducto.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim DSDataProyMov = New DSDataProyTableAdapters.MovimientoTableAdapter()
        Dim idProducto As Integer
        If (rowCount > 0) Then
            idProducto = dtgProducto.Rows(dtgProducto.CurrentRow.Index).Cells(0).Value
            dtgMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dtgMovimientos.DataSource = DSDataProyMov.GetData(idProducto)
        End If
    End Sub
    Private Sub dtgMovimiento_SelectionChanged(sender As Object, e As EventArgs) Handles dtgMovimientos.SelectionChanged
        Dim rowCount As Integer = dtgMovimientos.Rows.GetRowCount(DataGridViewElementStates.Selected)
        Dim DSDataProyMovDetalle = New DSDataProyTableAdapters.dtDetalleMovimientoTableAdapter()
        Dim idMovimiento As Integer
        Dim data As DataTable
        If (rowCount > 0) Then
            idMovimiento = dtgMovimientos.Rows(dtgMovimientos.CurrentRow.Index).Cells(0).Value
            data = DSDataProyMovDetalle.GetData(idMovimiento)
            txtMovimiento.Text = data.Rows(0)("Movimiento").ToString()
            txtTipoMovimiento.Text = data.Rows(0)("Tipo Movimiento").ToString()
            txtCantidad.Text = data.Rows(0)("Cantidad").ToString()
            txtFechaMovimiento.Text = Format(data.Rows(0)("Fecha Movimiento"), "dd/MM/yyyy")
            txtProducto.Text = data.Rows(0)("Producto").ToString()
            txtPresentacion.Text = data.Rows(0)("Presentacion").ToString()
            txtPrecioTotal.Text = data.Rows(0)("PrecioTotal").ToString()
            txtPrecioUnitario.Text = data.Rows(0)("PrecioUnitario").ToString()
        End If
    End Sub

End Class
