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
    public partial class ConsultarCalificacion : Form
    {
        public ConsultarCalificacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Proveedor";
            dataGridView1.Columns[2].Name = "Calificacion";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            string fechaI = dateTimePicker1.Value.ToString("dd/MM/yy");
            string fechaF = dateTimePicker2.Value.ToString("dd/MM/yy");
            Program.comando.CommandText = $"select unique p.nombre,p.nombre_prov,(select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacionp clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}') from productos p where (select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacionp clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}') is not null";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                dataGridView1.Rows.Add(Program.lector.GetValue(0), Program.lector.GetValue(1), Program.lector.GetValue(2)); ;
            }
        }

        private void Buscar(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Proveedor";
            dataGridView1.Columns[2].Name = "Calificacion";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            string fechaI = dateTimePicker1.Value.ToString("dd/MM/yy");
            string fechaF = dateTimePicker2.Value.ToString("dd/MM/yy");
            Program.comando.CommandText = $"select unique p.nombre,p.nombre_prov,(select cast(AVG(clp.calificaciont)as decimal(5,2)) from calificacionp clp,mispedidos mp where clp.numpedido=mp.numpedido and p.id=mp.idp and to_char(fecha,'dd/mm/yy')>='{fechaI}' and to_char(fecha,'dd/mm/yy')<='{fechaF}' and clp.calificaciont is not null),tipo from productos p,mispedidos mp,calificacionp clp where p.id=mp.idp and mp.numpedido=clp.numpedido and to_char(clp.fecha)<='{fechaF}' and to_char(clp.fecha)>='{fechaI}' and p.calificacion is not null";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                dataGridView1.Rows.Add(Program.lector.GetValue(0), Program.lector.GetValue(1), Program.lector.GetValue(2));;
            }
            Program.comando.CommandText = $"select unique p.nombre,p.nombre_prov,(select cast(AVG(clp.calificaciont)as decimal(5,2)) from calificacions clp,mispedidos mp where clp.numpedido=mp.numpedido and p.id=mp.idp and to_char(fecha,'dd/mm/yy')>='{fechaI}' and to_char(fecha,'dd/mm/yy')<='{fechaF}' and clp.calificaciont is not null),tipo from productos p,mispedidos mp,calificacions clp where p.id=mp.idp and mp.numpedido=clp.numpedido and to_char(clp.fecha)<='{fechaF}' and to_char(clp.fecha)>='{fechaI}' and p.calificacion is not null";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                dataGridView1.Rows.Add(Program.lector.GetValue(0), Program.lector.GetValue(1), Program.lector.GetValue(2)); ;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Proveedor";
            dataGridView1.Columns[1].Name = "Calificacion";
            dataGridView1.Columns[0].Width = 225;
            dataGridView1.Columns[1].Width = 225;
            string fechaI = dateTimePicker1.Value.ToString("dd/MM/yy");
            string fechaF = dateTimePicker2.Value.ToString("dd/MM/yy");
            Program.comando.CommandText = $"select unique p.nombre_prov,(NVL((select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacions clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}'),0)+nvl((select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacionp clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}'),0)) from productos p where (NVL((select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacions clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}'),0)+nvl((select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacionp clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}'),0)) !=0";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                dataGridView1.Rows.Add(Program.lector.GetValue(0), Program.lector.GetValue(1)); ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Producto";
            dataGridView1.Columns[1].Name = "Proveedor";
            dataGridView1.Columns[2].Name = "Calificacion";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            string fechaI = dateTimePicker1.Value.ToString("dd/MM/yy");
            string fechaF = dateTimePicker2.Value.ToString("dd/MM/yy");
            Program.comando.CommandText = $"select unique p.nombre,p.nombre_prov,(select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacions clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}') from productos p where (select cast(avg(clp.calificaciont) as decimal(5,2)) from calificacions clp,mispedidos mp where clp.numpedido=mp.numpedido and mp.idp=p.id and clp.calificaciont is not null and to_char(clp.fecha,'dd/mm/yy')>='{fechaI}' and to_char(clp.fecha,'dd/mm/yy')<='{fechaF}') is not null";
            Program.lector = Program.comando.ExecuteReader();
            while (Program.lector.Read())
            {
                dataGridView1.Rows.Add(Program.lector.GetValue(0), Program.lector.GetValue(1), Program.lector.GetValue(2)); ;
            }
        }

    }
}
