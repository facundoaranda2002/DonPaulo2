using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Threading;
using System.IO;
using DocumentFormat.OpenXml.Presentation;
using NPOI.SS.Formula.Functions;
using TuCompraAGranel;
using NPOI.SS.Formula.Atp;
using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;

namespace DonPaulo
{
    public partial class Proveedores_Pagos : Form
    {
        conexion Enlace = new conexion();
        int guia = 0;
        int pagoId = 0;
        public Proveedores_Pagos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new Size(651, 394);
        }

        private void CargarProveedores()
        {
            DataTable tabla = new DataTable();

            tabla = Enlace.RellenarDataGrid("Proveedores","");

            cmbProveedor.Items.Add("Todos");
            foreach (DataRow row in tabla.Rows)
            {
                cmbProveedor.Items.Add(row[1].ToString());
                cmbProveedorPago.Items.Add(row[1].ToString());
            }

            cmbProveedor.SelectedIndex = 0;
        }

        private void CargarPagos()
        {
            string condicion = "";


            if (cmbProveedor.Text != "Todos")
            {
                condicion = "WHERE proveedor='" + cmbProveedor.Text + "'";
            }
            DataTable tabla = Enlace.RellenarDataGrid("Proveedores_Pagos", condicion);
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
            dataGridView1.Columns[3].Visible = false;


            float total = 0;

            foreach (DataRow row in tabla.Rows)
            {
                foreach (DataColumn column in tabla.Columns)
                {
                    if (column.ColumnName == "montopago")
                    {
                        total += float.Parse(row[column].ToString());
                    }

                }
            }

            txtTotal.Text = "TOTAL: " + total.ToString();
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

        private void Proveedores_Pagos_Load(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            CargarProveedores();
            CargarPagos();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            ResetearEstado();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago();

            pago.id = pagoId;
            pago.proveedor = cmbProveedorPago.Text;
            pago.importe = float.Parse(txtImporte.Text);
            pago.fecha = dtpFecha.Text;

            if (guia == 1)
            {
                if (Enlace.GuardarPago(pago))
                {
                    cmbProveedor.SelectedIndex = 0;
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar.", "ERROR");
                }

            }
            else if (guia == 2)
            {
                if (Enlace.ModificarPago(pago))
                {
                    MessageBox.Show($"Pago del {pago.fecha} a {pago.proveedor} modificado", "ERROR");
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar.", "ERROR");
                }
            }

            ResetearEstado();
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the key press event
                e.Handled = true;
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void btnModificarPago_Click(object sender, EventArgs e)
        {
            if (guia == 1)
            {
                ResetearEstado();
            }
            lblDobleClick.Visible = true;
            lblDobleClick.Text = "DOBLE CLICK A UN PROVEEDOR PARA MODIFICARLO";
            btnCancelarEliminar.Visible = true;
            guia = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (guia == 1)
            {
                ResetearEstado();
            }
            lblDobleClick.Visible = true;
            lblDobleClick.Text = "DOBLE CLICK A UN PROVEEDOR PARA ELIMINARLO";
            btnCancelarEliminar.Visible = true;
            guia = 3;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guia == 3)//eliminar
            {
                if (MessageBox.Show($"Esta seguro que quiere eliminar el Pago del {dataGridView1.CurrentRow.Cells["Fecha"].Value}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Enlace.EliminarPago(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idpago"].Value)))
                    {
                        MessageBox.Show($"Pago del {dataGridView1.CurrentRow.Cells["Fecha"].Value} eliminado. ", "Exito");
                        CargarPagos();
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo eliminar el pago.", "ERROR.");
                    }
                }
                ResetearEstado();
            }
            else if (guia == 2)//modif
            {
                pagoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idpago"].Value);
                cmbProveedorPago.Text = dataGridView1.CurrentRow.Cells["proveedor"].Value.ToString();
                txtImporte.Text = dataGridView1.CurrentRow.Cells["montopago"].Value.ToString();
                dtpFecha.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                this.Size = new Size(923, 392);
            }
        }

        private void ResetearEstado()
        {
            lblDobleClick.Visible = false;
            btnCancelarEliminar.Visible = false;
            this.Size = new Size(651, 394);
            guia = 0;
            txtImporte.Text = "0";
            cmbProveedorPago.Text = "";
            dtpFecha.Value = DateTime.Today;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAltaPago_Click(object sender, EventArgs e)
        {
            this.Size = new Size(923, 392);

            if (cmbProveedor.Text != "Todos")
            {
                cmbProveedorPago.Text = cmbProveedor.Text;
            }

            guia = 1;

        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            ResetearEstado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores frm = new Proveedores();
            frm.Show();
        }
    }
}
