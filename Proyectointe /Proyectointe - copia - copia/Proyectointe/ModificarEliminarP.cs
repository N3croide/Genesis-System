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
    public partial class ModificarEliminarP : Form
    {
        public ModificarEliminarP()
        {
            InitializeComponent();
            ModificarEliminarP_Load();
        }
        string numpedido;

        private void ModificarEliminarP_Load()
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet6.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter1.Fill(this.dataSet6.PRODUCTOS);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ID.Text!="")
            {
                Program.comando.CommandText = $"select * from productos where id='{ID.Text}'";
                Program.lector = Program.comando.ExecuteReader();
                string[] x = new string[Program.lector.FieldCount];
                while (Program.lector.Read())
                {
                    for (int i = 0; i < Program.lector.FieldCount; i++)
                    {
                        x[i] = Program.lector.GetValue(i).ToString();
                    }
                    Nombre.Text = x[1];
                    NombreProve.Text = x[2];
                    Precio.Text = x[3];
                    comboBox1.Text = x[4];
                }
                Program.comando.CommandText = $"select cantidad({ID.Text}) from dual";
                Program.lector = Program.comando.ExecuteReader();
                while (Program.lector.Read())
                {
                    cantidad.Text = Convert.ToString(Program.lector.GetValue(0));
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           ID.Text=dataGridView1.SelectedCells[0].Value.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
       
            Program.comando.CommandText = $"update productos set nombre='{Nombre.Text}',nombre_prov='{NombreProve.Text}',precio='{Precio.Text}',Tipo='{comboBox1.Text}' where id='{ID.Text}'";
            Program.lector = Program.comando.ExecuteReader();
            Program.comando.CommandText = $"update disponible set cantidad={cantidad.Text} where idproducto={ID.Text}";
            Program.lector = Program.comando.ExecuteReader();
            ModificarEliminarP_Load();
            MessageBox.Show("Producto Actualizado");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult op = MessageBox.Show($"Quieres Eliminar: {Nombre.Text}","Eliminar Producto", MessageBoxButtons.YesNo);
            if (DialogResult.Yes==op)
            {

                Program.comando.CommandText = $"select numpedido from mispedidos where idp='{ID.Text}'";
                Program.lector = Program.comando.ExecuteReader();
                while (Program.lector.Read())
                {
                    numpedido = Convert.ToString(Program.lector.GetValue(0)) ;
                }
                Program.comando.CommandText = $"delete from disponible where idproducto={ID.Text}";
                Program.lector = Program.comando.ExecuteReader();
                if (comboBox1.SelectedText.Equals("Servicio"))
                {
                    Program.comando.CommandText = $"delete from calificacions where numpedido={numpedido}";
                    Program.lector = Program.comando.ExecuteReader();
                }
                else if (comboBox1.SelectedText.Equals("Productos")) 
                
                {
                    Program.comando.CommandText = $"delete from calificacionp where numpedido={numpedido}";
                    Program.lector = Program.comando.ExecuteReader();
                }
                Program.comando.CommandText = $"delete from disponible where idproducto='{ID.Text}'";
                Program.lector = Program.comando.ExecuteReader();
                Program.comando.CommandText = $"Delete from mispedidos where idp ='{ID.Text}'";
                Program.lector = Program.comando.ExecuteReader();
                Program.comando.CommandText = $"delete from productos where id={ID.Text}";
                Program.lector = Program.comando.ExecuteReader();
                dataGridView1.ClearSelection();
                ID.Text = "";
                Nombre.Text = "";
                NombreProve.Text = "";
                Precio.Text = "";
                comboBox1.Text = "";
                cantidad.Text = "";
            } 
            
            ModificarEliminarP_Load();
        }

    }
}
