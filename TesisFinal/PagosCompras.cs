using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesisFinal
{
    public partial class dgvPagos : Form
    {
        public dgvPagos()
        {
            InitializeComponent();
            LimpiarVariables();
            ListarComprasRealizadas();
            ListarPagosSinProceso();
            Botones();
        }
        void LimpiarVariables()
        {
            txtCodPago.Text = "";
            txtProveedor.Text = "";
            dtmFecha.ResetText();
            cboTipo.selectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            txtMonto.Text = "";
            cboCodCompra.Text  = "";

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
        public void ListarComprasRealizadas()
        {
            cboCodCompra.DataSource = LogCompra.Instancia.ListarCompra();
            cboCodCompra.DisplayMember = "idcompra";
            cboCodCompra.ValueMember = "idcompra";
                
        }
        public void ListarPagosSinProceso()
        {
            datapagosSin.DataSource = LogPagoCompra.Instancia.ListarPagosCompraPendientes();
        }

        private void btcrear_Click(object sender, EventArgs e)
        {
            try
            {
                EntPagoCompra pagoCompra = new EntPagoCompra();
                pagoCompra.proveedor = txtProveedor.Text;
                pagoCompra.fecha= dtmFecha.Value;
                pagoCompra.tipopago = cboTipo.selectedValue.Trim();
                pagoCompra.estado = 'A';
                pagoCompra.monto = Convert.ToDecimal(txtMonto.Text.Trim());
                pagoCompra.idcompra= Convert.ToInt32(cboCodCompra.Text.Trim());
                LogPagoCompra.Instancia.InsertarPagoCompras(pagoCompra);
            }catch(Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
            LimpiarVariables();
            ListarPagosSinProceso();
        }

        private void btprocesar_Click(object sender, EventArgs e)
        {
            try
            {
                EntPagoCompra c = new EntPagoCompra();
                c.idpagocompra = Convert.ToInt32(txtCodPago.Text.Trim());
                c.tipopago = cboTipo.selectedValue.Trim();
                c.estado = 'B';
                LogPagoCompra.Instancia.ProcesarPagoCompraId(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            ListarPagosSinProceso();
        }
        private void btbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodPago.Focus();
                int codigo = int.Parse(txtCodPago.Text.Trim());
                EntPagoCompra sto = LogPagoCompra.Instancia.BuscarPagoCompraId(codigo);
                if (sto != null)
                {
                    txtCodPago.Text = Convert.ToString(sto.idpagocompra);
                    txtProveedor.Text = Convert.ToString(sto.proveedor);
                    dtmFecha.Text = Convert.ToString(sto.fecha);
                    if (Convert.ToString(sto.tipopago) == "EFECTIVO")
                    {
                        cboTipo.selectedIndex = 1;
                    }
                    else if (Convert.ToString(sto.tipopago) == "TARJETA")
                    {
                        cboTipo.selectedIndex = 2;
                    }
                    
                    cboEstado.Text = Convert.ToString(sto.estado);
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
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                EntPagoCompra c = new EntPagoCompra();
                c.idpagocompra = int.Parse(txtCodPago.Text.Trim());
                LogPagoCompra.Instancia.EliminarPagoCompras(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
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
    }
}
