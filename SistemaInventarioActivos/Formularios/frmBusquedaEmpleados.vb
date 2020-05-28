Imports System.Data.SqlClient

Public Class frmBusquedaEmpleados
    Private Sub FrmBusquedaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub DgvEmpleados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentDoubleClick
        On Error Resume Next
        frmCargoActivos.txtIdEmpleado.Text = CStr(dgvEmpleados.Item("IdEmpleado", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtNombreE.Text = CStr(dgvEmpleados.Item("Nombre", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtIdentidad.Text = CStr(dgvEmpleados.Item("Identidad", dgvEmpleados.CurrentCell.RowIndex).Value)
        frmCargoActivos.txtDepartamento.Text = CStr(dgvEmpleados.Item("NombreD", dgvEmpleados.CurrentCell.RowIndex).Value)

        Me.Close()
    End Sub
End Class