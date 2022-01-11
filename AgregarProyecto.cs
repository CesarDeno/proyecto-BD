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
    public partial class AgregarProyecto : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost; database=PROYECTO_BD; integrated security=true");
        public AgregarProyecto()
        {
            InitializeComponent();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            tbxClave.Text = "";
            tbxTipo.Text = "";
            dtpInicio.Text = "";
            dtpFinal.Text = "";
            cbxEncargado.Text = "";
            cbxCliente.Text = "";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProyecto_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
            Cliente f1 = new Cliente();
            cbxCliente.DataSource = f1.pasarDataTable();
            cbxCliente.DisplayMember = "nombre";
            cbxCliente.ValueMember = "cve_cliente";

            Encargado f2 = new Encargado();
            cbxEncargado.DataSource = f2.pasarDataTable();
            cbxEncargado.DisplayMember = "nombre";
            cbxEncargado.ValueMember = "cve_encargado";
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            
            if (String.IsNullOrEmpty(tbxClave.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Proyecto");
            }
            else if (String.IsNullOrEmpty(tbxTipo.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Proyecto");
            }
            else if (String.IsNullOrEmpty(cbxEncargado.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Proyecto");
            }
            else if (String.IsNullOrEmpty(cbxCliente.Text))
            {
                MessageBox.Show("Llene correctamente los campos", "Agregar Proyecto");
            }
            else if (dtpInicio.Value >= dtpFinal.Value)
            {
                MessageBox.Show("La fecha de Inicio no puede ser despues de la Final", "Agregar Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "EXEC AGREGAR_PROYECTO @clave, @tipo, @inicio, @final, @cve_encargado, @cve_cliente";
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@clave", tbxClave.Text);
                    comando.Parameters.AddWithValue("@tipo", tbxTipo.Text);
                    comando.Parameters.AddWithValue("@inicio", dtpInicio.Value);
                    comando.Parameters.AddWithValue("@final", dtpFinal.Value);
                    comando.Parameters.AddWithValue("@cve_encargado", cbxEncargado.SelectedValue);
                    comando.Parameters.AddWithValue("@cve_cliente", cbxCliente.SelectedValue);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Proyecto insertado correctamente", "Agregar Proyecto");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("La clave coincide con la de otro proyecto", "Agregar Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                }
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
