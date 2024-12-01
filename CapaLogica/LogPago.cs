using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogPago
    {
        //insertar datos
        public void InsertarPago(EntPago Sto)
        {
            DatPago.Instancia.InsertarPago(Sto);
        }
        //modificar stock

        public void ActualizarPago(EntPago Sto)
        {
            DatPago.Instancia.ActualizarPago(Sto);
        }
    }
}
