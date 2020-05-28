<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargoActivos
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
        Me.DTPFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbNombreEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCodigoInventario = New System.Windows.Forms.RadioButton()
        Me.rbNombreArticulo = New System.Windows.Forms.RadioButton()
        Me.lblTotalActivos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvActivosAsignados = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.txtCodigoInventario = New System.Windows.Forms.TextBox()
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdArticulo = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreActivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcioFechaAsignacionn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvActivosAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTPFechaEntrega
        '
        Me.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaEntrega.Location = New System.Drawing.Point(329, 82)
        Me.DTPFechaEntrega.Name = "DTPFechaEntrega"
        Me.DTPFechaEntrega.Size = New System.Drawing.Size(133, 20)
        Me.DTPFechaEntrega.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Fecha Entrega"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(96, 56)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(103, 20)
        Me.txtIdentidad.TabIndex = 81
        '
        'btnArticulos
        '
        Me.btnArticulos.Location = New System.Drawing.Point(201, 27)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(27, 23)
        Me.btnArticulos.TabIndex = 80
        Me.btnArticulos.Text = "..."
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbNombreEmpleado)
        Me.Panel1.Controls.Add(Me.rbCodigoInventario)
        Me.Panel1.Controls.Add(Me.rbNombreArticulo)
        Me.Panel1.Controls.Add(Me.lblTotalActivos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvActivosAsignados)
        Me.Panel1.Location = New System.Drawing.Point(23, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 294)
        Me.Panel1.TabIndex = 79
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
        'lblTotalActivos
        '
        Me.lblTotalActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalActivos.Location = New System.Drawing.Point(137, 276)
        Me.lblTotalActivos.Name = "lblTotalActivos"
        Me.lblTotalActivos.Size = New System.Drawing.Size(39, 15)
        Me.lblTotalActivos.TabIndex = 24
        Me.lblTotalActivos.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Empleados Registrados:"
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
        'dgvActivosAsignados
        '
        Me.dgvActivosAsignados.AllowUserToDeleteRows = False
        Me.dgvActivosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivosAsignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargo, Me.NombreActivo, Me.CodigoInventario, Me.PrecioCompra, Me.Nombre, Me.Identidad, Me.NombreD, Me.DescripcioFechaAsignacionn, Me.Descripcion})
        Me.dgvActivosAsignados.Location = New System.Drawing.Point(0, 49)
        Me.dgvActivosAsignados.Name = "dgvActivosAsignados"
        Me.dgvActivosAsignados.ReadOnly = True
        Me.dgvActivosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivosAsignados.Size = New System.Drawing.Size(801, 224)
        Me.dgvActivosAsignados.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(676, 92)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(71, 35)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(753, 92)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 35)
        Me.btnCancelar.TabIndex = 77
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(753, 56)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(71, 35)
        Me.btnEliminar.TabIndex = 76
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(676, 56)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(71, 35)
        Me.btnEditar.TabIndex = 75
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(753, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 35)
        Me.btnGuardar.TabIndex = 74
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(676, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 35)
        Me.btnNuevo.TabIndex = 73
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Nuevo", "Usado"})
        Me.cboEstado.Location = New System.Drawing.Point(544, 85)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(94, 21)
        Me.cboEstado.TabIndex = 72
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(544, 32)
        Me.txtPrecio.Multiline = True
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(94, 20)
        Me.txtPrecio.TabIndex = 71
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(329, 56)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.ReadOnly = True
        Me.txtNombreE.Size = New System.Drawing.Size(132, 20)
        Me.txtNombreE.TabIndex = 70
        '
        'txtCodigoInventario
        '
        Me.txtCodigoInventario.Location = New System.Drawing.Point(96, 82)
        Me.txtCodigoInventario.Name = "txtCodigoInventario"
        Me.txtCodigoInventario.Size = New System.Drawing.Size(132, 20)
        Me.txtCodigoInventario.TabIndex = 69
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(86, 135)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(706, 58)
        Me.txtDescripcion.TabIndex = 68
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(329, 30)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.ReadOnly = True
        Me.txtNombreA.Size = New System.Drawing.Size(132, 20)
        Me.txtNombreA.TabIndex = 67
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(644, 86)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(26, 20)
        Me.txtIdEmpleado.TabIndex = 66
        Me.txtIdEmpleado.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(478, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 39)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Estado del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Nombre Empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Codigo Inventario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "N. Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Nombre Articulo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(96, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(103, 20)
        Me.txtCodigo.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Codigo"
        '
        'txtIdArticulo
        '
        Me.txtIdArticulo.Location = New System.Drawing.Point(644, 58)
        Me.txtIdArticulo.Name = "txtIdArticulo"
        Me.txtIdArticulo.Size = New System.Drawing.Size(26, 20)
        Me.txtIdArticulo.TabIndex = 87
        Me.txtIdArticulo.Visible = False
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(544, 59)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(94, 20)
        Me.txtDepartamento.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(464, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Departamento"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(644, 30)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(26, 20)
        Me.txtId.TabIndex = 91
        Me.txtId.Visible = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Location = New System.Drawing.Point(201, 56)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(27, 23)
        Me.btnEmpleados.TabIndex = 92
        Me.btnEmpleados.Text = "..."
        Me.btnEmpleados.UseVisualStyleBackColor = True
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
        'frmCargoActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 497)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtIdArticulo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPFechaEntrega)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.txtCodigoInventario)
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
        Me.Name = "frmCargoActivos"
        Me.Text = "Asignacion de Activos a Empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvActivosAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTPFechaEntrega As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents btnArticulos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbNombreEmpleado As RadioButton
    Friend WithEvents rbCodigoInventario As RadioButton
    Friend WithEvents rbNombreArticulo As RadioButton
    Friend WithEvents lblTotalActivos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvActivosAsignados As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents txtCodigoInventario As TextBox
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
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdArticulo As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents NombreActivo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoInventario As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents NombreD As DataGridViewTextBoxColumn
    Friend WithEvents DescripcioFechaAsignacionn As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents rbDepartamento As RadioButton
End Class
