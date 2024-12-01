using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogVenta
    {
        private static readonly LogVenta _instancia = new LogVenta();

        public static LogVenta Instancia
        {
            get
            {
                return LogVenta._instancia;
            }
        }
        //buscar stock
        public EntVenta BuscarVenta(int codigo)
        {
            return DatVenta.Instancia.BuscarVenta(codigo);
        }

        //listar datos
        public List<EntVenta> ListarVentas()
        {
            return DatVenta.Instancia.ListarVentas();
        }

        //insertar datos
        public Boolean InsertarVentas(EntVenta Com)
        {
            return DatVenta.Instancia.InsertarVenta(Com);
        }

        //modificar stock
        public Boolean ModificarVentas(EntVenta Com)
        {
            return DatVenta.Instancia.ModificarVenta(Com);
        }
        //eliminar
        public Boolean EliminarVentas(EntVenta Com)
        {
            return DatVenta.Instancia.EliminarVenta(Com);
        }
    }
}
