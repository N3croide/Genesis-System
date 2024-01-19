
namespace Proyectointe
{
    partial class Productocomprar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.idproducto = new System.Windows.Forms.Label();
            this.Calificacion = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Proveedor);
            this.panel1.Controls.Add(this.idproducto);
            this.panel1.Controls.Add(this.Calificacion);
            this.panel1.Controls.Add(this.Precio);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 116);
            this.panel1.TabIndex = 0;
            // 
            // idproducto
            // 
            this.idproducto.AutoSize = true;
            this.idproducto.Location = new System.Drawing.Point(82, 73);
            this.idproducto.Name = "idproducto";
            this.idproducto.Size = new System.Drawing.Size(15, 13);
            this.idproducto.TabIndex = 5;
            this.idproducto.Text = "id";
            this.idproducto.Visible = false;
            // 
            // Calificacion
            // 
            this.Calificacion.AutoSize = true;
            this.Calificacion.BackColor = System.Drawing.Color.Transparent;
            this.Calificacion.Location = new System.Drawing.Point(103, 65);
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Size = new System.Drawing.Size(35, 13);
            this.Calificacion.TabIndex = 4;
            this.Calificacion.Text = "label1";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.Location = new System.Drawing.Point(3, 89);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(35, 13);
            this.Precio.TabIndex = 2;
            this.Precio.Text = "label2";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Location = new System.Drawing.Point(103, 3);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(35, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 116);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSize = true;
            this.Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.Proveedor.Location = new System.Drawing.Point(103, 34);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(35, 13);
            this.Proveedor.TabIndex = 6;
            this.Proveedor.Text = "label1";
            // 
            // Productocomprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "Productocomprar";
            this.Size = new System.Drawing.Size(196, 116);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Calificacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label idproducto;
        private System.Windows.Forms.Label Proveedor;
    }
}
