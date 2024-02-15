using System;
namespace exam;
{
class Pgm
{
    static void Main(string[]args)
    {
        int a = new int[5];
        Console.WriteLine("enter array elements");
        for (int i = 0; i < args.Length; i++)
            a[i] = Convert.ToInt32(Console.ReadLine());
        for ( i = 0; i < args.Length; i++)
            Console.WriteLine(a[i]);
    }
}
}