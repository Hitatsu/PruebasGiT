using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PruebasGiT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(
                "server=192.168.10.145;" +
                "userid=root;" +
                "password=1234;" +
                "database=test"
                );

            conexion.Open();

            MySqlCommand Ingreso = new MySqlCommand();
            Ingreso.Connection = conexion;
            Ingreso.CommandText = "INSERT INTO alumno(cedula,nombre,apellido,clave) VALUE(@cedula,@nombre,@apellido,@clave)";

            Ingreso.Parameters.AddWithValue("@cedula", Cedula.Text);
            Ingreso.Parameters.AddWithValue("@nombre", Nombre.Text);
            Ingreso.Parameters.AddWithValue("@apellido", Apellido.Text);
            Ingreso.Parameters.AddWithValue("@clave", Clave.Text);

            Ingreso.Prepare();

            Ingreso.ExecuteNonQuery();

            conexion.Close();

            
        }
    }
}
