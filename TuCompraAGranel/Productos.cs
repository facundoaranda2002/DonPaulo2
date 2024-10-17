using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Drawing.Printing;
using Zen.Barcode;
using System.Drawing;


namespace TuCompraAGranel
{
    public partial class Productos : Form
    {
        List<Proveedor> proveedores = new List<Proveedor>();
        Proveedor aux = new Proveedor();
        List<Producto> cargarProductos = new List<Producto>();
        Producto nuevoProducto = new Producto();
        conexion Enlace = new conexion();
        Producto productoModificar = new Producto();
        List<Producto> ModificarVarios = new List<Producto>();


        public int guia = 0;
        public Productos()
        {
            InitializeComponent();
            // this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Litros");
            cmbCategoria.Items.Add("Unidades");
            mostrardatos(dataGridView1, "VistaProductos", "nombre", textBox1);
            Enlace.VerProveedores(proveedores);
            foreach (var item in proveedores)
            {
                cmbProveedor.Items.Add(item.Nombre);
                PFormularios.Visible = false;
            }
            ConfigGrid(dataGridView2);
            cmbCategoria.Items.Add("");
            cmbProveedor.Items.Add("");
        }

        public void mostrardatos(DataGridView grid, string tabla, string columnaFiltro, TextBox textBoxFiltro)
        {
            DataTable tablaDatos = Enlace.RellenarDataGrid(tabla, "");
            dataGridView1.DataSource = Enlace.RellenarDataGrid(tabla, "");
            // Suscribirse al evento CellFormatting del DataGridView
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true; // Establecer la columna como de solo lectura
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AutoResizeColumns();
            }
            if (string.IsNullOrWhiteSpace(textBoxFiltro.Text))
            {
                grid.DataSource = tablaDatos;
            }
            else
            {
                DataView vista = tablaDatos.DefaultView;
                vista.RowFilter = $"{columnaFiltro} LIKE '%{textBoxFiltro.Text}%'";
                grid.DataSource = vista;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /* private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
         {

             if (guia == 2)//modificar
             {
                 productoModificar.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                 Enlace.devolverProducto(productoModificar, productoModificar.Id);
                 txtNombre.Text = productoModificar.Nombre;
                 cmbCategoria.Text = productoModificar.Categoria;
                 txtCosto.Text = productoModificar.Costo.ToString();
                 txtCodigoBarras.Text = productoModificar.CodigoBarras;
                 foreach (var item in proveedores)
                 {
                     if (productoModificar.ProveedorId == item.Id)
                     {
                         cmbProveedor.Text = item.Nombre;
                     }
                 }
                 txtMayorista.Text = productoModificar.PorcentajeMayorista.ToString();


             }
             else
             {
                 if (guia == 3)//eliminar
                 {
                     productoModificar.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                     if (MessageBox.Show($"Esta seguro que quiere eliminar el Producto {productoModificar.Id}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                     {
                         Enlace.EliminarProducto(productoModificar.Id);
                         guia = 0;
                         mostrardatos(dataGridView1, "VistaProductos", "nombre", textBox1);
                         btn_Cancelar.Visible = false; btn_Eliminar.Visible = true; btn_Modificar.Visible = true; btn_Nuevo.Visible = true;
                         PFormularios.Visible = false;
                     }
                 }
             }
             Instruccion.Visible = false;

         }*/


        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            btn_Cancelar.Visible = true; btn_Eliminar.Visible = true; btn_Modificar.Visible = false; btn_Nuevo.Visible = false;
            Instruccion.Visible = true;
            btnImprimir.Visible = false;

            guia = 3;
        }

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            productoModificar.Id = 0;
            btn_Cancelar.Visible = true; btn_Eliminar.Visible = false; btn_Modificar.Visible = false; btn_Nuevo.Visible = false; PFormularios.Visible = true;
            Instruccion.Visible = true;
            btnVarios.Visible = true;
            btnImprimir.Visible = false;

            guia = 2;
        }

        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1332, 756);
            btn_Cancelar.Visible = true; btn_Eliminar.Visible = false; btn_Modificar.Visible = false; btn_Nuevo.Visible = false; PFormularios.Visible = true;
            label7.Visible = true; txtCantidad.Visible = true;
            guia = 1;
            btnImprimir.Visible = false;

        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1332, 594);
            btn_Cancelar.Visible = false; btn_Eliminar.Visible = true; btn_Modificar.Visible = true; btn_Nuevo.Visible = true;
            PFormularios.Visible = false; label7.Visible = false; txtCantidad.Visible = false;
            Instruccion.Visible = false;
            btnImprimir.Visible = true;
            btnVarios.Visible = false;
            guia = 0;
            productoModificar.Id = 0;
            txtNombre.Text = ""; cmbCategoria.Text = ""; txtCosto.Text = ""; cmbProveedor.Text = ""; txtMayorista.Text = ""; txtPrecioMayorista.Text = "";
            ModificarVarios.Clear();
            panel2.Visible = false;
            txtNombre.Enabled = true; txtCosto.Enabled = true; txtPrecioMayorista.Enabled = true;
            txtCantidad.Enabled = true; txtCodigoBarras.Enabled = true; radioEscanear.Enabled = true; radioGenerar.Enabled = true;
            cmbCategoria.Enabled = true;

        }

        private void btnConfirmacion_Click(object sender, EventArgs e)
        {
            if (guia != 5)
            {
                if (txtNombre.Text != "" && cmbCategoria.Text != "" && txtCosto.Text != "" && cmbProveedor.Text != "" && txtMayorista.Text != "")
                {
                    if (guia == 1)//crea nuevo
                    {
                        int idProveedor = aux.devolverId(proveedores, cmbProveedor.Text);
                        Producto p = new Producto(txtNombre.Text, Convert.ToInt32(txtCosto.Text), cmbCategoria.Text, idProveedor, Convert.ToInt32(txtMayorista.Text), txtCodigoBarras.Text, Convert.ToInt32(txtCantidad.Text));
                        if (MessageBox.Show("Esta seguro que quiere agregar el nuevo Producto?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Enlace.GuardarProductos(p);

                        }
                    }
                    else
                    {
                        if (guia == 2 && productoModificar.Id != 0)//modificar
                        {
                            int idProveedor = aux.devolverId(proveedores, cmbProveedor.Text);
                            Producto p = new Producto(txtNombre.Text, Convert.ToInt32(txtCosto.Text), cmbCategoria.Text, idProveedor, Convert.ToInt32(txtMayorista.Text), txtCodigoBarras.Text, 0);//cambiar mas tarde
                            p.Id = productoModificar.Id;
                            if (MessageBox.Show($"Esta seguro que quiere modificar el Producto {productoModificar.Nombre}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Enlace.ModificarProductos(p, "");

                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Esta seguro que completo todos los campos?");
                }
            }
            else
            {
                if (MessageBox.Show($"Esta seguro que quiere modificar los Productos?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string cadena = "";
                    if (txtMayorista.Text != "")
                    {
                        cadena = "porcentaje";
                        foreach (var item in ModificarVarios)
                        {
                            item.PorcentajeMayorista = Convert.ToInt32(txtMayorista.Text);
                            Enlace.ModificarProductos(item, cadena);
                        }
                    }
                    if (cmbProveedor.Text != "")
                    {
                        cadena = "proveedor";
                        int idProveedor = aux.devolverId(proveedores, cmbProveedor.Text);
                        foreach (var item in ModificarVarios)
                        {
                            item.ProveedorId = idProveedor;
                            Enlace.ModificarProductos(item, cadena);
                        }
                    }
                }
            }
            btn_Cancelar.Visible = false; btn_Eliminar.Visible = true; btn_Modificar.Visible = true; btn_Nuevo.Visible = true; PFormularios.Visible = false;
            txtNombre.Text = ""; cmbCategoria.Text = ""; txtCosto.Text = ""; cmbProveedor.Text = ""; txtMayorista.Text = ""; txtPrecioMayorista.Text = "";
            txtCantidad.Text = ""; txtCodigoBarras.Text = ""; radioEscanear.Checked = false; radioGenerar.Checked = false; btnImprimir.Visible = true;
            this.Size = new Size(1332, 597);
            mostrardatos(dataGridView1, "VistaProductos", "nombre", textBox1);
            ModificarVarios.Clear();
            panel2.Visible = false;
            txtNombre.Enabled = true; txtCosto.Enabled = true; txtPrecioMayorista.Enabled = true;
            txtCantidad.Enabled = true; txtCodigoBarras.Enabled = true; radioEscanear.Enabled = true; radioGenerar.Enabled = true;
            cmbCategoria.Enabled = true;
        }

        private void txtCosto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número ni una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento para evitar que se ingrese el carácter no deseado
                e.Handled = true;
            }
        }

        private void txtMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número ni una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento para evitar que se ingrese el carácter no deseado
                e.Handled = true;
            }
        }

        private void txtMayorista_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCosto.Text != "" && txtMayorista.Text != "")
            {
                float precio2 = Convert.ToSingle(txtCosto.Text) * (1 + Convert.ToSingle(txtMayorista.Text) / 100);
                txtPrecioMayorista.Text = precio2.ToString();
            }
        }

        private void txtCosto_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCosto.Text != "" && txtMayorista.Text != "")
            {
                float precio2 = Convert.ToSingle(txtCosto.Text) * (1 + Convert.ToSingle(txtMayorista.Text) / 100);
                txtPrecioMayorista.Text = precio2.ToString();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            mostrardatos(dataGridView1, "VistaProductos", "nombre", textBox1);
        }

        private void radioEscanear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEscanear.Checked)
            {
                txtCodigoBarras.ReadOnly = false;
                txtCodigoBarras.Text = string.Empty;

            }
        }

        private void radioGenerar_CheckedChanged(object sender, EventArgs e)
        {
            string codigo;
            Random random = new Random();
            do
            {
                codigo = random.Next(100000000, 999999999).ToString();
            }
            while (Enlace.VerificarCodigoDeBarrasDisponible(codigo) == false);

            if (radioGenerar.Checked)
            {

                txtCodigoBarras.ReadOnly = true;
                txtCodigoBarras.Text = codigo;

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (guia)
            {
                case 2:
                    this.Size = new Size(1332, 761);
                    productoModificar.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    Enlace.devolverProducto(productoModificar, productoModificar.Id);
                    txtNombre.Text = productoModificar.Nombre;
                    cmbCategoria.Text = productoModificar.Categoria;
                    txtCosto.Text = productoModificar.Costo.ToString();
                    txtCodigoBarras.Text = productoModificar.CodigoBarras;
                    foreach (var item in proveedores)
                    {
                        if (productoModificar.ProveedorId == item.Id)
                        {
                            cmbProveedor.Text = item.Nombre;
                        }
                    }
                    txtMayorista.Text = productoModificar.PorcentajeMayorista.ToString();
                    break;
                case 3:
                    productoModificar.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    if (MessageBox.Show($"Esta seguro que quiere eliminar el Producto {productoModificar.Id}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Enlace.EliminarProducto(productoModificar.Id);
                        guia = 0;
                        mostrardatos(dataGridView1, "VistaProductos", "nombre", textBox1);
                        btn_Cancelar.Visible = false; btn_Eliminar.Visible = true; btn_Modificar.Visible = true; btn_Nuevo.Visible = true;
                        PFormularios.Visible = false;
                    }
                    break;
                case 4:

                    productoModificar.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    Enlace.devolverProducto(productoModificar, productoModificar.Id);
                    if (MessageBox.Show($"Esta seguro que quiere imprimir el codigo del Producto {productoModificar.Nombre}?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        ImprimirCodigoBarras(productoModificar);
                    }
                    btn_Cancelar.Visible = false; btn_Eliminar.Visible = true; btn_Modificar.Visible = true; btn_Nuevo.Visible = true;
                    PFormularios.Visible = false; label7.Visible = false; txtCantidad.Visible = false;
                    Instruccion.Visible = false;
                    guia = 0;
                    productoModificar.Id = 0;
                    txtNombre.Text = ""; cmbCategoria.Text = ""; txtCosto.Text = ""; cmbProveedor.Text = ""; txtMayorista.Text = ""; txtPrecioMayorista.Text = "";
                    break;
                case 5:
                    this.Size = new Size(1332, 761);

                    Producto PM = new Producto();
                    PM.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    Enlace.devolverProducto(PM, PM.Id);
                    Agregarlista(ModificarVarios, PM);
                    ActualizarData(dataGridView2, ModificarVarios);
                    break;
            }
            Instruccion.Visible = false;
        }
        private void Agregarlista(List<Producto> list, Producto p)
        {
            int validacion = 0;
            foreach (Producto item in list)
            {
                if (item.Id == p.Id)
                {
                    validacion = 1; break;
                }
            }
            if (validacion != 1)
            {
                list.Add(p);
            }
        }
        private void ConfigGrid(DataGridView dataGridView)
        {
            // Configura las columnas en el DataGridView
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("Categoria", "Categoría");
            dataGridView.Columns.Add("ProveedorId", "Proveedor ID");
            dataGridView.Columns.Add("Costo", "Costo");
            dataGridView.Columns.Add("PorcentajeMayorista", "Porcentaje Mayorista");
            dataGridView.Columns.Add("CodigoBarras", "Código de Barras");
            dataGridView.Columns.Add("Cantidad", "Cantidad");
            dataGridView.AllowUserToAddRows = false;
            // Haz todas las columnas invisibles excepto la de Nombre
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (col.Name != "Nombre")
                {
                    col.Visible = false;
                }
                else
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Establece Fill para la columna Nombre
                    col.ReadOnly = true;
                }
            }
        }


        private void ActualizarData(DataGridView dataGridView, List<Producto> productos)
        {
            dataGridView.Rows.Clear();
            foreach (Producto producto in productos)
            {
                dataGridView.Rows.Add(
                    producto.Id,
                    producto.Nombre,
                    producto.Categoria,
                    producto.ProveedorId,
                    producto.Costo,
                    producto.PorcentajeMayorista,
                    producto.CodigoBarras,
                    producto.Cantidad
                );
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Visible = true; btn_Eliminar.Visible = false; btn_Modificar.Visible = false; btn_Nuevo.Visible = false;
            guia = 4;
        }
        public void ImprimirCodigoBarras(Producto p)
        {
            string texto = p.CodigoBarras.ToString();
            // Crear una instancia de BarcodeDraw de Zen Barcode
            BarcodeDraw barcodeDraw = BarcodeDrawFactory.Code128WithChecksum;

            // Generar el código de barras a partir del texto proporcionado con el doble de tamaño
            Image imagenCodigoBarras = barcodeDraw.Draw(texto, 100);

            // Crear una instancia de PrintDocument
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                // Obtener el ancho y alto de la imagen del código de barras
                int anchoImagen = imagenCodigoBarras.Width;
                int altoImagen = imagenCodigoBarras.Height;

                // Dibujar el texto "Codigo de Barras" encima de la imagen
                System.Drawing.Font fuente = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                e.Graphics.DrawString(p.Nombre, fuente, Brushes.Black, 100, 80);

                // Dibujar la imagen del código de barras en la página de impresión con el doble de tamaño
                e.Graphics.DrawImage(imagenCodigoBarras, 100, 100, anchoImagen * 2, altoImagen * 1);
            };

            // Imprimir el documento
            printDocument.Print();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVarios_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            guia = 5;
            this.Size = new Size(1332, 761);

            txtNombre.Enabled = false; txtCosto.Enabled = false; txtPrecioMayorista.Enabled = false;
            txtCantidad.Enabled = false; txtCodigoBarras.Enabled = false; radioEscanear.Enabled = false; radioGenerar.Enabled = false;
            cmbCategoria.Enabled = false;




            txtNombre.Text = ""; txtCosto.Text = ""; txtMayorista.Text = ""; txtPrecioMayorista.Text = "";
            txtCantidad.Text = ""; txtCodigoBarras.Text = ""; radioEscanear.Checked = false; radioGenerar.Checked = false;
            cmbCategoria.Text = "";
            cmbProveedor.Text = "";

        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id;
                id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["Id"].Value);
                for (int i = ModificarVarios.Count - 1; i >= 0; i--)
                {
                    if (id == ModificarVarios[i].Id)
                    {
                        ModificarVarios.RemoveAt(i);
                    }
                }
                ActualizarData(dataGridView2, ModificarVarios);
            }
            catch (Exception)
            {

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
