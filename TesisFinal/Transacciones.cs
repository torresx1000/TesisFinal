using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace TesisFinal

{
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
           dataList.Enabled = false;

          
        }
       
        
        private void Transacciones_Load(object sender, EventArgs e)
        {
            dataList.DataSource = LogTransacciones.Instancia.ListarTransacciones();

        }
        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
