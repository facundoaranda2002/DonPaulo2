using ClassLibrary1;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPaulo
{
    public partial class Gastos : Form
    {
        Cgastos gm = new Cgastos();
        conexion Enlace = new conexion();
        int guia = 0;
        public Gastos()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            this.Size = new Size(576, 402);
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            cargargrid();
        }
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si el valor de la celda es numérico
            if (dataGridView1.Columns[e.ColumnIndex].ValueType == typeof(double) || dataGridView1.Columns[e.ColumnIndex].ValueType == typeof(decimal))
            {
                // Aplicar formato de dos decimales después de la coma
                try
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("0.00");
                    e.FormattingApplied = true;
                }
                catch (Exception)
                {

                }
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            guia = 0;
            this.Size = new Size(576, 402);
            btnCancelar.Visible = false;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnNuevo.Visible = true;

            txtDetalle.Text = string.Empty;
            txtImporte.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            guia = 1;
            this.Size = new Size(903, 402);
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            guia = 2;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            btnNuevo.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            guia = 3;
            btnCancelar.Visible = true;
            btnModificar.Visible = false;
            btnNuevo.Visible = false;
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número ni una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento para evitar que se ingrese el carácter no deseado
                e.Handled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cgastos cgastos = new Cgastos();
            if (txtImporte.Text != "" && txtDetalle.Text != "")
            {

                switch (guia)
                {
                    case 1:

                        cgastos.Monto = Convert.ToSingle(txtImporte.Text);
                        cgastos.Fecha = dtpFecha.Text;
                        cgastos.Detalle = txtDetalle.Text;
                        Enlace.Guardargasto(cgastos);
                        break;
                    case 2:

                        gm.Monto = Convert.ToSingle(txtImporte.Text);
                        gm.Fecha = dtpFecha.Text;
                        gm.Detalle = txtDetalle.Text;
                        Enlace.ModificarGasto(gm);
                        break;
                }

                guia = 0;

                this.Size = new Size(576, 402);
                btnCancelar.Visible = false;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btnNuevo.Visible = true;

                txtDetalle.Text = string.Empty;
                txtImporte.Text = string.Empty;
                cargargrid();
            }
            else
            {
                MessageBox.Show("No completo todos los campos");
            }
        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            guia = 0;
            this.Size = new Size(576, 402);
            btnCancelar.Visible = false;
            btnEliminar.Visible = true;
            btnModificar.Visible = true;
            btnNuevo.Visible = true;

            txtDetalle.Text = string.Empty;
            txtImporte.Text = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            switch (guia)
            {
                case 2:
                    gm.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idgasto"].Value);
                    this.Size = new Size(903, 402);
                    txtImporte.Text = dataGridView1.CurrentRow.Cells["monto"].Value.ToString();
                    dtpFecha.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                    gm.Detalle = Enlace.devolverDetalle(gm.Detalle, gm.Id);
                    txtDetalle.Text = gm.Detalle.ToString();
                    break;
                case 3:
                    gm.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idgasto"].Value);
                    if (MessageBox.Show($"Esta seguro que quiere eliminar el gasto?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Enlace.EliminarGastoo(gm.Id);
                        guia = 0;
                        cargargrid();
                        btnCancelar.Visible = false;
                        btnNuevo.Visible = true;
                        btnModificar.Visible = true;
                    }
                    break;
            }

        }
        public void cargargrid()
        {
            DataTable tabla = Enlace.RellenarDataGrid("Gastos", "");
            dataGridView1.DataSource = tabla;
            // Suscribirse al evento CellFormatting del DataGridView
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true; // Establecer la columna como de solo lectura
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;


            float total = 0;


            foreach (DataRow row in tabla.Rows)
            {
                foreach (DataColumn column in tabla.Columns)
                {
                    if (column.ColumnName == "monto")
                    {
                        total += float.Parse(row[column].ToString());
                    }

                }
            }

            txtTotal.Text = "TOTAL: " + total.ToString();
        }


    }
}
