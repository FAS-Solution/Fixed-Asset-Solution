Imports System.Data.SqlClient

Public Class frmCargoActivos

    Private Sub FrmCargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        LlenarDatos()

        txtCodigo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigo.AutoCompleteCustomSource = ObtenerCodigos()

        'Identidad
        txtIdentidad.AutoCompleteMode = AutoCompleteMode.Suggest
        txtIdentidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtIdentidad.AutoCompleteCustomSource = ObtenerIdentidades()

        dgvActivosAsignados.AutoGenerateColumns = False

    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnArticulos.Enabled = False
        btnEmpleados.Enabled = False

        txtCodigo.Enabled = False
        txtNombreA.Enabled = False
        txtPrecio.Enabled = False
        txtIdentidad.Enabled = False
        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False
        txtCodigoInventario.Enabled = False
        DTPFechaEntrega.Enabled = False
        cboEstado.Enabled = False
        txtDescripcion.Enabled = False


        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnArticulos.Enabled = True
        btnEmpleados.Enabled = True

        txtCodigo.Enabled = True
        txtNombreA.Enabled = True
        txtPrecio.Enabled = True
        txtIdentidad.Enabled = True
        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True
        txtCodigoInventario.Enabled = True
        DTPFechaEntrega.Enabled = True
        cboEstado.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()
        txtCodigo.Text = ""
        txtNombreA.Text = ""
        txtPrecio.Text = ""
        txtIdentidad.Text = ""
        txtNombreE.Text = ""
        txtDepartamento.Text = ""
        txtCodigoInventario.Clear()
        DTPFechaEntrega.Text = ""
        cboEstado.Text = ""
        txtDescripcion.Text = ""


        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub Insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Regristo", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM CargoActivos Where CodigoInventario = '" & txtCodigoInventario.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigoInventario.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtIdArticulo.Text = "" Or txtIdEmpleado.Text = "" Or txtCodigoInventario.Text = "" Or DTPFechaEntrega.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO CargoActivos(CodigoInventario,FechaAsignacion,EstadoArticulo,Descripcion,IdArticulo,IdEmpleado) 
                    VALUES ('" & txtCodigoInventario.Text & "', '" & DTPFechaEntrega.Text & "', '" & cboEstado.Text & "', '" & txtDescripcion.Text & "', 
                            '" & txtIdArticulo.Text & "', '" & txtIdEmpleado.Text & "' )"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            ModificarArticulo()
            MsgBox("Registro realizado exitosamente", vbInformation, "Sistema Inventario")
        End If
    End Sub

    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventarios")
        Else
            If MsgBox("Seguro en eliminar el Activo" + Trim(txtNombreA.Text) + " De su registro de cargos ?", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()
                Exit Sub

            Else
                Dim sql As String
                sql = " DELETE FROM CargoActivos WHERE IdCargo  = " & Trim(txtId.Text)
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                ModificarArticuloPendiente()
                MsgBox("Registro eliminado correctamente", vbInformation, "Sistema de Inventario")
                LimpiarControles()
            End If
        End If
    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox(" Existen Campos Vacios", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE CargoActivos SET CodigoInventario = '" & txtCodigoInventario.Text & "', FechaAsignacion = '" & DTPFechaEntrega.Text & "',
                                        EstadoArticulo = '" & cboEstado.Text & "', Descripcion = '" & txtDescripcion.Text & "',
                                        IdArticuloo = '" & txtIdArticulo.Text & "', IdEmpleado = '" & txtIdEmpleado.Text & "'
                    WHERE IdCargo = '" & txtId.Text & "' "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registroeditado exitosamente", vbInformation, "Sistema de Inventario")
        End If
    End Sub

    Sub ModificarArticuloPendiente()
        Dim id As Integer
        Dim sql As String
        sql = "UPDATE Articulos SET EstadoArticulos = 'PENDIENTE', WHERE IdArticulo = '" & txtIdArticulo.Text & "' "
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Open()
        MsgBox("Registro editado exitosamente", vbInformation, "Istemade inventario")
        LimpiarControles()
    End Sub

    Sub ModificarArticulo()
        Dim id As Integer
        Dim sql As String
        sql = "UPDATE Articulos SET EstadoArticulos = 'Entregado', WHERE IdArticulo = '" & txtIdArticulo.Text & "' "
            Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Open()
        MsgBox("Registro editado exitosamente", vbInformation, "Istemade inventario")
        LimpiarControles()
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT CargoActivos.IdCargo, CargoActivos.CodigoInventario, CargoActivos.FechaAsignacion, CargoActivos.Descripcion, CargoActivos.EstadoArticulo,
                        Articulos.NombreA, Articulos.IdArticulo, Articulos.PrecioCompra, Articulos.CodigoA,
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

    Private Function ObtenerCodigos() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT CodigoA FROM Articulos WHERE EstadoArticulo = 'PENDIENTE ' ", obtenerconexion)
        Dim dt As New DataTable("Articulos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function

    Private Function ObtenerIdentidades() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT Identidad FROM Empleados ", obtenerconexion)
        Dim dt As New DataTable("Empleados")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT IdArticulo, NombreA, PrecioCompra FROM Articulos WHERE CodigoA ='" & txtCodigo.Text & "' ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreA.Text = fila("NombreA").ToString
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
            Else
                txtNombreA.Clear()
                txtPrecio.Clear()
                txtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        If txtIdentidad.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.nombre, Departamentos.NombreD
                                            FROM Departamentos 
                                            INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                            WHERE Identidad ='" & txtIdentidad.Text & "' ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                txtIdEmpleado.Text = fila("IdEmpleado").ToString
            Else
                txtNombreE.Clear()
                txtDepartamento.Clear()
                txtIdentidad.Focus()
            End If
        End If
    End Sub

    Private Sub BtnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        frmBusquedaArticulos.ShowDialog()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmBusquedaEmpleados.ShowDialog()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub RbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
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

    Private Sub DgvActivosAsignados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivosAsignados.CellDoubleClick
        On Error Resume Next
        txtIdArticulo.Text = CStr(dgvActivosAsignados.Item("IdArticulo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvActivosAsignados.Item("NombreA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvActivosAsignados.Item("CodigoA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvActivosAsignados.Item("PrecioCompra", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        txtIdEmpleado.Text = CStr(dgvActivosAsignados.Item("IdEmpleado", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvActivosAsignados.Item("Nombre", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvActivosAsignados.Item("CodigoA", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvActivosAsignados.Item("PrecioCompra", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        txtCodigoInventario.Text = CStr(dgvActivosAsignados.Item("CodigoInventario", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        DTPFechaEntrega.Text = CStr(dgvActivosAsignados.Item("FechaAsignacion", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        cboEstado.Text = CStr(dgvActivosAsignados.Item("EstadoArticulo", dgvActivosAsignados.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvActivosAsignados.Item("Descripcion", dgvActivosAsignados.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False
        btnArticulos.Enabled = True
        btnEmpleados.Enabled = True

        txtCodigo.Enabled = True
        txtIdentidad.Enabled = True
        txtCodigoInventario.Enabled = True
        DTPFechaEntrega.Enabled = True
        cboEstado.Enabled = True
        txtPrecio.Enabled = True
        txtDescripcion.Enabled = True

        txtNombreA.Focus()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Editar()
            DesactivarControles()
            LlenarDatos()
        Else
            MsgBox("No tiene los privilegios para modificar esta informacion", vbInformation, "Operacion Cancelada")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If UCase(tipousuario) = "ADMINISTRADOR" Then
            Eliminar()
            DesactivarControles()
            LlenarDatos()
        Else
            MsgBox("No tiene los privilegios para modificar esta informacion", vbInformation, "Operacion Cancelada")
        End If
    End Sub
End Class