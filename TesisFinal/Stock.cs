using Bunifu.Framework.UI;
using CapaEntidad;
using CapaLogica;
using System;
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
            listaIDCompras();
            ListarStock();
            Variables();
            Botones();

        }
        void listaIDCompras()
        {
            idcompra.DataSource = LogCompra.Instancia.ListarCompra();
            idcompra.DisplayMember = "idcompra";
            idcompra.ValueMember = "idcompra";
        }
        void Variables()
        {
            bmt_codigo.Text = "";
            dtp_fecha.Text ="";
            bmt_extra.Text = "";
            bmt_primera.Text = "";
            bmt_segunda.Text = "";
            bmt_tercera.Text = "";
            bmt_cuarta.Text = "";
            bmt_manchada.Text = "";
            bmt_chica.Text = "";
            
        }

        void Botones()
        {
            bnfnuevo.Visible = false;
            bnfmodificar.Visible = false;
            bnfconsultar.Visible = false;
            bnfcancelar.Visible = false;
            bnfeliminar.Visible = false;
            drop_options.selectedIndex = 0;
        }


        private void Stock_Load(object sender, System.EventArgs e)
        {
            
        }

       
        private void toolStripComboBox1_Click(object sender, System.EventArgs e)
        {
           
        }

        private void bunifuDropdown1_onItemSelected(object sender, System.EventArgs e)
        {
            if (drop_options.selectedValue == null)
            {
                bmt_codigo.Visible = true;
                Variables();
                ListarStock();

            }
            else if (drop_options.selectedValue == "NUEVO DATO")
            {
                bnfnuevo.Visible = true;
                bmt_codigo.Visible = false;
                bnfcancelar.Visible = true;
                ListarStock();
                Variables();
            }
            else if (drop_options.selectedValue == "ACTUALIZAR DATO")
            {
                MessageBox.Show("ingresa el ID o CODIGO para ACTUALIZAR.");
                bnfmodificar.Visible=true;
                bnfcancelar.Visible = true;
                ListarStock();
                Variables();
            }
            else if (drop_options.selectedValue == "BUSCAR DATO")
            {
                MessageBox.Show("ingresa el ID o CODIGO para BUSCAR.");
                bnfconsultar.Visible=true;
                bnfcancelar.Visible = true;
                ListarStock();
            }
            else if(drop_options.selectedValue == "ELIMINAR DATO")
            {
                MessageBox.Show("ingresa el ID o CODIGO para ELIMINAR.");
                bnfeliminar.Visible=true;
                bnfcancelar.Visible = true;
                ListarStock();
            }
        }

      

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bmt_segunda_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_segunda.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_segunda.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_segunda.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_primera_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_primera.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_primera.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_primera.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_extra_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_extra.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_extra.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_extra.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_codigo_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_codigo.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_codigo.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_codigo.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_tercera_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_tercera.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_tercera.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_tercera.BackColor = Color.LightCoral; // Indicar entrada inválida
            }

        }

        private void bmt_chica_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_chica.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_chica.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_chica.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_manchada_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_manchada.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_manchada.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_manchada.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_cuarta_OnValueChanged(object sender, System.EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bmt_cuarta.Text.Trim(), out valor) && valor >= 0)
            {

                bmt_cuarta.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bmt_cuarta.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bmt_total_OnValueChanged(object sender, System.EventArgs e)
        {
           
           
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                EntStock c = new EntStock();
                c.idStock = int.Parse(bmt_codigo.Text.Trim());
                LogStock.Instancia.EliminarStock(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            Botones();
            Variables();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                EntStock c = new EntStock();
                c.fecha = dtp_fecha.Value;
                c.st_x = Convert.ToDecimal(bmt_extra.Text.Trim());
                c.st_1 = Convert.ToDecimal(bmt_primera.Text.Trim());
                c.st_2 = Convert.ToDecimal(bmt_segunda.Text.Trim());
                c.st_3 = Convert.ToDecimal(bmt_tercera.Text.Trim());
                c.st_4 = Convert.ToDecimal(bmt_cuarta.Text.Trim());
                c.st_m = Convert.ToDecimal(bmt_manchada.Text.Trim());
                c.st_ch = Convert.ToDecimal(bmt_chica.Text.Trim());
                c.idcompra = Convert.ToInt32(idcompra.Text.Trim());
                LogStock.Instancia.InsertarStock(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            Botones();
            Variables();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                bmt_codigo.Focus();
                int codigo = int.Parse(bmt_codigo.Text.Trim());
                EntStock sto = LogStock.Instancia.BuscarStock(codigo);
                if (sto != null)
                {
                    bmt_codigo.Text = Convert.ToString(sto.idStock);
                    dtp_fecha.Text = Convert.ToString(sto.fecha);
                    bmt_extra.Text = sto.st_x.ToString();
                    bmt_primera.Text = Convert.ToString(sto.st_1);
                    bmt_segunda.Text = Convert.ToString(sto.st_2);
                    bmt_tercera.Text = Convert.ToString(sto.st_3);
                    bmt_cuarta.Text = Convert.ToString(sto.st_4);
                    bmt_manchada.Text = Convert.ToString(sto.st_m);
                    bmt_chica.Text = Convert.ToString(sto.st_ch);
                    idcompra.Text = Convert.ToString(sto.idcompra);
                    
                }

                else
                {
                    MessageBox.Show("no existe el Stock buscado", "Sock : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Intente nuevamente", "Stock : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Botones();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EntStock c = new EntStock();
                c.idStock = Convert.ToInt32(bmt_codigo.Text.Trim());
                c.fecha = dtp_fecha.Value;
                c.st_x = Convert.ToDecimal(bmt_extra.Text.Trim());
                c.st_1 = Convert.ToDecimal(bmt_primera.Text.Trim());
                c.st_2 = Convert.ToDecimal(bmt_segunda.Text.Trim());
                c.st_3 = Convert.ToDecimal(bmt_tercera.Text.Trim());
                c.st_4 = Convert.ToDecimal(bmt_cuarta.Text.Trim());
                c.st_m = Convert.ToDecimal(bmt_manchada.Text.Trim());
                c.st_ch = Convert.ToDecimal(bmt_chica.Text.Trim());


                LogStock.Instancia.ModificarStock(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            Botones();
            Variables();
        }

        private void bnfcancelar_Click(object sender, EventArgs e)
        {
            drop_options.selectedIndex = 0;
            Botones();
            Variables();
            bmt_codigo.Visible = true;
        }
        void ListarStock()
        {
            datastock.DataSource = LogStock.Instancia.ListarUltimosDosStock();
        }
        private void idcompra_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
    }

        private void datastock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
