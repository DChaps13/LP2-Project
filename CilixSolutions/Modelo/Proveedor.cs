using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        int _integer;
        string _razon_social;
        string _ruc;
        string _telefono;
        string _correo;
        BindingList<Producto> lstProductos;

        public Proveedor(int integer, string razon_social, string ruc, string telefono, string correo, BindingList<Producto> lstProductos)
        {
            _integer = integer;
            _razon_social = razon_social;
            _ruc = ruc;
            _telefono = telefono;
            _correo = correo;
            this.lstProductos = lstProductos;
        }

        public int Integer { get => _integer; set => _integer = value; }
        public string Razon_social { get => _razon_social; set => _razon_social = value; }
        public string Ruc { get => _ruc; set => _ruc = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public BindingList<Producto> LstProductos { get => lstProductos; set => lstProductos = value; }
    }
}
