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
            string conexion = "Data Source=localhost;Initial Catalog=inf282g4;Persist Security Info=True;User ID=inf282g4;Password=LnyBcOhGWyvFVtBp";
            this.cadenaConexion = conexion;
        }

        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
    }
}
