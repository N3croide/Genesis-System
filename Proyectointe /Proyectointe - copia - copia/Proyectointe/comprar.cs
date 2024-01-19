using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectointe
{
    public partial class comprar : Form
    {
        public string id;
        public comprar()
        {
            
            InitializeComponent();
        }
        int costo;
        int c;
        bool cerrar=true;
        public void preciot() {
           
            Program.comando.CommandText = $"select precio from productos where id={id}";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
            preciotext.Text = Convert.ToString(Program.lector.GetValue(0)); 
            }
            costo = Convert.ToInt32(preciotext.Text);
            Program.comando.CommandText = $"select cantidad from disponible where idproducto={id}";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                c = Convert.ToInt32(Program.lector.GetValue(0));
            }

        }
        public void producto(object sender, EventArgs e)
        {
            if (c != 0)
            {
                cerrar = false;
                if (cantidadtext.Text != null & cantidadtext.Text != "0" & cantidadtext.Text != "")
                {
                    if (c - Convert.ToInt32(cantidadtext.Text) >= 0 & Convert.ToInt32(cantidadtext.Text)>0 & c>0)
                    {
                        button1.Enabled = true;
                        preciotext.Text = Convert.ToString(costo * Convert.ToInt32(cantidadtext.Text));
                    }
                    else { MessageBox.Show($"No hay productos suficientes \n Productos disponibles{c}");button1.Enabled = false; }
                   
                }
                else { preciotext.Text = Convert.ToString(costo); cantidadtext.Text = "1"; }
            }
            else { MessageBox.Show("Producto Agotado");button1.Enabled = false; }


        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            string f = ""; ;
            string tipo = ""; ;
            Program.comando.CommandText = $"insert into mispedidos(idp,cedulacliente,cantidad)values({id},{Program.InterfazAd.cedula},{cantidadtext.Text})";
            Program.lector = Program.comando.ExecuteReader();
            Program.comando.CommandText = $"update disponible set cantidad={c-Convert.ToInt32(cantidadtext.Text)} where idproducto={id}";
            c -= Convert.ToInt32(cantidadtext.Text);
            Program.lector = Program.comando.ExecuteReader();
            Program.comando.CommandText = "select max(numpedido) from mispedidos";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                f = Program.lector.GetValue(0).ToString();
            }
            
            Program.comando.CommandText = $"select tipo from productos where id={id}";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                tipo = Program.lector.GetValue(0).ToString();
            }
            
            Program.lector = Program.comando.ExecuteReader();
            if (tipo.Equals("Servicio"))
            {
                Program.comando.CommandText = $"insert into calificacions(numpedido)values({f})";
                Program.lector = Program.comando.ExecuteReader();
            }
            else if (tipo.Equals("Producto"))
            {
                Program.comando.CommandText = $"insert into calificacionp(numpedido)values({f})";
                Program.lector = Program.comando.ExecuteReader();
            }
            Program.comando.CommandText = $"insert into ";
            MessageBox.Show("Compra Realizada con exito");
            this.Close();
        }
    }
}
