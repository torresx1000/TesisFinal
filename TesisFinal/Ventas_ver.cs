using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

using Logic;

namespace TesisFinal
{
    public partial class Ventas_ver : Form
    {
        public Ventas_ver()
        {
            InitializeComponent();
            listarVentas();
        }
        public void listarVentas()
        {
            bft_ventas.DataSource = Log_Venta.Instancia.ListarVentas();
        }
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventas_ver_Load(object sender, EventArgs e)
        {

        }
    }
}
