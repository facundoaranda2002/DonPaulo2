namespace DonPaulo
{
    partial class Proveedores
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
            btnEliminar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            btnConfirmar = new System.Windows.Forms.Button();
            lblDobleClick = new System.Windows.Forms.Label();
            btnCancelarEliminar = new System.Windows.Forms.Button();
            btnCancelarAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(466, 278);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(12, 296);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(151, 51);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Proveedor";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button1_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(169, 297);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(157, 50);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Agregar Proveedor";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btn_Nuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(332, 297);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(146, 50);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar Proveedor";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(53, 376);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(54, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(113, 373);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(210, 23);
            txtNombre.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(332, 358);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(89, 23);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblDobleClick
            // 
            lblDobleClick.AutoSize = true;
            lblDobleClick.Location = new System.Drawing.Point(120, 297);
            lblDobleClick.Name = "lblDobleClick";
            lblDobleClick.Size = new System.Drawing.Size(281, 15);
            lblDobleClick.TabIndex = 13;
            lblDobleClick.Text = "DOBLE CLICK A UN PROVEEDOR PARA ELIMINARLO";
            lblDobleClick.Visible = false;
            // 
            // btnCancelarEliminar
            // 
            btnCancelarEliminar.Location = new System.Drawing.Point(205, 314);
            btnCancelarEliminar.Name = "btnCancelarEliminar";
            btnCancelarEliminar.Size = new System.Drawing.Size(87, 33);
            btnCancelarEliminar.TabIndex = 14;
            btnCancelarEliminar.Text = "Cancelar";
            btnCancelarEliminar.UseVisualStyleBackColor = true;
            btnCancelarEliminar.Visible = false;
            btnCancelarEliminar.Click += btnCancelarEliminar_Click;
            // 
            // btnCancelarAgregar
            // 
            btnCancelarAgregar.Location = new System.Drawing.Point(332, 387);
            btnCancelarAgregar.Name = "btnCancelarAgregar";
            btnCancelarAgregar.Size = new System.Drawing.Size(89, 23);
            btnCancelarAgregar.TabIndex = 15;
            btnCancelarAgregar.Text = "Cancelar";
            btnCancelarAgregar.UseVisualStyleBackColor = true;
            btnCancelarAgregar.Click += btnCancelarAgregar_Click;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(483, 353);
            Controls.Add(btnCancelarAgregar);
            Controls.Add(btnCancelarEliminar);
            Controls.Add(lblDobleClick);
            Controls.Add(btnConfirmar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblDobleClick;
        private System.Windows.Forms.Button btnCancelarEliminar;
        private System.Windows.Forms.Button btnCancelarAgregar;
    }
}