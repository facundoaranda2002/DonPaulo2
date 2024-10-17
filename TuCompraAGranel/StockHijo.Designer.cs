namespace DonPaulo
{
    partial class StockHijo
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
            panel2 = new System.Windows.Forms.Panel();
            btnCancelar = new System.Windows.Forms.Button();
            btnRestar = new System.Windows.Forms.Button();
            btnSuma = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lblContraseña = new System.Windows.Forms.Label();
            txtCantidad = new System.Windows.Forms.TextBox();
            txtContraseña = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            lblExistente = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(249, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(29, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(194, 28);
            label1.TabIndex = 1;
            label1.Text = "Modificar Cantidad";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnRestar);
            panel2.Controls.Add(btnSuma);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 256);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(249, 147);
            panel2.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            btnCancelar.Location = new System.Drawing.Point(0, 97);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(249, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Dock = System.Windows.Forms.DockStyle.Top;
            btnRestar.Location = new System.Drawing.Point(0, 51);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new System.Drawing.Size(249, 46);
            btnRestar.TabIndex = 2;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSuma
            // 
            btnSuma.Dock = System.Windows.Forms.DockStyle.Top;
            btnSuma.Location = new System.Drawing.Point(0, 0);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new System.Drawing.Size(249, 51);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(90, 151);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new System.Drawing.Point(90, 205);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new System.Drawing.Size(67, 15);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Visible = false;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(0, 169);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(249, 23);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtCantidad.KeyPress += textBox1_KeyPress;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new System.Drawing.Point(0, 223);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new System.Drawing.Size(249, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblExistente);
            panel3.Controls.Add(lblNombre);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 72);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(249, 72);
            panel3.TabIndex = 2;
            // 
            // lblExistente
            // 
            lblExistente.Dock = System.Windows.Forms.DockStyle.Top;
            lblExistente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblExistente.Location = new System.Drawing.Point(0, 34);
            lblExistente.Name = "lblExistente";
            lblExistente.Size = new System.Drawing.Size(249, 34);
            lblExistente.TabIndex = 1;
            lblExistente.Text = "Cantidad";
            lblExistente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(249, 34);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label3";
            lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockHijo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(249, 403);
            Controls.Add(panel3);
            Controls.Add(txtContraseña);
            Controls.Add(txtCantidad);
            Controls.Add(lblContraseña);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StockHijo";
            Text = "Form1";
            Load += StockHijo_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblExistente;
    }
}