namespace TuCompraAGranel
{
    partial class Factura
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
            label1 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtCantidad = new System.Windows.Forms.TextBox();
            txtSubTotal = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnImprimir = new System.Windows.Forms.Button();
            rdioTransferencia = new System.Windows.Forms.RadioButton();
            rdioEfectivo = new System.Windows.Forms.RadioButton();
            txtTotalaPagar = new System.Windows.Forms.TextBox();
            txtPago = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            labelFecha = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtCodigoBarras = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            btnBusqueda = new System.Windows.Forms.Button();
            txtNombre = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            txtIdProducto = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            lblNroBoleta = new System.Windows.Forms.Label();
            txtVuelto = new System.Windows.Forms.TextBox();
            lblEliminar = new System.Windows.Forms.Label();
            lblModificar = new System.Windows.Forms.Label();
            btnCancelar2 = new System.Windows.Forms.Button();
            rdioTarjeta = new System.Windows.Forms.RadioButton();
            btnBolsa = new System.Windows.Forms.Button();
            btnBidon10 = new System.Windows.Forms.Button();
            btnBidon5 = new System.Windows.Forms.Button();
            rdioBtnPedidos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(19, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 37);
            label1.TabIndex = 0;
            label1.Text = "Venta:";
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            btnModificar.Location = new System.Drawing.Point(135, 310);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(113, 36);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(1, 32, 67);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Nombre, Precio, Cantidad, SubTotal });
            dataGridView1.Location = new System.Drawing.Point(12, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(757, 215);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ID.Width = 43;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SubTotal
            // 
            SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(12, 253);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(104, 23);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new System.Drawing.Point(268, 253);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new System.Drawing.Size(104, 23);
            txtSubTotal.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 235);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(268, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Sub Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(12, 171);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 15);
            label4.TabIndex = 8;
            label4.Text = "Detalle";
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            btnEliminar.Location = new System.Drawing.Point(268, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(113, 36);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            btnCancelar.Location = new System.Drawing.Point(775, 417);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(169, 54);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            btnAgregar.Location = new System.Drawing.Point(12, 310);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(104, 36);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            btnGuardar.Location = new System.Drawing.Point(775, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(169, 47);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnImprimir.ForeColor = System.Drawing.SystemColors.Control;
            btnImprimir.Location = new System.Drawing.Point(398, 310);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(113, 36);
            btnImprimir.TabIndex = 13;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // rdioTransferencia
            // 
            rdioTransferencia.AutoSize = true;
            rdioTransferencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdioTransferencia.Location = new System.Drawing.Point(673, 288);
            rdioTransferencia.Name = "rdioTransferencia";
            rdioTransferencia.Size = new System.Drawing.Size(100, 19);
            rdioTransferencia.TabIndex = 14;
            rdioTransferencia.TabStop = true;
            rdioTransferencia.Text = "Transferencia";
            rdioTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdioEfectivo
            // 
            rdioEfectivo.AutoSize = true;
            rdioEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdioEfectivo.Location = new System.Drawing.Point(570, 288);
            rdioEfectivo.Name = "rdioEfectivo";
            rdioEfectivo.Size = new System.Drawing.Size(71, 19);
            rdioEfectivo.TabIndex = 15;
            rdioEfectivo.TabStop = true;
            rdioEfectivo.Text = "Efectivo";
            rdioEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtTotalaPagar
            // 
            txtTotalaPagar.BackColor = System.Drawing.Color.Black;
            txtTotalaPagar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotalaPagar.ForeColor = System.Drawing.Color.Firebrick;
            txtTotalaPagar.Location = new System.Drawing.Point(570, 103);
            txtTotalaPagar.Name = "txtTotalaPagar";
            txtTotalaPagar.ReadOnly = true;
            txtTotalaPagar.Size = new System.Drawing.Size(203, 34);
            txtTotalaPagar.TabIndex = 17;
            txtTotalaPagar.Text = "$0.00";
            // 
            // txtPago
            // 
            txtPago.Location = new System.Drawing.Point(570, 221);
            txtPago.Name = "txtPago";
            txtPago.Size = new System.Drawing.Size(203, 23);
            txtPago.TabIndex = 19;
            txtPago.TextChanged += txtPago_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(654, 85);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 15);
            label5.TabIndex = 20;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(645, 139);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 15);
            label6.TabIndex = 21;
            label6.Text = "Vuelto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(645, 203);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 15);
            label7.TabIndex = 22;
            label7.Text = "Efectivo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label8.Location = new System.Drawing.Point(441, 29);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 37);
            label8.TabIndex = 23;
            label8.Text = "Fecha";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            labelFecha.Location = new System.Drawing.Point(542, 29);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new System.Drawing.Size(287, 37);
            labelFecha.TabIndex = 24;
            labelFecha.Text = "XXXXXXXXXXXXXXX";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(610, 261);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(98, 15);
            label10.TabIndex = 25;
            label10.Text = "Metodo de Pago";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new System.Drawing.Point(144, 135);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new System.Drawing.Size(104, 23);
            txtCodigoBarras.TabIndex = 26;
            txtCodigoBarras.TextChanged += txtCodigoBarras_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(144, 117);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(95, 15);
            label11.TabIndex = 27;
            label11.Text = "Codigo de Barra";
            // 
            // btnBusqueda
            // 
            btnBusqueda.BackgroundImage = DonPaulo.Properties.Resources.LUPA;
            btnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBusqueda.FlatAppearance.BorderSize = 0;
            btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBusqueda.Location = new System.Drawing.Point(290, 117);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new System.Drawing.Size(66, 59);
            btnBusqueda.TabIndex = 28;
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(12, 189);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new System.Drawing.Size(236, 23);
            txtNombre.TabIndex = 29;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(144, 253);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new System.Drawing.Size(104, 23);
            txtPrecio.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(144, 235);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 15);
            label12.TabIndex = 31;
            label12.Text = "Precio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(12, 117);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(72, 15);
            label13.TabIndex = 33;
            label13.Text = "Id Producto";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new System.Drawing.Point(14, 135);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new System.Drawing.Size(104, 23);
            txtIdProducto.TabIndex = 32;
            txtIdProducto.TextChanged += txtIdProducto_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblNroBoleta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(label8);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(946, 81);
            panel1.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = DonPaulo.Properties.Resources.ayuda_boton;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.Transparent;
            button1.Location = new System.Drawing.Point(835, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(55, 52);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblNroBoleta
            // 
            lblNroBoleta.AutoSize = true;
            lblNroBoleta.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNroBoleta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lblNroBoleta.Location = new System.Drawing.Point(108, 29);
            lblNroBoleta.Name = "lblNroBoleta";
            lblNroBoleta.Size = new System.Drawing.Size(53, 37);
            lblNroBoleta.TabIndex = 25;
            lblNroBoleta.Text = "XX";
            // 
            // txtVuelto
            // 
            txtVuelto.BackColor = System.Drawing.Color.Black;
            txtVuelto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtVuelto.ForeColor = System.Drawing.Color.Lime;
            txtVuelto.Location = new System.Drawing.Point(570, 157);
            txtVuelto.Name = "txtVuelto";
            txtVuelto.ReadOnly = true;
            txtVuelto.Size = new System.Drawing.Size(203, 34);
            txtVuelto.TabIndex = 35;
            txtVuelto.Text = "$0.00";
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lblEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEliminar.ForeColor = System.Drawing.Color.Red;
            lblEliminar.Location = new System.Drawing.Point(268, 193);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new System.Drawing.Size(291, 19);
            lblEliminar.TabIndex = 25;
            lblEliminar.Text = "SELECCIONE UN PRODUCTO PARA ELIMINAR";
            lblEliminar.Visible = false;
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            lblModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblModificar.ForeColor = System.Drawing.Color.ForestGreen;
            lblModificar.Location = new System.Drawing.Point(256, 193);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new System.Drawing.Size(304, 19);
            lblModificar.TabIndex = 36;
            lblModificar.Text = "SELECCIONE UN PRODUCTO PARA MODIFICAR";
            lblModificar.Visible = false;
            // 
            // btnCancelar2
            // 
            btnCancelar2.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnCancelar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelar2.ForeColor = System.Drawing.SystemColors.Control;
            btnCancelar2.Location = new System.Drawing.Point(408, 235);
            btnCancelar2.Name = "btnCancelar2";
            btnCancelar2.Size = new System.Drawing.Size(103, 41);
            btnCancelar2.TabIndex = 37;
            btnCancelar2.Text = "Cancelar";
            btnCancelar2.UseVisualStyleBackColor = true;
            btnCancelar2.Visible = false;
            btnCancelar2.Click += btnCancelar2_Click;
            // 
            // rdioTarjeta
            // 
            rdioTarjeta.AutoSize = true;
            rdioTarjeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdioTarjeta.Location = new System.Drawing.Point(570, 320);
            rdioTarjeta.Name = "rdioTarjeta";
            rdioTarjeta.Size = new System.Drawing.Size(63, 19);
            rdioTarjeta.TabIndex = 38;
            rdioTarjeta.TabStop = true;
            rdioTarjeta.Text = "Tarjeta";
            rdioTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnBolsa
            // 
            btnBolsa.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnBolsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBolsa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBolsa.ForeColor = System.Drawing.SystemColors.Control;
            btnBolsa.Location = new System.Drawing.Point(809, 128);
            btnBolsa.Name = "btnBolsa";
            btnBolsa.Size = new System.Drawing.Size(103, 41);
            btnBolsa.TabIndex = 39;
            btnBolsa.Text = "Bolsa";
            btnBolsa.UseVisualStyleBackColor = true;
            btnBolsa.Click += btnBolsa_Click;
            // 
            // btnBidon10
            // 
            btnBidon10.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnBidon10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBidon10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBidon10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBidon10.ForeColor = System.Drawing.SystemColors.Control;
            btnBidon10.Location = new System.Drawing.Point(809, 181);
            btnBidon10.Name = "btnBidon10";
            btnBidon10.Size = new System.Drawing.Size(103, 41);
            btnBidon10.TabIndex = 40;
            btnBidon10.Text = "Bidon 10L";
            btnBidon10.UseVisualStyleBackColor = true;
            btnBidon10.Click += btnBidon10_Click;
            // 
            // btnBidon5
            // 
            btnBidon5.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnBidon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBidon5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBidon5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBidon5.ForeColor = System.Drawing.SystemColors.Control;
            btnBidon5.Location = new System.Drawing.Point(809, 235);
            btnBidon5.Name = "btnBidon5";
            btnBidon5.Size = new System.Drawing.Size(103, 41);
            btnBidon5.TabIndex = 41;
            btnBidon5.Text = "Bidon 5L";
            btnBidon5.UseVisualStyleBackColor = true;
            btnBidon5.Click += btnBidon5_Click;
            // 
            // rdioBtnPedidos
            // 
            rdioBtnPedidos.AutoSize = true;
            rdioBtnPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdioBtnPedidos.Location = new System.Drawing.Point(673, 320);
            rdioBtnPedidos.Name = "rdioBtnPedidos";
            rdioBtnPedidos.Size = new System.Drawing.Size(63, 19);
            rdioBtnPedidos.TabIndex = 42;
            rdioBtnPedidos.TabStop = true;
            rdioBtnPedidos.Text = "Pedido";
            rdioBtnPedidos.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(946, 580);
            Controls.Add(rdioBtnPedidos);
            Controls.Add(btnBidon5);
            Controls.Add(btnBidon10);
            Controls.Add(btnBolsa);
            Controls.Add(rdioTarjeta);
            Controls.Add(btnCancelar2);
            Controls.Add(lblModificar);
            Controls.Add(lblEliminar);
            Controls.Add(txtVuelto);
            Controls.Add(panel1);
            Controls.Add(label13);
            Controls.Add(txtIdProducto);
            Controls.Add(label12);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(btnBusqueda);
            Controls.Add(label11);
            Controls.Add(txtCodigoBarras);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPago);
            Controls.Add(txtTotalaPagar);
            Controls.Add(rdioEfectivo);
            Controls.Add(rdioTransferencia);
            Controls.Add(btnImprimir);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSubTotal);
            Controls.Add(txtCantidad);
            Controls.Add(dataGridView1);
            Controls.Add(btnModificar);
            Name = "Factura";
            Text = "Factura";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton rdioTransferencia;
        private System.Windows.Forms.RadioButton rdioEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.RadioButton rdioTarjeta;
        private System.Windows.Forms.Label lblNroBoleta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBolsa;
        private System.Windows.Forms.Button btnBidon10;
        private System.Windows.Forms.Button btnBidon5;
        private System.Windows.Forms.RadioButton rdioBtnPedidos;
    }
}