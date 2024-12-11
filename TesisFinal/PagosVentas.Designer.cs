namespace TesisFinal
{
    partial class PagosVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.idventa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmfecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnfdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drop_options = new Bunifu.Framework.UI.BunifuDropdown();
            this.btbuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bteliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btcancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btprocesar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btcrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtCodVenta = new System.Windows.Forms.TextBox();
            this.dataPagosSin = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPagosSin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.White;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Items.AddRange(new object[] {
            "",
            "PENDIENTE",
            "COMPLETADO"});
            this.cboestado.Location = new System.Drawing.Point(255, 384);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(378, 33);
            this.cboestado.TabIndex = 43;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(284, 435);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(349, 54);
            this.txtMonto.TabIndex = 42;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // idventa
            // 
            this.idventa.BackColor = System.Drawing.Color.White;
            this.idventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.idventa.FormattingEnabled = true;
            this.idventa.Location = new System.Drawing.Point(362, 507);
            this.idventa.Name = "idventa";
            this.idventa.Size = new System.Drawing.Size(271, 33);
            this.idventa.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(167, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 52);
            this.label7.TabIndex = 40;
            this.label7.Text = "PROCESAMIENTO DE UNA VENTA";
            // 
            // dtmfecha
            // 
            this.dtmfecha.BackColor = System.Drawing.Color.White;
            this.dtmfecha.BorderRadius = 0;
            this.dtmfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmfecha.ForeColor = System.Drawing.Color.ForestGreen;
            this.dtmfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmfecha.FormatCustom = null;
            this.dtmfecha.Location = new System.Drawing.Point(217, 246);
            this.dtmfecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtmfecha.Name = "dtmfecha";
            this.dtmfecha.Size = new System.Drawing.Size(416, 54);
            this.dtmfecha.TabIndex = 36;
            this.dtmfecha.Value = new System.DateTime(2024, 11, 16, 4, 16, 4, 443);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "CODIGO DE VENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "CODIGO DE PAGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "MONTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "ESTADO";
            // 
            // bnfdate
            // 
            this.bnfdate.AutoSize = true;
            this.bnfdate.BackColor = System.Drawing.Color.Transparent;
            this.bnfdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfdate.Location = new System.Drawing.Point(61, 263);
            this.bnfdate.Name = "bnfdate";
            this.bnfdate.Size = new System.Drawing.Size(85, 25);
            this.bnfdate.TabIndex = 48;
            this.bnfdate.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "TIPO DE PAGO";
            // 
            // drop_options
            // 
            this.drop_options.BackColor = System.Drawing.Color.Transparent;
            this.drop_options.BorderRadius = 3;
            this.drop_options.DisabledColor = System.Drawing.Color.Gray;
            this.drop_options.ForeColor = System.Drawing.Color.White;
            this.drop_options.Items = new string[] {
        "",
        "CREAR ORDEN",
        "PROCESAR",
        "BUSCAR",
        "ELIMINAR"};
            this.drop_options.Location = new System.Drawing.Point(817, 121);
            this.drop_options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drop_options.Name = "drop_options";
            this.drop_options.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drop_options.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.drop_options.selectedIndex = -1;
            this.drop_options.Size = new System.Drawing.Size(289, 54);
            this.drop_options.TabIndex = 53;
            this.drop_options.onItemSelected += new System.EventHandler(this.opciones_onItemSelected);
            // 
            // btbuscar
            // 
            this.btbuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbuscar.BorderRadius = 0;
            this.btbuscar.ButtonText = "APLICAR";
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btbuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btbuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btbuscar.Iconimage")));
            this.btbuscar.Iconimage_right = null;
            this.btbuscar.Iconimage_right_Selected = null;
            this.btbuscar.Iconimage_Selected = null;
            this.btbuscar.IconMarginLeft = 0;
            this.btbuscar.IconMarginRight = 0;
            this.btbuscar.IconRightVisible = true;
            this.btbuscar.IconRightZoom = 0D;
            this.btbuscar.IconVisible = true;
            this.btbuscar.IconZoom = 90D;
            this.btbuscar.IsTab = false;
            this.btbuscar.Location = new System.Drawing.Point(817, 263);
            this.btbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btbuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btbuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btbuscar.selected = false;
            this.btbuscar.Size = new System.Drawing.Size(289, 59);
            this.btbuscar.TabIndex = 56;
            this.btbuscar.Text = "APLICAR";
            this.btbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btbuscar.Textcolor = System.Drawing.Color.White;
            this.btbuscar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bteliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bteliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bteliminar.BorderRadius = 0;
            this.bteliminar.ButtonText = "APLICAR";
            this.bteliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bteliminar.DisabledColor = System.Drawing.Color.Gray;
            this.bteliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.bteliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bteliminar.Iconimage")));
            this.bteliminar.Iconimage_right = null;
            this.bteliminar.Iconimage_right_Selected = null;
            this.bteliminar.Iconimage_Selected = null;
            this.bteliminar.IconMarginLeft = 0;
            this.bteliminar.IconMarginRight = 0;
            this.bteliminar.IconRightVisible = true;
            this.bteliminar.IconRightZoom = 0D;
            this.bteliminar.IconVisible = true;
            this.bteliminar.IconZoom = 90D;
            this.bteliminar.IsTab = false;
            this.bteliminar.Location = new System.Drawing.Point(817, 263);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bteliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bteliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.bteliminar.selected = false;
            this.bteliminar.Size = new System.Drawing.Size(289, 59);
            this.bteliminar.TabIndex = 55;
            this.bteliminar.Text = "APLICAR";
            this.bteliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bteliminar.Textcolor = System.Drawing.Color.White;
            this.bteliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btcancelar.BorderRadius = 0;
            this.btcancelar.ButtonText = "CANCELAR";
            this.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btcancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btcancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btcancelar.Iconimage")));
            this.btcancelar.Iconimage_right = null;
            this.btcancelar.Iconimage_right_Selected = null;
            this.btcancelar.Iconimage_Selected = null;
            this.btcancelar.IconMarginLeft = 0;
            this.btcancelar.IconMarginRight = 0;
            this.btcancelar.IconRightVisible = true;
            this.btcancelar.IconRightZoom = 0D;
            this.btcancelar.IconVisible = true;
            this.btcancelar.IconZoom = 90D;
            this.btcancelar.IsTab = false;
            this.btcancelar.Location = new System.Drawing.Point(817, 405);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btcancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btcancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btcancelar.selected = false;
            this.btcancelar.Size = new System.Drawing.Size(289, 59);
            this.btcancelar.TabIndex = 52;
            this.btcancelar.Text = "CANCELAR";
            this.btcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btcancelar.Textcolor = System.Drawing.Color.White;
            this.btcancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btprocesar
            // 
            this.btprocesar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btprocesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btprocesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btprocesar.BorderRadius = 0;
            this.btprocesar.ButtonText = "APLICAR";
            this.btprocesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btprocesar.DisabledColor = System.Drawing.Color.Gray;
            this.btprocesar.Iconcolor = System.Drawing.Color.Transparent;
            this.btprocesar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btprocesar.Iconimage")));
            this.btprocesar.Iconimage_right = null;
            this.btprocesar.Iconimage_right_Selected = null;
            this.btprocesar.Iconimage_Selected = null;
            this.btprocesar.IconMarginLeft = 0;
            this.btprocesar.IconMarginRight = 0;
            this.btprocesar.IconRightVisible = true;
            this.btprocesar.IconRightZoom = 0D;
            this.btprocesar.IconVisible = true;
            this.btprocesar.IconZoom = 90D;
            this.btprocesar.IsTab = false;
            this.btprocesar.Location = new System.Drawing.Point(817, 263);
            this.btprocesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btprocesar.Name = "btprocesar";
            this.btprocesar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btprocesar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btprocesar.OnHoverTextColor = System.Drawing.Color.White;
            this.btprocesar.selected = false;
            this.btprocesar.Size = new System.Drawing.Size(289, 59);
            this.btprocesar.TabIndex = 57;
            this.btprocesar.Text = "APLICAR";
            this.btprocesar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btprocesar.Textcolor = System.Drawing.Color.White;
            this.btprocesar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprocesar.Click += new System.EventHandler(this.btprocesar_Click);
            // 
            // btcrear
            // 
            this.btcrear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btcrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btcrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btcrear.BorderRadius = 0;
            this.btcrear.ButtonText = "CREAR ORDEN";
            this.btcrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcrear.DisabledColor = System.Drawing.Color.Gray;
            this.btcrear.Iconcolor = System.Drawing.Color.Transparent;
            this.btcrear.Iconimage = ((System.Drawing.Image)(resources.GetObject("btcrear.Iconimage")));
            this.btcrear.Iconimage_right = null;
            this.btcrear.Iconimage_right_Selected = null;
            this.btcrear.Iconimage_Selected = null;
            this.btcrear.IconMarginLeft = 0;
            this.btcrear.IconMarginRight = 0;
            this.btcrear.IconRightVisible = true;
            this.btcrear.IconRightZoom = 0D;
            this.btcrear.IconVisible = true;
            this.btcrear.IconZoom = 90D;
            this.btcrear.IsTab = false;
            this.btcrear.Location = new System.Drawing.Point(817, 263);
            this.btcrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcrear.Name = "btcrear";
            this.btcrear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btcrear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btcrear.OnHoverTextColor = System.Drawing.Color.White;
            this.btcrear.selected = false;
            this.btcrear.Size = new System.Drawing.Size(289, 59);
            this.btcrear.TabIndex = 51;
            this.btcrear.Text = "CREAR ORDEN";
            this.btcrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btcrear.Textcolor = System.Drawing.Color.White;
            this.btcrear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcrear.Click += new System.EventHandler(this.btcrear_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(284, 174);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(349, 54);
            this.txtMotivo.TabIndex = 58;
            // 
            // txtCodVenta
            // 
            this.txtCodVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVenta.Location = new System.Drawing.Point(319, 108);
            this.txtCodVenta.Multiline = true;
            this.txtCodVenta.Name = "txtCodVenta";
            this.txtCodVenta.Size = new System.Drawing.Size(314, 54);
            this.txtCodVenta.TabIndex = 59;
            // 
            // dataPagosSin
            // 
            this.dataPagosSin.AllowUserToAddRows = false;
            this.dataPagosSin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPagosSin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPagosSin.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataPagosSin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPagosSin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPagosSin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPagosSin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPagosSin.DoubleBuffered = true;
            this.dataPagosSin.EnableHeadersVisualStyles = false;
            this.dataPagosSin.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataPagosSin.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataPagosSin.Location = new System.Drawing.Point(66, 576);
            this.dataPagosSin.Name = "dataPagosSin";
            this.dataPagosSin.ReadOnly = true;
            this.dataPagosSin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPagosSin.RowHeadersWidth = 51;
            this.dataPagosSin.RowTemplate.Height = 24;
            this.dataPagosSin.Size = new System.Drawing.Size(1040, 150);
            this.dataPagosSin.TabIndex = 60;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::TesisFinal.Properties.Resources.sesion_fin;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1035, 25);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 77;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.cbotipo);
            this.bunifuGradientPanel1.Controls.Add(this.btprocesar);
            this.bunifuGradientPanel1.Controls.Add(this.bteliminar);
            this.bunifuGradientPanel1.Controls.Add(this.btcrear);
            this.bunifuGradientPanel1.Controls.Add(this.btbuscar);
            this.bunifuGradientPanel1.Controls.Add(this.btcancelar);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(208)))), ((int)(((byte)(215)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1167, 796);
            this.bunifuGradientPanel1.TabIndex = 78;
            // 
            // cbotipo
            // 
            this.cbotipo.BackColor = System.Drawing.Color.White;
            this.cbotipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.cbotipo.Location = new System.Drawing.Point(284, 325);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(349, 33);
            this.cbotipo.TabIndex = 79;
            // 
            // PagosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 796);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.dataPagosSin);
            this.Controls.Add(this.txtCodVenta);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.drop_options);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnfdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.idventa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtmfecha);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagosVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagosVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataPagosSin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox idventa;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker dtmfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bnfdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btbuscar;
        private Bunifu.Framework.UI.BunifuFlatButton bteliminar;
        private Bunifu.Framework.UI.BunifuDropdown drop_options;
        private Bunifu.Framework.UI.BunifuFlatButton btcancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btprocesar;
        private Bunifu.Framework.UI.BunifuFlatButton btcrear;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtCodVenta;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataPagosSin;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ComboBox cbotipo;
    }
}