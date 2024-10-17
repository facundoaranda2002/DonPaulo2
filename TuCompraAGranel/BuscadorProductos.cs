using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace TuCompraAGranel
{
    public partial class BuscadorProductos : Form
    {
        DataTable tablaDatos = new DataTable();
        public BuscadorProductos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        public void BuscadorProductos_Load(object sender, EventArgs e)
        {


            RellenarDataGridView(tablaDatos);
            dataGridView1.DataSource = tablaDatos;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void RellenarDataGridView(DataTable tabla)
        {
            // Limpiar el DataGridView
            tabla.Rows.Clear();

            // Consulta SQL para obtener los datos de la vista y la tabla
            string sql = "SELECT vp.id, vp.nombre, vp.precioventa, p.proveedorid  " +
                         "FROM VistaProductos vp " +
                         "INNER JOIN PRODUCTOS1 p ON vp.id = p.id";

            // Establecer la conexión a la base de datos y crear un objeto SqlCommand
            using (SqlConnection connection = new SqlConnection(@"Data source = . ; initial catalog = DonPaulo ; integrated security = true "))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                conexion enlace = new conexion();
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta y obtener los resultados
                    SqlDataReader reader = command.ExecuteReader();

                    // Crear el DataTable y configurar las columnas
                    tabla.Columns.Add("id", typeof(int));
                    tabla.Columns.Add("nombre", typeof(string));
                    tabla.Columns.Add("precio", typeof(decimal));
                    tabla.Columns.Add("proveedor", typeof(string));

                    // Recorrer los registros y agregarlos al DataTable
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string nombre = reader["nombre"].ToString();
                        decimal precio = Convert.ToDecimal(reader["precioventa"]);
                        int idProveedor = Convert.ToInt32(reader["proveedorid"]);
                        string proveedor = enlace.ObtenerNombreProveedor(idProveedor);
                        string precioFormateado = precio.ToString("0.00");

                        tabla.Rows.Add(id, nombre, precioFormateado, proveedor);
                    }

                    // Cerrar el lector de datos
                    reader.Close();
                }
                catch (Exception)
                {
                    // Manejar cualquier excepción
                }
            }

            // Configurar propiedades de las columnas en el DataGridView
            tablaDatos.Columns["id"].ReadOnly = true;
            tablaDatos.Columns["nombre"].ReadOnly = true;
            tablaDatos.Columns["precio"].ReadOnly = true;
            tablaDatos.Columns["proveedor"].ReadOnly = true;
        }






        private void FiltrarDatosPorNombre(string nombreProducto)
        {
            // Obtener la vista por defecto del DataTable
            DataView vista = tablaDatos.DefaultView;

            // Aplicar el filtro basado en el nombre del producto
            vista.RowFilter = $"nombre LIKE '%{nombreProducto}%'";

            // Establecer la vista filtrada como origen de datos del DataGridView
            dataGridView1.DataSource = vista;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Factura frmFactura = Application.OpenForms.OfType<Factura>().FirstOrDefault();
                frmFactura.buscadorId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            }
            catch
            {
                this.Close();

            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatosPorNombre(textBox1.Text);
        }

        private void Bolsa_Click(object sender, EventArgs e)
        {
            try
            {
                Factura frmFactura = Application.OpenForms.OfType<Factura>().FirstOrDefault();
                frmFactura.productoaAgregar.Id = 1827;
            }
            catch
            {
                this.Close();

            }
            this.Close();
        }
    }
}
