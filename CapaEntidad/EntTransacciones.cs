using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntTransacciones
    {
        public int idtransaccion {  get; set; }//identificador de la transaccion
        public int IdPago { get; set; }  // Representa el campo idpago
        public string Accion { get; set; }  // Representa el campo accion
        public string Descripcion { get; set; }  // Representa el campo descripcion
        public DateTime fecha { get; set; }
        public decimal Monto { get; set; }  // Representa el campo monto
        public DateTime FechaTransaccion { get; set; }  // Representa el campo fecha_transaccion

    }
}
