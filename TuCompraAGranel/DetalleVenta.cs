using ClassLibrary1;
using DocumentFormat.OpenXml.Office2010.Excel;
using NPOI.POIFS.Crypt.Dsig;
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
    public partial class DetalleVenta : Form
    {
        List<VentaDetalle> detalle = new List<VentaDetalle>();    
        DataTable ventas = new DataTable();
        conexion enlace = new conexion();
        int itmVentas;
        public DetalleVenta()
        {
            InitializeComponent();

        }

        public void DetalleVenta_Load(object sender, EventArgs e)
        {
            try
            {
                RegistroVentas frm = Application.OpenForms.OfType<RegistroVentas>().FirstOrDefault();
                if (frm != null)
                {
                    itmVentas = frm.idventa;
                }
            }
            catch
            {
                this.Close();
            }
            ventas = enlace.RellenarDataGrid("VentasDetalles", $" where idCabecera ={itmVentas}");
            dataGridView1.DataSource = ventas; 
            foreach (DataRow dr in ventas.Rows)
            { 
                VentaDetalle ventaDetalle = new VentaDetalle();
                ventaDetalle.Fecha = dr[0].ToString();
                ventaDetalle.IdProducto = Convert.ToInt32(dr[1]);
                ventaDetalle.NombreProducto = dr[2].ToString();
                ventaDetalle.Cantidad = Convert.ToInt32(dr[3]);
                ventaDetalle.Costo = Convert.ToSingle(dr[4]);
                ventaDetalle.TotalCosto = Convert.ToSingle(dr[5]);
                ventaDetalle.Precio = Convert.ToSingle(dr[6]);
                ventaDetalle.TotalVenta = Convert.ToSingle(dr[7]);
                ventaDetalle.Ganancia = Convert.ToSingle(dr[8]);
                ventaDetalle.IdCabecera = Convert.ToInt32(dr[9]);
                ventaDetalle.IdDetalle = Convert.ToInt32(dr[10]);
                detalle.Add(ventaDetalle);

            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
                switch (column.Name)
                {
                    case "nombreProducto":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        column.HeaderText = "Detalle";
                        break;
                    case "idProducto":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.HeaderText = "Id";
                        break;
                    case "cantidad":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.HeaderText = "Cantidad";
                        break;
                    case "precio":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.HeaderText = "Precio Unitario";
                        column.DefaultCellStyle.Format = "c";
                        column.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                        break;
                    case "totalVenta":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        column.HeaderText = "Sub Total";
                        column.DefaultCellStyle.Format = "c";
                        column.DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                        break;
                    case "fecha":
                    case "costo":
                    case "totalCosto":
                    case "ganancia":
                    case "idCabecera":
                    case "idDetalle":
                        column.Visible = false;
                        break;
                }

            }



        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Esta seguro que quiere eliminar esta factura ?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                enlace.InsertarLog("Convert(varchar,getdate())", "'Se elimino la venta ID:" + itmVentas.ToString()+"'", "'Comienza eliminacion'");
                foreach (var item in detalle)
                {                
                        DevolucionDeStock(item.IdProducto, item.Cantidad, itmVentas);                                   
                }
                enlace.EliminarVenta(itmVentas);
                this.Close();
                try
                {
                    RegistroVentas frm = Application.OpenForms.OfType<RegistroVentas>().FirstOrDefault();
                    if (frm != null)
                    {
                        frm.Close();
                    }
                }
                catch
                {
                    this.Close();
                }
            }          
        }

        public void DevolucionDeStock(int id, int devolucion,int itmVentas)
        {
            string mensaje = "";
            Producto producto = new Producto();
            enlace.devolverProducto(producto,id);
            decimal precio =(Convert.ToDecimal(producto.Costo) * (Convert.ToDecimal(producto.PorcentajeMayorista) / 100) + Convert.ToDecimal(producto.Costo));
            string total = (devolucion * precio).ToString();
            producto.Cantidad = producto.Cantidad + devolucion;      
            enlace.ModificarCantidad(producto,"1","Devolucion Stock");
            mensaje = "'Se elimino " + devolucion.ToString() + " de" + producto.Nombre + " Total:" + total+"'";
            enlace.InsertarLog("Convert(varchar,getdate())", mensaje, "'Venta Eliminada'");
        }
    }
}
