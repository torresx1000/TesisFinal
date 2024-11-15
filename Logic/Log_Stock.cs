using Datos;
using Endidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Log_Stock
    {

        private static readonly Log_Stock _instancia = new Log_Stock();
        
        public static Log_Stock Instancia
        {
            get
            {
                return Log_Stock._instancia;
            }
        }
        //listar datos
        public List <Ent_Stock> ListarStock()
        {
            return Dat_Stock.Instancia.ListarStock();
        }
        //insertar datos
        public void InsertarStock(Ent_Stock Sto)
        {
            Dat_Stock.Instancia.InsertarStock(Sto);
        }
        //modificar stock

        public void ModificarStock(Ent_Stock Sto)
        {
            Dat_Stock.Instancia.ModificarStock(Sto);
        }
        //eliminar
        public void EliminarStock(Ent_Stock Sto)
        {
            Dat_Stock.Instancia.EliminarStock(Sto);
        }
    }
}
