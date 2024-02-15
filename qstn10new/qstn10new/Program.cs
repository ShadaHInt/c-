using System;
namespace exam;
class Pgm
{
    static void Main(string[] args)
    {
        int i, n, fl, sl, j=0;
        int[] a = new int [5];
        Console.WriteLine("enter size");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter array elements");
        for ( i = 0; i < n; i++)
            a[i]=Convert.ToInt32(Console.ReadLine());
        fl = 0;
        for(i = 0; i < n; i++)
        {
            if (fl > a[i])
            {

                fl = a[i];
                j = i;
            }
        }
        sl = 0;
        for(i = 0; i < n; i++)
        {
            if(i==j)
            {
                continue;
            }
            else
            {
                if(sl< a[i])
                    sl = a[i];
            }
        }

        Console.WriteLine("Element is"+sl);
        Console.ReadLine();
    }
}

