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
    public partial class Proyecto : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public Proyecto()
        {
            InitializeComponent();
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
            dgvProyectos.ReadOnly = true;
            try
            {
                conexion.Open();

                actualizarProyectos();

                cbxProyectos.Items.Add("Clave_Proyecto");
                cbxProyectos.Items.Add("Tipo");
                cbxProyectos.Items.Add("Clave_Encargado");
                cbxProyectos.Items.Add("Nombre_Encargado");
                cbxProyectos.Items.Add("Clave_Cliente");
                cbxProyectos.Items.Add("Nombre_Cliente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();

            }
        }

        public void actualizarProyectos()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM PROYECTO_TABLA", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaProyectos = new DataTable();
            adaptador.Fill(tablaProyectos);
            dgvProyectos.DataSource = tablaProyectos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProyecto f1 = new AgregarProyecto();
            f1.ShowDialog();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarProyectos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM PROYECTO WHERE CVE_PROYECTO = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@clave", dgvProyectos.CurrentRow.Cells["Clave_Proyecto"].Value);

            if (MessageBox.Show("¿Desea eliminar el proyecto seleccionado?", "Eliminar Proyecto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Proyecto Eliminado");
                actualizarProyectos();
            }
            else
            {
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("SELECT * FROM PROYECTO_TABLA", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaProyectos = new DataTable();
            adaptador.Fill(tablaProyectos);
            dgvProyectos.DataSource = tablaProyectos;

            try
            {
                tablaProyectos.DefaultView.RowFilter = $"{cbxProyectos.Text} LIKE '{txtBuscar.Text}%'";
            }
            catch (Exception)
            {
            }
        }

        private void cbxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxModificar.Checked)
            {
                dgvProyectos.ReadOnly = false;
            }
            else
            {
                dgvProyectos.ReadOnly = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE PROYECTO SET tipo = @tipo, fecha_inicio = @inicio, fecha_terminacion = @final WHERE cve_proyecto = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@tipo", dgvProyectos.CurrentRow.Cells["Tipo"].Value);
            comando.Parameters.AddWithValue("@inicio", dgvProyectos.CurrentRow.Cells["Fecha_Inicio"].Value);
            comando.Parameters.AddWithValue("@final", dgvProyectos.CurrentRow.Cells["Fecha_Terminacion"].Value);
            comando.Parameters.AddWithValue("@clave", dgvProyectos.CurrentRow.Cells["Clave_Proyecto"].Value);

            if (MessageBox.Show("¿Desea modificar el proyecto seleccionado?", "Modificar Proyecto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Proyecto Modificado");
                    actualizarProyectos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Fecha inicial no puede ser despues que la de Terminacion", "Modificar Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actualizarProyectos();
                }  
            }
            else
            {
                actualizarProyectos();
            }
        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
