using System;
using System.Data.SqlClient;
using System.Data;

namespace modelo
{
    internal class TipoVehiCRUD
    {

        //insertar vehiculo 
        public static SqlCommand CrearComandoProc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("regisTipoVehi", _conexion);
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
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand(); 
            _comando.CommandType= CommandType.Text;
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
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                comando.Connection.Close();
            }return _tabla;
        }




        // crear metodo desde visual y no desde la base de datos 

        //update
        public static SqlCommand CrearProcAct()
        {
            string _cadenadeconexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenadeconexion);
            SqlCommand _comando = new SqlCommand("ActReg", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;

        }


        public static int EjecutarcomandoUpdate(SqlCommand comando) {
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


        //delete 
         public static SqlCommand crearProcDelt()
        {
            string _cadenadeconexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenadeconexion);
            SqlCommand _comando = new SqlCommand("DeleteTipoVehi", _conexion);
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



        // CONDUCTORES


    }
}
