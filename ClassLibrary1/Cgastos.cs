using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cgastos
    {
        int id;
        string fecha;
        float monto;
        string detalle;

        public Cgastos(string fecha, float monto, string detalle)
        {
            this.fecha = fecha;
            this.monto = monto;
            this.detalle = detalle;
        }
        public Cgastos()
        {
            this.fecha = "";
            this.monto = 0;
            this.detalle = "";
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public float Monto { get => monto; set => monto = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int Id { get => id; set => id = value; }
    }
}
