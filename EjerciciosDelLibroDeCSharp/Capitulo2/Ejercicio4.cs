using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            string lector = "";
            double c, f;
            Console.Write("Cuantos grados Celsius quiere convertir a grados Fahrenheit: ");
            lector = Console.ReadLine();
            c = Convert.ToInt32(lector);
            f = (c * 1.8) + 32;
            Console.Write("{0} Grados Celsius son {1} Grados Fahrenheit", c, f);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
