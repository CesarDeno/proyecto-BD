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
    public partial class AgregarClientes : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxClaveCliente.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else if (String.IsNullOrEmpty(tbxNCliente.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else if (String.IsNullOrEmpty(tbxApellidoP.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else if (String.IsNullOrEmpty(tbxApellidoM.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else if(String.IsNullOrEmpty(tbxDireccionClien.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else if(String.IsNullOrEmpty(tbxTelefonoClien.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else if(String.IsNullOrEmpty(tbxCorreoClien.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Cliente");
            }
            else
            {
                try
                {
                    string query = "EXEC AGREGAR_CLIENTE @clave, @nombre, @apellidop, @apellidom, @telefono, @direccion, @correo";
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@clave", tbxClaveCliente.Text);
                    comando.Parameters.AddWithValue("@nombre", tbxNCliente.Text);
                    comando.Parameters.AddWithValue("@apellidop", tbxApellidoP.Text);
                    comando.Parameters.AddWithValue("@apellidom", tbxApellidoM.Text);
                    comando.Parameters.AddWithValue("@telefono", tbxTelefonoClien.Text);
                    comando.Parameters.AddWithValue("@direccion", tbxDireccionClien.Text);
                    comando.Parameters.AddWithValue("@correo", tbxCorreoClien.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente insertado correctamente", "Agregar Cliente");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("La clave coincide con la de otro cliente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                
            }
            
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            tbxClaveCliente.Text = "";
            tbxNCliente.Text = "";
            tbxApellidoP.Text = "";
            tbxApellidoM.Text = "";
            tbxDireccionClien.Text = "";
            tbxTelefonoClien.Text = "";
            tbxCorreoClien.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
