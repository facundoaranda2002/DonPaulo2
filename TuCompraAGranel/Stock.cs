using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DonPaulo
{
    public partial class Stock : Form
    {
        public int idP;
        conexion Enlace = new conexion();
        List<Proveedor> proveedores = new List<Proveedor>();
        Proveedor nProveedor = new Proveedor();
        public List<(int, string, string, string, string, string)> listaInfo = new List<(int, string, string, string, string, string)>();
        public List<(int, string, string, string, string, string)> listaFiltrada = new List<(int, string, string, string, string, string)>();


        public Stock()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            cargarLista();
            cargarGrid(listaInfo, dataGridView1);
            Cargacombo();
        }
        public void Cargacombo()
        {
            Enlace.VerProveedores(proveedores);
            cmbProveedor.Items.Add("");
            cmbCategoria.Items.Add("");
            cmbCategoria.Items.Add("Litros");
            cmbCategoria.Items.Add("Unidades");
            cmbEstado.Items.Add("");
            cmbEstado.Items.Add("Bien");
            cmbEstado.Items.Add("Regular");
            cmbEstado.Items.Add("Mal");
            foreach (var item in proveedores)
            {
                cmbProveedor.Items.Add(item.Nombre);
            }


        }


        private void cargarLista()
        {

            conexion Enlace = new conexion();
            List<Producto> listaP = new List<Producto>();
            listaP = Enlace.ObtenerDatosProductos();
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
                int rowIndex = dataGridView1.Rows.Add(item.Item2, item.Item3, item.Item4, item.Item5, item.Item6, item.Item1);
                switch (item.Item6)
                {
                    case "Bien":
                        data.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                        data.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        break;
                    case "Regular":
                        data.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                        data.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        break;
                    case "Mal":
                        data.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Firebrick;
                        data.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;

                        break;
                }
            }
        }

        private void FiltrarProductos()
        {
            string nombre = txtNombre.Text;
            string proveedor = cmbProveedor.SelectedItem as string;
            string categoria = cmbCategoria.SelectedItem as string;
            string estado = cmbEstado.SelectedItem as string;

            listaFiltrada.Clear();
            listaFiltrada.AddRange(listaInfo);

            // Filtrar la lista en función del nombre mientras se va escribiendo
            if (!string.IsNullOrEmpty(nombre))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Item2.ToLower().Contains(nombre.ToLower())).ToList();
            }

            // Filtrar la lista por proveedor
            if (!string.IsNullOrEmpty(proveedor))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Item3 == proveedor).ToList();
            }

            // Filtrar la lista por categoría
            if (!string.IsNullOrEmpty(categoria))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Item5 == categoria).ToList();
            }

            // Filtrar la lista por estado
            if (!string.IsNullOrEmpty(estado))
            {
                listaFiltrada = listaFiltrada.Where(p => p.Item6 == estado).ToList();
            }

            // Aplicar los filtros al DataGridView
            dataGridView1.Rows.Clear();
            cargarGrid(listaFiltrada, dataGridView1);
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductos();

        }
        private void StockHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listaInfo.Clear();
            dataGridView1.Rows.Clear();
            cargarLista();
            cargarGrid(listaInfo, dataGridView1);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idP = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            StockHijo frm = new StockHijo();
            frm.FormClosed += StockHijo_FormClosed;
            frm.ShowDialog();


        }
    }
}

