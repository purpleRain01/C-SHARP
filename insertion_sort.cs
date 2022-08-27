using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arra1 = new int[] { 1, 2, 3, 4, 9, 1, 4 };
            int current, j, i;
            for (i = 1; i < arra1.Length; i++)
            {
                current = arra1[i];
                j = i - 1;
                    while (j >= 0 && arra1[j] >current )
                    {
                        arra1[j + 1] = arra1[j];
                    j--;
                    }
                    arra1[j+1] = current;
            }
            foreach (int item in arra1)
            {
                Console.WriteLine($"{item},");
            }

            Console.ReadLine();
        
                
                    
        }
    }
}
