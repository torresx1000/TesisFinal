using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
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
            con.ConnectionString = "Data Source = DESKTOP-CI0V46U\\SQLEXPRESS; Initial Catalog = TESIS;" + //"User ID=sa; Password = 123";
            "Integrated Security=true";
            return con;
        }
            
        }


        
    
}
