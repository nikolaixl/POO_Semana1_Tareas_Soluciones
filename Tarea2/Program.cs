using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora compu = new Computadora(1, "Gamemax", "Rojo", 200);
            bool sumar = true;
            while (sumar)
            {
                Console.WriteLine("Datos completos: ");
                compu.Listado();
                compu.PrecioDolares *= 0.90;
                Console.WriteLine("Datos completos modificados: ");
                compu.Listado();
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

