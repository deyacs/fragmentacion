using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // conexion a la base de datos 
        MySqlConnection con = new MySqlConnection("server=localhost;database=escuela;Uid=root;Pwd=passw0rd;");
        DataTable dt = new DataTable();
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // mostrar todos los datos 
            dataGridView1.Visible = true;
            MySqlDataAdapter da = new MySqlDataAdapter("select * from alumnos", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // mostar datos del 90 al 99
            dataGridView2.Visible = true;
            MySqlDataAdapter da = new MySqlDataAdapter("select * from Alumnos where substr(Numcontrol,1,2) between '90' and '99'", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            // mostrar datos del 00 al 09
            dataGridView3.Visible = true;
            MySqlDataAdapter da1 = new MySqlDataAdapter("select * from Alumnos where substr(Numcontrol,1,2) between '00' and '09'", con);
            da1.SelectCommand.CommandType = CommandType.Text;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;

            // mostar datos del 10 al 16
            dataGridView4.Visible = true;
            MySqlDataAdapter da2 = new MySqlDataAdapter("select * from Alumnos where substr(Numcontrol,1,2) between '10' and '16'", con);
            da2.SelectCommand.CommandType = CommandType.Text;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // mostar datos por Especialidad 
            dataGridView2.Visible = true;
            MySqlDataAdapter da = new MySqlDataAdapter("select NumControl,Ciudad,Especialidad from alumnos where Especialidad = 'Sistemas'" , con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            // mostrar datos por Ciudad
            dataGridView3.Visible = true;
            MySqlDataAdapter da1 = new MySqlDataAdapter("select NumControl,Nombre,ciudad from alumnos where ciudad = 'Nuevo Laredo'", con);
            da1.SelectCommand.CommandType = CommandType.Text;
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;

            // mostar datos por semestre 
            dataGridView4.Visible = true;
            MySqlDataAdapter da2 = new MySqlDataAdapter("select NumControl,Especialidad,Semestre  from alumnos where Semestre between 23 and 33", con);
            da2.SelectCommand.CommandType = CommandType.Text;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;
            
        }
    }
}
