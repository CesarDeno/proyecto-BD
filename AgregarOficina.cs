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
    public partial class AgregarOficina : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public AgregarOficina()
        {
            InitializeComponent();
        }

        private void AgregarOficina_Load(object sender, EventArgs e)
        {

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            tbxClave.Text = "";
            tbxNombre.Text = "";
            tbxDireccion.Text = "";
            tbxTelefono.Text = "";
            tbxZona.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxClave.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Oficina");
            }
            else if (String.IsNullOrEmpty(tbxNombre.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Oficina");
            }
            else if (String.IsNullOrEmpty(tbxDireccion.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Oficina");
            }
            else if (String.IsNullOrEmpty(tbxTelefono.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Oficina");
            }
            else if (String.IsNullOrEmpty(tbxZona.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Oficina");
            }
            else
            {
                try
                {
                    string query = "EXEC AGREGAR_OFICINA @clave, @nombre, @direccion, @telefono, @zona";
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@clave", tbxClave.Text);
                    comando.Parameters.AddWithValue("@nombre", tbxNombre.Text);
                    comando.Parameters.AddWithValue("@direccion", tbxDireccion.Text);
                    comando.Parameters.AddWithValue("@telefono", tbxTelefono.Text);
                    comando.Parameters.AddWithValue("@zona", tbxZona.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Oficina agregada correctamente", "Agregar Oficina");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("La clave coincide con la de otro proyecto", "Agregar Oficina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
               
            }
        }

        private void tbxDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
