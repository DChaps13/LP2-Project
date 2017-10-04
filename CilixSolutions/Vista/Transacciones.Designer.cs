namespace Vista
{
    partial class Transacciones
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
            this.label5 = new System.Windows.Forms.Label();
            this.btNuevoContacto = new System.Windows.Forms.Button();
            this.btBuscarContacto = new System.Windows.Forms.Button();
            this.txtNombContacto = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btBuscaProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombUsuario
            // 
            this.lblNombUsuario.AutoSize = true;
            this.lblNombUsuario.Location = new System.Drawing.Point(27, 12);
            this.lblNombUsuario.Name = "lblNombUsuario";
            this.lblNombUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblNombUsuario.TabIndex = 0;
            this.lblNombUsuario.Text = "Usuario:";
            // 
            // txtNombUsuario
            // 
            this.txtNombUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombUsuario.Location = new System.Drawing.Point(94, 11);
            this.txtNombUsuario.Name = "txtNombUsuario";
            this.txtNombUsuario.Size = new System.Drawing.Size(416, 23);
            this.txtNombUsuario.TabIndex = 1;
            this.txtNombUsuario.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Transacción";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(161, 26);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(143, 24);
            this.cboTipo.TabIndex = 5;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(161, 67);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 22);
            this.numCantidad.TabIndex = 7;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Location = new System.Drawing.Point(140, 49);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(277, 22);
            this.txtIDProd.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(412, 478);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(87, 32);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(45, 356);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(465, 76);
            this.txtDescripcion.TabIndex = 15;
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
            this.groupBox1.Location = new System.Drawing.Point(30, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 207);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Proveedor/Cliente";
            // 
            // btNuevoContacto
            // 
            this.btNuevoContacto.Location = new System.Drawing.Point(138, 156);
            this.btNuevoContacto.Name = "btNuevoContacto";
            this.btNuevoContacto.Size = new System.Drawing.Size(87, 30);
            this.btNuevoContacto.TabIndex = 20;
            this.btNuevoContacto.Text = "Nuevo";
            this.btNuevoContacto.UseVisualStyleBackColor = true;
            this.btNuevoContacto.Click += new System.EventHandler(this.btNuevoContacto_Click);
            // 
            // btBuscarContacto
            // 
            this.btBuscarContacto.Location = new System.Drawing.Point(231, 156);
            this.btBuscarContacto.Name = "btBuscarContacto";
            this.btBuscarContacto.Size = new System.Drawing.Size(87, 30);
            this.btBuscarContacto.TabIndex = 19;
            this.btBuscarContacto.Text = "Buscar";
            this.btBuscarContacto.UseVisualStyleBackColor = true;
            this.btBuscarContacto.Click += new System.EventHandler(this.btBuscarContacto_Click);
            // 
            // txtNombContacto
            // 
            this.txtNombContacto.Location = new System.Drawing.Point(20, 128);
            this.txtNombContacto.Name = "txtNombContacto";
            this.txtNombContacto.Size = new System.Drawing.Size(449, 22);
            this.txtNombContacto.TabIndex = 9;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(319, 478);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(87, 32);
            this.btAceptar.TabIndex = 17;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btBuscaProducto
            // 
            this.btBuscaProducto.Location = new System.Drawing.Point(423, 48);
            this.btBuscaProducto.Name = "btBuscaProducto";
            this.btBuscaProducto.Size = new System.Drawing.Size(87, 51);
            this.btBuscaProducto.TabIndex = 18;
            this.btBuscaProducto.Text = "Buscar producto";
            this.btBuscaProducto.UseVisualStyleBackColor = true;
            this.btBuscaProducto.Click += new System.EventHandler(this.btBuscaProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(140, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 19;
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 527);
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
            this.Name = "Transacciones";
            this.Text = "Transacciones";
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