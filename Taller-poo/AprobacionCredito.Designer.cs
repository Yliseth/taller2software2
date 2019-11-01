namespace Taller_poo
{
    partial class AprobacionCredito
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AprobacionCredito));
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.lblNúmeroId = new System.Windows.Forms.Label();
            this.Numerodedocumento = new System.Windows.Forms.TextBox();
            this.cbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.tbxNombresApellidos = new System.Windows.Forms.TextBox();
            this.lblNombresApellidos = new System.Windows.Forms.Label();
            this.Creditosabiertos = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cbxTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCredito = new System.Windows.Forms.Label();
            this.tipoCredito = new System.Windows.Forms.ComboBox();
            this.lblMontoTotalCredito = new System.Windows.Forms.Label();
            this.txbPlazoPagos = new System.Windows.Forms.TextBox();
            this.lblPlazoPagos = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.gbxInformacionCliente = new System.Windows.Forms.GroupBox();
            this.numeroCreditosAbiertos = new System.Windows.Forms.TextBox();
            this.gbxInformacionCredito = new System.Windows.Forms.GroupBox();
            this.calculo = new System.Windows.Forms.Button();
            this.gbxInformacionPagos = new System.Windows.Forms.GroupBox();
            this.pagoatiempo = new System.Windows.Forms.ComboBox();
            this.Numerosdepagos = new System.Windows.Forms.TextBox();
            this.numeropagos = new System.Windows.Forms.Label();
            this.lblPagoRealizadoTiempo = new System.Windows.Forms.Label();
            this.lblMontoDineroCancelado = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechadePago = new System.Windows.Forms.Label();
            this.gbxDescuentos = new System.Windows.Forms.GroupBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbNombreAlmacen = new System.Windows.Forms.TextBox();
            this.lblNombreAlmacen = new System.Windows.Forms.Label();
            this.txbPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.lblPorcentajeDescuento = new System.Windows.Forms.Label();
            this.listaRegalos = new System.Windows.Forms.ListBox();
            this.listaRegalosEducacion = new System.Windows.Forms.ListBox();
            this.ResumenInformacion = new System.Windows.Forms.Button();
            this.txbMontoTotalCredito = new System.Windows.Forms.MaskedTextBox();
            this.montosCancelados = new System.Windows.Forms.MaskedTextBox();
            this.gbxInformacionCliente.SuspendLayout();
            this.gbxInformacionCredito.SuspendLayout();
            this.gbxInformacionPagos.SuspendLayout();
            this.gbxDescuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(11, 62);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(164, 17);
            this.lblTipoIdentificacion.TabIndex = 0;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación";
            // 
            // lblNúmeroId
            // 
            this.lblNúmeroId.AutoSize = true;
            this.lblNúmeroId.Location = new System.Drawing.Point(11, 86);
            this.lblNúmeroId.Name = "lblNúmeroId";
            this.lblNúmeroId.Size = new System.Drawing.Size(191, 17);
            this.lblNúmeroId.TabIndex = 1;
            this.lblNúmeroId.Text = "Número de Identificación";
            // 
            // Numerodedocumento
            // 
            this.Numerodedocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Numerodedocumento.Location = new System.Drawing.Point(274, 86);
            this.Numerodedocumento.MaxLength = 15;
            this.Numerodedocumento.Name = "Numerodedocumento";
            this.Numerodedocumento.Size = new System.Drawing.Size(257, 25);
            this.Numerodedocumento.TabIndex = 2;
            this.Numerodedocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cbTipoIdentificacion
            // 
            this.cbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoIdentificacion.FormattingEnabled = true;
            this.cbTipoIdentificacion.Items.AddRange(new object[] {
            "Cédula Ciudadanía",
            "Cédula extranjería",
            "Pasaporte"});
            this.cbTipoIdentificacion.Location = new System.Drawing.Point(274, 59);
            this.cbTipoIdentificacion.Name = "cbTipoIdentificacion";
            this.cbTipoIdentificacion.Size = new System.Drawing.Size(257, 25);
            this.cbTipoIdentificacion.TabIndex = 3;
            // 
            // tbxNombresApellidos
            // 
            this.tbxNombresApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNombresApellidos.Location = new System.Drawing.Point(274, 109);
            this.tbxNombresApellidos.MaxLength = 50;
            this.tbxNombresApellidos.Name = "tbxNombresApellidos";
            this.tbxNombresApellidos.Size = new System.Drawing.Size(257, 25);
            this.tbxNombresApellidos.TabIndex = 4;
            this.tbxNombresApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombresApellidos_KeyPress);
            // 
            // lblNombresApellidos
            // 
            this.lblNombresApellidos.AutoSize = true;
            this.lblNombresApellidos.Location = new System.Drawing.Point(11, 112);
            this.lblNombresApellidos.Name = "lblNombresApellidos";
            this.lblNombresApellidos.Size = new System.Drawing.Size(157, 17);
            this.lblNombresApellidos.TabIndex = 6;
            this.lblNombresApellidos.Text = "Nombres y Apellidos";
            // 
            // Creditosabiertos
            // 
            this.Creditosabiertos.AutoSize = true;
            this.Creditosabiertos.Location = new System.Drawing.Point(11, 138);
            this.Creditosabiertos.Name = "Creditosabiertos";
            this.Creditosabiertos.Size = new System.Drawing.Size(257, 17);
            this.Creditosabiertos.TabIndex = 7;
            this.Creditosabiertos.Text = "Créditos abiertos con la compañia";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(11, 34);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(94, 17);
            this.lblTipoCliente.TabIndex = 8;
            this.lblTipoCliente.Text = "Tipo Cliente";
            // 
            // cbxTipoCliente
            // 
            this.cbxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCliente.FormattingEnabled = true;
            this.cbxTipoCliente.Items.AddRange(new object[] {
            "Oro",
            "Plata",
            "Bronce"});
            this.cbxTipoCliente.Location = new System.Drawing.Point(274, 31);
            this.cbxTipoCliente.Name = "cbxTipoCliente";
            this.cbxTipoCliente.Size = new System.Drawing.Size(257, 25);
            this.cbxTipoCliente.TabIndex = 9;
            // 
            // lblTipoCredito
            // 
            this.lblTipoCredito.AutoSize = true;
            this.lblTipoCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCredito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoCredito.Location = new System.Drawing.Point(6, 54);
            this.lblTipoCredito.Name = "lblTipoCredito";
            this.lblTipoCredito.Size = new System.Drawing.Size(97, 17);
            this.lblTipoCredito.TabIndex = 10;
            this.lblTipoCredito.Text = "Tipo Credito";
            // 
            // tipoCredito
            // 
            this.tipoCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCredito.FormattingEnabled = true;
            this.tipoCredito.Items.AddRange(new object[] {
            "Vivienda",
            "Educación",
            "Libre inversión"});
            this.tipoCredito.Location = new System.Drawing.Point(192, 50);
            this.tipoCredito.Name = "tipoCredito";
            this.tipoCredito.Size = new System.Drawing.Size(257, 26);
            this.tipoCredito.TabIndex = 11;
            // 
            // lblMontoTotalCredito
            // 
            this.lblMontoTotalCredito.AutoSize = true;
            this.lblMontoTotalCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalCredito.Location = new System.Drawing.Point(2, 94);
            this.lblMontoTotalCredito.Name = "lblMontoTotalCredito";
            this.lblMontoTotalCredito.Size = new System.Drawing.Size(176, 17);
            this.lblMontoTotalCredito.TabIndex = 12;
            this.lblMontoTotalCredito.Text = "Monto Total del Crédito";
            // 
            // txbPlazoPagos
            // 
            this.txbPlazoPagos.Location = new System.Drawing.Point(192, 125);
            this.txbPlazoPagos.Name = "txbPlazoPagos";
            this.txbPlazoPagos.Size = new System.Drawing.Size(257, 26);
            this.txbPlazoPagos.TabIndex = 14;
            this.txbPlazoPagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPlazoPagos_KeyPress);
            // 
            // lblPlazoPagos
            // 
            this.lblPlazoPagos.AutoSize = true;
            this.lblPlazoPagos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazoPagos.Location = new System.Drawing.Point(6, 131);
            this.lblPlazoPagos.Name = "lblPlazoPagos";
            this.lblPlazoPagos.Size = new System.Drawing.Size(180, 17);
            this.lblPlazoPagos.TabIndex = 15;
            this.lblPlazoPagos.Text = "Plazo de Pagos (meses)";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 169);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(119, 17);
            this.lblFechaInicio.TabIndex = 16;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(192, 169);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(257, 26);
            this.dtpFechaInicio.TabIndex = 17;
            // 
            // gbxInformacionCliente
            // 
            this.gbxInformacionCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxInformacionCliente.Controls.Add(this.numeroCreditosAbiertos);
            this.gbxInformacionCliente.Controls.Add(this.lblTipoCliente);
            this.gbxInformacionCliente.Controls.Add(this.lblTipoIdentificacion);
            this.gbxInformacionCliente.Controls.Add(this.lblNúmeroId);
            this.gbxInformacionCliente.Controls.Add(this.Numerodedocumento);
            this.gbxInformacionCliente.Controls.Add(this.cbTipoIdentificacion);
            this.gbxInformacionCliente.Controls.Add(this.tbxNombresApellidos);
            this.gbxInformacionCliente.Controls.Add(this.lblNombresApellidos);
            this.gbxInformacionCliente.Controls.Add(this.Creditosabiertos);
            this.gbxInformacionCliente.Controls.Add(this.cbxTipoCliente);
            this.gbxInformacionCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionCliente.Location = new System.Drawing.Point(253, 12);
            this.gbxInformacionCliente.Name = "gbxInformacionCliente";
            this.gbxInformacionCliente.Size = new System.Drawing.Size(545, 171);
            this.gbxInformacionCliente.TabIndex = 19;
            this.gbxInformacionCliente.TabStop = false;
            this.gbxInformacionCliente.Text = "Infomación Cliente";
            // 
            // numeroCreditosAbiertos
            // 
            this.numeroCreditosAbiertos.Location = new System.Drawing.Point(274, 135);
            this.numeroCreditosAbiertos.Name = "numeroCreditosAbiertos";
            this.numeroCreditosAbiertos.Size = new System.Drawing.Size(257, 25);
            this.numeroCreditosAbiertos.TabIndex = 19;
            this.numeroCreditosAbiertos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroCreditosAbiertos_KeyPress);
            // 
            // gbxInformacionCredito
            // 
            this.gbxInformacionCredito.BackColor = System.Drawing.Color.White;
            this.gbxInformacionCredito.Controls.Add(this.txbMontoTotalCredito);
            this.gbxInformacionCredito.Controls.Add(this.lblTipoCredito);
            this.gbxInformacionCredito.Controls.Add(this.tipoCredito);
            this.gbxInformacionCredito.Controls.Add(this.lblMontoTotalCredito);
            this.gbxInformacionCredito.Controls.Add(this.dtpFechaInicio);
            this.gbxInformacionCredito.Controls.Add(this.lblFechaInicio);
            this.gbxInformacionCredito.Controls.Add(this.txbPlazoPagos);
            this.gbxInformacionCredito.Controls.Add(this.lblPlazoPagos);
            this.gbxInformacionCredito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionCredito.Location = new System.Drawing.Point(12, 189);
            this.gbxInformacionCredito.Name = "gbxInformacionCredito";
            this.gbxInformacionCredito.Size = new System.Drawing.Size(466, 220);
            this.gbxInformacionCredito.TabIndex = 20;
            this.gbxInformacionCredito.TabStop = false;
            this.gbxInformacionCredito.Text = "Información Crédito";
            // 
            // calculo
            // 
            this.calculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculo.Location = new System.Drawing.Point(333, 599);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(158, 74);
            this.calculo.TabIndex = 23;
            this.calculo.Text = "APROBACIÓN DE CREDITO";
            this.calculo.UseVisualStyleBackColor = true;
            this.calculo.Click += new System.EventHandler(this.calculo_Click);
            // 
            // gbxInformacionPagos
            // 
            this.gbxInformacionPagos.BackColor = System.Drawing.Color.White;
            this.gbxInformacionPagos.Controls.Add(this.montosCancelados);
            this.gbxInformacionPagos.Controls.Add(this.pagoatiempo);
            this.gbxInformacionPagos.Controls.Add(this.Numerosdepagos);
            this.gbxInformacionPagos.Controls.Add(this.numeropagos);
            this.gbxInformacionPagos.Controls.Add(this.lblPagoRealizadoTiempo);
            this.gbxInformacionPagos.Controls.Add(this.lblMontoDineroCancelado);
            this.gbxInformacionPagos.Controls.Add(this.dtpFechaPago);
            this.gbxInformacionPagos.Controls.Add(this.lblFechadePago);
            this.gbxInformacionPagos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionPagos.Location = new System.Drawing.Point(503, 189);
            this.gbxInformacionPagos.Name = "gbxInformacionPagos";
            this.gbxInformacionPagos.Size = new System.Drawing.Size(477, 220);
            this.gbxInformacionPagos.TabIndex = 21;
            this.gbxInformacionPagos.TabStop = false;
            this.gbxInformacionPagos.Text = "Información Pagos";
            // 
            // pagoatiempo
            // 
            this.pagoatiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagoatiempo.FormattingEnabled = true;
            this.pagoatiempo.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.pagoatiempo.Location = new System.Drawing.Point(214, 144);
            this.pagoatiempo.Name = "pagoatiempo";
            this.pagoatiempo.Size = new System.Drawing.Size(257, 26);
            this.pagoatiempo.TabIndex = 26;
            // 
            // Numerosdepagos
            // 
            this.Numerosdepagos.Location = new System.Drawing.Point(214, 112);
            this.Numerosdepagos.Name = "Numerosdepagos";
            this.Numerosdepagos.Size = new System.Drawing.Size(257, 26);
            this.Numerosdepagos.TabIndex = 25;
            this.Numerosdepagos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerosdepagos_KeyPress);
            // 
            // numeropagos
            // 
            this.numeropagos.AutoSize = true;
            this.numeropagos.Location = new System.Drawing.Point(6, 120);
            this.numeropagos.Name = "numeropagos";
            this.numeropagos.Size = new System.Drawing.Size(144, 18);
            this.numeropagos.TabIndex = 24;
            this.numeropagos.Text = "Numero pagados";
            // 
            // lblPagoRealizadoTiempo
            // 
            this.lblPagoRealizadoTiempo.AutoSize = true;
            this.lblPagoRealizadoTiempo.Location = new System.Drawing.Point(9, 147);
            this.lblPagoRealizadoTiempo.Name = "lblPagoRealizadoTiempo";
            this.lblPagoRealizadoTiempo.Size = new System.Drawing.Size(125, 18);
            this.lblPagoRealizadoTiempo.TabIndex = 4;
            this.lblPagoRealizadoTiempo.Text = "Pago a Tiempo";
            // 
            // lblMontoDineroCancelado
            // 
            this.lblMontoDineroCancelado.AutoSize = true;
            this.lblMontoDineroCancelado.Location = new System.Drawing.Point(5, 94);
            this.lblMontoDineroCancelado.Name = "lblMontoDineroCancelado";
            this.lblMontoDineroCancelado.Size = new System.Drawing.Size(204, 18);
            this.lblMontoDineroCancelado.TabIndex = 2;
            this.lblMontoDineroCancelado.Text = "Monto Dinero Cancelado";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(214, 61);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(257, 26);
            this.dtpFechaPago.TabIndex = 1;
            // 
            // lblFechadePago
            // 
            this.lblFechadePago.AutoSize = true;
            this.lblFechadePago.Location = new System.Drawing.Point(5, 67);
            this.lblFechadePago.Name = "lblFechadePago";
            this.lblFechadePago.Size = new System.Drawing.Size(126, 18);
            this.lblFechadePago.TabIndex = 0;
            this.lblFechadePago.Text = "Fecha de pago";
            // 
            // gbxDescuentos
            // 
            this.gbxDescuentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDescuentos.Controls.Add(this.txbDireccion);
            this.gbxDescuentos.Controls.Add(this.lblDireccion);
            this.gbxDescuentos.Controls.Add(this.txbNombreAlmacen);
            this.gbxDescuentos.Controls.Add(this.lblNombreAlmacen);
            this.gbxDescuentos.Controls.Add(this.txbPorcentajeDescuento);
            this.gbxDescuentos.Controls.Add(this.lblPorcentajeDescuento);
            this.gbxDescuentos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDescuentos.Location = new System.Drawing.Point(333, 415);
            this.gbxDescuentos.Name = "gbxDescuentos";
            this.gbxDescuentos.Size = new System.Drawing.Size(379, 150);
            this.gbxDescuentos.TabIndex = 22;
            this.gbxDescuentos.TabStop = false;
            this.gbxDescuentos.Text = "Descuentos";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(204, 89);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(159, 25);
            this.txbDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 92);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(79, 17);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // txbNombreAlmacen
            // 
            this.txbNombreAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNombreAlmacen.Location = new System.Drawing.Point(205, 58);
            this.txbNombreAlmacen.Name = "txbNombreAlmacen";
            this.txbNombreAlmacen.Size = new System.Drawing.Size(158, 25);
            this.txbNombreAlmacen.TabIndex = 3;
            this.txbNombreAlmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombreAlmacen_KeyPress);
            // 
            // lblNombreAlmacen
            // 
            this.lblNombreAlmacen.AutoSize = true;
            this.lblNombreAlmacen.Location = new System.Drawing.Point(7, 66);
            this.lblNombreAlmacen.Name = "lblNombreAlmacen";
            this.lblNombreAlmacen.Size = new System.Drawing.Size(134, 17);
            this.lblNombreAlmacen.TabIndex = 2;
            this.lblNombreAlmacen.Text = "Nombre Almacén";
            // 
            // txbPorcentajeDescuento
            // 
            this.txbPorcentajeDescuento.Location = new System.Drawing.Point(205, 30);
            this.txbPorcentajeDescuento.Name = "txbPorcentajeDescuento";
            this.txbPorcentajeDescuento.Size = new System.Drawing.Size(158, 25);
            this.txbPorcentajeDescuento.TabIndex = 1;
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.AutoSize = true;
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(7, 38);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(192, 17);
            this.lblPorcentajeDescuento.TabIndex = 0;
            this.lblPorcentajeDescuento.Text = "Porcentaje de Descuento";
            // 
            // listaRegalos
            // 
            this.listaRegalos.FormattingEnabled = true;
            this.listaRegalos.Items.AddRange(new object[] {
            "Licuadora y un Microondas",
            "Licuadora y un Cafetera",
            "Televisor y una Licuadora",
            "Televisor y un Micriondas",
            "Televisor y una Cafetera",
            "Microondas y una Cafetera "});
            this.listaRegalos.Location = new System.Drawing.Point(29, 180);
            this.listaRegalos.Name = "listaRegalos";
            this.listaRegalos.Size = new System.Drawing.Size(10, 4);
            this.listaRegalos.TabIndex = 25;
            // 
            // listaRegalosEducacion
            // 
            this.listaRegalosEducacion.FormattingEnabled = true;
            this.listaRegalosEducacion.Items.AddRange(new object[] {
            "Licuadora",
            "Televisor",
            "Microondas",
            "Cafetera"});
            this.listaRegalosEducacion.Location = new System.Drawing.Point(29, 189);
            this.listaRegalosEducacion.Name = "listaRegalosEducacion";
            this.listaRegalosEducacion.Size = new System.Drawing.Size(10, 4);
            this.listaRegalosEducacion.TabIndex = 26;
            // 
            // ResumenInformacion
            // 
            this.ResumenInformacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumenInformacion.Location = new System.Drawing.Point(515, 599);
            this.ResumenInformacion.Name = "ResumenInformacion";
            this.ResumenInformacion.Size = new System.Drawing.Size(171, 69);
            this.ResumenInformacion.TabIndex = 27;
            this.ResumenInformacion.Text = "RESUMEN DE INFORMACIÓN";
            this.ResumenInformacion.UseVisualStyleBackColor = true;
            this.ResumenInformacion.Click += new System.EventHandler(this.ResumenInformacion_Click);
            // 
            // txbMontoTotalCredito
            // 
            this.txbMontoTotalCredito.Location = new System.Drawing.Point(192, 89);
            this.txbMontoTotalCredito.Mask = "$999.999.999";
            this.txbMontoTotalCredito.Name = "txbMontoTotalCredito";
            this.txbMontoTotalCredito.Size = new System.Drawing.Size(257, 26);
            this.txbMontoTotalCredito.TabIndex = 28;
            // 
            // montosCancelados
            // 
            this.montosCancelados.Location = new System.Drawing.Point(214, 86);
            this.montosCancelados.Mask = "$999.999.999";
            this.montosCancelados.Name = "montosCancelados";
            this.montosCancelados.Size = new System.Drawing.Size(257, 26);
            this.montosCancelados.TabIndex = 28;
            // 
            // AprobacionCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 680);
            this.Controls.Add(this.ResumenInformacion);
            this.Controls.Add(this.listaRegalosEducacion);
            this.Controls.Add(this.listaRegalos);
            this.Controls.Add(this.gbxDescuentos);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.gbxInformacionPagos);
            this.Controls.Add(this.gbxInformacionCredito);
            this.Controls.Add(this.gbxInformacionCliente);
            this.Name = "AprobacionCredito";
            this.Text = "Aprobación de Créditos";
            this.Load += new System.EventHandler(this.AprobacionCredito_Load);
            this.gbxInformacionCliente.ResumeLayout(false);
            this.gbxInformacionCliente.PerformLayout();
            this.gbxInformacionCredito.ResumeLayout(false);
            this.gbxInformacionCredito.PerformLayout();
            this.gbxInformacionPagos.ResumeLayout(false);
            this.gbxInformacionPagos.PerformLayout();
            this.gbxDescuentos.ResumeLayout(false);
            this.gbxDescuentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.Label lblNúmeroId;
        private System.Windows.Forms.TextBox Numerodedocumento;
        private System.Windows.Forms.ComboBox cbTipoIdentificacion;
        private System.Windows.Forms.TextBox tbxNombresApellidos;
        private System.Windows.Forms.Label lblNombresApellidos;
        private System.Windows.Forms.Label Creditosabiertos;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cbxTipoCliente;
        private System.Windows.Forms.Label lblTipoCredito;
        private System.Windows.Forms.ComboBox tipoCredito;
        private System.Windows.Forms.Label lblMontoTotalCredito;
        private System.Windows.Forms.TextBox txbPlazoPagos;
        private System.Windows.Forms.Label lblPlazoPagos;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox gbxInformacionCliente;
        private System.Windows.Forms.GroupBox gbxInformacionCredito;
        private System.Windows.Forms.GroupBox gbxInformacionPagos;
        private System.Windows.Forms.Label lblMontoDineroCancelado;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblFechadePago;
        private System.Windows.Forms.Label lblPagoRealizadoTiempo;
        private System.Windows.Forms.GroupBox gbxDescuentos;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbNombreAlmacen;
        private System.Windows.Forms.Label lblNombreAlmacen;
        private System.Windows.Forms.TextBox txbPorcentajeDescuento;
        private System.Windows.Forms.Label lblPorcentajeDescuento;
        private System.Windows.Forms.Button calculo;
        private System.Windows.Forms.TextBox numeroCreditosAbiertos;
        private System.Windows.Forms.TextBox Numerosdepagos;
        private System.Windows.Forms.Label numeropagos;
        private System.Windows.Forms.ComboBox pagoatiempo;
        private System.Windows.Forms.ListBox listaRegalos;
        private System.Windows.Forms.ListBox listaRegalosEducacion;
        private System.Windows.Forms.Button ResumenInformacion;
        private System.Windows.Forms.MaskedTextBox txbMontoTotalCredito;
        private System.Windows.Forms.MaskedTextBox montosCancelados;
    }
}

