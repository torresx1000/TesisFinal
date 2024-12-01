using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogTransacciones
    {

        private static readonly LogTransacciones _instancia = new LogTransacciones();

        public static LogTransacciones Instancia
        {
            get
            {
                return LogTransacciones._instancia;
            }
        }
        //listar datos
        public List<EntTransacciones> ListarTransacciones()
        {
            return DatTransacciones.Instancia.ListarTransacciones();
        }
    }
}
