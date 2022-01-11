using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Base_Datos
{
    public partial class Cliente : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");

        public Cliente()
        {
            InitializeComponent();
        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
            dgvClientes.ReadOnly = true;
            try
            {
                conexion.Open();

                actualizarClientes();

                cbxCliente.Items.Add("Clave_Cliente");
                cbxCliente.Items.Add("Nombre");
                cbxCliente.Items.Add("Apellido_Paterno");
                cbxCliente.Items.Add("Apellido_Materno");
                cbxCliente.Items.Add("Teléfono");
                cbxCliente.Items.Add("Dirección");
                cbxCliente.Items.Add("Correo");;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();
              
            }
        }

        public DataTable pasarDataTable()
        {
            SqlCommand comando = new SqlCommand("SELECT nombre + ' ' + apellido_p AS 'nombre', cve_cliente FROM CLIENTE", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaClientes = new DataTable();
            adaptador.Fill(tablaClientes);
            dgvClientes.DataSource = tablaClientes;

            return tablaClientes;
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClientes f1 = new AgregarClientes();
            f1.ShowDialog();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.Close();
            conexion.Close();
        }

        public void actualizarClientes()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE_NUMERO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaClientes = new DataTable();
            adaptador.Fill(tablaClientes);
            dgvClientes.DataSource = tablaClientes;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CLIENTE WHERE CVE_CLIENTE = @clave";
            SqlCommand comando = new SqlCommand(query,conexion);
            comando.Parameters.AddWithValue("@clave", dgvClientes.CurrentRow.Cells["Clave_Cliente"].Value);
            
            if (MessageBox.Show("¿Desea eliminar al cliente seleccionado?", "Eliminar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente Eliminado");
                    actualizarClientes();
                }
                catch (Exception)
                {
                    MessageBox.Show("Este cliente cuenta con proyectos pendientes", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
            }
            else{
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CLIENTE SET nombre = @nombre, apellido_p = @apellidop, apellido_m = @apellidom, teléfono = @telefono, dirección = @direccion, correo = @correo WHERE cve_cliente = @clave";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@nombre", dgvClientes.CurrentRow.Cells["Nombre"].Value);
            comando.Parameters.AddWithValue("@apellidop", dgvClientes.CurrentRow.Cells["Apellido_Paterno"].Value);
            comando.Parameters.AddWithValue("@apellidom", dgvClientes.CurrentRow.Cells["Apellido_Materno"].Value);
            comando.Parameters.AddWithValue("@telefono", dgvClientes.CurrentRow.Cells["Teléfono"].Value);
            comando.Parameters.AddWithValue("@direccion", dgvClientes.CurrentRow.Cells["Dirección"].Value);
            comando.Parameters.AddWithValue("@correo", dgvClientes.CurrentRow.Cells["Correo"].Value);
            comando.Parameters.AddWithValue("@clave", dgvClientes.CurrentRow.Cells["Clave_Cliente"].Value);

            if (MessageBox.Show("¿Desea modificar el cliente seleccionado?", "Modificar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Modificado");
                actualizarClientes();
            }
            else
            {
                actualizarClientes();
            }
        }

        private void cbxModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxModificar.Checked)
            {
                dgvClientes.ReadOnly = false;
            }
            else
            {
                dgvClientes.ReadOnly = true;
            } 
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE_NUMERO", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaClientes = new DataTable();                  
            adaptador.Fill(tablaClientes);
            dgvClientes.DataSource = tablaClientes;
            
            try
            {
                tablaClientes.DefaultView.RowFilter = $"{cbxCliente.Text} LIKE '{txtBuscarCliente.Text}%'";
            }
            catch (Exception)
            { 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}