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
    public class DatVenta
    {

        //conexion
        private static readonly DatVenta _instacia = new DatVenta();
        public static DatVenta Instancia
        {
            get
            {
                return DatVenta._instacia;
            }
        }

        //buscar  ventas
        public EntVenta BuscarVenta(int compra)
        {
            SqlCommand cmd = null;
            EntVenta venta = new EntVenta();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", compra);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    venta.idventa =Convert.ToInt32(dr["idventa"]);
                    venta.fecha = Convert.ToDateTime(dr["fecha"]);
                    venta.motivo = dr["motivo"].ToString();
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
                    venta.idstock = Convert.ToInt32(dr["idstock"]);
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
            return venta;
        }


        // Listar ventas
        public List<EntVenta> ListarVentas()
        {
            SqlCommand cmd = null;
            List<EntVenta> lista = new List<EntVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntVenta venta = new EntVenta();
                    venta.idventa = Convert.ToInt32(dr["idventa"]);
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
        public Boolean InsertarVenta(EntVenta venta)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.Parameters.AddWithValue("@idstock", venta.idstock);
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

        public Boolean ModificarVenta(EntVenta venta)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", venta.idventa);
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

        public Boolean EliminarVenta(EntVenta venta)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarVentas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idventa", venta.idventa);
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
