using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Edificio
    {
        private int codigo { get; set; }
        private int departamentos { get; set; }

        private int pisosEdificio { get; set; }

        private double precioDepartamentoDolares { get; set; }

        public Edificio(int codigo, int departamentos, int pisosEdificio, double precioDepartamentoDolares)
        {
            this.codigo = codigo;
            this.departamentos = departamentos;
            this.pisosEdificio = pisosEdificio;
            this.precioDepartamentoDolares = precioDepartamentoDolares;
        }

        public int Codigo { get { return  codigo; } set { codigo = value; } }
        public int Departamentos { get { return departamentos; } set { departamentos = value; } }
        public int CopisosEdificiodigo { get { return pisosEdificio; } set { pisosEdificio = value; } }
        public double PrecioDepartamentoDolares { get { return precioDepartamentoDolares; } set { precioDepartamentoDolares = value; } }


        public double PrecioDolaresEdificio()
        {
            return (departamentos * precioDepartamentoDolares);

        }

        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Codigo: " + this.codigo);
            Console.WriteLine("Departamentos: " + this.departamentos);
            Console.WriteLine("Cantidad de pisos del Edificio: " + this.pisosEdificio);
            Console.WriteLine("Precio de un departamento en dolares: " + this.precioDepartamentoDolares);
            Console.WriteLine("----------------------------------------------");
        }




    }
}
