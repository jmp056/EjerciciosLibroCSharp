using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo5
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            factorial();
            Console.ReadKey();
        }

        static void factorial()
        {
            string lector = "";
            float n, r = 1;
            Console.Write("Digite un numero: ");
            lector = Console.ReadLine();
            n = Convert.ToInt32(lector);
            for (int x = 1; x <= n; x++)
                r *= x;
            Console.Write("El factorial de {0} es {1}", n, r);
        }
    }
}
