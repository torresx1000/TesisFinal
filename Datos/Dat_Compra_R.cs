using Endidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dat_Compra_R
    {
        #region Singleton
        private static readonly Dat_Compra_R _instancia = new Dat_Compra_R();
        public static Dat_Compra_R Instancia
        {
            get
            {
                return Dat_Compra_R._instancia;
            }
        }
        #endregion Singleton

        // Listar compras
        public List<Ent_compra_r> ListarCompras()
        {
            SqlCommand cmd = null;
            List<Ent_compra_r> lista = new List<Ent_compra_r>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarCompras", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ent_compra_r compra = new Ent_compra_r();
                    compra.idCompra = Convert.ToInt32(dr["idCompra"]);
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
        public Boolean InsertarCompra(Ent_compra_r compra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCompra", compra.idCompra);
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

        public Boolean ModificarCompra(Ent_compra_r compra)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_compra", compra.idCompra);
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
        public Boolean EliminarCompra(Ent_compra_r compra)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_compra", compra.idCompra);
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
