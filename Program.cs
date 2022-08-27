using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace stringbuiler_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stringbuildr = new Stopwatch();//stringbuilder section
            stringbuildr.Start();
            string_Builder();
            stringbuildr.Stop();
            Console.WriteLine(stringbuildr.ElapsedMilliseconds+"ms");

            Stopwatch normalstop = new Stopwatch();//normal process section
            normalstop.Start();
            normal();
            normalstop.Stop();
            Console.WriteLine(normalstop.ElapsedMilliseconds + "ms");

            Console.ReadKey();

        }
        public static void string_Builder()
        {   
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i);
            }
        }
        public static void normal()
        {
            string s = "";
            for(int i=0;i<1000;i++)
            {
                s += i;
            }
        }
    }
}
