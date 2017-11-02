using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private string id;
        private string nombre;
        private int cantidad;
        private double precio;
        private string estado;
        private CategoriaProd categoria;
        private DateTime fecha_Ult_modificacion;
        private DateTime fecha_Lanzamiento;
        private int stock_minimo;
        private PersonaJuridica proveedor;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime Fecha_Ult_modificacion { get => fecha_Ult_modificacion; set => fecha_Ult_modificacion = value; }
        public DateTime Fecha_Lanzamiento { get => fecha_Lanzamiento; set => fecha_Lanzamiento = value; }
        public int Stock_minimo { get => stock_minimo; set => stock_minimo = value; }
        public string Id { get => id; set => id = value; }
        public PersonaJuridica Proveedor { get => proveedor; set => proveedor = value; }
        public CategoriaProd Categoria { get => categoria; set => categoria = value; }

        public void actualizarStock(Transaccion t)
        {

        }
    }
}
