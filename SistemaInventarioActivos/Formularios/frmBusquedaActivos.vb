Imports System.Data.SqlClient

Public Class frmBusquedaActivos
    Private Sub FrmBusquedaActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
        txtBuscar.Focus()
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, CargoActivos.EstadoArticulos,
                        Articulos.NombreA, Articulos.IdArticulos, Articulos.PrecioCompra, Articulos.CodigoA,
                        Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado,
                        Departamentos.NombreD
                FROM Articulos
                INNER JOIN CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                INNER JOIN Empleados ON CargoActivos.idEmpleado = Empleados.IdEmpleado
                INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvActivosAsignados.DataSource = tabla
            lblTotalActivos.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try
    End Sub

    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("Select CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion,
                                                    Articulos.NombreA, Articulos.IdArticulos, Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado,
                                                    Departamentos.NombreD
                                            From Articulos
                                            INNER Join CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                            INNER Join Empleados ON CargoActivos.idEmpleado = Empleados.IdEmpleado
                                            INNER Join Departamentos On Empleados.IdDepartamento = Departamentos.IdDepartamento

                                            WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvActivosAsignados.DataSource = tabla
                lblTotalActivos.Text = tabla.Rows.Count
            Else
                dgvActivosAsignados.DataSource = ""
            End If



            If rbCodigoInventario.Checked Then
                If txtBuscar.Text = "" Then
                    LlenarDatos()
                End If
                adaptador = New SqlDataAdapter("Select CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion,
                                                    Articulos.NombreA, Articulos.IdArticulos, Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado,
                                                    Departamentos.NombreD
                                            From Articulos
                                            INNER Join CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                            INNER Join Empleados ON CargoActivos.idEmpleado = Empleados.IdEmpleado
                                            INNER Join Departamentos On Empleados.IdDepartamento = Departamentos.IdDepartamento

                                            WHERE CargoActivos.CodigoInventario LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count > 0 Then
                    dgvActivosAsignados.DataSource = tabla
                    lblTotalActivos.Text = tabla.Rows.Count
                Else
                    dgvActivosAsignados.DataSource = ""
                End If



                If rbNombreArticulo.Checked Then
                    If txtBuscar.Text = "" Then
                        LlenarDatos()
                    End If
                    adaptador = New SqlDataAdapter("Select CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion,
                                                    Articulos.NombreA, Articulos.IdArticulos, Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado,
                                                    Departamentos.NombreD
                                            From Articulos
                                            INNER Join CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                            INNER Join Empleados ON CargoActivos.idEmpleado = Empleados.IdEmpleado
                                            INNER Join Departamentos On Empleados.IdDepartamento = Departamentos.IdDepartamento

                                            WHERE Articulos.NombreA LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
                    tabla.Clear()
                    adaptador.Fill(tabla)
                    If tabla.Rows.Count > 0 Then
                        dgvActivosAsignados.DataSource = tabla
                        lblTotalActivos.Text = tabla.Rows.Count
                    Else
                        dgvActivosAsignados.DataSource = ""
                    End If
                End If



                If rbDepartamento.Checked Then
                    If txtBuscar.Text = "" Then
                        LlenarDatos()
                    End If
                    adaptador = New SqlDataAdapter("Select CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion,
                                                    Articulos.NombreA, Articulos.IdArticulos, Articulos.PrecioCompra,
                                                    Empleados.Nombre, Empleados.Identidad, Empleados.IdEmpleado,
                                                    Departamentos.NombreD
                                            From Articulos
                                            INNER Join CargoActivos ON Articulos.IdArticulo = CargoActivos.IdArticulo
                                            INNER Join Empleados ON CargoActivos.idEmpleado = Empleados.IdEmpleado
                                            INNER Join Departamentos On Empleados.IdDepartamento = Departamentos.IdDepartamento

                                            WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
                    tabla.Clear()
                    adaptador.Fill(tabla)
                    If tabla.Rows.Count > 0 Then
                        dgvActivosAsignados.DataSource = tabla
                        lblTotalActivos.Text = tabla.Rows.Count
                    Else
                        dgvActivosAsignados.DataSource = ""
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub RbCodigoInventario_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoInventario.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub RbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub RbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub DgvActivosAsignados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivosAsignados.CellContentDoubleClick
        On Error Resume Next
        frmDescargoActivos.txtIdArticulo.Text = CStr(dgvActivosAsignados.Item("IdArticulo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNombreA.Text = CStr(dgvActivosAsignados.Item("NombreA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtCodigoI.Text = CStr(dgvActivosAsignados.Item("CodigoInventario", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtPrecio.Text = CStr(dgvActivosAsignados.Item("PrecioCompra", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        frmDescargoActivos.txtIdCargo.Text = CStr(dgvActivosAsignados.Item("IdCargo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtNombreE.Text = CStr(dgvActivosAsignados.Item("Nombre", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtIdentidad.Text = CStr(dgvActivosAsignados.Item("Identidad", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        frmDescargoActivos.txtDepartamento.Text = CStr(dgvActivosAsignados.Item("NombreD", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        frmDescargoActivos.DTPFechaEntrega.Text = CStr(dgvActivosAsignados.Item("FechaAsignacion", dgvActivosAsignados.CurrentCell.RowIndex).Value)
    End Sub
End Class