using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video vi = new Video(1, "KING KONG", 2, 30, 3.78);
            bool sumar = true;
            while (sumar)
            {
                Console.WriteLine("Datos Completos: ");
                vi.Listado();
                vi.Preciosoles += 5.50;
                string okno;

                do
                {
                    Console.WriteLine("Quieres Continuar?: ");
                    okno = Console.ReadLine().ToLower();
                    if (okno != "si" && okno != "no")
                    {
                        Console.Write("Por favor, ingrese 'si' para continuar o 'no' para salir.");
                    }

                } while (okno != "si" && okno != "no");
                    if(okno == "no")
                {
                    sumar = false;
                    Console.WriteLine("Gracias");
                }
            }
        }
    }
}
