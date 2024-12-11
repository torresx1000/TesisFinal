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
    public class DatPagoCompra
    {
        private static readonly DatPagoCompra _instacia = new DatPagoCompra();
        public static DatPagoCompra Instancia
        {
            get
            {
                return DatPagoCompra._instacia;
            }
        }

        
        
                // Listar pagos de compra todos
                public List<EntPagoCompra> ListarPagosCompra()
                {
                    SqlCommand cmd = null;
                    List<EntPagoCompra> lista = new List<EntPagoCompra>();
                    try
                    {
                        SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                        cmd = new SqlCommand("ListarPagosCompra", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            EntPagoCompra pago = new    EntPagoCompra();        
                            pago.idpagocompra = Convert.ToInt32(dr["idpago"]);  
                            pago.proveedor = dr["proveedor"].ToString(); 
                            pago.fecha = Convert.ToDateTime(dr["fecha"]);       
                            pago.tipopago = dr["tipopago"].ToString();   
                            pago.estado = Convert.ToChar(dr["estado"]);
                            pago.monto = Convert.ToInt64(dr["monto"]);
                            pago.idcompra = Convert.ToInt32(dr["idcompra"]);
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
                
        // Listar pagos de compras sin procesar
        public List<EntPagoCompra> ListarPagosCompraPendientes()
        {
            SqlCommand cmd = null;
            List<EntPagoCompra> lista = new List<EntPagoCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("ListarPagosCompraPendientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPagoCompra pago1 = new EntPagoCompra();
                    pago1.idpagocompra = Convert.ToInt32(dr["idpago"]);
                    pago1.proveedor = dr["proveedor"].ToString();
                    pago1.fecha = Convert.ToDateTime(dr["fecha"]);
                    pago1.tipopago = dr["tipopago"].ToString();
                    pago1.estado = Convert.ToChar(dr["estado"]);
                    pago1.monto = Convert.ToDecimal(dr["monto"]);
                    lista.Add(pago1);
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
        

        //buscar por pagos compra por id
        public EntPagoCompra BuscarPagoCompraId(int codigo)
        {
            SqlCommand cmd = null;
            EntPagoCompra Sto = new EntPagoCompra();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BuscarPagosCompraId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpago", codigo);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Sto.idpagocompra = Convert.ToInt32(dr["idpago"]);
                    Sto.proveedor = dr["proveedor"].ToString();
                    Sto.fecha = Convert.ToDateTime(dr["fecha"]);
                    Sto.tipopago = dr["tipopago"].ToString();
                    Sto.estado = Convert.ToChar(dr["estado"]);
                    Sto.monto = Convert.ToDecimal(dr["monto"]);
                    Sto.idcompra = Convert.ToInt32(dr["idcompra"]);
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
            return Sto;
        }

        


        // insertar pago compra
        public Boolean InsertarPagoCompra(EntPagoCompra pago)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarPagosCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proveedor", pago.proveedor);
                cmd.Parameters.AddWithValue("@fecha", pago.fecha);
                cmd.Parameters.AddWithValue("@tipopago", pago.tipopago);
                cmd.Parameters.AddWithValue("@estado", pago.estado);
                cmd.Parameters.AddWithValue("@monto", pago.monto);
                cmd.Parameters.AddWithValue("@idcompra", pago.idcompra);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { 
                    inserta = true;
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
            return inserta;
        }

//procesar pago compra
        public Boolean ProcesarPagoCompra(EntPagoCompra pago)
        {
            SqlCommand cmd = null;
            Boolean actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ProcesarPagosCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpago", pago.idpagocompra);
                cmd.Parameters.AddWithValue("@tipopago", pago.tipopago);
                cmd.Parameters.AddWithValue("@estado", pago.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) {
                    actualiza = true;
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
            return actualiza;
        }
        //eliminar pago compra
        public Boolean EliminarPagoCompra(EntPagoCompra pago)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EliminarPagosCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpago", pago.idpagocompra);
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
