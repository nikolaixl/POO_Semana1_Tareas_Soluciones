using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pe = new Pelota("Walon", 20, 30, 10, 50);
            bool verificar = true;
            while (verificar)
            {
                Console.WriteLine("Datos Completos: ");
                pe.Listado();
                pe.Precio *= 0.75;
                pe.DiametroCentimetros += 1;
                Console.WriteLine("Datos Completos Modificados: ");
                pe.Listado();
                string okno;
                do
                {
                    Console.WriteLine("Quieres Continuar?: ");
                    okno = Console.ReadLine().ToLower();
                    if (okno != "si" && okno != "no")
                    {
                        Console.WriteLine("Por favor, ingrese 'si' para continuar o 'no' para salir");
                    }
                } while (okno != "si" && okno != "no");
                if(okno == "no")
                {
                    verificar = false;
                    Console.WriteLine("Gracias");
                }
            }


        }
    }
}
