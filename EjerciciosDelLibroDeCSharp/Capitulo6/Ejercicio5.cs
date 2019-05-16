using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo6
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int[][] numeros = new int[][]
            {
                new int[] { 9, 3, 1, 7, 2, 4 },
                new int[] { 2, 9 },
                new int[] { 3, 5, 2, 9 }
            };
            imprime(numeros);
            Console.ReadKey();
        }

        static void imprime(int[][] numeros)
        {
            for (int x = 0; x  3; x++)
            {
                for (int y = 0; y  numeros[x].GetLength(0); y++)
                    Console.Write({ 0}  , numeros[x][y]);
                Console.Write(n);
            }
        }
    }
}
