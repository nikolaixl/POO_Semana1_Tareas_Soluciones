using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    internal class Pelota
    {
        private string marca { get; set; }
        private double pesoGramos { get; set; }
        private double presionLibras { get; set; }

        private double diametroCentimetros { get; set; }
        private double precio { get; set; }

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCentimetros, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCentimetros = diametroCentimetros;
            this.precio = precio;
        }

        public string Marca { get { return marca; } set { marca = value; } }
        public double PesoGramos { get { return pesoGramos; } set { pesoGramos = value; } }
        public double PresionLibras { get { return presionLibras; } set { presionLibras = value; } }
        public double DiametroCentimetros { get { return diametroCentimetros; } set { diametroCentimetros = value; } }
        public double Precio { get { return precio; } set { precio = value; } }


        public double pRadio()
        {
            return (diametroCentimetros / 2);
        }
        public double volumenBalon()
        {
            return (4 * 3.1416 * pRadio() * pRadio() * pRadio() / 3);
        }
        public double pDescuento()
        {
            return (precio * 0.10);
        }
        public double importePagar()
        {
            return (precio - pDescuento());
        }


        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Marca: " + this.marca);
            Console.WriteLine("Peso en Gramos: " + this.PesoGramos);
            Console.WriteLine("Presion en Libras: " + this.PresionLibras);
            Console.WriteLine("Diametro en Centimetros: " + this.diametroCentimetros);
            Console.WriteLine("Precio: " + this.precio);
            Console.WriteLine("Radio: " + this.pRadio());
            Console.WriteLine("Volumen del Balon: " + this.volumenBalon());
            Console.WriteLine("Descuento: " + this.pDescuento());
            Console.WriteLine("Importe a Pagar: " + this.importePagar());
            Console.WriteLine("----------------------------------------------");
        }
    }
}
