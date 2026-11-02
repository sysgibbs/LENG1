namespace CRUD_PERSONAS
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            IdLabel = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblNombre = new Label();
            txtCorreo = new TextBox();
            lblApellido = new Label();
            lblCorreo = new Label();
            dgvPersonas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnCreateInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            IdLabel.ForeColor = Color.FromArgb(15, 26, 32);
            IdLabel.Location = new Point(36, 49);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(30, 22);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(252, 250, 249);
            txtId.Location = new Point(36, 79);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 27);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(252, 250, 249);
            txtNombre.Location = new Point(284, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(252, 250, 249);
            txtApellido.Location = new Point(36, 150);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(168, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(15, 26, 32);
            lblNombre.Location = new Point(284, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 22);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            lblNombre.Click += labelNombre_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(252, 250, 249);
            txtCorreo.Location = new Point(284, 150);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(262, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(15, 26, 32);
            lblApellido.Location = new Point(36, 118);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 22);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("JetBrains Mono", 10F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(15, 26, 32);
            lblCorreo.Location = new Point(284, 118);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 22);
            lblCorreo.TabIndex = 7;
            lblCorreo.Text = "Correo";
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.BackgroundColor = Color.FromArgb(158, 173, 200);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(238, 244, 212);
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 52, 121);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(35, 142, 178);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellido, colCorreo });
            dgvPersonas.GridColor = Color.FromArgb(221, 218, 231);
            dgvPersonas.Location = new Point(27, 241);
            dgvPersonas.MultiSelect = false;
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.Size = new Size(832, 174);
            dgvPersonas.TabIndex = 8;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            dgvPersonas.CellContentDoubleClick += dgvPersonas_CellDoubleClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(39, 39, 39);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(159, 193);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 31);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(39, 39, 39);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(36, 193);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 31);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(39, 39, 39);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(284, 193);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(117, 31);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(39, 39, 39);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(408, 193);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(39, 39, 39);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(532, 193);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(117, 31);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BackColor = Color.FromArgb(39, 39, 39);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(655, 193);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(204, 31);
            btnCreateInvoice.TabIndex = 14;
            btnCreateInvoice.Text = "Solicitar equipos";
            btnCreateInvoice.UseVisualStyleBackColor = false;
            btnCreateInvoice.Click += btnCreateInvoice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 224);
            ClientSize = new Size(900, 435);
            Controls.Add(btnCreateInvoice);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvPersonas);
            Controls.Add(lblCorreo);
            Controls.Add(lblApellido);
            Controls.Add(txtCorreo);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(IdLabel);
            Font = new Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Directorio de empleados";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdLabel;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblNombre;
        private TextBox txtCorreo;
        private Label lblApellido;
        private Label lblCorreo;
        private DataGridView dgvPersonas;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colCorreo;
        private Button btnCreateInvoice;
    }
}
