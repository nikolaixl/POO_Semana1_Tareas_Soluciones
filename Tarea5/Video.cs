using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    internal class Video
    {
        private int codigo { get; set; }
        private string nombrevideo { get; set; }

        private double duracion { get; set; }

        private double preciosoles { get; set; }
        private double tipoCambio { get; set; }

        public Video(int codigo, string nombrevideo, double duracion, double preciosoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombrevideo = nombrevideo;
            this.duracion = duracion;
            this.preciosoles = preciosoles;
            this.tipoCambio = tipoCambio;
        }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombrevideo { get { return nombrevideo; } set { nombrevideo = value; } }
        public double Duracion { get { return duracion; } set { duracion = value; } }
        public double Preciosoles { get { return preciosoles; } set { preciosoles = value; } }
        public double TipoCambio { get { return tipoCambio; } set { tipoCambio = value; } }

        public double precioVideoDolares()
        {
            return (preciosoles / tipoCambio);
        }
        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Codigo: " + this.codigo);
            Console.WriteLine("Nombre del Video: " + this.nombrevideo);
            Console.WriteLine("Duracion: " + this.duracion);
            Console.WriteLine("Precio en soles: " + this.preciosoles);
            Console.WriteLine("Tipo de Cambio: " + this.tipoCambio);
            Console.WriteLine("Precio en dolares: " + this.precioVideoDolares());

            Console.WriteLine("----------------------------------------------");
        }
    }
}
