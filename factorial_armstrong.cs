using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _26_08class
{
    class Program
    {
        static void Main(string[] args)
        {
            //armstrong();
            //fibonacci();
            //forevaluate();
            foctorial();

            Console.ReadLine();

        }
        public static void foctorial()
        {
            int limit,factorial=1;
            Console.WriteLine("Enter the number ");
            limit = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=limit;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"factorial of {limit} is {factorial}");
        }
        public static void forevaluate()
        {
            for(int i=1;i<=10;i++)
            {
                Console.Write(i+",");
            }
        }
        public static void fibonacci()
        {
            int num1 = 0, num2 = 1, sum,i=0;
            int limit;
            
            Console.Write("enter a limit");

            limit = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2+" ");
            while (i<limit-2)
            {
                sum = num1 + num2;
                Console.Write($"{sum} ");
                num1 = num2;
                num2 = sum;
                i++;
            }

          
        }
        public static void armstrong()
        {
            int number, mod, sum = 0, temp;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number != 0)
            {
                mod = number % 10;
                sum = sum + (mod * mod * mod);
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"{temp} is armstrong number");
            }
            else
            {
                Console.WriteLine($"{temp} is not an armstrong number");
            }
        }
    }
}
