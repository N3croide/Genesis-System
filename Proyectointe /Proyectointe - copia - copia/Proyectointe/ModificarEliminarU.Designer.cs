
namespace Proyectointe
{
    partial class ModificarEliminarU
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEDULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASEÑADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet8 = new Proyectointe.DataSet8();
            this.cLIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter1 = new Proyectointe.DataSet8TableAdapters.CLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDODataGridViewTextBoxColumn,
            this.cEDULADataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.cONTRASEÑADataGridViewTextBoxColumn,
            this.rOLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTESBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(71, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(135, 273);
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Size = new System.Drawing.Size(100, 20);
            this.Cedula.TabIndex = 1;
            this.Cedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(347, 273);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 2;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(453, 273);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(100, 20);
            this.Correo.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(241, 273);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 4;
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(559, 273);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(100, 20);
            this.Contraseña.TabIndex = 5;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(158, 385);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(136, 28);
            this.Actualizar.TabIndex = 8;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(485, 385);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(136, 28);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);

            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(338, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELLIDODataGridViewTextBoxColumn
            // 
            this.aPELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.aPELLIDODataGridViewTextBoxColumn.Name = "aPELLIDODataGridViewTextBoxColumn";
            this.aPELLIDODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEDULADataGridViewTextBoxColumn
            // 
            this.cEDULADataGridViewTextBoxColumn.DataPropertyName = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.HeaderText = "CEDULA";
            this.cEDULADataGridViewTextBoxColumn.Name = "cEDULADataGridViewTextBoxColumn";
            this.cEDULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            this.cORREODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONTRASEÑADataGridViewTextBoxColumn
            // 
            this.cONTRASEÑADataGridViewTextBoxColumn.DataPropertyName = "CONTRASEÑA";
            this.cONTRASEÑADataGridViewTextBoxColumn.HeaderText = "CONTRASEÑA";
            this.cONTRASEÑADataGridViewTextBoxColumn.Name = "cONTRASEÑADataGridViewTextBoxColumn";
            this.cONTRASEÑADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rOLDataGridViewTextBoxColumn
            // 
            this.rOLDataGridViewTextBoxColumn.DataPropertyName = "ROL";
            this.rOLDataGridViewTextBoxColumn.HeaderText = "ROL";
            this.rOLDataGridViewTextBoxColumn.Name = "rOLDataGridViewTextBoxColumn";
            this.rOLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSet8
            // 
            this.dataSet8.DataSetName = "DataSet8";
            this.dataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource1
            // 
            this.cLIENTESBindingSource1.DataMember = "CLIENTES";
            this.cLIENTESBindingSource1.DataSource = this.dataSet8;
            // 
            // cLIENTESTableAdapter1
            // 
            this.cLIENTESTableAdapter1.ClearBeforeFill = true;
            // 
            // ModificarEliminarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarEliminarU";
            this.Text = "Modificar/EliminarU";
            this.Load += new System.EventHandler(this.ModificarEliminarU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEDULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASEÑADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLDataGridViewTextBoxColumn;
        private DataSet8 dataSet8;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource1;
        private DataSet8TableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter1;
    }
}