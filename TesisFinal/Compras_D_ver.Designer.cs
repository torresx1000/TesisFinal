namespace TesisFinal
{
    partial class Compras_D_ver
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
            this.bft_compras = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bft_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // bft_compras
            // 
            this.bft_compras.AllowUserToAddRows = false;
            this.bft_compras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bft_compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bft_compras.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bft_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bft_compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bft_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bft_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bft_compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bft_compras.DoubleBuffered = true;
            this.bft_compras.EnableHeadersVisualStyles = false;
            this.bft_compras.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bft_compras.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bft_compras.Location = new System.Drawing.Point(0, 0);
            this.bft_compras.Name = "bft_compras";
            this.bft_compras.ReadOnly = true;
            this.bft_compras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bft_compras.RowHeadersWidth = 51;
            this.bft_compras.RowTemplate.Height = 24;
            this.bft_compras.Size = new System.Drawing.Size(800, 450);
            this.bft_compras.TabIndex = 0;
            // 
            // Compras_D_ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bft_compras);
            this.Name = "Compras_D_ver";
            this.Text = "Compras_ver";
            this.Load += new System.EventHandler(this.Compras_D_ver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bft_compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bft_compras;
    }
}