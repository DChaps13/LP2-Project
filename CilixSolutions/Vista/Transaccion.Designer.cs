namespace Vista
{
    partial class Transaccion
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.dgvUsuariosFilt = new System.Windows.Forms.DataGridView();
            this.dgvContactosFilt = new System.Windows.Forms.DataGridView();
            this.dgvProductosFilt = new System.Windows.Forms.DataGridView();
            this.btAgregarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuitarUsuario = new System.Windows.Forms.Button();
            this.btQuitarContacto = new System.Windows.Forms.Button();
            this.btBuscaUsuario = new System.Windows.Forms.Button();
            this.btBuscaContacto = new System.Windows.Forms.Button();
            this.btAgregarContacto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btQuitarProducto = new System.Windows.Forms.Button();
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.btBuscaProd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosFilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosFilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFilt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(708, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva Transacción";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Nueva Transacción";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(744, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 523);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBoxBuscarUsuario
            // 
            this.groupBoxBuscarUsuario.Controls.Add(this.dgvUsuariosFilt);
            this.groupBoxBuscarUsuario.Controls.Add(this.dgvContactosFilt);
            this.groupBoxBuscarUsuario.Controls.Add(this.dgvProductosFilt);
            this.groupBoxBuscarUsuario.Controls.Add(this.btAgregarUsuario);
            this.groupBoxBuscarUsuario.Controls.Add(this.label1);
            this.groupBoxBuscarUsuario.Controls.Add(this.btQuitarUsuario);
            this.groupBoxBuscarUsuario.Controls.Add(this.btQuitarContacto);
            this.groupBoxBuscarUsuario.Controls.Add(this.btBuscaUsuario);
            this.groupBoxBuscarUsuario.Controls.Add(this.btBuscaContacto);
            this.groupBoxBuscarUsuario.Controls.Add(this.btAgregarContacto);
            this.groupBoxBuscarUsuario.Controls.Add(this.label3);
            this.groupBoxBuscarUsuario.Controls.Add(this.button2);
            this.groupBoxBuscarUsuario.Controls.Add(this.button1);
            this.groupBoxBuscarUsuario.Controls.Add(this.btQuitarProducto);
            this.groupBoxBuscarUsuario.Controls.Add(this.btAgregarProducto);
            this.groupBoxBuscarUsuario.Controls.Add(this.btBuscaProd);
            this.groupBoxBuscarUsuario.Controls.Add(this.label2);
            this.groupBoxBuscarUsuario.Controls.Add(this.label5);
            this.groupBoxBuscarUsuario.Controls.Add(this.label4);
            this.groupBoxBuscarUsuario.Location = new System.Drawing.Point(11, 92);
            this.groupBoxBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBuscarUsuario.Name = "groupBoxBuscarUsuario";
            this.groupBoxBuscarUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBuscarUsuario.Size = new System.Drawing.Size(710, 453);
            this.groupBoxBuscarUsuario.TabIndex = 9;
            this.groupBoxBuscarUsuario.TabStop = false;
            this.groupBoxBuscarUsuario.Text = "Historial de Transacciones";
            // 
            // dgvUsuariosFilt
            // 
            this.dgvUsuariosFilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosFilt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FechaCreacion,
            this.Rol});
            this.dgvUsuariosFilt.Location = new System.Drawing.Point(109, 287);
            this.dgvUsuariosFilt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuariosFilt.Name = "dgvUsuariosFilt";
            this.dgvUsuariosFilt.RowTemplate.Height = 24;
            this.dgvUsuariosFilt.Size = new System.Drawing.Size(481, 92);
            this.dgvUsuariosFilt.TabIndex = 18;
            // 
            // dgvContactosFilt
            // 
            this.dgvContactosFilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactosFilt.Location = new System.Drawing.Point(109, 160);
            this.dgvContactosFilt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvContactosFilt.Name = "dgvContactosFilt";
            this.dgvContactosFilt.RowTemplate.Height = 24;
            this.dgvContactosFilt.Size = new System.Drawing.Size(481, 92);
            this.dgvContactosFilt.TabIndex = 18;
            // 
            // dgvProductosFilt
            // 
            this.dgvProductosFilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosFilt.Location = new System.Drawing.Point(109, 34);
            this.dgvProductosFilt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductosFilt.Name = "dgvProductosFilt";
            this.dgvProductosFilt.RowTemplate.Height = 24;
            this.dgvProductosFilt.Size = new System.Drawing.Size(481, 95);
            this.dgvProductosFilt.TabIndex = 18;
            // 
            // btAgregarUsuario
            // 
            this.btAgregarUsuario.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarUsuario.ForeColor = System.Drawing.Color.ForestGreen;
            this.btAgregarUsuario.Location = new System.Drawing.Point(639, 284);
            this.btAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregarUsuario.Name = "btAgregarUsuario";
            this.btAgregarUsuario.Size = new System.Drawing.Size(37, 25);
            this.btAgregarUsuario.TabIndex = 17;
            this.btAgregarUsuario.Text = "+";
            this.btAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacto";
            // 
            // btQuitarUsuario
            // 
            this.btQuitarUsuario.Location = new System.Drawing.Point(598, 313);
            this.btQuitarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuitarUsuario.Name = "btQuitarUsuario";
            this.btQuitarUsuario.Size = new System.Drawing.Size(79, 25);
            this.btQuitarUsuario.TabIndex = 17;
            this.btQuitarUsuario.Text = "eliminar";
            this.btQuitarUsuario.UseVisualStyleBackColor = true;
            // 
            // btQuitarContacto
            // 
            this.btQuitarContacto.Location = new System.Drawing.Point(598, 185);
            this.btQuitarContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuitarContacto.Name = "btQuitarContacto";
            this.btQuitarContacto.Size = new System.Drawing.Size(79, 25);
            this.btQuitarContacto.TabIndex = 7;
            this.btQuitarContacto.Text = "eliminar";
            this.btQuitarContacto.UseVisualStyleBackColor = true;
            // 
            // btBuscaUsuario
            // 
            this.btBuscaUsuario.Location = new System.Drawing.Point(598, 284);
            this.btBuscaUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscaUsuario.Name = "btBuscaUsuario";
            this.btBuscaUsuario.Size = new System.Drawing.Size(37, 25);
            this.btBuscaUsuario.TabIndex = 17;
            this.btBuscaUsuario.Text = "...";
            this.btBuscaUsuario.UseVisualStyleBackColor = true;
            this.btBuscaUsuario.Click += new System.EventHandler(this.btBuscaUsuario_Click);
            // 
            // btBuscaContacto
            // 
            this.btBuscaContacto.Location = new System.Drawing.Point(598, 156);
            this.btBuscaContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscaContacto.Name = "btBuscaContacto";
            this.btBuscaContacto.Size = new System.Drawing.Size(37, 25);
            this.btBuscaContacto.TabIndex = 7;
            this.btBuscaContacto.Text = "...";
            this.btBuscaContacto.UseVisualStyleBackColor = true;
            this.btBuscaContacto.Click += new System.EventHandler(this.btBuscaContacto_Click);
            // 
            // btAgregarContacto
            // 
            this.btAgregarContacto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarContacto.ForeColor = System.Drawing.Color.ForestGreen;
            this.btAgregarContacto.Location = new System.Drawing.Point(639, 156);
            this.btAgregarContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregarContacto.Name = "btAgregarContacto";
            this.btAgregarContacto.Size = new System.Drawing.Size(37, 25);
            this.btAgregarContacto.TabIndex = 7;
            this.btAgregarContacto.Text = "+";
            this.btAgregarContacto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Usuario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ver Todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btQuitarProducto
            // 
            this.btQuitarProducto.Location = new System.Drawing.Point(598, 63);
            this.btQuitarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuitarProducto.Name = "btQuitarProducto";
            this.btQuitarProducto.Size = new System.Drawing.Size(79, 25);
            this.btQuitarProducto.TabIndex = 12;
            this.btQuitarProducto.Text = "eliminar";
            this.btQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarProducto.ForeColor = System.Drawing.Color.ForestGreen;
            this.btAgregarProducto.Location = new System.Drawing.Point(639, 34);
            this.btAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(37, 25);
            this.btAgregarProducto.TabIndex = 12;
            this.btAgregarProducto.Text = "+";
            this.btAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btBuscaProd
            // 
            this.btBuscaProd.Location = new System.Drawing.Point(598, 34);
            this.btBuscaProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscaProd.Name = "btBuscaProd";
            this.btBuscaProd.Size = new System.Drawing.Size(37, 25);
            this.btBuscaProd.TabIndex = 12;
            this.btBuscaProd.Text = "...";
            this.btBuscaProd.UseVisualStyleBackColor = true;
            this.btBuscaProd.Click += new System.EventHandler(this.btBuscaProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "and";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "and";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "fechaCreacion";
            this.FechaCreacion.HeaderText = "Fecha de Creacion";
            this.FechaCreacion.Name = "FechaCreacion";
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "getRol";
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxBuscarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transaccion";
            this.Text = "Transaccion";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBuscarUsuario.ResumeLayout(false);
            this.groupBoxBuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosFilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactosFilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFilt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxBuscarUsuario;
        private System.Windows.Forms.Button btBuscaContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscaProd;
        private System.Windows.Forms.DataGridView dgvContactosFilt;
        private System.Windows.Forms.Button btBuscaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsuariosFilt;
        private System.Windows.Forms.DataGridView dgvProductosFilt;
        private System.Windows.Forms.Button btAgregarUsuario;
        private System.Windows.Forms.Button btAgregarContacto;
        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btQuitarUsuario;
        private System.Windows.Forms.Button btQuitarContacto;
        private System.Windows.Forms.Button btQuitarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}