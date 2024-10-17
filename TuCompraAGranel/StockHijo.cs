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
using TuCompraAGranel;

namespace DonPaulo
{
    public partial class StockHijo : Form
    {
        int contador = 0;
        conexion Enlace = new conexion();
        Producto pModificar = new Producto();
        public StockHijo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }


        private void StockHijo_Load_1(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            try
            {
                Stock frmStock = Application.OpenForms.OfType<Stock>().FirstOrDefault();
                if (frmStock != null)
                {
                    Enlace.devolverProducto(pModificar, frmStock.idP);
                    lblNombre.Text = pModificar.Nombre;
                    lblExistente.Text = "Quedan " + pModificar.Cantidad + " " + pModificar.Categoria;
                }
            }
            catch
            {
                this.Close();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada si no es un número o una tecla de control
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != string.Empty)
            {
                pModificar.Cantidad = pModificar.Cantidad + Convert.ToInt32(txtCantidad.Text);
                Enlace.ModificarCantidad(pModificar, "1", "Modulo Stock (Aumento)");
                this.Close();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {

            if (lblContraseña.Visible == true && txtContraseña.Visible == true)
            {
                if (txtContraseña.Text == "30048963")
                {
                    pModificar.Cantidad = pModificar.Cantidad - Convert.ToInt32(txtCantidad.Text);
                    if (pModificar.Cantidad < 0)
                    {
                        pModificar.Cantidad = 0;
                    }
                    Enlace.ModificarCantidad(pModificar, "1", "Modulo Stock (Decremento)");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Contraseña no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            btnSuma.Enabled = false;
            lblContraseña.Visible = true;
            txtContraseña.Visible = true;
            btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSuma.Enabled = true;
            btnCancelar.Enabled = false;
            lblContraseña.Visible = false;
            txtContraseña.Visible = false;
            txtContraseña.Text = string.Empty;
        }
    }
}
