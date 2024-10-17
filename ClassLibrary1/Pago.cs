using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pago
    {
        public int id;
        public string proveedor;
        public float importe;
        public string fecha;

        public Pago()
        {
        }

        public Pago(int id, string proveedor, float importe, string fecha)
        {
            this.id = id;
            this.proveedor = proveedor;
            this.importe = importe;
            this.fecha = fecha;
        }
    }
}
