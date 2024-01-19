
namespace Proyectointe
{
    partial class Calificar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GuardarB = new System.Windows.Forms.Button();
            this.Criterio1 = new System.Windows.Forms.ComboBox();
            this.Criterio2 = new System.Windows.Forms.ComboBox();
            this.Criterio3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // GuardarB
            // 
            this.GuardarB.Location = new System.Drawing.Point(134, 229);
            this.GuardarB.Name = "GuardarB";
            this.GuardarB.Size = new System.Drawing.Size(88, 23);
            this.GuardarB.TabIndex = 6;
            this.GuardarB.Text = "Guardar";
            this.GuardarB.UseVisualStyleBackColor = true;
            this.GuardarB.Click += new System.EventHandler(this.GuardarB_Click);
            // 
            // Criterio1
            // 
            this.Criterio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Criterio1.FormattingEnabled = true;
            this.Criterio1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Criterio1.Location = new System.Drawing.Point(155, 63);
            this.Criterio1.Name = "Criterio1";
            this.Criterio1.Size = new System.Drawing.Size(121, 21);
            this.Criterio1.TabIndex = 7;
            // 
            // Criterio2
            // 
            this.Criterio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Criterio2.FormattingEnabled = true;
            this.Criterio2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Criterio2.Location = new System.Drawing.Point(155, 118);
            this.Criterio2.Name = "Criterio2";
            this.Criterio2.Size = new System.Drawing.Size(121, 21);
            this.Criterio2.TabIndex = 8;
            // 
            // Criterio3
            // 
            this.Criterio3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Criterio3.FormattingEnabled = true;
            this.Criterio3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Criterio3.Location = new System.Drawing.Point(155, 171);
            this.Criterio3.Name = "Criterio3";
            this.Criterio3.Size = new System.Drawing.Size(121, 21);
            this.Criterio3.TabIndex = 9;
            // 
            // Calificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 284);
            this.Controls.Add(this.Criterio3);
            this.Controls.Add(this.Criterio2);
            this.Controls.Add(this.Criterio1);
            this.Controls.Add(this.GuardarB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calificar";
            this.Text = "Calificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GuardarB;
        private System.Windows.Forms.ComboBox Criterio1;
        private System.Windows.Forms.ComboBox Criterio2;
        private System.Windows.Forms.ComboBox Criterio3;
    }
}