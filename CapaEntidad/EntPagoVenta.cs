using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPagoVenta
    {
        public int idpagoventa {  get; set; }      
        public string descripcion { get; set; } // Descripción del pago       
        public DateTime fecha { get; set; }
        public string tipopago { get; set; }    // Tipo de pago
        public char estado { get; set; }        //A,B
        public decimal monto { get; set; }      // Monto del pago
        public int idventa { get; set; }

    }
}
