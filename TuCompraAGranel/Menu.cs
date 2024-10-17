using ClassLibrary1;
using DonPaulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuCompraAGranel
{
    public partial class Menu : Form
    {
        conexion Enlace = new conexion();
        VentaCabecera vCabecera = new VentaCabecera();
        List<VentaCabecera> cabecerasHoy = new List<VentaCabecera>();
        List<VentaCabecera> filtroCabeceras = new List<VentaCabecera>();
        public List<(int, string, string, string, string, string)> listaInfo = new List<(int, string, string, string, string, string)>();
        string fecha = DateTime.Today.ToString("D");
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            ActualizarTotales();
            Enlace.CreadorLog();
            txtFecha.Text = fecha;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock frm = new Stock();
            frm.FormClosed += Stock_FormClosed;
            frm.ShowDialog();


        }
        private void Stock_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarTotales();
        }
        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirBuscadorProducto();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores_Pagos frm = new Proveedores_Pagos();
            frm.ShowDialog();
        }

        public float SumaVentas(List<VentaCabecera> v1)
        {
            float resultado = 0;

            foreach (var item in v1)
            {
                resultado = resultado + item.TotalVenta;
            }
            return resultado;
        }
        public void ActualizarTotales()
        {
            float efectivo;
            float tarjeta;
            float transferencia;
            float pedidos;

            numEfectivo.Text = "$0";
            numTransferencia.Text = "$0";
            numEfectivo.Text = "$0";
            numTotal.Text = "$0";

            filtroCabeceras = Enlace.CabeceraMetodoPago("Efectivo");
            filtroCabeceras = vCabecera.CabecerasHoy(filtroCabeceras);
            efectivo = SumaVentas(filtroCabeceras);


            filtroCabeceras = Enlace.CabeceraMetodoPago("Transferencia");
            filtroCabeceras = vCabecera.CabecerasHoy(filtroCabeceras);
            transferencia = SumaVentas(filtroCabeceras);


            filtroCabeceras = Enlace.CabeceraMetodoPago("Tarjeta");
            filtroCabeceras = vCabecera.CabecerasHoy(filtroCabeceras);
            tarjeta = SumaVentas(filtroCabeceras);

            filtroCabeceras = Enlace.CabeceraMetodoPago("Pedido");
            filtroCabeceras = vCabecera.CabecerasHoy(filtroCabeceras);
            pedidos = SumaVentas(filtroCabeceras);


            numTotal.Text = (efectivo + transferencia + tarjeta + pedidos).ToString("C2");
            txtPedidos.Text = pedidos.ToString("C2");
            numTarjeta.Text = tarjeta.ToString("C2");
            numEfectivo.Text = efectivo.ToString("C2");
            numTransferencia.Text = transferencia.ToString("C2");


            dataGridView1.Rows.Clear();
            cargarLista();
            cargarGrid(listaInfo, dataGridView1);
        }

        private void Factura_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarTotales();
        }
        private void AbrirBuscadorProducto()
        {
            Factura frm = new Factura();
            frm.FormClosed += Factura_FormClosed;
            frm.ShowDialog();
        }
        private void cargarLista()
        {
            conexion Enlace = new conexion();
            List<Producto> listaP = new List<Producto>();
            listaP = Enlace.ObtenerDatosProductos();
            listaInfo.Clear();
            foreach (Producto producto in listaP)
            {
                // Determinar el estado según la cantidad
                string estado;
                string nombre;

                if (producto.Categoria == "Litros")
                {
                    if (producto.Cantidad > 30)
                    {
                        estado = "Bien";
                    }
                    else if (producto.Cantidad > 15)
                    {
                        estado = "Regular";
                    }
                    else
                    {
                        estado = "Mal";
                    }
                }
                else
                {
                    if (producto.Cantidad > 10)
                    {
                        estado = "Bien";
                    }
                    else if (producto.Cantidad > 5)
                    {
                        estado = "Regular";
                    }
                    else
                    {
                        estado = "Mal";
                    }
                }

                nombre = Enlace.ObtenerNombreProveedor(producto.ProveedorId);

                listaInfo.Add((producto.Id, producto.Nombre, nombre, producto.Cantidad.ToString(), producto.Categoria, estado));
            }
        }
        public void cargarGrid(List<(int, string, string, string, string, string)> lp, DataGridView data)
        {

            foreach (var item in lp)
            {
                if (item.Item6 == "Mal")
                {
                    int rowIndex = dataGridView1.Rows.Add(item.Item2, item.Item3, item.Item4, item.Item5, item.Item6, item.Item1);
                    data.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Firebrick;
                }
                else
                {
                    if (item.Item6 == "Regular")
                    {
                        int rowIndex = dataGridView1.Rows.Add(item.Item2, item.Item3, item.Item4, item.Item5, item.Item6, item.Item1);
                        data.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }

            }

        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            Gastos frm = new Gastos();
            frm.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            CajaDiario frm = new CajaDiario();


            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numTransferencia_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistroVentas frm = new RegistroVentas();
            frm.FormClosed += RegistroVentas_FormClosed;
            frm.ShowDialog();
        }
        private void RegistroVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActualizarTotales();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
