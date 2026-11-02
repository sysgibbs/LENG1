namespace CRUD_PERSONAS
{
    partial class FormInvoice
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
            components = new System.ComponentModel.Container();
            cmbProducts = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtQuantity = new TextBox();
            btnAdd = new Button();
            dgvCart = new DataGridView();
            lblTotal = new Label();
            btnPrintTxt = new Button();
            label1 = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            label2 = new Label();
            btnPrintPdf = new Button();
            label3 = new Label();
            cmbEmployee = new ComboBox();
            Cliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // cmbProducts
            // 
            cmbProducts.BackColor = Color.FromArgb(252, 250, 249);
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(164, 126);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(179, 27);
            cmbProducts.Sorted = true;
            cmbProducts.TabIndex = 0;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(252, 250, 249);
            txtQuantity.Location = new Point(97, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(61, 27);
            txtQuantity.TabIndex = 2;
            txtQuantity.Text = "1";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 39, 39);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageAlign = ContentAlignment.TopCenter;
            btnAdd.Location = new Point(12, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(332, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Solicitar equipos";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.BackgroundColor = Color.FromArgb(158, 173, 200);
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.GridColor = Color.FromArgb(221, 218, 231);
            dgvCart.Location = new Point(371, 31);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(1305, 562);
            dgvCart.TabIndex = 4;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(39, 39, 39);
            lblTotal.ForeColor = Color.FromArgb(252, 250, 249);
            lblTotal.Location = new Point(1541, 560);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(117, 19);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: $0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            lblTotal.Click += lblTotal_Click;
            // 
            // btnPrintTxt
            // 
            btnPrintTxt.BackColor = Color.FromArgb(39, 39, 39);
            btnPrintTxt.ForeColor = Color.White;
            btnPrintTxt.Location = new Point(12, 216);
            btnPrintTxt.Name = "btnPrintTxt";
            btnPrintTxt.Size = new Size(163, 42);
            btnPrintTxt.TabIndex = 6;
            btnPrintTxt.Text = "Guardar como TXT";
            btnPrintTxt.UseVisualStyleBackColor = false;
            btnPrintTxt.Click += btnSaveInvoice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 129);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 9;
            label1.Text = "Cantidad";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // btnPrintPdf
            // 
            btnPrintPdf.BackColor = Color.FromArgb(39, 39, 39);
            btnPrintPdf.ForeColor = Color.White;
            btnPrintPdf.Location = new Point(181, 216);
            btnPrintPdf.Name = "btnPrintPdf";
            btnPrintPdf.Size = new Size(163, 42);
            btnPrintPdf.TabIndex = 12;
            btnPrintPdf.Text = "Guardar como PDF";
            btnPrintPdf.UseVisualStyleBackColor = false;
            btnPrintPdf.Click += btnPrintPdf_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 19.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 31);
            label3.Name = "label3";
            label3.Size = new Size(342, 43);
            label3.TabIndex = 13;
            label3.Text = "Solicitud Equipos";
            label3.Click += label3_Click;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(99, 86);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(245, 27);
            cmbEmployee.TabIndex = 14;
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(12, 89);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(81, 19);
            Cliente.TabIndex = 7;
            Cliente.Text = "Empleado";
            Cliente.Click += label1_Click;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 224);
            ClientSize = new Size(1699, 605);
            Controls.Add(cmbEmployee);
            Controls.Add(label3);
            Controls.Add(btnPrintPdf);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cliente);
            Controls.Add(btnPrintTxt);
            Controls.Add(lblTotal);
            Controls.Add(dgvCart);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(cmbProducts);
            Font = new Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormInvoice";
            Text = "Gestion de equipos";
            Load += FormInvoice_Load;
            KeyDown += FormInvoice_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducts;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtQuantity;
        private Button btnAdd;
        private DataGridView dgvCart;
        private Label lblTotal;
        private Button btnPrintTxt;
        private Label label1;
        private ContextMenuStrip contextMenuStrip2;
        private Label label2;
        private Button btnPrintPdf;
        private Label label3;
        private ComboBox cmbEmployee;
        private Label Cliente;
    }
}