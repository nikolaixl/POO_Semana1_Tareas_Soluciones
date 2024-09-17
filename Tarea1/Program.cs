using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular(945133651, "PEDRO", 30, 20);
            bool sumar = true;
            while (sumar)
            {
                Console.WriteLine("Datos completos: ");
                celular.Listado();
                celular.SegundosConsumidos += 20;
                celular.PrecioPorSegundo *= 0.95;
                Console.WriteLine("Datos completos modificados: ");
                celular.Listado();
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
