using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class DatCompra
    {
        //instancia
        private static readonly DatCompra _instacia = new DatCompra();
        public static DatCompra Instancia
        {
            get
            {
                return DatCompra._instacia;
            }
        }

        //buscar compra
        // Buscar en compra_R
        public EntCompra BuscarCompra(int id_compra)
        {
            SqlCommand cmd = null;
            EntCompra compra = new EntCompra();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcompra", id_compra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    compra.idcompra = Convert.ToInt32(dr["idcompra"]);
                    compra.proveedor = dr["proveedor"].ToString();
                    compra.fecha = Convert.ToDateTime(dr["fecha"]);
                    compra.cal_x = Convert.ToDecimal(dr["cal_x"]);
                    compra.cal_1 = Convert.ToDecimal(dr["cal_1"]);
                    compra.cal_2 = Convert.ToDecimal(dr["cal_2"]);
                    compra.cal_3 = Convert.ToDecimal(dr["cal_3"]);
                    compra.cal_4 = Convert.ToDecimal(dr["cal_4"]);
                    compra.cal_m = Convert.ToDecimal(dr["cal_m"]);
                    compra.cal_ch = Convert.ToDecimal(dr["cal_ch"]);
                    compra.pr_x = Convert.ToDecimal(dr["pr_x"]);
                    compra.pr_1 = Convert.ToDecimal(dr["pr_1"]);
                    compra.pr_2 = Convert.ToDecimal(dr["pr_2"]);
                    compra.pr_3 = Convert.ToDecimal(dr["pr_3"]);
                    compra.pr_4 = Convert.ToDecimal(dr["pr_4"]);
                    compra.pr_m = Convert.ToDecimal(dr["pr_m"]);
                    compra.pr_ch = Convert.ToDecimal(dr["pr_ch"]);
                    compra.mont_tt = Convert.ToDecimal(dr["mont_tt"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return compra;
        }


        // Listar compras
        public List<EntCompra> ListarCompras()
        {
            SqlCommand cmd = null;
            List<EntCompra> lista = new List<EntCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntCompra compra = new EntCompra();
                    compra.idcompra = Convert.ToInt32(dr["idcompra"]);
                    compra.proveedor = Convert.ToString(dr["proveedor"]);
                    compra.fecha = Convert.ToDateTime(dr["fecha"]);
                    compra.cal_x = Convert.ToDecimal(dr["cal_x"]);
                    compra.cal_1 = Convert.ToDecimal(dr["cal_1"]);
                    compra.cal_2 = Convert.ToDecimal(dr["cal_2"]);
                    compra.cal_3 = Convert.ToDecimal(dr["cal_3"]);
                    compra.cal_4 = Convert.ToDecimal(dr["cal_4"]);
                    compra.cal_m = Convert.ToDecimal(dr["cal_m"]);
                    compra.cal_ch = Convert.ToDecimal(dr["cal_ch"]);
                    compra.pr_x = Convert.ToDecimal(dr["pr_x"]);
                    compra.pr_1 = Convert.ToDecimal(dr["pr_1"]);
                    compra.pr_2 = Convert.ToDecimal(dr["pr_2"]);
                    compra.pr_3 = Convert.ToDecimal(dr["pr_3"]);
                    compra.pr_4 = Convert.ToDecimal(dr["pr_4"]);
                    compra.pr_m = Convert.ToDecimal(dr["pr_m"]);
                    compra.pr_ch = Convert.ToDecimal(dr["pr_ch"]);
                    compra.mont_tt = Convert.ToDecimal(dr["mont_tt"]);

                    lista.Add(compra);
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

        // Insertar compra
        public Boolean InsertarCompra(EntCompra compra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proveedor", compra.proveedor);
                cmd.Parameters.AddWithValue("@fecha", compra.fecha);
                cmd.Parameters.AddWithValue("@cal_x", compra.cal_x);
                cmd.Parameters.AddWithValue("@cal_1", compra.cal_1);
                cmd.Parameters.AddWithValue("@cal_2", compra.cal_2);
                cmd.Parameters.AddWithValue("@cal_3", compra.cal_3);
                cmd.Parameters.AddWithValue("@cal_4", compra.cal_4);
                cmd.Parameters.AddWithValue("@cal_m", compra.cal_m);
                cmd.Parameters.AddWithValue("@cal_ch", compra.cal_ch);
                cmd.Parameters.AddWithValue("@pr_x", compra.pr_x);
                cmd.Parameters.AddWithValue("@pr_1", compra.pr_1);
                cmd.Parameters.AddWithValue("@pr_2", compra.pr_2);
                cmd.Parameters.AddWithValue("@pr_3", compra.pr_3);
                cmd.Parameters.AddWithValue("@pr_4", compra.pr_4);
                cmd.Parameters.AddWithValue("@pr_m", compra.pr_m);
                cmd.Parameters.AddWithValue("@pr_ch", compra.pr_ch);
                cmd.Parameters.AddWithValue("@mont_tt", compra.mont_tt);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
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
            return inserta;
        }

        public Boolean ModificarCompra(EntCompra compra)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcompra", compra.idcompra);
                cmd.Parameters.AddWithValue("@proveedor", compra.proveedor);
                cmd.Parameters.AddWithValue("@fecha", compra.fecha);
                cmd.Parameters.AddWithValue("@cal_x", compra.cal_x);
                cmd.Parameters.AddWithValue("@cal_1", compra.cal_1);
                cmd.Parameters.AddWithValue("@cal_2", compra.cal_2);
                cmd.Parameters.AddWithValue("@cal_3", compra.cal_3);
                cmd.Parameters.AddWithValue("@cal_4", compra.cal_4);
                cmd.Parameters.AddWithValue("@cal_m", compra.cal_m);
                cmd.Parameters.AddWithValue("@cal_ch", compra.cal_ch);
                cmd.Parameters.AddWithValue("@pr_x", compra.pr_x);
                cmd.Parameters.AddWithValue("@pr_1", compra.pr_1);
                cmd.Parameters.AddWithValue("@pr_2", compra.pr_2);
                cmd.Parameters.AddWithValue("@pr_3", compra.pr_3);
                cmd.Parameters.AddWithValue("@pr_4", compra.pr_4);
                cmd.Parameters.AddWithValue("@pr_m", compra.pr_m);
                cmd.Parameters.AddWithValue("@pr_ch", compra.pr_ch);
                cmd.Parameters.AddWithValue("@mont_tt", compra.mont_tt);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean EliminarCompra(EntCompra compra)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idcompra", compra.idcompra);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
    }
}
