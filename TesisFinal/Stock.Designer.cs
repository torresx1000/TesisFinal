namespace TesisFinal
{
    partial class Stock
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.bmt_codigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.drop_options = new Bunifu.Framework.UI.BunifuDropdown();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bmt_extra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmt_primera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmt_segunda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmt_manchada = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmt_cuarta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmt_tercera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bmt_chica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfmodificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfconsultar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfnuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfeliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfcancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.datastock = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.idcompra = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastock)).BeginInit();
            this.SuspendLayout();
            // 
            // bmt_codigo
            // 
            this.bmt_codigo.BackColor = System.Drawing.Color.White;
            this.bmt_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_codigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_codigo.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_codigo.HintText = "DIGITE SU CODIGO";
            this.bmt_codigo.isPassword = false;
            this.bmt_codigo.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_codigo.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_codigo.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_codigo.LineThickness = 3;
            this.bmt_codigo.Location = new System.Drawing.Point(70, 91);
            this.bmt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_codigo.Name = "bmt_codigo";
            this.bmt_codigo.Size = new System.Drawing.Size(300, 45);
            this.bmt_codigo.TabIndex = 4;
            this.bmt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_codigo.OnValueChanged += new System.EventHandler(this.bmt_codigo_OnValueChanged);
            // 
            // drop_options
            // 
            this.drop_options.BackColor = System.Drawing.Color.Transparent;
            this.drop_options.BorderRadius = 3;
            this.drop_options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drop_options.DisabledColor = System.Drawing.Color.GhostWhite;
            this.drop_options.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_options.ForeColor = System.Drawing.Color.White;
            this.drop_options.Items = new string[] {
        "",
        "NUEVO DATO",
        "ACTUALIZAR DATO",
        "BUSCAR DATO",
        "ELIMINAR DATO"};
            this.drop_options.Location = new System.Drawing.Point(1096, 137);
            this.drop_options.Margin = new System.Windows.Forms.Padding(4);
            this.drop_options.Name = "drop_options";
            this.drop_options.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drop_options.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drop_options.selectedIndex = -1;
            this.drop_options.Size = new System.Drawing.Size(278, 58);
            this.drop_options.TabIndex = 5;
            this.drop_options.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1185, 99);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Select Option";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.BackColor = System.Drawing.Color.White;
            this.dtp_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dtp_fecha.BorderRadius = 2;
            this.dtp_fecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.FormatCustom = null;
            this.dtp_fecha.Location = new System.Drawing.Point(70, 183);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(300, 45);
            this.dtp_fecha.TabIndex = 7;
            this.dtp_fecha.Value = new System.DateTime(2024, 11, 1, 23, 42, 6, 0);
            // 
            // bmt_extra
            // 
            this.bmt_extra.BackColor = System.Drawing.Color.White;
            this.bmt_extra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_extra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_extra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_extra.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_extra.HintText = "CALIDAD EXTRA";
            this.bmt_extra.isPassword = false;
            this.bmt_extra.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_extra.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_extra.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_extra.LineThickness = 3;
            this.bmt_extra.Location = new System.Drawing.Point(70, 275);
            this.bmt_extra.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_extra.Name = "bmt_extra";
            this.bmt_extra.Size = new System.Drawing.Size(300, 45);
            this.bmt_extra.TabIndex = 9;
            this.bmt_extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_extra.OnValueChanged += new System.EventHandler(this.bmt_extra_OnValueChanged);
            // 
            // bmt_primera
            // 
            this.bmt_primera.BackColor = System.Drawing.Color.White;
            this.bmt_primera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_primera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_primera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_primera.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_primera.HintText = "CALIDAD PRIMERA";
            this.bmt_primera.isPassword = false;
            this.bmt_primera.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_primera.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_primera.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_primera.LineThickness = 3;
            this.bmt_primera.Location = new System.Drawing.Point(70, 373);
            this.bmt_primera.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_primera.Name = "bmt_primera";
            this.bmt_primera.Size = new System.Drawing.Size(300, 45);
            this.bmt_primera.TabIndex = 10;
            this.bmt_primera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_primera.OnValueChanged += new System.EventHandler(this.bmt_primera_OnValueChanged);
            // 
            // bmt_segunda
            // 
            this.bmt_segunda.BackColor = System.Drawing.Color.White;
            this.bmt_segunda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_segunda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_segunda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_segunda.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_segunda.HintText = "CALIDAD SEGUNDA";
            this.bmt_segunda.isPassword = false;
            this.bmt_segunda.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_segunda.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_segunda.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_segunda.LineThickness = 3;
            this.bmt_segunda.Location = new System.Drawing.Point(70, 467);
            this.bmt_segunda.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_segunda.Name = "bmt_segunda";
            this.bmt_segunda.Size = new System.Drawing.Size(300, 45);
            this.bmt_segunda.TabIndex = 11;
            this.bmt_segunda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_segunda.OnValueChanged += new System.EventHandler(this.bmt_segunda_OnValueChanged);
            // 
            // bmt_manchada
            // 
            this.bmt_manchada.BackColor = System.Drawing.Color.White;
            this.bmt_manchada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_manchada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_manchada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_manchada.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_manchada.HintText = "CALIDAD MANCHADA / DESCARTE";
            this.bmt_manchada.isPassword = false;
            this.bmt_manchada.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_manchada.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_manchada.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_manchada.LineThickness = 3;
            this.bmt_manchada.Location = new System.Drawing.Point(443, 275);
            this.bmt_manchada.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_manchada.Name = "bmt_manchada";
            this.bmt_manchada.Size = new System.Drawing.Size(300, 45);
            this.bmt_manchada.TabIndex = 14;
            this.bmt_manchada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_manchada.OnValueChanged += new System.EventHandler(this.bmt_manchada_OnValueChanged);
            // 
            // bmt_cuarta
            // 
            this.bmt_cuarta.BackColor = System.Drawing.Color.White;
            this.bmt_cuarta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_cuarta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_cuarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_cuarta.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_cuarta.HintText = "CALIDAD CUARTA";
            this.bmt_cuarta.isPassword = false;
            this.bmt_cuarta.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_cuarta.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_cuarta.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_cuarta.LineThickness = 3;
            this.bmt_cuarta.Location = new System.Drawing.Point(443, 183);
            this.bmt_cuarta.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_cuarta.Name = "bmt_cuarta";
            this.bmt_cuarta.Size = new System.Drawing.Size(300, 45);
            this.bmt_cuarta.TabIndex = 13;
            this.bmt_cuarta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_cuarta.OnValueChanged += new System.EventHandler(this.bmt_cuarta_OnValueChanged);
            // 
            // bmt_tercera
            // 
            this.bmt_tercera.BackColor = System.Drawing.Color.White;
            this.bmt_tercera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_tercera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_tercera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_tercera.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_tercera.HintText = "CALIDAD TERCERA";
            this.bmt_tercera.isPassword = false;
            this.bmt_tercera.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_tercera.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_tercera.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_tercera.LineThickness = 3;
            this.bmt_tercera.Location = new System.Drawing.Point(443, 91);
            this.bmt_tercera.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_tercera.Name = "bmt_tercera";
            this.bmt_tercera.Size = new System.Drawing.Size(300, 45);
            this.bmt_tercera.TabIndex = 12;
            this.bmt_tercera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_tercera.OnValueChanged += new System.EventHandler(this.bmt_tercera_OnValueChanged);
            // 
            // bmt_chica
            // 
            this.bmt_chica.BackColor = System.Drawing.Color.White;
            this.bmt_chica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_chica.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmt_chica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_chica.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_chica.HintText = "CALIDAD CHICA / BOLILLA";
            this.bmt_chica.isPassword = false;
            this.bmt_chica.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_chica.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_chica.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_chica.LineThickness = 3;
            this.bmt_chica.Location = new System.Drawing.Point(443, 373);
            this.bmt_chica.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_chica.Name = "bmt_chica";
            this.bmt_chica.Size = new System.Drawing.Size(300, 45);
            this.bmt_chica.TabIndex = 17;
            this.bmt_chica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bmt_chica.OnValueChanged += new System.EventHandler(this.bmt_chica_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::TesisFinal.Properties.Resources.sesion_fin;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1375, 25);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(66, 65);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bnfmodificar
            // 
            this.bnfmodificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfmodificar.BorderRadius = 0;
            this.bnfmodificar.ButtonText = "APLICAR";
            this.bnfmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfmodificar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfmodificar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfmodificar.Iconimage = global::TesisFinal.Properties.Resources.cambios;
            this.bnfmodificar.Iconimage_right = null;
            this.bnfmodificar.Iconimage_right_Selected = null;
            this.bnfmodificar.Iconimage_Selected = null;
            this.bnfmodificar.IconMarginLeft = 0;
            this.bnfmodificar.IconMarginRight = 0;
            this.bnfmodificar.IconRightVisible = true;
            this.bnfmodificar.IconRightZoom = 0D;
            this.bnfmodificar.IconVisible = true;
            this.bnfmodificar.IconZoom = 50D;
            this.bnfmodificar.IsTab = false;
            this.bnfmodificar.Location = new System.Drawing.Point(1096, 242);
            this.bnfmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnfmodificar.Name = "bnfmodificar";
            this.bnfmodificar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfmodificar.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bnfmodificar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfmodificar.selected = false;
            this.bnfmodificar.Size = new System.Drawing.Size(278, 59);
            this.bnfmodificar.TabIndex = 125;
            this.bnfmodificar.Text = "APLICAR";
            this.bnfmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnfmodificar.Textcolor = System.Drawing.Color.White;
            this.bnfmodificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfmodificar.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bnfconsultar
            // 
            this.bnfconsultar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfconsultar.BorderRadius = 0;
            this.bnfconsultar.ButtonText = "APLICAR";
            this.bnfconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfconsultar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfconsultar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfconsultar.Iconimage = global::TesisFinal.Properties.Resources.cambios;
            this.bnfconsultar.Iconimage_right = null;
            this.bnfconsultar.Iconimage_right_Selected = null;
            this.bnfconsultar.Iconimage_Selected = null;
            this.bnfconsultar.IconMarginLeft = 0;
            this.bnfconsultar.IconMarginRight = 0;
            this.bnfconsultar.IconRightVisible = true;
            this.bnfconsultar.IconRightZoom = 0D;
            this.bnfconsultar.IconVisible = true;
            this.bnfconsultar.IconZoom = 50D;
            this.bnfconsultar.IsTab = false;
            this.bnfconsultar.Location = new System.Drawing.Point(1096, 242);
            this.bnfconsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnfconsultar.Name = "bnfconsultar";
            this.bnfconsultar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfconsultar.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bnfconsultar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfconsultar.selected = false;
            this.bnfconsultar.Size = new System.Drawing.Size(278, 59);
            this.bnfconsultar.TabIndex = 124;
            this.bnfconsultar.Text = "APLICAR";
            this.bnfconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnfconsultar.Textcolor = System.Drawing.Color.White;
            this.bnfconsultar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfconsultar.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bnfnuevo
            // 
            this.bnfnuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfnuevo.BorderRadius = 0;
            this.bnfnuevo.ButtonText = "APLICAR";
            this.bnfnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfnuevo.DisabledColor = System.Drawing.Color.Gray;
            this.bnfnuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfnuevo.Iconimage = global::TesisFinal.Properties.Resources.cambios;
            this.bnfnuevo.Iconimage_right = null;
            this.bnfnuevo.Iconimage_right_Selected = null;
            this.bnfnuevo.Iconimage_Selected = null;
            this.bnfnuevo.IconMarginLeft = 0;
            this.bnfnuevo.IconMarginRight = 0;
            this.bnfnuevo.IconRightVisible = true;
            this.bnfnuevo.IconRightZoom = 0D;
            this.bnfnuevo.IconVisible = true;
            this.bnfnuevo.IconZoom = 50D;
            this.bnfnuevo.IsTab = false;
            this.bnfnuevo.Location = new System.Drawing.Point(1096, 242);
            this.bnfnuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnfnuevo.Name = "bnfnuevo";
            this.bnfnuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfnuevo.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bnfnuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfnuevo.selected = false;
            this.bnfnuevo.Size = new System.Drawing.Size(278, 59);
            this.bnfnuevo.TabIndex = 123;
            this.bnfnuevo.Text = "APLICAR";
            this.bnfnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnfnuevo.Textcolor = System.Drawing.Color.White;
            this.bnfnuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfnuevo.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bnfeliminar
            // 
            this.bnfeliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfeliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfeliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfeliminar.BorderRadius = 0;
            this.bnfeliminar.ButtonText = "APLICAR";
            this.bnfeliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfeliminar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfeliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfeliminar.Iconimage = global::TesisFinal.Properties.Resources.cambios;
            this.bnfeliminar.Iconimage_right = null;
            this.bnfeliminar.Iconimage_right_Selected = null;
            this.bnfeliminar.Iconimage_Selected = null;
            this.bnfeliminar.IconMarginLeft = 0;
            this.bnfeliminar.IconMarginRight = 0;
            this.bnfeliminar.IconRightVisible = true;
            this.bnfeliminar.IconRightZoom = 0D;
            this.bnfeliminar.IconVisible = true;
            this.bnfeliminar.IconZoom = 50D;
            this.bnfeliminar.IsTab = false;
            this.bnfeliminar.Location = new System.Drawing.Point(1096, 242);
            this.bnfeliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnfeliminar.Name = "bnfeliminar";
            this.bnfeliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfeliminar.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bnfeliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfeliminar.selected = false;
            this.bnfeliminar.Size = new System.Drawing.Size(278, 59);
            this.bnfeliminar.TabIndex = 126;
            this.bnfeliminar.Text = "APLICAR";
            this.bnfeliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnfeliminar.Textcolor = System.Drawing.Color.White;
            this.bnfeliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfeliminar.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bnfcancelar
            // 
            this.bnfcancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfcancelar.BorderRadius = 0;
            this.bnfcancelar.ButtonText = "CANCELAR";
            this.bnfcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfcancelar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfcancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfcancelar.Iconimage = global::TesisFinal.Properties.Resources.cambios;
            this.bnfcancelar.Iconimage_right = null;
            this.bnfcancelar.Iconimage_right_Selected = null;
            this.bnfcancelar.Iconimage_Selected = null;
            this.bnfcancelar.IconMarginLeft = 0;
            this.bnfcancelar.IconMarginRight = 0;
            this.bnfcancelar.IconRightVisible = true;
            this.bnfcancelar.IconRightZoom = 0D;
            this.bnfcancelar.IconVisible = true;
            this.bnfcancelar.IconZoom = 50D;
            this.bnfcancelar.IsTab = false;
            this.bnfcancelar.Location = new System.Drawing.Point(1096, 357);
            this.bnfcancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnfcancelar.Name = "bnfcancelar";
            this.bnfcancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bnfcancelar.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.bnfcancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfcancelar.selected = false;
            this.bnfcancelar.Size = new System.Drawing.Size(278, 59);
            this.bnfcancelar.TabIndex = 127;
            this.bnfcancelar.Text = "CANCELAR";
            this.bnfcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnfcancelar.Textcolor = System.Drawing.Color.White;
            this.bnfcancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfcancelar.Click += new System.EventHandler(this.bnfcancelar_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.datastock);
            this.bunifuGradientPanel1.Controls.Add(this.materialLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.idcompra);
            this.bunifuGradientPanel1.Controls.Add(this.drop_options);
            this.bunifuGradientPanel1.Controls.Add(this.bnfnuevo);
            this.bunifuGradientPanel1.Controls.Add(this.bnfconsultar);
            this.bunifuGradientPanel1.Controls.Add(this.bnfmodificar);
            this.bunifuGradientPanel1.Controls.Add(this.bnfeliminar);
            this.bunifuGradientPanel1.Controls.Add(this.bnfcancelar);
            this.bunifuGradientPanel1.Controls.Add(this.materialLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.dtp_fecha);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_codigo);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_extra);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_primera);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_segunda);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_tercera);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_cuarta);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_manchada);
            this.bunifuGradientPanel1.Controls.Add(this.bmt_chica);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1500, 700);
            this.bunifuGradientPanel1.TabIndex = 129;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // datastock
            // 
            this.datastock.AllowUserToAddRows = false;
            this.datastock.AllowUserToDeleteRows = false;
            this.datastock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datastock.Location = new System.Drawing.Point(70, 519);
            this.datastock.Name = "datastock";
            this.datastock.ReadOnly = true;
            this.datastock.RowHeadersWidth = 51;
            this.datastock.RowTemplate.Height = 24;
            this.datastock.Size = new System.Drawing.Size(1304, 111);
            this.datastock.TabIndex = 130;
            this.datastock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datastock_CellContentClick);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(865, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(27, 120);
            this.materialLabel3.TabIndex = 129;
            this.materialLabel3.Text = "S\r\nT\r\nO\r\nC\r\nK ";
            // 
            // idcompra
            // 
            this.idcompra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.idcompra.FormattingEnabled = true;
            this.idcompra.Location = new System.Drawing.Point(443, 467);
            this.idcompra.Name = "idcompra";
            this.idcompra.Size = new System.Drawing.Size(300, 31);
            this.idcompra.TabIndex = 128;
            this.idcompra.SelectedIndexChanged += new System.EventHandler(this.idcompra_SelectedIndexChanged);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 700);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datastock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_codigo;
        private Bunifu.Framework.UI.BunifuDropdown drop_options;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_fecha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_extra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_primera;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_segunda;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_manchada;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_cuarta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_tercera;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_chica;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bnfmodificar;
        private Bunifu.Framework.UI.BunifuFlatButton bnfconsultar;
        private Bunifu.Framework.UI.BunifuFlatButton bnfnuevo;
        private Bunifu.Framework.UI.BunifuFlatButton bnfeliminar;
        private Bunifu.Framework.UI.BunifuFlatButton bnfcancelar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ComboBox idcompra;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView datastock;
    }
}

