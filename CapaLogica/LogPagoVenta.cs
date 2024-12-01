using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogPagoVenta
    {
        private static readonly LogPagoVenta _instancia = new LogPagoVenta();

        public static LogPagoVenta Instancia
        {
            get
            {
                return LogPagoVenta._instancia;
            }
        }


        
        
       
        //ventas
        //listar datos
        public List<EntPagoVenta> ListarPagoVentas()
        {
            return DatPagoVenta.Instancia.ListarPagosVenta();
        }
        //ListarPagoVentasPendientes
        public List<EntPagoVenta> ListarPagoVentasPendientes()
        {
            return DatPagoVenta.Instancia.ListarPagoVentasPendientes();
        }
        //insertar datos
        public Boolean InsertarPagoVentas(EntPagoVenta Sto)
        {
            return DatPagoVenta.Instancia.InsertarPagoVenta(Sto);
        }
        //modificar stock
       
        public Boolean ProcesarPagoVentaId(EntPagoVenta Sto)
        {
            return DatPagoVenta.Instancia.ProcesarPagoVentaId(Sto);
        }
        public EntPagoVenta BuscarPagoVentaId(int codigo)
        {
            return DatPagoVenta.Instancia.BuscarPagoVentaId(codigo);
        }
        public Boolean EliminarPagosVenta(EntPagoVenta Sto)
        {
            return DatPagoVenta.Instancia.EliminarPagoVenta(Sto);
        }

       
    }
}
