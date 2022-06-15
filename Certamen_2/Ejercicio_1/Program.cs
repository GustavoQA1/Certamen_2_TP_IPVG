using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {

        //En un arreglo de tamaño 5 solicite al usuario los números para cada una de las posiciones, 
        //    luego pregunte al usuario un valor, 
        //    deberá mostrar los valores del arreglo que son mayores al valor dado por el usuario.
        static void Main(string[] args)
        {

            int[] arreglo = new int[5];
            int valor = 0;
          


            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                Console.Write(i + 1 + ".Ingrese Numero: ");
                arreglo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("El arreglo quedo expresado de esta forma");
            ImprimeVector(arreglo);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese un valor: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {            

                if(arreglo[i] > valor)
                {
                    Console.Write(arreglo[i] + " | ");
                }
            }
            Console.WriteLine();
         
            Console.ReadKey();
        }

        static void ImprimeVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " | ");
            }
        }


    }
}
    

