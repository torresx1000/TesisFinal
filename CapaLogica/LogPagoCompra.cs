using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica { 
    public class LogPagoCompra
    {
        private static readonly LogPagoCompra _instancia = new LogPagoCompra();

        public static LogPagoCompra Instancia
        {
            get
            {
                return LogPagoCompra._instancia;
            }
        }


        //compras
        //listar datos
         public List<EntPagoCompra> ListarPagosCompra()
         {
             return DatPagoCompra.Instancia.ListarPagosCompra();
         }
        public List<EntPagoCompra> ListarPagosCompraPendientes()
        {
            return DatPagoCompra.Instancia.ListarPagosCompraPendientes();
        }

        //insertar datos
        public Boolean InsertarPagoCompras(EntPagoCompra Sto)
        {
            return DatPagoCompra.Instancia.InsertarPagoCompra(Sto);
        }
        //modificar stock

        public Boolean ProcesarPagoCompraId(EntPagoCompra Sto)
        {
            return DatPagoCompra.Instancia.ProcesarPagoCompra(Sto);
        }
        //buscar compra x id
        public EntPagoCompra BuscarPagoCompraId(int codigo)
        {
            return DatPagoCompra.Instancia.BuscarPagoCompraId(codigo);
        }

        public Boolean EliminarPagoCompras(EntPagoCompra Sto)
        {
            return DatPagoCompra.Instancia.EliminarPagoCompra(Sto);
        }


    }
}

