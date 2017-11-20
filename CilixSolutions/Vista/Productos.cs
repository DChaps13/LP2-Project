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

        public Producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }

        public Productos()
        {
            InitializeComponent();

            logNegProd = new ProductoBL();
            PerJuridicaBL logNegPerJur = new PerJuridicaBL();
            CategoriaBL logNegCategoria = new CategoriaBL();
            PerJuridicaBL logNegProv = new PerJuridicaBL();

            //Categorias ComboBox
            BindingList<CategoriaProd> listCat = new BindingList<CategoriaProd>();
            listCat = logNegCategoria.listaCategorias();

            cbxCategoria.ValueMember = "Nombre";
            cbxCategoria.Items.Add("Todas");
            foreach (CategoriaProd r in listCat)
            {
                cbxCategoria.Items.Add(r);
            }


            //Proveedores ComboBox
            BindingList<PersonaJuridica> listaProv = new BindingList<PersonaJuridica>();
            listaProv = logNegProv.listarProveedores();

            cbxProv.ValueMember = "RazonSocial";
            cbxProv.Items.Add("Todos");
            foreach (PersonaJuridica p in listaProv)
            {
                cbxProv.Items.Add(p);
            }


            productos = new BindingList<Producto>();

            dataProductos.AutoGenerateColumns = false;
            dataProductos.Refresh();
            dataProductos.AllowUserToAddRows = false;
            //dataProductos.DataSource = productos;
        }

        private void buscarProd_Click(object sender, EventArgs e)
        {
            if (txtNombreProd.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del producto o 'Todos'", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxCategoria.Text == "")
            {
                MessageBox.Show("Seleccione una categorìa o 'Todas'", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxProv.Text == "")
            {
                MessageBox.Show("Seleccione un proveedor o 'Todos'", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            productos = logNegProd.listaProductos(txtNombreProd.Text,cbxCategoria.Text,cbxProv.Text);

            dataProductos.DataSource = productos;

            //dataProductos.DataSource = productosSel;
        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto frmNuevoProducto = new NuevoProducto();
            if (frmNuevoProducto.ShowDialog() == DialogResult.OK)
            {
                //productos = logNegProd.listaProductos();
                dataProductos.DataSource = productos;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ProductoSeleccionado = (Producto)dataProductos.CurrentRow.DataBoundItem;
            this.Close();
        }
    }
}


