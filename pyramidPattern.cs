using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_08
{
    class Program
    {
       public static void Main(string[] args)
        {
            int row;
            Console.WriteLine("enter the rows");
            row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for (int j=i; j <row; j++)
                {
                    Console.Write("  ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write(k+" ");
                }
                for(int l=1;l<i;l++)
                {
                    Console.Write(l+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
