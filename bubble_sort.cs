using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[] { 1,3,2,10,8,4,1,6,5};
            for (int i=0;i<arr.Length;i++)
            {
               
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(var item in arr)
            {
                Console.WriteLine($"{item},");
            }

            Console.ReadLine();
        }
    }
}
