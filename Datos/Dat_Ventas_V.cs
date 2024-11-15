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
    public class Dat_Ventas_V
    {
        #region Singleton
        private static readonly Dat_Ventas_V _instancia = new Dat_Ventas_V();
        public static Dat_Ventas_V Instancia
        {
            get
            {
                return Dat_Ventas_V._instancia;
            }
        }
        #endregion Singleton

        // Listar ventas
        public List<Ent_ventas> ListarVentas()
        {
            SqlCommand cmd = null;
            List<Ent_ventas> lista = new List<Ent_ventas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ent_ventas venta = new Ent_ventas();
                    venta.idVenta = Convert.ToInt32(dr["id_venta"]);
                    venta.fecha = Convert.ToDateTime(dr["fecha"]);
                    venta.motivo = Convert.ToString(dr["motivo"]);
                    venta.cal_x = Convert.ToDecimal(dr["cal_x"]);
                    venta.cal_1 = Convert.ToDecimal(dr["cal_1"]);
                    venta.cal_2 = Convert.ToDecimal(dr["cal_2"]);
                    venta.cal_3 = Convert.ToDecimal(dr["cal_3"]);
                    venta.cal_4 = Convert.ToDecimal(dr["cal_4"]);
                    venta.cal_m = Convert.ToDecimal(dr["cal_m"]);
                    venta.cal_ch = Convert.ToDecimal(dr["cal_ch"]);
                    venta.pr_x = Convert.ToDecimal(dr["pr_x"]);
                    venta.pr_1 = Convert.ToDecimal(dr["pr_1"]);
                    venta.pr_2 = Convert.ToDecimal(dr["pr_2"]);
                    venta.pr_3 = Convert.ToDecimal(dr["pr_3"]);
                    venta.pr_4 = Convert.ToDecimal(dr["pr_4"]);
                    venta.pr_m = Convert.ToDecimal(dr["pr_m"]);
                    venta.pr_ch = Convert.ToDecimal(dr["pr_ch"]);
                    venta.mont_tt = Convert.ToDecimal(dr["mont_tt"]);

                    lista.Add(venta);
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

        // Insertar venta
        public Boolean InsertarVenta(Ent_ventas venta)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_venta", venta.idVenta);
                cmd.Parameters.AddWithValue("@fecha", venta.fecha);
                cmd.Parameters.AddWithValue("@motivo", venta.motivo);
                cmd.Parameters.AddWithValue("@cal_x", venta.cal_x);
                cmd.Parameters.AddWithValue("@cal_1", venta.cal_1);
                cmd.Parameters.AddWithValue("@cal_2", venta.cal_2);
                cmd.Parameters.AddWithValue("@cal_3", venta.cal_3);
                cmd.Parameters.AddWithValue("@cal_4", venta.cal_4);
                cmd.Parameters.AddWithValue("@cal_m", venta.cal_m);
                cmd.Parameters.AddWithValue("@cal_ch", venta.cal_ch);
                cmd.Parameters.AddWithValue("@pr_x", venta.pr_x);
                cmd.Parameters.AddWithValue("@pr_1", venta.pr_1);
                cmd.Parameters.AddWithValue("@pr_2", venta.pr_2);
                cmd.Parameters.AddWithValue("@pr_3", venta.pr_3);
                cmd.Parameters.AddWithValue("@pr_4", venta.pr_4);
                cmd.Parameters.AddWithValue("@pr_m", venta.pr_m);
                cmd.Parameters.AddWithValue("@pr_ch", venta.pr_ch);
                cmd.Parameters.AddWithValue("@mont_tt", venta.mont_tt);
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

        public Boolean ModificarVenta(Ent_ventas venta)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_venta", venta.idVenta);
                cmd.Parameters.AddWithValue("@fecha", venta.fecha);
                cmd.Parameters.AddWithValue("@motivo", venta.motivo);
                cmd.Parameters.AddWithValue("@cal_x", venta.cal_x);
                cmd.Parameters.AddWithValue("@cal_1", venta.cal_1);
                cmd.Parameters.AddWithValue("@cal_2", venta.cal_2);
                cmd.Parameters.AddWithValue("@cal_3", venta.cal_3);
                cmd.Parameters.AddWithValue("@cal_4", venta.cal_4);
                cmd.Parameters.AddWithValue("@cal_m", venta.cal_m);
                cmd.Parameters.AddWithValue("@cal_ch", venta.cal_ch);
                cmd.Parameters.AddWithValue("@pr_x", venta.pr_x);
                cmd.Parameters.AddWithValue("@pr_1", venta.pr_1);
                cmd.Parameters.AddWithValue("@pr_2", venta.pr_2);
                cmd.Parameters.AddWithValue("@pr_3", venta.pr_3);
                cmd.Parameters.AddWithValue("@pr_4", venta.pr_4);
                cmd.Parameters.AddWithValue("@pr_m", venta.pr_m);
                cmd.Parameters.AddWithValue("@pr_ch", venta.pr_ch);
                cmd.Parameters.AddWithValue("@mont_tt", venta.mont_tt);
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

        public Boolean EliminarVenta(Ent_ventas venta)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_venta", venta.idVenta);
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
