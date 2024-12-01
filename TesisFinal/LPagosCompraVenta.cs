using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesisFinal
{
    public partial class PagosCompraVenta : Form
    {
        public PagosCompraVenta()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = LogPagoCompra.Instancia.ListarPagosCompra();
                
            }
            else if (comboBox1.SelectedIndex == 1) { 
                dataGridView1.DataSource= LogPagoVenta.Instancia.ListarPagoVentas();
            }
        }
    }
}
