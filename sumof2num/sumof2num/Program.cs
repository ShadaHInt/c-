// See https://aka.ms/new-console-template for more information
using System;
    namespace example;
           class Program
{
    static void Main(string[] args )
    {
        int num1, num2, res;
        Console.WriteLine("Enter first number");
         num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
         num2 = int.Parse(Console.ReadLine());
         res = num1 + num2;
        Console.WriteLine(res);
    }

}

