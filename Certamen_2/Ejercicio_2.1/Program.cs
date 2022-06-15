using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1
{
    internal class Program
    {

      


        static void Main(string[] args)
        {

            //Genere en un arreglo de 8 x 8 la siguiente figura,
            //la figura deberá funcionar en pruebas con arreglos de
            //4x4

            {

                string[,] mat = new string[4, 4];


                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        if (i == 1 || i == 2 || j == 1 || j == 2)
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

