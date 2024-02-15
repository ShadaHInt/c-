// See https://aka.ms/new-console-template for more information
using System;
namespace example;

class Program
{
    static void Main(string[]args)
    {
        int i, j;
        for(i=1;i<=5;++i)
        {
            for (j = 1; j <= i; ++j)
            {
                Console.Write("1");
                if (i == 2 || i == 4)
                    Console.Write("0" + "1");
           
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
