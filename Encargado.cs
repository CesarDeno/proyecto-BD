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

    public partial class Encargado : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public Encargado()
        {
            InitializeComponent();
        }

        private void Encargado_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;

            dgvEncargados.ReadOnly = true;            
            try
            {
                conexion.Open();

                actualizarEncargados();

                cbxEncargados.Items.Add("Clave_Encargado");
                cbxEncargados.Items.Add("Nombre");
                cbxEncargados.Items.Add("Apellido_Paterno");
                cbxEncargados.Items.Add("Apellido_Materno");
                cbxEncargados.Items.Add("Teléfono");
                cbxEncargados.Items.Add("Correo");
                cbxEncargados.Items.Add("Clave_Oficina");
                cbxEncargados.Items.Add("Nombre_Oficina");



            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();

            }
        }

        public DataTable pasarDataTable()
        {
            SqlCommand comando = new SqlCommand("SELECT nombre + ' ' + apellido_p AS 'nombre', cve_encargado FROM ENCARGADO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaEncargados = new DataTable();
            adaptador.Fill(tablaEncargados);
            dgvEncargados.DataSource = tablaEncargados;

            return tablaEncargados;
        }
        public void actualizarEncargados()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM ENCARGADO_TABLA", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaEncargados = new DataTable();
            adaptador.Fill(tablaEncargados);
            dgvEncargados.DataSource = tablaEncargados;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEncargado f1 = new AgregarEncargado();
            f1.ShowDialog();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarEncargados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ENCARGADO WHERE CVE_ENCARGADO = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@clave", dgvEncargados.CurrentRow.Cells["Clave_Encargado"].Value);

            if (MessageBox.Show("¿Desea eliminar al encargado seleccionado?", "Eliminar Encargado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Encargado Eliminado");
                    actualizarEncargados();
                }
                catch (Exception)
                {
                    MessageBox.Show("Este Encargado cuenta con proyectos pendientes", "Eliminar Encargado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ENCARGADO SET nombre = @nombre, apellido_p = @apellidop, apellido_m = @apellidom, teléfono = @telefono, correo = @correo WHERE cve_encargado = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", dgvEncargados.CurrentRow.Cells["Nombre"].Value);
            comando.Parameters.AddWithValue("@apellidop", dgvEncargados.CurrentRow.Cells["Apellido_Paterno"].Value);
            comando.Parameters.AddWithValue("@apellidom", dgvEncargados.CurrentRow.Cells["Apellido_Materno"].Value);
            comando.Parameters.AddWithValue("@telefono", dgvEncargados.CurrentRow.Cells["Teléfono"].Value);
            comando.Parameters.AddWithValue("@correo", dgvEncargados.CurrentRow.Cells["Correo"].Value);
            comando.Parameters.AddWithValue("@clave", dgvEncargados.CurrentRow.Cells["Clave_Encargado"].Value);

            if (MessageBox.Show("¿Desea modificar el encargado seleccionado?", "Modificar Encargado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Encargado Modificado");
                actualizarEncargados();
            }
            else
            {
                actualizarEncargados();
            }
        }

        private void cbxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxModificar.Checked)
            {
                dgvEncargados.ReadOnly = false;
            }
            else
            {
                dgvEncargados.ReadOnly = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM ENCARGADO_TABLA", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaEncargados = new DataTable();
            adaptador.Fill(tablaEncargados);
            dgvEncargados.DataSource = tablaEncargados;

            try
            {
                tablaEncargados.DefaultView.RowFilter = $"{cbxEncargados.Text} LIKE '{txtBuscar.Text}%'";
            }
            catch (Exception)
            {
            }
        }
    }
}
