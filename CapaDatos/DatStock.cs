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
    public class DatStock
    {

        private static readonly DatStock _instacia = new DatStock();
        public static DatStock Instancia
        {
            get
            {
                return DatStock._instacia;
            }
        }
        //buscar en stock
        public EntStock BuscarStock ( int codigo)
        {
            SqlCommand cmd = null;
            EntStock Sto = new EntStock();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idstock", codigo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Sto.idStock = Convert.ToInt32(dr["idstock"]);
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    Sto.st_x = Convert.ToDecimal(dr["st_x"]);
                    Sto.st_1 = Convert.ToDecimal(dr["st_1"]);
                    Sto.st_2 = Convert.ToDecimal(dr["st_2"]);
                    Sto.st_3 = Convert.ToDecimal(dr["st_3"]);
                    Sto.st_4 = Convert.ToDecimal(dr["st_4"]);
                    Sto.st_m = Convert.ToDecimal(dr["st_m"]);
                    Sto.st_ch = Convert.ToDecimal(dr["st_ch"]);
                    Sto.idcompra = Convert.ToInt32(dr["idcompra"]);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return Sto;
        }
        //buscar por fecha
        public EntStock BuscarStockPorFecha(DateTime fecha)
        {
            SqlCommand cmd = null;
            EntStock Sto = new EntStock();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarStockPorFecha", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Sto.idStock = Convert.ToInt32(dr["idstock"]);
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    Sto.st_x = Convert.ToDecimal(dr["st_x"]);
                    Sto.st_1 = Convert.ToDecimal(dr["st_1"]);
                    Sto.st_2 = Convert.ToDecimal(dr["st_2"]);
                    Sto.st_3 = Convert.ToDecimal(dr["st_3"]);
                    Sto.st_4 = Convert.ToDecimal(dr["st_4"]);
                    Sto.st_m = Convert.ToDecimal(dr["st_m"]);
                    Sto.st_ch = Convert.ToDecimal(dr["st_ch"]);
                    Sto.idcompra = Convert.ToInt32(dr["idcompra"]);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return Sto;
        }
        // listar stock

        public List<EntStock> ListarStockFecha()
        {
            SqlCommand cmd = null;
            List<EntStock> lista = new List<EntStock>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarStockFecha", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntStock Sto = new EntStock();
                    Sto.idStock = Convert.ToInt32(dr["idstock"]);
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    lista.Add(Sto);
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
        public List<EntStock> ListarStock()
        {
            SqlCommand cmd = null;
            List<EntStock> lista = new List<EntStock>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarStockConDatos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntStock Sto = new EntStock();
                    Sto.idStock = Convert.ToInt32(dr["idstock"]);
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    Sto.st_x = Convert.ToDecimal(dr["st_x"]);
                    Sto.st_1 = Convert.ToDecimal(dr["st_1"]);
                    Sto.st_2 = Convert.ToDecimal(dr["st_2"]);
                    Sto.st_3 = Convert.ToDecimal(dr["st_3"]);
                    Sto.st_4 = Convert.ToDecimal(dr["st_4"]);
                    Sto.st_m = Convert.ToDecimal(dr["st_m"]);
                    Sto.st_ch = Convert.ToDecimal(dr["st_ch"]);


                    lista.Add(Sto);
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
        //lista stock 2 ultimos
        public List<EntStock> ListarUltimosDosStock()
        {
            SqlCommand cmd = null;
            List<EntStock> lista = new List<EntStock>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarUltimosDosStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntStock Sto = new EntStock();
                    Sto.idStock = Convert.ToInt32(dr["codigo"]);
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    Sto.st_x = Convert.ToDecimal(dr["extra"]);
                    Sto.st_1 = Convert.ToDecimal(dr["primera"]);
                    Sto.st_2 = Convert.ToDecimal(dr["segunda"]);
                    Sto.st_3 = Convert.ToDecimal(dr["tercera"]);
                    Sto.st_4 = Convert.ToDecimal(dr["cuarta"]);
                    Sto.st_m = Convert.ToDecimal(dr["manchada"]);
                    Sto.st_ch = Convert.ToDecimal(dr["chica"]);
                    Sto.idcompra = Convert.ToInt32(dr["cod compra"]);


                    lista.Add(Sto);
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

        //insertar stock
        public Boolean InsertarStock(EntStock Sto)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", Sto.fecha);
                cmd.Parameters.AddWithValue("@st_x", Sto.st_x);
                cmd.Parameters.AddWithValue("@st_1", Sto.st_1);
                cmd.Parameters.AddWithValue("@st_2", Sto.st_2);
                cmd.Parameters.AddWithValue("@st_3", Sto.st_3);
                cmd.Parameters.AddWithValue("@st_4", Sto.st_4);
                cmd.Parameters.AddWithValue("@st_m", Sto.st_m);
                cmd.Parameters.AddWithValue("@st_ch", Sto.st_ch);
                cmd.Parameters.AddWithValue("@idcompra", Sto.idcompra);
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
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //modificar cliente
        public Boolean ModificarStock(EntStock Sto)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idstock", Sto.idStock);
                cmd.Parameters.AddWithValue("@fecha", Sto.fecha);
                cmd.Parameters.AddWithValue("@st_x", Sto.st_x);
                cmd.Parameters.AddWithValue("@st_1", Sto.st_1);
                cmd.Parameters.AddWithValue("@st_2", Sto.st_2);
                cmd.Parameters.AddWithValue("@st_3", Sto.st_3);
                cmd.Parameters.AddWithValue("@st_4", Sto.st_4);
                cmd.Parameters.AddWithValue("@st_m", Sto.st_m);
                cmd.Parameters.AddWithValue("@st_ch", Sto.st_ch);
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

        //eliminar stock
        public Boolean EliminarStock(EntStock Sto)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idstock", Sto.idStock);
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
