using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo2
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            string lector = "";
            double g, r;
            Console.Write("Cuantos grados quiere convertir a radianes: ");
            lector = Console.ReadLine();
            g = Convert.ToInt32(lector);
            r = g * (3.1416 / 180);
            Console.WriteLine("{0} grados es igual a {1} radianes", g, r);
            Console.ReadLine();
        }
    }
}
