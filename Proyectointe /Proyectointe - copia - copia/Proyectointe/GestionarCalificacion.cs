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
    public partial class GestionarCalificacion : Form
    {
        public GestionarCalificacion()
        {
            InitializeComponent();
           
        }
        public string criterio1p,criterio2p,criterio3p,criterio1s,criterio2s,criterio3s;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Criterio1P.Text=="" || Criterio2P.Text == "" || Criterio3P.Text == "") 
            {
                MessageBox.Show("Ingrese valores");
                return;
            }
            string[] nombre = new string[3];
            Program.comando.CommandText = "select * from calificacionp";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                nombre[0] = Program.lector.GetName(1);
                nombre[1] = Program.lector.GetName(2);
                nombre[2] = Program.lector.GetName(3);
            }
            int x = 0;
            try
            {
                x = Convert.ToInt32(Ponderado1P.Text) + Convert.ToInt32(Ponderado2P.Text) + Convert.ToInt32(Ponderado3P.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese numero validos");
                return;
            }
            if (x == 100) 
            {
                criterio1p = Criterio1P.Text.ToUpper();
                criterio2p = Criterio2P.Text.ToUpper();
                criterio3p = Criterio3P.Text.ToUpper();
                if (nombre[0] != (criterio1p) & nombre[1] != (criterio2p) & nombre[2] != (criterio3p))
                {
                Program.CriterioP = new string[] { criterio1p, criterio2p, criterio3p };
                Program.comando.CommandText = $"update calificacionp set criterio1='{criterio1p}',criterio2='{criterio2p}',criterio3='{criterio3p}'";
                Program.lector = Program.comando.ExecuteReader();
                Program.comando.CommandText = $"update calificacionp set ponderado1={Ponderado1P.Text} ,ponderado2={Ponderado2P.Text},ponderado3={Ponderado3P.Text}";
                Program.lector = Program.comando.ExecuteReader();     
                    MessageBox.Show("Cambios realizados con exito");
                }
                else MessageBox.Show("Ingrese nombres diferentes al ya existente");

            }
            else MessageBox.Show("La suma debe ser 100%");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Criterio1S.Text == "" || Criterio2S.Text == "" || Criterio3S.Text == "")
            {
                MessageBox.Show("Ingrese valores");
                return;
            }
            string[] nombre = new string[3];
            Program.comando.CommandText = "select * from calificacions";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                nombre[0] = Program.lector.GetName(1);
                nombre[1] = Program.lector.GetName(2);
                nombre[2] = Program.lector.GetName(3);
            }
            int x=0;
            try
            {
                x = Convert.ToInt32(Ponderado1S.Text) + Convert.ToInt32(Ponderado2S.Text) + Convert.ToInt32(Ponderado3S.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese numero validos");
                return;
            }
                if (x == 100)
                {
                    criterio1s = Criterio1S.Text.ToUpper();
                    criterio2s = Criterio2S.Text.ToUpper();
                    criterio3s = Criterio3S.Text.ToUpper();   

                if (nombre[0] != (criterio1s) & nombre[1] != (criterio2s) & nombre[2] != (criterio3s))
                {
                    Program.CriterioS = new string[] { criterio1s,criterio2s, criterio3s };
                    Program.comando.CommandText = $"update calificacions set criterio1='{criterio1s}',criterio2='{criterio2s}',criterio3='{criterio3s}'";
                    Program.lector = Program.comando.ExecuteReader();
                    Program.comando.CommandText = $"update calificacions set ponderado1={Ponderado1S.Text},ponderado2={Ponderado2S.Text},ponderado3={Ponderado3S.Text}";
                    Program.lector = Program.comando.ExecuteReader();
                    MessageBox.Show("Cambios realizados con exito");
                }
                else MessageBox.Show("Ingrese nombres diferentes al ya existente");

            } else MessageBox.Show("La suma debe ser 100%");

        }


        
    }
}
