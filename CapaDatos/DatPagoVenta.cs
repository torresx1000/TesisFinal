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
    public class DatPagoVenta
    {
        private static readonly DatPagoVenta _instacia = new DatPagoVenta();
        public static DatPagoVenta Instancia
        {
            get
            {
                return DatPagoVenta._instacia;
            }
        }

        // Listar pagos de venta
        public List<EntPagoVenta> ListarPagosVenta()
        {
            SqlCommand cmd = null;
            List<EntPagoVenta> lista = new List<EntPagoVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarPagosVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPagoVenta pago = new EntPagoVenta();
                    pago.idpagoventa = Convert.ToInt32(dr["idpago"]);
                    pago.descripcion = dr["motivo"].ToString();
                    pago.fecha = Convert.ToDateTime(dr["fecha"]);
                    pago.tipopago = dr["tipopago"].ToString();
                    pago.estado = Convert.ToChar(dr["estado"]);
                    pago.monto = Convert.ToInt64(dr["monto"]);
                    pago.idventa = Convert.ToInt32(dr["idventa"]);


                    lista.Add(pago);
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

        //ListarPagoVentasPendientes
        public List<EntPagoVenta> ListarPagoVentasPendientes()
        {
            SqlCommand cmd = null;
            List<EntPagoVenta> lista = new List<EntPagoVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarPagoVentasPendientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPagoVenta pago = new EntPagoVenta();
                    pago.idpagoventa = Convert.ToInt32(dr["idpago"]);
                    pago.descripcion = dr["motivo"].ToString();
                    pago.fecha = Convert.ToDateTime(dr["fecha"]);
                    pago.tipopago = dr["tipopago"].ToString();
                    pago.estado = Convert.ToChar(dr["estado"]);
                    pago.monto = Convert.ToInt64(dr["monto"]);
                    pago.idventa = Convert.ToInt32(dr["idventa"]);


                    lista.Add(pago);
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


        //buscar por pagos venta id
        public EntPagoVenta BuscarPagoVentaId(int codigo)
        {
            SqlCommand cmd = null;
            EntPagoVenta Sto = new EntPagoVenta();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarPagosVentaId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpago", codigo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Sto.idpagoventa = Convert.ToInt32(dr["idpago"]);
                    Sto.descripcion = dr["motivo"].ToString();
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    Sto.tipopago = dr["tipopago"].ToString();
                    Sto.estado = Convert.ToChar(dr["estado"]);
                    Sto.monto = Convert.ToDecimal(dr["monto"]);
                    Sto.idventa = Convert.ToInt32(dr["idventa"]);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cmd.Connection.Close(); }
            return Sto;
        }

       
        // insert pago venta 

        public Boolean InsertarPagoVenta(EntPagoVenta pago)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarPagosVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@motivo", pago.descripcion);
                cmd.Parameters.AddWithValue("@fecha", pago.fecha);
                cmd.Parameters.AddWithValue("@tipopago", pago.tipopago);
                cmd.Parameters.AddWithValue("@estado", pago.estado);
                cmd.Parameters.AddWithValue("@monto", pago.monto);
                cmd.Parameters.AddWithValue("@idventa", pago.idventa);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        
        // actuaizar pago venta
        public Boolean ProcesarPagoVentaId(EntPagoVenta pago)
        {
            SqlCommand cmd = null;
            Boolean actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ProcesarPagoVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpago", pago.idpagoventa);
                cmd.Parameters.AddWithValue("@tipopago", pago.tipopago);
                cmd.Parameters.AddWithValue("@estado", pago.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) actualiza = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return actualiza;
        }
        //eliminar pago venta
        public Boolean EliminarPagoVenta(EntPagoVenta pago)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarPagosVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpago", pago.idpagoventa);
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

