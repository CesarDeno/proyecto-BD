using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Base_Datos
{
    public partial class Pantalla_Principal : Form
    {
        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente f1 = new Cliente();
            f1.ShowDialog();
        }

        private void btnOficina_Click(object sender, EventArgs e)
        {
            Oficina f2 = new Oficina();
            f2.ShowDialog();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
        }

        private void btnEncargado_Click(object sender, EventArgs e)
        {
            Encargado f3 = new Encargado();
            f3.ShowDialog();
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            Proyecto f4 = new Proyecto();
            f4.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial f5 = new Historial();
            f5.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
