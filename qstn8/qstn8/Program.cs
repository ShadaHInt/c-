using System;
namespace exm;
class pgm
{
    static void Main(string[] args)
    {
        int i;
        for (i = 0; i < 12; i++)
        {
            if (i == 1 || i == 11)
                Console.WriteLine("       *");
            else if (i == 2 || i == 10)
                Console.WriteLine("     *   *");
            else if (i == 3 || i == 9)
                Console.WriteLine("    *      *");
            else if (i == 4 || i == 8)
                Console.WriteLine("   *         *");//3
            else if (i == 5 || i == 7)
                Console.WriteLine("  *           *");
            else if (i == 6)
                Console.WriteLine("*               *");

        }
        Console.ReadLine();
    }
}
