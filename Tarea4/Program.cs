using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obre = new Obrero(1, "PEDRO", 8, 30);
            bool sumar = true;

            while (sumar)
            {
                Console.WriteLine("Datos Completos: ");
                obre.Listado();
                obre.Horatrabajadas += 8;
                obre.Tarifahora *= 1.5;
                Console.WriteLine("Datos Completos Modificados: ");
                obre.Listado();
                string okno;
                do
                {
                    Console.WriteLine("Quieres continuar?: ");
                    okno = Console.ReadLine().ToLower();
                    if (okno != "si" && okno != "no")
                    {
                        Console.WriteLine("Por favor, ingrese 'si' para continuar o 'no' para salir.");
                    }
                } while (okno != "si" && okno != "no");
                if(okno == "no") { 
                    sumar = false;
                    Console.WriteLine("Gracias: ");
                }
            }

        }
    }
}
