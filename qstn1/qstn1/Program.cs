// See https://aka.ms/new-console-template for more information
using System;
namespace example;
class Program
{
    static void Main (string[]args)
    {
         int i;
         for(i=1;i<=8;i++)
         {
        if (i == 1)
            Console.WriteLine("*********");
        else if(i==8)
                Console.WriteLine("*********");
        else 
            Console.WriteLine("*       *");
          }
    Console.ReadLine();

    }
}
