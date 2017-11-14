using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ConexionBD
    {
        private string cadenaConexion;

        public ConexionBD()
        {

            //string conexion = "Data Source=localhost;Initial Catalog=inf282g4;Persist Security Info=True;User ID=inf282g4;Password=LnyBcOhGWyvFVtBp";
            string conexion = "Persist Security Info = False; User ID = inf282g4; Password = LnyBcOhGWyvFVtBp; Initial Catalog = inf282g4; Server = 200.16.7.140";
            this.cadenaConexion = conexion;
        }

        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
    }
}
