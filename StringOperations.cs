using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_08excerscise
{
    class Program
    {
        static void Main(string[] args)
        {
            individual();
            wordscount();
            integerremoval();
            concatinated();
        }
        private static void concatinated()
        {
            string first, second;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("CONCATINATION");
            Console.WriteLine("____________________");
            Console.WriteLine("enter first string");
            first =Console.ReadLine();
            Console.WriteLine("enter first string");
            second =Console.ReadLine();

            int flength = first.Length-1;
            int slength = second.Length-1;
            int i,total=slength+flength;

            for(i=0;i<=flength;i++)
            {
                sb.Append(first[i]);
            }
    
            for (i=0; i <= slength; i++)
            {
                sb.Append(second[i]);
            }
            Console.WriteLine("concatinated string is " +
                ""+sb);
            Console.ReadLine(); 

        }
        private static void integerremoval()
        {
            Console.WriteLine("REMOVING INTEGER FROM THE STRING");
            Console.WriteLine("_________________________________");
            Console.WriteLine("enter the text");
            int[] arr = new int[10];
            string input =Console.ReadLine();
            int length = input.Length,i=0;
            while (i < length)
            {
                arr[i] = Convert.ToInt32(input[i]);
                i++;
            }
            i = 0;
            while (i < length)
            {
                if (arr[i] <48 || arr[i]>57)
                {
                    Console.Write(input[i]);
                }
                i++;
            }
        

            Console.ReadLine();

        }
        private static void wordscount()
        {
            string str;
            Console.WriteLine("COUNTING THE NUMBER OF WORDS IN A STRING");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("enter a text");
            str =Console.ReadLine();
            int count=0,length = str.Length-1;
            while(length>=0)
            {
                if (str[length] == ' ')
                {
                    count += 1;
                }
                length--;
            }
            Console.WriteLine("{0} contains {1} words",str,count+1);
        }
        private static void individual()
        {
            string str;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("CONVERTING STRING TO INDIVITUAL CHARECTERS");
            Console.WriteLine("___________________________________________");
            Console.WriteLine("enter the text");
            str = Console.ReadLine();
            int length = str.Length;
            length--;
            while (length >= 0)
            {
                sb.Append(str[length]);
                sb.Append(" ");
                length--;
            }
            Console.WriteLine(sb);
        }
    }
}
