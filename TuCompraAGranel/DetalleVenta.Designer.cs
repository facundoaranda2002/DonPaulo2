namespace DonPaulo
{
    partial class DetalleVenta
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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btn_Cancelar = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(1, 32, 67);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(799, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(262, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 31);
            label1.TabIndex = 28;
            label1.Text = "Datos de la Factura";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.AccessibleName = "doc";
            btn_Cancelar.BackgroundImage = Properties.Resources.Boton;
            btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            btn_Cancelar.Location = new System.Drawing.Point(8, 334);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new System.Drawing.Size(221, 68);
            btn_Cancelar.TabIndex = 30;
            btn_Cancelar.Text = "Eliminar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(1, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(799, 234);
            dataGridView1.TabIndex = 31;
            // 
            // DetalleVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 416);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Cancelar);
            Controls.Add(panel1);
            Name = "DetalleVenta";
            Text = "Form1";
            Load += DetalleVenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}