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
    public partial class AgregarEncargado : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public AgregarEncargado()
        {
            InitializeComponent();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            tbxClave.Text = "";
            tbxNombre.Text = "";
            tbxApellidoM.Text = "";
            tbxApellidoP.Text = "";
            tbxTelefono.Text = "";
            tbxCorreo.Text = "";
            cbxOficina.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxClave.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else if (String.IsNullOrEmpty(tbxNombre.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else if (String.IsNullOrEmpty(tbxApellidoM.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else if (String.IsNullOrEmpty(tbxApellidoP.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else if (String.IsNullOrEmpty(tbxTelefono.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else if (String.IsNullOrEmpty(tbxCorreo.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else if (String.IsNullOrEmpty(cbxOficina.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Encargado");
            }
            else
            {
                try
                {
                    string query = "EXEC AGREGAR_ENCARGADO @clave, @nombre, @apellidop, @apellidom, @telefono, @correo, @cve_oficina";
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@clave", tbxClave.Text);
                    comando.Parameters.AddWithValue("@nombre", tbxNombre.Text);
                    comando.Parameters.AddWithValue("@apellidop", tbxApellidoP.Text);
                    comando.Parameters.AddWithValue("@apellidom", tbxApellidoM.Text);
                    comando.Parameters.AddWithValue("@telefono", tbxTelefono.Text);
                    comando.Parameters.AddWithValue("@correo", tbxCorreo.Text);
                    comando.Parameters.AddWithValue("@cve_oficina", cbxOficina.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Encargado insertado correctamente", "Agregar Encargado");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("La clave coincide con la de otro ENCARGADO", "Agregar Encargado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
            }
        }

        private void AgregarEncargado_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
            Oficina f1 = new Oficina();
            cbxOficina.DataSource = f1.pasarDataTable();
            cbxOficina.DisplayMember = "nombre";
            cbxOficina.ValueMember = "Clave_Oficina";
        }

        private void cbxOficina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
