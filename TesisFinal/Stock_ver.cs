using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
namespace TesisFinal
{
    public partial class Stock_ver : Form
    {
        public Stock_ver()
        {
            InitializeComponent();
            ListarStock();
        }
        void ListarStock()
        {
            dataGridView1.DataSource = LogStock.Instancia.ListarStock();
               
        }

        private void Stock_ver_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
