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
    public partial class ComprasForm : Form
    {
        public ComprasForm()
        {
            InitializeComponent();
            Botones();
        }

       
        void LimpiarCampos()
        {
            bnfCodigo.Text = "";
            bnfpr.Text = "";
            bnfdate.ResetText();
            bnfx.Text = "";
            bnf1.Text = "";
            bnf2.Text = "";
            bnf3.Text = "";
            bnf4.Text = "";
            bnfm.Text = "";
            bnfch.Text = "";
            bnfpx.Text = "";
            bnfp1.Text = "";
            bnfp2.Text = "";
            bnfp3.Text = "";
            bnfp4.Text = "";
            bnfpm.Text = "";
            bnfpch.Text = "";


        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                EntCompra c = new EntCompra();
                c.proveedor = bnfpr.Text.Trim();
                c.fecha = bnfdate.Value;
                c.cal_x = Convert.ToDecimal(bnfx.Text.Trim());
                c.cal_1 = Convert.ToDecimal(bnf1.Text.Trim());
                c.cal_2 = Convert.ToDecimal(bnf2.Text.Trim());
                c.cal_3 = Convert.ToDecimal(bnf3.Text.Trim());
                c.cal_4 = Convert.ToDecimal(bnf4.Text.Trim());
                c.cal_m = Convert.ToDecimal(bnfm.Text.Trim());
                c.cal_ch = Convert.ToDecimal(bnfch.Text.Trim());
                c.pr_x = Convert.ToDecimal(bnfpx.Text.Trim());
                c.pr_1 = Convert.ToDecimal(bnfp1.Text.Trim());
                c.pr_2 = Convert.ToDecimal(bnfp2.Text.Trim());
                c.pr_3 = Convert.ToDecimal(bnfp3.Text.Trim());
                c.pr_4 = Convert.ToDecimal(bnfp4.Text.Trim());
                c.pr_m = Convert.ToDecimal(bnfpm.Text.Trim());
                c.pr_ch = Convert.ToDecimal(bnfpch.Text.Trim());
                c.mont_tt = Convert.ToDecimal(bmt_total.Text.Trim());
                LogCompra.Instancia.InsertarCompra(c);
            } catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarCampos();
            PagosVentas form = new PagosVentas();
            form.ShowDialog();

        }

        private void bnfconsulta_Click(object sender, EventArgs e)
        {

            try
            {
                bnfCodigo.Focus();
                int codigo = int.Parse(bnfCodigo.Text.Trim());
                EntCompra compra = LogCompra.Instancia.BuscarCompra(codigo);
                if (compra != null)
                {
                    bnfCodigo.Text = Convert.ToString(compra.idcompra);
                    bnfdate.Value = compra.fecha;
                    bnfpr.Text = compra.proveedor.ToString();
                    bnfx.Text = Convert.ToString(compra.cal_x);
                    bnf1.Text = Convert.ToString(compra.cal_1);
                    bnf2.Text = Convert.ToString(compra.cal_2);
                    bnf3.Text = Convert.ToString(compra.cal_3);
                    bnf4.Text = Convert.ToString(compra.cal_4);
                    bnfm.Text = Convert.ToString(compra.cal_m);
                    bnfch.Text = Convert.ToString(compra.cal_ch);
                    bnfpx.Text = Convert.ToString(compra.pr_x);
                    bnfp1.Text = Convert.ToString(compra.pr_1);
                    bnfp2.Text = Convert.ToString(compra.pr_2);
                    bnfp3.Text = Convert.ToString(compra.pr_3);
                    bnfp4.Text = Convert.ToString(compra.pr_4);
                    bnfpm.Text = Convert.ToString(compra.pr_m);
                    bnfpch.Text = Convert.ToString(compra.pr_ch);
                    bmt_total.Text = Convert.ToString(compra.mont_tt);
                }

                else
                {
                    MessageBox.Show("no exiate el Stock buscado", "Sock : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch (Exception)
            {
                MessageBox.Show("Intente nuevamente", "Stock : Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bnfcancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Botones();

        }

        private void bnfmodificar_Click(object sender, EventArgs e)
        {
            


            try
            {
                EntCompra c = new EntCompra();
                c.idcompra = int.Parse(bnfCodigo.Text.Trim());
                c.proveedor = bnfpr.Text.Trim();
                c.fecha = bnfdate.Value;
                c.cal_x = Convert.ToDecimal(bnfx.Text.Trim());
                c.cal_1 = Convert.ToDecimal(bnf1.Text.Trim());
                c.cal_2 = Convert.ToDecimal(bnf2.Text.Trim());
                c.cal_3 = Convert.ToDecimal(bnf3.Text.Trim());
                c.cal_4 = Convert.ToDecimal(bnf4.Text.Trim());
                c.cal_m = Convert.ToDecimal(bnfm.Text.Trim());
                c.cal_ch = Convert.ToDecimal(bnfch.Text.Trim());
                c.pr_x = Convert.ToDecimal(bnfpx.Text.Trim());
                c.pr_1 = Convert.ToDecimal(bnfp1.Text.Trim());
                c.pr_2 = Convert.ToDecimal(bnfp2.Text.Trim());
                c.pr_3 = Convert.ToDecimal(bnfp3.Text.Trim());
                c.pr_4 = Convert.ToDecimal(bnfp4.Text.Trim());
                c.pr_m = Convert.ToDecimal(bnfpm.Text.Trim());
                c.pr_ch = Convert.ToDecimal(bnfpch.Text.Trim());
                c.mont_tt = Convert.ToDecimal(bmt_total.Text.Trim());


                LogCompra.Instancia.ModificarCompra(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            

        }

        private void bnfeliminar_Click(object sender, EventArgs e)
        {
            Botones();

            try
            {
                EntCompra c = new EntCompra();
                c.idcompra = int.Parse(bnfCodigo.Text.Trim());
                LogCompra.Instancia.EliminarCompra(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            LimpiarCampos();
        }

        private void btnf_cambios_Click(object sender, EventArgs e)
        {



        }

        private void bnfpx_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfpx.Text.Trim(), out valor) && valor >= 0)
            {

                bnfpx.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfpx.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfCodigo_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfCodigo.Text.Trim(), out valor) && valor >= 0)
            {

                bnfCodigo.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfCodigo.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfx_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfx.Text.Trim(), out valor) && valor >= 0)
            {

                bnfx.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfx.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnf1_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnf1.Text.Trim(), out valor) && valor >= 0)
            {

                bnf1.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnf1.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnf2_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnf2.Text.Trim(), out valor) && valor >= 0)
            {

                bnf2.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnf2.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnf3_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnf3.Text.Trim(), out valor) && valor >= 0)
            {

                bnf3.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnf3.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnf4_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnf4.Text.Trim(), out valor) && valor >= 0)
            {

                bnf4.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnf4.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfm_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfm.Text.Trim(), out valor) && valor >= 0)
            {

                bnfm.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfm.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfch_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfch.Text.Trim(), out valor) && valor >= 0)
            {

                bnfch.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfch.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfp1_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfp1.Text.Trim(), out valor) && valor >= 0)
            {

                bnfp1.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfp1.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfp2_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfp2.Text.Trim(), out valor) && valor >= 0)
            {

                bnfp2.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfp2.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfp3_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfp3.Text.Trim(), out valor) && valor >= 0)
            {

                bnfp3.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfp3.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfp4_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfp4.Text.Trim(), out valor) && valor >= 0)
            {

                bnfp4.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfp4.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfpm_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfpm.Text.Trim(), out valor) && valor >= 0)
            {

                bnfpm.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfpm.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void bnfpch_OnValueChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(bnfpch.Text.Trim(), out valor) && valor >= 0)
            {

                bnfpch.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                bnfpch.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }

        private void ComprasForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bnfsx.Text = Convert.ToString(Convert.ToDecimal(bnfx.Text.Trim()) * Convert.ToDecimal(bnfpx.Text.Trim()));
            bnfs1.Text = Convert.ToString(Convert.ToDecimal(bnf1.Text.Trim()) * Convert.ToDecimal(bnfp1.Text.Trim()));
            bnfs2.Text = Convert.ToString(Convert.ToDecimal(bnf2.Text.Trim()) * Convert.ToDecimal(bnfp2.Text.Trim()));
            bnfs3.Text = Convert.ToString(Convert.ToDecimal(bnf3.Text.Trim()) * Convert.ToDecimal(bnfp3.Text.Trim()));
            bnfs4.Text = Convert.ToString(Convert.ToDecimal(bnf4.Text.Trim()) * Convert.ToDecimal(bnfp4.Text.Trim()));
            bnfsm.Text = Convert.ToString(Convert.ToDecimal(bnfm.Text.Trim()) * Convert.ToDecimal(bnfpm.Text.Trim()));
            bnfsch.Text = Convert.ToString(Convert.ToDecimal(bnfch.Text.Trim()) * Convert.ToDecimal(bnfpch.Text.Trim()));

            bmt_total.Text = Convert.ToString(Convert.ToDecimal(bnfsx.Text.Trim()) +
                                            Convert.ToDecimal(bnfs1.Text.Trim()) +
                                            Convert.ToDecimal(bnfs2.Text.Trim()) +
                                            Convert.ToDecimal(bnfs3.Text.Trim()) +
                                            Convert.ToDecimal(bnfs4.Text.Trim()) +
                                            Convert.ToDecimal(bnfsm.Text.Trim()) +
                                            Convert.ToDecimal(bnfsch.Text.Trim()));
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
                LimpiarCampos();

            }
            else if (drop_options.selectedValue == "ACTUALIZAR DATO")
            {
                bnfmodificar.Visible = true;
                bnfcancelar.Visible = true;
                LimpiarCampos();
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
                LimpiarCampos();
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
