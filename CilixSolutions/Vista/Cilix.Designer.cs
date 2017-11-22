namespace Vista
{
    partial class Cilix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cilix));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BCerrar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BLogout = new System.Windows.Forms.Button();
            this.BLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelNuevo = new System.Windows.Forms.Panel();
            this.BNuevoTrans = new System.Windows.Forms.Button();
            this.BNuevoJuridico = new System.Windows.Forms.Button();
            this.BNuevoNatural = new System.Windows.Forms.Button();
            this.BNuevoProducto = new System.Windows.Forms.Button();
            this.BNuevoUsuario = new System.Windows.Forms.Button();
            this.PanelBuscar = new System.Windows.Forms.Panel();
            this.BBuscarTrans = new System.Windows.Forms.Button();
            this.BBuscarJuridico = new System.Windows.Forms.Button();
            this.BBuscarNatural = new System.Windows.Forms.Button();
            this.BBuscarProducto = new System.Windows.Forms.Button();
            this.BBuscarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelNuevo.SuspendLayout();
            this.PanelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BCerrar);
            this.panel1.Controls.Add(this.BBuscar);
            this.panel1.Controls.Add(this.BNuevo);
            this.panel1.Controls.Add(this.BLogout);
            this.panel1.Controls.Add(this.BLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 479);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrar.ForeColor = System.Drawing.Color.White;
            this.BCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BCerrar.Image")));
            this.BCerrar.Location = new System.Drawing.Point(0, 406);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(158, 67);
            this.BCerrar.TabIndex = 4;
            this.BCerrar.Text = "Cerrar   ";
            this.BCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BBuscar.Image")));
            this.BBuscar.Location = new System.Drawing.Point(0, 333);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(158, 67);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.Text = "Buscar    ";
            this.BBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // BNuevo
            // 
            this.BNuevo.FlatAppearance.BorderSize = 0;
            this.BNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevo.ForeColor = System.Drawing.Color.White;
            this.BNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BNuevo.Image")));
            this.BNuevo.Location = new System.Drawing.Point(0, 260);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(158, 67);
            this.BNuevo.TabIndex = 4;
            this.BNuevo.Text = "Nuevo   ";
            this.BNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BNuevo.UseVisualStyleBackColor = true;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // BLogout
            // 
            this.BLogout.FlatAppearance.BorderSize = 0;
            this.BLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogout.ForeColor = System.Drawing.Color.White;
            this.BLogout.Image = ((System.Drawing.Image)(resources.GetObject("BLogout.Image")));
            this.BLogout.Location = new System.Drawing.Point(3, 114);
            this.BLogout.Name = "BLogout";
            this.BLogout.Size = new System.Drawing.Size(158, 67);
            this.BLogout.TabIndex = 4;
            this.BLogout.Text = "Log out";
            this.BLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLogout.UseVisualStyleBackColor = true;
            this.BLogout.Click += new System.EventHandler(this.BLogout_Click);
            // 
            // BLogin
            // 
            this.BLogin.FlatAppearance.BorderSize = 0;
            this.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.ForeColor = System.Drawing.Color.White;
            this.BLogin.Image = ((System.Drawing.Image)(resources.GetObject("BLogin.Image")));
            this.BLogin.Location = new System.Drawing.Point(0, 114);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(158, 67);
            this.BLogin.TabIndex = 3;
            this.BLogin.Text = "Log in       ";
            this.BLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 72);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cilix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelNuevo
            // 
            this.PanelNuevo.Controls.Add(this.BNuevoTrans);
            this.PanelNuevo.Controls.Add(this.BNuevoJuridico);
            this.PanelNuevo.Controls.Add(this.BNuevoNatural);
            this.PanelNuevo.Controls.Add(this.BNuevoProducto);
            this.PanelNuevo.Controls.Add(this.BNuevoUsuario);
            this.PanelNuevo.Location = new System.Drawing.Point(161, 248);
            this.PanelNuevo.Name = "PanelNuevo";
            this.PanelNuevo.Size = new System.Drawing.Size(597, 131);
            this.PanelNuevo.TabIndex = 1;
            this.PanelNuevo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BNuevoTrans
            // 
            this.BNuevoTrans.FlatAppearance.BorderSize = 0;
            this.BNuevoTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoTrans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoTrans.ForeColor = System.Drawing.Color.White;
            this.BNuevoTrans.Image = ((System.Drawing.Image)(resources.GetObject("BNuevoTrans.Image")));
            this.BNuevoTrans.Location = new System.Drawing.Point(439, 0);
            this.BNuevoTrans.Name = "BNuevoTrans";
            this.BNuevoTrans.Size = new System.Drawing.Size(113, 131);
            this.BNuevoTrans.TabIndex = 9;
            this.BNuevoTrans.Text = "Transacción";
            this.BNuevoTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BNuevoTrans.UseVisualStyleBackColor = true;
            this.BNuevoTrans.Click += new System.EventHandler(this.BNuevoTrans_Click);
            // 
            // BNuevoJuridico
            // 
            this.BNuevoJuridico.FlatAppearance.BorderSize = 0;
            this.BNuevoJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoJuridico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoJuridico.ForeColor = System.Drawing.Color.White;
            this.BNuevoJuridico.Image = ((System.Drawing.Image)(resources.GetObject("BNuevoJuridico.Image")));
            this.BNuevoJuridico.Location = new System.Drawing.Point(329, 5);
            this.BNuevoJuridico.Name = "BNuevoJuridico";
            this.BNuevoJuridico.Size = new System.Drawing.Size(113, 131);
            this.BNuevoJuridico.TabIndex = 8;
            this.BNuevoJuridico.Text = "Cliente jurídico";
            this.BNuevoJuridico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BNuevoJuridico.UseVisualStyleBackColor = true;
            this.BNuevoJuridico.Click += new System.EventHandler(this.BNuevoJuridico_Click);
            // 
            // BNuevoNatural
            // 
            this.BNuevoNatural.FlatAppearance.BorderSize = 0;
            this.BNuevoNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoNatural.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoNatural.ForeColor = System.Drawing.Color.White;
            this.BNuevoNatural.Image = ((System.Drawing.Image)(resources.GetObject("BNuevoNatural.Image")));
            this.BNuevoNatural.Location = new System.Drawing.Point(219, 5);
            this.BNuevoNatural.Name = "BNuevoNatural";
            this.BNuevoNatural.Size = new System.Drawing.Size(113, 131);
            this.BNuevoNatural.TabIndex = 7;
            this.BNuevoNatural.Text = "Cliente Natual";
            this.BNuevoNatural.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BNuevoNatural.UseVisualStyleBackColor = true;
            this.BNuevoNatural.Click += new System.EventHandler(this.BNuevoNatural_Click);
            // 
            // BNuevoProducto
            // 
            this.BNuevoProducto.FlatAppearance.BorderSize = 0;
            this.BNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.BNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("BNuevoProducto.Image")));
            this.BNuevoProducto.Location = new System.Drawing.Point(109, 0);
            this.BNuevoProducto.Name = "BNuevoProducto";
            this.BNuevoProducto.Size = new System.Drawing.Size(113, 131);
            this.BNuevoProducto.TabIndex = 6;
            this.BNuevoProducto.Text = "Producto";
            this.BNuevoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BNuevoProducto.UseVisualStyleBackColor = true;
            this.BNuevoProducto.Click += new System.EventHandler(this.BNuevoProducto_Click);
            // 
            // BNuevoUsuario
            // 
            this.BNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.BNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNuevoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.BNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BNuevoUsuario.Image")));
            this.BNuevoUsuario.Location = new System.Drawing.Point(0, 0);
            this.BNuevoUsuario.Name = "BNuevoUsuario";
            this.BNuevoUsuario.Size = new System.Drawing.Size(113, 131);
            this.BNuevoUsuario.TabIndex = 5;
            this.BNuevoUsuario.Text = "Usuario";
            this.BNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BNuevoUsuario.UseVisualStyleBackColor = true;
            this.BNuevoUsuario.Click += new System.EventHandler(this.BNuevoUsuario_Click);
            // 
            // PanelBuscar
            // 
            this.PanelBuscar.Controls.Add(this.BBuscarTrans);
            this.PanelBuscar.Controls.Add(this.BBuscarJuridico);
            this.PanelBuscar.Controls.Add(this.BBuscarNatural);
            this.PanelBuscar.Controls.Add(this.BBuscarProducto);
            this.PanelBuscar.Controls.Add(this.BBuscarUsuario);
            this.PanelBuscar.Location = new System.Drawing.Point(164, 321);
            this.PanelBuscar.Name = "PanelBuscar";
            this.PanelBuscar.Size = new System.Drawing.Size(597, 116);
            this.PanelBuscar.TabIndex = 2;
            // 
            // BBuscarTrans
            // 
            this.BBuscarTrans.FlatAppearance.BorderSize = 0;
            this.BBuscarTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarTrans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarTrans.ForeColor = System.Drawing.Color.White;
            this.BBuscarTrans.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarTrans.Image")));
            this.BBuscarTrans.Location = new System.Drawing.Point(439, 0);
            this.BBuscarTrans.Name = "BBuscarTrans";
            this.BBuscarTrans.Size = new System.Drawing.Size(113, 131);
            this.BBuscarTrans.TabIndex = 9;
            this.BBuscarTrans.Text = "Transacción";
            this.BBuscarTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BBuscarTrans.UseVisualStyleBackColor = true;
            this.BBuscarTrans.Click += new System.EventHandler(this.BBuscarTrans_Click);
            // 
            // BBuscarJuridico
            // 
            this.BBuscarJuridico.FlatAppearance.BorderSize = 0;
            this.BBuscarJuridico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarJuridico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarJuridico.ForeColor = System.Drawing.Color.White;
            this.BBuscarJuridico.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarJuridico.Image")));
            this.BBuscarJuridico.Location = new System.Drawing.Point(329, 5);
            this.BBuscarJuridico.Name = "BBuscarJuridico";
            this.BBuscarJuridico.Size = new System.Drawing.Size(113, 131);
            this.BBuscarJuridico.TabIndex = 8;
            this.BBuscarJuridico.Text = "Cliente jurídico";
            this.BBuscarJuridico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BBuscarJuridico.UseVisualStyleBackColor = true;
            this.BBuscarJuridico.Click += new System.EventHandler(this.BBuscarJuridico_Click);
            // 
            // BBuscarNatural
            // 
            this.BBuscarNatural.FlatAppearance.BorderSize = 0;
            this.BBuscarNatural.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarNatural.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarNatural.ForeColor = System.Drawing.Color.White;
            this.BBuscarNatural.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarNatural.Image")));
            this.BBuscarNatural.Location = new System.Drawing.Point(219, 5);
            this.BBuscarNatural.Name = "BBuscarNatural";
            this.BBuscarNatural.Size = new System.Drawing.Size(113, 131);
            this.BBuscarNatural.TabIndex = 7;
            this.BBuscarNatural.Text = "Cliente Natual";
            this.BBuscarNatural.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BBuscarNatural.UseVisualStyleBackColor = true;
            this.BBuscarNatural.Click += new System.EventHandler(this.BBuscarNatural_Click);
            // 
            // BBuscarProducto
            // 
            this.BBuscarProducto.FlatAppearance.BorderSize = 0;
            this.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.BBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarProducto.Image")));
            this.BBuscarProducto.Location = new System.Drawing.Point(109, 0);
            this.BBuscarProducto.Name = "BBuscarProducto";
            this.BBuscarProducto.Size = new System.Drawing.Size(113, 131);
            this.BBuscarProducto.TabIndex = 6;
            this.BBuscarProducto.Text = "Producto";
            this.BBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BBuscarProducto.UseVisualStyleBackColor = true;
            this.BBuscarProducto.Click += new System.EventHandler(this.BBuscarProducto_Click);
            // 
            // BBuscarUsuario
            // 
            this.BBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.BBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.BBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BBuscarUsuario.Image")));
            this.BBuscarUsuario.Location = new System.Drawing.Point(0, 0);
            this.BBuscarUsuario.Name = "BBuscarUsuario";
            this.BBuscarUsuario.Size = new System.Drawing.Size(113, 131);
            this.BBuscarUsuario.TabIndex = 5;
            this.BBuscarUsuario.Text = "Usuario";
            this.BBuscarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BBuscarUsuario.UseVisualStyleBackColor = true;
            this.BBuscarUsuario.Click += new System.EventHandler(this.BBuscarUsuario_Click);
            // 
            // Cilix
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(755, 479);
            this.Controls.Add(this.PanelBuscar);
            this.Controls.Add(this.PanelNuevo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cilix";
            this.Text = "Z";
            this.Load += new System.EventHandler(this.Cilix_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelNuevo.ResumeLayout(false);
            this.PanelBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelNuevo;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Button BLogout;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BNuevoTrans;
        private System.Windows.Forms.Button BNuevoJuridico;
        private System.Windows.Forms.Button BNuevoNatural;
        private System.Windows.Forms.Button BNuevoProducto;
        private System.Windows.Forms.Button BNuevoUsuario;
        private System.Windows.Forms.Panel PanelBuscar;
        private System.Windows.Forms.Button BBuscarTrans;
        private System.Windows.Forms.Button BBuscarJuridico;
        private System.Windows.Forms.Button BBuscarNatural;
        private System.Windows.Forms.Button BBuscarProducto;
        private System.Windows.Forms.Button BBuscarUsuario;
    }
}