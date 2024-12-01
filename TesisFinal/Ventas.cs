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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            ListarFechasStock();
            Botones();


        }

        void LimpiarCampos()
        {
            bmt_codigo.Text = "";
            bmt_extra.Text = "";
            bmt_primera.Text = "";
            bmt_segunda.Text = "";
            bmt_tercera.Text = "";
            bmt_cuarta.Text = "";
            bmt_manchada.Text = "";
            bmt_chica.Text = "";
            codigo.Text = "";
            fecha.ResetText(); ;
            descripcion.Text = "";
            caex.Text = "";
            cae1.Text = "";
            cae2.Text = "";
            cae3.Text = "";
            cae4.Text = "";
            caem.Text = "";
            caech.Text = "";
            capx.Text = "";
            cap1.Text = "";
            cap2.Text = "";
            cap3.Text = "";
            cap4.Text = "";
            capm.Text = "";
            capch.Text = "";
            bmt_total.Text = "";

        }

        private void ListarFechasStock()
        {
            bx_search_date.DataSource = LogStock.Instancia.ListarStockPorFecha();
            bx_search_date.DisplayMember = "fecha";
            bx_search_date.ValueMember = "fecha";
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gb_stock_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox17_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void bx_search_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bx_search_date.Focus();
                DateTime fecha = Convert.ToDateTime(bx_search_date.Text.Trim());
                EntStock sto = LogStock.Instancia.BuscarStockFecha(fecha);
                if (sto != null)
                {

                    bmt_codigo.Text = Convert.ToString(sto.idStock);
                    dtp_fecha.Value = Convert.ToDateTime(sto.fecha);
                    bmt_extra.Text = Convert.ToString(sto.st_x);    
                    bmt_primera.Text = Convert.ToString(sto.st_1);
                    bmt_segunda.Text = Convert.ToString(sto.st_2);
                    bmt_tercera.Text = Convert.ToString(sto.st_3);
                    bmt_cuarta.Text = Convert.ToString(sto.st_4);
                    bmt_manchada.Text = Convert.ToString(sto.st_m);
                    bmt_chica.Text = Convert.ToString(sto.st_ch);
                    codstock.Text = bmt_codigo.Text.Trim();
                }

                else
                {
                    bmt_codigo.Text = string.Empty;
                    MessageBox.Show("no exiate el Stock buscado", "Sock : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("realice sus ventas con el stock", "Stock : Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(caex.Text.Trim(), out valor) && valor >= 0)
            {

                caex.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                caex.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void codigo_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(codigo.Text.Trim(), out valor) && valor >= 0)
            {

                codigo.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                codigo.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cae1_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cae1.Text.Trim(), out valor) && valor >= 0)
            {

                cae1.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cae1.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cae2_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cae2.Text.Trim(), out valor) && valor >= 0)
            {

                cae2.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cae2.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cae3_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cae3.Text.Trim(), out valor) && valor >= 0)
            {

                cae3.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cae3.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cae4_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cae4.Text.Trim(), out valor) && valor >= 0)
            {

                cae4.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cae4.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void caem_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(caem.Text.Trim(), out valor) && valor >= 0)
            {

                caem.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                caem.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void caech_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(caech.Text.Trim(), out valor) && valor >= 0)
            {

                caech.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                caech.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void capx_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(capx.Text.Trim(), out valor) && valor >= 0)
            {

                capx.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                capx.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cap1_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cap1.Text.Trim(), out valor) && valor >= 0)
            {

                cap1.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cap1.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cap2_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cap2.Text.Trim(), out valor) && valor >= 0)
            {

                cap2.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cap2.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cap3_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cap3.Text.Trim(), out valor) && valor >= 0)
            {

                cap3.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cap3.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void cap4_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(cap4.Text.Trim(), out valor) && valor >= 0)
            {

                cap4.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                cap4.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void capm_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(capm.Text.Trim(), out valor) && valor >= 0)
            {

                capm.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                capm.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void capch_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(capch.Text.Trim(), out valor) && valor >= 0)
            {

                capch.BackColor = Color.LightSlateGray; // Indicar entrada válida
            }
            else
            {
                capch.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void subm_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {


                EntVenta v = new EntVenta
                {
                    fecha = fecha.Value,
                    motivo = descripcion.Text.Trim(),
                    cal_x = Convert.ToDecimal(caex.Text.Trim()),
                    cal_1 = Convert.ToDecimal(cae1.Text.Trim()),
                    cal_2 = Convert.ToDecimal(cae2.Text.Trim()),
                    cal_3 = Convert.ToDecimal(cae3.Text.Trim()),
                    cal_4 = Convert.ToDecimal(cae4.Text.Trim()),
                    cal_m = Convert.ToDecimal(caem.Text.Trim()),
                    cal_ch = Convert.ToDecimal(caech.Text.Trim()),
                    pr_x = Convert.ToDecimal(capx.Text.Trim()),
                    pr_1 = Convert.ToDecimal(cap1.Text.Trim()),
                    pr_2 = Convert.ToDecimal(cap2.Text.Trim()),
                    pr_3 = Convert.ToDecimal(cap3.Text.Trim()),
                    pr_4 = Convert.ToDecimal(cap4.Text.Trim()),
                    pr_m = Convert.ToDecimal(capm.Text.Trim()),
                    pr_ch = Convert.ToDecimal(capch.Text.Trim()),
                    mont_tt = Convert.ToDecimal(bmt_total.Text.Trim()),
                    idstock = Convert.ToInt32(bmt_codigo.Text.Trim()),

                };

                LogVenta.Instancia.InsertarVentas(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la venta: " + ex);
            }

            PagosVentas form = new PagosVentas();
            form.ShowDialog();
            
        }  

        private void subx_OnValueChanged(object sender, EventArgs e)
        {



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            subx.Text = Convert.ToString(Convert.ToDecimal(caex.Text.Trim()) * Convert.ToDecimal(capx.Text.Trim()));
            sub1.Text = Convert.ToString(Convert.ToDecimal(cae1.Text.Trim()) * Convert.ToDecimal(cap1.Text.Trim()));
            sub2.Text = Convert.ToString(Convert.ToDecimal(cae2.Text.Trim()) * Convert.ToDecimal(cap2.Text.Trim()));
            sub3.Text = Convert.ToString(Convert.ToDecimal(cae3.Text.Trim()) * Convert.ToDecimal(cap3.Text.Trim()));
            sub4.Text = Convert.ToString(Convert.ToDecimal(cae4.Text.Trim()) * Convert.ToDecimal(cap4.Text.Trim()));
            subm.Text = Convert.ToString(Convert.ToDecimal(caem.Text.Trim()) * Convert.ToDecimal(capm.Text.Trim()));
            subch.Text = Convert.ToString(Convert.ToDecimal(caech.Text.Trim()) * Convert.ToDecimal(capch.Text.Trim()));

            bmt_total.Text = Convert.ToString(Convert.ToDecimal(subx.Text.Trim()) +
                                            Convert.ToDecimal(sub1.Text.Trim()) +
                                            Convert.ToDecimal(sub2.Text.Trim()) +
                                            Convert.ToDecimal(sub3.Text.Trim()) +
                                            Convert.ToDecimal(sub4.Text.Trim()) +
                                            Convert.ToDecimal(subm.Text.Trim()) +
                                            Convert.ToDecimal(subch.Text.Trim()));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EntVenta c = new EntVenta();
                c.idventa = int.Parse(codigo.Text.Trim());
                c.fecha = fecha.Value;
                c.motivo = descripcion.Text.Trim();
                c.cal_x = Convert.ToDecimal(caex.Text.Trim());
                c.cal_1 = Convert.ToDecimal(cae1.Text.Trim());
                c.cal_2 = Convert.ToDecimal(cae2.Text.Trim());
                c.cal_3 = Convert.ToDecimal(cae3.Text.Trim());
                c.cal_4 = Convert.ToDecimal(cae4.Text.Trim());
                c.cal_m = Convert.ToDecimal(caem.Text.Trim());
                c.cal_ch = Convert.ToDecimal(caech.Text.Trim());
                c.pr_x = Convert.ToDecimal(capx.Text.Trim());
                c.pr_1 = Convert.ToDecimal(cap1.Text.Trim());
                c.pr_2 = Convert.ToDecimal(cap2.Text.Trim());
                c.pr_3 = Convert.ToDecimal(cap3.Text.Trim());
                c.pr_4 = Convert.ToDecimal(cap4.Text.Trim());
                c.pr_m = Convert.ToDecimal(capm.Text.Trim());
                c.pr_ch = Convert.ToDecimal(capch.Text.Trim());
                c.mont_tt = Convert.ToDecimal(bmt_total.Text.Trim());


                LogVenta.Instancia.ModificarVentas(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Botones();
            try
            {
                EntVenta c = new EntVenta();
                c.idventa = int.Parse(codigo.Text.Trim());
                LogVenta.Instancia.EliminarVentas(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            LimpiarCampos();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
           try
            {
                codigo.Focus();
                int idcodigo = int.Parse(codigo.Text.Trim());
                EntVenta venta = LogVenta.Instancia.BuscarVenta(idcodigo);
                if (venta != null)
                {
                codigo.Text = Convert.ToString(venta.idventa);
                    fecha.Text = Convert.ToString(venta.fecha);
                    descripcion.Text = venta.motivo.ToString();
                    caex.Text = Convert.ToString(venta.cal_x);
                    cae1.Text = Convert.ToString(venta.cal_1);
                    cae2.Text = Convert.ToString(venta.cal_2);
                    cae3.Text = Convert.ToString(venta.cal_3);
                    cae4.Text = Convert.ToString(venta.cal_4);
                    caem.Text = Convert.ToString(venta.cal_m);
                    caech.Text = Convert.ToString(venta.cal_ch);
                    capx.Text = Convert.ToString(venta.pr_x);
                    cap1.Text = Convert.ToString(venta.pr_1);
                    cap2.Text = Convert.ToString(venta.pr_2);
                    cap3.Text = Convert.ToString(venta.pr_3);
                    cap4.Text = Convert.ToString(venta.pr_4);
                    capm.Text = Convert.ToString(venta.pr_m);
                    capch.Text = Convert.ToString(venta.pr_ch);
                    bmt_total.Text = Convert.ToString(venta.mont_tt);

                }

                else
                {
                    MessageBox.Show("no existe la venta buscado", "Sock : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Intente nuevamente", "Venta : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

            if (drop_options.selectedValue == null)
            {

                LimpiarCampos();

            }
            else if (drop_options.selectedValue == "NUEVO DATO")
            {
                bnfnuevo.Visible = true;
                bnfcancelar.Visible = true;
            }
            else if (drop_options.selectedValue == "ACTUALIZAR DATO")
            {
                bnfmodificar.Visible = true;
                bnfcancelar.Visible = true;
            }
            else if (drop_options.selectedValue == "BUSCAR DATO")
            {
                bnfconsultar.Visible = true;
                bnfcancelar.Visible = true;
            }
            else if (drop_options.selectedValue == "ELIMINAR DATO")
            {
                bnfeliminar.Visible = true;
                bnfcancelar.Visible = true;
            }
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

        private void bnfcancelar_Click(object sender, EventArgs e)
        {
         
            LimpiarCampos();
            Botones();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bmt_total_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fecha_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
