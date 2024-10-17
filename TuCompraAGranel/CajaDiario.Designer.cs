namespace DonPaulo
{
    partial class CajaDiario
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
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPagoProveedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblMes = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            txtProveedores = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtGastos = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtFacturacion = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtGanancia = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            cmbMes = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(1, 32, 67);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Fecha, TotalVentas, TotalGasto, TotalPagoProveedores });
            dataGridView1.Location = new System.Drawing.Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(788, 361);
            dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotalVentas
            // 
            TotalVentas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TotalVentas.HeaderText = "TotalVentas";
            TotalVentas.Name = "TotalVentas";
            TotalVentas.ReadOnly = true;
            // 
            // TotalGasto
            // 
            TotalGasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TotalGasto.HeaderText = "TotalGasto";
            TotalGasto.Name = "TotalGasto";
            TotalGasto.ReadOnly = true;
            // 
            // TotalPagoProveedores
            // 
            TotalPagoProveedores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            TotalPagoProveedores.HeaderText = "TotalPagoProveedores";
            TotalPagoProveedores.Name = "TotalPagoProveedores";
            TotalPagoProveedores.ReadOnly = true;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMes.ForeColor = System.Drawing.SystemColors.Control;
            lblMes.Location = new System.Drawing.Point(12, 18);
            lblMes.Name = "lblMes";
            lblMes.Size = new System.Drawing.Size(85, 45);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel1.Controls.Add(lblMes);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1110, 79);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel2.Controls.Add(txtProveedores);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtGastos);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFacturacion);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtGanancia);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Location = new System.Drawing.Point(822, 135);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(276, 292);
            panel2.TabIndex = 3;
            // 
            // txtProveedores
            // 
            txtProveedores.AutoSize = true;
            txtProveedores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            txtProveedores.Location = new System.Drawing.Point(129, 169);
            txtProveedores.Name = "txtProveedores";
            txtProveedores.Size = new System.Drawing.Size(100, 25);
            txtProveedores.TabIndex = 10;
            txtProveedores.Text = "xxxxxxxx";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label7.Location = new System.Drawing.Point(3, 169);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(129, 25);
            label7.TabIndex = 9;
            label7.Text = "proveedores:";
            // 
            // txtGastos
            // 
            txtGastos.AutoSize = true;
            txtGastos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtGastos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            txtGastos.Location = new System.Drawing.Point(129, 108);
            txtGastos.Name = "txtGastos";
            txtGastos.Size = new System.Drawing.Size(100, 25);
            txtGastos.TabIndex = 8;
            txtGastos.Text = "xxxxxxxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label5.Location = new System.Drawing.Point(3, 108);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 25);
            label5.TabIndex = 7;
            label5.Text = "Gastos:";
            // 
            // txtFacturacion
            // 
            txtFacturacion.AutoSize = true;
            txtFacturacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtFacturacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            txtFacturacion.Location = new System.Drawing.Point(129, 47);
            txtFacturacion.Name = "txtFacturacion";
            txtFacturacion.Size = new System.Drawing.Size(100, 25);
            txtFacturacion.TabIndex = 6;
            txtFacturacion.Text = "xxxxxxxx";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(2, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 25);
            label2.TabIndex = 5;
            label2.Text = "Facturado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label6.Location = new System.Drawing.Point(-16, 118);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(325, 37);
            label6.TabIndex = 15;
            label6.Text = "____________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(-16, -7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(325, 37);
            label3.TabIndex = 13;
            label3.Text = "____________________________";
            // 
            // txtGanancia
            // 
            txtGanancia.AutoSize = true;
            txtGanancia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtGanancia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            txtGanancia.Location = new System.Drawing.Point(123, 236);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new System.Drawing.Size(100, 28);
            txtGanancia.TabIndex = 12;
            txtGanancia.Text = "xxxxxxxx";
            txtGanancia.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label9.Location = new System.Drawing.Point(3, 236);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(126, 32);
            label9.TabIndex = 11;
            label9.Text = "Ganancia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label4.Location = new System.Drawing.Point(-16, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(325, 37);
            label4.TabIndex = 14;
            label4.Text = "____________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label8.Location = new System.Drawing.Point(-16, 180);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(325, 37);
            label8.TabIndex = 16;
            label8.Text = "____________________________";
            // 
            // cmbMes
            // 
            cmbMes.FormattingEnabled = true;
            cmbMes.Location = new System.Drawing.Point(883, 105);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new System.Drawing.Size(147, 23);
            cmbMes.TabIndex = 0;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(897, 82);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 20);
            label1.TabIndex = 4;
            label1.Text = "Filtrar por mes";
            // 
            // CajaDiario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1110, 451);
            Controls.Add(cmbMes);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "CajaDiario";
            Text = "CajaDiario";
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
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPagoProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtGanancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtProveedores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtGastos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtFacturacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}