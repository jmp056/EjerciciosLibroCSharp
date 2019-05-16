using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroDeCSharp.Capitulo6
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            programa();
            Console.ReadKey();
        }

        static void programa()
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            int contador = 0;
            string valor = "";

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f; //Variable para la calificación mínima
            float maxima = 0.0f; //Variable para la calificación maxima

            // Pedimos la cantidad de salones
            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            // Creamos el arreglo
            float[][] calif = new float[salones][];

            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.Write("Dame la cantidad de alumnos para el salon {0}: ", n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);

                // Instanciamos el arreglo
                calif[n] = new float[cantidad];
            }

            // Capturamos la información
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) //Ciclo alumnos
                {
                    Console.Write("Dame la calificación: ");
                    valor = Console.ReadLine();
                    calif[n]
                    [m] = Convert.ToSingle(valor);
                }
            }

            // Desplegamos la información
            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);
                    if (calif[n][m] < minima)
                        minima = calif[n][m];
                    else if (calif[n][m] > maxima)
                        maxima = calif[n][m];
                    promedio += calif[n][m];
                    contador++;
                }
                Console.WriteLine("El promedio es: {0}", promedio / contador);
                Console.WriteLine("La nota menor es: {0}", minima);
                Console.WriteLine("La nota mayor es: {0}", maxima);
                contador = 0;
                promedio = 0;
                minima = 10;
                maxima = 0;
            }
        }
    }
}
