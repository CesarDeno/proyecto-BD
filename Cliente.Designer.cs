namespace Proyecto_Base_Datos
{
    partial class Cliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar1 = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbxModificar = new System.Windows.Forms.CheckBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvClientes, "dgvClientes");
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 25;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnAgregarCliente, "btnAgregarCliente");
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnActualizar, "btnActualizar");
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegresar1
            // 
            resources.ApplyResources(this.btnRegresar1, "btnRegresar1");
            this.btnRegresar1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.UseVisualStyleBackColor = true;
            this.btnRegresar1.Click += new System.EventHandler(this.btnRegresar1_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnEliminarCliente, "btnEliminarCliente");
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AllowDrop = true;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxModificar
            // 
            resources.ApplyResources(this.cbxModificar, "cbxModificar");
            this.cbxModificar.Name = "cbxModificar";
            this.cbxModificar.UseVisualStyleBackColor = true;
            this.cbxModificar.CheckedChanged += new System.EventHandler(this.cbxModificar_CheckedChanged);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtBuscarCliente, "txtBuscarCliente");
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // cbxCliente
            // 
            resources.ApplyResources(this.cbxCliente, "cbxCliente");
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.cbxModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnRegresar1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Load += new System.EventHandler(this.formCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnAgregarCliente;
        private Button btnActualizar;
        private Button btnRegresar1;
        private Button btnEliminarCliente;
        private Button btnModificar;
        private CheckBox cbxModificar;
        private TextBox txtBuscarCliente;
        private Label label1;
        private ComboBox cbxCliente;
        private Label label2;
        private Label label3;
    }
}