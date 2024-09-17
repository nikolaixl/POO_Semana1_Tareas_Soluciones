using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paci = new Paciente("PEDRO","SUAREZ", 20, 176, 80);
            bool sumar = true;
            while (sumar)
            {
                Console.WriteLine("Datos Completos: ");
                paci.Listado();
                paci.Edad = 10;
                Console.WriteLine("Datos Completos Modificados: ");
                paci.Listado();
                string okno;
                do
                {
                    Console.WriteLine("Quieres continuar?: ");
                    okno = Console.ReadLine().ToLower();
                    if (okno != "si" && okno != "no")
                    {
                        Console.WriteLine("Por favor, ingrese 'si' para continuar o 'no' para salir");
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
