using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VentaCabecera
    {
        string fecha;
        string hora;
        float totalVenta;
        string metodoDePago;
        int IdBoleta;

        public VentaCabecera(string fecha, string hora, float totalVenta, string metodoDePago, int idBoleta)
        {
            this.fecha = fecha;
            this.hora = hora;
            this.totalVenta = totalVenta;
            this.metodoDePago = metodoDePago;
            IdBoleta = idBoleta;
        }
        public VentaCabecera()
        {
            this.fecha = "";
            this.hora = "";
            this.totalVenta = 0;
            this.metodoDePago = "";          
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public float TotalVenta { get => totalVenta; set => totalVenta = value; }
        public string MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public int IdBoleta1 { get => IdBoleta; set => IdBoleta = value; }



        public List<VentaCabecera> CabecerasHoy(List<VentaCabecera> Cabeceras)
        {
            List < VentaCabecera >aux = new List<VentaCabecera>();
            string fechaHoy = DateTime.Today.ToString("dd/MM/yyyy");


            foreach (var item in Cabeceras)
            {
                if (item.fecha == fechaHoy)
                {
                    VentaCabecera v1 = new VentaCabecera();
                    v1.Fecha = item.Fecha;
                    v1.Hora = item.Hora;
                    v1.TotalVenta = item.TotalVenta;
                    v1.MetodoDePago = item.MetodoDePago;
                    v1.IdBoleta1 = item.IdBoleta1;
                    aux.Add(v1);
                }
                
            } 
            return aux;
        }
    }
}
