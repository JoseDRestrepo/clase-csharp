using System;
using System.Data.SqlClient;
using System.Data;

namespace modelo
{
    internal class TipoConCRUD
    {
        //insertar 
        public static SqlCommand CrearComandoProc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("regisTipoCon", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }
        public static int EjecutarComandoInsert(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }


        // read (LIST)
        public static SqlCommand CrearComandoListar()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("listarTipoCon", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }


        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;
        }

        //update
        public static SqlCommand CrearProcAct()
        {
            string _cadenadeconexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenadeconexion);
            SqlCommand _comando = new SqlCommand("ActRegTipoC", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }


        public static int EjecutarcomandoUpdate(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }


        //eliminar 
        public static SqlCommand crearProcDelt()
        {
            string _cadenadeconexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenadeconexion);
            SqlCommand _comando = new SqlCommand("DeleteTipoCon", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        public static int EjecutarComandoDelete(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
