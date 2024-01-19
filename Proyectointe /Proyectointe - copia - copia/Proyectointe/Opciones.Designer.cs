
namespace Proyectointe
{
    partial class InterfazAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAdmin));
            this.button1 = new System.Windows.Forms.Button();
            this.OpcionesAdmin = new System.Windows.Forms.Panel();
            this.ConsultarCal = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PaginaPrincipal = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.MispedidosB = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Mispedidos = new System.Windows.Forms.Panel();
            this.Tablamispedidos = new System.Windows.Forms.DataGridView();
            this.numeroCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTOTOTALVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new Proyectointe.DataSet5();
            this.mISPEDIDOSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new Proyectointe.DataSet3();
            this.Comprar = new System.Windows.Forms.Panel();
            this.IniciarSesion = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Iniciar_sesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Atras = new System.Windows.Forms.Button();
            this.dataSet1 = new Proyectointe.DataSet1();
            this.mISPEDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISPEDIDOSTableAdapter = new Proyectointe.DataSet1TableAdapters.MISPEDIDOSTableAdapter();
            this.mISPEDIDOSVTableAdapter = new Proyectointe.DataSet3TableAdapters.MISPEDIDOSVTableAdapter();
            this.dataSet4 = new Proyectointe.DataSet4();
            this.mISPEDIDOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mISPEDIDOSTableAdapter1 = new Proyectointe.DataSet4TableAdapters.MISPEDIDOSTableAdapter();
            this.dataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSTOTOTALVTableAdapter = new Proyectointe.DataSet5TableAdapters.COSTOTOTALVTableAdapter();
            this.OpcionesAdmin.SuspendLayout();
            this.PaginaPrincipal.SuspendLayout();
            this.Mispedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tablamispedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTOTOTALVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISPEDIDOSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.IniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISPEDIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISPEDIDOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(302, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar/EliminarP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpcionesAdmin
            // 
            this.OpcionesAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.OpcionesAdmin.Controls.Add(this.ConsultarCal);
            this.OpcionesAdmin.Controls.Add(this.button6);
            this.OpcionesAdmin.Controls.Add(this.button1);
            this.OpcionesAdmin.Controls.Add(this.button4);
            this.OpcionesAdmin.Controls.Add(this.button3);
            this.OpcionesAdmin.Controls.Add(this.button2);
            this.OpcionesAdmin.Location = new System.Drawing.Point(1, 35);
            this.OpcionesAdmin.Name = "OpcionesAdmin";
            this.OpcionesAdmin.Size = new System.Drawing.Size(770, 410);
            this.OpcionesAdmin.TabIndex = 11;
            // 
            // ConsultarCal
            // 
            this.ConsultarCal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConsultarCal.Location = new System.Drawing.Point(302, 324);
            this.ConsultarCal.Name = "ConsultarCal";
            this.ConsultarCal.Size = new System.Drawing.Size(178, 41);
            this.ConsultarCal.TabIndex = 13;
            this.ConsultarCal.Text = "Consultar Calificaciones";
            this.ConsultarCal.UseVisualStyleBackColor = false;
            this.ConsultarCal.Click += new System.EventHandler(this.ConsultarCal_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Location = new System.Drawing.Point(302, 261);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 41);
            this.button6.TabIndex = 11;
            this.button6.Text = "Ponderados de Calificacion";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(302, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "RegistrarUsuario";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(302, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modificar/EliminarU";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(302, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "AggProducto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PaginaPrincipal
            // 
            this.PaginaPrincipal.AutoScroll = true;
            this.PaginaPrincipal.AutoSize = true;
            this.PaginaPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.PaginaPrincipal.Controls.Add(this.flowLayoutPanel2);
            this.PaginaPrincipal.Controls.Add(this.MispedidosB);
            this.PaginaPrincipal.Controls.Add(this.flowLayoutPanel1);
            this.PaginaPrincipal.Location = new System.Drawing.Point(1, 35);
            this.PaginaPrincipal.Name = "PaginaPrincipal";
            this.PaginaPrincipal.Size = new System.Drawing.Size(776, 482);
            this.PaginaPrincipal.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(101, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(550, 148);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // MispedidosB
            // 
            this.MispedidosB.Location = new System.Drawing.Point(3, 6);
            this.MispedidosB.Name = "MispedidosB";
            this.MispedidosB.Size = new System.Drawing.Size(93, 23);
            this.MispedidosB.TabIndex = 3;
            this.MispedidosB.Text = "Mis Pedidos";
            this.MispedidosB.UseVisualStyleBackColor = true;
            this.MispedidosB.Click += new System.EventHandler(this.MispedidosB_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(648, 253);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Mispedidos
            // 
            this.Mispedidos.BackColor = System.Drawing.SystemColors.Window;
            this.Mispedidos.Controls.Add(this.Tablamispedidos);
            this.Mispedidos.Location = new System.Drawing.Point(4, 35);
            this.Mispedidos.Name = "Mispedidos";
            this.Mispedidos.Size = new System.Drawing.Size(769, 413);
            this.Mispedidos.TabIndex = 0;
            // 
            // Tablamispedidos
            // 
            this.Tablamispedidos.AllowUserToAddRows = false;
            this.Tablamispedidos.AllowUserToDeleteRows = false;
            this.Tablamispedidos.AutoGenerateColumns = false;
            this.Tablamispedidos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Tablamispedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablamispedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCompraDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoTotalDataGridViewTextBoxColumn});
            this.Tablamispedidos.DataSource = this.cOSTOTOTALVBindingSource;
            this.Tablamispedidos.Location = new System.Drawing.Point(161, 10);
            this.Tablamispedidos.Name = "Tablamispedidos";
            this.Tablamispedidos.ReadOnly = true;
            this.Tablamispedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tablamispedidos.Size = new System.Drawing.Size(443, 346);
            this.Tablamispedidos.TabIndex = 0;
            this.Tablamispedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablamispedidos_CellContentClick);
            // 
            // numeroCompraDataGridViewTextBoxColumn
            // 
            this.numeroCompraDataGridViewTextBoxColumn.DataPropertyName = "Numero compra";
            this.numeroCompraDataGridViewTextBoxColumn.HeaderText = "Numero compra";
            this.numeroCompraDataGridViewTextBoxColumn.Name = "numeroCompraDataGridViewTextBoxColumn";
            this.numeroCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre producto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre producto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoTotalDataGridViewTextBoxColumn
            // 
            this.costoTotalDataGridViewTextBoxColumn.DataPropertyName = "Costo Total";
            this.costoTotalDataGridViewTextBoxColumn.HeaderText = "Costo Total";
            this.costoTotalDataGridViewTextBoxColumn.Name = "costoTotalDataGridViewTextBoxColumn";
            this.costoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOSTOTOTALVBindingSource
            // 
            this.cOSTOTOTALVBindingSource.DataMember = "COSTOTOTALV";
            this.cOSTOTOTALVBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mISPEDIDOSVBindingSource
            // 
            this.mISPEDIDOSVBindingSource.DataMember = "MISPEDIDOSV";
            this.mISPEDIDOSVBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Comprar
            // 
            this.Comprar.AutoScroll = true;
            this.Comprar.AutoSize = true;
            this.Comprar.BackColor = System.Drawing.SystemColors.Window;
            this.Comprar.Location = new System.Drawing.Point(0, 35);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(774, 413);
            this.Comprar.TabIndex = 12;
            this.Comprar.Paint += new System.Windows.Forms.PaintEventHandler(this.Comprar_Paint);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.SystemColors.Window;
            this.IniciarSesion.Controls.Add(this.button5);
            this.IniciarSesion.Controls.Add(this.Iniciar_sesion);
            this.IniciarSesion.Controls.Add(this.label2);
            this.IniciarSesion.Controls.Add(this.label1);
            this.IniciarSesion.Controls.Add(this.contraseña);
            this.IniciarSesion.Controls.Add(this.usuario);
            this.IniciarSesion.Controls.Add(this.pictureBox1);
            this.IniciarSesion.Location = new System.Drawing.Point(0, 35);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(774, 413);
            this.IniciarSesion.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(407, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Registrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Iniciar_sesion
            // 
            this.Iniciar_sesion.Location = new System.Drawing.Point(198, 362);
            this.Iniciar_sesion.Name = "Iniciar_sesion";
            this.Iniciar_sesion.Size = new System.Drawing.Size(147, 23);
            this.Iniciar_sesion.TabIndex = 5;
            this.Iniciar_sesion.Text = "Iniciar sesion";
            this.Iniciar_sesion.UseVisualStyleBackColor = true;
            this.Iniciar_sesion.Click += new System.EventHandler(this.Iniciar_sesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo:";
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.contraseña.Location = new System.Drawing.Point(257, 157);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(208, 20);
            this.contraseña.TabIndex = 2;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(257, 118);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(208, 20);
            this.usuario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(680, 6);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(73, 23);
            this.Atras.TabIndex = 12;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mISPEDIDOSBindingSource
            // 
            this.mISPEDIDOSBindingSource.DataMember = "MISPEDIDOS";
            this.mISPEDIDOSBindingSource.DataSource = this.dataSet1;
            // 
            // mISPEDIDOSTableAdapter
            // 
            this.mISPEDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // mISPEDIDOSVTableAdapter
            // 
            this.mISPEDIDOSVTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mISPEDIDOSBindingSource1
            // 
            this.mISPEDIDOSBindingSource1.DataMember = "MISPEDIDOS";
            this.mISPEDIDOSBindingSource1.DataSource = this.dataSet4;
            // 
            // mISPEDIDOSTableAdapter1
            // 
            this.mISPEDIDOSTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet4BindingSource
            // 
            this.dataSet4BindingSource.DataSource = this.dataSet4;
            this.dataSet4BindingSource.Position = 0;
            // 
            // cOSTOTOTALVTableAdapter
            // 
            this.cOSTOTOTALVTableAdapter.ClearBeforeFill = true;
            // 
            // InterfazAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 517);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.PaginaPrincipal);
            this.Controls.Add(this.OpcionesAdmin);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.Mispedidos);
            this.Name = "InterfazAdmin";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.InterfazAdmin_Load);
            this.OpcionesAdmin.ResumeLayout(false);
            this.PaginaPrincipal.ResumeLayout(false);
            this.Mispedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tablamispedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTOTOTALVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISPEDIDOSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.IniciarSesion.ResumeLayout(false);
            this.IniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISPEDIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISPEDIDOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel IniciarSesion;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Iniciar_sesion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel OpcionesAdmin;
        private System.Windows.Forms.Panel Comprar;
        private System.Windows.Forms.Panel PaginaPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MispedidosB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Panel Mispedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.DataGridView Tablamispedidos;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mISPEDIDOSBindingSource;
        private DataSet1TableAdapters.MISPEDIDOSTableAdapter mISPEDIDOSTableAdapter;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource mISPEDIDOSVBindingSource;
        private DataSet3TableAdapters.MISPEDIDOSVTableAdapter mISPEDIDOSVTableAdapter;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource mISPEDIDOSBindingSource1;
        private DataSet4TableAdapters.MISPEDIDOSTableAdapter mISPEDIDOSTableAdapter1;
        private System.Windows.Forms.BindingSource dataSet4BindingSource;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource cOSTOTOTALVBindingSource;
        private DataSet5TableAdapters.COSTOTOTALVTableAdapter cOSTOTOTALVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ConsultarCal;
    }
}

