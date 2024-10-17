using ClassLibrary1;
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
    public partial class RegistroVentas : Form
    {
        DataTable ventas = new DataTable();
        conexion enlace = new conexion();
        public int idventa;

        public RegistroVentas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ventas = enlace.RellenarDataGrid("VentaCabecera1", "");
            dataGridView1.DataSource = ventas;



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idventa = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idBoleta"].Value);
            DetalleVenta frm = new DetalleVenta();
            frm.ShowDialog();

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // Establecer AutoSizeMode para que la columna se ajuste automáticamente al contenido
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Establecer ReadOnly para que la columna no sea editable
                column.ReadOnly = true;

                // Establecer Resizable para que la columna no sea redimensionable
                column.Resizable = DataGridViewTriState.False;

                switch (column.Name)
                {
                    case "totalVenta":
                        column.HeaderText = "Ventas";
                        column.DefaultCellStyle.Format = "c";
                        column.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                        break;
                    case "fecha":
                        column.HeaderText = "Fecha";
                        break;
                    case "idBoleta":
                        column.HeaderText = "Numero Boleta";
                        break;
                    case "metodoPago":
                        column.HeaderText = "Pago";
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        break;
                    case "hora":
                        column.HeaderText = "Hora";
                        break;

                }







            }
        }
    }
}
