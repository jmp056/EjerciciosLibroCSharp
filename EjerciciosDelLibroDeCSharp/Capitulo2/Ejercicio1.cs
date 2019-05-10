using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            string lector = "";
            float l, t, p;
            Console.Write("Cuantos lados tiene el poligono: ");
            lector = Console.ReadLine();
            l = Convert.ToSingle(lector);
            Console.Write("Cual es el tamaño de estos: ");
            lector = Console.ReadLine();
            t = Convert.ToSingle(lector);
            p = l * t;
            Console.WriteLine("El perimetro de este poligono es: {0}", p);
            Console.ReadKey();
        }
    }
}
