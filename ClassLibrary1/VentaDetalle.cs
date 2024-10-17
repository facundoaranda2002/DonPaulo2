using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VentaDetalle
    {
        string fecha;
        int idProducto;
        string nombreProducto;
        int cantidad;
        float costo;
        float totalCosto;
        float precio;
        float totalVenta;
        float ganancia;
        int idCabecera;
        int idDetalle;

        public string Fecha { get => fecha; set => fecha = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Costo { get => costo; set => costo = value; }
        public float TotalCosto { get => totalCosto; set => totalCosto = value; }
        public float Precio { get => precio; set => precio = value; }
        public float TotalVenta { get => totalVenta; set => totalVenta = value; }
        public float Ganancia { get => ganancia; set => ganancia = value; }
        public int IdCabecera { get => idCabecera; set => idCabecera = value; }
        public int IdDetalle { get => idDetalle; set => idDetalle = value; }

        public VentaDetalle(string fecha, int idProducto, string nombreProducto, int cantidad, float costo, float totalCosto, float precio, float totalVenta, float ganancia, int idCabecera, int idDetalle)
        {
            this.fecha = fecha;
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidad = cantidad;
            this.costo = costo;
            this.totalCosto = totalCosto;
            this.precio = precio;
            this.totalVenta = totalVenta;
            this.ganancia = ganancia;
            this.idCabecera = idCabecera;
            this.idDetalle = idDetalle;
        }
        public VentaDetalle()
        {
            this.fecha = "";
            this.idProducto = 0;
            this.nombreProducto = "";
            this.cantidad = 0;
            this.costo = 0;
            this.totalCosto = 0;
            this.precio = 0;
            this.totalVenta = 0;
            this.ganancia = 0;
            this.idCabecera = 0;
            this.idDetalle = 0;
        }
    }
}
