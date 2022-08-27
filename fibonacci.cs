using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciforloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, limit,sum;
            Console.WriteLine("enter a limit");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{num1},{num2},");
            for(int i=0;i<limit-2;i++)
            {
                sum = num1 + num2;
                Console.Write($"{sum},");
                num1 = num2;
                num2 = sum;
            }
        }
    }
}
