using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPagoCompra
    {
       
        public int idpagocompra { get; set; }
        public string proveedor { get; set; }
       public DateTime fecha { get; set; }
        public string tipopago { get; set; }    // Tipo de pago
        public char estado { get; set; }        //A,B
        public decimal monto { get; set; }      // Monto del pago
        public int idcompra { get; set; }
    }
}
