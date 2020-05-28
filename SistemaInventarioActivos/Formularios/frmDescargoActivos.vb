Imports System.Data.SqlClient


Public Class frmDescargoActivos
    Private Sub FrmDescargoActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        'LlenarDatos()

        txtCodigoI.AutoCompleteMode = AutoCompleteMode.Suggest
        txtCodigoI.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCodigoI.AutoCompleteCustomSource = ObtenerCodigoInventario()

        ''Identidad
        'txtIdentidad.AutoCompleteMode = AutoCompleteMode.Suggest
        'txtIdentidad.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtIdentidad.AutoCompleteCustomSource = ObtenerIdentidades()

        dgvActivosDescargados.AutoGenerateColumns = False
    End Sub

    Private Function ObtenerCodigoInventario() As AutoCompleteStringCollection
        adaptador = New SqlDataAdapter("SELECT CodigoInventario FROM CargoActivos ", obtenerconexion)
        Dim dt As New DataTable("CargoActivos")
        adaptador.Fill(dt)
        Dim ListarDatos As New AutoCompleteStringCollection()
        For Each row As DataRow In dt.Rows
            ListarDatos.Add(CStr(row(0)))
        Next
        Return ListarDatos
    End Function

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnCargos.Enabled = False

        txtCodigoI.Enabled = False
        txtNombreA.Enabled = False
        txtPrecio.Enabled = False
        txtIdentidad.Enabled = False
        txtNombreE.Enabled = False
        txtDepartamento.Enabled = False
        'DTPFechaEntrega.Enabled = False
        cboMotivo.Enabled = False
        txtDescripcion.Enabled = False
        DTPFechaDescargo.Enabled = False


        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnCargos.Enabled = True

        txtCodigoI.Enabled = True
        txtNombreA.Enabled = True
        txtPrecio.Enabled = True
        txtIdentidad.Enabled = True
        txtNombreE.Enabled = True
        txtDepartamento.Enabled = True

        'DTPFechaEntrega.Enabled = False
        cboMotivo.Enabled = True
        txtDescripcion.Enabled = True
        DTPFechaDescargo.Enabled = True

        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()
        txtCodigoI.Text = ""
        txtNombreA.Text = ""
        txtPrecio.Text = ""
        txtIdentidad.Text = ""
        txtNombreE.Text = ""
        txtDepartamento.Text = ""


        DTPFechaEntrega.Text = ""
        cboMotivo.Text = ""
        txtDescripcion.Text = ""
        txtIdCargo.Text = ""
        txtBuscar.Text = ""
        txtIdArticulo.Text = ""
        txtIdCargo.Text = ""
        DTPFechaDescargo.Text = ""


    End Sub

    Sub Insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Regristo", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT CargoActivos.CodigoInventario 
                                        FROM CargoActivos
                                        INNER JOIN DescargoActivos ON CargoActivos.IdCargo = DescargoActivos.IdCargoActivos
                                        Where CargoActivos.CodigoInventario = '" & txtCodigoI.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigoI.Text = tabla.Rows(0).Item("CodigoInventario")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtIdArticulo.Text = "" Or txtIdCargo.Text = "" Or DTPFechaDescargo.Text = "" Or cboMotivo.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO DescargoActivos(FechaDescargo,Descripcion,MotivoDescargo,IdCargoActivo) 
                    VALUES ('" & DTPFechaDescargo.Text & "', '" & txtDescripcion.Text & "', '" & cboMotivo.Text & "', 
                            '" & txtIdCargo.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente", vbInformation, "Sistema Inventario")
        End If
    End Sub

    Sub Eliminar()
        Dim id As Integer
        Dim sql As String
        sql = " DELETE FROM CargoActivos WHERE IdCargo  = " & Trim(txtIdCargo.Text)
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Close()
        ModificarArticuloPendiente()
        MsgBox("Registro eliminado correctamente", vbInformation, "Sistema de Inventario")
        LimpiarControles()
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
    Sub ModificarArticuloDefectuoso()
        Dim id As Integer
        Dim sql As String
        sql = "UPDATE Articulos SET EstadoArticulos = 'NO FUNCIONA', WHERE IdArticulo = '" & txtIdArticulo.Text & "' "
        Dim conect As New SqlConnection(obtenerconexion)
        conect.Open()
        Using comando As New SqlCommand(sql, conect)
            id = comando.ExecuteScalar()
        End Using
        conect.Open()
        MsgBox("Registro editado exitosamente", vbInformation, "Istemade inventario")
        LimpiarControles()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DesactivarControles()
    End Sub

    Private Sub TxtCodigoI_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoI.TextChanged
        If txtCodigoI.Text <> "" Then
            adaptador = New SqlDataAdapter("SELECT CargoActivos.IdCargo, CargoActivos.FechaAsignacion,
                                                   Articulos.IdArticulo, Articulos.NombreA, Articulos.PrecioCompra,
                                                   Empleados.Nombre, Empleados.Identidad,
                                                   Departamentos.NombreD 
                                            FROM Articulos
                                            INNER JOIN CargoActivos ON Articulos.IdArticulo = CarcoActivos.IdArticulo
                                            INNER JOIN Empleados ON CargoActivos.IdEMpleado = Empleados.IdEmpleado
                                            INNER JOIN Departamentos ON Empleados.IdDepartamento = Departamentos.IdDepartamento
                                            WHERE CodigoActivos.CodigoInventario ='" & txtCodigoI.Text & "' ", obtenerconexion)
            Dim tabla As New DataTable
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Dim fila As DataRow = tabla.Rows(0)
                txtNombreA.Text = fila("NombreA").ToString
                txtPrecio.Text = fila("PrecioCompra").ToString
                txtIdArticulo.Text = fila("IdArticulo").ToString
                txtIdentidad.Text = fila("IdIdentidad").ToString
                txtNombreE.Text = fila("Nombre").ToString
                txtDepartamento.Text = fila("NombreD").ToString
                DTPFechaEntrega.Text = fila("FechaAsignacion").ToString
                txtIdCargo.Text = fila("IdCargo").ToString
            Else
                txtNombreA.Clear()
                txtPrecio.Clear()
                txtCodigoI.Focus()
                txtIdArticulo.Clear()
                txtIdentidad.Clear()
                txtNombreE.Clear()
                txtDepartamento.Clear()
                DTPFechaEntrega.Text = ""
                txtIdCargo.Clear()
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cboMotivo.Text = "Obsoleto" Then
            Insertar()
            Eliminar()
            ModificarArticuloDefectuoso()
            DesactivarControles()
            LimpiarControles()
        Else
            Insertar()
            Eliminar()
            ModificarArticuloPendiente()
            DesactivarControles()
            LimpiarControles()
        End If
    End Sub

    Private Sub BtnCargos_Click(sender As Object, e As EventArgs) Handles btnCargos.Click
        frmBusquedaActivos.ShowDialog()
    End Sub
End Class