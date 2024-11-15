using Datos;
using Endidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Log_compra
    {
        private static readonly Log_compra _instancia = new Log_compra();

        public static Log_compra Instancia
        {
            get
            {
                return Log_compra._instancia;
            }
        }
        //listar datos
        public List<Ent_compra_r> ListarCompra()
        {
            return Dat_Compra_R.Instancia.ListarCompras();
        }
        //insertar datos
        public void InsertarCompra(Ent_compra_r Com)
        {
            Dat_Compra_R.Instancia.InsertarCompra(Com);
        }
        //modificar stock

        public void ModificarCompra(Ent_compra_r Com)
        {
            Dat_Compra_R.Instancia.ModificarCompra(Com);
        }
        //eliminar
        public void EliminarCompra(Ent_compra_r Com)
        {
            Dat_Compra_R.Instancia.EliminarCompra(Com);
        }
    }
}
