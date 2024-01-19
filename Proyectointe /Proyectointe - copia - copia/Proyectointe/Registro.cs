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
    public partial class Registro : Form
    {


        public Registro()
        {
            InitializeComponent();
        }
        public void registrarC()
        {

            comboBox1.Text = "Cliente";
            comboBox1.Hide();
            label1.Hide();
        }

        private void Registrar(object sender, EventArgs e)
        {
            Program.comando.CommandText = "select cedula from clientes";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                for (int i = 0; i < Program.lector.FieldCount; i++)
                {
                    if (Convert.ToString(Program.lector.GetValue(i)).Equals(textBox3.Text))
                    {
                        MessageBox.Show("Cedula ya registrada");
                        return;
                    }

                }
            }
            Program.comando.CommandText = "select correo from clientes";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                for (int i = 0; i < Program.lector.FieldCount; i++)
                {
                    if (Convert.ToString(Program.lector.GetValue(i)).Equals(textBox6.Text))
                    {
                        MessageBox.Show("Correo ya registrado");
                        return;
                    }

                }
            }
            if (textBox1.Text!="" && textBox1.Text != "Nombre" && textBox2.Text!="" && textBox2.Text != "Apellido" && textBox3.Text != "" && textBox3.Text != "Cedula" && textBox6.Text != "" && textBox6.Text != "Correo" && textBox8.Text != "" && textBox8.Text != "Contraseña" && comboBox1.Text != "" )
            {
                Program.comando.CommandText = $"begin ingresarcliente('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox6.Text}','{textBox8.Text}','{comboBox1.Text}'); end;";
                Program.lector = Program.comando.ExecuteReader();
                MessageBox.Show("Usuario creado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
         

        }
        private void textBox1_TextChanged(object x, EventArgs e)
        {
            TextBox b = x as TextBox;
            string g = b.Text;
            b.Text = "";

        }

    }


}
