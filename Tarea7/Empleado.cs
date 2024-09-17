using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    internal class Empleado
    {

        private int codigo { get; set; }
        private string nombre { get; set; }

        private int numeroCelular { get; set; }

        private double sueldoSoles { get; set; }

        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldoSoles = sueldoSoles;
        }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int NumeroCelular { get { return numeroCelular; } set { numeroCelular = value; } }

        public double SueldoSoles { get { return sueldoSoles; } set { sueldoSoles = value; } }



        public string estadoSueldo()
        {
            if (sueldoSoles > 3500)
            {
                return "Mayor a 3500";
            }
            else if (sueldoSoles == 3500)
            {
                return "Igual a 3500";

            }
            else return "Menor a 3500";
        }

        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Codigo: " + this.nombre);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Numero Celular: " + this.numeroCelular);
            Console.WriteLine("Sueldo Soles: " + this.sueldoSoles);
            Console.WriteLine("Estado Sueldo: " + this.estadoSueldo());
           


            Console.WriteLine("----------------------------------------------");
        }
    }
}
