using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor ase = new Asesor(1, 8, 30);
            bool verificar = true;
            while (verificar)
            {
                Console.WriteLine("Datos Completos: ");
                ase.Listado();
                ase.HorasTrabajadas += 10;
                ase.TarifaHora *= 0.85;
                Console.WriteLine("Datos Completos Modificados: ");
                ase.Listado();
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
