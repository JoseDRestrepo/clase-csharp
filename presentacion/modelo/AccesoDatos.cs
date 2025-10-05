using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo
{
    public class AccesoDatos
    {

        // insertar

        public int InsertTipoVehi(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoVehiCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@IdTipo", idtipo);
            _comando.Parameters.AddWithValue("@NombreTipo", nombretipo);
            return TipoVehiCRUD.EjecutarComandoInsert(_comando);
        }

        public int InsertTipoCon(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoConCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@IdTipoCon", idtipo);
            _comando.Parameters.AddWithValue("@NombreTipoCon", nombretipo);

            return TipoConCRUD.EjecutarComandoInsert(_comando);
        }

        public int InsertVehiculo(int idvehiculo, string marca, string modelo, string matricula, int annio, int idtipo)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("insertVehiculo");
            _comando.Parameters.AddWithValue("@IdVehi", idvehiculo);
            _comando.Parameters.AddWithValue("@Marca", marca);
            _comando.Parameters.AddWithValue("@Modelo", modelo);
            _comando.Parameters.AddWithValue("@Matricula", matricula);
            _comando.Parameters.AddWithValue("@Annio", annio);
            _comando.Parameters.AddWithValue("@IdTipo", idtipo);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int InsertConductor(int idconductor, string nombre, int idVehiculo, int idTipoCon)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("insertConductor");
            _comando.Parameters.AddWithValue("@IdConductor", idconductor);
            _comando.Parameters.AddWithValue("@Nombre", nombre);
            _comando.Parameters.AddWithValue("@IdVehi", idVehiculo);
            _comando.Parameters.AddWithValue("@IdTipoCon", idTipoCon);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int InsertRuta(int idRuta, string estacion, int idVehiculo)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("insertRuta");
            _comando.Parameters.AddWithValue("@IdRuta", idRuta);
            _comando.Parameters.AddWithValue("@Estacion", estacion);
            _comando.Parameters.AddWithValue("@IdVehi", idVehiculo);
            return OperacionesCRUD.EjecutarComandos(_comando);  
        }

        public int InsertContratro(int idContrato, int idVehiculo, int idConductor)
        {    
            SqlCommand _comando = OperacionesCRUD.CrearProc("insertContrato");
            _comando.Parameters.AddWithValue("@IdContrato", idContrato);
            _comando.Parameters.AddWithValue("@IdVehi", idVehiculo);
            _comando.Parameters.AddWithValue("@IdConductor", idConductor);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        // listar
        public static DataTable obtenerTiposVehi()
        {
            SqlCommand _comando = TipoVehiCRUD.CrearComandoListar();
            _comando.CommandText = "SELECT * FROM tipo_vehiculo order by IdTipo asc";
            return TipoVehiCRUD.EjecutarComandoSelect(_comando);
        }

        public static DataTable obtenerTiposCon() 
        {
            SqlCommand _comando = TipoConCRUD.CrearComandoListar();
            return TipoConCRUD.EjecutarComandoSelect(_comando);
        }

        public static DataTable obtenerVehiculos()
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("listarVehiculo");
            return OperacionesCRUD.EjecutarComandoListar(_comando);
        }

        public static DataTable obtenerConductores()
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("listarConductor");
            return OperacionesCRUD.EjecutarComandoListar(_comando);
        }

        public static DataTable obtenerRutas()
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("listarRuta");
            return OperacionesCRUD.EjecutarComandoListar(_comando);
        }

        public static DataTable obtenerContratos()
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("listarContrato");
            return OperacionesCRUD.EjecutarComandoListar(_comando);
        }

        // update
        public int UpdateTipoVehi(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoVehiCRUD.CrearProcAct();
            _comando.Parameters.AddWithValue("IdTipo", idtipo);
            _comando.Parameters.AddWithValue("@NombreTipo", nombretipo);

            return TipoVehiCRUD.EjecutarcomandoUpdate(_comando);
        }

        public int UpdateTipoCon(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoConCRUD.CrearProcAct();
            _comando.Parameters.AddWithValue("IdTipoCon", idtipo);
            _comando.Parameters.AddWithValue("@NombreTipoCon", nombretipo);

            return TipoConCRUD.EjecutarcomandoUpdate(_comando);
        }

        public int UpdateVehiculo(int idvehiculo, string marca, string modelo, string matricula, int annio, int idtipo)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("actVehiculo");
            _comando.Parameters.AddWithValue("IdVehi", idvehiculo);
            _comando.Parameters.AddWithValue("@Marca", marca);
            _comando.Parameters.AddWithValue("@Modelo", modelo);
            _comando.Parameters.AddWithValue("@Matricula", matricula);
            _comando.Parameters.AddWithValue("@Annio", annio);
            _comando.Parameters.AddWithValue("@IdTipo", idtipo);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int UpdateConductor(int idconductor, string nombre, int idVehiculo, int idTipoCon)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("actConductor");
            _comando.Parameters.AddWithValue("IdConductor", idconductor);
            _comando.Parameters.AddWithValue("@Nombre", nombre);
            _comando.Parameters.AddWithValue("@IdVehi", idVehiculo);
            _comando.Parameters.AddWithValue("@IdTipoCon", idTipoCon);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int UpdateRuta(int idRuta, string estacion, int idVehiculo)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("actRuta");
            _comando.Parameters.AddWithValue("IdRuta", idRuta);
            _comando.Parameters.AddWithValue("@Estacion", estacion);
            _comando.Parameters.AddWithValue("@IdVehi", idVehiculo);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int UpdateContrato(int idContrato, int idVehiculo, int idConductor)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("actContrato");
            _comando.Parameters.AddWithValue("IdContrato", idContrato);
            _comando.Parameters.AddWithValue("@IdVehi", idVehiculo);
            _comando.Parameters.AddWithValue("@IdConductor", idConductor);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        //eliminar
        public int deleteTipoVehi(int idTipo)
        {
            SqlCommand _comando = TipoVehiCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("IdTipo", idTipo);

            return TipoVehiCRUD.EjecutarComandoDelete(_comando);
        }

        public int deleteTipoCon(int idTipo)
        {
            SqlCommand _comando = TipoConCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("IdTipoCon", idTipo);

            return TipoConCRUD.EjecutarComandoDelete(_comando);
        }

        public int deleteVehiculo(int idVehiculo)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("deleteVehiculo");
            _comando.Parameters.AddWithValue("IdVehi", idVehiculo);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int deleteConductor(int idConductor)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("deltConductor");
            _comando.Parameters.AddWithValue("IdConductor", idConductor);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int deleteRuta(int idRuta)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("deltRuta");
            _comando.Parameters.AddWithValue("IdRuta", idRuta);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }

        public int deleteContrato(int idContrato)
        {
            SqlCommand _comando = OperacionesCRUD.CrearProc("deltContrato");
            _comando.Parameters.AddWithValue("IdContrato", idContrato);
            return OperacionesCRUD.EjecutarComandos(_comando);
        }
    }
}
