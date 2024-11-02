using Bunifu.Framework.UI;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TesisFinal
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            Data_bmt_Total();
        }
        void Data_bmt_Total()
        {
            // Configura el texto de sugerencia
            bmt_total.Text = "aqui /n suma total...";
            bmt_total.ForeColor = Color.Gray;

            // Evento Enter: limpia el texto de sugerencia cuando el usuario hace clic
            bmt_total.Enter += (s, e) =>
            {
                if (bmt_total.Text == "aqui /n suma total...")
                {
                    bmt_total.Text = ""; // Limpia el texto
                    bmt_total.ForeColor = Color.Black; // Cambia el color del texto
                }
            };

            // Evento Leave: restablece el texto de sugerencia si el cuadro de texto está vacío
            bmt_total.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(bmt_total.Text))
                {
                    bmt_total.Text = "aqui /n suma total...";
                    bmt_total.ForeColor = Color.Gray;
                }
            };

        }

        private void Stock_Load(object sender, System.EventArgs e)
        {
            
        }

       
        private void toolStripComboBox1_Click(object sender, System.EventArgs e)
        {
           
        }

        private void bunifuDropdown1_onItemSelected(object sender, System.EventArgs e)
        {

        }

      

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
