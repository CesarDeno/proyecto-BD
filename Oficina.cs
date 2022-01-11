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
    public partial class Oficina : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public Oficina()
        {
            InitializeComponent();
        }

        private void Oficina_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
            dgvOficina.ReadOnly = true;
            try
            {
                conexion.Open();

                actualizarOficina();

                cbxOficina.Items.Add("Clave_Oficina");
                cbxOficina.Items.Add("Nombre");
                cbxOficina.Items.Add("Direccion");
                cbxOficina.Items.Add("Teléfono");
                cbxOficina.Items.Add("Zona");
                


            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();

            }
        }

        public void actualizarOficina()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM OFICINA_NUMERO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaOficina = new DataTable();
            adaptador.Fill(tablaOficina);
            dgvOficina.DataSource = tablaOficina;
        }

        public DataTable pasarDataTable()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM OFICINA_NUMERO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaOficinas = new DataTable();
            adaptador.Fill(tablaOficinas);
            dgvOficina.DataSource = tablaOficinas;

            return tablaOficinas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarOficina f1 = new AgregarOficina();
            f1.ShowDialog();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarOficina();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM OFICINA WHERE CVE_OFICINA = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@clave", dgvOficina.CurrentRow.Cells["Clave_Oficina"].Value);

            if (MessageBox.Show("¿Desea eliminar la oficina seleccionada?", "Eliminar Oficina", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Oficina Eliminada");
                    actualizarOficina();
                }
                catch (Exception)
                {
                    MessageBox.Show("Esta Oficina cuenta con encargados", "Eliminar Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }
            else
            {
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE OFICINA SET nombre = @nombre, direccion = @direccion, teléfono = @telefono, zona = @zona WHERE cve_oficina = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", dgvOficina.CurrentRow.Cells["Nombre"].Value);
            comando.Parameters.AddWithValue("@direccion", dgvOficina.CurrentRow.Cells["Direccion"].Value);
            comando.Parameters.AddWithValue("@telefono", dgvOficina.CurrentRow.Cells["Teléfono"].Value);
            comando.Parameters.AddWithValue("@zona", dgvOficina.CurrentRow.Cells["Zona"].Value);
            comando.Parameters.AddWithValue("@clave", dgvOficina.CurrentRow.Cells["Clave_Oficina"].Value);


            if (MessageBox.Show("¿Desea modificar la oficina seleccionada?", "Modificar Oficina", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Oficina Modificada");
                actualizarOficina();
            }
            else
            {
                actualizarOficina();
            }
        }

        private void cbxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxModificar.Checked)
            {
                dgvOficina.ReadOnly = false;
            }
            else
            {
                dgvOficina.ReadOnly = true;
            }
        }

        private void txtBuscarOficina_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM OFICINA_NUMERO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaOficinas = new DataTable();
            adaptador.Fill(tablaOficinas);
            dgvOficina.DataSource = tablaOficinas;

            try
            {
                tablaOficinas.DefaultView.RowFilter = $"{cbxOficina.Text} LIKE '{txtBuscarOficina.Text}%'";
            }
            catch (Exception)
            {
            }
        }
    }
}
