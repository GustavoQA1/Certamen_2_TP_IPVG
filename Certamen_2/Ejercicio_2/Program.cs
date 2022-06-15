using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Genere en un arreglo de 8 x 8 la siguiente figura
          


            {

                string[,] mat = new string[8,8];
           

                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        if (i == 3 || i == 4 || j == 3 || j == 4)
                            mat[i, j] = "1";
                        else
                            mat[i, j] = "0";
                    }
                
                }

                imprimir(mat);
                Console.ReadKey();
            }

        }

        static void imprimir(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine();
            }


        }
    }
}
    

