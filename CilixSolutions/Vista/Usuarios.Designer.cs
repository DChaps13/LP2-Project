﻿namespace Vista
{
    partial class Usuarios
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
            this.groupBoxBuscarUsuario = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.btOK = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBuscarUsuario
            // 
            this.groupBoxBuscarUsuario.Controls.Add(this.cbxEstado);
            this.groupBoxBuscarUsuario.Controls.Add(this.label3);
            this.groupBoxBuscarUsuario.Controls.Add(this.Buscar);
            this.groupBoxBuscarUsuario.Controls.Add(this.cbxRol);
            this.groupBoxBuscarUsuario.Controls.Add(this.label2);
            this.groupBoxBuscarUsuario.Controls.Add(this.txtID);
            this.groupBoxBuscarUsuario.Controls.Add(this.label1);
            this.groupBoxBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.groupBoxBuscarUsuario.Location = new System.Drawing.Point(18, 17);
            this.groupBoxBuscarUsuario.Name = "groupBoxBuscarUsuario";
            this.groupBoxBuscarUsuario.Size = new System.Drawing.Size(477, 162);
            this.groupBoxBuscarUsuario.TabIndex = 0;
            this.groupBoxBuscarUsuario.TabStop = false;
            this.groupBoxBuscarUsuario.Text = "Buscar Usuario";
            this.groupBoxBuscarUsuario.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(104, 104);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(228, 28);
            this.cbxEstado.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.Black;
            this.Buscar.Location = new System.Drawing.Point(370, 29);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 28);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // cbxRol
            // 
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(104, 65);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(228, 28);
            this.cbxRol.TabIndex = 6;
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(104, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 27);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Todos";
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.AllowUserToAddRows = false;
            this.dataUsuarios.AllowUserToDeleteRows = false;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechadeCreacion,
            this.Rol});
            this.dataUsuarios.Location = new System.Drawing.Point(18, 185);
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.ReadOnly = true;
            this.dataUsuarios.Size = new System.Drawing.Size(477, 174);
            this.dataUsuarios.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(187, 376);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(90, 31);
            this.btOK.TabIndex = 8;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Visible = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 120;
            // 
            // FechadeCreacion
            // 
            this.FechadeCreacion.DataPropertyName = "fechaCreacion";
            this.FechadeCreacion.HeaderText = "FechaCreacion";
            this.FechadeCreacion.Name = "FechadeCreacion";
            this.FechadeCreacion.ReadOnly = true;
            this.FechadeCreacion.Width = 120;
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "Rol";
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 150;
            // 
            // Usuarios
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.dataUsuarios);
            this.Controls.Add(this.groupBoxBuscarUsuario);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.groupBoxBuscarUsuario.ResumeLayout(false);
            this.groupBoxBuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxBuscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView dataUsuarios;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}