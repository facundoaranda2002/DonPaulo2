namespace DonPaulo
{
    partial class Proveedores_Pagos
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            cmbProveedor = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            btnModificarPago = new System.Windows.Forms.Button();
            btnAltaPago = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtImporte = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            cmbProveedorPago = new System.Windows.Forms.ComboBox();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            btnCancelarAgregar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnCancelarEliminar = new System.Windows.Forms.Button();
            lblDobleClick = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            txtTotal = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(1, 32, 67);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(466, 278);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new System.Drawing.Point(283, 322);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new System.Drawing.Size(142, 23);
            cmbProveedor.TabIndex = 41;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(283, 304);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(115, 15);
            label3.TabIndex = 40;
            label3.Text = "Filtrar Por Proveedor";
            // 
            // btnModificarPago
            // 
            btnModificarPago.BackgroundImage = Properties.Resources.Boton;
            btnModificarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnModificarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModificarPago.ForeColor = System.Drawing.SystemColors.Control;
            btnModificarPago.Location = new System.Drawing.Point(484, 68);
            btnModificarPago.Name = "btnModificarPago";
            btnModificarPago.Size = new System.Drawing.Size(146, 50);
            btnModificarPago.TabIndex = 42;
            btnModificarPago.Text = "Modificar Pago";
            btnModificarPago.UseVisualStyleBackColor = true;
            btnModificarPago.Click += btnModificarPago_Click;
            // 
            // btnAltaPago
            // 
            btnAltaPago.BackgroundImage = Properties.Resources.Boton;
            btnAltaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAltaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAltaPago.ForeColor = System.Drawing.SystemColors.Control;
            btnAltaPago.Location = new System.Drawing.Point(484, 12);
            btnAltaPago.Name = "btnAltaPago";
            btnAltaPago.Size = new System.Drawing.Size(146, 50);
            btnAltaPago.TabIndex = 43;
            btnAltaPago.Text = "Nuevo Pago";
            btnAltaPago.UseVisualStyleBackColor = true;
            btnAltaPago.Click += btnAltaPago_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(98, 87);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 17);
            label5.TabIndex = 45;
            label5.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Location = new System.Drawing.Point(54, 111);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new System.Drawing.Size(142, 23);
            txtImporte.TabIndex = 44;
            txtImporte.KeyPress += txtImporte_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(91, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 17);
            label1.TabIndex = 46;
            label1.Text = "Proveedor";
            // 
            // cmbProveedorPago
            // 
            cmbProveedorPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProveedorPago.FormattingEnabled = true;
            cmbProveedorPago.Location = new System.Drawing.Point(54, 56);
            cmbProveedorPago.Name = "cmbProveedorPago";
            cmbProveedorPago.Size = new System.Drawing.Size(142, 23);
            cmbProveedorPago.TabIndex = 47;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFecha.Location = new System.Drawing.Point(54, 170);
            dtpFecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(142, 23);
            dtpFecha.TabIndex = 48;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(103, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 17);
            label2.TabIndex = 49;
            label2.Text = "Fecha";
            // 
            // btnCancelarAgregar
            // 
            btnCancelarAgregar.BackgroundImage = Properties.Resources.Boton;
            btnCancelarAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelarAgregar.ForeColor = System.Drawing.SystemColors.Control;
            btnCancelarAgregar.Location = new System.Drawing.Point(138, 213);
            btnCancelarAgregar.Name = "btnCancelarAgregar";
            btnCancelarAgregar.Size = new System.Drawing.Size(98, 33);
            btnCancelarAgregar.TabIndex = 51;
            btnCancelarAgregar.Text = "Cancelar";
            btnCancelarAgregar.UseVisualStyleBackColor = true;
            btnCancelarAgregar.Click += btnCancelarAgregar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackgroundImage = Properties.Resources.Boton;
            btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            btnConfirmar.Location = new System.Drawing.Point(14, 213);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(95, 33);
            btnConfirmar.TabIndex = 50;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtImporte);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbProveedorPago);
            panel1.Controls.Add(btnCancelarAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnConfirmar);
            panel1.Location = new System.Drawing.Point(645, 29);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(250, 278);
            panel1.TabIndex = 52;
            // 
            // btnCancelarEliminar
            // 
            btnCancelarEliminar.BackgroundImage = Properties.Resources.Boton;
            btnCancelarEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelarEliminar.ForeColor = System.Drawing.SystemColors.Control;
            btnCancelarEliminar.Location = new System.Drawing.Point(484, 240);
            btnCancelarEliminar.Name = "btnCancelarEliminar";
            btnCancelarEliminar.Size = new System.Drawing.Size(87, 33);
            btnCancelarEliminar.TabIndex = 54;
            btnCancelarEliminar.Text = "Cancelar";
            btnCancelarEliminar.UseVisualStyleBackColor = true;
            btnCancelarEliminar.Visible = false;
            btnCancelarEliminar.Click += btnCancelarEliminar_Click;
            // 
            // lblDobleClick
            // 
            lblDobleClick.Location = new System.Drawing.Point(484, 188);
            lblDobleClick.Name = "lblDobleClick";
            lblDobleClick.Size = new System.Drawing.Size(109, 49);
            lblDobleClick.TabIndex = 53;
            lblDobleClick.Text = "DOBLE CLICK A UN PROVEEDOR PARA ELIMINARLO";
            lblDobleClick.Visible = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Boton;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(484, 126);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(146, 50);
            button1.TabIndex = 55;
            button1.Text = "Eliminar Pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.Color.FromArgb(1, 32, 67);
            txtTotal.Location = new System.Drawing.Point(12, 315);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(61, 18);
            txtTotal.TabIndex = 57;
            txtTotal.Text = "TOTAL:";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Boton;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.Control;
            button2.Location = new System.Drawing.Point(484, 308);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(139, 32);
            button2.TabIndex = 58;
            button2.Text = "Editar Proveedores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Proveedores_Pagos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(907, 353);
            Controls.Add(button2);
            Controls.Add(txtTotal);
            Controls.Add(button1);
            Controls.Add(btnCancelarEliminar);
            Controls.Add(lblDobleClick);
            Controls.Add(btnAltaPago);
            Controls.Add(btnModificarPago);
            Controls.Add(cmbProveedor);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Proveedores_Pagos";
            Text = "Pagos";
            Load += Proveedores_Pagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarPago;
        private System.Windows.Forms.Button btnAltaPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedorPago;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelarEliminar;
        private System.Windows.Forms.Label lblDobleClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button button2;
    }
}