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
        //PerJuridicaBL logNegPJ;
        //CategoriaBL logNegCat;
        public NuevoProducto()
        {
            InitializeComponent();
            logNegProd = new ProductoBL();
            //logNegCat = new CategoriaBL();

            //logNegPJ = new PerJuridicaBL();
            BindingList<PersonaJuridica> listaPJ = new BindingList<PersonaJuridica>();
            BindingList<CategoriaProd> listaCat = new BindingList<CategoriaProd>();
            //listaCat = logNegCat.listaCategorias();
           // listaPJ = logNegPJ.listaPJs();


            comboBox1.ValueMember = "RazonSocial";
            foreach (PersonaJuridica l in listaPJ)
            {
                comboBox1.Items.Add(l);
            }

            comboBox2.ValueMember = "Nombre";
            foreach(CategoriaProd c in listaCat)
            {
                comboBox2.Items.Add(c);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearProd_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Nombre = textBox1.Text; //id
            if (comboBox1.SelectedItem == null) //Proveedor
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            p.Proveedor = (PersonaJuridica)comboBox1.SelectedItem;


            if (comboBox2.SelectedItem == null) //Categoria
            {
                MessageBox.Show("Debe seleccionar una categoria", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            p.Categoria = (CategoriaProd)comboBox2.SelectedItem;

            logNegProd.registrarProducto(p);



            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
