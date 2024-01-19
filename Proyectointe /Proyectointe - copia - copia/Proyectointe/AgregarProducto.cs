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
    public partial class AgregarProducto : Form
    {

        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object x, EventArgs e)
        {
            TextBox b = x as TextBox;
            string g = b.Text;
            b.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.comando.CommandText = "select id from productos";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                for (int i = 0; i < Program.lector.FieldCount; i++)
                {
                    if (Convert.ToString(Program.lector.GetValue(i))==Precio.Text)
                    {
                        MessageBox.Show("El id del producto ya existe");
                        return;
                    }
                }

            }
            Program.comando.CommandText=$"INSERT INTO PRODUCTOS(ID, NOMBRE, NOMBRE_PROV, PRECIO,TIPO) VALUES('{ID.Text}', '{NombreP.Text}', '{NombreProv.Text}', '{Precio.Text}','{comboBox1.Text}')";
            Program.lector = Program.comando.ExecuteReader();
            Program.comando.CommandText = $"insert into disponible(idproducto,cantidad)values({ID.Text},{Cantidad.Text})";
            Program.lector = Program.comando.ExecuteReader();
            MessageBox.Show("El producto ha sido agregado exitosamente");
        }

    }
}
