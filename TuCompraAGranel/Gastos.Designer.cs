namespace DonPaulo
{
    partial class Gastos
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
            label1 = new System.Windows.Forms.Label();
            btnNuevo = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            txtDetalle = new System.Windows.Forms.TextBox();
            btnCancelarAgregar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            dtpFecha = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            txtImporte = new System.Windows.Forms.TextBox();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lblDobleClick = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(1, 32, 67);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(423, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            label1.Location = new System.Drawing.Point(414, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 40);
            label1.TabIndex = 1;
            label1.Text = "Gastos\r\n";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Boton;
            btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            btnNuevo.Location = new System.Drawing.Point(438, 89);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(109, 35);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo Pago";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(887, 65);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDetalle);
            panel2.Controls.Add(btnCancelarAgregar);
            panel2.Controls.Add(btnConfirmar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpFecha);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtImporte);
            panel2.Location = new System.Drawing.Point(587, 89);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(288, 262);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(116, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 59;
            label3.Text = "Detalle";
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new System.Drawing.Point(13, 137);
            txtDetalle.Multiline = true;
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new System.Drawing.Size(260, 81);
            txtDetalle.TabIndex = 58;
            // 
            // btnCancelarAgregar
            // 
            btnCancelarAgregar.BackgroundImage = Properties.Resources.Boton_Blanco;
            btnCancelarAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelarAgregar.Location = new System.Drawing.Point(158, 224);
            btnCancelarAgregar.Name = "btnCancelarAgregar";
            btnCancelarAgregar.Size = new System.Drawing.Size(105, 30);
            btnCancelarAgregar.TabIndex = 57;
            btnCancelarAgregar.Text = "Cancelar";
            btnCancelarAgregar.UseVisualStyleBackColor = true;
            btnCancelarAgregar.Click += btnCancelarAgregar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackgroundImage = Properties.Resources.Boton_Blanco;
            btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.Location = new System.Drawing.Point(26, 224);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(98, 30);
            btnConfirmar.TabIndex = 56;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(116, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 55;
            label2.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFecha.Location = new System.Drawing.Point(71, 83);
            dtpFecha.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFecha.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new System.Drawing.Size(142, 23);
            dtpFecha.TabIndex = 54;
            dtpFecha.Value = new System.DateTime(2023, 9, 5, 18, 30, 16, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.Control;
            label5.Location = new System.Drawing.Point(116, 4);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 53;
            label5.Text = "Importe";
            // 
            // txtImporte
            // 
            txtImporte.Location = new System.Drawing.Point(71, 27);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new System.Drawing.Size(142, 23);
            txtImporte.TabIndex = 52;
            txtImporte.KeyPress += txtImporte_KeyPress;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = Properties.Resources.Boton;
            btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            btnModificar.Location = new System.Drawing.Point(438, 130);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(109, 35);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Boton;
            btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            btnEliminar.Location = new System.Drawing.Point(438, 171);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(109, 35);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = Properties.Resources.Boton;
            btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            btnCancelar.Location = new System.Drawing.Point(438, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(109, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDobleClick
            // 
            lblDobleClick.Location = new System.Drawing.Point(441, 209);
            lblDobleClick.Name = "lblDobleClick";
            lblDobleClick.Size = new System.Drawing.Size(130, 62);
            lblDobleClick.TabIndex = 54;
            lblDobleClick.Text = "DOBLE CLICK A UN PAGO PARA ELIMINARLO / MODIFICARLO";
            lblDobleClick.Visible = false;
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.Color.FromArgb(1, 32, 67);
            txtTotal.Location = new System.Drawing.Point(12, 330);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(83, 24);
            txtTotal.TabIndex = 58;
            txtTotal.Text = "TOTAL:";
            // 
            // Gastos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(891, 363);
            Controls.Add(txtTotal);
            Controls.Add(lblDobleClick);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridView1);
            Name = "Gastos";
            Text = "Gastos";
            Load += Gastos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDobleClick;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnCancelarAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImporte;
    }
}