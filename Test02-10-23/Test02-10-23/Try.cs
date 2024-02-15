using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02_10_23
{
    
        public class Program
        {
            public static void Main(string[] args)
            {
                string  ch;
                string rev = string.Empty;
                int len;
                Console.WriteLine("enter string");
                ch = Console.ReadLine();
                len = ch.Length;
                for (int i = len - 1; i >= 0; i--)
                {
                    rev = rev + ch[i];
                }
                if (rev == ch)
                {
                    Console.WriteLine("palindrome");
                }
                else
                    Console.WriteLine("not palin");

            }
        }



    }



