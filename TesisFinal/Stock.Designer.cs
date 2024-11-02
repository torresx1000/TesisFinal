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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.bmt_total = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bmt_chica = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnf_cambios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(61, 551);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 48);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "informacion\r\ncompletada";
            // 
            // bmt_codigo
            // 
            this.bmt_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_codigo.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_codigo.HintText = "DIGITE SU CODIGO";
            this.bmt_codigo.isPassword = false;
            this.bmt_codigo.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_codigo.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_codigo.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_codigo.LineThickness = 3;
            this.bmt_codigo.Location = new System.Drawing.Point(309, 92);
            this.bmt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_codigo.Name = "bmt_codigo";
            this.bmt_codigo.Size = new System.Drawing.Size(292, 33);
            this.bmt_codigo.TabIndex = 4;
            this.bmt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // drop_options
            // 
            this.drop_options.BackColor = System.Drawing.Color.Transparent;
            this.drop_options.BorderRadius = 3;
            this.drop_options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drop_options.DisabledColor = System.Drawing.Color.GhostWhite;
            this.drop_options.ForeColor = System.Drawing.Color.White;
            this.drop_options.Items = new string[] {
        "NUEVO",
        "ACTUALIZAR ",
        "BUSCAR"};
            this.drop_options.Location = new System.Drawing.Point(22, 202);
            this.drop_options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drop_options.Name = "drop_options";
            this.drop_options.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.drop_options.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drop_options.selectedIndex = -1;
            this.drop_options.Size = new System.Drawing.Size(191, 49);
            this.drop_options.TabIndex = 5;
            this.drop_options.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(56, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Select Option";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.BackColor = System.Drawing.Color.SeaGreen;
            this.dtp_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dtp_fecha.BorderRadius = 2;
            this.dtp_fecha.ForeColor = System.Drawing.Color.White;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.FormatCustom = null;
            this.dtp_fecha.Location = new System.Drawing.Point(309, 13);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(292, 34);
            this.dtp_fecha.TabIndex = 7;
            this.dtp_fecha.Value = new System.DateTime(2024, 11, 1, 23, 42, 6, 0);
            // 
            // bmt_extra
            // 
            this.bmt_extra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_extra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_extra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_extra.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_extra.HintText = "CALIDAD EXTRA";
            this.bmt_extra.isPassword = false;
            this.bmt_extra.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_extra.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_extra.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_extra.LineThickness = 3;
            this.bmt_extra.Location = new System.Drawing.Point(309, 154);
            this.bmt_extra.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_extra.Name = "bmt_extra";
            this.bmt_extra.Size = new System.Drawing.Size(292, 33);
            this.bmt_extra.TabIndex = 9;
            this.bmt_extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_primera
            // 
            this.bmt_primera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_primera.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_primera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_primera.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_primera.HintText = "CALIDAD PRIMERA";
            this.bmt_primera.isPassword = false;
            this.bmt_primera.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_primera.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_primera.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_primera.LineThickness = 3;
            this.bmt_primera.Location = new System.Drawing.Point(309, 218);
            this.bmt_primera.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_primera.Name = "bmt_primera";
            this.bmt_primera.Size = new System.Drawing.Size(292, 33);
            this.bmt_primera.TabIndex = 10;
            this.bmt_primera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_segunda
            // 
            this.bmt_segunda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_segunda.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_segunda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_segunda.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_segunda.HintText = "CALIDAD SEGUNDA";
            this.bmt_segunda.isPassword = false;
            this.bmt_segunda.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_segunda.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_segunda.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_segunda.LineThickness = 3;
            this.bmt_segunda.Location = new System.Drawing.Point(309, 279);
            this.bmt_segunda.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_segunda.Name = "bmt_segunda";
            this.bmt_segunda.Size = new System.Drawing.Size(292, 33);
            this.bmt_segunda.TabIndex = 11;
            this.bmt_segunda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_manchada
            // 
            this.bmt_manchada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_manchada.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_manchada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_manchada.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_manchada.HintText = "CALIDAD MANCHADA / DESCARTE";
            this.bmt_manchada.isPassword = false;
            this.bmt_manchada.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_manchada.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_manchada.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_manchada.LineThickness = 3;
            this.bmt_manchada.Location = new System.Drawing.Point(814, 162);
            this.bmt_manchada.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_manchada.Name = "bmt_manchada";
            this.bmt_manchada.Size = new System.Drawing.Size(330, 33);
            this.bmt_manchada.TabIndex = 14;
            this.bmt_manchada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_cuarta
            // 
            this.bmt_cuarta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_cuarta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_cuarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_cuarta.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_cuarta.HintText = "CALIDAD CUARTA";
            this.bmt_cuarta.isPassword = false;
            this.bmt_cuarta.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_cuarta.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_cuarta.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_cuarta.LineThickness = 3;
            this.bmt_cuarta.Location = new System.Drawing.Point(814, 92);
            this.bmt_cuarta.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_cuarta.Name = "bmt_cuarta";
            this.bmt_cuarta.Size = new System.Drawing.Size(330, 33);
            this.bmt_cuarta.TabIndex = 13;
            this.bmt_cuarta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_tercera
            // 
            this.bmt_tercera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_tercera.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_tercera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_tercera.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_tercera.HintText = "CALIDAD TERCERA";
            this.bmt_tercera.isPassword = false;
            this.bmt_tercera.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_tercera.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_tercera.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_tercera.LineThickness = 3;
            this.bmt_tercera.Location = new System.Drawing.Point(306, 359);
            this.bmt_tercera.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_tercera.Name = "bmt_tercera";
            this.bmt_tercera.Size = new System.Drawing.Size(298, 33);
            this.bmt_tercera.TabIndex = 12;
            this.bmt_tercera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bmt_total
            // 
            this.bmt_total.BackColor = System.Drawing.SystemColors.Control;
            this.bmt_total.BorderColorFocused = System.Drawing.Color.SpringGreen;
            this.bmt_total.BorderColorIdle = System.Drawing.Color.LightSeaGreen;
            this.bmt_total.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.bmt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmt_total.BorderThickness = 3;
            this.bmt_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_total.Enabled = false;
            this.bmt_total.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_total.isPassword = false;
            this.bmt_total.Location = new System.Drawing.Point(814, 279);
            this.bmt_total.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_total.Name = "bmt_total";
            this.bmt_total.Size = new System.Drawing.Size(330, 113);
            this.bmt_total.TabIndex = 15;
            this.bmt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bmt_chica
            // 
            this.bmt_chica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmt_chica.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bmt_chica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bmt_chica.HintForeColor = System.Drawing.Color.Empty;
            this.bmt_chica.HintText = "CALIDAD CHICA / BOLILLA";
            this.bmt_chica.isPassword = false;
            this.bmt_chica.LineFocusedColor = System.Drawing.Color.Blue;
            this.bmt_chica.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.bmt_chica.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bmt_chica.LineThickness = 3;
            this.bmt_chica.Location = new System.Drawing.Point(814, 218);
            this.bmt_chica.Margin = new System.Windows.Forms.Padding(4);
            this.bmt_chica.Name = "bmt_chica";
            this.bmt_chica.Size = new System.Drawing.Size(330, 33);
            this.bmt_chica.TabIndex = 17;
            this.bmt_chica.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::TesisFinal.Properties.Resources.sesion_fin;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1351, 13);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(66, 65);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 18;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnf_cambios
            // 
            this.btnf_cambios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnf_cambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnf_cambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnf_cambios.BorderRadius = 0;
            this.btnf_cambios.ButtonText = "APLICAR CAMBIOS";
            this.btnf_cambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnf_cambios.DisabledColor = System.Drawing.Color.Gray;
            this.btnf_cambios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnf_cambios.Iconimage = global::TesisFinal.Properties.Resources.cambios;
            this.btnf_cambios.Iconimage_right = null;
            this.btnf_cambios.Iconimage_right_Selected = null;
            this.btnf_cambios.Iconimage_Selected = null;
            this.btnf_cambios.IconMarginLeft = 0;
            this.btnf_cambios.IconMarginRight = 0;
            this.btnf_cambios.IconRightVisible = true;
            this.btnf_cambios.IconRightZoom = 0D;
            this.btnf_cambios.IconVisible = true;
            this.btnf_cambios.IconZoom = 50D;
            this.btnf_cambios.IsTab = false;
            this.btnf_cambios.Location = new System.Drawing.Point(603, 483);
            this.btnf_cambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnf_cambios.Name = "btnf_cambios";
            this.btnf_cambios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnf_cambios.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnf_cambios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnf_cambios.selected = false;
            this.btnf_cambios.Size = new System.Drawing.Size(233, 59);
            this.btnf_cambios.TabIndex = 16;
            this.btnf_cambios.Text = "APLICAR CAMBIOS";
            this.btnf_cambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnf_cambios.Textcolor = System.Drawing.Color.White;
            this.btnf_cambios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.ForestGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(51, 409);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(133, 133);
            this.bunifuCircleProgressbar1.TabIndex = 1;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 708);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bmt_chica);
            this.Controls.Add(this.btnf_cambios);
            this.Controls.Add(this.bmt_total);
            this.Controls.Add(this.bmt_manchada);
            this.Controls.Add(this.bmt_cuarta);
            this.Controls.Add(this.bmt_tercera);
            this.Controls.Add(this.bmt_segunda);
            this.Controls.Add(this.bmt_primera);
            this.Controls.Add(this.bmt_extra);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.drop_options);
            this.Controls.Add(this.bmt_codigo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
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
        private Bunifu.Framework.UI.BunifuFlatButton btnf_cambios;
        private Bunifu.Framework.UI.BunifuMetroTextbox bmt_total;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bmt_chica;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

