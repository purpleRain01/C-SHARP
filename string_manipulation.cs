using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace join_concaqt
{
    class Program
    {
        static void Main(string[] args)
        {
            string_concat();
            string_join();
            Console.ReadKey();
        }
        public static void string_concat()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 6 };
            string str;
            str = string.Concat(array1);
            Console.WriteLine("concatenated result= "+str);
        }
        public static void string_join()
        {

            int[] arra = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            string str = string.Join(",", arra);
            Console.WriteLine("join method result= "+str);
            Console.WriteLine(str.GetType());
            string str1 = "arun,aishu,jisha,arya";
            string[] array1 =str1.Split(',') ;


            Array.ForEach(array1, x => Console.WriteLine(x));

        }
    }
}
