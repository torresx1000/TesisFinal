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
            compras_D_Ver.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Compra_D compra_D = new Compra_D();
            compra_D.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Ventas ventas  = new Ventas();
            ventas.ShowDialog();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Ventas_ver form2 = new Ventas_ver(); // Crea una instancia de Form2
            form2.Show();
        }
    }
}
