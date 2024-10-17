
namespace TuCompraAGranel
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnProductos = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnProveedores = new System.Windows.Forms.Button();
            btnGastos = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnCaja = new System.Windows.Forms.Button();
            btnFactura = new System.Windows.Forms.Button();
            btnStock = new System.Windows.Forms.Button();
            lblTituloEfectivo = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel4 = new System.Windows.Forms.Panel();
            numTarjeta = new System.Windows.Forms.Label();
            Pedidos = new System.Windows.Forms.Label();
            txtPedidos = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            numEfectivo = new System.Windows.Forms.Label();
            numTotal = new System.Windows.Forms.Label();
            numTransferencia = new System.Windows.Forms.Label();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            txtFecha = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre, Proveedor, Cantidad, Categoria, Estado, Id });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridView1.Location = new System.Drawing.Point(475, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new System.Drawing.Size(439, 368);
            dataGridView1.TabIndex = 32;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Nombre.Width = 285;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            Proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Proveedor.Visible = false;
            Proveedor.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Categoria.Visible = false;
            Categoria.Width = 125;
            // 
            // Estado
            // 
            Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // btnProductos
            // 
            btnProductos.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnProductos.Location = new System.Drawing.Point(0, 34);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new System.Drawing.Size(363, 38);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel1.Controls.Add(btnProveedores);
            panel1.Controls.Add(btnGastos);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCaja);
            panel1.Controls.Add(btnFactura);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnStock);
            panel1.Location = new System.Drawing.Point(28, 262);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(363, 348);
            panel1.TabIndex = 2;
            // 
            // btnProveedores
            // 
            btnProveedores.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnProveedores.ForeColor = System.Drawing.SystemColors.Control;
            btnProveedores.Location = new System.Drawing.Point(0, 207);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new System.Drawing.Size(363, 35);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = " Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnGastos
            // 
            btnGastos.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGastos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGastos.ForeColor = System.Drawing.SystemColors.Control;
            btnGastos.Location = new System.Drawing.Point(0, 170);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new System.Drawing.Size(363, 37);
            btnGastos.TabIndex = 7;
            btnGastos.Text = "Gastos";
            btnGastos.UseVisualStyleBackColor = true;
            btnGastos.Click += btnGastos_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(0, 135);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(363, 35);
            button1.TabIndex = 9;
            button1.Text = "Registro Ventas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnCaja
            // 
            btnCaja.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCaja.Dock = System.Windows.Forms.DockStyle.Top;
            btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCaja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCaja.ForeColor = System.Drawing.SystemColors.Control;
            btnCaja.Location = new System.Drawing.Point(0, 102);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new System.Drawing.Size(363, 33);
            btnCaja.TabIndex = 5;
            btnCaja.Text = "Caja";
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnFactura.ForeColor = System.Drawing.SystemColors.Control;
            btnFactura.Location = new System.Drawing.Point(0, 72);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new System.Drawing.Size(363, 30);
            btnFactura.TabIndex = 1;
            btnFactura.Text = "  Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnStock
            // 
            btnStock.BackgroundImage = DonPaulo.Properties.Resources.Boton;
            btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnStock.ForeColor = System.Drawing.SystemColors.Control;
            btnStock.Location = new System.Drawing.Point(0, 0);
            btnStock.Name = "btnStock";
            btnStock.Size = new System.Drawing.Size(363, 34);
            btnStock.TabIndex = 2;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // lblTituloEfectivo
            // 
            lblTituloEfectivo.AutoSize = true;
            lblTituloEfectivo.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloEfectivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblTituloEfectivo.Location = new System.Drawing.Point(320, 14);
            lblTituloEfectivo.Name = "lblTituloEfectivo";
            lblTituloEfectivo.Size = new System.Drawing.Size(132, 36);
            lblTituloEfectivo.TabIndex = 3;
            lblTituloEfectivo.Text = "Efectivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(32, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 36);
            label1.TabIndex = 4;
            label1.Text = "Transfer:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            label2.Location = new System.Drawing.Point(321, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 36);
            label2.TabIndex = 5;
            label2.Text = "Tarjetas:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1008, 216);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel4
            // 
            panel4.Controls.Add(numTarjeta);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(Pedidos);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtPedidos);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lblTituloEfectivo);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(numEfectivo);
            panel4.Controls.Add(numTotal);
            panel4.Controls.Add(numTransferencia);
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(369, 19);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(636, 194);
            panel4.TabIndex = 18;
            // 
            // numTarjeta
            // 
            numTarjeta.AutoSize = true;
            numTarjeta.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numTarjeta.ForeColor = System.Drawing.Color.WhiteSmoke;
            numTarjeta.Location = new System.Drawing.Point(458, 61);
            numTarjeta.Name = "numTarjeta";
            numTarjeta.Size = new System.Drawing.Size(129, 36);
            numTarjeta.TabIndex = 9;
            numTarjeta.Text = "XXXXXX";
            // 
            // Pedidos
            // 
            Pedidos.AutoSize = true;
            Pedidos.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Pedidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            Pedidos.Location = new System.Drawing.Point(37, 62);
            Pedidos.Name = "Pedidos";
            Pedidos.Size = new System.Drawing.Size(132, 36);
            Pedidos.TabIndex = 16;
            Pedidos.Text = "Pedidos:";
            // 
            // txtPedidos
            // 
            txtPedidos.AutoSize = true;
            txtPedidos.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtPedidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            txtPedidos.Location = new System.Drawing.Point(174, 61);
            txtPedidos.Name = "txtPedidos";
            txtPedidos.Size = new System.Drawing.Size(129, 36);
            txtPedidos.TabIndex = 17;
            txtPedidos.Text = "XXXXXX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.MintCream;
            label3.Location = new System.Drawing.Point(96, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(418, 52);
            label3.TabIndex = 15;
            label3.Text = "______________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            label9.Location = new System.Drawing.Point(147, 114);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(136, 52);
            label9.TabIndex = 12;
            label9.Text = "Total:";
            // 
            // numEfectivo
            // 
            numEfectivo.AutoSize = true;
            numEfectivo.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numEfectivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            numEfectivo.Location = new System.Drawing.Point(457, 14);
            numEfectivo.Name = "numEfectivo";
            numEfectivo.Size = new System.Drawing.Size(129, 36);
            numEfectivo.TabIndex = 7;
            numEfectivo.Text = "XXXXXX";
            // 
            // numTotal
            // 
            numTotal.AutoSize = true;
            numTotal.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            numTotal.Location = new System.Drawing.Point(275, 114);
            numTotal.Name = "numTotal";
            numTotal.Size = new System.Drawing.Size(190, 52);
            numTotal.TabIndex = 13;
            numTotal.Text = "XXXXXX";
            // 
            // numTransferencia
            // 
            numTransferencia.AutoSize = true;
            numTransferencia.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numTransferencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            numTransferencia.Location = new System.Drawing.Point(174, 14);
            numTransferencia.Name = "numTransferencia";
            numTransferencia.Size = new System.Drawing.Size(129, 36);
            numTransferencia.TabIndex = 8;
            numTransferencia.Text = "XXXXXX";
            numTransferencia.Click += numTransferencia_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = DonPaulo.Properties.Resources.logo_removebg_preview;
            pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox7.ErrorImage = DonPaulo.Properties.Resources.logo_removebg_preview;
            pictureBox7.Location = new System.Drawing.Point(28, 41);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(335, 87);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // txtFecha
            // 
            txtFecha.AutoSize = true;
            txtFecha.Font = new System.Drawing.Font("Microsoft YaHei Light", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtFecha.ForeColor = System.Drawing.Color.MintCream;
            txtFecha.Location = new System.Drawing.Point(28, 0);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new System.Drawing.Size(147, 52);
            txtFecha.TabIndex = 14;
            txtFecha.Text = "FECHA";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel3.Controls.Add(txtFecha);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 672);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1008, 57);
            panel3.TabIndex = 33;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1008, 729);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Menu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label lblTituloEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label numTarjeta;
        private System.Windows.Forms.Label numEfectivo;
        private System.Windows.Forms.Label numTransferencia;
        private System.Windows.Forms.Label numTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Pedidos;
        private System.Windows.Forms.Label txtPedidos;
        private System.Windows.Forms.Panel panel4;
    }
}