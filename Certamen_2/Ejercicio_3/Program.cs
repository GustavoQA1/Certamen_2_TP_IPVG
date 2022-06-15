using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Genere un arreglo de tamaño 10, complete cada una de sus posiciones.
            //Con valores enteros de 50 a 200 de forma aleatoria(random),
            //luego indique en qué posición del arreglo se encuentra el valor mayor y el menor 



            var random = new Random();
            
            int[] vector = new int[10];
            int may = vector[0];
            int men = vector[0];
            int pos_may = 1;
            int pos_men = 1;

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(50, 200);
            }
            Console.WriteLine("El arreglo de 10 posiciones registra estos numeros aleatorios");
            ImprimirVector(vector);
            Console.WriteLine();


            for (int i = 0; i < vector.Length; i++)

            {
                if (vector[i] > may)
                { 
                may = vector[i];
                pos_may = i;
   

                }
                for (int j = 0; j < vector.Length; j++)
                {
                    if (vector[i] < may)
                    {

                        men = vector[j];
                        pos_men = j;
                    }
                }

            }

       
   

            Console.WriteLine("El numero mayor es:" + vector.Max());
            Console.WriteLine("La posición del mayor es: " + pos_may);

            Console.WriteLine("El numero menor es:" + vector.Min());
            Console.WriteLine("La posición del mayor es: " + pos_men);

            Console.ReadKey();
        }

        static void ImprimirVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}
