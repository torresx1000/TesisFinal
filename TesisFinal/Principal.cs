using Bunifu.Framework.UI;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Compras_D_ver compras_D_Ver = new Compras_D_ver();
            compras_D_Ver.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            ComprasForm compra_D = new ComprasForm();
            compra_D.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Ventas ventas  = new Ventas();
            ventas.ShowDialog();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            LVentas_ver form2 = new LVentas_ver(); // Crea una instancia de Form2
            form2.ShowDialog();
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            Transacciones form = new Transacciones();
            form.ShowDialog();
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            dgvPagos pagos = new dgvPagos();
            pagos.ShowDialog();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
         PagosVentas ps = new PagosVentas();
           ps.ShowDialog();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {

            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            Stock_ver stock = new Stock_ver();
            stock.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            PagosCompraVenta pag = new PagosCompraVenta();
            pag.ShowDialog();
        }
    }
}
