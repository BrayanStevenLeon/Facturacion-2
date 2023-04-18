using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Telas());
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();
        }
       private void btn_cliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Cliente());
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Pedidos());
        }

        private void btn_detalles_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Detalles());
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Productos());
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Pago());
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Proveedores());
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Factura());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
