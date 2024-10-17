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

namespace DonPaulo
{
    public partial class Form1 : Form
    {
        DataTable ventas = new DataTable();
        conexion enlace = new conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ventas = enlace.RellenarDataGrid("Log", "");
            dataGridView1.DataSource = ventas;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
                column.Resizable = DataGridViewTriState.False;
                switch (column.Name)
                {
                    case "fecha":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        break;
                    case "mensaje":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "modulo":
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        break;

                }
            }
        }
    }
}
