using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class NuevoProducto : Form
    {
        ProductoBL logNegProd;
        PerJuridicaBL logNegPJ;
        CategoriaBL logNegCat;
        public NuevoProducto()
        {
            InitializeComponent();
            logNegProd = new ProductoBL();
            logNegCat = new CategoriaBL();

            logNegPJ = new PerJuridicaBL();
            BindingList<PersonaJuridica> listaPJ = new BindingList<PersonaJuridica>();
            BindingList<CategoriaProd> listaCat = new BindingList<CategoriaProd>();
            //listaCat = logNegCat.listaCategorias();
            listaPJ = logNegPJ.listarProveedores();


            cbxProv.ValueMember = "RazonSocial";
            foreach (PersonaJuridica l in listaPJ)
            {
                cbxProv.Items.Add(l);
            }

            //cbxCat.ValueMember = "Nombre";
            //foreach(CategoriaProd c in listaCat)
            //{
            //    cbxCat.Items.Add(c);
            //}
            cbxCat.Items.Add("Electronicos");
            cbxCat.Items.Add("Software");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearProd_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Nombre = txtNombreProd.Text; //id
            if (cbxProv.SelectedItem == null) //Proveedor
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            p.Proveedor = (PersonaJuridica)cbxProv.SelectedItem;


            if (cbxCat.SelectedItem == null) //Categoria
            {
                MessageBox.Show("Debe seleccionar una categoria", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //p.Categoria = (CategoriaProd)cbxCat.SelectedItem;
            CategoriaProd cat = new CategoriaProd();
            cat.Nombre = cbxCat.SelectedItem.ToString();
            p.Cantidad = Int32.Parse(txtStock.Text);
            p.Precio = float.Parse(txtPrecio.Text);
            p.Categoria = cat;

            try
            {
                logNegProd.registrarProducto(cbxProv.Text, p);
                MessageBox.Show("El registro del producto fue exitoso", "Mensaje de éxito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el producto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
