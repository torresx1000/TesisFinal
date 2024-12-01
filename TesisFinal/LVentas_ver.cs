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
using CapaLogica;

namespace TesisFinal
{
    public partial class LVentas_ver : Form
    {
        public LVentas_ver()
        {
            InitializeComponent();
            listarVentas();
        }
        public void listarVentas()
        {
            bft_ventas.DataSource = LogVenta.Instancia.ListarVentas();
        }
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventas_ver_Load(object sender, EventArgs e)
        {

        }
    }
}
