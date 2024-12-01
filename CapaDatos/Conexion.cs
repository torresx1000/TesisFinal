using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = DESKTOP-CI0V46U\\SQLEXPRESS; Initial Catalog = TESIS1;" + //"User ID=sa; Password = 123";
            "Integrated Security=true";
            return con;
        }

    }

}
