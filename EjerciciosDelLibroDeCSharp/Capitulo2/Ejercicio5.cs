using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string lector = "";
            double d, c, e;
            Console.Write("Valor del dolar en Euro: ");
            lector = Console.ReadLine();
            d = Convert.ToInt32(lector);
            Console.Write("Cuantos dolares desea cabiar: ");
            lector = Console.ReadLine();
            c = Convert.ToInt32(lector);
            e = d * c;
            Console.Write("{0} Dolares hacen un total de: {1} Euros", c, e);
            Console.ReadKey();
        }
    }
}
