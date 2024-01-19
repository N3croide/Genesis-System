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
    public partial class Calificar : Form
    {

        string P1,P2,P3,tipo;
        public Calificar()
        {
            InitializeComponent();
        }
        public void Calificar_Load(Calificar x)
        {
            Program.comando.CommandText = $"select tipo from productos where id={Program.InterfazAd.id}";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                tipo = Convert.ToString(Program.lector.GetValue(0));
            }
            if (tipo.Equals("Servicio"))
            {
                Program.comando.CommandText = $"select unique criterio1,criterio2,criterio3,ponderado1,ponderado2,ponderado3 from calificacions ";
                Program.lector = Program.comando.ExecuteReader();
                while (Program.lector.Read())
                { 
                    x.label1.Text = Convert.ToString(Program.lector.GetValue(0));
                    x.label2.Text = Convert.ToString(Program.lector.GetValue(1));
                    x.label3.Text = Convert.ToString(Program.lector.GetValue(2));
                    x.P1 = Convert.ToString(Program.lector.GetValue(3));
                    x.P2 = Convert.ToString(Program.lector.GetValue(4));
                    x.P3 = Convert.ToString(Program.lector.GetValue(5));

                }
            }
            else if (tipo.Equals("Producto"))
            {
                Program.comando.CommandText = $"select unique criterio1,criterio2,criterio3,ponderado1,ponderado2,ponderado3 from calificacionp ";
                Program.lector = Program.comando.ExecuteReader();
                while (Program.lector.Read())
                {
                    x.label1.Text = Convert.ToString(Program.lector.GetValue(0));
                    x.label2.Text = Convert.ToString(Program.lector.GetValue(1));
                    x.label3.Text = Convert.ToString(Program.lector.GetValue(2));
                    x.P1 = Convert.ToString(Program.lector.GetValue(3));
                    x.P2 = Convert.ToString(Program.lector.GetValue(4));
                    x.P3 = Convert.ToString(Program.lector.GetValue(5));
                }
            }
        }

        private void GuardarB_Click(object sender, EventArgs e)
        {
            double valor1, valor2, valor3, total;
            valor1 = (Convert.ToDouble(P1) * Convert.ToDouble(Criterio1.Text)) / 100;
            valor2 = (Convert.ToDouble(P2) * Convert.ToDouble(Criterio2.Text)) / 100;
            valor3 = (Convert.ToDouble(P3) * Convert.ToDouble(Criterio3.Text)) / 100;

            total = (valor1 + valor2 + valor3);
            if (tipo.Equals("Producto"))
            {
                Program.InterfazAd.calificar();
                Program.comando.CommandText = $"update calificacionp set nota1='{Math.Truncate(valor1 * 100) / 100}',nota2='{Math.Truncate(valor2 * 100) / 100}',nota3='{Math.Truncate(valor3 * 100) / 100}',calificaciont='{Math.Truncate(total * 100) / 100}' where numpedido ={Program.InterfazAd.numpedido}";
                Program.lector = Program.comando.ExecuteReader();
                Program.comando.CommandText = $"update productos set calificacion=(select avg(cp.calificaciont)from calificacionp cp,mispedidos mp, productos p where cp.numpedido = mp.numpedido and mp.idp = p.id and p.id = { Program.InterfazAd.id}) where id = { Program.InterfazAd.id}";
                Program.lector = Program.comando.ExecuteReader();
            }
            else if (tipo.Equals("Servicio"))
            {
                Program.InterfazAd.calificar();
                Program.comando.CommandText = $"update calificacions set nota1='{Math.Truncate(valor1 * 100) / 100}',nota2='{Math.Truncate(valor2 * 100) / 100}',nota3='{Math.Truncate(valor3 * 100) / 100}',calificaciont='{Math.Truncate(total * 100) / 100}' where numpedido ={Program.InterfazAd.numpedido}";
                Program.lector = Program.comando.ExecuteReader();
                Program.comando.CommandText = $"update productos set calificacion=(select avg(cp.calificaciont)from calificacions cp,mispedidos mp, productos p where cp.numpedido = mp.numpedido and mp.idp = p.id and p.id = { Program.InterfazAd.id}) where id = { Program.InterfazAd.id}";
                Program.lector = Program.comando.ExecuteReader();
            }
            Program.InterfazAd.cargarproductos();
            MessageBox.Show("Gracias por calificar nuestros productos");
            this.Close();
        }


    }
}   

