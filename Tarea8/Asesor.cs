using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    internal class Asesor
    {
        private int codigo { get; set; }
        private int horasTrabajadas { get; set; }
        private double tarifaHora { get; set; }

        public Asesor(int codigo, int horasTrabajadas, double tarifaHora)
        {
            this.codigo = codigo;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHora = tarifaHora;
        }

        public int Codigo { get { return codigo; } set { codigo = value; } }

        public int HorasTrabajadas { get { return horasTrabajadas; } set { horasTrabajadas = value; } }

        public double TarifaHora { get { return tarifaHora; } set { tarifaHora = value; } }



        public double sueldoBruto()
        {
            return (horasTrabajadas * tarifaHora);
        }
        public double descuentoSueldoBruto()
        {
            return (sueldoBruto() * 0.15);
        }
        public double sueldoNeto()
        {
            return (sueldoBruto() - descuentoSueldoBruto());
        }

        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Codigo: " + this.codigo);
            Console.WriteLine("Horas Trabajadas: " + this.horasTrabajadas);
            Console.WriteLine("Tarifa por hora: " + this.tarifaHora);
            Console.WriteLine("Sueldo Bruto: " + this.sueldoBruto());
            Console.WriteLine("Sueldo Neto: " + this.sueldoNeto());
           

            Console.WriteLine("----------------------------------------------");
        }
    }
}
