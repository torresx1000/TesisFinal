using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogStock
    {
        private static readonly LogStock _instancia = new LogStock();

        public static LogStock Instancia
        {
            get
            {
                return LogStock._instancia;
            }
        }
        //buscar stock
        public EntStock BuscarStock(int codigo)
        {
            return DatStock.Instancia.BuscarStock(codigo);
        }
        //buscar por fecha
       public EntStock BuscarStockFecha(DateTime fecha)
        {
            return DatStock.Instancia.BuscarStockPorFecha(fecha);
        }
        public List<EntStock> ListarStockPorFecha()
        {
            return DatStock.Instancia.ListarStockFecha();
        }
        //listar datos
        public List<EntStock> ListarStock()
        {
            return DatStock.Instancia.ListarStock();
        }

        //listar los 2 ultimos datos
        public List<EntStock> ListarUltimosDosStock()
        {
            return DatStock.Instancia.ListarUltimosDosStock();
        }
        //insertar datos
        public Boolean InsertarStock(EntStock Sto)
        {
            return DatStock.Instancia.InsertarStock(Sto);
        }
        //modificar stock

        public Boolean ModificarStock(EntStock Sto)
        {
            return DatStock.Instancia.ModificarStock(Sto);
        }
        //eliminar


        public Boolean EliminarStock(EntStock Sto)
        {
            return DatStock.Instancia.EliminarStock(Sto);
        }
       
    }
}
