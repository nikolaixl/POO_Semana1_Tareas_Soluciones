using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Celular
    {
        private int numero { get; set; }
        private string usuario { get; set; }
        private int segundosconsumidos { get; set; }
        private double precioporsegundo { get; set; }
        public Celular(int numero, string usuario, int segundosconsumidos, double precioporsegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosconsumidos = segundosconsumidos;
            this.precioporsegundo = precioporsegundo;
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int SegundosConsumidos
        {
            get { return segundosconsumidos; }
            set { segundosconsumidos = value; }
        }

        public double PrecioPorSegundo
        {
            get { return precioporsegundo; }
            set { precioporsegundo = value; }
        }
        public double costoporconsumo()
        {
            return (segundosconsumidos * precioporsegundo);
        }
        public double impuestoIGV()
        {
            return (0.18 * costoporconsumo());
        }
        public double totalPagar()
        {
            return (costoporconsumo() + impuestoIGV());
        }
        public void Listado()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Número: " + this.numero);
            Console.WriteLine("Usuario: " + this.usuario);
            Console.WriteLine("Segundos consumidos: " + this.segundosconsumidos);
            Console.WriteLine("Precio por segundo: " + this.precioporsegundo);
            Console.WriteLine("Costo por consumo: " + this.costoporconsumo());
            Console.WriteLine("Impuesto IGV: " + this.impuestoIGV());
            Console.WriteLine("Total a pagar: " + this.totalPagar());
            Console.WriteLine("----------------------------------------------");
        }

    }
}
