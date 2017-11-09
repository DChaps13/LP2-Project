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
        private Estado estado;
        private RolUsuario rol;

        public Usuario()
        {
            rol = new RolUsuario();
        }

        public Usuario(string id, string contraseña, DateTime fechaCreacion, DateTime fechaModificacion, Estado estado, RolUsuario rol)
        {
            this.id = id;
            this.contraseña = contraseña;
            this.fechaCreacion = fechaCreacion;
            this.fechaModificacion = fechaModificacion;
            this.estado = estado;
            this.rol = rol;
        }

        public string Id { get => id; set => id = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public DateTime FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public RolUsuario Rol { get => rol; set => rol = value; }
    }
}
