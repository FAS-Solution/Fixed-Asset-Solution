Imports System.Data.SqlClient


Public Class frmArticulos

    Private tabla_marcas As New DataTable

    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DesactivarControles()
        LlenarDatos()
        Mostrar_Marcas()
        cboMarca.SelectedIndex = -1
        dgvArticulos.AutoGenerateColumns = False

        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvArticulos.Columns("PrecioCompra").DefaultCellStyle.Format = "N2"

    End Sub

    Sub DesactivarControles()
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = False
        btnMarcas.Enabled = False

        txtNombreA.Enabled = False
        txtCodigo.Enabled = False
        txtSerie.Enabled = False
        txtModelo.Enabled = False
        cboMarca.Enabled = False
        DTPFechaCompra.Enabled = False
        txtPrecio.Enabled = False
        txtDescripcion.Enabled = False


        btnNuevo.Enabled = True
    End Sub

    Sub ActivarControles()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnCancelar.Enabled = True
        btnMarcas.Enabled = True

        txtNombreA.Enabled = True
        txtCodigo.Enabled = True
        txtSerie.Enabled = True
        txtModelo.Enabled = True
        cboMarca.Enabled = True
        DTPFechaCompra.Enabled = True
        txtPrecio.Enabled = True
        txtDescripcion.Enabled = True

        btnNuevo.Enabled = False
    End Sub

    Sub LimpiarControles()
        txtNombreA.Text = ""
        txtCodigo.Text = ""
        txtSerie.Text = ""
        txtModelo.Text = ""
        cboMarca.Text = ""
        DTPFechaCompra.Text = ""
        txtPrecio.Text = ""
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

        adaptador = New SqlDataAdapter("SELECT * FROM Articulos Where CodigoA = '" & txtCodigo.Text & "' ", obtenerconexion)
        tabla.Clear()
        adaptador.Fill(tabla)
        If tabla.Rows.Count > 0 Then
            txtCodigo.Text = tabla.Rows(0).Item("CodigoA")
            MsgBox("El registro ya existe en la base de datos ", vbInformation, "Sistema Inventario")
            Exit Sub
        End If

        If txtNombreA.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Existen Campos vacios", vbInformation, "Sistema Inventario")
            Exit Sub
        Else
            sql = "INSERT INTO Articulos(NombreA, NumeroSerie,CodigoA,IdMarca,Modelo,PrecioCompra,FechaCompra,EstadoArticulo,Descripcion)" &
                    "VALUES('" & txtNombreA.Text & "', '" & txtSerie.Text & "', '" & txtCodigo.Text & "', '" & Trim(cboMarca.SelectedValue) & "', 
            '" & txtModelo.Text & "', '" & txtPrecio.Text & "', '" & DTPFechaCompra.Text & "', 'PENDIENTE', '" & txtDescripcion.Text & "')"
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Close()
            MsgBox("Registro realizado exitosamente", vbInformation, "Sistema Inventario")
        End If
    End Sub

    Sub LlenarDatos()
        Dim sql As String
        sql = "SELECT Articulos.IdArticulo,Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                        Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion
                FROM Articulos
                INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca
                WHERE Articulos.EstadoArticulo = 'PENDIENTE'"
        Try
            Dim tabla As New DataTable
            adaptador = New SqlDataAdapter(sql, obtenerconexion)
            adaptador.Fill(tabla)
            dgvArticulos.DataSource = tabla
            lblTotalArticulos.Text = tabla.Rows.Count

        Catch ex As Exception
            MsgBox("Se ha mostrado el siguiente error " + ex.ToString + "Sistema Inventario")
        End Try
    End Sub

    Sub BuscarDatos()
        If rbNombreArticulo.Checked Then
            If txtBuscar.Text = "" Then
                LlenarDatos()
            End If
            adaptador = New SqlDataAdapter("SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                                                    Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion
                                            FROM Articulos
                                            INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca

                                            WHERE Articulos.NombreA LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE' ", obtenerconexion)
            tabla.Clear()
            adaptador.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                dgvArticulos.DataSource = tabla
                lblTotalArticulos.Text = tabla.Rows.Count
            Else
                dgvArticulos.DataSource = ""
            End If

            If rbCodigoA.Checked Then
                If txtBuscar.Text = "" Then
                    LlenarDatos()
                End If
                adaptador = New SqlDataAdapter("SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                                                    Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion
                                            FROM Articulos
                                            INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca

                                            WHERE Articulos.CodigoA LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE' ", obtenerconexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count > 0 Then
                    dgvArticulos.DataSource = tabla
                    lblTotalArticulos.Text = tabla.Rows.Count
                Else
                    dgvArticulos.DataSource = ""
                End If

                If rbMarca.Checked Then
                    If txtBuscar.Text = "" Then
                        LlenarDatos()
                    End If
                    adaptador = New SqlDataAdapter("SELECT Articulos.NombreA,Articulos.NumeroSerie,Articulos.CodigoA,Marcas.NombreM,Articulos.Modelo,Articulos.PrecioCompra,
                                                    Articulos.FechaCompra,Articulos.EstadoArticulo,Articulos.Descripcion
                                            FROM Articulos
                                            INNER JOIN Marcas ON Articulos.IdMarca = Marcas.IdMarca

                                            WHERE Marcas.NombreM LIKE '%" & txtBuscar.Text & "%' AND Articulos.EstadoArticulo = 'PENDIENTE' ", obtenerconexion)
                    tabla.Clear()
                    adaptador.Fill(tabla)
                    If tabla.Rows.Count > 0 Then
                        dgvArticulos.DataSource = tabla
                        lblTotalArticulos.Text = tabla.Rows.Count
                    Else
                        dgvArticulos.DataSource = ""
                    End If
                End If
            End If
        End If
    End Sub

    Sub Editar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventario")
        Else
            Dim sql As String
            sql = "UPDATE Articulos SET NombreA = '" & txtNombreA.Text & "', NumeroSerie = '" & txtSerie.Text & "',
                                        CodigoA = '" & txtCodigo.Text & "', IdMarca = '" & Trim(cboMarca.SelectedValue) & "',
                                        Modelo = '" & txtModelo.Text & "', PrecioCompra = '" & txtPrecio.Text & "',
                                        PrecioCompra = '" & DTPFechaCompra.Text & "', Descripcion = '" & txtDescripcion.Text & "', 
                    WHERE IdArticulo = '" & txtId.Text & "' "
            Dim conect As New SqlConnection(obtenerconexion)
            conect.Open()
            Using comando As New SqlCommand(sql, conect)
                id = comando.ExecuteScalar()
            End Using
            conect.Open()
            MsgBox("Registro editado exitosamente", vbInformation, "Istemade inventario")
            LimpiarControles()
        End If
    End Sub

    Sub Eliminar()
        Dim id As Integer
        If txtId.Text = "" Then
            MsgBox("Existen Campos Vacios", vbInformation, "Sistema de Inventarios")
        Else
            If MsgBox("Seguro en eliminar el articulo" + Trim(txtNombreA.Text) + " De su registro ?", vbQuestion + vbYesNo, "Sistema de Inventario") = vbNo Then
                LimpiarControles()
                DesactivarControles()
                Exit Sub

            Else
                Dim sql As String
                sql = " DELETE FROM Articulos WHERE IdArticulo  = " & Trim(txtId.Text)
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

    Public Function Marcas_Listar(activo As Integer) As DataTable
        Dim tabla As New DataTable
        Dim sql As String
        sql = "SELECT IdMarca, NombreM FROM Marcas "
        Using adaptador = New SqlDataAdapter(sql, obtenerconexion)
            tabla.Rows.Clear()
            adaptador.Fill(tabla)
        End Using
        Return tabla
    End Function

    Private Sub Mostrar_Marcas()
        tabla_marcas = Marcas_Listar(True)
        cboMarca.DataSource = tabla_marcas
        cboMarca.DisplayMember = "NombreM"
        cboMarca.ValueMember = "IdMarca"
    End Sub

    Private Sub BtnMarcas_Click(sender As Object, e As EventArgs) Handles btnMarcas.Click
        frmMarcas.ShowDialog()

    End Sub

    Private Sub CboMarca_Click(sender As Object, e As EventArgs) Handles cboMarca.Click
        Mostrar_Marcas()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Insertar()
        LlenarDatos()
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
        DesactivarControles()
        LlenarDatos()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DesactivarControles()
        LimpiarControles()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarDatos()
    End Sub

    Private Sub RbNombreArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombreArticulo.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub RbCodigoA_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigoA.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub RbMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rbMarca.CheckedChanged
        txtBuscar.Focus()
    End Sub

    Private Sub DgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArticulos.CellDoubleClick
        On Error Resume Next
        txtId.Text = CStr(dgvArticulos.Item("IdArticulo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtNombreA.Text = CStr(dgvArticulos.Item("NombreA", dgvArticulos.CurrentCell.RowIndex).Value)
        txtSerie.Text = CStr(dgvArticulos.Item("NumeroSerie", dgvArticulos.CurrentCell.RowIndex).Value)
        txtCodigo.Text = CStr(dgvArticulos.Item("CodigoA", dgvArticulos.CurrentCell.RowIndex).Value)
        cboMarca.Text = CStr(dgvArticulos.Item("NombreM", dgvArticulos.CurrentCell.RowIndex).Value)
        txtModelo.Text = CStr(dgvArticulos.Item("Modelo", dgvArticulos.CurrentCell.RowIndex).Value)
        txtPrecio.Text = CStr(dgvArticulos.Item("PrecioCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        DTPFechaCompra.Text = CStr(dgvArticulos.Item("FechaCompra", dgvArticulos.CurrentCell.RowIndex).Value)
        txtDescripcion.Text = CStr(dgvArticulos.Item("Descripcion", dgvArticulos.CurrentCell.RowIndex).Value)

        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = False

        txtNombreA.Enabled = True
        txtSerie.Enabled = True
        txtCodigo.Enabled = True
        cboMarca.Enabled = True
        txtModelo.Enabled = True
        txtPrecio.Enabled = True
        DTPFechaCompra.Enabled = True
        txtDescripcion.Enabled = True

        txtNombreA.Focus()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
        DesactivarControles()
        LlenarDatos()
    End Sub
End Class