using System;
namespace example;
class Prog
{
    static void Main(string[] args)
    {
        int b, n, res=1;
        Console.WriteLine("Enter the number");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter power");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            res = res * b;
        }
        Console.WriteLine("result is"+res);
        Console.ReadLine();
    }
}