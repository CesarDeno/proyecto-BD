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

namespace Proyecto_Base_Datos
{
    public partial class Historial : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            dgvHistorial.ReadOnly = true;        
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM HISTORIAL", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tablaHistorial = new DataTable();
                adaptador.Fill(tablaHistorial);
                dgvHistorial.DataSource = tablaHistorial;

                cbxHistorial.Items.Add("tabla");
                cbxHistorial.Items.Add("clave");
                cbxHistorial.Items.Add("nombre");
                cbxHistorial.Items.Add("tipo_modificacion");
                cbxHistorial.Items.Add("usuario");
                cbxHistorial.Items.Add("terminal");

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();
            }
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM HISTORIAL", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaHistorial = new DataTable();
            adaptador.Fill(tablaHistorial);
            dgvHistorial.DataSource = tablaHistorial;

            try
            {
                tablaHistorial.DefaultView.RowFilter = $"{cbxHistorial.Text} LIKE '{txtBuscar.Text}%'";
            }
            catch (Exception)
            {
            }
        }
    }
}
