using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddoreven
{
    class Program
    {
        static void Main(string[] args)
        {
            oddeven();
            largest();
            natural();
            Console.Read();
        }
        private static void oddeven()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even", number);
            }
            else
            {
                Console.WriteLine("{0} is odd ", number);
            }
           
        }
        private static void largest()
        {
            int num1, num2, num3;
            Console.WriteLine("enter 3 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if(num1>num3)
                    Console.WriteLine("{0} is greatest",num1);
                else
                {
                    Console.WriteLine("{0} is greatest", num3);
                }
            }    
            else if(num2>num3)
            {
                Console.WriteLine("{0} is greatest", num2);
            }
            else
            {
                Console.WriteLine("{0} is greatest", num3);
            }
        }
        private static void natural()
        {
            int limit, iteration = 1;
            Console.WriteLine("enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("natural numbers are");
            while(iteration<=limit)
            {
                Console.WriteLine(iteration);
                iteration += 1;

            }
            
        }
    }
}
