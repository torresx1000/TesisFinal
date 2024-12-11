namespace TesisFinal
{
    partial class LVentas_ver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LVentas_ver));
            this.bft_ventas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bft_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // bft_ventas
            // 
            this.bft_ventas.AllowUserToAddRows = false;
            this.bft_ventas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bft_ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bft_ventas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bft_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bft_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bft_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bft_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bft_ventas.DoubleBuffered = true;
            this.bft_ventas.EnableHeadersVisualStyles = false;
            this.bft_ventas.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bft_ventas.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bft_ventas.Location = new System.Drawing.Point(12, 30);
            this.bft_ventas.Name = "bft_ventas";
            this.bft_ventas.ReadOnly = true;
            this.bft_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bft_ventas.RowHeadersWidth = 51;
            this.bft_ventas.RowTemplate.Height = 24;
            this.bft_ventas.Size = new System.Drawing.Size(1134, 451);
            this.bft_ventas.TabIndex = 0;
            this.bft_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(248)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1158, 493);
            this.bunifuGradientPanel1.TabIndex = 5;
            // 
            // LVentas_ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 493);
            this.Controls.Add(this.bft_ventas);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "LVentas_ver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.Ventas_ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bft_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bft_ventas;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}