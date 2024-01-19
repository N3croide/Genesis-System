using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proyectointe
{

    public partial class InterfazAdmin : Form
    {
        public int cedula=0;
        public string id;
        public int numpedido;
        public InterfazAdmin()
        {
            InitializeComponent();
            PaginaPrincipal.Hide();
            OpcionesAdmin.Hide();
            IniciarSesion.Show();
            Mispedidos.Hide();
            Comprar.Hide();
        }

        Panel paginaAnterior = new Panel();

        private void button2_Click(object sender, EventArgs e)
        {
            using (AgregarProducto aggp = new AgregarProducto()) aggp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Registro reg = new Registro()) reg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ModificarEliminarU meu = new ModificarEliminarU()) meu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ModificarEliminarP mep = new ModificarEliminarP()) mep.ShowDialog();
        }


        private void Iniciar_sesion_Click(object sender, EventArgs e)
        {
            bool x = false;
            Program.comando.CommandText = $"select correo,contraseña,rol,cedula from clientes";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                for (int i = Program.lector.FieldCount-1; i < Program.lector.FieldCount; i++)
                {

                    if (Convert.ToString(Program.lector.GetValue(0)).Equals(usuario.Text) & Convert.ToString(Program.lector.GetValue(1)).Equals(contraseña.Text))
                    {
                        cedula =Convert.ToInt32(Program.lector.GetValue(3));
                        if (Convert.ToString(Program.lector.GetValue(2)).Equals("Administrador"))
                        {

                            OpcionesAdmin.Show();
                            IniciarSesion.Hide();
                            paginaAnterior = IniciarSesion;
                            usuario.Text = "";
                            contraseña.Text = "";
                            x = true;
                            return;
                        }
                        else if (Convert.ToString(Program.lector.GetValue(2)).Equals("Cliente")) {
                            PaginaPrincipal.Show();
                            IniciarSesion.Hide();
                            paginaAnterior = IniciarSesion;
                            usuario.Text = "";
                            contraseña.Text = "";
                            Program.comando.CommandText = "select * from calificacions where numpedido=0 ";
                            Program.lector = Program.comando.ExecuteReader();
                            while (Program.lector.Read())
                            {
                                Program.CalificacionS[0] = Convert.ToString(Program.lector.GetValue(4));
                                Program.CalificacionS[1] = Convert.ToString(Program.lector.GetValue(5));
                                Program.CalificacionS[2] = Convert.ToString(Program.lector.GetValue(6));
                                Program.CriterioS[0] = Program.lector.GetName(1);
                                Program.CriterioS[1] = Program.lector.GetName(2);
                                Program.CriterioS[2] = Program.lector.GetName(3);
                            }

                            Program.comando.CommandText = "select * from calificacionp where numpedido=0 ";
                            Program.lector = Program.comando.ExecuteReader();
                            while (Program.lector.Read())
                            { 
                                Program.CalificacionP[0] = Convert.ToString(Program.lector.GetValue(4));
                                Program.CalificacionP[1] = Convert.ToString(Program.lector.GetValue(5));
                                Program.CalificacionP[2] = Convert.ToString(Program.lector.GetValue(6));
                                Program.CriterioP[0] = Program.lector.GetName(1);
                                Program.CriterioP[1] = Program.lector.GetName(2);
                                Program.CriterioP[2] = Program.lector.GetName(3);
                            }
                            InterfazAdmin_Load(Program.InterfazAd, e);
                            cargarproductos();
                            return;
                        }
                    }
                  
                }
                

            }
            MessageBox.Show("Usuario o contraseña incorrectos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registro rc = new Registro();
            rc.registrarC();
            rc.ShowDialog();
        }

        public void cargarproductos() {;

            vaciarL();
            llenar();
            mejores();
        }
        private void llenar()
        {
            Productocomprar n = new Productocomprar();
            
            n.producto(flowLayoutPanel1);
        }
        private void mejores() {

            Productocomprar n = new Productocomprar();
            n.ProductusMejor(flowLayoutPanel2);
        }
        private void vaciarL() 
        {   Productocomprar x = new Productocomprar();
            x.vaciar(flowLayoutPanel1);
            x.vaciar(flowLayoutPanel2); 
        }
        private void button6_Click(object sender, EventArgs e)
        {
            switch ( paginaAnterior.Name)
            {
                case "PaginaPrincipal":
                    paginaAnterior.Show();
                    Comprar.Hide();
                    Mispedidos.Hide();
                    paginaAnterior = IniciarSesion;
                    break;
                case "IniciarSesion":
                    paginaAnterior.Show();
                    PaginaPrincipal.Hide();
                    OpcionesAdmin.Hide();
                    break;
            }
        }

        private void MispedidosB_Click(object sender, EventArgs e)
        {
            InterfazAdmin_Load(Program.InterfazAd, e);
            Mispedidos.Show();
            PaginaPrincipal.Hide();
            paginaAnterior = PaginaPrincipal;
        }

        private void InterfazAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.COSTOTOTALV' Puede moverla o quitarla según sea necesario.
            this.cOSTOTOTALVTableAdapter.Fill(this.dataSet5.COSTOTOTALV,Program.InterfazAd.cedula);
        }

        public void InterfazComprar(Productocomprar c) 
        {
            Productocomprar d=new Productocomprar();
            comprar comprar = new comprar();
            d.copiar(d, c, comprar);
            comprar.Controls.Add(d);
            comprar.preciot();
            comprar.ShowDialog();           
        }
        private void Comprar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tablamispedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Calificar x = new Calificar();
            Program.comando.CommandText=$"select idp from mispedidos where numpedido='{Tablamispedidos.SelectedCells[0].Value.ToString()}'";
            Program.lector = Program.comando.ExecuteReader();
            numpedido = Convert.ToInt32(Tablamispedidos.SelectedCells[0].Value);
            while (Program.lector.Read())
            {
                id = Convert.ToString(Program.lector.GetValue(0));
            }
            
            x.Calificar_Load(x);
            x.ShowDialog();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            using (GestionarCalificacion gc = new GestionarCalificacion()) gc.ShowDialog();

        }
        public void calificar() {
            int x;
            x=Tablamispedidos.SelectedRows[0].Index;
            Tablamispedidos.ClearSelection();
            this.Tablamispedidos.CurrentCell = null;
            Tablamispedidos.Rows[x].Visible = false;
         }

        private void ConsultarCal_Click(object sender, EventArgs e)
        {
            using (ConsultarCalificacion x = new ConsultarCalificacion()) x.ShowDialog();

        }

    }

}
