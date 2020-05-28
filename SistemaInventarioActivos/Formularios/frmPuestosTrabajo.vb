Imports System.Data.SqlClient

Public Class frmPuestosTrabajo
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False

        txtNombreP.Enabled = False
        txtDescripcionP.Enabled = False

        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True

        txtNombreP.Enabled = True
        txtDescripcionP.Enabled = True

        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()
        txtNombreP.Text = ""
        txtDescripcionP.Text = ""
        txtId.Text = ""
        txtBuscar.Text = ""

    End Sub

    Sub TamanioFormularioBuscar()
        Width = 507
        Height = 420
        Panel1.Visible = True
        txtBuscar.Focus()
        txtBuscar.BackColor = Color.Yellow
    End Sub

    Sub TamanioFormulario()
        Width = 507
        Height = 169
        Panel1.Visible = False
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT * FROM Puestos"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvPuestos.DataSource = tabla
            lblTotalPuestos.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try

    End Sub

    Sub Insertar()
        Dim sql As String
        Dim id As Integer
        If MsgBox("Guardar Nuevo Regristo", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
            Exit Sub
        End If

        adaptador = New SqlDataAdapter("SELECT * FROM Puestos Where NombreP = '" & txtNombreP.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtNombreP.Text = tabla.Rows(0).Item("NombreP")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtNombreP.Text = "" Or txtDescripcionP.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Puestos(NombreP, DescripcionP) VALUES ('" & txtNombreP.Text & "', '" & txtDescripcionP.Text & "')"
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
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventarios")
        Else
            Dim sql As String
            sql = "UPDATE Puestos SET NombreP = '" & txtNombreP.Text & "', DescripcionP = ' " & txtDescripcionP.Text & " '
                                        WHERE IdPuesto = '" & txtId.Text & "' "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro editado correctamente", vbInformation, "Sistema de Inventario")
            LimpiarControles()
        End If
    End Sub

    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventarios")
        Else
            If MsgBox("Seguro en eliminar el puesto de " + Trim(txtNombreP.Text) + " De su registro ?", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()
                Exit Sub

            Else
                Dim sql As String
                sql = " DELETE FROM Puestos WHERE IdPuesto  = " & Trim(txtId.Text)
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

    Private Sub PuestosTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactivarControles()
        TamanioFormulario()
        LlenarDatos()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ActivarControles()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        Call DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        TamanioFormularioBuscar()
        btnCancelar.Enabled = True
        btnBuscar.Enabled = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TamanioFormulario()
        LimpiarControles()
        DesactivarControles()
        Panel1.Visible = False
        btnCancelar.Enabled = False
        btnBuscar.Enabled = True
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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            LlenarDatos()
        End If
        adaptador = New SqlDataAdapter("SELECT * FROM Puestos WHERE NombreP LIKE '%" & txtBuscar.Text & "%' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            dgvPuestos.DataSource = tabla
            lblTotalPuestos.Text = tabla.Rows.Count
        Else
            dgvPuestos.DataSource = ""
        End If
    End Sub

    Private Sub DgvPuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPuestos.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvPuestos.Item("IdPuesto", dgvPuestos.CurrentCell.RowIndex).Value)
        txtNombreP.Text = CStr(dgvPuestos.Item("NombreP", dgvPuestos.CurrentCell.RowIndex).Value)
        txtDescripcionP.Text = CStr(dgvPuestos.Item("DescripcionP", dgvPuestos.CurrentCell.RowIndex).Value)
        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreP.Enabled = True
        txtDescripcionP.Enabled = True

        txtNombreP.Focus()
    End Sub
End Class