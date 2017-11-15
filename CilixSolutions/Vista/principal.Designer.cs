namespace Vista
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurídicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transacciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.juridicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jurídicoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logueoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbLoggedUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.logueoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transacciónToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productoToolStripMenuItem1});
            this.transaccionesToolStripMenuItem.Enabled = false;
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.transaccionesToolStripMenuItem.Text = "Nuevo";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // transacciónToolStripMenuItem
            // 
            this.transacciónToolStripMenuItem.Enabled = false;
            this.transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            this.transacciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transacciónToolStripMenuItem.Text = "Transacción...";
            this.transacciónToolStripMenuItem.Click += new System.EventHandler(this.transacciónToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Enabled = false;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario...";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naturalToolStripMenuItem,
            this.jurídicoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // naturalToolStripMenuItem
            // 
            this.naturalToolStripMenuItem.Enabled = false;
            this.naturalToolStripMenuItem.Name = "naturalToolStripMenuItem";
            this.naturalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.naturalToolStripMenuItem.Text = "Natural...";
            this.naturalToolStripMenuItem.Click += new System.EventHandler(this.naturalToolStripMenuItem_Click);
            // 
            // jurídicoToolStripMenuItem
            // 
            this.jurídicoToolStripMenuItem.Enabled = false;
            this.jurídicoToolStripMenuItem.Name = "jurídicoToolStripMenuItem";
            this.jurídicoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.jurídicoToolStripMenuItem.Text = "Jurídico...";
            this.jurídicoToolStripMenuItem.Click += new System.EventHandler(this.jurídicoToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem1
            // 
            this.productoToolStripMenuItem1.Enabled = false;
            this.productoToolStripMenuItem1.Name = "productoToolStripMenuItem1";
            this.productoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem1.Text = "Producto";
            this.productoToolStripMenuItem1.Click += new System.EventHandler(this.productoToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transacciónToolStripMenuItem1,
            this.usuarioToolStripMenuItem1,
            this.clientesToolStripMenuItem1,
            this.productoToolStripMenuItem});
            this.buscarToolStripMenuItem.Enabled = false;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // transacciónToolStripMenuItem1
            // 
            this.transacciónToolStripMenuItem1.Enabled = false;
            this.transacciónToolStripMenuItem1.Name = "transacciónToolStripMenuItem1";
            this.transacciónToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.transacciónToolStripMenuItem1.Text = "Transacción...";
            this.transacciónToolStripMenuItem1.Click += new System.EventHandler(this.transacciónToolStripMenuItem1_Click);
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Enabled = false;
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuario...";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juridicoToolStripMenuItem1,
            this.jurídicoToolStripMenuItem2});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // juridicoToolStripMenuItem1
            // 
            this.juridicoToolStripMenuItem1.Enabled = false;
            this.juridicoToolStripMenuItem1.Name = "juridicoToolStripMenuItem1";
            this.juridicoToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.juridicoToolStripMenuItem1.Text = "Natural...";
            // 
            // jurídicoToolStripMenuItem2
            // 
            this.jurídicoToolStripMenuItem2.Enabled = false;
            this.jurídicoToolStripMenuItem2.Name = "jurídicoToolStripMenuItem2";
            this.jurídicoToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.jurídicoToolStripMenuItem2.Text = "Jurídico...";
            this.jurídicoToolStripMenuItem2.Click += new System.EventHandler(this.jurídicoToolStripMenuItem2_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Enabled = false;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // logueoToolStripMenuItem
            // 
            this.logueoToolStripMenuItem.Name = "logueoToolStripMenuItem";
            this.logueoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.logueoToolStripMenuItem.Text = "Logueo...";
            this.logueoToolStripMenuItem.Click += new System.EventHandler(this.logueoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.logOutToolStripMenuItem.Text = "Log Out...";
            this.logOutToolStripMenuItem.Visible = false;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lbLoggedUser
            // 
            this.lbLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoggedUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLoggedUser.Location = new System.Drawing.Point(530, 0);
            this.lbLoggedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoggedUser.Name = "lbLoggedUser";
            this.lbLoggedUser.Size = new System.Drawing.Size(287, 23);
            this.lbLoggedUser.TabIndex = 2;
            this.lbLoggedUser.Text = "Usuario";
            this.lbLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 568);
            this.Controls.Add(this.lbLoggedUser);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "principal";
            this.Text = "principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurídicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transacciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem juridicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jurídicoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logueoToolStripMenuItem;
        private System.Windows.Forms.Label lbLoggedUser;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}