using System;
namespace program;
class assessment
{
    static void Main(string[]args)
    {
        int i, j, c = 0, d = 0, e = 0;
        //upper half
        for (i = 5; i >= 1; i--)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(j);
                c = c + 1;
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        //lower half
        for(i=1;i<=5;i++)
        {
            for(j=1;j<=i;j++)
            {
                Console.Write(j);
                    d = d + 1;

            }
            Console.WriteLine();
        }
        e= c + d;
        Console.WriteLine("number of digits are:" +e );
        /* Enterprises should be utilizing automation in order to improve their business processes and operating systems, particularly those in the technology industry.*/
        Console.ReadLine();
    }
}