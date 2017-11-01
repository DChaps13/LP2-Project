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
        public Productos()
        {
            InitializeComponent();

            logNegProd = new ProductoBL();
            productos = logNegProd.listaProductos();
            dataProductos.AutoGenerateColumns = false;
            dataProductos.DataSource = logNegProd.listaProductos();
        }

        private void buscarProd_Click(object sender, EventArgs e)
        {
            BindingList<Producto> productosSel = new BindingList<Producto>();
            BindingList<Usuario> usuariosAux = new BindingList<Usuario>();

            if (textBox1.Text != "Todos")
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].Id == textBox1.Text)
                    {
                        usuariosSel.Add(usuarios[i]);
                    }
                }

            }
            else
            {
                usuariosSel = usuarios;
            }

            usuariosAux = usuariosSel;
            if (comboBox1.Text != "Todos") // Rol del usuario
            {
                for (int i = 0; i < usuariosSel.Count; i++)
                {
                    if (usuariosSel[i].Rol.ToString() != comboBox1.Text)
                    {
                        usuariosAux.Remove(usuariosSel[i]);
                    }
                }
            }

            usuariosSel = usuariosAux;
            if (comboBox2.Text != "Todos") //Estado del usuario
            {
                for (int i = 0; i < usuariosSel.Count; i++)
                {
                    if (usuariosSel[i].Estado != comboBox2.Text)
                    {
                        usuariosAux.Remove(usuariosSel[i]);
                    }
                }
            }

            usuariosSel = usuariosAux;

            dataUsuarios.DataSource = usuariosSel;
        }
    }
}
