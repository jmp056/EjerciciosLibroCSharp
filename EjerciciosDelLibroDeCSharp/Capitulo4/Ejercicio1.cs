using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo4
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            string lector = "";
            int n, r;
            Console.Write("Ingrese el numero el cual desea multiplicar: ");
            lector = Console.ReadLine();
            n = Convert.ToInt32(lector);
            for (int x = 1; x <= 10; x++)
            {
                r = n * x;
                Console.WriteLine("{0} x {1} = {2}", x, n, r);
            }

            Console.ReadLine();
        }
    }
}
