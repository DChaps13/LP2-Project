using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Transaccion
    {
        private Contacto destino;
        private Usuario usuario;
        private TipoTransaccion tipo;
        private int cantidad;
        private string descripcion;
        private DateTime fecha;

        public TipoTransaccion Tipo { get => tipo; set => tipo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal Contacto Destino { get => destino; set => destino = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
