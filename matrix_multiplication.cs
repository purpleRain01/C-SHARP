using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixmuti
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;
            Console.WriteLine("enter the row and coloumn size of matrix A");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the row and coloumn size of matrix B");
            r2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[r1,c1];
            int[,] B = new int[r2, c2];

            if(c1==r2)
            {
                int[,] C = new int[r1, c2];
                Console.WriteLine("enter the elements A");
                for(int i=0;i<r1;i++)
                {
                    for(int j=0;j<c1;j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("enter the elements B");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        for (int k = 0; k < c1; k++)
                        {
                            C[i, j] = C[i, j] + (A[i, k] * B[k, j]);
                        }
                    }
                }
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Console.Write($"{C[i,j]}  ");
                    }
                    Console.WriteLine();
                }

            }

            Console.ReadLine();

        }
    }
}
