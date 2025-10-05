using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Configuracion
    {

        static string cadenaConexion = @"Data Source=DESKTOP-5QI7J0I\SQLEXPRESS;Initial Catalog=gestion_vehiculos;Integrated Security=True";
        public static string CadenaConexion {
        get { return cadenaConexion; }
        }
    }
}
