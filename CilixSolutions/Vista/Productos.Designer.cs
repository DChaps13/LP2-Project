namespace Vista
{
    partial class Productos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuevoProducto = new System.Windows.Forms.Button();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.cbxProv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscarProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.groupBoxBuscarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuevoProducto);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 73);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Producto";
            // 
            // nuevoProducto
            // 
            this.nuevoProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoProducto.ForeColor = System.Drawing.Color.Black;
            this.nuevoProducto.Location = new System.Drawing.Point(181, 26);
            this.nuevoProducto.Name = "nuevoProducto";
            this.nuevoProducto.Size = new System.Drawing.Size(170, 29);
            this.nuevoProducto.TabIndex = 10;
            this.nuevoProducto.Text = "Nuevo Producto";
            this.nuevoProducto.UseVisualStyleBackColor = true;
            this.nuevoProducto.Click += new System.EventHandler(this.nuevoProducto_Click);
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToAddRows = false;
            this.dataProductos.AllowUserToDeleteRows = false;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Estado});
            this.dataProductos.Location = new System.Drawing.Point(12, 352);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            this.dataProductos.Size = new System.Drawing.Size(518, 171);
            this.dataProductos.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // groupBoxBuscarUsuario
            // 
            this.groupBoxBuscarUsuario.Controls.Add(this.cbxProv);
            this.groupBoxBuscarUsuario.Controls.Add(this.label4);
            this.groupBoxBuscarUsuario.Controls.Add(this.cbxCategoria);
            this.groupBoxBuscarUsuario.Controls.Add(this.txtNombreProd);
            this.groupBoxBuscarUsuario.Controls.Add(this.label3);
            this.groupBoxBuscarUsuario.Controls.Add(this.buscarProd);
            this.groupBoxBuscarUsuario.Controls.Add(this.label2);
            this.groupBoxBuscarUsuario.Controls.Add(this.textBox1);
            this.groupBoxBuscarUsuario.Controls.Add(this.label1);
            this.groupBoxBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.groupBoxBuscarUsuario.Location = new System.Drawing.Point(11, 91);
            this.groupBoxBuscarUsuario.Name = "groupBoxBuscarUsuario";
            this.groupBoxBuscarUsuario.Size = new System.Drawing.Size(519, 221);
            this.groupBoxBuscarUsuario.TabIndex = 6;
            this.groupBoxBuscarUsuario.TabStop = false;
            this.groupBoxBuscarUsuario.Text = "Buscar Producto";
            // 
            // cbxProv
            // 
            this.cbxProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProv.FormattingEnabled = true;
            this.cbxProv.Location = new System.Drawing.Point(139, 159);
            this.cbxProv.Name = "cbxProv";
            this.cbxProv.Size = new System.Drawing.Size(226, 28);
            this.cbxProv.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Proveedor";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(140, 121);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(225, 28);
            this.cbxCategoria.TabIndex = 11;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(139, 84);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(226, 27);
            this.txtNombreProd.TabIndex = 10;
            this.txtNombreProd.Text = "Todos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoría";
            // 
            // buscarProd
            // 
            this.buscarProd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProd.ForeColor = System.Drawing.Color.Black;
            this.buscarProd.Location = new System.Drawing.Point(405, 44);
            this.buscarProd.Name = "buscarProd";
            this.buscarProd.Size = new System.Drawing.Size(75, 30);
            this.buscarProd.TabIndex = 7;
            this.buscarProd.Text = "Buscar";
            this.buscarProd.UseVisualStyleBackColor = true;
            this.buscarProd.Click += new System.EventHandler(this.buscarProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Producto";
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(226, 547);
            this.btOK.Margin = new System.Windows.Forms.Padding(2);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 30);
            this.btOK.TabIndex = 14;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Visible = false;
            this.btOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(580, 610);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.groupBoxBuscarUsuario);
            this.Name = "Productos";
            this.Text = "Productos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.groupBoxBuscarUsuario.ResumeLayout(false);
            this.groupBoxBuscarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button nuevoProducto;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.GroupBox groupBoxBuscarUsuario;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscarProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}