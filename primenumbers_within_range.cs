using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //    checkprime();
            primrange();
        }
        public static void primrange()
        {
            int limit,count=0;
            Console.WriteLine("enter the range to print");
            limit = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=limit;i++)
            {
                int tempnumber = i;
                int j = 1;
                while(j<=tempnumber/2)
                {
                    if(tempnumber%j==0)
                    {
                        count++;
                    }
                    j++;
                }
                if (count == 1)
                {
                    Console.Write(i + ",");
                }
                count = 0;

            }
            Console.WriteLine();

        }
        public static void checkprime()
        {
            int number,count=0;
            Console.WriteLine("enter the number to check");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=number/2;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==1)
            {
                Console.WriteLine($"{number} is prime");
            }
            else
            {
                Console.WriteLine($"{number} is not prime");
            }
        }
        
    }
}
