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
    public partial class ModificarEliminarU : Form
    {
        public ModificarEliminarU()
        {
            InitializeComponent();
            ModificarEliminarU_Load();
        }

        private void ModificarEliminarU_Load()
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet8.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter1.Fill(this.dataSet8.CLIENTES);

            Program.comando.CommandText = @"select * from clientes";
            DataTable x = new DataTable();
            x.Load(Program.comando.ExecuteReader());
            dataGridView1.DataSource = x;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.comando.CommandText = $"update clientes set nombre='{Nombre.Text}',apellido='{Apellido.Text}',correo='{Correo.Text}',Contraseña='{Contraseña.Text}' where cedula='{Cedula.Text}'";
            Program.lector = Program.comando.ExecuteReader();
            MessageBox.Show("Usuario actualizado");
            ModificarEliminarU_Load();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Cedula.Text = dataGridView1.SelectedCells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] x = new string[6];
            Program.comando.CommandText = $"select * from clientes where cedula='{Cedula.Text}'";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                for (int i = 0; i < Program.lector.FieldCount; i++)
                {
                    x[i] = Program.lector.GetValue(i).ToString();
                }
                Nombre.Text = x[0];
                Apellido.Text = x[1];
                Correo.Text = x[3];
                Contraseña.Text = x[4];
                comboBox1.Text =x[5];
                
            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Program.comando.CommandText = $"delete from clientes where cedula='{Cedula.Text}'";
            DialogResult re = MessageBox.Show($"Desea eliminar el usuario: {Nombre.Text}","Eliminar Usuario",MessageBoxButtons.YesNo);
            if (DialogResult.Yes==re)
            {
                Program.lector = Program.comando.ExecuteReader();
                MessageBox.Show("Usuario Eliminado");
                Nombre.Text = "";
                Apellido.Text = "";
                Cedula.Text = "";
                Correo.Text = "";
                Contraseña.Text = "";
            }
            ModificarEliminarU_Load();
        }

        private void ModificarEliminarU_Load(object sender, EventArgs e)
        {

        }
    }
}
