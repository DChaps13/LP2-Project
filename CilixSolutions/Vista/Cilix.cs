using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Cilix : Form
    {
        private Usuario usuarioActual;
        public Cilix(Usuario usu)
        {
            this.IsMdiContainer = true;
            this.usuarioActual = usu;
            InitializeComponent();

            this.Visible = true;
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label2.Text = "Hola, " + usuarioActual.Id + " (" + usuarioActual.Rol.Descriptor + ")";
            label2.Visible = true;

            BLogin.Visible = false;
            BLogin.Enabled = false;
            BLogout.Visible = true;
            BLogout.Enabled = true;
            BNuevo.Visible = true;
            BNuevo.Enabled = true;
            BBuscar.Visible = true;
            BBuscar.Enabled = true;
            BCerrar.Visible = true;
            BCerrar.Enabled = true;
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;





            switch (usuarioActual.Rol.Privilegio)
            {
                case (1): //Administrador
                    BLogin.Visible = true;
                    BLogin.Enabled = false;
                    BLogout.Visible = true;
                    BLogout.Enabled = true;
                    BNuevo.Visible = true;
                    BNuevo.Enabled = true;
                    BBuscar.Visible = true;
                    BBuscar.Enabled = true;
                    BCerrar.Visible = true;
                    BCerrar.Enabled = true;


                    break;
                case (2): //Registrador
                          //Nuevo 





                    break;
                case (3): //Trabajador
                          //Nuevo






                    break;
            }
        }
        public Cilix()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            this.Visible = true;
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label2.Text = " ";
            label2.Visible = true;


            BLogin.Visible = true;
            BLogin.Enabled = true;
            BLogout.Visible = true;
            BLogout.Enabled = false;
            BNuevo.Visible = false;
            BNuevo.Enabled = false;
            BBuscar.Visible = false;
            BBuscar.Enabled = false;
            BCerrar.Visible = true;
            BCerrar.Enabled = true;
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled= false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cilix_Load(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            Logueo childForm = new Logueo();
            usuarioActual = childForm.UsuarioActivo;
            childForm.Visible = true;
            this.Visible = false;

        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BLogout_Click(object sender, EventArgs e)
        {
            Cilix cilix = new Cilix();
            cilix.Visible = true;
            this.Close();

        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            PanelNuevo.Visible = true;
            PanelNuevo.Enabled = true;
            switch (usuarioActual.Rol.Privilegio)
            {
                case (1): //Administrador

                    //Nuevo
                    BNuevoTrans.Enabled = true;
                    BNuevoUsuario.Enabled = true;
                    BNuevoNatural.Enabled = true;
                    BNuevoJuridico.Enabled = true;
                    BNuevoProducto.Enabled = true;
                    //Buscar
                    BBuscarTrans.Enabled = true;
                    BBuscarUsuario.Enabled = true;
                    BBuscarNatural.Enabled = true; //natural
                    BBuscarJuridico.Enabled = true; //juridico
                    BBuscarProducto.Enabled = true;

                    break;
                case (2): //Registrador
                          //Nuevo
                    BNuevoTrans.Enabled = true;
                    BNuevoUsuario.Enabled = false;
                    BNuevoNatural.Enabled = true;
                    BNuevoJuridico.Enabled = true;
                    BNuevoProducto.Enabled = true;
                    //Buscar
                    BBuscarTrans.Enabled = true;
                    BBuscarUsuario.Enabled = true;
                    BBuscarNatural.Enabled = true; //natural
                    BBuscarJuridico.Enabled = true; //juridico
                    BBuscarProducto.Enabled = true;
                    break;
                case (3): //Trabajador
                          //Nuevo
                    BNuevoTrans.Enabled = true;
                    BNuevoUsuario.Enabled = false;
                    BNuevoNatural.Enabled = true;
                    BNuevoJuridico.Enabled = true;
                    BNuevoProducto.Enabled = false;
                    //Buscar
                    BBuscarTrans.Enabled = true;
                    BBuscarUsuario.Enabled = true;
                    BBuscarNatural.Enabled = true; //natural
                    BBuscarJuridico.Enabled = true; //juridico
                    BBuscarProducto.Enabled = true;
                    break;
            }
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;


        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            PanelBuscar.Visible = true;
            PanelBuscar.Enabled = true;
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
        }

        private void BNuevoUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario childForm = new NuevoUsuario();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Usuario";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BBuscarUsuario_Click(object sender, EventArgs e)
        {
            Usuarios childForm = new Usuarios();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Usuarios";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BNuevoProducto_Click(object sender, EventArgs e)
        {
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
            

            NuevoProducto childForm = new NuevoProducto();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Producto";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled= false;
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            Productos childForm = new Productos();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Productos";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BNuevoNatural_Click(object sender, EventArgs e)
        {
            NuevoCliente childForm = new NuevoCliente();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Cliente";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BBuscarNatural_Click(object sender, EventArgs e)
        {
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BNuevoJuridico_Click(object sender, EventArgs e)
        {
            NuevoProveedor childForm = new NuevoProveedor();
            childForm.MdiParent = this;
            childForm.Text = "Nuevo Proveedor";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BBuscarJuridico_Click(object sender, EventArgs e)
        {
            Proveedores childForm = new Proveedores();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Proveedores";
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BNuevoTrans_Click(object sender, EventArgs e)
        {
            NuevaTransaccion childForm = new NuevaTransaccion();
            childForm.MdiParent = this;
            childForm.Text = "Nueva Transaccion";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }

        private void BBuscarTrans_Click(object sender, EventArgs e)
        {
            Transaccion childForm = new Transaccion();
            childForm.MdiParent = this;
            childForm.Text = "Buscar Transaccion";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
            PanelNuevo.Visible = false;
            PanelNuevo.Enabled = false;
            PanelBuscar.Visible = false;
            PanelBuscar.Enabled = false;
        }
    }
}
