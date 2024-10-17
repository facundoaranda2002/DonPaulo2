using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
//C:\Users\\Julian lopez\\source\\repos\\TuCompraAGranel
namespace ClassLibrary1
{
    public class Producto
    {
        private int id;
        private string nombre;
        private string categoria;
        private int proveedorId;
        private float costo;
        private int porcentajeMayorista;
        private string codigoBarras;
        private int cantidad;
        

        public Producto()
        {
            this.nombre = "";
            this.costo = 0;
            this.categoria = "";
            this.proveedorId = 0;
            this.porcentajeMayorista = 0;

        }
        public Producto(string nombre, float costo, string categoria,  int proveedorId, int porcentajeMayorista, string codigoBarras, int cantidad)
        {
            
            this.nombre = nombre;
            this.categoria = categoria;
            this.proveedorId = proveedorId;
            this.costo = costo;            
            this.porcentajeMayorista = porcentajeMayorista;
            this.codigoBarras = codigoBarras;
            this.cantidad = cantidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public float Costo { get => costo; set => costo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int ProveedorId { get => proveedorId; set => proveedorId = value; }
        public int PorcentajeMayorista { get => porcentajeMayorista; set => porcentajeMayorista = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public static int CargarProductosExcel(string rutaArchivo, List<Producto> Listaproductos)
        {
            
            int validacion = 1;

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                // Manejar el caso cuando el archivo no existe
                // Puedes lanzar una excepción, mostrar un mensaje de error, etc.
                return validacion = -1;
            }

            // Abrir el archivo de Excel utilizando NPOI
            using (FileStream file = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new XSSFWorkbook(file);
                ISheet hojaCalculo = workbook.GetSheet("Hoja1");

                // Obtener el número total de filas en la tabla
                int totalFilas = hojaCalculo.LastRowNum + 1;

                // Recorrer las filas y obtener los datos de las columnas especificadas
                for (int fila = 1; fila < totalFilas; fila++) // Suponiendo que la tabla comienza desde la segunda fila
                {
                    IRow row = hojaCalculo.GetRow(fila);
                    Producto productoNuevo = new Producto();

                    productoNuevo.nombre = row.GetCell(0)?.ToString();
                    productoNuevo.categoria = "Unidades";
                    productoNuevo.proveedorId = 1;
                    productoNuevo.costo = Convert.ToInt32(row.GetCell(1)?.NumericCellValue);
                    productoNuevo.porcentajeMayorista = 40;

                    if (!string.IsNullOrEmpty(productoNuevo.nombre) && !string.IsNullOrEmpty(productoNuevo.categoria) && productoNuevo.proveedorId != 0 && productoNuevo.costo != 0
                     && productoNuevo.porcentajeMayorista != 0)
                    {
                        Listaproductos.Add(productoNuevo);
                    }
                }
            }

            return validacion;
        }
    }
}
