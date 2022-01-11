namespace Proyecto_Base_Datos
{
    partial class Oficina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oficina));
            this.label2 = new System.Windows.Forms.Label();
            this.cbxOficina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarOficina = new System.Windows.Forms.TextBox();
            this.cbxModificar = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvOficina = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficina)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "OFICINAS";
            // 
            // cbxOficina
            // 
            this.cbxOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOficina.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxOficina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxOficina.FormattingEnabled = true;
            this.cbxOficina.Location = new System.Drawing.Point(139, 86);
            this.cbxOficina.Name = "cbxOficina";
            this.cbxOficina.Size = new System.Drawing.Size(159, 25);
            this.cbxOficina.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(304, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar";
            // 
            // txtBuscarOficina
            // 
            this.txtBuscarOficina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarOficina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarOficina.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarOficina.Location = new System.Drawing.Point(372, 87);
            this.txtBuscarOficina.Name = "txtBuscarOficina";
            this.txtBuscarOficina.Size = new System.Drawing.Size(223, 17);
            this.txtBuscarOficina.TabIndex = 19;
            this.txtBuscarOficina.TextChanged += new System.EventHandler(this.txtBuscarOficina_TextChanged);
            // 
            // cbxModificar
            // 
            this.cbxModificar.AutoSize = true;
            this.cbxModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxModificar.Location = new System.Drawing.Point(580, 479);
            this.cbxModificar.Name = "cbxModificar";
            this.cbxModificar.Size = new System.Drawing.Size(15, 14);
            this.cbxModificar.TabIndex = 18;
            this.cbxModificar.UseVisualStyleBackColor = true;
            this.cbxModificar.CheckedChanged += new System.EventHandler(this.cbxModificar_CheckedChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.AllowDrop = true;
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(466, 472);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 33);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(359, 472);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 33);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresar1
            // 
            this.btnRegresar1.BackColor = System.Drawing.Color.White;
            this.btnRegresar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegresar1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegresar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegresar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegresar1.Location = new System.Drawing.Point(35, 472);
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.Size = new System.Drawing.Size(90, 33);
            this.btnRegresar1.TabIndex = 15;
            this.btnRegresar1.Text = "REGRESAR";
            this.btnRegresar1.UseVisualStyleBackColor = false;
            this.btnRegresar1.Click += new System.EventHandler(this.btnRegresar1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnActualizar.Location = new System.Drawing.Point(499, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 33);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(206, 472);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 33);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR OFICINA";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvOficina
            // 
            this.dgvOficina.AllowUserToAddRows = false;
            this.dgvOficina.AllowUserToDeleteRows = false;
            this.dgvOficina.AllowUserToResizeColumns = false;
            this.dgvOficina.AllowUserToResizeRows = false;
            this.dgvOficina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOficina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOficina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOficina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOficina.Location = new System.Drawing.Point(35, 134);
            this.dgvOficina.Name = "dgvOficina";
            this.dgvOficina.ReadOnly = true;
            this.dgvOficina.RowTemplate.Height = 25;
            this.dgvOficina.Size = new System.Drawing.Size(565, 321);
            this.dgvOficina.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ordenar Por";
            // 
            // Oficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxOficina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarOficina);
            this.Controls.Add(this.cbxModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegresar1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvOficina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Oficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oficina";
            this.Load += new System.EventHandler(this.Oficina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOficina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ComboBox cbxOficina;
        private Label label1;
        private TextBox txtBuscarOficina;
        private CheckBox cbxModificar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnRegresar1;
        private Button btnActualizar;
        private Button btnAgregar;
        private DataGridView dgvOficina;
        private Label label3;
    }
}