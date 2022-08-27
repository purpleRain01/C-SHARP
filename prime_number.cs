using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main()
        {
            //primenumber();
            //  pattern();
            //pattern1();
            pattern2();
        }
        public static void pattern2()
        {
            int row, x = (int)'A';
            Console.WriteLine("enter the rows");
            row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)x + " ");
                    x += 1;
                }
                Console.WriteLine();
            }

        }
        public static void pattern1()
        {
            int row,x=2;
            Console.WriteLine("enter the rows");
            row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(x+" ");
                    x += 2;
                }
                Console.WriteLine();
            }
        }
        public static void pattern()
        {
            int row;
            Console.WriteLine("enter the number of rows");
            row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        public static void primenumber()
        {
            int number, i, flag = 0;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    flag++;
                }
            }
            if (flag == 2)
            {
                Console.WriteLine($"{number} is prime");
            }
            else
            {
                Console.WriteLine($"{number} is not prime ");
            }
        }
    }
}
