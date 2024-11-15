using Datos;
using Endidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Log_Venta
    {
        private static readonly Log_Venta _instancia = new Log_Venta();

        public static Log_Venta Instancia
        {
            get
            {
                return Log_Venta._instancia;
            }
        }
        //listar datos
        public List<Ent_ventas> ListarVentas()
        {
            return Dat_Ventas_V.Instancia.ListarVentas();
        } 

        //insertar datos
        public void InsertarVentas(Ent_ventas Com)
        {
            Dat_Ventas_V.Instancia.InsertarVenta(Com);
        }

        //modificar stock
        public void ModificarVentas(Ent_ventas Com)
        {
            Dat_Ventas_V.Instancia.ModificarVenta(Com);
        }
        //eliminar
        public void EliminarVentas(Ent_ventas Com)
        {
            Dat_Ventas_V.Instancia.EliminarVenta(Com);
        }
    }
}
