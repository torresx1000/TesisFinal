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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
using System.IO;

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
            cboTipo.SelectedIndex = 0;
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
                pagoCompra.fecha = dtmFecha.Value;
                pagoCompra.tipopago = Convert.ToString(cboTipo.Text.Trim());
                pagoCompra.estado = 'A';
                pagoCompra.monto = Convert.ToDecimal(txtMonto.Text.Trim());
                pagoCompra.idcompra = Convert.ToInt32(cboCodCompra.Text.Trim());
                LogPagoCompra.Instancia.InsertarPagoCompras(pagoCompra);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
            LimpiarVariables();
            ListarPagosSinProceso();
        }


        private void btprocesar_Click(object sender, EventArgs e)
        {/*
           
            try
            {
                EntPagoCompra c = new EntPagoCompra();
                c.idpagocompra = Convert.ToInt32(txtCodPago.Text.Trim());
                c.tipopago = Convert.ToString(cboTipo.Text.Trim());
                c.estado = 'B';
                LogPagoCompra.Instancia.ProcesarPagoCompraId(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            ListarPagosSinProceso();


            // aquim va reporte

            */


            try
            {
                // Crear objeto de pago
                EntPagoCompra c = new EntPagoCompra
                {
                    idpagocompra = Convert.ToInt32(txtCodPago.Text.Trim()),
                    tipopago = Convert.ToString(cboTipo.Text.Trim()),
                    estado = 'B'
                };

                // Procesar el pago
                LogPagoCompra.Instancia.ProcesarPagoCompraId(c);

                // Buscar el pago para obtener la información completa
                EntPagoCompra pago = LogPagoCompra.Instancia.BuscarPagoCompraId(c.idpagocompra);

                // Generar el PDF
                GenerarPdfPagoCompra(pago);

                MessageBox.Show("Pago procesado y PDF generado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Botones();
            // Actualizar lista de pagos
            ListarPagosSinProceso();
        }
        private void GenerarPdfPagoCompra(EntPagoCompra pago)
        {
            string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pagos Compra", "Pagos");
            Directory.CreateDirectory(carpetaDestino);

            string rutaArchivo = Path.Combine(carpetaDestino, $"Pago_{pago.idpagocompra}.pdf");

            using (FileStream stream = new FileStream(rutaArchivo, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open(); // Establecer imagen de fondo
                iTextSharp.text.Image imgFondo = iTextSharp.text.Image.GetInstance("D:\\Proyectos\\copia\\TesisFinal\\TesisFinal\\images_icons\\fondor.png");
                imgFondo.SetAbsolutePosition(0, 0);  // Posición en la esquina inferior izquierda
                imgFondo.ScaleToFit(pdfDoc.PageSize.Width, pdfDoc.PageSize.Height);  // Ajustar al tamaño de la página
                writer.DirectContentUnder.AddImage(imgFondo);  // Añadir como fondo


                // Agregar contenido al PDF
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(new Paragraph("                  " + "Comprobante de Pago", FontFactory.GetFont( FontFactory.HELVETICA_BOLD,  17)));
                pdfDoc.Add(new Paragraph("             " + $"ID Pago: {pago.idpagocompra}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Proveedor: {pago.proveedor}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Fecha: {pago.fecha:dd/MM/yyyy}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Tipo de Pago: {pago.tipopago}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Estado: {pago.estado}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Monto: S/ {pago.monto:F2}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15)));
                pdfDoc.Add(new Paragraph("             " + $"ID Compra: {pago.idcompra}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));

                pdfDoc.Close();
                writer.Close();
            }
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
                        cboTipo.SelectedIndex = 0;
                    }
                    else if (Convert.ToString(sto.tipopago) == "TARJETA")
                    {
                        cboTipo.SelectedIndex = 1;
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
            Botones();
            txtCodPago.Visible = true;
            label1.Visible = true;
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
                txtCodPago.Visible = true;
                label1.Visible = true;

            }
            else if (drop_options.selectedValue == "CREAR ORDEN")
            {
                txtCodPago.Visible = false;
                label1.Visible = false;
                btcrear.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "PROCESAR")
            {
                MessageBox.Show("ingresa el ID o CODIGO para PROCESAR.");
                btprocesar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "BUSCAR")
            {
                MessageBox.Show("ingresa el ID o CODIGO para BUSCAR.");
                btbuscar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "ELIMINAR")
            {
                MessageBox.Show("ingresa el ID o CODIGO para ELIMINAR.");
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
