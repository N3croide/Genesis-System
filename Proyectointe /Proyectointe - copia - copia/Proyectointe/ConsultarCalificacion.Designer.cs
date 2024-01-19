
namespace Proyectointe
{
    partial class ConsultarCalificacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ConsultarProductos = new System.Windows.Forms.Button();
            this.ConsultarServicios = new System.Windows.Forms.Button();
            this.ConsultarProv = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // ConsultarProductos
            // 
            this.ConsultarProductos.Location = new System.Drawing.Point(287, 375);
            this.ConsultarProductos.Name = "ConsultarProductos";
            this.ConsultarProductos.Size = new System.Drawing.Size(131, 23);
            this.ConsultarProductos.TabIndex = 2;
            this.ConsultarProductos.Text = "Consultar por Productos";
            this.ConsultarProductos.UseVisualStyleBackColor = true;
            this.ConsultarProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultarServicios
            // 
            this.ConsultarServicios.Location = new System.Drawing.Point(434, 375);
            this.ConsultarServicios.Name = "ConsultarServicios";
            this.ConsultarServicios.Size = new System.Drawing.Size(131, 23);
            this.ConsultarServicios.TabIndex = 3;
            this.ConsultarServicios.Text = "Consultar por Servicios";
            this.ConsultarServicios.UseVisualStyleBackColor = true;
            this.ConsultarServicios.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultarProv
            // 
            this.ConsultarProv.Location = new System.Drawing.Point(581, 375);
            this.ConsultarProv.Name = "ConsultarProv";
            this.ConsultarProv.Size = new System.Drawing.Size(131, 23);
            this.ConsultarProv.TabIndex = 4;
            this.ConsultarProv.Text = "Consultar por Prveedor";
            this.ConsultarProv.UseVisualStyleBackColor = true;
            this.ConsultarProv.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(62, 416);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha final";
            // 
            // buscarbutton
            // 
            this.buscarbutton.Location = new System.Drawing.Point(287, 413);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(131, 23);
            this.buscarbutton.TabIndex = 8;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.Buscar);
            // 
            // ConsultarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 441);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ConsultarProv);
            this.Controls.Add(this.ConsultarServicios);
            this.Controls.Add(this.ConsultarProductos);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarCalificacion";
            this.Text = "ConsultarCalificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ConsultarProductos;
        private System.Windows.Forms.Button ConsultarServicios;
        private System.Windows.Forms.Button ConsultarProv;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscarbutton;
    }
}