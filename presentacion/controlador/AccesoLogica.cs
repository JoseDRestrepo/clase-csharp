using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Data;
using modelo;

namespace controlador
{
    public class AccesoLogica
    {
        //llamada de metodos

        //insertar un vehiculo ya completo 
        public int InsertTipoVehi(int idtipo, string nombretipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertTipoVehi(idtipo, nombretipo);
        }

        public int InsertTipoCon(int idtipoCon, string nombretipo) 
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertTipoCon(idtipoCon, nombretipo);
        }

        public int InsertVehiculo(int idvehiculo, string marca, string modelo, string matricula, int annio, int idtipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertVehiculo(idvehiculo, marca, modelo, matricula, annio, idtipo);
        }

        public int InsertConductor(int idconductor, string nombre, int idVehiculo, int idTipoCon)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertConductor(idconductor, nombre, idVehiculo, idTipoCon);
        }

        public int InsertContrato(int idContrato, int idVehiculo, int idConductor)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertContratro(idContrato, idVehiculo, idConductor);
        }

        public int InsertRuta(int idRuta, string estacion, int idVehiculo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertRuta(idRuta, estacion, idVehiculo);
        }

        // listar los datos
        public static DataTable ObtenerTiposVehiculos()
        { 
            return AccesoDatos.obtenerTiposVehi();
        }

        public static DataTable ObtenerTiposConductor()
        {
            return AccesoDatos.obtenerTiposCon();
        }

        public static DataTable ObtenerVehiculos()
        {
            return AccesoDatos.obtenerVehiculos();
        }

        public static DataTable ObtenerConductores()
        {
            return AccesoDatos.obtenerConductores();
        }
        public static DataTable ObtenerRutas()
        {
            return AccesoDatos.obtenerRutas();
        }

        public static DataTable ObtenerContratos()
        {
            return AccesoDatos.obtenerContratos();
        }

        // actualizar datos 
        public int UpdateTipoVehi(int idtipo, string nombretipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.UpdateTipoVehi(idtipo, nombretipo);
        }

        public int UpdateTipoCon(int idtipo, string nombretipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.UpdateTipoCon(idtipo, nombretipo);
        }

        public int UpdateVehiculo(int idvehiculo, string marca, string modelo, string matricula, int annio, int idtipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.UpdateVehiculo(idvehiculo, marca, modelo, matricula, annio, idtipo);
        }

        public int UpdateConductor(int idconductor, string nombre, int idVehiculo, int idTipoCon)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.UpdateConductor(idconductor, nombre, idVehiculo, idTipoCon);
        }

        public int UpdateContrato(int idContrato, int idVehiculo, int idConductor)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.UpdateContrato(idContrato, idVehiculo, idConductor);
        }
        public int UpdateRuta(int idRuta, string estacion, int idVehiculo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.UpdateRuta(idRuta, estacion, idVehiculo);
        }

        //eliminar datos
        public int DeleteTipoVehi(int idTipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteTipoVehi(idTipo);
        }

        public int DeleteTipoCon(int idTipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteTipoCon(idTipo);
        }

        public int DeleteVehiculo(int idVehiculo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteVehiculo(idVehiculo);
        }

        public int DeleteConductor(int idConductor)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteConductor(idConductor);
        }
        public int DeleteContrato(int idContrato)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteContrato(idContrato);
        }
        public int DeleteRuta(int idRuta)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteRuta(idRuta);
        }
    }
}
