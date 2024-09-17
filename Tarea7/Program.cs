using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado(1, "JUAN", 945123654, 3100);
            bool verificar = true;

            while (verificar)
            {
                Console.WriteLine("Datos Completos: ");
                emp.Listado();
                emp.NumeroCelular = 999888777;
                emp.SueldoSoles += 200;
                Console.WriteLine("Datos Completos Modificados: ");
                emp.Listado();
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
                    verificar = false;
                    Console.WriteLine("Gracias");
                }
            }
        }
    }
}
