using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaLogica
{
    public class LogCompra
    {
        private static readonly LogCompra _instancia = new LogCompra();

        public static LogCompra Instancia
        {
            get
            {
                return LogCompra._instancia;
            }
        }

        //buscar venta
        public EntCompra BuscarCompra(int codigo)
        {
            return DatCompra.Instancia.BuscarCompra(codigo);
        }
        //listar datos
        public List<EntCompra> ListarCompra()
        {
            return DatCompra.Instancia.ListarCompras();
        }
        //insertar datos
        public Boolean InsertarCompra(EntCompra Com)
        {
            return DatCompra.Instancia.InsertarCompra(Com);
        }
        //modificar stock

        public Boolean ModificarCompra(EntCompra Com)
        {
            return DatCompra.Instancia.ModificarCompra(Com);
        }
        //eliminar
        public Boolean EliminarCompra(EntCompra Com)
        {
            return DatCompra.Instancia.EliminarCompra(Com);
        }
    }
}
