using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;


namespace Vista
{
    public partial class Productos : Form
    {
        BindingList<Producto> productos;
        ProductoBL logNegProd;
        Producto productoSeleccionado;
        public Productos()
        {
            InitializeComponent();

            logNegProd = new ProductoBL();
            productos = logNegProd.listaProductos();
            dataProductos.AutoGenerateColumns = false;
            dataProductos.DataSource = productos;
        }

        private void buscarProd_Click(object sender, EventArgs e)
        {
            BindingList<Producto> productosSel = new BindingList<Producto>();
            BindingList<Producto> productosAux = new BindingList<Producto>();

            if (textBox1.Text != "Todos") //Id del producto
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    if (productos[i].Id == textBox1.Text)
                    {
                        productosSel.Add(productos[i]);
                    }
                }

            }
            else
            {
                productosSel = productos;
            }

            productosAux = productosSel;
            if (textBox2.Text != "Todos") // Nombre del producto
            {
                for (int i = 0; i < productosSel.Count; i++)
                {
                    if (productosSel[i].Nombre != textBox2.Text)
                    {
                        productosAux.Remove(productosSel[i]);
                    }
                }
            }

            productosSel = productosAux;
            if (comboBox1.Text != "Todos") //Categoria del producto
            {
                for (int i = 0; i < productosSel.Count; i++)
                {
                    if (productosSel[i].Categoria.Nombre != comboBox1.Text)
                    {
                        productosAux.Remove(productosSel[i]);
                    }
                }
            }

            productosSel = productosAux;
            if (comboBox2.Text != "Todos") //Proveedor del producto
            {
                for (int i = 0; i < productosSel.Count; i++)
                {
                    if (productosSel[i].Proveedor.RazonSocial != comboBox2.Text)
                    {
                        productosAux.Remove(productosSel[i]);
                    }
                }
            }

            productosSel = productosAux;

            dataProductos.DataSource = productosSel;
        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto frmNuevoProducto = new NuevoProducto();
            if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
            {
                productos = logNegProd.listaProductos();
                dataProductos.DataSource = productos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productoSeleccionado = (Producto)dataProductos.CurrentRow.DataBoundItem;
            this.Close();
        }
    }
}
