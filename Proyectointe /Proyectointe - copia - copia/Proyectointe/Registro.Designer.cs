
namespace Proyectointe
{
    partial class Registro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(266, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nombre";
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(266, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Apellido";
            this.textBox2.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.Location = new System.Drawing.Point(266, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Cedula";
            this.textBox3.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox6.Location = new System.Drawing.Point(266, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(214, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Correo";
            this.textBox6.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(274, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Registrar);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(-6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 434);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rol de usuario:";
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox8.Location = new System.Drawing.Point(266, 256);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(214, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Contraseña";
            this.textBox8.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.comboBox1.Location = new System.Drawing.Point(359, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.TextBox textBox2;
            private System.Windows.Forms.TextBox textBox3;
            private System.Windows.Forms.TextBox textBox6;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.ComboBox comboBox1;
            private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
    }
    }

