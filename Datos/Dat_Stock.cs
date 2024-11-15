using Endidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dat_Stock
    {
        #region singlenton
        private static readonly Dat_Stock _instancia = new Dat_Stock();
        public static Dat_Stock Instancia
        {
            get
            {
                return Dat_Stock._instancia;
            }
        }
        #endregion singlenton
        // listar stock
        public List <Ent_Stock> ListarStock()
        {
            SqlCommand cmd = null;
            List<Ent_Stock> lista = new List<Ent_Stock>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Ent_Stock Sto = new Ent_Stock();
                    Sto.idStock = Convert.ToInt32(dr["idStock"]);
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
            catch(Exception e)
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
        public Boolean InsertarStock(Ent_Stock Sto)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_stock", Sto.idStock);
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
        public Boolean ModificarStock(Ent_Stock Sto)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ModificarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_stock", Sto.idStock);
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
        public Boolean EliminarStock(Ent_Stock Sto)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_stock",Sto.idStock);
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
