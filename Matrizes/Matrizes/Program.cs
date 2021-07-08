using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double[,] mat = new double[2, 3];
             Console.WriteLine(mat.Length);
             Console.WriteLine(mat.Rank); //primeira dimensão(linhas)
             Console.WriteLine(mat.GetLength(0)); //quantidade de linhas(dimensao)
             Console.WriteLine(mat.GetLength(1)); //quantidade de colunas(dimensao)

             */

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' '); //para inserir tudo na mesma linha

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        count++;
                }
            }

            Console.WriteLine("Negative Numbers:" + count);

        }
    }
}
