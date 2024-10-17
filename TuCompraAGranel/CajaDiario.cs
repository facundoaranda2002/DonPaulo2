using ClassLibrary1;
using DocumentFormat.OpenXml.Drawing;
using NPOI.HSSF.Record;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPaulo
{
    public partial class CajaDiario : Form
    {
        conexion Enlace = new conexion();
        InformeDiario info = new InformeDiario();
        List<InformeDiario> listainfo = new List<InformeDiario>();
        List<InformeDiario> listaFiltrada = new List<InformeDiario>();
        string mes = "0";
        public CajaDiario()
        {
            InitializeComponent();
            CargarCombo();
            mes = DateTime.Today.ToString("MM");
            listainfo = Enlace.ObtenerInformeDiario();
            listaFiltrada = FiltroInforme(listainfo, mes);
            CargarGrid(listaFiltrada);
            lblMes.Text = (DateTime.Today.ToString("MMMM")).ToLower();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void CargarCombo()
        {
            string[] meses = {
            "Todos","Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
            "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };
            cmbMes.Items.AddRange(meses);
        }
        static string ObtenerNumeroMes(string nombreMes)
        {
            switch (nombreMes.ToLower())
            {
                case "enero":
                    return "01";
                case "febrero":
                    return "02";
                case "marzo":
                    return "03";
                case "abril":
                    return "04";
                case "mayo":
                    return "05";
                case "junio":
                    return "06";
                case "julio":
                    return "07";
                case "agosto":
                    return "08";
                case "septiembre":
                    return "09";
                case "octubre":
                    return "10";
                case "noviembre":
                    return "11";
                case "diciembre":
                    return "12";
                default:
                    return "0"; // Valor de retorno cuando el nombre del mes no es válido
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes = ObtenerNumeroMes(cmbMes.Text);
            listaFiltrada = FiltroInforme(listainfo, mes);
            CargarGrid(listaFiltrada);
            if (mes == "0")
            {
                CargarGrid(listainfo);
            }
            lblMes.Text = cmbMes.Text.ToLower();
        }
        private List<InformeDiario> FiltroInforme(List<InformeDiario> lista, string mes)
        {
            List<InformeDiario> listaFiltrada = new List<InformeDiario>();

            foreach (var item in lista)
            {
                string m = ObtenerMesDesdeFecha(item.Fecha);
                if (m == mes.ToString())
                {
                    listaFiltrada.Add(item);
                }
            }


            return listaFiltrada;
        }
        static string ObtenerMesDesdeFecha(string fechaEnTexto)
        {
            // Parsea la fecha en formato "dd/MM/yyyy" a un objeto DateTime
            DateTime fecha = DateTime.ParseExact(fechaEnTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Extrae el mes en formato "MM" y lo devuelve como un string
            string mes = fecha.ToString("MM");

            return mes;
        }
        private void CargarGrid(List<InformeDiario> lista)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in lista)
            {
                dataGridView1.Rows.Add(item.Fecha, item.TotalVentas, item.TotalGastos, item.TotalPagoProveedores);
            }

            float facturacion = CalcularTotal("TotalVentas");
            float proveedores = CalcularTotal("TotalPagoProveedores");
            float gastos = CalcularTotal("TotalGasto");
            float ganancia = facturacion - (proveedores + gastos);
            txtGanancia.Text = ganancia.ToString("C0");
            txtFacturacion.Text = facturacion.ToString("C2");
            txtGastos.Text = gastos.ToString("C2");
            txtProveedores.Text = proveedores.ToString("C2");



        }
        private float CalcularTotal(string columna)
        {
            float totalGastos = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Verificamos si la fila es válida y no es la fila de encabezado
                if (!fila.IsNewRow)
                {
                    // Accedemos a la celda de la columna "Total Gasto" (suponiendo que es la columna 2, puedes cambiarlo si es diferente)
                    DataGridViewCell celda = fila.Cells[$"{columna}"];

                    // Verificamos si la celda contiene un valor numérico válido
                    if (float.TryParse(celda.Value.ToString(), out float valorGasto))
                    {
                        // Sumamos el valor de la celda a la variable totalGastos
                        totalGastos += valorGasto;
                    }
                }
            }
            return totalGastos;
        }
    }
}
