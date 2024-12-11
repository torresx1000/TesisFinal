using CapaEntidad;
using CapaLogica;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            /* try
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
            */
            try
            {
                // Crear objeto de pago
                EntPagoVenta c = new EntPagoVenta
                {
                    idpagoventa = Convert.ToInt32(txtCodVenta.Text.Trim()),
                    tipopago = Convert.ToString(cbotipo.Text.Trim()),
                    estado = 'B'
                };

                // Procesar el pago
                LogPagoVenta.Instancia.ProcesarPagoVentaId(c);

                // Buscar el pago para obtener la información completa
                EntPagoVenta pago = LogPagoVenta.Instancia.BuscarPagoVentaId(c.idpagoventa);

                // Generar el PDF
                GenerarPdfPagoCompra(pago);

                MessageBox.Show("Pago procesado y PDF generado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarPagosSinProceso();
            
            Botones();
        }
        private void GenerarPdfPagoCompra(EntPagoVenta pago)
        {
            string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Pagos Venta", "Pagos");
            Directory.CreateDirectory(carpetaDestino);

            string rutaArchivo = Path.Combine(carpetaDestino, $"Pago_{pago.idpagoventa}.pdf");

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
                pdfDoc.Add(new Paragraph("                         " + "Comprobante de Pago", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 17)));
                pdfDoc.Add(new Paragraph("             " + $"ID Pago: {pago.idpagoventa}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Descripción: {pago.descripcion}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Fecha: {pago.fecha:dd/MM/yyyy}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Tipo de Pago: {pago.tipopago}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Estado: {pago.estado}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));
                pdfDoc.Add(new Paragraph("             " + $"Monto: S/ {pago.monto:F2}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15)));
                pdfDoc.Add(new Paragraph("             " + $"ID Compra: {pago.idventa}", FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14)));

                pdfDoc.Close();
                writer.Close();
            }
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
                MessageBox.Show("ingresa el ID o CODIGO de la tabla para PROCESAR.");
                btprocesar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "BUSCAR")
            {
                MessageBox.Show("ingresa el ID o CODIGO PARA BUSCAR.");
                btbuscar.Visible = true;
                btcancelar.Visible = true;
                LimpiarVariables();
            }
            else if (drop_options.selectedValue == "ELIMINAR")
            {
                MessageBox.Show("ingresa el ID o CODIGO PARA ELIMINAR.");
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
