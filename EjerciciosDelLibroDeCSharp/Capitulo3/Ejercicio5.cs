using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo3
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string lector = "";
            int o;
            Console.WriteLine("Que decea calcular: ");
            Console.WriteLine("1 - El perimetro");
            Console.WriteLine("2 - El area");
            Console.Write("Seleccione la opcion deseada: ");
            lector = Console.ReadLine();
            o = Convert.ToInt32(lector);
            switch (o)
            {
                case 1:
                    {
                        float l, t, p;
                        Console.Write("Cuantos lados tiene el poligono: ");
                        lector = Console.ReadLine();
                        l = Convert.ToSingle(lector);
                        Console.Write("Cual es el tamaño de estos: ");
                        lector = Console.ReadLine();
                        t = Convert.ToSingle(lector);
                        p = l * t;
                        Console.WriteLine("El perimetro de este poligono es: {0}", p);
                    };
                    break;
                case 2:
                    {
                        float b, a, ar;
                        Console.Write("Cuanto mide la base: ");
                        lector = Console.ReadLine();
                        b = Convert.ToSingle(lector);
                        Console.Write("Cuanto tiene de altura: ");
                        lector = Console.ReadLine();
                        a = Convert.ToSingle(lector);
                        ar = (b * a) / 2;
                        Console.WriteLine("El area de este poligono es: {0}", ar);
                    };
                    break;
            }
            Console.ReadKey();
        }
    }
}
