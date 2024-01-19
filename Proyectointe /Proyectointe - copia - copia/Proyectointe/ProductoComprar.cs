using System;
using System.Windows.Forms;

namespace Proyectointe
{
    public partial class Productocomprar : UserControl
    {
        public Productocomprar()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productocomprar producto = new Productocomprar();
            producto.Calificacion = this.Calificacion;
            producto.Nombre = this.Nombre;
            producto.Precio = this.Precio;
            producto.pictureBox1 = this.pictureBox1;
            producto.panel1 = this.panel1;
            producto.Proveedor = this.Proveedor;
            producto.idproducto = this.idproducto;
            Program.InterfazAd.InterfazComprar(this);
        }
        public void producto(FlowLayoutPanel x) {
            Program.comando.CommandText = "select id,nombre,precio,tipo,nombre_prov from productos";
            Program.lector = Program.comando.ExecuteReader();
            string tipo;
            int id;
            while (Program.lector.Read())
            {
                tipo = Convert.ToString(Program.lector[3]);
                Productocomprar nuevo = new Productocomprar();
                nuevo.Nombre.Text = Convert.ToString(Program.lector[1]);
                nuevo.Precio.Text = "$ "+Convert.ToString(Program.lector[2]);
                nuevo.Proveedor.Text = Convert.ToString(Program.lector[4]);
                id =Convert.ToInt32(Program.lector.GetValue(0));
                nuevo.idproducto.Text =Convert.ToString(Program.lector.GetValue(0));
                x.Controls.Add(nuevo);
                calificacionavg(nuevo,id,tipo); 
            }

           
        
        }
        public void ProductusMejor(FlowLayoutPanel x) {
            Program.comando.CommandText = "select id,nombre,precio,tipo,nombre_prov,calificacion from productos p where p.calificacion is not null order by calificacion desc ";
            Program.lector = Program.comando.ExecuteReader();
            string tipo;
            int id;
            while (Program.lector.Read())
            {
                tipo = Convert.ToString(Program.lector[3]);
                Productocomprar nuevo = new Productocomprar();
                nuevo.Nombre.Text = Convert.ToString(Program.lector[1]);
                nuevo.Precio.Text = "$ " + Convert.ToString(Program.lector[2]);
                id = Convert.ToInt32(Program.lector.GetValue(0));
                nuevo.Proveedor.Text = Convert.ToString(Program.lector[4]);
                nuevo.idproducto.Text = Convert.ToString(Program.lector.GetValue(0));
                x.Controls.Add(nuevo);
                calificacionavg(nuevo, id, tipo);
            }
        
        }
        public void vaciar(FlowLayoutPanel x) {
            x.Controls.Clear();
        }
        public void calificacionavg(Productocomprar x,int id,string tipo)
        {

            Oracle.ManagedDataAccess.Client.OracleCommand comando2;
            Oracle.ManagedDataAccess.Client.OracleDataReader lector2;
            comando2 = Program.conexion.CreateCommand();
            if (tipo == "Producto")
            {
              comando2.CommandText = $"select (select round(avg(cp.calificaciont),2) from calificacionp cp,mispedidos mp,productos p where cp.numpedido=mp.numpedido and mp.idp=p.id and p.id={id})from productos where id = {id}";
                lector2 = comando2.ExecuteReader();
                while (lector2.Read())
                {
                    x.Calificacion.Text =$"{Convert.ToString(lector2.GetValue(0))}";
                }           

            }   
            else if(tipo=="Servicio")
            {

                comando2.CommandText = $"select (select round(avg(cp.calificaciont),2) from calificacions cp,mispedidos mp,productos p where cp.numpedido=mp.numpedido and mp.idp=p.id and p.id={id})from productos where id = { id}";
                lector2 = comando2.ExecuteReader();
                while (lector2.Read())
                {
                    x.Calificacion.Text = $"{Convert.ToString(lector2.GetValue(0))}";
                }
               
            }

        }
        public void copiar(Productocomprar x, Productocomprar g,comprar e) { 
            x.Nombre.Text = g.Nombre.Text;
            x.Precio.Text = g.Precio.Text;
            x.pictureBox1.Image = g.pictureBox1.Image;
            x.Calificacion.Text = g.Calificacion.Text;
            x.idproducto.Text = g.idproducto.Text;
            x.Proveedor.Text = g.Proveedor.Text;
            e.id = x.idproducto.Text;
        }
        

    }
}
