using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo4
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string lector = "";
            int p, ma, me, pro, v;
            Console.Write("Cuantas personas hay en el grupo: ");
            lector = Console.ReadLine();
            p = Convert.ToInt32(lector);
            Console.Write("Edad 1: ");
            lector = Console.ReadLine();
            v = Convert.ToInt32(lector);
            ma = v;
            me = v;
            pro = v;
            for (int x = 2; x <= p; x++)
            {
                Console.Write("Edad {0}: ", x);
                lector = Console.ReadLine();
                v = Convert.ToInt32(lector);
                if (v > ma)
                    ma = v;
                if (v < me)
                    me = v;
                pro += v;
            }
            pro /= p;
            Console.WriteLine("La edad promedio es: {0}", pro);
            Console.WriteLine("La edad mayor es: {0}", ma);
            Console.WriteLine("La edad menor es: {0}", me);
            Console.ReadLine();
        }
    }
}
