namespace PuntoDeVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpProductos = new System.Windows.Forms.GroupBox();
            this.ltbPro = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCodPro = new System.Windows.Forms.Label();
            this.cbxPrePro = new System.Windows.Forms.ComboBox();
            this.lbPrePro = new System.Windows.Forms.Label();
            this.cbxCatPro = new System.Windows.Forms.ComboBox();
            this.cbxNomPro = new System.Windows.Forms.ComboBox();
            this.lbCatPro = new System.Windows.Forms.Label();
            this.lbNomPro = new System.Windows.Forms.Label();
            this.gpTotales = new System.Windows.Forms.GroupBox();
            this.lbTotProd = new System.Windows.Forms.Label();
            this.lbTotPro = new System.Windows.Forms.Label();
            this.lbPreXPro = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbTotPrePro = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbReg = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiProv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiPro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVer = new System.Windows.Forms.ToolStripSplitButton();
            this.tsiListProv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiListPro = new System.Windows.Forms.ToolStripMenuItem();
            this.gpProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpTotales.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpProductos
            // 
            this.gpProductos.Controls.Add(this.ltbPro);
            this.gpProductos.Controls.Add(this.panel1);
            this.gpProductos.Location = new System.Drawing.Point(13, 30);
            this.gpProductos.Name = "gpProductos";
            this.gpProductos.Size = new System.Drawing.Size(515, 434);
            this.gpProductos.TabIndex = 0;
            this.gpProductos.TabStop = false;
            this.gpProductos.Text = "Productos";
            // 
            // ltbPro
            // 
            this.ltbPro.FormattingEnabled = true;
            this.ltbPro.Location = new System.Drawing.Point(7, 196);
            this.ltbPro.Name = "ltbPro";
            this.ltbPro.Size = new System.Drawing.Size(502, 212);
            this.ltbPro.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbCodPro);
            this.panel1.Controls.Add(this.cbxPrePro);
            this.panel1.Controls.Add(this.lbPrePro);
            this.panel1.Controls.Add(this.cbxCatPro);
            this.panel1.Controls.Add(this.cbxNomPro);
            this.panel1.Controls.Add(this.lbCatPro);
            this.panel1.Controls.Add(this.lbNomPro);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 169);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lbCodPro
            // 
            this.lbCodPro.AutoSize = true;
            this.lbCodPro.Location = new System.Drawing.Point(278, 30);
            this.lbCodPro.Name = "lbCodPro";
            this.lbCodPro.Size = new System.Drawing.Size(40, 13);
            this.lbCodPro.TabIndex = 8;
            this.lbCodPro.Text = "Código";
            // 
            // cbxPrePro
            // 
            this.cbxPrePro.FormattingEnabled = true;
            this.cbxPrePro.Location = new System.Drawing.Point(102, 110);
            this.cbxPrePro.Name = "cbxPrePro";
            this.cbxPrePro.Size = new System.Drawing.Size(121, 21);
            this.cbxPrePro.TabIndex = 7;
            // 
            // lbPrePro
            // 
            this.lbPrePro.AutoSize = true;
            this.lbPrePro.Location = new System.Drawing.Point(46, 113);
            this.lbPrePro.Name = "lbPrePro";
            this.lbPrePro.Size = new System.Drawing.Size(37, 13);
            this.lbPrePro.TabIndex = 6;
            this.lbPrePro.Text = "Precio";
            // 
            // cbxCatPro
            // 
            this.cbxCatPro.FormattingEnabled = true;
            this.cbxCatPro.Location = new System.Drawing.Point(102, 69);
            this.cbxCatPro.Name = "cbxCatPro";
            this.cbxCatPro.Size = new System.Drawing.Size(121, 21);
            this.cbxCatPro.TabIndex = 5;
            // 
            // cbxNomPro
            // 
            this.cbxNomPro.FormattingEnabled = true;
            this.cbxNomPro.Location = new System.Drawing.Point(102, 26);
            this.cbxNomPro.Name = "cbxNomPro";
            this.cbxNomPro.Size = new System.Drawing.Size(121, 21);
            this.cbxNomPro.TabIndex = 4;
            // 
            // lbCatPro
            // 
            this.lbCatPro.AutoSize = true;
            this.lbCatPro.Location = new System.Drawing.Point(43, 69);
            this.lbCatPro.Name = "lbCatPro";
            this.lbCatPro.Size = new System.Drawing.Size(54, 13);
            this.lbCatPro.TabIndex = 2;
            this.lbCatPro.Text = "Categoría";
            this.lbCatPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNomPro
            // 
            this.lbNomPro.AutoSize = true;
            this.lbNomPro.Location = new System.Drawing.Point(43, 29);
            this.lbNomPro.Name = "lbNomPro";
            this.lbNomPro.Size = new System.Drawing.Size(44, 13);
            this.lbNomPro.TabIndex = 1;
            this.lbNomPro.Text = "Nombre";
            // 
            // gpTotales
            // 
            this.gpTotales.Controls.Add(this.lbTotProd);
            this.gpTotales.Controls.Add(this.lbTotPro);
            this.gpTotales.Controls.Add(this.lbPreXPro);
            this.gpTotales.Controls.Add(this.lb);
            this.gpTotales.Controls.Add(this.lbTotPrePro);
            this.gpTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTotales.Location = new System.Drawing.Point(535, 30);
            this.gpTotales.Name = "gpTotales";
            this.gpTotales.Size = new System.Drawing.Size(253, 434);
            this.gpTotales.TabIndex = 1;
            this.gpTotales.TabStop = false;
            this.gpTotales.Text = "Totales";
            // 
            // lbTotProd
            // 
            this.lbTotProd.AutoSize = true;
            this.lbTotProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotProd.Location = new System.Drawing.Point(67, 108);
            this.lbTotProd.Name = "lbTotProd";
            this.lbTotProd.Size = new System.Drawing.Size(149, 25);
            this.lbTotProd.TabIndex = 5;
            this.lbTotProd.Text = "Total Productos";
            // 
            // lbTotPro
            // 
            this.lbTotPro.AutoSize = true;
            this.lbTotPro.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotPro.Location = new System.Drawing.Point(116, 133);
            this.lbTotPro.Name = "lbTotPro";
            this.lbTotPro.Size = new System.Drawing.Size(54, 27);
            this.lbTotPro.TabIndex = 4;
            this.lbTotPro.Text = "0.0";
            // 
            // lbPreXPro
            // 
            this.lbPreXPro.AutoSize = true;
            this.lbPreXPro.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreXPro.Location = new System.Drawing.Point(116, 58);
            this.lbPreXPro.Name = "lbPreXPro";
            this.lbPreXPro.Size = new System.Drawing.Size(54, 27);
            this.lbPreXPro.TabIndex = 2;
            this.lbPreXPro.Text = "0.0";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.SystemColors.Window;
            this.lb.Location = new System.Drawing.Point(110, 46);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 13);
            this.lb.TabIndex = 1;
            // 
            // lbTotPrePro
            // 
            this.lbTotPrePro.AutoSize = true;
            this.lbTotPrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotPrePro.Location = new System.Drawing.Point(110, 33);
            this.lbTotPrePro.Name = "lbTotPrePro";
            this.lbTotPrePro.Size = new System.Drawing.Size(67, 25);
            this.lbTotPrePro.TabIndex = 0;
            this.lbTotPrePro.Text = "Precio";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbReg,
            this.toolStripSeparator1,
            this.tsbVer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbReg
            // 
            this.tsbReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiProv,
            this.tsiPro});
            this.tsbReg.Image = ((System.Drawing.Image)(resources.GetObject("tsbReg.Image")));
            this.tsbReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReg.Name = "tsbReg";
            this.tsbReg.Size = new System.Drawing.Size(71, 22);
            this.tsbReg.Text = "Registros";
            // 
            // tsiProv
            // 
            this.tsiProv.Name = "tsiProv";
            this.tsiProv.Size = new System.Drawing.Size(180, 22);
            this.tsiProv.Text = "Proveedores";
            this.tsiProv.Click += new System.EventHandler(this.tsiProv_Click);
            // 
            // tsiPro
            // 
            this.tsiPro.Name = "tsiPro";
            this.tsiPro.Size = new System.Drawing.Size(180, 22);
            this.tsiPro.Text = "Productos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbVer
            // 
            this.tsbVer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiListProv,
            this.tsiListPro});
            this.tsbVer.Image = ((System.Drawing.Image)(resources.GetObject("tsbVer.Image")));
            this.tsbVer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVer.Name = "tsbVer";
            this.tsbVer.Size = new System.Drawing.Size(39, 22);
            this.tsbVer.Text = "Ver";
            // 
            // tsiListProv
            // 
            this.tsiListProv.Name = "tsiListProv";
            this.tsiListProv.Size = new System.Drawing.Size(180, 22);
            this.tsiListProv.Text = "List. Proveedores";
            this.tsiListProv.Click += new System.EventHandler(this.tsiListProv_Click);
            // 
            // tsiListPro
            // 
            this.tsiListPro.Name = "tsiListPro";
            this.tsiListPro.Size = new System.Drawing.Size(163, 22);
            this.tsiListPro.Text = "List. Productos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gpTotales);
            this.Controls.Add(this.gpProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Punto de Venta";
            this.gpProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpTotales.ResumeLayout(false);
            this.gpTotales.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxPrePro;
        private System.Windows.Forms.Label lbPrePro;
        private System.Windows.Forms.ComboBox cbxCatPro;
        private System.Windows.Forms.ComboBox cbxNomPro;
        private System.Windows.Forms.Label lbCatPro;
        private System.Windows.Forms.Label lbNomPro;
        private System.Windows.Forms.GroupBox gpTotales;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCodPro;
        private System.Windows.Forms.ListBox ltbPro;
        private System.Windows.Forms.Label lbTotPrePro;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lbPreXPro;
        private System.Windows.Forms.Label lbTotPro;
        private System.Windows.Forms.Label lbTotProd;
        private System.Windows.Forms.ToolStripSplitButton tsbReg;
        private System.Windows.Forms.ToolStripMenuItem tsiProv;
        private System.Windows.Forms.ToolStripMenuItem tsiPro;
        private System.Windows.Forms.ToolStripSplitButton tsbVer;
        private System.Windows.Forms.ToolStripMenuItem tsiListProv;
        private System.Windows.Forms.ToolStripMenuItem tsiListPro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

