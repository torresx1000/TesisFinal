using CapaEntidad;
using CapaLogica;
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
    public partial class PagosVentas : Form
    {
        public PagosVentas()
        {
            InitializeComponent();
            ListarVentasRealizadas();
            ListarPagosSinProceso();
            Botones();
        }
        void LimpiarVariables()
        {
            txtCodVenta.Text = "";
            txtMotivo.Text = "";
            dtmfecha.ResetText();
            cbotipo.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
            txtMonto.Text = "";
            idventa.Text = "";

        }
        void Botones()
        {
            btcrear.Visible = false;
            btbuscar.Visible = false;
            btcancelar.Visible = false;
            btprocesar.Visible = false;
            bteliminar.Visible = false;
            drop_options.selectedIndex = 0;
        }
        public void ListarPagosSinProceso()
        {
            dataPagosSin.DataSource = LogPagoVenta.Instancia.ListarPagoVentasPendientes();
        }
        public void ListarVentasRealizadas()
        {
            idventa.DataSource = LogVenta.Instancia.ListarVentas();
            idventa.DisplayMember = "idventa";
            idventa.ValueMember = "idventa";

        }
        private void btcrear_Click(object sender, EventArgs e)
        {
            try
            {
                EntPagoVenta pagoVenta = new EntPagoVenta();
                pagoVenta.descripcion = txtMotivo.Text;
                pagoVenta.fecha = dtmfecha.Value;
                pagoVenta.tipopago = cbotipo.Text.Trim();
                pagoVenta.estado = 'A';
                pagoVenta.monto = Convert.ToDecimal(txtMonto.Text.Trim());
                pagoVenta.idventa = Convert.ToInt32(idventa.Text.Trim());
                LogPagoVenta.Instancia.InsertarPagoVentas(pagoVenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
            LimpiarVariables();
            ListarPagosSinProceso();
            Botones();
        }

        private void btprocesar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPagoVenta c = new EntPagoVenta();
                c.idpagoventa = Convert.ToInt32(txtCodVenta.Text.Trim());
                c.tipopago = cbotipo.Text.Trim();
                c.estado = 'B';
                LogPagoVenta.Instancia.ProcesarPagoVentaId(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            ListarPagosSinProceso();
            Botones();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodVenta.Focus();
                int codigo = int.Parse(txtCodVenta.Text.Trim());
                EntPagoVenta sto = LogPagoVenta.Instancia.BuscarPagoVentaId(codigo);
                if (sto != null)
                {
                    txtCodVenta.Text = Convert.ToString(sto.idpagoventa);
                    txtMotivo.Text = Convert.ToString(sto.descripcion);
                    dtmfecha.Text = Convert.ToString(sto.fecha);
                    cbotipo.Text = Convert.ToString(sto.tipopago);
                    cboestado.Text = Convert.ToString(sto.estado);
                    txtMonto.Text = Convert.ToString(sto.monto);
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

        private void bteliminar_Click(object sender, EventArgs e)
        {
            try
            { 
                EntPagoVenta c = new EntPagoVenta();
                c.idpagoventa = int.Parse(txtCodVenta.Text.Trim());
                LogPagoVenta.Instancia.EliminarPagosVenta(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            ListarPagosSinProceso();
            Botones();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            txtCodVenta.Visible = false;
            label1.Visible = false;
            Botones();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void opciones_onItemSelected(object sender, EventArgs e)
        {
            if (drop_options.selectedValue == null)
            {

                LimpiarVariables();

            }
            else if (drop_options.selectedValue == "CREAR ORDEN")
            {
                btcrear.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
                txtCodVenta.Visible = false;
                label1.Visible = false;
            }
            else if (drop_options.selectedValue == "PROCESAR")
            {
                btprocesar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "BUSCAR")
            {
                btbuscar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "ELIMINAR")
            {
                bteliminar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            decimal valor;
            if (decimal.TryParse(txtMonto.Text.Trim(), out valor) && valor >= 0)
            {

                txtMonto.BackColor = Color.AliceBlue; // Indicar entrada válida
            }
            else
            {
                txtMonto.BackColor = Color.LightCoral; // Indicar entrada inválida
            }
        }
    }
}
