using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ls = new List<string>();
            string str = "i.like.this.program.very.much";
            ls = str.Split('.').ToList();
            foreach(var a in ls)
            {
              Console.WriteLine(a);
            }
            ls.Reverse();
            string result;
            result=string.Join(".",ls);  
           /* string s = "";             
            foreach (var a in ls)      
            {
                s = s + a;
                s = s + ".";
            }
            s = s.Remove(s.Length - 1, 1);*/
            Console.WriteLine(result);          
            Console.ReadKey();
        }
    }
}
