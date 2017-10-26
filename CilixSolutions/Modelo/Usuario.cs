using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private string id;
        private string contraseña;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string estado;
        private RolUsuario rol;

        public string Id { get => id; set => id = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
        public string Estado { get => estado; set => estado = value; }
        internal RolUsuario Rol { get => rol; set => rol = value; }
    }
}
