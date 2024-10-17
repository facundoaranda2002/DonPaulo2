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

namespace DonPaulo
{
    public partial class Proveedores : Form
    {
        conexion Enlace = new conexion();
        int guia;
        int provId;

        public Proveedores()
        {
            InitializeComponent();
        }

        public void mostrardatos(DataGridView grid, string tabla)
        {
            DataTable tablaDatos = Enlace.RellenarDataGrid(tabla, "");
            dataGridView1.DataSource = Enlace.RellenarDataGrid(tabla    , "");
            // Suscribirse al evento CellFormatting del DataGridView
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true; // Establecer la columna como de solo lectura
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoResizeColumns();
            }
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

        private void Proveedores_Load(object sender, System.EventArgs e)
        {
            mostrardatos(dataGridView1, "Proveedores");
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(506, 459);
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            btnConfirmar.Visible = true;
            guia = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(506, 393);
            lblDobleClick.Visible = true;
            lblDobleClick.Text = "DOBLE CLICK A UN PROVEEDOR PARA ELIMINARLO";
            btnCancelarEliminar.Visible = true;
            btnModificar.Visible = false;
            btnNuevo.Visible = false;
            btnEliminar.Visible = false;
            guia = 3;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (guia == 1)
                {
                    Proveedor p = new Proveedor(0, txtNombre.Text);
                    if (Enlace.GuardarProveedor(p))
                    {
                        this.Size = new Size(506, 393);
                        lblNombre.Visible = false;
                        txtNombre.Visible = false;
                        btnConfirmar.Visible = false;
                        mostrardatos(dataGridView1, "proveedores");
                        ResetearEstado();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar.", "ERROR");
                        ResetearEstado();
                    }
                }
                else if (guia == 2)
                {
                    Proveedor p = new Proveedor(provId, txtNombre.Text);
                    if (Enlace.ModificarProveedor(p))
                    {
                        this.Size = new Size(506, 393);
                        lblNombre.Visible = false;
                        txtNombre.Visible = false;
                        btnConfirmar.Visible = false;
                        mostrardatos(dataGridView1, "proveedores");
                        ResetearEstado();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar.", "ERROR");
                        ResetearEstado();
                    }
                }
            }
        }

        private void ResetearEstado()
        {
            btnModificar.Visible = true;
            btnNuevo.Visible = true;
            btnEliminar.Visible = true;
            lblDobleClick.Visible = false;
            btnCancelarEliminar.Visible = false;
            this.Size = new Size(506, 393);
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            btnConfirmar.Visible = false;
            guia = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(506, 393);
            lblDobleClick.Visible = true;
            lblDobleClick.Text = "DOBLE CLICK A UN PROVEEDOR PARA MODIFICARLO";
            btnCancelarEliminar.Visible = true;
            btnEliminar.Visible = false;
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            guia = 2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guia == 3)//eliminar
            {
                if (MessageBox.Show($"Esta seguro que quiere eliminar el Proveedor {dataGridView1.CurrentRow.Cells["nombre_Proveedor"].Value.ToString()}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Enlace.EliminarProveedor(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value)))
                    {
                        MessageBox.Show($"Proveedor {dataGridView1.CurrentRow.Cells["nombre_Proveedor"].Value.ToString()} eliminado. ", "Exito");
                        mostrardatos(dataGridView1, "proveedores");
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo eliminar al proveedor.", "ERROR.");
                    }
                }
                ResetearEstado();
            }
            else if (guia == 2)//modif
            {
                this.Size = new Size(506, 461);
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre_Proveedor"].Value.ToString();
                provId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                btnConfirmar.Visible = true;
            }

        }

        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            ResetearEstado();
        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            ResetearEstado();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
