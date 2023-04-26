
namespace COOPERATIVAahcr
{
    partial class gestionSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.volverAtras = new System.Windows.Forms.Button();
            this.dgGestionSocios = new System.Windows.Forms.DataGridView();
            this.cedulaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmTelefonoMovilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmTelefonoResidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacionUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreCrediticioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaCooperativaDataSet = new COOPERATIVAahcr.sistemaCooperativaDataSet();
            this.uSUARIOSTableAdapter = new COOPERATIVAahcr.sistemaCooperativaDataSetTableAdapters.USUARIOSTableAdapter();
            this.cedulausuario = new System.Windows.Forms.TextBox();
            this.nombreUser = new System.Windows.Forms.TextBox();
            this.apellidoUser = new System.Windows.Forms.TextBox();
            this.contraseñaUser = new System.Windows.Forms.TextBox();
            this.telMovil = new System.Windows.Forms.TextBox();
            this.direccionResidencia = new System.Windows.Forms.TextBox();
            this.correoElectronico = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.rolUser = new System.Windows.Forms.TextBox();
            this.statusUser = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.TextBox();
            this.referencias = new System.Windows.Forms.TextBox();
            this.ocupacionUsuario = new System.Windows.Forms.TextBox();
            this.telResidencia = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.apellidoUsuario = new System.Windows.Forms.Label();
            this.contraseñaUsuario = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.Label();
            this.telefonoMovil = new System.Windows.Forms.Label();
            this.telefonoResidencia = new System.Windows.Forms.Label();
            this.statusUsuario = new System.Windows.Forms.Label();
            this.rolUsuario = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.Label();
            this.scoreCredito = new System.Windows.Forms.Label();
            this.refPersonal = new System.Windows.Forms.Label();
            this.ocupacion = new System.Windows.Forms.Label();
            this.nombreUsuarioLogIn = new System.Windows.Forms.Label();
            this.logInUser = new System.Windows.Forms.TextBox();
            this.agregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE SOCIOS ";
            // 
            // volverAtras
            // 
            this.volverAtras.Location = new System.Drawing.Point(834, 377);
            this.volverAtras.Name = "volverAtras";
            this.volverAtras.Size = new System.Drawing.Size(106, 66);
            this.volverAtras.TabIndex = 1;
            this.volverAtras.Tag = "";
            this.volverAtras.Text = "VOLVER ATRÁS";
            this.volverAtras.UseVisualStyleBackColor = true;
            this.volverAtras.Click += new System.EventHandler(this.volverAtras_Click);
            // 
            // dgGestionSocios
            // 
            this.dgGestionSocios.AutoGenerateColumns = false;
            this.dgGestionSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn1,
            this.apellidoUsuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.direcciónUsuarioDataGridViewTextBoxColumn,
            this.nmTelefonoMovilDataGridViewTextBoxColumn,
            this.nmTelefonoResidencialDataGridViewTextBoxColumn,
            this.statusUsuarioDataGridViewTextBoxColumn,
            this.ocupacionUsuarioDataGridViewTextBoxColumn,
            this.refPersonalDataGridViewTextBoxColumn,
            this.scoreCrediticioDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.rolUsuarioDataGridViewTextBoxColumn,
            this.numCuentaDataGridViewTextBoxColumn,
            this.idPrestamoDataGridViewTextBoxColumn});
            this.dgGestionSocios.DataSource = this.uSUARIOSBindingSource;
            this.dgGestionSocios.Location = new System.Drawing.Point(12, 29);
            this.dgGestionSocios.Name = "dgGestionSocios";
            this.dgGestionSocios.RowHeadersWidth = 51;
            this.dgGestionSocios.RowTemplate.Height = 24;
            this.dgGestionSocios.Size = new System.Drawing.Size(925, 242);
            this.dgGestionSocios.TabIndex = 2;
            this.dgGestionSocios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGestionSocios_CellContentClick);
            // 
            // cedulaUsuarioDataGridViewTextBoxColumn
            // 
            this.cedulaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "cedulaUsuario";
            this.cedulaUsuarioDataGridViewTextBoxColumn.HeaderText = "cedulaUsuario";
            this.cedulaUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedulaUsuarioDataGridViewTextBoxColumn.Name = "cedulaUsuarioDataGridViewTextBoxColumn";
            this.cedulaUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn1
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn1.DataPropertyName = "nombre_Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn1.HeaderText = "nombre_Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreUsuarioDataGridViewTextBoxColumn1.Name = "nombreUsuarioDataGridViewTextBoxColumn1";
            this.nombreUsuarioDataGridViewTextBoxColumn1.Width = 125;
            // 
            // apellidoUsuarioDataGridViewTextBoxColumn
            // 
            this.apellidoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "apellidoUsuario";
            this.apellidoUsuarioDataGridViewTextBoxColumn.HeaderText = "apellidoUsuario";
            this.apellidoUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoUsuarioDataGridViewTextBoxColumn.Name = "apellidoUsuarioDataGridViewTextBoxColumn";
            this.apellidoUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "correoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "correoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direcciónUsuarioDataGridViewTextBoxColumn
            // 
            this.direcciónUsuarioDataGridViewTextBoxColumn.DataPropertyName = "direcciónUsuario";
            this.direcciónUsuarioDataGridViewTextBoxColumn.HeaderText = "direcciónUsuario";
            this.direcciónUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direcciónUsuarioDataGridViewTextBoxColumn.Name = "direcciónUsuarioDataGridViewTextBoxColumn";
            this.direcciónUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nmTelefonoMovilDataGridViewTextBoxColumn
            // 
            this.nmTelefonoMovilDataGridViewTextBoxColumn.DataPropertyName = "nmTelefonoMovil";
            this.nmTelefonoMovilDataGridViewTextBoxColumn.HeaderText = "nmTelefonoMovil";
            this.nmTelefonoMovilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nmTelefonoMovilDataGridViewTextBoxColumn.Name = "nmTelefonoMovilDataGridViewTextBoxColumn";
            this.nmTelefonoMovilDataGridViewTextBoxColumn.Width = 125;
            // 
            // nmTelefonoResidencialDataGridViewTextBoxColumn
            // 
            this.nmTelefonoResidencialDataGridViewTextBoxColumn.DataPropertyName = "nmTelefonoResidencial";
            this.nmTelefonoResidencialDataGridViewTextBoxColumn.HeaderText = "nmTelefonoResidencial";
            this.nmTelefonoResidencialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nmTelefonoResidencialDataGridViewTextBoxColumn.Name = "nmTelefonoResidencialDataGridViewTextBoxColumn";
            this.nmTelefonoResidencialDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusUsuarioDataGridViewTextBoxColumn
            // 
            this.statusUsuarioDataGridViewTextBoxColumn.DataPropertyName = "statusUsuario";
            this.statusUsuarioDataGridViewTextBoxColumn.HeaderText = "statusUsuario";
            this.statusUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusUsuarioDataGridViewTextBoxColumn.Name = "statusUsuarioDataGridViewTextBoxColumn";
            this.statusUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // ocupacionUsuarioDataGridViewTextBoxColumn
            // 
            this.ocupacionUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ocupacionUsuario";
            this.ocupacionUsuarioDataGridViewTextBoxColumn.HeaderText = "ocupacionUsuario";
            this.ocupacionUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ocupacionUsuarioDataGridViewTextBoxColumn.Name = "ocupacionUsuarioDataGridViewTextBoxColumn";
            this.ocupacionUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // refPersonalDataGridViewTextBoxColumn
            // 
            this.refPersonalDataGridViewTextBoxColumn.DataPropertyName = "refPersonal";
            this.refPersonalDataGridViewTextBoxColumn.HeaderText = "refPersonal";
            this.refPersonalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refPersonalDataGridViewTextBoxColumn.Name = "refPersonalDataGridViewTextBoxColumn";
            this.refPersonalDataGridViewTextBoxColumn.Width = 125;
            // 
            // scoreCrediticioDataGridViewTextBoxColumn
            // 
            this.scoreCrediticioDataGridViewTextBoxColumn.DataPropertyName = "scoreCrediticio";
            this.scoreCrediticioDataGridViewTextBoxColumn.HeaderText = "scoreCrediticio";
            this.scoreCrediticioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoreCrediticioDataGridViewTextBoxColumn.Name = "scoreCrediticioDataGridViewTextBoxColumn";
            this.scoreCrediticioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "fechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "fechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // rolUsuarioDataGridViewTextBoxColumn
            // 
            this.rolUsuarioDataGridViewTextBoxColumn.DataPropertyName = "rolUsuario";
            this.rolUsuarioDataGridViewTextBoxColumn.HeaderText = "rolUsuario";
            this.rolUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolUsuarioDataGridViewTextBoxColumn.Name = "rolUsuarioDataGridViewTextBoxColumn";
            this.rolUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // numCuentaDataGridViewTextBoxColumn
            // 
            this.numCuentaDataGridViewTextBoxColumn.DataPropertyName = "numCuenta";
            this.numCuentaDataGridViewTextBoxColumn.HeaderText = "numCuenta";
            this.numCuentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numCuentaDataGridViewTextBoxColumn.Name = "numCuentaDataGridViewTextBoxColumn";
            this.numCuentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPrestamoDataGridViewTextBoxColumn
            // 
            this.idPrestamoDataGridViewTextBoxColumn.DataPropertyName = "idPrestamo";
            this.idPrestamoDataGridViewTextBoxColumn.HeaderText = "idPrestamo";
            this.idPrestamoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPrestamoDataGridViewTextBoxColumn.Name = "idPrestamoDataGridViewTextBoxColumn";
            this.idPrestamoDataGridViewTextBoxColumn.Width = 125;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sistemaCooperativaDataSet;
            // 
            // sistemaCooperativaDataSet
            // 
            this.sistemaCooperativaDataSet.DataSetName = "sistemaCooperativaDataSet";
            this.sistemaCooperativaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // cedulausuario
            // 
            this.cedulausuario.Location = new System.Drawing.Point(177, 295);
            this.cedulausuario.Name = "cedulausuario";
            this.cedulausuario.Size = new System.Drawing.Size(286, 22);
            this.cedulausuario.TabIndex = 3;
            // 
            // nombreUser
            // 
            this.nombreUser.Location = new System.Drawing.Point(109, 351);
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.Size = new System.Drawing.Size(126, 22);
            this.nombreUser.TabIndex = 4;
            // 
            // apellidoUser
            // 
            this.apellidoUser.Location = new System.Drawing.Point(109, 379);
            this.apellidoUser.Name = "apellidoUser";
            this.apellidoUser.Size = new System.Drawing.Size(126, 22);
            this.apellidoUser.TabIndex = 5;
            // 
            // contraseñaUser
            // 
            this.contraseñaUser.Location = new System.Drawing.Point(109, 407);
            this.contraseñaUser.Name = "contraseñaUser";
            this.contraseñaUser.Size = new System.Drawing.Size(126, 22);
            this.contraseñaUser.TabIndex = 6;
            // 
            // telMovil
            // 
            this.telMovil.Location = new System.Drawing.Point(109, 491);
            this.telMovil.Name = "telMovil";
            this.telMovil.Size = new System.Drawing.Size(126, 22);
            this.telMovil.TabIndex = 7;
            // 
            // direccionResidencia
            // 
            this.direccionResidencia.Location = new System.Drawing.Point(109, 463);
            this.direccionResidencia.Name = "direccionResidencia";
            this.direccionResidencia.Size = new System.Drawing.Size(126, 22);
            this.direccionResidencia.TabIndex = 8;
            // 
            // correoElectronico
            // 
            this.correoElectronico.Location = new System.Drawing.Point(109, 435);
            this.correoElectronico.Name = "correoElectronico";
            this.correoElectronico.Size = new System.Drawing.Size(126, 22);
            this.correoElectronico.TabIndex = 9;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(401, 435);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(126, 22);
            this.fecha.TabIndex = 16;
            // 
            // rolUser
            // 
            this.rolUser.Location = new System.Drawing.Point(401, 463);
            this.rolUser.Name = "rolUser";
            this.rolUser.Size = new System.Drawing.Size(126, 22);
            this.rolUser.TabIndex = 15;
            // 
            // statusUser
            // 
            this.statusUser.Location = new System.Drawing.Point(401, 491);
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(126, 22);
            this.statusUser.TabIndex = 14;
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(401, 407);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(126, 22);
            this.score.TabIndex = 13;
            // 
            // referencias
            // 
            this.referencias.Location = new System.Drawing.Point(401, 379);
            this.referencias.Name = "referencias";
            this.referencias.Size = new System.Drawing.Size(126, 22);
            this.referencias.TabIndex = 12;
            // 
            // ocupacionUsuario
            // 
            this.ocupacionUsuario.Location = new System.Drawing.Point(401, 351);
            this.ocupacionUsuario.Name = "ocupacionUsuario";
            this.ocupacionUsuario.Size = new System.Drawing.Size(126, 22);
            this.ocupacionUsuario.TabIndex = 11;
            // 
            // telResidencia
            // 
            this.telResidencia.Location = new System.Drawing.Point(401, 323);
            this.telResidencia.Name = "telResidencia";
            this.telResidencia.Size = new System.Drawing.Size(126, 22);
            this.telResidencia.TabIndex = 10;
            // 
            // cedula
            // 
            this.cedula.AutoSize = true;
            this.cedula.Location = new System.Drawing.Point(73, 296);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(105, 17);
            this.cedula.TabIndex = 17;
            this.cedula.Text = "CedulaUsuario:";
            this.cedula.Click += new System.EventHandler(this.NombreUsuario_Click);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(10, 356);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(96, 17);
            this.nombreUsuario.TabIndex = 18;
            this.nombreUsuario.Text = "Nombre User:";
            // 
            // apellidoUsuario
            // 
            this.apellidoUsuario.AutoSize = true;
            this.apellidoUsuario.Location = new System.Drawing.Point(9, 384);
            this.apellidoUsuario.Name = "apellidoUsuario";
            this.apellidoUsuario.Size = new System.Drawing.Size(100, 17);
            this.apellidoUsuario.TabIndex = 19;
            this.apellidoUsuario.Text = "Apellido User: ";
            // 
            // contraseñaUsuario
            // 
            this.contraseñaUsuario.AutoSize = true;
            this.contraseñaUsuario.Location = new System.Drawing.Point(10, 408);
            this.contraseñaUsuario.Name = "contraseñaUsuario";
            this.contraseñaUsuario.Size = new System.Drawing.Size(85, 17);
            this.contraseñaUsuario.TabIndex = 20;
            this.contraseñaUsuario.Text = "Contraseña:";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Location = new System.Drawing.Point(10, 438);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(90, 17);
            this.correo.TabIndex = 21;
            this.correo.Text = "Correo Elect:";
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(10, 466);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 17);
            this.direccion.TabIndex = 22;
            this.direccion.Text = "Dirección Res:";
            // 
            // telefonoMovil
            // 
            this.telefonoMovil.AutoSize = true;
            this.telefonoMovil.Location = new System.Drawing.Point(10, 494);
            this.telefonoMovil.Name = "telefonoMovil";
            this.telefonoMovil.Size = new System.Drawing.Size(80, 17);
            this.telefonoMovil.TabIndex = 23;
            this.telefonoMovil.Text = "Teléf Móvil:";
            this.telefonoMovil.Click += new System.EventHandler(this.label8_Click);
            // 
            // telefonoResidencia
            // 
            this.telefonoResidencia.AutoSize = true;
            this.telefonoResidencia.Location = new System.Drawing.Point(273, 326);
            this.telefonoResidencia.Name = "telefonoResidencia";
            this.telefonoResidencia.Size = new System.Drawing.Size(122, 17);
            this.telefonoResidencia.TabIndex = 24;
            this.telefonoResidencia.Text = "Teléf. Residencia:";
            // 
            // statusUsuario
            // 
            this.statusUsuario.AutoSize = true;
            this.statusUsuario.Location = new System.Drawing.Point(273, 496);
            this.statusUsuario.Name = "statusUsuario";
            this.statusUsuario.Size = new System.Drawing.Size(109, 17);
            this.statusUsuario.TabIndex = 30;
            this.statusUsuario.Text = "Status Usuario: ";
            // 
            // rolUsuario
            // 
            this.rolUsuario.AutoSize = true;
            this.rolUsuario.Location = new System.Drawing.Point(273, 468);
            this.rolUsuario.Name = "rolUsuario";
            this.rolUsuario.Size = new System.Drawing.Size(86, 17);
            this.rolUsuario.TabIndex = 29;
            this.rolUsuario.Text = "Rol Usuario:";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSize = true;
            this.fechaIngreso.Location = new System.Drawing.Point(273, 440);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(102, 17);
            this.fechaIngreso.TabIndex = 28;
            this.fechaIngreso.Text = "Fecha Ingreso:";
            // 
            // scoreCredito
            // 
            this.scoreCredito.AutoSize = true;
            this.scoreCredito.Location = new System.Drawing.Point(273, 410);
            this.scoreCredito.Name = "scoreCredito";
            this.scoreCredito.Size = new System.Drawing.Size(111, 17);
            this.scoreCredito.TabIndex = 27;
            this.scoreCredito.Text = "Score Crediticio:";
            // 
            // refPersonal
            // 
            this.refPersonal.AutoSize = true;
            this.refPersonal.Location = new System.Drawing.Point(273, 382);
            this.refPersonal.Name = "refPersonal";
            this.refPersonal.Size = new System.Drawing.Size(113, 17);
            this.refPersonal.TabIndex = 26;
            this.refPersonal.Text = "Ref. Personales:";
            // 
            // ocupacion
            // 
            this.ocupacion.AutoSize = true;
            this.ocupacion.Location = new System.Drawing.Point(273, 354);
            this.ocupacion.Name = "ocupacion";
            this.ocupacion.Size = new System.Drawing.Size(133, 17);
            this.ocupacion.TabIndex = 25;
            this.ocupacion.Text = "Ocupación Usuario:";
            // 
            // nombreUsuarioLogIn
            // 
            this.nombreUsuarioLogIn.AutoSize = true;
            this.nombreUsuarioLogIn.Location = new System.Drawing.Point(10, 323);
            this.nombreUsuarioLogIn.Name = "nombreUsuarioLogIn";
            this.nombreUsuarioLogIn.Size = new System.Drawing.Size(85, 17);
            this.nombreUsuarioLogIn.TabIndex = 32;
            this.nombreUsuarioLogIn.Text = "Log In User:";
            // 
            // logInUser
            // 
            this.logInUser.Location = new System.Drawing.Point(109, 322);
            this.logInUser.Name = "logInUser";
            this.logInUser.Size = new System.Drawing.Size(126, 22);
            this.logInUser.TabIndex = 31;
            // 
            // agregarUsuario
            // 
            this.agregarUsuario.Location = new System.Drawing.Point(39, 519);
            this.agregarUsuario.Name = "agregarUsuario";
            this.agregarUsuario.Size = new System.Drawing.Size(139, 63);
            this.agregarUsuario.TabIndex = 33;
            this.agregarUsuario.Text = "AGREGAR  NUEVO USUARIO";
            this.agregarUsuario.UseVisualStyleBackColor = true;
            this.agregarUsuario.Click += new System.EventHandler(this.agregarUsuario_Click);
            // 
            // gestionSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 593);
            this.Controls.Add(this.agregarUsuario);
            this.Controls.Add(this.nombreUsuarioLogIn);
            this.Controls.Add(this.logInUser);
            this.Controls.Add(this.statusUsuario);
            this.Controls.Add(this.rolUsuario);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.scoreCredito);
            this.Controls.Add(this.refPersonal);
            this.Controls.Add(this.ocupacion);
            this.Controls.Add(this.telefonoResidencia);
            this.Controls.Add(this.telefonoMovil);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.contraseñaUsuario);
            this.Controls.Add(this.apellidoUsuario);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.rolUser);
            this.Controls.Add(this.statusUser);
            this.Controls.Add(this.score);
            this.Controls.Add(this.referencias);
            this.Controls.Add(this.ocupacionUsuario);
            this.Controls.Add(this.telResidencia);
            this.Controls.Add(this.correoElectronico);
            this.Controls.Add(this.direccionResidencia);
            this.Controls.Add(this.telMovil);
            this.Controls.Add(this.contraseñaUser);
            this.Controls.Add(this.apellidoUser);
            this.Controls.Add(this.nombreUser);
            this.Controls.Add(this.cedulausuario);
            this.Controls.Add(this.dgGestionSocios);
            this.Controls.Add(this.volverAtras);
            this.Controls.Add(this.label1);
            this.Name = "gestionSocios";
            this.Text = "Gestión Socios";
            this.Load += new System.EventHandler(this.gestionSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverAtras;
        private System.Windows.Forms.DataGridView dgGestionSocios;
        private sistemaCooperativaDataSet sistemaCooperativaDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private sistemaCooperativaDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmTelefonoMovilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmTelefonoResidencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacionUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreCrediticioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cedulausuario;
        private System.Windows.Forms.TextBox nombreUser;
        private System.Windows.Forms.TextBox apellidoUser;
        private System.Windows.Forms.TextBox contraseñaUser;
        private System.Windows.Forms.TextBox telMovil;
        private System.Windows.Forms.TextBox direccionResidencia;
        private System.Windows.Forms.TextBox correoElectronico;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.TextBox rolUser;
        private System.Windows.Forms.TextBox statusUser;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.TextBox referencias;
        private System.Windows.Forms.TextBox ocupacionUsuario;
        private System.Windows.Forms.TextBox telResidencia;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label apellidoUsuario;
        private System.Windows.Forms.Label contraseñaUsuario;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.Label telefonoMovil;
        private System.Windows.Forms.Label telefonoResidencia;
        private System.Windows.Forms.Label statusUsuario;
        private System.Windows.Forms.Label rolUsuario;
        private System.Windows.Forms.Label fechaIngreso;
        private System.Windows.Forms.Label scoreCredito;
        private System.Windows.Forms.Label refPersonal;
        private System.Windows.Forms.Label ocupacion;
        private System.Windows.Forms.Label nombreUsuarioLogIn;
        private System.Windows.Forms.TextBox logInUser;
        private System.Windows.Forms.Button agregarUsuario;
    }
}