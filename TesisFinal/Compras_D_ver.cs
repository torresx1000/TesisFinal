using Endidad;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
namespace TesisFinal
{
    public partial class Compras_D_ver : Form
    {
        public Compras_D_ver()
        {
            InitializeComponent();
            listarCompras();
        }
        public void listarCompras()
        {
            bft_compras.DataSource = Log_compra.Instancia.ListarCompra();
        }
        private void Compras_D_ver_Load(object sender, EventArgs e)
        {

        }
    }
}
