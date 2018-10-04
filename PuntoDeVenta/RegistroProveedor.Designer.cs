namespace PuntoDeVenta
{
    partial class RegistroProveedor
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
            this.pnlRegProv = new System.Windows.Forms.Panel();
            this.lbNombres = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNomEmpr = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.pnlRegProv.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegProv
            // 
            this.pnlRegProv.Controls.Add(this.btnReg);
            this.pnlRegProv.Controls.Add(this.textBox4);
            this.pnlRegProv.Controls.Add(this.label1);
            this.pnlRegProv.Controls.Add(this.textBox3);
            this.pnlRegProv.Controls.Add(this.lbNomEmpr);
            this.pnlRegProv.Controls.Add(this.textBox2);
            this.pnlRegProv.Controls.Add(this.lbApellidos);
            this.pnlRegProv.Controls.Add(this.textBox1);
            this.pnlRegProv.Controls.Add(this.lbNombres);
            this.pnlRegProv.Location = new System.Drawing.Point(13, 13);
            this.pnlRegProv.Name = "pnlRegProv";
            this.pnlRegProv.Size = new System.Drawing.Size(482, 166);
            this.pnlRegProv.TabIndex = 0;
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Location = new System.Drawing.Point(11, 15);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(55, 13);
            this.lbNombres.TabIndex = 0;
            this.lbNombres.Text = "Nombre(s)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(242, 15);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(49, 13);
            this.lbApellidos.TabIndex = 2;
            this.lbApellidos.Text = "Apellidos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbNomEmpr
            // 
            this.lbNomEmpr.AutoSize = true;
            this.lbNomEmpr.Location = new System.Drawing.Point(242, 54);
            this.lbNomEmpr.Name = "lbNomEmpr";
            this.lbNomEmpr.Size = new System.Drawing.Size(48, 13);
            this.lbNomEmpr.TabIndex = 7;
            this.lbNomEmpr.Text = "Empresa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(303, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha Registro";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(303, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 10;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(201, 132);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // RegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 191);
            this.Controls.Add(this.pnlRegProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroProveedor";
            this.Text = "Registrar proveedor";
            this.pnlRegProv.ResumeLayout(false);
            this.pnlRegProv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegProv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbNomEmpr;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnReg;
    }
}