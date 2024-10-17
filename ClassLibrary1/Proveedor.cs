using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Proveedor
    {
        private int id;
        private string nombre;

        public Proveedor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Proveedor()
        {
            this.nombre = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int devolverId(List<Proveedor> listaProveedores, string nombre)
        {
            int id=-1;
            foreach (var item in listaProveedores)
            {
                if (nombre == item.nombre)
                {
                    id = item.id;
                    return id;
                }
            }
            return id;
        }

    }
}
