<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescargoActivos
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
        Me.txtIdCargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtCodigoI = New System.Windows.Forms.TextBox()
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.btnCargos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigoInventario = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalActivosDescargados = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvActivosDescargados = New System.Windows.Forms.DataGridView()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcioFechaAsignacionn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFechaDescargo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvActivosDescargados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdCargo
        '
        Me.txtIdCargo.Location = New System.Drawing.Point(647, 7)
        Me.txtIdCargo.Name = "txtIdCargo"
        Me.txtIdCargo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdCargo.TabIndex = 123
        Me.txtIdCargo.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(467, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "Departamento"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(547, 36)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(94, 20)
        Me.txtDepartamento.TabIndex = 121
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(647, 35)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdArticulo.TabIndex = 120
        Me.txtIdArticulo.Visible = False
        '
        'txtCodigoI
        '
        Me.txtCodigoI.Location = New System.Drawing.Point(99, 5)
        Me.txtCodigoI.Name = "txtCodigoI"
        Me.txtCodigoI.Size = New System.Drawing.Size(103, 20)
        Me.txtCodigoI.TabIndex = 119
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Enabled = False
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(99, 59)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(103, 20)
        Me.DTPFechaEntrega.TabIndex = 117
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Fecha Entrega"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(99, 33)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.ReadOnly = True
        Me.txtIdentidad.Size = New System.Drawing.Size(103, 20)
        Me.txtIdentidad.TabIndex = 115
        '
        'btnCargos
        '
        Me.btnCargos.Location = New System.Drawing.Point(204, 4)
        Me.btnCargos.Name = "btnCargos"
        Me.btnCargos.Size = New System.Drawing.Size(27, 23)
        Me.btnCargos.TabIndex = 114
        Me.btnCargos.Text = "..."
        Me.btnCargos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.rbCodigoInventario)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalActivosDescargados)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvActivosDescargados)
        Me.Panel1.Location = New System.Drawing.Point(26, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 294)
        Me.Panel1.TabIndex = 113
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(458, 26)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(92, 17)
        Me.rbDepartamento.TabIndex = 28
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbNombreEmpleado
        '
        Me.rbNombreEmpleado.AutoSize = True
        Me.rbNombreEmpleado.Location = New System.Drawing.Point(306, 26)
        Me.rbNombreEmpleado.Name = "rbNombreEmpleado"
        Me.rbNombreEmpleado.Size = New System.Drawing.Size(112, 17)
        Me.rbNombreEmpleado.TabIndex = 27
        Me.rbNombreEmpleado.TabStop = True
        Me.rbNombreEmpleado.Text = "Nombre Empleado"
        Me.rbNombreEmpleado.UseVisualStyleBackColor = True
        '
        'rbCodigoInventario
        '
        Me.rbCodigoInventario.AutoSize = True
        Me.rbCodigoInventario.Location = New System.Drawing.Point(140, 26)
        Me.rbCodigoInventario.Name = "rbCodigoInventario"
        Me.rbCodigoInventario.Size = New System.Drawing.Size(123, 17)
        Me.rbCodigoInventario.TabIndex = 26
        Me.rbCodigoInventario.Text = "Codigo de Inventario"
        Me.rbCodigoInventario.UseVisualStyleBackColor = True
        '
        'rbNombreArticulo
        '
        Me.rbNombreArticulo.AutoSize = True
        Me.rbNombreArticulo.Checked = True
        Me.rbNombreArticulo.Location = New System.Drawing.Point(13, 26)
        Me.rbNombreArticulo.Name = "rbNombreArticulo"
        Me.rbNombreArticulo.Size = New System.Drawing.Size(100, 17)
        Me.rbNombreArticulo.TabIndex = 25
        Me.rbNombreArticulo.TabStop = True
        Me.rbNombreArticulo.Text = "Nombre Articulo"
        Me.rbNombreArticulo.UseVisualStyleBackColor = True
        '
        'lblTotalActivosDescargados
        '
        Me.lblTotalActivosDescargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalActivosDescargados.Location = New System.Drawing.Point(74, 274)
        Me.lblTotalActivosDescargados.Name = "lblTotalActivosDescargados"
        Me.lblTotalActivosDescargados.Size = New System.Drawing.Size(39, 15)
        Me.lblTotalActivosDescargados.TabIndex = 24
        Me.lblTotalActivosDescargados.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Registros"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(582, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(219, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvActivosDescargados
        '
        Me.dgvActivosDescargados.AllowUserToDeleteRows = False
        Me.dgvActivosDescargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivosDescargados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.NombreActivo, Me.CodigoInventario, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.DescripcioFechaAsignacionn, Me.Descripcion})
        Me.dgvActivosDescargados.Location = New System.Drawing.Point(0, 49)
        Me.dgvActivosDescargados.Name = "dgvActivosDescargados"
        Me.dgvActivosDescargados.ReadOnly = True
        Me.dgvActivosDescargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivosDescargados.Size = New System.Drawing.Size(801, 224)
        Me.dgvActivosDescargados.TabIndex = 0
        '
        'IdCargo
        '
        Me.IdCargo.DataPropertyName = "IdCargo"
        Me.IdCargo.HeaderText = "ID"
        Me.IdCargo.Name = "IdCargo"
        Me.IdCargo.ReadOnly = True
        Me.IdCargo.Visible = False
        '
        'NombreActivo
        '
        Me.NombreActivo.DataPropertyName = "NombreActivo"
        Me.NombreActivo.HeaderText = "NOMBRE DEL ACTIVO"
        Me.NombreActivo.Name = "NombreActivo"
        Me.NombreActivo.ReadOnly = True
        Me.NombreActivo.Width = 85
        '
        'CodigoInventario
        '
        Me.CodigoInventario.DataPropertyName = "CodigoInventario"
        Me.CodigoInventario.HeaderText = "CODIGO INVENTARIO"
        Me.CodigoInventario.Name = "CodigoInventario"
        Me.CodigoInventario.ReadOnly = True
        Me.CodigoInventario.Width = 150
        '
        'PrecioCompra
        '
        Me.PrecioCompra.DataPropertyName = "PrecioCompra"
        Me.PrecioCompra.HeaderText = "PRECIO DE COMPRA"
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE EMPLEADO"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 85
        '
        'Identidad
        '
        Me.Identidad.DataPropertyName = "Identidad"
        Me.Identidad.HeaderText = "IDENTIDAD"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        '
        'NombreD
        '
        Me.NombreD.DataPropertyName = "NombreD"
        Me.NombreD.HeaderText = "DEPARTAMENTO"
        Me.NombreD.Name = "NombreD"
        Me.NombreD.ReadOnly = True
        Me.NombreD.Visible = False
        Me.NombreD.Width = 80
        '
        'DescripcioFechaAsignacionn
        '
        Me.DescripcioFechaAsignacionn.DataPropertyName = "FechaAsignacion"
        Me.DescripcioFechaAsignacionn.HeaderText = "FECHA DE ASIGNACION"
        Me.DescripcioFechaAsignacionn.Name = "DescripcioFechaAsignacionn"
        Me.DescripcioFechaAsignacionn.ReadOnly = True
        Me.DescripcioFechaAsignacionn.Width = 120
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(679, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(71, 35)
        Me.btnBuscar.TabIndex = 112
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(756, 69)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 35)
        Me.btnCancelar.TabIndex = 111
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(756, 33)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(71, 35)
        Me.btnEliminar.TabIndex = 110
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(679, 33)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(71, 35)
        Me.btnEditar.TabIndex = 109
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(756, -3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 35)
        Me.btnGuardar.TabIndex = 108
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(679, -3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 35)
        Me.btnNuevo.TabIndex = 107
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cboMotivo
        '
        Me.cboMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"Obsoleto", "Cambio"})
        Me.cboMotivo.Location = New System.Drawing.Point(547, 62)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(94, 21)
        Me.cboMotivo.TabIndex = 106
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(547, 9)
        Me.txtPrecio.Multiline = True
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(94, 20)
        Me.txtPrecio.TabIndex = 105
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(332, 33)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.ReadOnly = True
        Me.txtNombreE.Size = New System.Drawing.Size(132, 20)
        Me.txtNombreE.TabIndex = 104
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(89, 112)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(706, 58)
        Me.txtDescripcion.TabIndex = 102
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(332, 7)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.ReadOnly = True
        Me.txtNombreA.Size = New System.Drawing.Size(132, 20)
        Me.txtNombreA.TabIndex = 101
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(647, 63)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(26, 20)
        Me.txtIdEmpleado.TabIndex = 100
        Me.txtIdEmpleado.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(488, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 26)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Motivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Descargo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Nombre Empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Codigo Inventario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "N. Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Nombre Articulo"
        '
        'DTPFechaDescargo
        '
        Me.DTPFechaDescargo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaDescargo.Location = New System.Drawing.Point(332, 59)
        Me.DTPFechaDescargo.Name = "DTPFechaDescargo"
        Me.DTPFechaDescargo.Size = New System.Drawing.Size(133, 20)
        Me.DTPFechaDescargo.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 26)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Descargo "
        '
        'frmDescargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 477)
        Me.Controls.Add(Me.DTPFechaDescargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdCargo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtCodigoI)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.btnCargos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboMotivo)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDescargoActivos"
        Me.Text = "Registro de Bajas de Activos Fijos de Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvActivosDescargados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdCargo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtCodigoI As TextBox
    Friend WithEvents DTPFechaEntrega As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents btnCargos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents rbCodigoInventario As RadioButton
    Friend WithEvents rbNombreArticulo As RadioButton
    Friend WithEvents lblTotalActivosDescargados As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvActivosDescargados As DataGridView
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents NombreActivo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents DescripcioFechaAsignacionn As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cboMotivo As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFechaDescargo As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
