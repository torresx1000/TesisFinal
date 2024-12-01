using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatTransacciones
    {
        private static readonly DatTransacciones _instacia = new DatTransacciones();
        public static DatTransacciones Instancia
        {
            get
            {
                return DatTransacciones._instacia;
            }
        }
        // Listar Transacciones
        public List<EntTransacciones> ListarTransacciones()
        {
            SqlCommand cmd = null;
            List<EntTransacciones> lista = new List<EntTransacciones>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("sp_VerTransacciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTransacciones transa = new EntTransacciones();
                    transa.idtransaccion = Convert.ToInt32(dr["idtransaccion"]);
                    transa.IdPago = Convert.ToInt32(dr["idpago"]);
                    transa.Accion = Convert.ToString(dr["accion"]);
                    transa.Descripcion = Convert.ToString(dr["descripcion"]);
                    transa.fecha = Convert.ToDateTime(dr["fecha"]);
                    transa.Monto = Convert.ToDecimal(dr["monto"]);
                    transa.FechaTransaccion = Convert.ToDateTime(dr["fecha_transaccion"]);         
                   lista.Add(transa);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
