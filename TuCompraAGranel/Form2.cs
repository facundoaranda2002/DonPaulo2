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
using System.IO;

namespace DonPaulo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "juanpablorios334")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else if (textBox1.Text == "excel123")
            {
                List<Producto> Listaproductos = new List<Producto>();

                // Construir la ruta del archivo correctamente
                string rutaArchivo = Path.Combine(Environment.CurrentDirectory, "Productos.xlsx");

                // Llamar al método para cargar productos desde el archivo
                if (Producto.CargarProductosExcel(rutaArchivo, Listaproductos) != 1)
                {
                    MessageBox.Show("Error en la ruta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conexion Enlace = new conexion();
                    foreach (Producto producto in Listaproductos)
                    {
                        Enlace.GuardarProductos(producto);
                    }
                    MessageBox.Show("Carga Terminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            this.Close();
        }
    }
}
