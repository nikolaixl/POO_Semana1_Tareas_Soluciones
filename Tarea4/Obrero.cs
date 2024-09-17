using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class Obrero
    {

        private int codigo { get; set; }

        private string nombre { get; set; }

        private int horatrabajadas { get; set; }

        private double tarifahora { get; set; }

        public Obrero(int codigo, string nombre, int horatrabajadas, double tarifahora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horatrabajadas = horatrabajadas;
            this.tarifahora = tarifahora;
        }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int Horatrabajadas { get { return horatrabajadas; } set { horatrabajadas = value; } }

        public double Tarifahora { get { return tarifahora; } set { tarifahora = value; } }


        public double sueldoBruto()
        {
            return (horatrabajadas * tarifahora);
        }

        public double descuentoAFP()
        {
            return (sueldoBruto() * 0.10);
        }
        public double descuentoEPS()
        {
            return (sueldoBruto() * 0.05);
        }
        public double sueldoNeto()
        {
            return (sueldoBruto() - descuentoAFP() - descuentoEPS());
        }

        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Codigo: " + this.codigo);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Horas trabajadas: " + this.horatrabajadas);
            Console.WriteLine("Tarifa por hora: " + this.tarifahora);
            Console.WriteLine("Sueldo Bruto: " + this.sueldoBruto());
            Console.WriteLine("Descuento AFP: " + this.descuentoAFP());
            Console.WriteLine("Descuento EPS: " + this.descuentoEPS());
            Console.WriteLine("Sueldo Neto: " + this.sueldoNeto());
            Console.WriteLine("----------------------------------------------");
        }
    }
}
