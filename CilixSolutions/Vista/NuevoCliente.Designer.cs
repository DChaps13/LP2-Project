namespace Vista
{
    partial class NuevoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DNItextBox = new System.Windows.Forms.TextBox();
            this.CANCELARbutton = new System.Windows.Forms.Button();
            this.CREARbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.APEMATtextBox = new System.Windows.Forms.TextBox();
            this.APEPATtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NOMBREtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CORREOtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TLFtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CORREOtextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TLFtextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DNItextBox);
            this.groupBox1.Controls.Add(this.CANCELARbutton);
            this.groupBox1.Controls.Add(this.CREARbutton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.APEMATtextBox);
            this.groupBox1.Controls.Add(this.APEPATtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NOMBREtextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 273);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI";
            // 
            // DNItextBox
            // 
            this.DNItextBox.Location = new System.Drawing.Point(139, 129);
            this.DNItextBox.Name = "DNItextBox";
            this.DNItextBox.Size = new System.Drawing.Size(174, 20);
            this.DNItextBox.TabIndex = 7;
            this.DNItextBox.TextChanged += new System.EventHandler(this.DNItextBox_TextChanged);
            // 
            // CANCELARbutton
            // 
            this.CANCELARbutton.Location = new System.Drawing.Point(195, 231);
            this.CANCELARbutton.Name = "CANCELARbutton";
            this.CANCELARbutton.Size = new System.Drawing.Size(136, 23);
            this.CANCELARbutton.TabIndex = 5;
            this.CANCELARbutton.Text = "Cancelar";
            this.CANCELARbutton.UseVisualStyleBackColor = true;
            this.CANCELARbutton.Click += new System.EventHandler(this.CANCELARbutton_Click);
            // 
            // CREARbutton
            // 
            this.CREARbutton.Location = new System.Drawing.Point(21, 231);
            this.CREARbutton.Name = "CREARbutton";
            this.CREARbutton.Size = new System.Drawing.Size(136, 23);
            this.CREARbutton.TabIndex = 4;
            this.CREARbutton.Text = "Crear";
            this.CREARbutton.UseVisualStyleBackColor = true;
            this.CREARbutton.Click += new System.EventHandler(this.CREARbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Materno";
            // 
            // APEMATtextBox
            // 
            this.APEMATtextBox.Location = new System.Drawing.Point(139, 94);
            this.APEMATtextBox.Name = "APEMATtextBox";
            this.APEMATtextBox.Size = new System.Drawing.Size(174, 20);
            this.APEMATtextBox.TabIndex = 1;
            this.APEMATtextBox.TextChanged += new System.EventHandler(this.APEMATtextBox_TextChanged);
            // 
            // APEPATtextBox
            // 
            this.APEPATtextBox.Location = new System.Drawing.Point(139, 59);
            this.APEPATtextBox.Name = "APEPATtextBox";
            this.APEPATtextBox.Size = new System.Drawing.Size(174, 20);
            this.APEPATtextBox.TabIndex = 1;
            this.APEPATtextBox.TextChanged += new System.EventHandler(this.APEPATtextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Paterno";
            // 
            // NOMBREtextBox
            // 
            this.NOMBREtextBox.Location = new System.Drawing.Point(139, 25);
            this.NOMBREtextBox.Name = "NOMBREtextBox";
            this.NOMBREtextBox.Size = new System.Drawing.Size(174, 20);
            this.NOMBREtextBox.TabIndex = 1;
            this.NOMBREtextBox.TextChanged += new System.EventHandler(this.NOMBREtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CORREOtextBox
            // 
            this.CORREOtextBox.Location = new System.Drawing.Point(139, 196);
            this.CORREOtextBox.Name = "CORREOtextBox";
            this.CORREOtextBox.Size = new System.Drawing.Size(174, 20);
            this.CORREOtextBox.TabIndex = 11;
            this.CORREOtextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TLFtextBox
            // 
            this.TLFtextBox.Location = new System.Drawing.Point(139, 161);
            this.TLFtextBox.Name = "TLFtextBox";
            this.TLFtextBox.Size = new System.Drawing.Size(174, 20);
            this.TLFtextBox.TabIndex = 9;
            this.TLFtextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoCliente";
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DNItextBox;
        private System.Windows.Forms.Button CANCELARbutton;
        private System.Windows.Forms.Button CREARbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox APEMATtextBox;
        private System.Windows.Forms.TextBox APEPATtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NOMBREtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CORREOtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TLFtextBox;
    }
}