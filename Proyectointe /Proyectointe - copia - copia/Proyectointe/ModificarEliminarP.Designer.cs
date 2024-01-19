
namespace Proyectointe
{
    partial class ModificarEliminarP
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
            this.pRODUCTOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new Proyectointe.DataSet6();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productosDB = new Proyectointe.productosDB();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.NombreProve = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pRODUCTOSTableAdapter = new Proyectointe.productosDBTableAdapters.PRODUCTOSTableAdapter();
            this.pRODUCTOSTableAdapter1 = new Proyectointe.DataSet6TableAdapters.PRODUCTOSTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPROVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.nOMBREPROVDataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.tIPODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(122, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pRODUCTOSBindingSource2
            // 
            this.pRODUCTOSBindingSource2.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource2.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.productosDB;
            // 
            // productosDB
            // 
            this.productosDB.DataSetName = "productosDB";
            this.productosDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.productosDB;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(122, 349);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(103, 20);
            this.ID.TabIndex = 3;
            this.ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(240, 349);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(103, 20);
            this.Nombre.TabIndex = 4;
            // 
            // NombreProve
            // 
            this.NombreProve.Location = new System.Drawing.Point(349, 349);
            this.NombreProve.Name = "NombreProve";
            this.NombreProve.Size = new System.Drawing.Size(103, 20);
            this.NombreProve.TabIndex = 5;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(458, 349);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(103, 20);
            this.Precio.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Producto",
            "Servicio"});
            this.comboBox1.Location = new System.Drawing.Point(567, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOSTableAdapter1
            // 
            this.pRODUCTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBREPROVDataGridViewTextBoxColumn
            // 
            this.nOMBREPROVDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PROV";
            this.nOMBREPROVDataGridViewTextBoxColumn.HeaderText = "NOMBRE_PROV";
            this.nOMBREPROVDataGridViewTextBoxColumn.Name = "nOMBREPROVDataGridViewTextBoxColumn";
            this.nOMBREPROVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            this.pRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPODataGridViewTextBoxColumn
            // 
            this.tIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO";
            this.tIPODataGridViewTextBoxColumn.HeaderText = "TIPO";
            this.tIPODataGridViewTextBoxColumn.Name = "tIPODataGridViewTextBoxColumn";
            this.tIPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(349, 384);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(103, 20);
            this.cantidad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModificarEliminarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.NombreProve);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificarEliminarP";
            this.Text = "Modificar/EliminarP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox NombreProve;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.ComboBox comboBox1;
        private productosDB productosDB;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private productosDBTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource2;
        private DataSet6TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPROVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
    }
}