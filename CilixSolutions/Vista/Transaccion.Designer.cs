﻿namespace Vista
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 58);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva Transacción";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(184, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Nueva Transacción";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 425);
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
            this.groupBoxBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.groupBoxBuscarUsuario.Location = new System.Drawing.Point(8, 75);
            this.groupBoxBuscarUsuario.Name = "groupBoxBuscarUsuario";
            this.groupBoxBuscarUsuario.Size = new System.Drawing.Size(532, 368);
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
            this.dgvUsuariosFilt.Location = new System.Drawing.Point(82, 233);
            this.dgvUsuariosFilt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuariosFilt.Name = "dgvUsuariosFilt";
            this.dgvUsuariosFilt.RowTemplate.Height = 24;
            this.dgvUsuariosFilt.Size = new System.Drawing.Size(361, 75);
            this.dgvUsuariosFilt.TabIndex = 18;
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
            // dgvContactosFilt
            // 
            this.dgvContactosFilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactosFilt.Location = new System.Drawing.Point(82, 130);
            this.dgvContactosFilt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvContactosFilt.Name = "dgvContactosFilt";
            this.dgvContactosFilt.RowTemplate.Height = 24;
            this.dgvContactosFilt.Size = new System.Drawing.Size(361, 75);
            this.dgvContactosFilt.TabIndex = 18;
            // 
            // dgvProductosFilt
            // 
            this.dgvProductosFilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosFilt.Location = new System.Drawing.Point(82, 28);
            this.dgvProductosFilt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProductosFilt.Name = "dgvProductosFilt";
            this.dgvProductosFilt.RowTemplate.Height = 24;
            this.dgvProductosFilt.Size = new System.Drawing.Size(361, 77);
            this.dgvProductosFilt.TabIndex = 18;
            // 
            // btAgregarUsuario
            // 
            this.btAgregarUsuario.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btAgregarUsuario.Location = new System.Drawing.Point(479, 231);
            this.btAgregarUsuario.Name = "btAgregarUsuario";
            this.btAgregarUsuario.Size = new System.Drawing.Size(28, 20);
            this.btAgregarUsuario.TabIndex = 17;
            this.btAgregarUsuario.Text = "+";
            this.btAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacto";
            // 
            // btQuitarUsuario
            // 
            this.btQuitarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btQuitarUsuario.Location = new System.Drawing.Point(448, 254);
            this.btQuitarUsuario.Name = "btQuitarUsuario";
            this.btQuitarUsuario.Size = new System.Drawing.Size(59, 20);
            this.btQuitarUsuario.TabIndex = 17;
            this.btQuitarUsuario.Text = "eliminar";
            this.btQuitarUsuario.UseVisualStyleBackColor = true;
            // 
            // btQuitarContacto
            // 
            this.btQuitarContacto.ForeColor = System.Drawing.Color.Black;
            this.btQuitarContacto.Location = new System.Drawing.Point(448, 150);
            this.btQuitarContacto.Name = "btQuitarContacto";
            this.btQuitarContacto.Size = new System.Drawing.Size(59, 20);
            this.btQuitarContacto.TabIndex = 7;
            this.btQuitarContacto.Text = "eliminar";
            this.btQuitarContacto.UseVisualStyleBackColor = true;
            // 
            // btBuscaUsuario
            // 
            this.btBuscaUsuario.ForeColor = System.Drawing.Color.Black;
            this.btBuscaUsuario.Location = new System.Drawing.Point(448, 231);
            this.btBuscaUsuario.Name = "btBuscaUsuario";
            this.btBuscaUsuario.Size = new System.Drawing.Size(28, 20);
            this.btBuscaUsuario.TabIndex = 17;
            this.btBuscaUsuario.Text = "...";
            this.btBuscaUsuario.UseVisualStyleBackColor = true;
            this.btBuscaUsuario.Click += new System.EventHandler(this.btBuscaUsuario_Click);
            // 
            // btBuscaContacto
            // 
            this.btBuscaContacto.ForeColor = System.Drawing.Color.Black;
            this.btBuscaContacto.Location = new System.Drawing.Point(448, 127);
            this.btBuscaContacto.Name = "btBuscaContacto";
            this.btBuscaContacto.Size = new System.Drawing.Size(28, 20);
            this.btBuscaContacto.TabIndex = 7;
            this.btBuscaContacto.Text = "...";
            this.btBuscaContacto.UseVisualStyleBackColor = true;
            this.btBuscaContacto.Click += new System.EventHandler(this.btBuscaContacto_Click);
            // 
            // btAgregarContacto
            // 
            this.btAgregarContacto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarContacto.ForeColor = System.Drawing.Color.Black;
            this.btAgregarContacto.Location = new System.Drawing.Point(479, 127);
            this.btAgregarContacto.Name = "btAgregarContacto";
            this.btAgregarContacto.Size = new System.Drawing.Size(28, 20);
            this.btAgregarContacto.TabIndex = 7;
            this.btAgregarContacto.Text = "+";
            this.btAgregarContacto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Usuario";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(264, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ver Todo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(196, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btQuitarProducto
            // 
            this.btQuitarProducto.ForeColor = System.Drawing.Color.Black;
            this.btQuitarProducto.Location = new System.Drawing.Point(448, 51);
            this.btQuitarProducto.Name = "btQuitarProducto";
            this.btQuitarProducto.Size = new System.Drawing.Size(59, 20);
            this.btQuitarProducto.TabIndex = 12;
            this.btQuitarProducto.Text = "eliminar";
            this.btQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btAgregarProducto.Location = new System.Drawing.Point(479, 28);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(28, 20);
            this.btAgregarProducto.TabIndex = 12;
            this.btAgregarProducto.Text = "+";
            this.btAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btBuscaProd
            // 
            this.btBuscaProd.ForeColor = System.Drawing.Color.Black;
            this.btBuscaProd.Location = new System.Drawing.Point(448, 28);
            this.btBuscaProd.Name = "btBuscaProd";
            this.btBuscaProd.Size = new System.Drawing.Size(28, 20);
            this.btBuscaProd.TabIndex = 12;
            this.btBuscaProd.Text = "...";
            this.btBuscaProd.UseVisualStyleBackColor = true;
            this.btBuscaProd.Click += new System.EventHandler(this.btBuscaProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "and";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "and";
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(976, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxBuscarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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