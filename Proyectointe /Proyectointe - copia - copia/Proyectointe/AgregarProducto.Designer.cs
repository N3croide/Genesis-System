
namespace Proyectointe
{
    partial class AgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.NombreProv = new System.Windows.Forms.TextBox();
            this.NombreP = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Precio);
            this.groupBox1.Controls.Add(this.NombreProv);
            this.groupBox1.Controls.Add(this.NombreP);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(-27, -16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Servicio",
            "Producto"});
            this.comboBox1.Location = new System.Drawing.Point(343, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Precio
            // 
            this.Precio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Precio.Location = new System.Drawing.Point(293, 243);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(171, 20);
            this.Precio.TabIndex = 4;
            this.Precio.Text = "Precio";
            this.Precio.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NombreProv
            // 
            this.NombreProv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NombreProv.Location = new System.Drawing.Point(293, 187);
            this.NombreProv.Name = "NombreProv";
            this.NombreProv.Size = new System.Drawing.Size(171, 20);
            this.NombreProv.TabIndex = 3;
            this.NombreProv.Text = "Nombre Proveedor";
            this.NombreProv.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NombreP
            // 
            this.NombreP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NombreP.Location = new System.Drawing.Point(293, 131);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(171, 20);
            this.NombreP.TabIndex = 1;
            this.NombreP.Text = "Nombre";
            this.NombreP.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ID.Location = new System.Drawing.Point(293, 79);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(171, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "Id";
            this.ID.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(266, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cantidad.Location = new System.Drawing.Point(293, 298);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(171, 20);
            this.Cantidad.TabIndex = 7;
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox NombreProv;
        private System.Windows.Forms.TextBox NombreP;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Cantidad;
    }
}