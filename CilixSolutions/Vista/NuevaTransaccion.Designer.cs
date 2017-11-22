namespace Vista
{
    partial class NuevaTransaccion
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
            this.lblNombUsuario = new System.Windows.Forms.Label();
            this.txtNombUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btNuevoContacto = new System.Windows.Forms.Button();
            this.btBuscarContacto = new System.Windows.Forms.Button();
            this.txtNombContacto = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btBuscaProducto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombUsuario
            // 
            this.lblNombUsuario.AutoSize = true;
            this.lblNombUsuario.Location = new System.Drawing.Point(20, 10);
            this.lblNombUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombUsuario.Name = "lblNombUsuario";
            this.lblNombUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNombUsuario.TabIndex = 0;
            this.lblNombUsuario.Text = "Usuario:";
            this.lblNombUsuario.Click += new System.EventHandler(this.lblNombUsuario_Click);
            // 
            // txtNombUsuario
            // 
            this.txtNombUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombUsuario.Location = new System.Drawing.Point(70, 9);
            this.txtNombUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNombUsuario.Name = "txtNombUsuario";
            this.txtNombUsuario.Size = new System.Drawing.Size(312, 19);
            this.txtNombUsuario.TabIndex = 1;
            this.txtNombUsuario.Text = "label1";
            this.txtNombUsuario.Click += new System.EventHandler(this.txtNombUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad Actual";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Transacción";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(121, 21);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(232, 21);
            this.cboTipo.TabIndex = 5;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(121, 54);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(90, 20);
            this.numCantidad.TabIndex = 7;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // txtIDProd
            // 
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Location = new System.Drawing.Point(105, 40);
            this.txtIDProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(209, 20);
            this.txtIDProd.TabIndex = 8;
            this.txtIDProd.TextChanged += new System.EventHandler(this.txtIDProd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripción";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.ForeColor = System.Drawing.Color.Black;
            this.btCancelar.Location = new System.Drawing.Point(309, 388);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(65, 26);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 356);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(34, 289);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 62);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btNuevoContacto);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.btBuscarContacto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombContacto);
            this.groupBox1.Controls.Add(this.numCantidad);
            this.groupBox1.Location = new System.Drawing.Point(22, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(362, 168);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cantidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Proveedor/Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btNuevoContacto
            // 
            this.btNuevoContacto.ForeColor = System.Drawing.Color.Black;
            this.btNuevoContacto.Location = new System.Drawing.Point(104, 127);
            this.btNuevoContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btNuevoContacto.Name = "btNuevoContacto";
            this.btNuevoContacto.Size = new System.Drawing.Size(65, 24);
            this.btNuevoContacto.TabIndex = 20;
            this.btNuevoContacto.Text = "Nuevo";
            this.btNuevoContacto.UseVisualStyleBackColor = true;
            this.btNuevoContacto.Click += new System.EventHandler(this.btNuevoContacto_Click);
            // 
            // btBuscarContacto
            // 
            this.btBuscarContacto.ForeColor = System.Drawing.Color.Black;
            this.btBuscarContacto.Location = new System.Drawing.Point(173, 127);
            this.btBuscarContacto.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscarContacto.Name = "btBuscarContacto";
            this.btBuscarContacto.Size = new System.Drawing.Size(65, 24);
            this.btBuscarContacto.TabIndex = 19;
            this.btBuscarContacto.Text = "Buscar";
            this.btBuscarContacto.UseVisualStyleBackColor = true;
            this.btBuscarContacto.Click += new System.EventHandler(this.btBuscarContacto_Click);
            // 
            // txtNombContacto
            // 
            this.txtNombContacto.Location = new System.Drawing.Point(15, 104);
            this.txtNombContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombContacto.Name = "txtNombContacto";
            this.txtNombContacto.Size = new System.Drawing.Size(338, 20);
            this.txtNombContacto.TabIndex = 9;
            this.txtNombContacto.TextChanged += new System.EventHandler(this.txtNombContacto_TextChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.ForeColor = System.Drawing.Color.Black;
            this.btAceptar.Location = new System.Drawing.Point(239, 388);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(65, 26);
            this.btAceptar.TabIndex = 17;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btBuscaProducto
            // 
            this.btBuscaProducto.ForeColor = System.Drawing.Color.Black;
            this.btBuscaProducto.Location = new System.Drawing.Point(317, 39);
            this.btBuscaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaProducto.Name = "btBuscaProducto";
            this.btBuscaProducto.Size = new System.Drawing.Size(65, 41);
            this.btBuscaProducto.TabIndex = 18;
            this.btBuscaProducto.Text = "Buscar producto";
            this.btBuscaProducto.UseVisualStyleBackColor = true;
            this.btBuscaProducto.Click += new System.EventHandler(this.btBuscaProducto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(105, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NuevaTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(416, 428);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btBuscaProducto);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombUsuario);
            this.Controls.Add(this.lblNombUsuario);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NuevaTransaccion";
            this.Text = "Nueva Transaccion";
            this.Load += new System.EventHandler(this.NuevaTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombUsuario;
        private System.Windows.Forms.Label txtNombUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btBuscaProducto;
        private System.Windows.Forms.TextBox txtNombContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNuevoContacto;
        private System.Windows.Forms.Button btBuscarContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}