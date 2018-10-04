namespace PuntoDeVenta
{
    partial class ListaProveedores
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
            this.lvProv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvProv
            // 
            this.lvProv.Location = new System.Drawing.Point(13, 13);
            this.lvProv.Name = "lvProv";
            this.lvProv.Size = new System.Drawing.Size(562, 245);
            this.lvProv.TabIndex = 0;
            this.lvProv.UseCompatibleStateImageBehavior = false;
            this.lvProv.SelectedIndexChanged += new System.EventHandler(this.lvProv_SelectedIndexChanged);
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 270);
            this.Controls.Add(this.lvProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaProveedores";
            this.Text = "ListaProveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProv;
    }
}