
namespace Proyectointe
{
    partial class comprar
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadtext = new System.Windows.Forms.TextBox();
            this.preciotext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Confirmar compra?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // cantidadtext
            // 
            this.cantidadtext.Location = new System.Drawing.Point(260, 59);
            this.cantidadtext.Name = "cantidadtext";
            this.cantidadtext.Size = new System.Drawing.Size(100, 20);
            this.cantidadtext.Text = "1";
            this.cantidadtext.TabIndex = 3;
            this.cantidadtext.TextChanged += new System.EventHandler(this.producto);
            // 
            // preciotext
            // 
            this.preciotext.Location = new System.Drawing.Point(260, 85);
            this.preciotext.Name = "preciotext";
            this.preciotext.ReadOnly = true;
            this.preciotext.Size = new System.Drawing.Size(100, 20);
            this.preciotext.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio total";
            // 
            // comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 173);
            this.Controls.Add(this.preciotext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidadtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "comprar";
            this.Text = "comprar";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.producto);
            this.Load += new System.EventHandler(Comprar_Load);
        }

        private void Comprar_Load(object sender, System.EventArgs e)
        {
            if (this.cerrar)
            {
                this.Close();
            }
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidadtext;
        private System.Windows.Forms.TextBox preciotext;
        private System.Windows.Forms.Label label3;
    }
}