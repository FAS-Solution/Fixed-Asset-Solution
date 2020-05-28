Imports System.Data.SqlClient

Public Class FrmEmpleados

    Private tabla_departamentos As New DataTable
    Private tabla_puestos As New DataTable

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        'LlenarDatos()
        dgvEmpleados.AutoGenerateColumns = False
        Mostrar_Departamentos()
        cboDepartamento.SelectedIndex = -1
        Mostrar_Puestos()

        cboPuesto.SelectedIndex = -1
    End Sub

    Sub BuscarDatos()
        If rbNombreEmpleado.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, 
                                                    Departamentos.NombreD,
                                                    Puestos.NombreP 
                                            FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                               INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto

                                            WHERE Empleados.Nombre LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvEmpleados.DataSource = tabla
                lblTotalEmpleados.Text = tabla.Rows.Count
            Else
                dgvEmpleados.DataSource = ""
            End If

            If rbIdentidad.Checked Then
                If txtBuscar.Text = "" Then
                    LlenarDatos()
                End If
                adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, 
                                                    Departamentos.NombreD,
                                                    Puestos.NombreP 
                                            FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                               INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto

                                            WHERE Empleados.Identidad LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count > 0 Then
                    dgvEmpleados.DataSource = tabla
                    lblTotalEmpleados.Text = tabla.Rows.Count
                Else
                    dgvEmpleados.DataSource = ""
                End If

                If rbDepartamento.Checked Then
                    If txtBuscar.Text = "" Then
                        LlenarDatos()
                    End If
                    adaptador = New SqlDataAdapter("SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, 
                                                    Departamentos.NombreD,
                                                    Puestos.NombreP 
                                            FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                                               INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto

                                            WHERE Departamentos.NombreD LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
                    tabla.Clear()
                    adaptador.Fill(tabla)
                    If tabla.Rows.Count > 0 Then
                        dgvEmpleados.DataSource = tabla
                        lblTotalEmpleados.Text = tabla.Rows.Count
                    Else
                        dgvEmpleados.DataSource = ""
                    End If
                End If
            End If
        End If
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT Empleados.IdEmpleado, Empleados.Nombre, Empleados.Identidad, Empleados.Genero, Empleados.Telefono, Empleados.Correo, Empleados.Direccion, 
                        Departamentos.NombreD,
                        Puestos.NombreP 
                FROM Departamentos INNER JOIN Empleados ON Departamentos.IdDepartamento = Empleados.IdDepartamento
                                   INNER JOIN Puestos ON Empleados.IdPuesto = Puestos.IdPuesto"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvEmpleados.DataSource = tabla
            lblTotalEmpleados.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try

    End Sub

    Public Function Departamento_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdDepartamento, NombreD From Departamentos "
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function

    Private Sub Mostrar_Departamentos()
        tabla_departamentos = Departamento_Listar(True)
        cboDepartamento.DataSource = tabla_departamentos
        cboDepartamento.DisplayMember = "NombreD"
        cboDepartamento.ValueMember = "IdDepartamento"
    End Sub

    Public Function Puesto_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdPuesto, NombreP From Puestos "
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function

    Private Sub Mostrar_Puestos()
        tabla_puestos = Puesto_Listar(True)
        cboPuesto.DataSource = tabla_puestos
        cboPuesto.DisplayMember = "NombreP"
        cboPuesto.ValueMember = "IdPuesto"
    End Sub



    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False

        txtNombreE.Enabled = False
        txtIdentidad.Enabled = False
        txtCorreo.Enabled = False
        txtTelefono.Enabled = False
        txtDireccion.Enabled = False
        cboGenero.Enabled = False
        cboDepartamento.Enabled = False
        cboPuesto.Enabled = False


        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True
        txtCorreo.Enabled = True
        txtTelefono.Enabled = True
        txtDireccion.Enabled = True
        cboGenero.Enabled = True
        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()
        txtNombreE.Text = ""
        txtIdentidad.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        cboGenero.Text = ""
        cboDepartamento.Text = ""
        cboPuesto.Text = ""

        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub Insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Regristo", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Empleados Where Identidad = '" & txtIdentidad.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtIdentidad.Text = tabla.Rows(0).Item("Identidad")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtNombreE.Text = "" Or txtIdentidad.Text = "" Or cboGenero.Text = "" Or cboDepartamento.Text = "" Or cboPuesto.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Empleados(Nombre, Identidad, Genero, Telefono, Correo, Direccion, IdPuesto, IdDepartamento) VALUES ('" & txtNombreE.Text & "', 
                                                                                        '" & txtIdentidad.Text & "', '" & cboGenero.Text & "', '" & txtTelefono.Text & "', 
                                                                                        '" & txtCorreo.Text & "', '" & txtDireccion.Text & "', '" & Trim(cboPuesto.SelectedValue) & "',
                                                                                        '" & Trim(cboDepartamento.SelectedValue) & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente", vbInformation, "Sistema Inventario")
        End If
    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Empleados SET Nombre = '" & txtNombreE.Text & "', Identidad = '" & txtIdentidad.Text & "',
                                        Genero = '" & cboGenero.Text & "', Telefono = '" & txtTelefono.Text & "',
                                        Correo = '" & txtCorreo.Text & "', Direccion = '" & txtDireccion.Text & "',
                                        IdDepartamento = '" & Trim(cboDepartamento.SelectedValue) & "', 
                                        IdPuesto = '" & Trim(cboPuesto.SelectedValue) & "' 
                  WHERE IdEmpleado = '" & txtId.Text & "' "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()

            End Using
            conect.Close()
            MsgBox("Regsitro editado exitosamente", vbInformation, "Sistema de inventario")
            LimpiarControles()
        End If
    End Sub

    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventarios")
        Else
            If MsgBox("Seguro en eliminar a" + Trim(txtNombreE.Text) + " De su registro ?", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()
                Exit Sub

            Else
                Dim sql As String
                sql = " DELETE FROM Empleados WHERE IdEmpleado  = " & Trim(txtId.Text)
                Dim conect As New SqlConnection(obtenerconexion)
                conect.Open()
                Using comando As New SqlCommand(sql, conect)
                    id = comando.ExecuteScalar()
                End Using
                conect.Close()
                MsgBox("Registro eliminado correctamente", vbInformation, "Sistema de Inventario")
                LimpiarControles()
            End If
        End If
    End Sub



    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call ActivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub RbNombreEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreEmpleado.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub RbIdentidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbIdentidad.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub RbDepartamento_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepartamento.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub DgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvEmpleados.Item("IdEmpleado", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtNombreE.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtIdentidad.Text = CStr(dgvEmpleados.Item("Identidad", dgvEmpleados.CurrentCell.RowIndex).Value)
        cboGenero.Text = CStr(dgvEmpleados.Item("Genero", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtTelefono.Text = CStr(dgvEmpleados.Item("Telefono", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtCorreo.Text = CStr(dgvEmpleados.Item("Correo", dgvEmpleados.CurrentCell.RowIndex).Value)
        txtDireccion.Text = CStr(dgvEmpleados.Item("Direccion", dgvEmpleados.CurrentCell.RowIndex).Value)
        cboDepartamento.Text = CStr(dgvEmpleados.Item("NombreD", dgvEmpleados.CurrentCell.RowIndex).Value)
        cboPuesto.Text = CStr(dgvEmpleados.Item("NombreP", dgvEmpleados.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreE.Enabled = True
        txtIdentidad.Enabled = True
        cboGenero.Enabled = True
        txtTelefono.Enabled = True
        txtCorreo.Enabled = True
        txtDireccion.Enabled = True
        cboDepartamento.Enabled = True
        cboPuesto.Enabled = True

        txtNombreE.Focus()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub BtnDepartamento_Click(sender As Object, e As EventArgs) Handles btnDepartamento.Click
        frmDepartamentos.ShowDialog()
    End Sub

    Private Sub BtnPuesto_Click(sender As Object, e As EventArgs) Handles btnPuesto.Click
        frmPuestosTrabajo.ShowDialog()
    End Sub
End Class