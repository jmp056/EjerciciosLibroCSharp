using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            string lector = "";
            int n;
            Console.Write("Digite un numero del 1 al 7: ");
            lector = Console.ReadLine();
            n = Convert.ToInt32(lector);
            switch (n)
            {
                case 1:
                    Console.Write("El numero {0} representa el lunes", n);
                    break;
                case 2:
                    Console.Write("El numero {0} representa el martes", n);
                    break;
                case 3:
                    Console.Write("El numero {0} representa el miercoles", n);
                    break;
                case 4:
                    Console.Write("El numero {0} representa el jueves", n);
                    break;
                case 5:
                    Console.Write("El numero {0} representa el viernes", n);
                    break;
                case 6:
                    Console.Write("El numero {0} representa el sabado", n);
                    break;
                case 7:
                    Console.Write("El numero {0} representa el domingo", n);
                    break;
                default: break;
            }
            Console.ReadKey();
        }
    }
}
