using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo3
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int n;
            string lector = "";
            Console.Write("Digite un numero: ");
            lector = Console.ReadLine();
            n = Convert.ToInt32(lector);
            if (n % 2 == 0)
                Console.WriteLine("El numero {0} es par", n);
            else
                Console.WriteLine("El numero {0} es impar", n);
            Console.ReadKey();
        }
    }
}
