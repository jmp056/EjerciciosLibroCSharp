using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo4
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string lector = "";
            int n, p, r = 1;
            Console.Write("Digite un numero: ");
            lector = Console.ReadLine();
            n = Convert.ToInt32(lector);
            Console.Write("Digite la potencia a la cual se va a elevar: ");
            lector = Console.ReadLine();
            p = Convert.ToInt32(lector);
            for (int x = 1; x <= p; x++)
                r *= n;
            Console.WriteLine("{0} elevado a {1} es igual a: {2}", n, p, r);
            Console.ReadLine();
        }
    }
}
