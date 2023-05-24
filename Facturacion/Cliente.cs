using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=BRAYAN;Initial Catalog=DBFACTURACION;Integrated Security=True";
            string query = "INSERT INTO Clientes VALUES(@ID, @NOMBRE, @DIRECCION, @TELEFONO, @CORREO)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", Convert.ToInt64(txt_cliente.Text));
            command.Parameters.AddWithValue("@NOMBRE",txt_NombreCliente.Text);
            command.Parameters.AddWithValue("@DIRECCION",txt_direccion.Text);
            command.Parameters.AddWithValue("@TELEFONO",txt_telefono.Text);
            command.Parameters.AddWithValue("@CORREO",txt_correo.Text);

            connection.Open();
            MessageBox.Show("Conection");
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("conection closed");
        }
    }
}
