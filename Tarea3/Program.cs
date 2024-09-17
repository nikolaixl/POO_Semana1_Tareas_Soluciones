using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio edi = new Edificio(1, 5, 10, 30000);
            edi.Listado();
            bool sumar = true;
            while (sumar)
            {
                Console.WriteLine("Datos Completos: ");
                edi.Listado();
                edi.PrecioDepartamentoDolares *= 1.20;
                Console.WriteLine("Datos Completos Modificados: ");
                edi.Listado();
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
                    if (okno == "no")
                    {
                        sumar = false;
                        Console.WriteLine("Gracias");
                    }

                
                    
                    
            }
        }
    }
}

