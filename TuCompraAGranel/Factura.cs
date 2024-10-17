using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using DocumentFormat.OpenXml.Math;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using NPOI.HSSF.Record;
using NPOI.SS.Formula.Functions;
using static NPOI.HSSF.Util.HSSFColor;
using DonPaulo.Properties;
using System.util;
using System.Drawing.Printing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace TuCompraAGranel
{
    public partial class Factura : Form
    {
        int nroBoleta;
        string metodoPago;
        int guia = 0;
        string[,] listaVentas = new string[200, 6];
        public Producto productoaAgregar = new Producto();
        conexion Enlace = new conexion();
        public int buscadorId;
        public Factura()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            labelFecha.Text = hoy.ToString("dd/MM/yyyy");
            nroBoleta = 1 + Enlace.ObtenerUltimaVenta();
            lblNroBoleta.Text = nroBoleta.ToString();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            limpiarTxt();
            AbrirBuscadorProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarProducto();
            limpiarTxt();
            txtTotalaPagar.Text = totalPagar(); // Actualizar el total a pagar

        }
        private void BuscadorProductos_FormClosed(object sender, FormClosedEventArgs e)
        {

            Enlace.devolverProducto(productoaAgregar, buscadorId);
            rellenarTxt(productoaAgregar);
        }
        private void AbrirBuscadorProducto()
        {
            BuscadorProductos formBuscador = new BuscadorProductos();
            productoaAgregar.Id = 0;
            formBuscador.FormClosed += BuscadorProductos_FormClosed;
            formBuscador.ShowDialog();
        }
        private void rellenarTxt(Producto p)
        {

            if (p.CodigoBarras != null)
            {
                this.txtIdProducto.Text = p.Id.ToString();
                this.txtNombre.Text = p.Nombre.ToString();
                this.txtPrecio.Text = (Convert.ToDecimal(p.Costo) * (Convert.ToDecimal(p.PorcentajeMayorista) / 100) + Convert.ToDecimal(p.Costo)).ToString();
                this.txtCodigoBarras.Text = p.CodigoBarras.ToString();
            }
            if (p.CodigoBarras == null || p.CodigoBarras == "")
            {
                this.txtIdProducto.Text = p.Id.ToString();
                this.txtNombre.Text = p.Nombre.ToString();
                this.txtPrecio.Text = (Convert.ToDecimal(p.Costo) * (Convert.ToDecimal(p.PorcentajeMayorista) / 100) + Convert.ToDecimal(p.Costo)).ToString();

            }
        }
        private void limpiarTxt()
        {
            this.txtIdProducto.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtCodigoBarras.Text = string.Empty;
            this.txtSubTotal.Text = string.Empty;
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSubTotal.Text = (Convert.ToDecimal(txtPrecio.Text) * Convert.ToDecimal(txtCantidad.Text)).ToString();
            }
            catch
            {
                txtSubTotal.Text = "0.00";
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número ni una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento para evitar que se ingrese el carácter no deseado
                e.Handled = true;
            }
        }
        private void agregarProducto()
        {
            if (this.txtIdProducto.Text != string.Empty
                && this.txtNombre.Text != string.Empty
                && this.txtCantidad.Text != string.Empty
                && this.txtPrecio.Text != string.Empty
                && this.txtSubTotal.Text != string.Empty)
            {
                int fila = 0;
                while (fila < listaVentas.GetLength(0) && listaVentas[fila, 0] != null)
                {
                    fila++;
                }

                if (fila < listaVentas.GetLength(0))
                {
                    listaVentas[fila, 0] = this.txtIdProducto.Text;
                    listaVentas[fila, 1] = this.txtNombre.Text;
                    listaVentas[fila, 2] = this.txtPrecio.Text;
                    listaVentas[fila, 3] = this.txtCantidad.Text;
                    listaVentas[fila, 4] = this.txtSubTotal.Text;
                    dataGridView1.Rows.Add(listaVentas[fila, 0], listaVentas[fila, 1], listaVentas[fila, 2], listaVentas[fila, 3], listaVentas[fila, 4]);

                }
                else
                {
                    MessageBox.Show("La matriz de ventas está llena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tiene algún campo vacío, por favor revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            if (Enlace.ObtenerProductoPorCodigoDeBarras(productoaAgregar, txtCodigoBarras.Text) == 1)
            {
                rellenarTxt(productoaAgregar);
            }
            else
            {
                if (txtCodigoBarras.Text == "")
                {
                    limpiarTxt();
                }
            }

        }
        public string totalPagar()
        {
            float contadorTotal = 0;
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                float subtotal = 0;
                if (row.Cells["SubTotal"].Value != null && float.TryParse(row.Cells["SubTotal"].Value.ToString(), out subtotal))
                {
                    contadorTotal += subtotal;
                }
            }
            return contadorTotal.ToString();
        }
        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Enlace.devolverProducto(productoaAgregar, Convert.ToInt32(txtIdProducto.Text));
                rellenarTxt(productoaAgregar);
            }
            catch
            {


            }

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float totalPagar, pago, vuelto;
                if (float.TryParse(txtTotalaPagar.Text, out totalPagar) && float.TryParse(txtPago.Text, out pago))
                {
                    vuelto = pago - totalPagar;
                    txtVuelto.Text = vuelto.ToString();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            guia = 1;
            Inhabilitar();
            lblModificar.Visible = true;
        }
        private void Inhabilitar()
        {
            txtIdProducto.Enabled = false;
            txtCodigoBarras.Enabled = false;
            txtNombre.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtSubTotal.Enabled = false;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnImprimir.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtPago.Enabled = false;
            btnCancelar2.Visible = true;
            btnBusqueda.Enabled = false;
            rdioEfectivo.Enabled = false;
            rdioTarjeta.Enabled = false;
            rdioTransferencia.Enabled = false;
        }
        private void Habilitar()
        {

            txtIdProducto.Enabled = true;
            txtCodigoBarras.Enabled = true;
            txtNombre.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecio.Enabled = true;
            txtSubTotal.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnImprimir.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtPago.Enabled = true;
            btnCancelar2.Visible = false;
            btnBusqueda.Enabled = true;
            rdioEfectivo.Enabled = true;
            rdioTarjeta.Enabled = true;
            rdioTransferencia.Enabled = true;

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            Habilitar();
            guia = 0;
            lblModificar.Visible = false;
            lblEliminar.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (guia)
            {
                case 1:
                    limpiarTxt();
                    txtIdProducto.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                    txtCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                    txtSubTotal.Text = dataGridView1.CurrentRow.Cells["SubTotal"].Value.ToString();

                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        dataGridView1.Rows.Remove(row);
                    }
                    Habilitar();
                    guia = 0;
                    break;
                case 2:
                    //idP = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        dataGridView1.Rows.Remove(row);
                        Habilitar();
                        txtTotalaPagar.Text = totalPagar();
                        guia = 0;
                    }
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            guia = 2;
            Inhabilitar();
            lblEliminar.Visible = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (rdioEfectivo.Checked == false && rdioTarjeta.Checked == false && rdioTransferencia.Checked == false && rdioBtnPedidos.Checked == false)
                {
                    MessageBox.Show("No selecciono metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rdioEfectivo.Checked == true)
                    {
                        metodoPago = "Efectivo";
                    }
                    else
                    {
                        if (rdioTarjeta.Checked == true)
                        {
                            metodoPago = "Tarjeta";
                        }
                        else
                        {
                            if (rdioTransferencia.Checked == true)
                            {
                                metodoPago = "Transferencia";
                            }
                            else
                            {
                                if (rdioBtnPedidos.Checked==true)
                                {
                                    metodoPago = "Pedido";

                                }
                            }
                        }
                    }

                    int error = 0;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        Producto pAux = new Producto();
                        Enlace.devolverProducto(pAux, Convert.ToInt32(row.Cells["ID"].Value));
                        VentaDetalle ventaDetalle = new VentaDetalle();
                        if (!row.IsNewRow) // Ignorar la fila nueva si existe
                        {
                            ventaDetalle.Fecha = labelFecha.Text;
                            ventaDetalle.IdProducto = Convert.ToInt32(row.Cells["ID"].Value);
                            ventaDetalle.NombreProducto = row.Cells["Nombre"].Value.ToString();
                            ventaDetalle.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            ventaDetalle.Costo = pAux.Costo;
                            ventaDetalle.TotalCosto = pAux.Costo * ventaDetalle.Cantidad;
                            ventaDetalle.Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                            ventaDetalle.TotalVenta = ventaDetalle.Precio * ventaDetalle.Cantidad;
                            ventaDetalle.Ganancia = ventaDetalle.TotalVenta - ventaDetalle.TotalCosto;
                            ventaDetalle.IdCabecera = Enlace.ObtenerUltimaVenta();

                            pAux.Cantidad = pAux.Cantidad - ventaDetalle.Cantidad;
                            if (pAux.Cantidad < 0)
                            {
                                MessageBox.Show($"No existe la cantidad suficiente de {ventaDetalle.NombreProducto} revise el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                error = 1;
                            }
                        }
                    }
                    if (error == 0)
                    {
                        string hora = DateTime.Now.ToString("HH:mm:ss").ToString();
                        Enlace.InsertarVentaCabecera(labelFecha.Text, hora, Convert.ToSingle(txtTotalaPagar.Text), metodoPago);
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            Producto pAux = new Producto();
                            Enlace.devolverProducto(pAux, Convert.ToInt32(row.Cells["ID"].Value));
                            VentaDetalle ventaDetalle = new VentaDetalle();
                            if (!row.IsNewRow) // Ignorar la fila nueva si existe
                            {
                                ventaDetalle.Fecha = labelFecha.Text;
                                ventaDetalle.IdProducto = Convert.ToInt32(row.Cells["ID"].Value);
                                ventaDetalle.NombreProducto = row.Cells["Nombre"].Value.ToString();
                                ventaDetalle.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                ventaDetalle.Costo = pAux.Costo;
                                ventaDetalle.TotalCosto = pAux.Costo * ventaDetalle.Cantidad;
                                ventaDetalle.Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                                ventaDetalle.TotalVenta = ventaDetalle.Precio * ventaDetalle.Cantidad;
                                ventaDetalle.Ganancia = ventaDetalle.TotalVenta - ventaDetalle.TotalCosto;
                                ventaDetalle.IdCabecera = Enlace.ObtenerUltimaVenta();

                                pAux.Cantidad = pAux.Cantidad - ventaDetalle.Cantidad;
                                if (pAux.Cantidad < 0)
                                {
                                    MessageBox.Show($"No existe la cantidad suficiente de {ventaDetalle.NombreProducto} revise el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                Enlace.ModificarCantidad(pAux, "1", "Factura (Venta)");
                                Enlace.InsertarVentaDetalle(ventaDetalle);

                                this.Close();
                            }
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("No cargo ningun articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintDoc_PrintPage;

                printDoc.PrinterSettings.PrinterName = printDialog.PrinterSettings.PrinterName;

                printDoc.Print();
            }
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (rdioEfectivo.Checked == false && rdioTarjeta.Checked == false && rdioTransferencia.Checked == false && rdioBtnPedidos.Checked == false)
            {
                MessageBox.Show("No selecciono metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdioEfectivo.Checked == true)
                {
                    metodoPago = "Efectivo";
                }
                else
                {
                    if (rdioTarjeta.Checked == true)
                    {
                        metodoPago = "Tarjeta";
                    }
                    else
                    {
                        if (rdioTransferencia.Checked == true)
                        {
                            metodoPago = "Transferencia";
                        }
                    }
                }
                String htmlPagina = Resources.Plantilla.ToString();
                htmlPagina = htmlPagina.Replace("@IDBOLETA", nroBoleta.ToString());
                htmlPagina = htmlPagina.Replace("@METODODEPAGO", metodoPago);
                htmlPagina = htmlPagina.Replace("@FECHA", labelFecha.Text);
                string filas = string.Empty;
                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row != null)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                        filas += "</tr>";
                        total += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                    }
                }
                htmlPagina = htmlPagina.Replace("@FILAS", filas);
                htmlPagina = htmlPagina.Replace("@TOTAL", total.ToString());

                // Crear un control WebBrowser y asignar el contenido HTML
                WebBrowser browser = new WebBrowser();
                browser.DocumentText = htmlPagina;

                // Esperar a que se cargue completamente el contenido
                browser.DocumentCompleted += (s, args) =>
                {
                    // Imprimir el contenido del WebBrowser
                    browser.Print();

                    // Indicar que no hay más páginas a imprimir
                    e.HasMorePages = false;
                };

                // Establecer el WebBrowser como el control activo para cargar y mostrar el contenido
                browser.Parent = new System.Windows.Forms.Control();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTxt();
            dataGridView1.Rows.Clear();
        }

        private void btnBolsa_Click(object sender, EventArgs e)
        {
            txtIdProducto.Clear();


            agregarPredeterminado(1827);


        }

        private void btnBidon10_Click(object sender, EventArgs e)
        {
            txtIdProducto.Clear();


            agregarPredeterminado(1861);


        }

        private void btnBidon5_Click(object sender, EventArgs e)
        {
            txtIdProducto.Clear();
            agregarPredeterminado(1862);

        }
        public void agregarPredeterminado(int id)
        {
            Producto agg = new Producto();
            Enlace.devolverProducto(agg, id);
            txtIdProducto.Text = "";
            rellenarTxt(agg);
        }

    }
}
