using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;
            Console.WriteLine("enter the row size of  matrix A");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the coloumn size of  matrix A");
            c1 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[r1, c1];
            Console.WriteLine("enter the row size of  matrix B");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the coloumn size of  matrix B");
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] B = new int[r2, c2];
           
            if(r1==r2 && c1==c2)
            {
                Console.WriteLine("enter the first matrix A");
                int[,] C = new int[r1, c1];
                for(int i=0;i<r1;i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("enter the matrix B");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("sum=");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                        Console.Write($"{C[i,j]} ");
                    }
                    Console.WriteLine();
                }

            }

            
            else
            {
                Console.WriteLine("matrix addition not possible");
            }

            Console.ReadLine();
        }
    }
}
